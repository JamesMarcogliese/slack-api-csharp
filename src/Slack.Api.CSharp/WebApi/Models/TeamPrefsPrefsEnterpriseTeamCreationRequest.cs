// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TeamPrefsPrefsEnterpriseTeamCreationRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TeamPrefsPrefsEnterpriseTeamCreationRequest class.
        /// </summary>
        public TeamPrefsPrefsEnterpriseTeamCreationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// TeamPrefsPrefsEnterpriseTeamCreationRequest class.
        /// </summary>
        public TeamPrefsPrefsEnterpriseTeamCreationRequest(bool isEnabled)
        {
            IsEnabled = isEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_enabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
