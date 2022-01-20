using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Mercenary
{


    public class Mercenary
    {


            /* Deployment 
           var mercenaryDeployment = new MercenaryDeployment();

           var transactionReceiptDeployment = await web3.Eth.GetContractDeploymentHandler<MercenaryDeployment>().SendRequestAndWaitForReceiptAsync(mercenaryDeployment);
           var contractAddress = transactionReceiptDeployment.ContractAddress;
            */

            /** Function: DEFAULT_ADMIN_ROLE**/
            /*
            var dEFAULT_ADMIN_ROLEFunctionReturn = await contractHandler.QueryAsync<DEFAULT_ADMIN_ROLEFunction, byte[]>();
            */


            /** Function: MINTER_ROLE**/
            /*
            var mINTER_ROLEFunctionReturn = await contractHandler.QueryAsync<MINTER_ROLEFunction, byte[]>();
            */


            /** Function: PAUSER_ROLE**/
            /*
            var pAUSER_ROLEFunctionReturn = await contractHandler.QueryAsync<PAUSER_ROLEFunction, byte[]>();
            */


            /** Function: allowance**/
            /*
            var allowanceFunction = new AllowanceFunction();
            allowanceFunction.Owner = owner;
            allowanceFunction.Spender = spender;
            var allowanceFunctionReturn = await contractHandler.QueryAsync<AllowanceFunction, BigInteger>(allowanceFunction);
            */


            /** Function: approve**/
            /*
            var approveFunction = new ApproveFunction();
            approveFunction.Spender = spender;
            approveFunction.Amount = amount;
            var approveFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(approveFunction);
            */


            /** Function: balanceOf**/
            /*
            var balanceOfFunction = new BalanceOfFunction();
            balanceOfFunction.Account = account;
            var balanceOfFunctionReturn = await contractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction);
            */


            /** Function: burn**/
            /*
            var burnFunction = new BurnFunction();
            burnFunction.Amount = amount;
            var burnFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(burnFunction);
            */


            /** Function: burnFrom**/
            /*
            var burnFromFunction = new BurnFromFunction();
            burnFromFunction.Account = account;
            burnFromFunction.Amount = amount;
            var burnFromFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(burnFromFunction);
            */


            /** Function: decimals**/
            /*
            var decimalsFunctionReturn = await contractHandler.QueryAsync<DecimalsFunction, byte>();
            */


            /** Function: decreaseAllowance**/
            /*
            var decreaseAllowanceFunction = new DecreaseAllowanceFunction();
            decreaseAllowanceFunction.Spender = spender;
            decreaseAllowanceFunction.SubtractedValue = subtractedValue;
            var decreaseAllowanceFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(decreaseAllowanceFunction);
            */


            /** Function: getRoleAdmin**/
            /*
            var getRoleAdminFunction = new GetRoleAdminFunction();
            getRoleAdminFunction.Role = role;
            var getRoleAdminFunctionReturn = await contractHandler.QueryAsync<GetRoleAdminFunction, byte[]>(getRoleAdminFunction);
            */


            /** Function: getRoleMember**/
            /*
            var getRoleMemberFunction = new GetRoleMemberFunction();
            getRoleMemberFunction.Role = role;
            getRoleMemberFunction.Index = index;
            var getRoleMemberFunctionReturn = await contractHandler.QueryAsync<GetRoleMemberFunction, string>(getRoleMemberFunction);
            */


            /** Function: getRoleMemberCount**/
            /*
            var getRoleMemberCountFunction = new GetRoleMemberCountFunction();
            getRoleMemberCountFunction.Role = role;
            var getRoleMemberCountFunctionReturn = await contractHandler.QueryAsync<GetRoleMemberCountFunction, BigInteger>(getRoleMemberCountFunction);
            */


            /** Function: grantRole**/
            /*
            var grantRoleFunction = new GrantRoleFunction();
            grantRoleFunction.Role = role;
            grantRoleFunction.Account = account;
            var grantRoleFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(grantRoleFunction);
            */


            /** Function: hasRole**/
            /*
            var hasRoleFunction = new HasRoleFunction();
            hasRoleFunction.Role = role;
            hasRoleFunction.Account = account;
            var hasRoleFunctionReturn = await contractHandler.QueryAsync<HasRoleFunction, bool>(hasRoleFunction);
            */


            /** Function: increaseAllowance**/
            /*
            var increaseAllowanceFunction = new IncreaseAllowanceFunction();
            increaseAllowanceFunction.Spender = spender;
            increaseAllowanceFunction.AddedValue = addedValue;
            var increaseAllowanceFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(increaseAllowanceFunction);
            */


            /** Function: mint**/
            /*
            var mintFunction = new MintFunction();
            mintFunction.To = to;
            mintFunction.Amount = amount;
            var mintFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(mintFunction);
            */


            /** Function: name**/
            /*
            var nameFunctionReturn = await contractHandler.QueryAsync<NameFunction, string>();
            */


            /** Function: pause**/
            /*
            var pauseFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync<PauseFunction>();
            */


            /** Function: paused**/
            /*
            var pausedFunctionReturn = await contractHandler.QueryAsync<PausedFunction, bool>();
            */


            /** Function: renounceRole**/
            /*
            var renounceRoleFunction = new RenounceRoleFunction();
            renounceRoleFunction.Role = role;
            renounceRoleFunction.Account = account;
            var renounceRoleFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(renounceRoleFunction);
            */


            /** Function: revokeRole**/
            /*
            var revokeRoleFunction = new RevokeRoleFunction();
            revokeRoleFunction.Role = role;
            revokeRoleFunction.Account = account;
            var revokeRoleFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(revokeRoleFunction);
            */


            /** Function: supportsInterface**/
            /*
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
            supportsInterfaceFunction.InterfaceId = interfaceId;
            var supportsInterfaceFunctionReturn = await contractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction);
            */


            /** Function: symbol**/
            /*
            var symbolFunctionReturn = await contractHandler.QueryAsync<SymbolFunction, string>();
            */


            /** Function: totalSupply**/
            /*
            var totalSupplyFunctionReturn = await contractHandler.QueryAsync<TotalSupplyFunction, BigInteger>();
            */


            /** Function: transfer**/
            /*
            var transferFunction = new TransferFunction();
            transferFunction.Recipient = recipient;
            transferFunction.Amount = amount;
            var transferFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(transferFunction);
            */


            /** Function: transferFrom**/
            /*
            var transferFromFunction = new TransferFromFunction();
            transferFromFunction.Sender = sender;
            transferFromFunction.Recipient = recipient;
            transferFromFunction.Amount = amount;
            var transferFromFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction);
            */


            /** Function: unpause**/
            /*
            var unpauseFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync<UnpauseFunction>();
            */

    }

    public partial class MercenaryDeployment : MercenaryDeploymentBase
    {
        public MercenaryDeployment() : base(BYTECODE) { }
        public MercenaryDeployment(string byteCode) : base(byteCode) { }
    }

    public class MercenaryDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "osef";
        public MercenaryDeploymentBase() : base(BYTECODE) { }
        public MercenaryDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class DEFAULT_ADMIN_ROLEFunction : DEFAULT_ADMIN_ROLEFunctionBase { }

    [Function("DEFAULT_ADMIN_ROLE", "bytes32")]
    public class DEFAULT_ADMIN_ROLEFunctionBase : FunctionMessage
    {

    }

    public partial class MINTER_ROLEFunction : MINTER_ROLEFunctionBase { }

    [Function("MINTER_ROLE", "bytes32")]
    public class MINTER_ROLEFunctionBase : FunctionMessage
    {

    }

    public partial class PAUSER_ROLEFunction : PAUSER_ROLEFunctionBase { }

    [Function("PAUSER_ROLE", "bytes32")]
    public class PAUSER_ROLEFunctionBase : FunctionMessage
    {

    }

    public partial class AllowanceFunction : AllowanceFunctionBase { }

    [Function("allowance", "uint256")]
    public class AllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "spender", 2)]
        public virtual string Spender { get; set; }
    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve", "bool")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class BurnFunction : BurnFunctionBase { }

    [Function("burn")]
    public class BurnFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class BurnFromFunction : BurnFromFunctionBase { }

    [Function("burnFrom")]
    public class BurnFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class DecimalsFunction : DecimalsFunctionBase { }

    [Function("decimals", "uint8")]
    public class DecimalsFunctionBase : FunctionMessage
    {

    }

    public partial class DecreaseAllowanceFunction : DecreaseAllowanceFunctionBase { }

    [Function("decreaseAllowance", "bool")]
    public class DecreaseAllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "subtractedValue", 2)]
        public virtual BigInteger SubtractedValue { get; set; }
    }

    public partial class GetRoleAdminFunction : GetRoleAdminFunctionBase { }

    [Function("getRoleAdmin", "bytes32")]
    public class GetRoleAdminFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
    }

    public partial class GetRoleMemberFunction : GetRoleMemberFunctionBase { }

    [Function("getRoleMember", "address")]
    public class GetRoleMemberFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("uint256", "index", 2)]
        public virtual BigInteger Index { get; set; }
    }

    public partial class GetRoleMemberCountFunction : GetRoleMemberCountFunctionBase { }

    [Function("getRoleMemberCount", "uint256")]
    public class GetRoleMemberCountFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
    }

    public partial class GrantRoleFunction : GrantRoleFunctionBase { }

    [Function("grantRole")]
    public class GrantRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class HasRoleFunction : HasRoleFunctionBase { }

    [Function("hasRole", "bool")]
    public class HasRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class IncreaseAllowanceFunction : IncreaseAllowanceFunctionBase { }

    [Function("increaseAllowance", "bool")]
    public class IncreaseAllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "addedValue", 2)]
        public virtual BigInteger AddedValue { get; set; }
    }

    public partial class MintFunction : MintFunctionBase { }

    [Function("mint")]
    public class MintFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

    }

    public partial class PauseFunction : PauseFunctionBase { }

    [Function("pause")]
    public class PauseFunctionBase : FunctionMessage
    {

    }

    public partial class PausedFunction : PausedFunctionBase { }

    [Function("paused", "bool")]
    public class PausedFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceRoleFunction : RenounceRoleFunctionBase { }

    [Function("renounceRole")]
    public class RenounceRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class RevokeRoleFunction : RevokeRoleFunctionBase { }

    [Function("revokeRole")]
    public class RevokeRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class SymbolFunction : SymbolFunctionBase { }

    [Function("symbol", "string")]
    public class SymbolFunctionBase : FunctionMessage
    {

    }

    public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }

    [Function("totalSupply", "uint256")]
    public class TotalSupplyFunctionBase : FunctionMessage
    {

    }

    public partial class TransferFunction : TransferFunctionBase { }

    [Function("transfer", "bool")]
    public class TransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "recipient", 1)]
        public virtual string Recipient { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom", "bool")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "sender", 1)]
        public virtual string Sender { get; set; }
        [Parameter("address", "recipient", 2)]
        public virtual string Recipient { get; set; }
        [Parameter("uint256", "amount", 3)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class UnpauseFunction : UnpauseFunctionBase { }

    [Function("unpause")]
    public class UnpauseFunctionBase : FunctionMessage
    {

    }

    public partial class ApprovalEventDTO : ApprovalEventDTOBase { }

    [Event("Approval")]
    public class ApprovalEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true)]
        public virtual string Owner { get; set; }
        [Parameter("address", "spender", 2, true)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "value", 3, false)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class PausedEventDTO : PausedEventDTOBase { }

    [Event("Paused")]
    public class PausedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, false)]
        public virtual string Account { get; set; }
    }

    public partial class RoleAdminChangedEventDTO : RoleAdminChangedEventDTOBase { }

    [Event("RoleAdminChanged")]
    public class RoleAdminChangedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true)]
        public virtual byte[] Role { get; set; }
        [Parameter("bytes32", "previousAdminRole", 2, true)]
        public virtual byte[] PreviousAdminRole { get; set; }
        [Parameter("bytes32", "newAdminRole", 3, true)]
        public virtual byte[] NewAdminRole { get; set; }
    }

    public partial class RoleGrantedEventDTO : RoleGrantedEventDTOBase { }

    [Event("RoleGranted")]
    public class RoleGrantedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2, true)]
        public virtual string Account { get; set; }
        [Parameter("address", "sender", 3, true)]
        public virtual string Sender { get; set; }
    }

    public partial class RoleRevokedEventDTO : RoleRevokedEventDTOBase { }

    [Event("RoleRevoked")]
    public class RoleRevokedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2, true)]
        public virtual string Account { get; set; }
        [Parameter("address", "sender", 3, true)]
        public virtual string Sender { get; set; }
    }

    public partial class TransferEventDTO : TransferEventDTOBase { }

    [Event("Transfer")]
    public class TransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true)]
        public virtual string To { get; set; }
        [Parameter("uint256", "value", 3, false)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class UnpausedEventDTO : UnpausedEventDTOBase { }

    [Event("Unpaused")]
    public class UnpausedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, false)]
        public virtual string Account { get; set; }
    }

    public partial class DEFAULT_ADMIN_ROLEOutputDTO : DEFAULT_ADMIN_ROLEOutputDTOBase { }

    [FunctionOutput]
    public class DEFAULT_ADMIN_ROLEOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class MINTER_ROLEOutputDTO : MINTER_ROLEOutputDTOBase { }

    [FunctionOutput]
    public class MINTER_ROLEOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class PAUSER_ROLEOutputDTO : PAUSER_ROLEOutputDTOBase { }

    [FunctionOutput]
    public class PAUSER_ROLEOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class AllowanceOutputDTO : AllowanceOutputDTOBase { }

    [FunctionOutput]
    public class AllowanceOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }





    public partial class DecimalsOutputDTO : DecimalsOutputDTOBase { }

    [FunctionOutput]
    public class DecimalsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }



    public partial class GetRoleAdminOutputDTO : GetRoleAdminOutputDTOBase { }

    [FunctionOutput]
    public class GetRoleAdminOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class GetRoleMemberOutputDTO : GetRoleMemberOutputDTOBase { }

    [FunctionOutput]
    public class GetRoleMemberOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetRoleMemberCountOutputDTO : GetRoleMemberCountOutputDTOBase { }

    [FunctionOutput]
    public class GetRoleMemberCountOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class HasRoleOutputDTO : HasRoleOutputDTOBase { }

    [FunctionOutput]
    public class HasRoleOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }





    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class PausedOutputDTO : PausedOutputDTOBase { }

    [FunctionOutput]
    public class PausedOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }





    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

    [FunctionOutput]
    public class SymbolOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }

    [FunctionOutput]
    public class TotalSupplyOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }






}
