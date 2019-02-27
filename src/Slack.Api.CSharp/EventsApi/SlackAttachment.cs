using Newtonsoft.Json;

namespace Slack.Api.CSharp.EventsApi
{
    public partial class SlackAttachment
    {
        [JsonProperty("fallback")]
        public string Fallback { get; set; }
        [JsonProperty("color")]
        public string Color { get; set; }
        [JsonProperty("pretext")]
        public string Pretext { get; set; }
        [JsonProperty("author_name")]
        public string AuthorName { get; set; }
        [JsonProperty("author_link")]
        public string AuthorLink { get; set; }
        [JsonProperty("author_icon")]
        public string AuthorIcon { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("title_link")]
        public string TitleLink { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("fields")]
        public SlackAttachmentField[] Fields { get; set; }
        [JsonProperty("actions")]
        public SlackAttachmentAction[] Actions { get; set; }
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
        [JsonProperty("thumb_url")]
        public string ThumbUrl { get; set; }
        [JsonProperty("footer")]
        public string Footer { get; set; }
        [JsonProperty("footer_icon")]
        public string FooterIcon { get; set; }
        [JsonProperty("ts")]
        public long Ts { get; set; }
        [JsonProperty("callback_id")]
        public string CallbackId { get; set; }
    }

    public partial class SlackAttachmentField
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("short")]
        public bool Short { get; set; }
    }

    public partial class SlackAttachmentAction
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("style")]
        public string Style { get; set; }
        [JsonProperty("confirm")]
        public string Confirm { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class SlackAttachment
    {
        public static SlackAttachment FromJson(string json) => JsonConvert.DeserializeObject<SlackAttachment>(json, Converter.Settings);
    }

    public static partial class Serialize
    {
        public static string ToJson(this SlackAttachment self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

}
