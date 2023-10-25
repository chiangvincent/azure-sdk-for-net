// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Reservations;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> List of `Reservation`s. </summary>
    internal partial class ReservationList
    {
        /// <summary> Initializes a new instance of ReservationList. </summary>
        internal ReservationList()
        {
            Value = new ChangeTrackingList<ReservationDetailData>();
        }

        /// <summary> Initializes a new instance of ReservationList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> Url to get the next page of reservations. </param>
        internal ReservationList(IReadOnlyList<ReservationDetailData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ReservationDetailData> Value { get; }
        /// <summary> Url to get the next page of reservations. </summary>
        public string NextLink { get; }
    }
}
