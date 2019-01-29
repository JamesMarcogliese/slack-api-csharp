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
    /// channels.info error schema
    /// </summary>
    /// <remarks>
    /// Schema for error response channels.info method
    /// </remarks>
    public partial class InfoErrorModel2
    {
        /// <summary>
        /// Initializes a new instance of the InfoErrorModel2 class.
        /// </summary>
        public InfoErrorModel2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InfoErrorModel2 class.
        /// </summary>
        /// <param name="error">Possible values include: 'channel_not_found',
        /// 'not_authed', 'invalid_auth', 'account_inactive',
        /// 'invalid_arg_name', 'invalid_array_arg', 'invalid_charset',
        /// 'invalid_form_data', 'invalid_post_type', 'missing_post_type',
        /// 'invalid_json', 'json_not_object', 'request_timeout',
        /// 'upgrade_required', 'team_added_to_org', 'missing_charset',
        /// 'superfluous_charset'</param>
        public InfoErrorModel2(string error)
        {
            Error = error;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for InfoErrorModel2 class.
        /// </summary>
        static InfoErrorModel2()
        {
            Ok = false;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'channel_not_found',
        /// 'not_authed', 'invalid_auth', 'account_inactive',
        /// 'invalid_arg_name', 'invalid_array_arg', 'invalid_charset',
        /// 'invalid_form_data', 'invalid_post_type', 'missing_post_type',
        /// 'invalid_json', 'json_not_object', 'request_timeout',
        /// 'upgrade_required', 'team_added_to_org', 'missing_charset',
        /// 'superfluous_charset'
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