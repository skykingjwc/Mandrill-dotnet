﻿using Newtonsoft.Json;

namespace Mandrill.Models.Requests
{
  /// <summary>
  /// Base Payload class for all request going to Mandrill Servers
  /// </summary>
  public abstract class RequestBase
  {
    /// <summary>
    /// The API Key property.
    /// </summary>
    [JsonProperty("key")]
    public string Key { get; set; }
  }
}
