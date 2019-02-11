// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.Authentication.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Sql.Common;
using Microsoft.Azure.Commands.Sql.ServiceObjective.Adapter;
using Microsoft.Azure.Commands.Sql.ServiceObjective.Model;
using System;
using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Sql.ServiceObjective.Cmdlet
{
    public abstract class AzureSqlServerServiceObjectiveCmdletBase
        : AzureSqlCmdletBase<IEnumerable<AzureSqlServerServiceObjectiveModel>, AzureSqlServerServiceObjectiveAdapter>
    {
        /// <summary>
        /// Gets or sets the name of the database server to use.
        /// </summary>
        [Parameter(Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            Position = 1,
            HelpMessage = "SQL Database server name.")]
        [ResourceNameCompleter("Microsoft.Sql/servers", "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public string ServerName { get; set; }

        /// <summary>
        /// Intializes the model adapter
        /// </summary>
        /// <returns>The service objective adapter</returns>
        protected override AzureSqlServerServiceObjectiveAdapter InitModelAdapter()
        {
            return new AzureSqlServerServiceObjectiveAdapter(DefaultProfile.DefaultContext);
        }
    }
}
