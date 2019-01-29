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

    public partial class InfoOKResponseBot
    {
        /// <summary>
        /// Initializes a new instance of the InfoOKResponseBot class.
        /// </summary>
        public InfoOKResponseBot()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InfoOKResponseBot class.
        /// </summary>
        public InfoOKResponseBot(string appId, bool deleted, InfoOKResponseBotIcons icons, string id, string name, int updated, string userId = default(string))
        {
            AppId = appId;
            Deleted = deleted;
            Icons = icons;
            Id = id;
            Name = name;
            Updated = updated;
            UserId = userId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "icons")]
        public InfoOKResponseBotIcons Icons { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updated")]
        public int Updated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AppId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppId");
            }
            if (Icons == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Icons");
            }
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Icons != null)
            {
                Icons.Validate();
            }
        }
    }
}