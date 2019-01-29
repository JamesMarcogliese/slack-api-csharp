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
    /// Reactions operations.
    /// </summary>
    public partial interface IReactions
    {
        /// <summary>
        /// Adds a reaction to an item.
        /// <see href="https://api.slack.com/methods/reactions.add" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `reactions:write`
        /// </param>
        /// <param name='name'>
        /// Reaction (emoji) name.
        /// </param>
        /// <param name='fileComment'>
        /// File comment to add reaction to.
        /// </param>
        /// <param name='timestamp'>
        /// Timestamp of the message to add reaction to.
        /// </param>
        /// <param name='file'>
        /// File to add reaction to.
        /// </param>
        /// <param name='channel'>
        /// Channel where the message to add reaction to was posted.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AddErrorModel2Exception">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<AddOKResponseModelModel>> AddWithHttpMessagesAsync(string token = default(string), string name = default(string), string fileComment = default(string), double? timestamp = default(double?), string file = default(string), string channel = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets reactions for an item.
        /// <see href="https://api.slack.com/methods/reactions.get" />
        /// </summary>
        /// <param name='full'>
        /// If true always return the complete reaction list.
        /// </param>
        /// <param name='fileComment'>
        /// File comment to get reactions for.
        /// </param>
        /// <param name='timestamp'>
        /// Timestamp of the message to get reactions for.
        /// </param>
        /// <param name='token'>
        /// Authentication token. Requires scope: `reactions:read`
        /// </param>
        /// <param name='file'>
        /// File to get reactions for.
        /// </param>
        /// <param name='channel'>
        /// Channel where the message to get reactions for was posted.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="GetErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<object>> GetWithHttpMessagesAsync(bool? full = default(bool?), string fileComment = default(string), double? timestamp = default(double?), string token = default(string), string file = default(string), string channel = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists reactions made by a user.
        /// <see href="https://api.slack.com/methods/reactions.list" />
        /// </summary>
        /// <param name='count'>
        /// </param>
        /// <param name='token'>
        /// Authentication token. Requires scope: `reactions:read`
        /// </param>
        /// <param name='full'>
        /// If true always return the complete reaction list.
        /// </param>
        /// <param name='user'>
        /// Show reactions made by this user. Defaults to the authed user.
        /// </param>
        /// <param name='page'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ListErrorModel10Exception">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ListOKResponseModelModelModelModelModelModelModelModel>> ListWithHttpMessagesAsync(string count = default(string), string token = default(string), bool? full = default(bool?), string user = default(string), string page = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes a reaction from an item.
        /// <see href="https://api.slack.com/methods/reactions.remove" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `reactions:write`
        /// </param>
        /// <param name='name'>
        /// Reaction (emoji) name.
        /// </param>
        /// <param name='fileComment'>
        /// File comment to remove reaction from.
        /// </param>
        /// <param name='timestamp'>
        /// Timestamp of the message to remove reaction from.
        /// </param>
        /// <param name='file'>
        /// File to remove reaction from.
        /// </param>
        /// <param name='channel'>
        /// Channel where the message to remove reaction from was posted.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RemoveErrorModel1Exception">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<RemoveOKResponseModel>> RemoveWithHttpMessagesAsync(string token = default(string), string name = default(string), string fileComment = default(string), double? timestamp = default(double?), string file = default(string), string channel = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}