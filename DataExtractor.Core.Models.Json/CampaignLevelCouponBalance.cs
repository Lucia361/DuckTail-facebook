using Newtonsoft.Json;

namespace DataExtractor.Core.Models.Json.GetInfoPendingJsonModel;

public class CampaignLevelCouponBalance
{
	[JsonProperty("currency")]
	public string Currency { get; set; }

	[JsonProperty("formatted_amount_no_symbol")]
	public string FormattedAmountNoSymbol { get; set; }
}
