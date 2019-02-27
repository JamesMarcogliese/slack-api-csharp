// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Slack.Api.CSharp.EventsApi;
//
//    var slackAction = SlackAction.FromJson(jsonString);

namespace Slack.Api.CSharp.EventsApi
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    public partial class SlackAction
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("actions")]
        public Action1[] Actions { get; set; }
        [JsonProperty("callback_id")]
        public string CallbackId { get; set; }
        [JsonProperty("team")]
        public Team Team { get; set; }
        [JsonProperty("channel")]
        public Channel Channel { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("action_ts")]
        public string ActionTs { get; set; }
        [JsonProperty("message_ts")]
        public string MessageTs { get; set; }
        [JsonProperty("attachment_id")]
        public string AttachmentId { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("original_message")]
        public TheActualEventAnObjectThatHappened OriginalMessage { get; set; }
        [JsonProperty("response_url")]
        public string ResponseUrl { get; set; }
    }

    public partial class Team
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("domain")]
        public string Domain { get; set; }
    }

    public partial class Channel
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Action1
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("selected_options")]
        public Selected_Options[] SelectedOptions { get; set; }
    }

    public partial class Selected_Options
    {
        [JsonProperty("value")]
        public string value { get; set; }
    }
    public partial class SlackAction
    {
        public static SlackAction FromJson(string json) => JsonConvert.DeserializeObject<SlackAction>(json, Converter.Settings);
    }

    public static partial class Serialize
    {
        public static string ToJson(this SlackAction self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
