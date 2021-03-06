// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ServiceTreeInfo
    {
        /// <summary>
        /// Initializes a new instance of the ServiceTreeInfo class.
        /// </summary>
        public ServiceTreeInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceTreeInfo class.
        /// </summary>
        public ServiceTreeInfo(string serviceId = default(string), string componentId = default(string))
        {
            ServiceId = serviceId;
            ComponentId = componentId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceId")]
        public string ServiceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentId")]
        public string ComponentId { get; set; }

    }
}
