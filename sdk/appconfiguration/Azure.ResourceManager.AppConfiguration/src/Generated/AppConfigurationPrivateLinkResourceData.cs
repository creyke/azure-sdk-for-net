// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary> A class representing the AppConfigurationPrivateLinkResource data model. </summary>
    public partial class AppConfigurationPrivateLinkResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of AppConfigurationPrivateLinkResourceData. </summary>
        internal AppConfigurationPrivateLinkResourceData()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AppConfigurationPrivateLinkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The list of required DNS zone names of the private link resource. </param>
        internal AppConfigurationPrivateLinkResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string groupId, IReadOnlyList<string> requiredMembers, IReadOnlyList<string> requiredZoneNames) : base(id, name, resourceType, systemData)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> The private link resource group id. </summary>
        public string GroupId { get; }
        /// <summary> The private link resource required member names. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> The list of required DNS zone names of the private link resource. </summary>
        public IReadOnlyList<string> RequiredZoneNames { get; }
    }
}
