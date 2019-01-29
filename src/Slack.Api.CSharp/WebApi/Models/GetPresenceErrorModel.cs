// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// users.counts error schema
    /// </summary>
    /// <remarks>
    /// Schema for error response users.getPresence method
    /// </remarks>
    public partial class GetPresenceErrorModel
    {
        /// <summary>
        /// Initializes a new instance of the GetPresenceErrorModel class.
        /// </summary>
        public GetPresenceErrorModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetPresenceErrorModel class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        public GetPresenceErrorModel(string error, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>))
        {
            AdditionalProperties = additionalProperties;
            Error = error;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for GetPresenceErrorModel class.
        /// </summary>
        static GetPresenceErrorModel()
        {
            Ok = false;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
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