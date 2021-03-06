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
    /// dnd.teamInfo success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response from dnd.teamInfo method
    /// </remarks>
    public partial class TeamInfoOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the TeamInfoOKResponse class.
        /// </summary>
        public TeamInfoOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TeamInfoOKResponse class.
        /// </summary>
        public TeamInfoOKResponse(object users, bool? cached = default(bool?))
        {
            Cached = cached;
            Users = users;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for TeamInfoOKResponse class.
        /// </summary>
        static TeamInfoOKResponse()
        {
            Ok = true;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cached")]
        public bool? Cached { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public object Users { get; set; }

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
            if (Users == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Users");
            }
        }
    }
}
