// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The awsOrganization data for the member account. </summary>
    public partial class AwsOrganizationalDataMember : AwsOrganizationalData
    {
        /// <summary> Initializes a new instance of AwsOrganizationalDataMember. </summary>
        public AwsOrganizationalDataMember()
        {
            OrganizationMembershipType = OrganizationMembershipType.Member;
        }

        /// <summary> Initializes a new instance of AwsOrganizationalDataMember. </summary>
        /// <param name="organizationMembershipType"> The multi cloud account&apos;s membership type in the organization. </param>
        /// <param name="parentHierarchyId"> If the multi cloud account is not of membership type organization, this will be the ID of the account&apos;s parent. </param>
        internal AwsOrganizationalDataMember(OrganizationMembershipType organizationMembershipType, string parentHierarchyId) : base(organizationMembershipType)
        {
            ParentHierarchyId = parentHierarchyId;
            OrganizationMembershipType = organizationMembershipType;
        }

        /// <summary> If the multi cloud account is not of membership type organization, this will be the ID of the account&apos;s parent. </summary>
        public string ParentHierarchyId { get; set; }
    }
}
