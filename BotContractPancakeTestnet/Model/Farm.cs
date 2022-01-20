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

namespace BotContract.Contract
{


    public class Farmer 
    {
    /** Function: craft**/
    /*
    var craftFunction = new CraftFunction();
    craftFunction.RecipeAddress = recipeAddress;
    craftFunction.Amount = amount;
    var craftFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(craftFunction);
    */


    /** Function: createFarm**/
    /*
    var createFarmFunction = new CreateFarmFunction();
    createFarmFunction.Charity = charity;
    var createFarmFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(createFarmFunction);
    */


    /** Function: createRecipe**/
    /*
    var createRecipeFunction = new CreateRecipeFunction();
    createRecipeFunction.TokenAddress = tokenAddress;
    createRecipeFunction.Costs = costs;
    var createRecipeFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(createRecipeFunction);
    */


    /** Function: createResource**/
    /*
    var createResourceFunction = new CreateResourceFunction();
    createResourceFunction.ResourceAddress = resourceAddress;
    createResourceFunction.Requires = requires;
    var createResourceFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(createResourceFunction);
    */


    /** Function: getFarm**/
    /*
    var getFarmFunction = new GetFarmFunction(); 
    getFarmFunction.Account = account;
    var getFarmOutputDTO = await contractHandler.QueryDeserializingToObjectAsync<GetFarmFunction, GetFarmOutputDTO>(getFarmFunction);
    */


    /** Function: getFarmCount**/
    /*
    var getFarmCountFunctionReturn = await contractHandler.QueryAsync<GetFarmCountFunction, BigInteger>();
    */


    /** Function: getItemBalance**/
    /*
    var getItemBalanceFunction = new GetItemBalanceFunction();
    getItemBalanceFunction.ItemAddress = itemAddress;
    var getItemBalanceFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(getItemBalanceFunction);
    */


    /** Function: getLand**/
    /*
    var getLandFunction = new GetLandFunction(); 
    getLandFunction.Owner = owner;
    var getLandOutputDTO = await contractHandler.QueryDeserializingToObjectAsync<GetLandFunction, GetLandOutputDTO>(getLandFunction);
    */


    /** Function: getMarketPrice**/
    /*
    var getMarketPriceFunction = new GetMarketPriceFunction();
    getMarketPriceFunction.Price = price;
    var getMarketPriceFunctionReturn = await contractHandler.QueryAsync<GetMarketPriceFunction, BigInteger>(getMarketPriceFunction);
    */


    /** Function: getRecipe**/
    /*
    var getRecipeFunction = new GetRecipeFunction(); 
    getRecipeFunction.RecipeAddress = recipeAddress;
    var getRecipeOutputDTO = await contractHandler.QueryDeserializingToObjectAsync<GetRecipeFunction, GetRecipeOutputDTO>(getRecipeFunction);
    */


    /** Function: getResource**/
    /*
    var getResourceFunction = new GetResourceFunction();
    getResourceFunction.ResourceAddress = resourceAddress;
    var getResourceFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(getResourceFunction);
    */


    /** Function: levelUp**/
    /*
    var levelUpFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync<LevelUpFunction>();
    */


    /** Function: mintNFT**/
    /*
    var mintNFTFunction = new MintNFTFunction();
    mintNFTFunction.RecipeAddress = recipeAddress;
    mintNFTFunction.TokenId = tokenId;
    var mintNFTFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(mintNFTFunction);
    */


    /** Function: myReward**/
    /*
    var myRewardFunctionReturn = await contractHandler.QueryAsync<MyRewardFunction, BigInteger>();
    */


    /** Function: receiveReward**/
    /*
    var receiveRewardFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync<ReceiveRewardFunction>();
    */


    /** Function: stake**/
    /*
    var stakeFunction = new StakeFunction();
    stakeFunction.ResourceAddress = resourceAddress;
    stakeFunction.Amount = amount;
    var stakeFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(stakeFunction);
    */


    /** Function: sync**/
    /*
    var syncFunction = new SyncFunction();
    syncFunction.Events = events;
    var syncFunctionTxnReceipt = await contractHandler.SendRequestAndWaitForReceiptAsync(syncFunction);
    */
[Parameter("address", "_token", 1)]
public virtual string Token { get; set; }
[Parameter("tuple[]", "farms", 2)]
public virtual List<V1Farm> Farms { get; set; }
    }

    public partial class CraftFunction : CraftFunctionBase { }

[Function("craft")]
public class CraftFunctionBase : FunctionMessage
{
    [Parameter("address", "recipeAddress", 1)]
    public virtual string RecipeAddress { get; set; }
    [Parameter("uint256", "amount", 2)]
    public virtual BigInteger Amount { get; set; }
}

public partial class CreateFarmFunction : CreateFarmFunctionBase { }

[Function("createFarm")]
public class CreateFarmFunctionBase : FunctionMessage
{
    [Parameter("address", "_charity", 1)]
    public virtual string Charity { get; set; }
}

public partial class CreateRecipeFunction : CreateRecipeFunctionBase { }

[Function("createRecipe")]
public class CreateRecipeFunctionBase : FunctionMessage
{
    [Parameter("address", "tokenAddress", 1)]
    public virtual string TokenAddress { get; set; }
    [Parameter("tuple[]", "costs", 2)]
    public virtual List<Cost> Costs { get; set; }
}

public partial class CreateResourceFunction : CreateResourceFunctionBase { }

[Function("createResource")]
public class CreateResourceFunctionBase : FunctionMessage
{
    [Parameter("address", "resourceAddress", 1)]
    public virtual string ResourceAddress { get; set; }
    [Parameter("address", "requires", 2)]
    public virtual string Requires { get; set; }
}

public partial class GetFarmFunction : GetFarmFunctionBase { }

[Function("getFarm", typeof(GetFarmOutputDTO))]
public class GetFarmFunctionBase : FunctionMessage
{
    [Parameter("address", "account", 1)]
    public virtual string Account { get; set; }
}

public partial class GetFarmCountFunction : GetFarmCountFunctionBase { }

[Function("getFarmCount", "uint256")]
public class GetFarmCountFunctionBase : FunctionMessage
{

}

public partial class GetItemBalanceFunction : GetItemBalanceFunctionBase { }

[Function("getItemBalance", "uint256")]
public class GetItemBalanceFunctionBase : FunctionMessage
{
    [Parameter("address", "itemAddress", 1)]
    public virtual string ItemAddress { get; set; }
}

public partial class GetLandFunction : GetLandFunctionBase { }

[Function("getLand", typeof(GetLandOutputDTO))]
public class GetLandFunctionBase : FunctionMessage
{
    [Parameter("address", "owner", 1)]
    public virtual string Owner { get; set; }
}

public partial class GetMarketPriceFunction : GetMarketPriceFunctionBase { }

[Function("getMarketPrice", "uint256")]
public class GetMarketPriceFunctionBase : FunctionMessage
{
    [Parameter("uint256", "price", 1)]
    public virtual BigInteger Price { get; set; }
}

public partial class GetRecipeFunction : GetRecipeFunctionBase { }

[Function("getRecipe", typeof(GetRecipeOutputDTO))]
public class GetRecipeFunctionBase : FunctionMessage
{
    [Parameter("address", "recipeAddress", 1)]
    public virtual string RecipeAddress { get; set; }
}

public partial class GetResourceFunction : GetResourceFunctionBase { }

[Function("getResource", typeof(GetResourceOutputDTO))]
public class GetResourceFunctionBase : FunctionMessage
{
    [Parameter("address", "resourceAddress", 1)]
    public virtual string ResourceAddress { get; set; }
}

public partial class LevelUpFunction : LevelUpFunctionBase { }

[Function("levelUp")]
public class LevelUpFunctionBase : FunctionMessage
{

}

public partial class MintNFTFunction : MintNFTFunctionBase { }

[Function("mintNFT")]
public class MintNFTFunctionBase : FunctionMessage
{
    [Parameter("address", "recipeAddress", 1)]
    public virtual string RecipeAddress { get; set; }
    [Parameter("uint256", "tokenId", 2)]
    public virtual BigInteger TokenId { get; set; }
}

public partial class MyRewardFunction : MyRewardFunctionBase { }

[Function("myReward", "uint256")]
public class MyRewardFunctionBase : FunctionMessage
{

}

public partial class ReceiveRewardFunction : ReceiveRewardFunctionBase { }

[Function("receiveReward")]
public class ReceiveRewardFunctionBase : FunctionMessage
{

}

public partial class StakeFunction : StakeFunctionBase { }

[Function("stake")]
public class StakeFunctionBase : FunctionMessage
{
    [Parameter("address", "resourceAddress", 1)]
    public virtual string ResourceAddress { get; set; }
    [Parameter("uint256", "amount", 2)]
    public virtual BigInteger Amount { get; set; }
}

public partial class SyncFunction : SyncFunctionBase { }

[Function("sync", typeof(SyncOutputDTO))]
public class SyncFunctionBase : FunctionMessage
{
    [Parameter("tuple[]", "_events", 1)]
    public virtual List<Event> Events { get; set; }
}

public partial class FarmCreatedEventDTO : FarmCreatedEventDTOBase { }

[Event("FarmCreated")]
public class FarmCreatedEventDTOBase : IEventDTO
{
    [Parameter("address", "_address", 1, true)]
    public virtual string Address { get; set; }
}

public partial class FarmSyncedEventDTO : FarmSyncedEventDTOBase { }

[Event("FarmSynced")]
public class FarmSyncedEventDTOBase : IEventDTO
{
    [Parameter("address", "_address", 1, true)]
    public virtual string Address { get; set; }
}

public partial class ItemCraftedEventDTO : ItemCraftedEventDTOBase { }

[Event("ItemCrafted")]
public class ItemCraftedEventDTOBase : IEventDTO
{
    [Parameter("address", "_address", 1, true)]
    public virtual string Address { get; set; }
    [Parameter("address", "_item", 2, false)]
    public virtual string Item { get; set; }
}









public partial class GetFarmOutputDTO : GetFarmOutputDTOBase { }

[FunctionOutput]
public class GetFarmOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("tuple[]", "farm", 1)]
    public virtual List<Square> Farm { get; set; }
}

public partial class GetFarmCountOutputDTO : GetFarmCountOutputDTOBase { }

[FunctionOutput]
public class GetFarmCountOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("uint256", "count", 1)]
    public virtual BigInteger Count { get; set; }
}



public partial class GetLandOutputDTO : GetLandOutputDTOBase { }

[FunctionOutput]
public class GetLandOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("tuple[]", "", 1)]
    public virtual List<Square> ReturnValue1 { get; set; }
}

public partial class GetMarketPriceOutputDTO : GetMarketPriceOutputDTOBase { }

[FunctionOutput]
public class GetMarketPriceOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("uint256", "conversion", 1)]
    public virtual BigInteger Conversion { get; set; }
}

public partial class GetRecipeOutputDTO : GetRecipeOutputDTOBase { }

[FunctionOutput]
public class GetRecipeOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("tuple", "recipe", 1)]
    public virtual Recipe Recipe { get; set; }
}

public partial class GetResourceOutputDTO : GetResourceOutputDTOBase { }

[FunctionOutput]
public class GetResourceOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("tuple", "resource", 1)]
    public virtual StakedResource Resource { get; set; }
}





public partial class MyRewardOutputDTO : MyRewardOutputDTOBase { }

[FunctionOutput]
public class MyRewardOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("uint256", "amount", 1)]
    public virtual BigInteger Amount { get; set; }
}





public partial class SyncOutputDTO : SyncOutputDTOBase { }

[FunctionOutput]
public class SyncOutputDTOBase : IFunctionOutputDTO
{
    [Parameter("tuple", "", 1)]
    public virtual Farm ReturnValue1 { get; set; }
}

public partial class V1Farm : V1FarmBase { }

public class V1FarmBase
{
    [Parameter("address", "account", 1)]
    public virtual string Account { get; set; }
    [Parameter("uint256", "tokenAmount", 2)]
    public virtual BigInteger TokenAmount { get; set; }
    [Parameter("uint256", "size", 3)]
    public virtual BigInteger Size { get; set; }
    [Parameter("uint8", "fruit", 4)]
    public virtual byte Fruit { get; set; }
}

public partial class Cost : CostBase { }

public class CostBase
{
    [Parameter("address", "materialAddress", 1)]
    public virtual string MaterialAddress { get; set; }
    [Parameter("uint256", "amount", 2)]
    public virtual BigInteger Amount { get; set; }
}

public partial class Square : SquareBase { }

public class SquareBase
{
    [Parameter("uint8", "fruit", 1)]
    public virtual byte Fruit { get; set; }
    [Parameter("uint256", "createdAt", 2)]
    public virtual BigInteger CreatedAt { get; set; }
}

public partial class Recipe : RecipeBase { }

public class RecipeBase
{
    [Parameter("address", "outputAddress", 1)]
    public virtual string OutputAddress { get; set; }
    [Parameter("tuple[]", "costs", 2)]
    public virtual List<Cost> Costs { get; set; }
}

public partial class StakedResource : StakedResourceBase { }

public class StakedResourceBase
{
    [Parameter("uint256", "balance", 1)]
    public virtual BigInteger Balance { get; set; }
    [Parameter("uint256", "staked", 2)]
    public virtual BigInteger Staked { get; set; }
}

public partial class Farm : FarmBase { }

public class FarmBase
{
    [Parameter("tuple[]", "land", 1)]
    public virtual List<Square> Land { get; set; }
    [Parameter("uint256", "balance", 2)]
    public virtual BigInteger Balance { get; set; }
}

public partial class Event : EventBase { }

public class EventBase
{
    [Parameter("uint8", "action", 1)]
    public virtual byte Action { get; set; }
    [Parameter("uint8", "fruit", 2)]
    public virtual byte Fruit { get; set; }
    [Parameter("uint256", "landIndex", 3)]
    public virtual BigInteger LandIndex { get; set; }
    [Parameter("uint256", "createdAt", 4)]
    public virtual BigInteger CreatedAt { get; set; }
}
}
