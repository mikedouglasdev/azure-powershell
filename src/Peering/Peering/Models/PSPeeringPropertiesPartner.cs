// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Common.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The peering properties carrier class.
    /// </summary>
    public partial class PSPeeringPropertiesPartner
    {
        /// <summary>
        /// Initializes a new instance of the PSPeeringPropertiesPartner class.
        /// </summary>
        public PSPeeringPropertiesPartner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PSPeeringPropertiesPartner class.
        /// </summary>
        /// <param name="partnerName">Gets or sets the carrier name.</param>
        /// <param name="serviceTag">Gets or sets the service tag.</param>
        /// <param name="prefixes">Gets or sets the list of prefixes.</param>
        public PSPeeringPropertiesPartner(string partnerName = default(string), string serviceTag = default(string), IDictionary<string, PSPeeringPrefix> prefixes = default(IDictionary<string, PSPeeringPrefix>))
        {
            PartnerName = partnerName;
            ServiceTag = serviceTag;
            Prefixes = prefixes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the carrier name.
        /// </summary>
        [JsonProperty(PropertyName = "partnerName")]
        public string PartnerName { get; set; }

        /// <summary>
        /// Gets or sets the service tag.
        /// </summary>
        [JsonProperty(PropertyName = "serviceTag")]
        public string ServiceTag { get; set; }

        /// <summary>
        /// Gets or sets the list of prefixes.
        /// </summary>
        [JsonProperty(PropertyName = "prefixes")]
        public IDictionary<string, PSPeeringPrefix> Prefixes { get; set; }

    }
}
