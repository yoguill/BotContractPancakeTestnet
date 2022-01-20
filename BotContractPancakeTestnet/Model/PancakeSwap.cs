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

namespace PancakeSwap
{


    public class PancakeSwap
    {
        /** Function: WETH**/
        /*
        var wETHFunctionReturn = await contractHandler.QueryAsync<WETHFunction, string>();
        */


        /** Function: addLiquidity**/
        /*
        var addLiquidityFunction = new AddLiquidityFunction();
        addLiquidityFunction.TokenA = tokenA;
        addLiquidityFunction.TokenB = tokenB;
        addLiquidityFunction.AmountADesired = amountADesired;
        addLiquidityFunction.AmountBDesired = amountBDesired;
        addLiquidityFunction.AmountAMin = amountAMin;
        addLiquidityFunction.AmountBMin = amountBMin;
        addLiquidityFunction.To = to;
        addLiquidityFunction.Deadline = deadline;
        var addLiquidityFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(addLiquidityFunction);
        */


        /** Function: addLiquidityETH**/
        /*
        var addLiquidityETHFunction = new AddLiquidityETHFunction();
        addLiquidityETHFunction.Token = token;
        addLiquidityETHFunction.AmountTokenDesired = amountTokenDesired;
        addLiquidityETHFunction.AmountTokenMin = amountTokenMin;
        addLiquidityETHFunction.AmountETHMin = amountETHMin;
        addLiquidityETHFunction.To = to;
        addLiquidityETHFunction.Deadline = deadline;
        var addLiquidityETHFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(addLiquidityETHFunction);
        */


        /** Function: factory**/
        /*
        var factoryFunctionReturn = await contractHandler.QueryAsync<FactoryFunction, string>();
        */


        /** Function: getAmountIn**/
        /*
        var getAmountInFunction = new GetAmountInFunction();
        getAmountInFunction.AmountOut = amountOut;
        getAmountInFunction.ReserveIn = reserveIn;
        getAmountInFunction.ReserveOut = reserveOut;
        var getAmountInFunctionReturn = await contractHandler.QueryAsync<GetAmountInFunction, BigInteger>(getAmountInFunction);
        */


        /** Function: getAmountOut**/
        /*
        var getAmountOutFunction = new GetAmountOutFunction();
        getAmountOutFunction.AmountIn = amountIn;
        getAmountOutFunction.ReserveIn = reserveIn;
        getAmountOutFunction.ReserveOut = reserveOut;
        var getAmountOutFunctionReturn = await contractHandler.QueryAsync<GetAmountOutFunction, BigInteger>(getAmountOutFunction);
        */


        /** Function: getAmountsIn**/
        /*
        var getAmountsInFunction = new GetAmountsInFunction();
        getAmountsInFunction.AmountOut = amountOut;
        getAmountsInFunction.Path = path;
        var getAmountsInFunctionReturn = await contractHandler.QueryAsync<GetAmountsInFunction, List<BigInteger>>(getAmountsInFunction);
        */


        /** Function: getAmountsOut**/
        /*
        var getAmountsOutFunction = new GetAmountsOutFunction();
        getAmountsOutFunction.AmountIn = amountIn;
        getAmountsOutFunction.Path = path;
        var getAmountsOutFunctionReturn = await contractHandler.QueryAsync<GetAmountsOutFunction, List<BigInteger>>(getAmountsOutFunction);
        */


        /** Function: quote**/
        /*
        var quoteFunction = new QuoteFunction();
        quoteFunction.AmountA = amountA;
        quoteFunction.ReserveA = reserveA;
        quoteFunction.ReserveB = reserveB;
        var quoteFunctionReturn = await contractHandler.QueryAsync<QuoteFunction, BigInteger>(quoteFunction);
        */


        /** Function: removeLiquidity**/
        /*
        var removeLiquidityFunction = new RemoveLiquidityFunction();
        removeLiquidityFunction.TokenA = tokenA;
        removeLiquidityFunction.TokenB = tokenB;
        removeLiquidityFunction.Liquidity = liquidity;
        removeLiquidityFunction.AmountAMin = amountAMin;
        removeLiquidityFunction.AmountBMin = amountBMin;
        removeLiquidityFunction.To = to;
        removeLiquidityFunction.Deadline = deadline;
        var removeLiquidityFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(removeLiquidityFunction);
        */


        /** Function: removeLiquidityETH**/
        /*
        var removeLiquidityETHFunction = new RemoveLiquidityETHFunction();
        removeLiquidityETHFunction.Token = token;
        removeLiquidityETHFunction.Liquidity = liquidity;
        removeLiquidityETHFunction.AmountTokenMin = amountTokenMin;
        removeLiquidityETHFunction.AmountETHMin = amountETHMin;
        removeLiquidityETHFunction.To = to;
        removeLiquidityETHFunction.Deadline = deadline;
        var removeLiquidityETHFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(removeLiquidityETHFunction);
        */


        /** Function: removeLiquidityETHSupportingFeeOnTransferTokens**/
        /*
        var removeLiquidityETHSupportingFeeOnTransferTokensFunction = new RemoveLiquidityETHSupportingFeeOnTransferTokensFunction();
        removeLiquidityETHSupportingFeeOnTransferTokensFunction.Token = token;
        removeLiquidityETHSupportingFeeOnTransferTokensFunction.Liquidity = liquidity;
        removeLiquidityETHSupportingFeeOnTransferTokensFunction.AmountTokenMin = amountTokenMin;
        removeLiquidityETHSupportingFeeOnTransferTokensFunction.AmountETHMin = amountETHMin;
        removeLiquidityETHSupportingFeeOnTransferTokensFunction.To = to;
        removeLiquidityETHSupportingFeeOnTransferTokensFunction.Deadline = deadline;
        var removeLiquidityETHSupportingFeeOnTransferTokensFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(removeLiquidityETHSupportingFeeOnTransferTokensFunction);
        */


        /** Function: removeLiquidityETHWithPermit**/
        /*
        var removeLiquidityETHWithPermitFunction = new RemoveLiquidityETHWithPermitFunction();
        removeLiquidityETHWithPermitFunction.Token = token;
        removeLiquidityETHWithPermitFunction.Liquidity = liquidity;
        removeLiquidityETHWithPermitFunction.AmountTokenMin = amountTokenMin;
        removeLiquidityETHWithPermitFunction.AmountETHMin = amountETHMin;
        removeLiquidityETHWithPermitFunction.To = to;
        removeLiquidityETHWithPermitFunction.Deadline = deadline;
        removeLiquidityETHWithPermitFunction.ApproveMax = approveMax;
        removeLiquidityETHWithPermitFunction.V = v;
        removeLiquidityETHWithPermitFunction.R = r;
        removeLiquidityETHWithPermitFunction.S = s;
        var removeLiquidityETHWithPermitFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(removeLiquidityETHWithPermitFunction);
        */


        /** Function: removeLiquidityETHWithPermitSupportingFeeOnTransferTokens**/
        /*
        var removeLiquidityETHWithPermitSupportingFeeOnTransferTokensFunction = new RemoveLiquidityETHWithPermitSupportingFeeOnTransferTokensFunction();
        removeLiquidityETHWithPermitSupportingFeeOnTransferTokensFunction.Token = token;
        removeLiquidityETHWithPermitSupportingFeeOnTransferTokensFunction.Liquidity = liquidity;
        removeLiquidityETHWithPermitSupportingFeeOnTransferTokensFunction.AmountTokenMin = amountTokenMin;
        removeLiquidityETHWithPermitSupportingFeeOnTransferTokensFunction.AmountETHMin = amountETHMin;
        removeLiquidityETHWithPermitSupportingFeeOnTransferTokensFunction.To = to;
        removeLiquidityETHWithPermitSupportingFeeOnTransferTokensFunction.Deadline = deadline;
        removeLiquidityETHWithPermitSupportingFeeOnTransferTokensFunction.ApproveMax = approveMax;
        removeLiquidityETHWithPermitSupportingFeeOnTransferTokensFunction.V = v;
        removeLiquidityETHWithPermitSupportingFeeOnTransferTokensFunction.R = r;
        removeLiquidityETHWithPermitSupportingFeeOnTransferTokensFunction.S = s;
        var removeLiquidityETHWithPermitSupportingFeeOnTransferTokensFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(removeLiquidityETHWithPermitSupportingFeeOnTransferTokensFunction);
        */


        /** Function: removeLiquidityWithPermit**/
        /*
        var removeLiquidityWithPermitFunction = new RemoveLiquidityWithPermitFunction();
        removeLiquidityWithPermitFunction.TokenA = tokenA;
        removeLiquidityWithPermitFunction.TokenB = tokenB;
        removeLiquidityWithPermitFunction.Liquidity = liquidity;
        removeLiquidityWithPermitFunction.AmountAMin = amountAMin;
        removeLiquidityWithPermitFunction.AmountBMin = amountBMin;
        removeLiquidityWithPermitFunction.To = to;
        removeLiquidityWithPermitFunction.Deadline = deadline;
        removeLiquidityWithPermitFunction.ApproveMax = approveMax;
        removeLiquidityWithPermitFunction.V = v;
        removeLiquidityWithPermitFunction.R = r;
        removeLiquidityWithPermitFunction.S = s;
        var removeLiquidityWithPermitFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(removeLiquidityWithPermitFunction);
        */


        /** Function: swapETHForExactTokens**/
        /*
        var swapETHForExactTokensFunction = new SwapETHForExactTokensFunction();
        swapETHForExactTokensFunction.AmountOut = amountOut;
        swapETHForExactTokensFunction.Path = path;
        swapETHForExactTokensFunction.To = to;
        swapETHForExactTokensFunction.Deadline = deadline;
        var swapETHForExactTokensFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(swapETHForExactTokensFunction);
        */


        /** Function: swapExactETHForTokens**/
        /*
        var swapExactETHForTokensFunction = new SwapExactETHForTokensFunction();
        swapExactETHForTokensFunction.AmountOutMin = amountOutMin;
        swapExactETHForTokensFunction.Path = path;
        swapExactETHForTokensFunction.To = to;
        swapExactETHForTokensFunction.Deadline = deadline;
        var swapExactETHForTokensFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(swapExactETHForTokensFunction);
        */


        /** Function: swapExactETHForTokensSupportingFeeOnTransferTokens**/
        /*
        var swapExactETHForTokensSupportingFeeOnTransferTokensFunction = new SwapExactETHForTokensSupportingFeeOnTransferTokensFunction();
        swapExactETHForTokensSupportingFeeOnTransferTokensFunction.AmountOutMin = amountOutMin;
        swapExactETHForTokensSupportingFeeOnTransferTokensFunction.Path = path;
        swapExactETHForTokensSupportingFeeOnTransferTokensFunction.To = to;
        swapExactETHForTokensSupportingFeeOnTransferTokensFunction.Deadline = deadline;
        var swapExactETHForTokensSupportingFeeOnTransferTokensFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(swapExactETHForTokensSupportingFeeOnTransferTokensFunction);
        */


        /** Function: swapExactTokensForETH**/
        /*
        var swapExactTokensForETHFunction = new SwapExactTokensForETHFunction();
        swapExactTokensForETHFunction.AmountIn = amountIn;
        swapExactTokensForETHFunction.AmountOutMin = amountOutMin;
        swapExactTokensForETHFunction.Path = path;
        swapExactTokensForETHFunction.To = to;
        swapExactTokensForETHFunction.Deadline = deadline;
        var swapExactTokensForETHFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(swapExactTokensForETHFunction);
        */


        /** Function: swapExactTokensForETHSupportingFeeOnTransferTokens**/
        /*
        var swapExactTokensForETHSupportingFeeOnTransferTokensFunction = new SwapExactTokensForETHSupportingFeeOnTransferTokensFunction();
        swapExactTokensForETHSupportingFeeOnTransferTokensFunction.AmountIn = amountIn;
        swapExactTokensForETHSupportingFeeOnTransferTokensFunction.AmountOutMin = amountOutMin;
        swapExactTokensForETHSupportingFeeOnTransferTokensFunction.Path = path;
        swapExactTokensForETHSupportingFeeOnTransferTokensFunction.To = to;
        swapExactTokensForETHSupportingFeeOnTransferTokensFunction.Deadline = deadline;
        var swapExactTokensForETHSupportingFeeOnTransferTokensFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(swapExactTokensForETHSupportingFeeOnTransferTokensFunction);
        */


        /** Function: swapExactTokensForTokens**/
        /*
        var swapExactTokensForTokensFunction = new SwapExactTokensForTokensFunction();
        swapExactTokensForTokensFunction.AmountIn = amountIn;
        swapExactTokensForTokensFunction.AmountOutMin = amountOutMin;
        swapExactTokensForTokensFunction.Path = path;
        swapExactTokensForTokensFunction.To = to;
        swapExactTokensForTokensFunction.Deadline = deadline;
        var swapExactTokensForTokensFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(swapExactTokensForTokensFunction);
        */


        /** Function: swapExactTokensForTokensSupportingFeeOnTransferTokens**/
        /*
        var swapExactTokensForTokensSupportingFeeOnTransferTokensFunction = new SwapExactTokensForTokensSupportingFeeOnTransferTokensFunction();
        swapExactTokensForTokensSupportingFeeOnTransferTokensFunction.AmountIn = amountIn;
        swapExactTokensForTokensSupportingFeeOnTransferTokensFunction.AmountOutMin = amountOutMin;
        swapExactTokensForTokensSupportingFeeOnTransferTokensFunction.Path = path;
        swapExactTokensForTokensSupportingFeeOnTransferTokensFunction.To = to;
        swapExactTokensForTokensSupportingFeeOnTransferTokensFunction.Deadline = deadline;
        var swapExactTokensForTokensSupportingFeeOnTransferTokensFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(swapExactTokensForTokensSupportingFeeOnTransferTokensFunction);
        */


        /** Function: swapTokensForExactETH**/
        /*
        var swapTokensForExactETHFunction = new SwapTokensForExactETHFunction();
        swapTokensForExactETHFunction.AmountOut = amountOut;
        swapTokensForExactETHFunction.AmountInMax = amountInMax;
        swapTokensForExactETHFunction.Path = path;
        swapTokensForExactETHFunction.To = to;
        swapTokensForExactETHFunction.Deadline = deadline;
        var swapTokensForExactETHFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(swapTokensForExactETHFunction);
        */


        /** Function: swapTokensForExactTokens**/
        /*
        var swapTokensForExactTokensFunction = new SwapTokensForExactTokensFunction();
        swapTokensForExactTokensFunction.AmountOut = amountOut;
        swapTokensForExactTokensFunction.AmountInMax = amountInMax;
        swapTokensForExactTokensFunction.Path = path;
        swapTokensForExactTokensFunction.To = to;
        swapTokensForExactTokensFunction.Deadline = deadline;
        var swapTokensForExactTokensFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(swapTokensForExactTokensFunction);
        */
    }
        public partial class PancakeSwapDeployment : PancakeSwapDeploymentBase
        {
            public PancakeSwapDeployment() : base(BYTECODE) { }
            public PancakeSwapDeployment(string byteCode) : base(byteCode) { }
        }

        public class PancakeSwapDeploymentBase : ContractDeploymentMessage
        {
            public static string BYTECODE = "menfoupalu";
            public PancakeSwapDeploymentBase() : base(BYTECODE) { }
            public PancakeSwapDeploymentBase(string byteCode) : base(byteCode) { }
            [Parameter("address", "_factory", 1)]
            public virtual string Factory { get; set; }
            [Parameter("address", "_WETH", 2)]
            public virtual string WETH { get; set; }
        }

        public partial class WETHFunction : WETHFunctionBase { }

        [Function("WETH", "address")]
        public class WETHFunctionBase : FunctionMessage
        {

        }

        public partial class AddLiquidityFunction : AddLiquidityFunctionBase { }

        [Function("addLiquidity", typeof(AddLiquidityOutputDTO))]
        public class AddLiquidityFunctionBase : FunctionMessage
        {
            [Parameter("address", "tokenA", 1)]
            public virtual string TokenA { get; set; }
            [Parameter("address", "tokenB", 2)]
            public virtual string TokenB { get; set; }
            [Parameter("uint256", "amountADesired", 3)]
            public virtual BigInteger AmountADesired { get; set; }
            [Parameter("uint256", "amountBDesired", 4)]
            public virtual BigInteger AmountBDesired { get; set; }
            [Parameter("uint256", "amountAMin", 5)]
            public virtual BigInteger AmountAMin { get; set; }
            [Parameter("uint256", "amountBMin", 6)]
            public virtual BigInteger AmountBMin { get; set; }
            [Parameter("address", "to", 7)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 8)]
            public virtual BigInteger Deadline { get; set; }
        }

        public partial class AddLiquidityETHFunction : AddLiquidityETHFunctionBase { }

        [Function("addLiquidityETH", typeof(AddLiquidityETHOutputDTO))]
        public class AddLiquidityETHFunctionBase : FunctionMessage
        {
            [Parameter("address", "token", 1)]
            public virtual string Token { get; set; }
            [Parameter("uint256", "amountTokenDesired", 2)]
            public virtual BigInteger AmountTokenDesired { get; set; }
            [Parameter("uint256", "amountTokenMin", 3)]
            public virtual BigInteger AmountTokenMin { get; set; }
            [Parameter("uint256", "amountETHMin", 4)]
            public virtual BigInteger AmountETHMin { get; set; }
            [Parameter("address", "to", 5)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 6)]
            public virtual BigInteger Deadline { get; set; }
        }

        public partial class FactoryFunction : FactoryFunctionBase { }

        [Function("factory", "address")]
        public class FactoryFunctionBase : FunctionMessage
        {

        }

        public partial class GetAmountInFunction : GetAmountInFunctionBase { }

        [Function("getAmountIn", "uint256")]
        public class GetAmountInFunctionBase : FunctionMessage
        {
            [Parameter("uint256", "amountOut", 1)]
            public virtual BigInteger AmountOut { get; set; }
            [Parameter("uint256", "reserveIn", 2)]
            public virtual BigInteger ReserveIn { get; set; }
            [Parameter("uint256", "reserveOut", 3)]
            public virtual BigInteger ReserveOut { get; set; }
        }

        public partial class GetAmountOutFunction : GetAmountOutFunctionBase { }

        [Function("getAmountOut", "uint256")]
        public class GetAmountOutFunctionBase : FunctionMessage
        {
            [Parameter("uint256", "amountIn", 1)]
            public virtual BigInteger AmountIn { get; set; }
            [Parameter("uint256", "reserveIn", 2)]
            public virtual BigInteger ReserveIn { get; set; }
            [Parameter("uint256", "reserveOut", 3)]
            public virtual BigInteger ReserveOut { get; set; }
        }

        public partial class GetAmountsInFunction : GetAmountsInFunctionBase { }

        [Function("getAmountsIn", "uint256[]")]
        public class GetAmountsInFunctionBase : FunctionMessage
        {
            [Parameter("uint256", "amountOut", 1)]
            public virtual BigInteger AmountOut { get; set; }
            [Parameter("address[]", "path", 2)]
            public virtual List<string> Path { get; set; }
        }

        public partial class GetAmountsOutFunction : GetAmountsOutFunctionBase { }

        [Function("getAmountsOut", "uint256[]")]
        public class GetAmountsOutFunctionBase : FunctionMessage
        {
            [Parameter("uint256", "amountIn", 1)]
            public virtual BigInteger AmountIn { get; set; }
            [Parameter("address[]", "path", 2)]
            public virtual List<string> Path { get; set; }
        }

        public partial class QuoteFunction : QuoteFunctionBase { }

        [Function("quote", "uint256")]
        public class QuoteFunctionBase : FunctionMessage
        {
            [Parameter("uint256", "amountA", 1)]
            public virtual BigInteger AmountA { get; set; }
            [Parameter("uint256", "reserveA", 2)]
            public virtual BigInteger ReserveA { get; set; }
            [Parameter("uint256", "reserveB", 3)]
            public virtual BigInteger ReserveB { get; set; }
        }

        public partial class RemoveLiquidityFunction : RemoveLiquidityFunctionBase { }

        [Function("removeLiquidity", typeof(RemoveLiquidityOutputDTO))]
        public class RemoveLiquidityFunctionBase : FunctionMessage
        {
            [Parameter("address", "tokenA", 1)]
            public virtual string TokenA { get; set; }
            [Parameter("address", "tokenB", 2)]
            public virtual string TokenB { get; set; }
            [Parameter("uint256", "liquidity", 3)]
            public virtual BigInteger Liquidity { get; set; }
            [Parameter("uint256", "amountAMin", 4)]
            public virtual BigInteger AmountAMin { get; set; }
            [Parameter("uint256", "amountBMin", 5)]
            public virtual BigInteger AmountBMin { get; set; }
            [Parameter("address", "to", 6)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 7)]
            public virtual BigInteger Deadline { get; set; }
        }

        public partial class RemoveLiquidityETHFunction : RemoveLiquidityETHFunctionBase { }

        [Function("removeLiquidityETH", typeof(RemoveLiquidityETHOutputDTO))]
        public class RemoveLiquidityETHFunctionBase : FunctionMessage
        {
            [Parameter("address", "token", 1)]
            public virtual string Token { get; set; }
            [Parameter("uint256", "liquidity", 2)]
            public virtual BigInteger Liquidity { get; set; }
            [Parameter("uint256", "amountTokenMin", 3)]
            public virtual BigInteger AmountTokenMin { get; set; }
            [Parameter("uint256", "amountETHMin", 4)]
            public virtual BigInteger AmountETHMin { get; set; }
            [Parameter("address", "to", 5)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 6)]
            public virtual BigInteger Deadline { get; set; }
        }

        public partial class RemoveLiquidityETHSupportingFeeOnTransferTokensFunction : RemoveLiquidityETHSupportingFeeOnTransferTokensFunctionBase { }

        [Function("removeLiquidityETHSupportingFeeOnTransferTokens", "uint256")]
        public class RemoveLiquidityETHSupportingFeeOnTransferTokensFunctionBase : FunctionMessage
        {
            [Parameter("address", "token", 1)]
            public virtual string Token { get; set; }
            [Parameter("uint256", "liquidity", 2)]
            public virtual BigInteger Liquidity { get; set; }
            [Parameter("uint256", "amountTokenMin", 3)]
            public virtual BigInteger AmountTokenMin { get; set; }
            [Parameter("uint256", "amountETHMin", 4)]
            public virtual BigInteger AmountETHMin { get; set; }
            [Parameter("address", "to", 5)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 6)]
            public virtual BigInteger Deadline { get; set; }
        }

        public partial class RemoveLiquidityETHWithPermitFunction : RemoveLiquidityETHWithPermitFunctionBase { }

        [Function("removeLiquidityETHWithPermit", typeof(RemoveLiquidityETHWithPermitOutputDTO))]
        public class RemoveLiquidityETHWithPermitFunctionBase : FunctionMessage
        {
            [Parameter("address", "token", 1)]
            public virtual string Token { get; set; }
            [Parameter("uint256", "liquidity", 2)]
            public virtual BigInteger Liquidity { get; set; }
            [Parameter("uint256", "amountTokenMin", 3)]
            public virtual BigInteger AmountTokenMin { get; set; }
            [Parameter("uint256", "amountETHMin", 4)]
            public virtual BigInteger AmountETHMin { get; set; }
            [Parameter("address", "to", 5)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 6)]
            public virtual BigInteger Deadline { get; set; }
            [Parameter("bool", "approveMax", 7)]
            public virtual bool ApproveMax { get; set; }
            [Parameter("uint8", "v", 8)]
            public virtual byte V { get; set; }
            [Parameter("bytes32", "r", 9)]
            public virtual byte[] R { get; set; }
            [Parameter("bytes32", "s", 10)]
            public virtual byte[] S { get; set; }
        }

        public partial class RemoveLiquidityETHWithPermitSupportingFeeOnTransferTokensFunction : RemoveLiquidityETHWithPermitSupportingFeeOnTransferTokensFunctionBase { }

        [Function("removeLiquidityETHWithPermitSupportingFeeOnTransferTokens", "uint256")]
        public class RemoveLiquidityETHWithPermitSupportingFeeOnTransferTokensFunctionBase : FunctionMessage
        {
            [Parameter("address", "token", 1)]
            public virtual string Token { get; set; }
            [Parameter("uint256", "liquidity", 2)]
            public virtual BigInteger Liquidity { get; set; }
            [Parameter("uint256", "amountTokenMin", 3)]
            public virtual BigInteger AmountTokenMin { get; set; }
            [Parameter("uint256", "amountETHMin", 4)]
            public virtual BigInteger AmountETHMin { get; set; }
            [Parameter("address", "to", 5)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 6)]
            public virtual BigInteger Deadline { get; set; }
            [Parameter("bool", "approveMax", 7)]
            public virtual bool ApproveMax { get; set; }
            [Parameter("uint8", "v", 8)]
            public virtual byte V { get; set; }
            [Parameter("bytes32", "r", 9)]
            public virtual byte[] R { get; set; }
            [Parameter("bytes32", "s", 10)]
            public virtual byte[] S { get; set; }
        }

        public partial class RemoveLiquidityWithPermitFunction : RemoveLiquidityWithPermitFunctionBase { }

        [Function("removeLiquidityWithPermit", typeof(RemoveLiquidityWithPermitOutputDTO))]
        public class RemoveLiquidityWithPermitFunctionBase : FunctionMessage
        {
            [Parameter("address", "tokenA", 1)]
            public virtual string TokenA { get; set; }
            [Parameter("address", "tokenB", 2)]
            public virtual string TokenB { get; set; }
            [Parameter("uint256", "liquidity", 3)]
            public virtual BigInteger Liquidity { get; set; }
            [Parameter("uint256", "amountAMin", 4)]
            public virtual BigInteger AmountAMin { get; set; }
            [Parameter("uint256", "amountBMin", 5)]
            public virtual BigInteger AmountBMin { get; set; }
            [Parameter("address", "to", 6)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 7)]
            public virtual BigInteger Deadline { get; set; }
            [Parameter("bool", "approveMax", 8)]
            public virtual bool ApproveMax { get; set; }
            [Parameter("uint8", "v", 9)]
            public virtual byte V { get; set; }
            [Parameter("bytes32", "r", 10)]
            public virtual byte[] R { get; set; }
            [Parameter("bytes32", "s", 11)]
            public virtual byte[] S { get; set; }
        }

        public partial class SwapETHForExactTokensFunction : SwapETHForExactTokensFunctionBase { }

        [Function("swapETHForExactTokens", "uint256[]")]
        public class SwapETHForExactTokensFunctionBase : FunctionMessage
        {
            [Parameter("uint256", "amountOut", 1)]
            public virtual BigInteger AmountOut { get; set; }
            [Parameter("address[]", "path", 2)]
            public virtual List<string> Path { get; set; }
            [Parameter("address", "to", 3)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 4)]
            public virtual BigInteger Deadline { get; set; }
        }

        public partial class SwapExactETHForTokensFunction : SwapExactETHForTokensFunctionBase { }

        [Function("swapExactETHForTokens", "uint256[]")]
        public class SwapExactETHForTokensFunctionBase : FunctionMessage
        {
            [Parameter("uint256", "amountOutMin", 1)]
            public virtual BigInteger AmountOutMin { get; set; }
            [Parameter("address[]", "path", 2)]
            public virtual List<string> Path { get; set; }
            [Parameter("address", "to", 3)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 4)]
            public virtual BigInteger Deadline { get; set; }
        }

        public partial class SwapExactETHForTokensSupportingFeeOnTransferTokensFunction : SwapExactETHForTokensSupportingFeeOnTransferTokensFunctionBase { }

        [Function("swapExactETHForTokensSupportingFeeOnTransferTokens")]
        public class SwapExactETHForTokensSupportingFeeOnTransferTokensFunctionBase : FunctionMessage
        {
            [Parameter("uint256", "amountOutMin", 1)]
            public virtual BigInteger AmountOutMin { get; set; }
            [Parameter("address[]", "path", 2)]
            public virtual List<string> Path { get; set; }
            [Parameter("address", "to", 3)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 4)]
            public virtual BigInteger Deadline { get; set; }
        }

        public partial class SwapExactTokensForETHFunction : SwapExactTokensForETHFunctionBase { }

        [Function("swapExactTokensForETH", "uint256[]")]
        public class SwapExactTokensForETHFunctionBase : FunctionMessage
        {
            [Parameter("uint256", "amountIn", 1)]
            public virtual BigInteger AmountIn { get; set; }
            [Parameter("uint256", "amountOutMin", 2)]
            public virtual BigInteger AmountOutMin { get; set; }
            [Parameter("address[]", "path", 3)]
            public virtual List<string> Path { get; set; }
            [Parameter("address", "to", 4)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 5)]
            public virtual BigInteger Deadline { get; set; }
        }

        public partial class SwapExactTokensForETHSupportingFeeOnTransferTokensFunction : SwapExactTokensForETHSupportingFeeOnTransferTokensFunctionBase { }

        [Function("swapExactTokensForETHSupportingFeeOnTransferTokens")]
        public class SwapExactTokensForETHSupportingFeeOnTransferTokensFunctionBase : FunctionMessage
        {
            [Parameter("uint256", "amountIn", 1)]
            public virtual BigInteger AmountIn { get; set; }
            [Parameter("uint256", "amountOutMin", 2)]
            public virtual BigInteger AmountOutMin { get; set; }
            [Parameter("address[]", "path", 3)]
            public virtual List<string> Path { get; set; }
            [Parameter("address", "to", 4)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 5)]
            public virtual BigInteger Deadline { get; set; }
        }

        public partial class SwapExactTokensForTokensFunction : SwapExactTokensForTokensFunctionBase { }

        [Function("swapExactTokensForTokens", "uint256[]")]
        public class SwapExactTokensForTokensFunctionBase : FunctionMessage
        {
            [Parameter("uint256", "amountIn", 1)]
            public virtual BigInteger AmountIn { get; set; }
            [Parameter("uint256", "amountOutMin", 2)]
            public virtual BigInteger AmountOutMin { get; set; }
            [Parameter("address[]", "path", 3)]
            public virtual List<string> Path { get; set; }
            [Parameter("address", "to", 4)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 5)]
            public virtual BigInteger Deadline { get; set; }
        }

        public partial class SwapExactTokensForTokensSupportingFeeOnTransferTokensFunction : SwapExactTokensForTokensSupportingFeeOnTransferTokensFunctionBase { }

        [Function("swapExactTokensForTokensSupportingFeeOnTransferTokens")]
        public class SwapExactTokensForTokensSupportingFeeOnTransferTokensFunctionBase : FunctionMessage
        {
            [Parameter("uint256", "amountIn", 1)]
            public virtual BigInteger AmountIn { get; set; }
            [Parameter("uint256", "amountOutMin", 2)]
            public virtual BigInteger AmountOutMin { get; set; }
            [Parameter("address[]", "path", 3)]
            public virtual List<string> Path { get; set; }
            [Parameter("address", "to", 4)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 5)]
            public virtual BigInteger Deadline { get; set; }
        }

        public partial class SwapTokensForExactETHFunction : SwapTokensForExactETHFunctionBase { }

        [Function("swapTokensForExactETH", "uint256[]")]
        public class SwapTokensForExactETHFunctionBase : FunctionMessage
        {
            [Parameter("uint256", "amountOut", 1)]
            public virtual BigInteger AmountOut { get; set; }
            [Parameter("uint256", "amountInMax", 2)]
            public virtual BigInteger AmountInMax { get; set; }
            [Parameter("address[]", "path", 3)]
            public virtual List<string> Path { get; set; }
            [Parameter("address", "to", 4)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 5)]
            public virtual BigInteger Deadline { get; set; }
        }

        public partial class SwapTokensForExactTokensFunction : SwapTokensForExactTokensFunctionBase { }

        [Function("swapTokensForExactTokens", "uint256[]")]
        public class SwapTokensForExactTokensFunctionBase : FunctionMessage
        {
            [Parameter("uint256", "amountOut", 1)]
            public virtual BigInteger AmountOut { get; set; }
            [Parameter("uint256", "amountInMax", 2)]
            public virtual BigInteger AmountInMax { get; set; }
            [Parameter("address[]", "path", 3)]
            public virtual List<string> Path { get; set; }
            [Parameter("address", "to", 4)]
            public virtual string To { get; set; }
            [Parameter("uint256", "deadline", 5)]
            public virtual BigInteger Deadline { get; set; }
        }

        public partial class WETHOutputDTO : WETHOutputDTOBase { }

        [FunctionOutput]
        public class WETHOutputDTOBase : IFunctionOutputDTO
        {
            [Parameter("address", "", 1)]
            public virtual string ReturnValue1 { get; set; }
        }

        public partial class AddLiquidityOutputDTO : AddLiquidityOutputDTOBase { }

        [FunctionOutput]
        public class AddLiquidityOutputDTOBase : IFunctionOutputDTO
        {
            [Parameter("uint256", "amountA", 1)]
            public virtual BigInteger AmountA { get; set; }
            [Parameter("uint256", "amountB", 2)]
            public virtual BigInteger AmountB { get; set; }
            [Parameter("uint256", "liquidity", 3)]
            public virtual BigInteger Liquidity { get; set; }
        }

        public partial class AddLiquidityETHOutputDTO : AddLiquidityETHOutputDTOBase { }

        [FunctionOutput]
        public class AddLiquidityETHOutputDTOBase : IFunctionOutputDTO
        {
            [Parameter("uint256", "amountToken", 1)]
            public virtual BigInteger AmountToken { get; set; }
            [Parameter("uint256", "amountETH", 2)]
            public virtual BigInteger AmountETH { get; set; }
            [Parameter("uint256", "liquidity", 3)]
            public virtual BigInteger Liquidity { get; set; }
        }

        public partial class FactoryOutputDTO : FactoryOutputDTOBase { }

        [FunctionOutput]
        public class FactoryOutputDTOBase : IFunctionOutputDTO
        {
            [Parameter("address", "", 1)]
            public virtual string ReturnValue1 { get; set; }
        }

        public partial class GetAmountInOutputDTO : GetAmountInOutputDTOBase { }

        [FunctionOutput]
        public class GetAmountInOutputDTOBase : IFunctionOutputDTO
        {
            [Parameter("uint256", "amountIn", 1)]
            public virtual BigInteger AmountIn { get; set; }
        }

        public partial class GetAmountOutOutputDTO : GetAmountOutOutputDTOBase { }

        [FunctionOutput]
        public class GetAmountOutOutputDTOBase : IFunctionOutputDTO
        {
            [Parameter("uint256", "amountOut", 1)]
            public virtual BigInteger AmountOut { get; set; }
        }

        public partial class GetAmountsInOutputDTO : GetAmountsInOutputDTOBase { }

        [FunctionOutput]
        public class GetAmountsInOutputDTOBase : IFunctionOutputDTO
        {
            [Parameter("uint256[]", "amounts", 1)]
            public virtual List<BigInteger> Amounts { get; set; }
        }

        public partial class GetAmountsOutOutputDTO : GetAmountsOutOutputDTOBase { }

        [FunctionOutput]
        public class GetAmountsOutOutputDTOBase : IFunctionOutputDTO
        {
            [Parameter("uint256[]", "amounts", 1)]
            public virtual List<BigInteger> Amounts { get; set; }
        }

        public partial class QuoteOutputDTO : QuoteOutputDTOBase { }

        [FunctionOutput]
        public class QuoteOutputDTOBase : IFunctionOutputDTO
        {
            [Parameter("uint256", "amountB", 1)]
            public virtual BigInteger AmountB { get; set; }
        }

        public partial class RemoveLiquidityOutputDTO : RemoveLiquidityOutputDTOBase { }

        [FunctionOutput]
        public class RemoveLiquidityOutputDTOBase : IFunctionOutputDTO
        {
            [Parameter("uint256", "amountA", 1)]
            public virtual BigInteger AmountA { get; set; }
            [Parameter("uint256", "amountB", 2)]
            public virtual BigInteger AmountB { get; set; }
        }

        public partial class RemoveLiquidityETHOutputDTO : RemoveLiquidityETHOutputDTOBase { }

        [FunctionOutput]
        public class RemoveLiquidityETHOutputDTOBase : IFunctionOutputDTO
        {
            [Parameter("uint256", "amountToken", 1)]
            public virtual BigInteger AmountToken { get; set; }
            [Parameter("uint256", "amountETH", 2)]
            public virtual BigInteger AmountETH { get; set; }
        }



        public partial class RemoveLiquidityETHWithPermitOutputDTO : RemoveLiquidityETHWithPermitOutputDTOBase { }

        [FunctionOutput]
        public class RemoveLiquidityETHWithPermitOutputDTOBase : IFunctionOutputDTO
        {
            [Parameter("uint256", "amountToken", 1)]
            public virtual BigInteger AmountToken { get; set; }
            [Parameter("uint256", "amountETH", 2)]
            public virtual BigInteger AmountETH { get; set; }
        }



        public partial class RemoveLiquidityWithPermitOutputDTO : RemoveLiquidityWithPermitOutputDTOBase { }

        [FunctionOutput]
        public class RemoveLiquidityWithPermitOutputDTOBase : IFunctionOutputDTO
        {
            [Parameter("uint256", "amountA", 1)]
            public virtual BigInteger AmountA { get; set; }
            [Parameter("uint256", "amountB", 2)]
            public virtual BigInteger AmountB { get; set; }
        }
}
