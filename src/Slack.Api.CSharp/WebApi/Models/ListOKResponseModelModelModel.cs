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
    /// conversations.list success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response from conversations.list method
    /// </remarks>
    public partial class ListOKResponseModelModelModel
    {
        /// <summary>
        /// Initializes a new instance of the ListOKResponseModelModelModel
        /// class.
        /// </summary>
        public ListOKResponseModelModelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListOKResponseModelModelModel
        /// class.
        /// </summary>
        public ListOKResponseModelModelModel(IList<object> channels, ListOKResponseResponseMetadataModel responseMetadata = default(ListOKResponseResponseMetadataModel))
        {
            Channels = channels;
            ResponseMetadata = responseMetadata;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for ListOKResponseModelModelModel class.
        /// </summary>
        static ListOKResponseModelModelModel()
        {
            Ok = true;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "channels")]
        public IList<object> Channels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "response_metadata")]
        public ListOKResponseResponseMetadataModel ResponseMetadata { get; set; }

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
            if (Channels == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Channels");
            }
            if (Channels != null)
            {
                if (Channels.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(Channels)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "Channels");
                }
            }
            if (ResponseMetadata != null)
            {
                ResponseMetadata.Validate();
            }
        }
    }
}