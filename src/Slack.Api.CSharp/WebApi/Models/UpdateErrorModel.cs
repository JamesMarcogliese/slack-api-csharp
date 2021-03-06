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
    /// chat.update error schema
    /// </summary>
    /// <remarks>
    /// Schema for error response chat.update method
    /// </remarks>
    public partial class UpdateErrorModel
    {
        /// <summary>
        /// Initializes a new instance of the UpdateErrorModel class.
        /// </summary>
        public UpdateErrorModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateErrorModel class.
        /// </summary>
        /// <param name="error">Possible values include: 'message_not_found',
        /// 'cant_update_message', 'channel_not_found', 'edit_window_closed',
        /// 'msg_too_long', 'too_many_attachments', 'rate_limited', 'no_text',
        /// 'not_authed', 'invalid_auth', 'account_inactive', 'token_revoked',
        /// 'no_permission', 'invalid_arg_name', 'invalid_array_arg',
        /// 'invalid_charset', 'invalid_form_data', 'invalid_post_type',
        /// 'missing_post_type', 'request_timeout', 'invalid_json',
        /// 'json_not_object', 'upgrade_required', 'fatal_error'</param>
        public UpdateErrorModel(string error)
        {
            Error = error;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for UpdateErrorModel class.
        /// </summary>
        static UpdateErrorModel()
        {
            Ok = false;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'message_not_found',
        /// 'cant_update_message', 'channel_not_found', 'edit_window_closed',
        /// 'msg_too_long', 'too_many_attachments', 'rate_limited', 'no_text',
        /// 'not_authed', 'invalid_auth', 'account_inactive', 'token_revoked',
        /// 'no_permission', 'invalid_arg_name', 'invalid_array_arg',
        /// 'invalid_charset', 'invalid_form_data', 'invalid_post_type',
        /// 'missing_post_type', 'request_timeout', 'invalid_json',
        /// 'json_not_object', 'upgrade_required', 'fatal_error'
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
