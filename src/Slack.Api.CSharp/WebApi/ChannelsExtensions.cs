// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Channels.
    /// </summary>
    public static partial class ChannelsExtensions
    {
            /// <summary>
            /// Archives a channel.
            /// <see href="https://api.slack.com/methods/channels.archive" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='channel'>
            /// Channel to archive
            /// </param>
            public static ArchiveOKResponse Archive(this IChannels operations, string token = default(string), string channel = default(string))
            {
                return operations.ArchiveAsync(token, channel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Archives a channel.
            /// <see href="https://api.slack.com/methods/channels.archive" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='channel'>
            /// Channel to archive
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ArchiveOKResponse> ArchiveAsync(this IChannels operations, string token = default(string), string channel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ArchiveWithHttpMessagesAsync(token, channel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a channel.
            /// <see href="https://api.slack.com/methods/channels.create" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='validate'>
            /// Whether to return errors on invalid channel name instead of modifying it to
            /// meet the specified criteria.
            /// </param>
            /// <param name='name'>
            /// Name of channel to create
            /// </param>
            public static CreateOKResponse Create(this IChannels operations, string token = default(string), bool? validate = default(bool?), string name = default(string))
            {
                return operations.CreateAsync(token, validate, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a channel.
            /// <see href="https://api.slack.com/methods/channels.create" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='validate'>
            /// Whether to return errors on invalid channel name instead of modifying it to
            /// meet the specified criteria.
            /// </param>
            /// <param name='name'>
            /// Name of channel to create
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CreateOKResponse> CreateAsync(this IChannels operations, string token = default(string), bool? validate = default(bool?), string name = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(token, validate, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Fetches history of messages and events from a channel.
            /// <see href="https://api.slack.com/methods/channels.history" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='count'>
            /// Number of messages to return, between 1 and 1000.
            /// </param>
            /// <param name='unreads'>
            /// Include `unread_count_display` in the output?
            /// </param>
            /// <param name='inclusive'>
            /// Include messages with latest or oldest timestamp in results.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:history`
            /// </param>
            /// <param name='oldest'>
            /// Start of time range of messages to include in results.
            /// </param>
            /// <param name='channel'>
            /// Channel to fetch history for.
            /// </param>
            /// <param name='latest'>
            /// End of time range of messages to include in results.
            /// </param>
            public static HistoryOKResponse History(this IChannels operations, int? count = default(int?), bool? unreads = default(bool?), bool? inclusive = default(bool?), string token = default(string), string oldest = default(string), string channel = default(string), string latest = default(string))
            {
                return operations.HistoryAsync(count, unreads, inclusive, token, oldest, channel, latest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fetches history of messages and events from a channel.
            /// <see href="https://api.slack.com/methods/channels.history" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='count'>
            /// Number of messages to return, between 1 and 1000.
            /// </param>
            /// <param name='unreads'>
            /// Include `unread_count_display` in the output?
            /// </param>
            /// <param name='inclusive'>
            /// Include messages with latest or oldest timestamp in results.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:history`
            /// </param>
            /// <param name='oldest'>
            /// Start of time range of messages to include in results.
            /// </param>
            /// <param name='channel'>
            /// Channel to fetch history for.
            /// </param>
            /// <param name='latest'>
            /// End of time range of messages to include in results.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HistoryOKResponse> HistoryAsync(this IChannels operations, int? count = default(int?), bool? unreads = default(bool?), bool? inclusive = default(bool?), string token = default(string), string oldest = default(string), string channel = default(string), string latest = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.HistoryWithHttpMessagesAsync(count, unreads, inclusive, token, oldest, channel, latest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about a channel.
            /// <see href="https://api.slack.com/methods/channels.info" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:read`
            /// </param>
            /// <param name='includeLocale'>
            /// Set this to `true` to receive the locale for this channel. Defaults to
            /// `false`
            /// </param>
            /// <param name='channel'>
            /// Channel to get info on
            /// </param>
            public static InfoOKResponseModelModel Info(this IChannels operations, string token = default(string), bool? includeLocale = default(bool?), string channel = default(string))
            {
                return operations.InfoAsync(token, includeLocale, channel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about a channel.
            /// <see href="https://api.slack.com/methods/channels.info" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:read`
            /// </param>
            /// <param name='includeLocale'>
            /// Set this to `true` to receive the locale for this channel. Defaults to
            /// `false`
            /// </param>
            /// <param name='channel'>
            /// Channel to get info on
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InfoOKResponseModelModel> InfoAsync(this IChannels operations, string token = default(string), bool? includeLocale = default(bool?), string channel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.InfoWithHttpMessagesAsync(token, includeLocale, channel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Invites a user to a channel.
            /// <see href="https://api.slack.com/methods/channels.invite" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='user'>
            /// User to invite to channel.
            /// </param>
            /// <param name='channel'>
            /// Channel to invite user to.
            /// </param>
            public static InviteOKResponse Invite(this IChannels operations, string token = default(string), string user = default(string), string channel = default(string))
            {
                return operations.InviteAsync(token, user, channel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Invites a user to a channel.
            /// <see href="https://api.slack.com/methods/channels.invite" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='user'>
            /// User to invite to channel.
            /// </param>
            /// <param name='channel'>
            /// Channel to invite user to.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InviteOKResponse> InviteAsync(this IChannels operations, string token = default(string), string user = default(string), string channel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.InviteWithHttpMessagesAsync(token, user, channel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Joins a channel, creating it if needed.
            /// <see href="https://api.slack.com/methods/channels.join" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='validate'>
            /// Whether to return errors on invalid channel name instead of modifying it to
            /// meet the specified criteria.
            /// </param>
            /// <param name='name'>
            /// Name of channel to join
            /// </param>
            public static JoinOKResponse Join(this IChannels operations, string token = default(string), bool? validate = default(bool?), string name = default(string))
            {
                return operations.JoinAsync(token, validate, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Joins a channel, creating it if needed.
            /// <see href="https://api.slack.com/methods/channels.join" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='validate'>
            /// Whether to return errors on invalid channel name instead of modifying it to
            /// meet the specified criteria.
            /// </param>
            /// <param name='name'>
            /// Name of channel to join
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JoinOKResponse> JoinAsync(this IChannels operations, string token = default(string), bool? validate = default(bool?), string name = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.JoinWithHttpMessagesAsync(token, validate, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Removes a user from a channel.
            /// <see href="https://api.slack.com/methods/channels.kick" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='user'>
            /// User to remove from channel.
            /// </param>
            /// <param name='channel'>
            /// Channel to remove user from.
            /// </param>
            public static KickOKResponse Kick(this IChannels operations, string token = default(string), string user = default(string), string channel = default(string))
            {
                return operations.KickAsync(token, user, channel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes a user from a channel.
            /// <see href="https://api.slack.com/methods/channels.kick" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='user'>
            /// User to remove from channel.
            /// </param>
            /// <param name='channel'>
            /// Channel to remove user from.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<KickOKResponse> KickAsync(this IChannels operations, string token = default(string), string user = default(string), string channel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.KickWithHttpMessagesAsync(token, user, channel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Leaves a channel.
            /// <see href="https://api.slack.com/methods/channels.leave" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='channel'>
            /// Channel to leave
            /// </param>
            public static LeaveOKResponse Leave(this IChannels operations, string token = default(string), string channel = default(string))
            {
                return operations.LeaveAsync(token, channel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Leaves a channel.
            /// <see href="https://api.slack.com/methods/channels.leave" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='channel'>
            /// Channel to leave
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LeaveOKResponse> LeaveAsync(this IChannels operations, string token = default(string), string channel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.LeaveWithHttpMessagesAsync(token, channel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all channels in a Slack team.
            /// <see href="https://api.slack.com/methods/channels.list" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='excludeMembers'>
            /// Exclude the `members` collection from each `channel`
            /// </param>
            /// <param name='cursor'>
            /// Paginate through collections of data by setting the `cursor` parameter to a
            /// `next_cursor` attribute returned by a previous request's
            /// `response_metadata`. Default value fetches the first "page" of the
            /// collection. See [pagination](/docs/pagination) for more detail.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:read`
            /// </param>
            /// <param name='limit'>
            /// The maximum number of items to return. Fewer than the requested number of
            /// items may be returned, even if the end of the users list hasn't been
            /// reached.
            /// </param>
            /// <param name='excludeArchived'>
            /// Exclude archived channels from the list
            /// </param>
            public static ListOKResponseModelModel List(this IChannels operations, bool? excludeMembers = default(bool?), string cursor = default(string), string token = default(string), int? limit = default(int?), bool? excludeArchived = default(bool?))
            {
                return operations.ListAsync(excludeMembers, cursor, token, limit, excludeArchived).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all channels in a Slack team.
            /// <see href="https://api.slack.com/methods/channels.list" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='excludeMembers'>
            /// Exclude the `members` collection from each `channel`
            /// </param>
            /// <param name='cursor'>
            /// Paginate through collections of data by setting the `cursor` parameter to a
            /// `next_cursor` attribute returned by a previous request's
            /// `response_metadata`. Default value fetches the first "page" of the
            /// collection. See [pagination](/docs/pagination) for more detail.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:read`
            /// </param>
            /// <param name='limit'>
            /// The maximum number of items to return. Fewer than the requested number of
            /// items may be returned, even if the end of the users list hasn't been
            /// reached.
            /// </param>
            /// <param name='excludeArchived'>
            /// Exclude archived channels from the list
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ListOKResponseModelModel> ListAsync(this IChannels operations, bool? excludeMembers = default(bool?), string cursor = default(string), string token = default(string), int? limit = default(int?), bool? excludeArchived = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(excludeMembers, cursor, token, limit, excludeArchived, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets the read cursor in a channel.
            /// <see href="https://api.slack.com/methods/channels.mark" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='ts'>
            /// Timestamp of the most recently seen message.
            /// </param>
            /// <param name='channel'>
            /// Channel to set reading cursor in.
            /// </param>
            public static MarkOKResponse Mark(this IChannels operations, string token = default(string), string ts = default(string), string channel = default(string))
            {
                return operations.MarkAsync(token, ts, channel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets the read cursor in a channel.
            /// <see href="https://api.slack.com/methods/channels.mark" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='ts'>
            /// Timestamp of the most recently seen message.
            /// </param>
            /// <param name='channel'>
            /// Channel to set reading cursor in.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MarkOKResponse> MarkAsync(this IChannels operations, string token = default(string), string ts = default(string), string channel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.MarkWithHttpMessagesAsync(token, ts, channel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Renames a channel.
            /// <see href="https://api.slack.com/methods/channels.rename" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='validate'>
            /// Whether to return errors on invalid channel name instead of modifying it to
            /// meet the specified criteria.
            /// </param>
            /// <param name='name'>
            /// New name for channel.
            /// </param>
            /// <param name='channel'>
            /// Channel to rename
            /// </param>
            public static RenameOKResponse Rename(this IChannels operations, string token = default(string), bool? validate = default(bool?), string name = default(string), string channel = default(string))
            {
                return operations.RenameAsync(token, validate, name, channel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Renames a channel.
            /// <see href="https://api.slack.com/methods/channels.rename" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='validate'>
            /// Whether to return errors on invalid channel name instead of modifying it to
            /// meet the specified criteria.
            /// </param>
            /// <param name='name'>
            /// New name for channel.
            /// </param>
            /// <param name='channel'>
            /// Channel to rename
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RenameOKResponse> RenameAsync(this IChannels operations, string token = default(string), bool? validate = default(bool?), string name = default(string), string channel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RenameWithHttpMessagesAsync(token, validate, name, channel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a thread of messages posted to a channel
            /// <see href="https://api.slack.com/methods/channels.replies" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='threadTs'>
            /// Unique identifier of a thread's parent message
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:history`
            /// </param>
            /// <param name='channel'>
            /// Channel to fetch thread from
            /// </param>
            public static RepliesOKResponse Replies(this IChannels operations, string threadTs = default(string), string token = default(string), string channel = default(string))
            {
                return operations.RepliesAsync(threadTs, token, channel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a thread of messages posted to a channel
            /// <see href="https://api.slack.com/methods/channels.replies" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='threadTs'>
            /// Unique identifier of a thread's parent message
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:history`
            /// </param>
            /// <param name='channel'>
            /// Channel to fetch thread from
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RepliesOKResponse> RepliesAsync(this IChannels operations, string threadTs = default(string), string token = default(string), string channel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RepliesWithHttpMessagesAsync(threadTs, token, channel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets the purpose for a channel.
            /// <see href="https://api.slack.com/methods/channels.setPurpose" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='purpose'>
            /// The new purpose
            /// </param>
            /// <param name='channel'>
            /// Channel to set the purpose of
            /// </param>
            public static SetPurposeOKResponse SetPurpose(this IChannels operations, string token = default(string), string purpose = default(string), string channel = default(string))
            {
                return operations.SetPurposeAsync(token, purpose, channel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets the purpose for a channel.
            /// <see href="https://api.slack.com/methods/channels.setPurpose" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='purpose'>
            /// The new purpose
            /// </param>
            /// <param name='channel'>
            /// Channel to set the purpose of
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SetPurposeOKResponse> SetPurposeAsync(this IChannels operations, string token = default(string), string purpose = default(string), string channel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SetPurposeWithHttpMessagesAsync(token, purpose, channel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets the topic for a channel.
            /// <see href="https://api.slack.com/methods/channels.setTopic" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='topic'>
            /// The new topic
            /// </param>
            /// <param name='channel'>
            /// Channel to set the topic of
            /// </param>
            public static SetTopicOKResponse SetTopic(this IChannels operations, string token = default(string), string topic = default(string), string channel = default(string))
            {
                return operations.SetTopicAsync(token, topic, channel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets the topic for a channel.
            /// <see href="https://api.slack.com/methods/channels.setTopic" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='topic'>
            /// The new topic
            /// </param>
            /// <param name='channel'>
            /// Channel to set the topic of
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SetTopicOKResponse> SetTopicAsync(this IChannels operations, string token = default(string), string topic = default(string), string channel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SetTopicWithHttpMessagesAsync(token, topic, channel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Unarchives a channel.
            /// <see href="https://api.slack.com/methods/channels.unarchive" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='channel'>
            /// Channel to unarchive
            /// </param>
            public static UnarchiveOKResponse Unarchive(this IChannels operations, string token = default(string), string channel = default(string))
            {
                return operations.UnarchiveAsync(token, channel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Unarchives a channel.
            /// <see href="https://api.slack.com/methods/channels.unarchive" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `channels:write`
            /// </param>
            /// <param name='channel'>
            /// Channel to unarchive
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UnarchiveOKResponse> UnarchiveAsync(this IChannels operations, string token = default(string), string channel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UnarchiveWithHttpMessagesAsync(token, channel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
