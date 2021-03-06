// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi.Models
{
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with UpdateErrorModel1
    /// information.
    /// </summary>
    public partial class UpdateErrorModel1Exception : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public UpdateErrorModel1 Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the UpdateErrorModel1Exception class.
        /// </summary>
        public UpdateErrorModel1Exception()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpdateErrorModel1Exception class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public UpdateErrorModel1Exception(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpdateErrorModel1Exception class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public UpdateErrorModel1Exception(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
