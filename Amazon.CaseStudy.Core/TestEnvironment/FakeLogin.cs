using System;
using Newtonsoft.Json;

namespace Amazon.CaseStudy.Core.TestEnvironment
{
	public class FakeLogin
	{
        [JsonProperty("fakeEmail")]
        public string FakeEmail { get; set; }

        [JsonProperty("blankEmail")]
        public string BlankEmail { get; set; }

        [JsonProperty("fakePassword")]
        public string FakePassword { get; set; }

        [JsonProperty("blankPassword")]
        public string BlankPassword { get; set; }

    }
}

