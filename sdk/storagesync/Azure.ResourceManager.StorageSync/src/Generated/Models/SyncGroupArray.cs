// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Array of SyncGroup. </summary>
    internal partial class SyncGroupArray
    {
        /// <summary> Initializes a new instance of SyncGroupArray. </summary>
        internal SyncGroupArray()
        {
            Value = new ChangeTrackingList<SyncGroupData>();
        }

        /// <summary> Initializes a new instance of SyncGroupArray. </summary>
        /// <param name="value"> Collection of SyncGroup. </param>
        internal SyncGroupArray(IReadOnlyList<SyncGroupData> value)
        {
            Value = value;
        }

        /// <summary> Collection of SyncGroup. </summary>
        public IReadOnlyList<SyncGroupData> Value { get; }
    }
}
