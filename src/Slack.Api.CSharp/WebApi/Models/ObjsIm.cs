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
    /// IM Object
    /// </summary>
    public partial class ObjsIm
    {
        /// <summary>
        /// Initializes a new instance of the ObjsIm class.
        /// </summary>
        public ObjsIm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ObjsIm class.
        /// </summary>
        public ObjsIm(int created, string id, bool isIm, bool isOrgShared, bool isUserDeleted, string user, int? priority = default(int?))
        {
            Created = created;
            Id = id;
            IsIm = isIm;
            IsOrgShared = isOrgShared;
            IsUserDeleted = isUserDeleted;
            Priority = priority;
            User = user;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public int Created { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_im")]
        public bool IsIm { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_org_shared")]
        public bool IsOrgShared { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_user_deleted")]
        public bool IsUserDeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (User == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "User");
            }
        }
    }
}
