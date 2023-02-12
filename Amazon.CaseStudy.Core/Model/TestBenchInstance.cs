using System;
using System.IO;
using System.Reflection;
using Amazon.CaseStudy.Core.Data;
using Newtonsoft.Json;

namespace Amazon.CaseStudy.Core.Model
{
	public class TestBenchInstance : TestBenchConfig
	{
        private static readonly TestBenchInstance instance = new TestBenchInstance();

        static TestBenchInstance()
        {
        }

        private TestBenchInstance() : base()
        {
           
                string TestBenchjson = File.ReadAllText("/Users/batuhancanci/Desktop/CodeTrainings/Amazon.CaseStudy/Amazon.CaseStudy.Core/Testbench.json");
                var obj = JsonConvert.DeserializeObject<TestBenchConfig>(TestBenchjson);
                foreach (PropertyInfo property in typeof(TestBenchConfig).GetProperties())
                {
                    if (property.CanWrite)
                    {
                        property.SetValue(this, property.GetValue(obj, null), null);
                    }
                }
            
        }

        public static TestBenchInstance TestBench
        {
            get
            {
                return instance;
            }
        }

    }
}

