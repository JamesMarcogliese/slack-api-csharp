// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// conversations.open error schema
    /// </summary>
    /// <remarks>
    /// Schema for error response from conversations.open method
    /// </remarks>
    public partial class OpenErrorModel
    {
        /// <summary>
        /// Initializes a new instance of the OpenErrorModel class.
        /// </summary>
        public OpenErrorModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OpenErrorModel class.
        /// </summary>
        /// <param name="error">Possible values include:
        /// 'method_not_supported_for_channel_type', 'user_not_found',
        /// 'user_not_visible', 'user_disabled', 'users_list_not_supplied',
        /// 'not_enough_users', 'too_many_users', 'not_authed', 'invalid_auth',
        /// 'account_inactive', 'invalid_arg_name', 'invalid_array_arg',
        /// 'invalid_charset', 'invalid_form_data', 'invalid_post_type',
        /// 'missing_post_type', 'team_added_to_org', 'invalid_json',
        /// 'json_not_object', 'request_timeout', 'upgrade_required',
        /// 'channel_not_found'</param>
        public OpenErrorModel(string error)
        {
            Error = error;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for OpenErrorModel class.
        /// </summary>
        static OpenErrorModel()
        {
            Ok = false;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include:
        /// 'method_not_supported_for_channel_type', 'user_not_found',
        /// 'user_not_visible', 'user_disabled', 'users_list_not_supplied',
        /// 'not_enough_users', 'too_many_users', 'not_authed', 'invalid_auth',
        /// 'account_inactive', 'invalid_arg_name', 'invalid_array_arg',
        /// 'invalid_charset', 'invalid_form_data', 'invalid_post_type',
        /// 'missing_post_type', 'team_added_to_org', 'invalid_json',
        /// 'json_not_object', 'request_timeout', 'upgrade_required',
        /// 'channel_not_found'
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ok")]
        public static bool Ok { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Error == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Error");
            }
        }
    }
}