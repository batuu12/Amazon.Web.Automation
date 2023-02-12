using System;
using Newtonsoft.Json;

namespace Amazon.CaseStudy.Core.TestEnvironment
{
	public class Login
	{
		[JsonProperty("email")]
		public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
	}
}

