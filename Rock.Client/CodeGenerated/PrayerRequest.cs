//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright 2013 by the Spark Development Network
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;


namespace Rock.Client
{
    /// <summary>
    /// Simple Client Model for PrayerRequest
    /// </summary>
    public partial class PrayerRequest
    {
        /// <summary />
        public int? ApprovedByPersonId { get; set; }

        /// <summary />
        public int? RequestedByPersonId { get; set; }

        /// <summary />
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary />
        public int? ModifiedByPersonAliasId { get; set; }

        /// <summary />
        public string FirstName { get; set; }

        /// <summary />
        public string LastName { get; set; }

        /// <summary />
        public string Email { get; set; }

        /// <summary />
        public int? CategoryId { get; set; }

        /// <summary />
        public string Text { get; set; }

        /// <summary />
        public string Answer { get; set; }

        /// <summary />
        public DateTime EnteredDateTime { get; set; }

        /// <summary />
        public DateTime? ExpirationDate { get; set; }

        /// <summary />
        public int? GroupId { get; set; }

        /// <summary />
        public bool? AllowComments { get; set; }

        /// <summary />
        public bool? IsUrgent { get; set; }

        /// <summary />
        public bool? IsPublic { get; set; }

        /// <summary />
        public bool? IsActive { get; set; }

        /// <summary />
        public bool? IsApproved { get; set; }

        /// <summary />
        public int? FlagCount { get; set; }

        /// <summary />
        public int? PrayerCount { get; set; }

        /// <summary />
        public DateTime? ApprovedOnDateTime { get; set; }

        /// <summary />
        public DateTime? CreatedDateTime { get; set; }

        /// <summary />
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public string ForeignId { get; set; }

    }
}
