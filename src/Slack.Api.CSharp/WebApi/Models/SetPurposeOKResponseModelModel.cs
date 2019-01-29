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
    /// groups.setPurpose schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response from groups.setPurpose method
    /// </remarks>
    public partial class SetPurposeOKResponseModelModel
    {
        /// <summary>
        /// Initializes a new instance of the SetPurposeOKResponseModelModel
        /// class.
        /// </summary>
        public SetPurposeOKResponseModelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetPurposeOKResponseModelModel
        /// class.
        /// </summary>
        public SetPurposeOKResponseModelModel(string purpose)
        {
            Purpose = purpose;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for SetPurposeOKResponseModelModel class.
        /// </summary>
        static SetPurposeOKResponseModelModel()
        {
            Ok = true;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "purpose")]
        public string Purpose { get; set; }

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
            if (Purpose == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Purpose");
            }
        }
    }
}