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
    /// Files operations.
    /// </summary>
    public partial interface IFiles
    {
        /// <summary>
        /// Add a comment to an existing file.
        /// <see href="https://api.slack.com/methods/files.comments.add" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `files:write:user`
        /// </param>
        /// <param name='comment'>
        /// Text of the comment to add.
        /// </param>
        /// <param name='file'>
        /// File to add a comment to.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AddErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<AddOKResponse>> AddWithHttpMessagesAsync(string token = default(string), string comment = default(string), string file = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an existing comment on a file.
        /// <see href="https://api.slack.com/methods/files.comments.delete" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `files:write:user`
        /// </param>
        /// <param name='id'>
        /// The comment to delete.
        /// </param>
        /// <param name='file'>
        /// File to delete a comment from.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DeleteErrorModel1Exception">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<DeleteOKResponseModel>> DeleteWithHttpMessagesAsync(string token = default(string), string id = default(string), string file = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Edit an existing file comment.
        /// <see href="https://api.slack.com/methods/files.comments.edit" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `files:write:user`
        /// </param>
        /// <param name='comment'>
        /// Text of the comment to edit.
        /// </param>
        /// <param name='id'>
        /// The comment to edit.
        /// </param>
        /// <param name='file'>
        /// File containing the comment to edit.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="EditErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<EditOKResponse>> EditWithHttpMessagesAsync(string token = default(string), string comment = default(string), string id = default(string), string file = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a file.
        /// <see href="https://api.slack.com/methods/files.delete" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `files:write:user`
        /// </param>
        /// <param name='file'>
        /// ID of file to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DeleteErrorModel2Exception">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<DeleteOKResponseModelModel>> Delete1WithHttpMessagesAsync(string token = default(string), string file = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets information about a team file.
        /// <see href="https://api.slack.com/methods/files.info" />
        /// </summary>
        /// <param name='count'>
        /// </param>
        /// <param name='token'>
        /// Authentication token. Requires scope: `files:read`
        /// </param>
        /// <param name='file'>
        /// Specify a file by providing its ID.
        /// </param>
        /// <param name='page'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="InfoErrorModel4Exception">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<InfoOKResponseModelModelModelModel>> InfoWithHttpMessagesAsync(string count = default(string), string token = default(string), string file = default(string), string page = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists &amp; filters team files.
        /// <see href="https://api.slack.com/methods/files.list" />
        /// </summary>
        /// <param name='count'>
        /// </param>
        /// <param name='channel'>
        /// Filter files appearing in a specific channel, indicated by its ID.
        /// </param>
        /// <param name='tsTo'>
        /// Filter files created before this timestamp (inclusive).
        /// </param>
        /// <param name='tsFrom'>
        /// Filter files created after this timestamp (inclusive).
        /// </param>
        /// <param name='token'>
        /// Authentication token. Requires scope: `files:read`
        /// </param>
        /// <param name='user'>
        /// Filter files created by a single user.
        /// </param>
        /// <param name='page'>
        /// </param>
        /// <param name='types'>
        /// Filter files by type:
        ///
        /// * `all` - All files
        /// * `spaces` - Posts
        /// * `snippets` - Snippets
        /// * `images` - Image files
        /// * `gdocs` - Google docs
        /// * `zips` - Zip files
        /// * `pdfs` - PDF files
        ///
        /// You can pass multiple values in the types argument, like
        /// `types=spaces,snippets`.The default value is `all`, which does not
        /// filter the list.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ListErrorModel5Exception">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ListOKResponseModelModelModelModelModel>> ListWithHttpMessagesAsync(string count = default(string), string channel = default(string), int? tsTo = default(int?), int? tsFrom = default(int?), string token = default(string), string user = default(string), string page = default(string), string types = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Revokes public/external sharing access for a file
        /// <see href="https://api.slack.com/methods/files.revokePublicURL" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `files:write:user`
        /// </param>
        /// <param name='file'>
        /// File to revoke
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RevokePublicURLErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<RevokePublicURLOKResponse>> RevokePublicURLWithHttpMessagesAsync(string token = default(string), string file = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Enables a file for public/external sharing.
        /// <see href="https://api.slack.com/methods/files.sharedPublicURL" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `files:write:user`
        /// </param>
        /// <param name='file'>
        /// File to share
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="SharedPublicURLErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<SharedPublicURLOKResponse>> SharedPublicURLWithHttpMessagesAsync(string token = default(string), string file = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Uploads or creates a file.
        /// <see href="https://api.slack.com/methods/files.upload" />
        /// </summary>
        /// <param name='channels'>
        /// Comma-separated list of channel names or IDs where the file will be
        /// shared.
        /// </param>
        /// <param name='title'>
        /// Title of file.
        /// </param>
        /// <param name='initialComment'>
        /// Initial comment to add to file.
        /// </param>
        /// <param name='filetype'>
        /// A [file type](/types/file#file_types) identifier.
        /// </param>
        /// <param name='filename'>
        /// Filename of file.
        /// </param>
        /// <param name='content'>
        /// File contents via a POST variable. If omitting this parameter, you
        /// must provide a `file`.
        /// </param>
        /// <param name='token'>
        /// Authentication token. Requires scope: `files:write:user`
        /// </param>
        /// <param name='file'>
        /// File contents via `multipart/form-data`. If omitting this
        /// parameter, you must submit `content`.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="UploadErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<UploadOKResponse>> UploadWithHttpMessagesAsync(string channels = default(string), string title = default(string), string initialComment = default(string), string filetype = default(string), string filename = default(string), string content = default(string), string token = default(string), string file = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
