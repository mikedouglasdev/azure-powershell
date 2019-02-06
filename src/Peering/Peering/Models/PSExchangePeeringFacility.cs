// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Common.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The peering location properties class.
    /// </summary>
    public partial class PSExchangePeeringFacility
    {
        /// <summary>
        /// Initializes a new instance of the PSExchangePeeringFacility class.
        /// </summary>
        public PSExchangePeeringFacility()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PSExchangePeeringFacility class.
        /// </summary>
        /// <param name="bandwidthInMbps">Gets or sets the bandwidth in
        /// Mbps.</param>
        /// <param name="microsoftIPv4Address">Gets or sets the Microsoft IP v4
        /// address.</param>
        /// <param name="microsoftIPv6Address">Gets or sets the Microsoft IP v6
        /// address.</param>
        /// <param name="name">Gets or sets the facility name.</param>
        /// <param name="address">Gets or sets the facility address.</param>
        /// <param name="peeringDBFacilityId">Gets or sets the facility
        /// id.</param>
        /// <param name="peeringDBFacilityLink">Gets or sets the Peering
        /// Facility Link.</param>
        public PSExchangePeeringFacility(int? bandwidthInMbps = default(int?), string microsoftIPv4Address = default(string), string microsoftIPv6Address = default(string), string name = default(string), string address = default(string), int? peeringDBFacilityId = default(int?), string peeringDBFacilityLink = default(string))
        {
            BandwidthInMbps = bandwidthInMbps;
            MicrosoftIPv4Address = microsoftIPv4Address;
            MicrosoftIPv6Address = microsoftIPv6Address;
            Name = name;
            Address = address;
            PeeringDBFacilityId = peeringDBFacilityId;
            PeeringDBFacilityLink = peeringDBFacilityLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the bandwidth in Mbps.
        /// </summary>
        [JsonProperty(PropertyName = "bandwidthInMbps")]
        public int? BandwidthInMbps { get; set; }

        /// <summary>
        /// Gets or sets the Microsoft IP v4 address.
        /// </summary>
        [JsonProperty(PropertyName = "microsoftIPv4Address")]
        public string MicrosoftIPv4Address { get; set; }

        /// <summary>
        /// Gets or sets the Microsoft IP v6 address.
        /// </summary>
        [JsonProperty(PropertyName = "microsoftIPv6Address")]
        public string MicrosoftIPv6Address { get; set; }

        /// <summary>
        /// Gets or sets the facility name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the facility address.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the facility id.
        /// </summary>
        [JsonProperty(PropertyName = "peeringDBFacilityId")]
        public int? PeeringDBFacilityId { get; set; }

        /// <summary>
        /// Gets or sets the Peering Facility Link.
        /// </summary>
        [JsonProperty(PropertyName = "peeringDBFacilityLink")]
        public string PeeringDBFacilityLink { get; set; }

    }
}
