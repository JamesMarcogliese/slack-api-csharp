# slack-api-csharp
This repository contains Slack WebAPI and wrapper EventAPI C# classes that have been auto-generated from Slack's own [slack-api-specs] repo and dev-adjusted to ensure completeness. 

You'll find a copy of the [OpenAPI specs](https://swagger.io/specification/) for the [Slack Web API](https://api.slack.com/web) and a copy of the [General Event Wrapper Schema spec](spec/EventsApi/slack_common_event_wrapper_schema.json) for the [Events API](https://api.slack.com/events-api) in the /spec folder.
### What's included
* [Web API](web-api)
    - Readily useable C# classes based off of the [OpenAPI 2.0 spec](spec/WebApi/slack_web_openapi_v2.json) - covers access token usage of public [Web API](https://api.slack.com/web) methods
* [Events API](events-api)
    - A C# class model derived from the [JSON Schema](events-api/slack_common_event_wrapper_schema.json) - covers the basic event wrapper all event types delivered by Slack

Simply import the nuget package into your project to use. 
Examples in the [wiki](https://github.com/JamesMarcogliese/slack-api-csharp/wiki).

## Installation

You should install [Slack.Api.CSharp with NuGet](https://www.nuget.org/packages/Slack.Api.CSharp/):

    Install-Package Slack.Api.CSharp

This command from Package Manager Console will download and install Slack.Api.CSharp and all required dependencies.

   [slack-api-specs]: <https://github.com/slackapi/slack-api-specs>