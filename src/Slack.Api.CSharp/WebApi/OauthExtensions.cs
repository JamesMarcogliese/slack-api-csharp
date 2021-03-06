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
    /// Extension methods for Oauth.
    /// </summary>
    public static partial class OauthExtensions
    {
            /// <summary>
            /// Exchanges a temporary OAuth verifier code for an access token.
            /// <see href="https://api.slack.com/methods/oauth.access" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientSecret'>
            /// Issued when you created your application.
            /// </param>
            /// <param name='code'>
            /// The `code` param returned via the OAuth callback.
            /// </param>
            /// <param name='singleChannel'>
            /// Request the user to add your app only to a single channel.
            /// </param>
            /// <param name='clientId'>
            /// Issued when you created your application.
            /// </param>
            /// <param name='redirectUri'>
            /// This must match the originally submitted URI (if one was sent).
            /// </param>
            public static AccessOKResponse Access(this IOauth operations, string clientSecret = default(string), string code = default(string), bool? singleChannel = default(bool?), string clientId = default(string), string redirectUri = default(string))
            {
                return operations.AccessAsync(clientSecret, code, singleChannel, clientId, redirectUri).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Exchanges a temporary OAuth verifier code for an access token.
            /// <see href="https://api.slack.com/methods/oauth.access" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientSecret'>
            /// Issued when you created your application.
            /// </param>
            /// <param name='code'>
            /// The `code` param returned via the OAuth callback.
            /// </param>
            /// <param name='singleChannel'>
            /// Request the user to add your app only to a single channel.
            /// </param>
            /// <param name='clientId'>
            /// Issued when you created your application.
            /// </param>
            /// <param name='redirectUri'>
            /// This must match the originally submitted URI (if one was sent).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessOKResponse> AccessAsync(this IOauth operations, string clientSecret = default(string), string code = default(string), bool? singleChannel = default(bool?), string clientId = default(string), string redirectUri = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AccessWithHttpMessagesAsync(clientSecret, code, singleChannel, clientId, redirectUri, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Exchanges a temporary OAuth verifier code for a workspace token.
            /// <see href="https://api.slack.com/methods/oauth.token" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientSecret'>
            /// Issued when you created your application.
            /// </param>
            /// <param name='code'>
            /// The `code` param returned via the OAuth callback.
            /// </param>
            /// <param name='singleChannel'>
            /// Request the user to add your app only to a single channel.
            /// </param>
            /// <param name='clientId'>
            /// Issued when you created your application.
            /// </param>
            /// <param name='redirectUri'>
            /// This must match the originally submitted URI (if one was sent).
            /// </param>
            public static TokenOKResponse Token(this IOauth operations, string clientSecret = default(string), string code = default(string), bool? singleChannel = default(bool?), string clientId = default(string), string redirectUri = default(string))
            {
                return operations.TokenAsync(clientSecret, code, singleChannel, clientId, redirectUri).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Exchanges a temporary OAuth verifier code for a workspace token.
            /// <see href="https://api.slack.com/methods/oauth.token" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientSecret'>
            /// Issued when you created your application.
            /// </param>
            /// <param name='code'>
            /// The `code` param returned via the OAuth callback.
            /// </param>
            /// <param name='singleChannel'>
            /// Request the user to add your app only to a single channel.
            /// </param>
            /// <param name='clientId'>
            /// Issued when you created your application.
            /// </param>
            /// <param name='redirectUri'>
            /// This must match the originally submitted URI (if one was sent).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TokenOKResponse> TokenAsync(this IOauth operations, string clientSecret = default(string), string code = default(string), bool? singleChannel = default(bool?), string clientId = default(string), string redirectUri = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.TokenWithHttpMessagesAsync(clientSecret, code, singleChannel, clientId, redirectUri, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
