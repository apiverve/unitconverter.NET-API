using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Result data
    /// </summary>
    public class Result
    {
        [JsonProperty("result")]
        public double Result { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

    }
    /// <summary>
    /// From data
    /// </summary>
    public class From
    {
        [JsonProperty("abbr")]
        public string Abbr { get; set; }

        [JsonProperty("measure")]
        public string Measure { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("singular")]
        public string Singular { get; set; }

        [JsonProperty("plural")]
        public string Plural { get; set; }

    }
    /// <summary>
    /// To data
    /// </summary>
    public class To
    {
        [JsonProperty("abbr")]
        public string Abbr { get; set; }

        [JsonProperty("measure")]
        public string Measure { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("singular")]
        public string Singular { get; set; }

        [JsonProperty("plural")]
        public string Plural { get; set; }

    }
    /// <summary>
    /// UnitDefinitions data
    /// </summary>
    public class UnitDefinitions
    {
        [JsonProperty("from")]
        public From From { get; set; }

        [JsonProperty("to")]
        public To To { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("result")]
        public Result Result { get; set; }

        [JsonProperty("unitDefinitions")]
        public UnitDefinitions UnitDefinitions { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
