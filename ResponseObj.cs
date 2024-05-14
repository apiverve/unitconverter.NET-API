using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class result
{
    [JsonProperty("result")]
    public double result { get; set; }

    [JsonProperty("from")]
    public string from { get; set; }

    [JsonProperty("to")]
    public string to { get; set; }

}

public class from
{
    [JsonProperty("abbr")]
    public string abbr { get; set; }

    [JsonProperty("measure")]
    public string measure { get; set; }

    [JsonProperty("system")]
    public string system { get; set; }

    [JsonProperty("singular")]
    public string singular { get; set; }

    [JsonProperty("plural")]
    public string plural { get; set; }

}

public class to
{
    [JsonProperty("abbr")]
    public string abbr { get; set; }

    [JsonProperty("measure")]
    public string measure { get; set; }

    [JsonProperty("system")]
    public string system { get; set; }

    [JsonProperty("singular")]
    public string singular { get; set; }

    [JsonProperty("plural")]
    public string plural { get; set; }

}

public class unitDefinitions
{
    [JsonProperty("from")]
    public from from { get; set; }

    [JsonProperty("to")]
    public to to { get; set; }

}

public class data
{
    [JsonProperty("result")]
    public result result { get; set; }

    [JsonProperty("unitDefinitions")]
    public unitDefinitions unitDefinitions { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
