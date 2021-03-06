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
    /// Usergroups operations.
    /// </summary>
    public partial interface IUsergroups
    {
        /// <summary>
        /// Create a User Group
        /// <see href="https://api.slack.com/methods/usergroups.create" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `usergroups:write`
        /// </param>
        /// <param name='handle'>
        /// A mention handle. Must be unique among channels, users and User
        /// Groups.
        /// </param>
        /// <param name='name'>
        /// A name for the User Group. Must be unique among User Groups.
        /// </param>
        /// <param name='channels'>
        /// A comma separated string of encoded channel IDs for which the User
        /// Group uses as a default.
        /// </param>
        /// <param name='includeCount'>
        /// Include the number of users in each User Group.
        /// </param>
        /// <param name='description'>
        /// A short description of the User Group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CreateErrorModel3Exception">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<CreateOKResponseModelModelModel>> CreateWithHttpMessagesAsync(string token = default(string), string handle = default(string), string name = default(string), string channels = default(string), bool? includeCount = default(bool?), string description = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Disable an existing User Group
        /// <see href="https://api.slack.com/methods/usergroups.disable" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `usergroups:write`
        /// </param>
        /// <param name='includeCount'>
        /// Include the number of users in the User Group.
        /// </param>
        /// <param name='usergroup'>
        /// The encoded ID of the User Group to disable.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DisableErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<DisableOKResponse>> DisableWithHttpMessagesAsync(string token = default(string), bool? includeCount = default(bool?), string usergroup = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Enable a User Group
        /// <see href="https://api.slack.com/methods/usergroups.enable" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `usergroups:write`
        /// </param>
        /// <param name='includeCount'>
        /// Include the number of users in the User Group.
        /// </param>
        /// <param name='usergroup'>
        /// The encoded ID of the User Group to enable.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="EnableErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<EnableOKResponse>> EnableWithHttpMessagesAsync(string token = default(string), bool? includeCount = default(bool?), string usergroup = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all User Groups for a team
        /// <see href="https://api.slack.com/methods/usergroups.list" />
        /// </summary>
        /// <param name='includeUsers'>
        /// Include the list of users for each User Group.
        /// </param>
        /// <param name='token'>
        /// Authentication token. Requires scope: `usergroups:read`
        /// </param>
        /// <param name='includeCount'>
        /// Include the number of users in each User Group.
        /// </param>
        /// <param name='includeDisabled'>
        /// Include disabled User Groups.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ListErrorModel13Exception">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ListOKResponseModelModelModelModel>> ListWithHttpMessagesAsync(bool? includeUsers = default(bool?), string token = default(string), bool? includeCount = default(bool?), bool? includeDisabled = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update an existing User Group
        /// <see href="https://api.slack.com/methods/usergroups.update" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `usergroups:write`
        /// </param>
        /// <param name='handle'>
        /// A mention handle. Must be unique among channels, users and User
        /// Groups.
        /// </param>
        /// <param name='description'>
        /// A short description of the User Group.
        /// </param>
        /// <param name='channels'>
        /// A comma separated string of encoded channel IDs for which the User
        /// Group uses as a default.
        /// </param>
        /// <param name='includeCount'>
        /// Include the number of users in the User Group.
        /// </param>
        /// <param name='usergroup'>
        /// The encoded ID of the User Group to update.
        /// </param>
        /// <param name='name'>
        /// A name for the User Group. Must be unique among User Groups.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="UpdateErrorModel1Exception">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<UpdateOKResponseModel>> UpdateWithHttpMessagesAsync(string token = default(string), string handle = default(string), string description = default(string), string channels = default(string), bool? includeCount = default(bool?), string usergroup = default(string), string name = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all users in a User Group
        /// <see href="https://api.slack.com/methods/usergroups.users.list" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `usergroups:read`
        /// </param>
        /// <param name='includeDisabled'>
        /// Allow results that involve disabled User Groups.
        /// </param>
        /// <param name='usergroup'>
        /// The encoded ID of the User Group to update.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ListErrorModel14Exception">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ListOKResponseModelModelModelModel>> List1WithHttpMessagesAsync(string token = default(string), bool? includeDisabled = default(bool?), string usergroup = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update the list of users for a User Group
        /// <see href="https://api.slack.com/methods/usergroups.users.update" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `usergroups:write`
        /// </param>
        /// <param name='includeCount'>
        /// Include the number of users in the User Group.
        /// </param>
        /// <param name='users'>
        /// A comma separated string of encoded user IDs that represent the
        /// entire list of users for the User Group.
        /// </param>
        /// <param name='usergroup'>
        /// The encoded ID of the User Group to update.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="UpdateErrorModel2Exception">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<UpdateOKResponseModel>> Update1WithHttpMessagesAsync(string token = default(string), bool? includeCount = default(bool?), string users = default(string), string usergroup = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
