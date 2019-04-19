namespace Slack.Api.CSharp.EventsApi
{
	using System;
	using System.Collections.Generic;

	using System.Globalization;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;
	public partial class SlackMessage
	{
		[JsonProperty("text")]
		public string Text { get; set; }
		[JsonProperty("blocks")]
		public SlackBlock[] Blocks { get; set; }
		[JsonProperty("attachments")]
		public SlackAttachment[] Attachments { get; set; }
		[JsonProperty("thread_ts")]
		public string Thread_TS { get; set; }
		[JsonProperty("mrkdwn")]
		public bool Mrkdwn { get; set; }
		[JsonProperty("ts")]
		private string TS { set { Thread_TS = value; } }
		[JsonProperty("type")]
		public string Type { get; set; }
		[JsonProperty("subtype")]
		public string SubType { get; set; }
		[JsonProperty("username")]
		public string UserName { get; set; }
		[JsonProperty("bot_id")]
		public string Bot_ID { get; set; }
	}
}
