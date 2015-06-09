using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using Microsoft.Azure;

namespace Microsoft.Azure.Management.Storage.Models
{
    /// <summary>
    /// </summary>
    public partial class Endpoints
    {
        /// <summary>
        /// Gets the blob endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "blob")]
        public string Blob { get; set; }

        /// <summary>
        /// Gets the queue endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "queue")]
        public string Queue { get; set; }

        /// <summary>
        /// Gets the table endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "table")]
        public string Table { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}