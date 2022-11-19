using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataExtractor.Core.Models.Json.GetInfoPendingJsonModel;

public class Rdfds
{
	[JsonProperty("m")]
	public List<string> M { get; set; }

	[JsonProperty("r")]
	public List<string> R { get; set; }
}
