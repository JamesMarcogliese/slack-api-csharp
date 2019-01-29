// Additions to the Auto-Generated SlackEvent_Generated class
//


namespace Slack.Api.CSharp.EventsApi
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Adapted from auto-generated content
    /// </summary>
    public partial class SlackEvent
    {
        [JsonProperty("challenge")]
        public string Challenge { get; set; }
    }

    public partial class TheActualEventAnObjectThatHappened
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("channel")]
        public string Channel { get; set; }
        [JsonProperty("ts")]
        public string Ts { get; set; }
        [JsonProperty("channel_type")]
        public string ChannelType { get; set; }
        [JsonProperty("subtype")]
        public string SubType { get; set; }
        [JsonProperty("bot_id")]
        public string BotId { get; set; }
    }

}