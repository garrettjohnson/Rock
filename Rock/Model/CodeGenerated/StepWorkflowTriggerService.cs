//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// StepWorkflowTrigger Service class
    /// </summary>
    public partial class StepWorkflowTriggerService : Service<StepWorkflowTrigger>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StepWorkflowTriggerService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public StepWorkflowTriggerService(RockContext context) : base(context)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( StepWorkflowTrigger item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class StepWorkflowTriggerExtensionMethods
    {
        /// <summary>
        /// Clones this StepWorkflowTrigger object to a new StepWorkflowTrigger object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static StepWorkflowTrigger Clone( this StepWorkflowTrigger source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as StepWorkflowTrigger;
            }
            else
            {
                var target = new StepWorkflowTrigger();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Copies the properties from another StepWorkflowTrigger object to this StepWorkflowTrigger object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this StepWorkflowTrigger target, StepWorkflowTrigger source )
        {
            target.Id = source.Id;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.IsActive = source.IsActive;
            target.StepProgramId = source.StepProgramId;
            target.StepTypeId = source.StepTypeId;
            target.TriggerType = source.TriggerType;
            target.TypeQualifier = source.TypeQualifier;
            target.WorkflowName = source.WorkflowName;
            target.WorkflowTypeId = source.WorkflowTypeId;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}
