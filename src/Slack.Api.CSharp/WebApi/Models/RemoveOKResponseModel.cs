// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// reactions.remove schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response from reactions.remove method
    /// </remarks>
    public partial class RemoveOKResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the RemoveOKResponseModel class.
        /// </summary>
        public RemoveOKResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Static constructor for RemoveOKResponseModel class.
        /// </summary>
        static RemoveOKResponseModel()
        {
            Ok = true;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ok")]
        public static bool Ok { get; private set; }

    }
}
