using System;
using Amazon.CaseStudy.Core.TestEnvironment;
using Newtonsoft.Json;

namespace Amazon.CaseStudy.Core.Data
{
	public class TestBenchConfig
	{
		[JsonProperty("login")]
		public Login Login { get; set; }

		[JsonProperty("fakeLogin")]
		public FakeLogin FakeLogin { get; set; }

		[JsonProperty("searchedItem")]
        public string SearchedItem { get; set; }

    }
}

