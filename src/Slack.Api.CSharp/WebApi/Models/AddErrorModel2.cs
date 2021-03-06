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
    /// reactions.add error schema
    /// </summary>
    /// <remarks>
    /// Schema for error response from reactions.add method
    /// </remarks>
    public partial class AddErrorModel2
    {
        /// <summary>
        /// Initializes a new instance of the AddErrorModel2 class.
        /// </summary>
        public AddErrorModel2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddErrorModel2 class.
        /// </summary>
        /// <param name="error">Possible values include: 'bad_timestamp',
        /// 'file_not_found', 'file_comment_not_found', 'message_not_found',
        /// 'no_item_specified', 'invalid_name', 'already_reacted',
        /// 'too_many_emoji', 'too_many_reactions', 'not_authed',
        /// 'invalid_auth', 'account_inactive', 'no_permission',
        /// 'invalid_arg_name', 'invalid_array_arg', 'invalid_charset',
        /// 'invalid_form_data', 'invalid_post_type', 'missing_post_type',
        /// 'team_added_to_org', 'invalid_json', 'json_not_object',
        /// 'request_timeout', 'upgrade_required'</param>
        public AddErrorModel2(string error)
        {
            Error = error;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for AddErrorModel2 class.
        /// </summary>
        static AddErrorModel2()
        {
            Ok = false;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'bad_timestamp',
        /// 'file_not_found', 'file_comment_not_found', 'message_not_found',
        /// 'no_item_specified', 'invalid_name', 'already_reacted',
        /// 'too_many_emoji', 'too_many_reactions', 'not_authed',
        /// 'invalid_auth', 'account_inactive', 'no_permission',
        /// 'invalid_arg_name', 'invalid_array_arg', 'invalid_charset',
        /// 'invalid_form_data', 'invalid_post_type', 'missing_post_type',
        /// 'team_added_to_org', 'invalid_json', 'json_not_object',
        /// 'request_timeout', 'upgrade_required'
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
