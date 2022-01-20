using System;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Util;
using Nethereum.Web3;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Linq;
using BotContract.Model;
using BotContract.Contract;
using Mercenary;
using PancakeSwap;
using NBitcoin;
//https://bscscan.com/tx/0x8c3ca4262d9451994aa985f848dcc39ade682b21b05c55b1b3fcba4cf93ee2ac#eventlog
//https://testnet.bscscan.com/tx/0x6912bb9848e2baf3a0937d77799584d716dbfe73ed57ac9d4ac21d0bd484e936
//https://bscscan.com/tx/0x78f7b944299940762090d884acdb60eec9b835bf7c27d913af1f7d8e4707c0a6 // approve contrat
//https://bscscan.com/tx/0x12cab738d1634490b7b06aa99d4a16f416e88cbbd7016e827d73e3984afe5624 // ou peut etre celui la le approve

internal class Program
{
    static async Task Main(string[] args)

    {

        //------------------------------BNB TO BUSD TESTNET-------------------------

        //Valeur a acheter 
        int dollars = 52;
        double valeurbnb = 0.2;//ne pas hesiter a mettre + la différence est remboursé
        int gazMultiplicateur = 15;//a up pour mettre plus de gaz a disposition

        //Contrats
        var contractAdressPancakeRouter = ConfigurationManager.AppSettings["ContractPancakeTestnet"];

        //Connexion Reseau
        var chainId = ConfigurationManager.AppSettings["ChainIdBSCTestnet"];
        var adressRPC = ConfigurationManager.AppSettings["AdresseRpcBSCTestnet"];

        //Token
        string wbnbtokenadress = ConfigurationManager.AppSettings["ContractTokenWBNBTestNet"];
        string DAItokenadress = ConfigurationManager.AppSettings["ContractTokenDAITestNet"];
        string USDTtokenadress = ConfigurationManager.AppSettings["ContractTokenUSDTTestNet"];
        string busdtokenadress = ConfigurationManager.AppSettings["ContractTokenBUSDTestNet"];

        //Wallet
        var wallets = await Wallet.getAllWalletsAsync();
        Console.WriteLine(wallets.Count + " WALLETS READY TO BE USE");
        var accountAdress = wallets[0].AccountAdress;
        var privateKey = wallets[0].PrivateKey;

        //définition du web3 de tous les wallets
        var account = new Nethereum.Web3.Accounts.Account(privateKey, Int32.Parse((chainId)));
        var web3Rpc = new Web3(account, adressRPC);

        //Definition parametre pour fonction pancakeswaptestnet
        List<string> address = new() { wbnbtokenadress, DAItokenadress, USDTtokenadress, busdtokenadress };
        BigInteger deadline = DateTimeOffset.Now.AddMinutes(15).ToUnixTimeSeconds();

        //Calculer les gaz
        var GasPrice = await web3Rpc.Eth.GasPrice.SendRequestAsync();


        BigInteger Gas = await GetGas(web3Rpc, accountAdress, address, GasPrice, gazMultiplicateur);

        //savoir combien on va avoir de token      
        var amountOUT = Nethereum.Web3.Web3.Convert.ToWei(dollars);
        var AmountToSend = Nethereum.Web3.Web3.Convert.ToWei(valeurbnb);

        Console.WriteLine("TRYING");
        var Request = new SwapETHForExactTokensFunction
        {
            GasPrice = GasPrice,
            Gas = Gas,
            AmountOut = amountOUT,
            AmountToSend = AmountToSend,
            Path = address,
            To = accountAdress,
            Deadline = deadline

        };

        //Execution de la requete
        var contractHandler = web3Rpc.Eth.GetContractHandler(contractAdressPancakeRouter);
        var resulta = await contractHandler.SendRequestAndWaitForReceiptAsync(Request);

        Console.WriteLine("Request SUCCESS");
    }
    private static async Task<BigInteger> GetGas(Web3 web3, string From, List<string> To, HexBigInteger gasPrice, int multiplicateur)
    {
        BigInteger gasLimit;
        gasLimit = await SendTransac(web3, From, To[0], gasPrice);
        gasLimit = gasLimit * multiplicateur;
        return gasLimit;
    }

    private static async Task<BigInteger> SendTransac(Web3 web3, string From, string To, HexBigInteger gasPrice)
    {
        var transfer = new CallInput()
        {
            From = From,
            To = To,
            GasPrice = gasPrice
        };


        return await web3.Eth.Transactions.EstimateGas.SendRequestAsync(transfer);
    }
}

