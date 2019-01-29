// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Chat operations.
    /// </summary>
    public partial interface IChat
    {
        /// <summary>
        /// Deletes a message.
        /// <see href="https://api.slack.com/methods/chat.delete" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `chat:write`
        /// </param>
        /// <param name='asUser'>
        /// Pass true to delete the message as the authed user with
        /// `chat:write:user` scope. [Bot users](/bot-users) in this context
        /// are considered authed users. If unused or false, the message will
        /// be deleted with `chat:write:bot` scope.
        /// </param>
        /// <param name='ts'>
        /// Timestamp of the message to be deleted.
        /// </param>
        /// <param name='channel'>
        /// Channel containing the message to be deleted.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DeleteErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<DeleteOKResponse>> DeleteWithHttpMessagesAsync(string token = default(string), bool? asUser = default(bool?), double? ts = default(double?), string channel = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a permalink URL for a specific extant message
        /// <see href="https://api.slack.com/methods/chat.getPermalink" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `none`
        /// </param>
        /// <param name='messageTs'>
        /// A message's `ts` value, uniquely identifying it within a channel
        /// </param>
        /// <param name='channel'>
        /// The ID of the conversation or channel containing the message
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="GetPermalinkErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<GetPermalinkOKResponse>> GetPermalinkWithHttpMessagesAsync(string token = default(string), double? messageTs = default(double?), string channel = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Share a me message into a channel.
        /// <see href="https://api.slack.com/methods/chat.meMessage" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `chat:write:user`
        /// </param>
        /// <param name='text'>
        /// Text of the message to send.
        /// </param>
        /// <param name='channel'>
        /// Channel to send message to. Can be a public channel, private group
        /// or IM channel. Can be an encoded ID, or a name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="MeMessageErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<MeMessageOKResponse>> MeMessageWithHttpMessagesAsync(string token = default(string), string text = default(string), string channel = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sends an ephemeral message to a user in a channel.
        /// <see href="https://api.slack.com/methods/chat.postEphemeral" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `chat:write`
        /// </param>
        /// <param name='attachments'>
        /// A JSON-based array of structured attachments, presented as a
        /// URL-encoded string.
        /// </param>
        /// <param name='text'>
        /// Text of the message to send. See below for an explanation of
        /// [formatting](#formatting). This field is usually required, unless
        /// you're providing only `attachments` instead.
        /// </param>
        /// <param name='linkNames'>
        /// Find and link channel names and usernames.
        /// </param>
        /// <param name='parse'>
        /// Change how messages are treated. Defaults to `none`. See
        /// [below](#formatting).
        /// </param>
        /// <param name='user'>
        /// `id` of the user who will receive the ephemeral message. The user
        /// should be in the channel specified by the `channel` argument.
        /// </param>
        /// <param name='asUser'>
        /// Pass true to post the message as the authed bot. Defaults to false.
        /// </param>
        /// <param name='channel'>
        /// Channel, private group, or IM channel to send message to. Can be an
        /// encoded ID, or a name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="PostEphemeralErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<PostEphemeralOKResponse>> PostEphemeralWithHttpMessagesAsync(string token = default(string), string attachments = default(string), string text = default(string), bool? linkNames = default(bool?), string parse = default(string), string user = default(string), bool? asUser = default(bool?), string channel = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sends a message to a channel.
        /// <see href="https://api.slack.com/methods/chat.postMessage" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `chat:write`
        /// </param>
        /// <param name='username'>
        /// Set your bot's user name. Must be used in conjunction with
        /// `as_user` set to false, otherwise ignored. See
        /// [authorship](#authorship) below.
        /// </param>
        /// <param name='threadTs'>
        /// Provide another message's `ts` value to make this message a reply.
        /// Avoid using a reply's `ts` value; use its parent instead.
        /// </param>
        /// <param name='attachments'>
        /// A JSON-based array of structured attachments, presented as a
        /// URL-encoded string.
        /// </param>
        /// <param name='unfurlLinks'>
        /// Pass true to enable unfurling of primarily text-based content.
        /// </param>
        /// <param name='text'>
        /// Text of the message to send. See below for an explanation of
        /// [formatting](#formatting). This field is usually required, unless
        /// you're providing only `attachments` instead. Provide no more than
        /// 40,000 characters or [risk
        /// truncation](/changelog/2018-04-truncating-really-long-messages).
        /// </param>
        /// <param name='unfurlMedia'>
        /// Pass false to disable unfurling of media content.
        /// </param>
        /// <param name='parse'>
        /// Change how messages are treated. Defaults to `none`. See
        /// [below](#formatting).
        /// </param>
        /// <param name='asUser'>
        /// Pass true to post the message as the authed user, instead of as a
        /// bot. Defaults to false. See [authorship](#authorship) below.
        /// </param>
        /// <param name='mrkdwn'>
        /// Disable Slack markup parsing by setting to `false`. Enabled by
        /// default.
        /// </param>
        /// <param name='iconEmoji'>
        /// Emoji to use as the icon for this message. Overrides `icon_url`.
        /// Must be used in conjunction with `as_user` set to `false`,
        /// otherwise ignored. See [authorship](#authorship) below.
        /// </param>
        /// <param name='linkNames'>
        /// Find and link channel names and usernames.
        /// </param>
        /// <param name='iconUrl'>
        /// URL to an image to use as the icon for this message. Must be used
        /// in conjunction with `as_user` set to false, otherwise ignored. See
        /// [authorship](#authorship) below.
        /// </param>
        /// <param name='channel'>
        /// Channel, private group, or IM channel to send message to. Can be an
        /// encoded ID, or a name. See [below](#channels) for more details.
        /// </param>
        /// <param name='replyBroadcast'>
        /// Used in conjunction with `thread_ts` and indicates whether reply
        /// should be made visible to everyone in the channel or conversation.
        /// Defaults to `false`.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="PostMessageErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<PostMessageOKResponse>> PostMessageWithHttpMessagesAsync(string token = default(string), string username = default(string), double? threadTs = default(double?), string attachments = default(string), bool? unfurlLinks = default(bool?), string text = default(string), bool? unfurlMedia = default(bool?), string parse = default(string), bool? asUser = default(bool?), bool? mrkdwn = default(bool?), string iconEmoji = default(string), bool? linkNames = default(bool?), string iconUrl = default(string), string channel = default(string), bool? replyBroadcast = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Provide custom unfurl behavior for user-posted URLs
        /// <see href="https://api.slack.com/methods/chat.unfurl" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `links:write`
        /// </param>
        /// <param name='userAuthMessage'>
        /// Provide a simply-formatted string to send as an ephemeral message
        /// to the user as invitation to authenticate further and enable full
        /// unfurling behavior
        /// </param>
        /// <param name='userAuthRequired'>
        /// Set to `true` or `1` to indicate the user must install your Slack
        /// app to trigger unfurls for this domain
        /// </param>
        /// <param name='unfurls'>
        /// URL-encoded JSON map with keys set to URLs featured in the the
        /// message, pointing to their unfurl message attachments.
        /// </param>
        /// <param name='ts'>
        /// Timestamp of the message to add unfurl behavior to.
        /// </param>
        /// <param name='userAuthUrl'>
        /// Send users to this custom URL where they will complete
        /// authentication in your app to fully trigger unfurling. Value should
        /// be properly URL-encoded.
        /// </param>
        /// <param name='channel'>
        /// Channel ID of the message
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="UnfurlErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<UnfurlOKResponse>> UnfurlWithHttpMessagesAsync(string token = default(string), string userAuthMessage = default(string), bool? userAuthRequired = default(bool?), string unfurls = default(string), string ts = default(string), string userAuthUrl = default(string), string channel = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a message.
        /// <see href="https://api.slack.com/methods/chat.update" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `chat:write`
        /// </param>
        /// <param name='attachments'>
        /// A JSON-based array of structured attachments, presented as a
        /// URL-encoded string. This field is required when not presenting
        /// `text`.
        /// </param>
        /// <param name='text'>
        /// New text for the message, using the [default formatting
        /// rules](/docs/formatting). It's not required when presenting
        /// `attachments`.
        /// </param>
        /// <param name='ts'>
        /// Timestamp of the message to be updated.
        /// </param>
        /// <param name='parse'>
        /// Change how messages are treated. Defaults to `client`, unlike
        /// `chat.postMessage`. See [below](#formatting).
        /// </param>
        /// <param name='asUser'>
        /// Pass true to update the message as the authed user. [Bot
        /// users](/bot-users) in this context are considered authed users.
        /// </param>
        /// <param name='linkNames'>
        /// Find and link channel names and usernames. Defaults to `none`. See
        /// [below](#formatting).
        /// </param>
        /// <param name='channel'>
        /// Channel containing the message to be updated.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="UpdateErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<UpdateOKResponse>> UpdateWithHttpMessagesAsync(string token = default(string), string attachments = default(string), string text = default(string), double? ts = default(double?), string parse = default(string), bool? asUser = default(bool?), bool? linkNames = default(bool?), string channel = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}