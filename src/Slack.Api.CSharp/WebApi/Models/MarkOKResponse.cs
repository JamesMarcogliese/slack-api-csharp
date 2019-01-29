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
    /// channels.mark success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response channels.mark method
    /// </remarks>
    public partial class MarkOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the MarkOKResponse class.
        /// </summary>
        public MarkOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Static constructor for MarkOKResponse class.
        /// </summary>
        static MarkOKResponse()
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