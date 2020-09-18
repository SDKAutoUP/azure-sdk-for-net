// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VMwareCbt specific enable migration input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("VMwareCbt")]
    public partial class VMwareCbtEnableMigrationInput : EnableMigrationProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the VMwareCbtEnableMigrationInput
        /// class.
        /// </summary>
        public VMwareCbtEnableMigrationInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMwareCbtEnableMigrationInput
        /// class.
        /// </summary>
        /// <param name="vmwareMachineId">The ARM Id of the VM discovered in
        /// VMware.</param>
        /// <param name="disksToInclude">The disks to include list.</param>
        /// <param name="dataMoverRunAsAccountId">The data mover RunAs account
        /// Id.</param>
        /// <param name="snapshotRunAsAccountId">The snapshot RunAs account
        /// Id.</param>
        /// <param name="targetResourceGroupId">The target resource group ARM
        /// Id.</param>
        /// <param name="targetNetworkId">The target network ARM Id.</param>
        /// <param name="licenseType">License type. Possible values include:
        /// 'NotSpecified', 'NoLicenseType', 'WindowsServer'</param>
        /// <param name="targetVmName">The target VM name.</param>
        /// <param name="targetVmSize">The target VM size.</param>
        /// <param name="targetSubnetName">The target subnet name.</param>
        /// <param name="targetAvailabilitySetId">The target availability set
        /// ARM Id.</param>
        /// <param name="targetBootDiagnosticsStorageAccountId">The target boot
        /// diagnostics storage account ARM Id.</param>
        public VMwareCbtEnableMigrationInput(string vmwareMachineId, IList<VMwareCbtDiskInput> disksToInclude, string dataMoverRunAsAccountId, string snapshotRunAsAccountId, string targetResourceGroupId, string targetNetworkId, string licenseType = default(string), string targetVmName = default(string), string targetVmSize = default(string), string targetSubnetName = default(string), string targetAvailabilitySetId = default(string), string targetBootDiagnosticsStorageAccountId = default(string))
        {
            VmwareMachineId = vmwareMachineId;
            DisksToInclude = disksToInclude;
            LicenseType = licenseType;
            DataMoverRunAsAccountId = dataMoverRunAsAccountId;
            SnapshotRunAsAccountId = snapshotRunAsAccountId;
            TargetVmName = targetVmName;
            TargetVmSize = targetVmSize;
            TargetResourceGroupId = targetResourceGroupId;
            TargetNetworkId = targetNetworkId;
            TargetSubnetName = targetSubnetName;
            TargetAvailabilitySetId = targetAvailabilitySetId;
            TargetBootDiagnosticsStorageAccountId = targetBootDiagnosticsStorageAccountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ARM Id of the VM discovered in VMware.
        /// </summary>
        [JsonProperty(PropertyName = "vmwareMachineId")]
        public string VmwareMachineId { get; set; }

        /// <summary>
        /// Gets or sets the disks to include list.
        /// </summary>
        [JsonProperty(PropertyName = "disksToInclude")]
        public IList<VMwareCbtDiskInput> DisksToInclude { get; set; }

        /// <summary>
        /// Gets or sets license type. Possible values include: 'NotSpecified',
        /// 'NoLicenseType', 'WindowsServer'
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets or sets the data mover RunAs account Id.
        /// </summary>
        [JsonProperty(PropertyName = "dataMoverRunAsAccountId")]
        public string DataMoverRunAsAccountId { get; set; }

        /// <summary>
        /// Gets or sets the snapshot RunAs account Id.
        /// </summary>
        [JsonProperty(PropertyName = "snapshotRunAsAccountId")]
        public string SnapshotRunAsAccountId { get; set; }

        /// <summary>
        /// Gets or sets the target VM name.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmName")]
        public string TargetVmName { get; set; }

        /// <summary>
        /// Gets or sets the target VM size.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmSize")]
        public string TargetVmSize { get; set; }

        /// <summary>
        /// Gets or sets the target resource group ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceGroupId")]
        public string TargetResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets the target network ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetNetworkId")]
        public string TargetNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the target subnet name.
        /// </summary>
        [JsonProperty(PropertyName = "targetSubnetName")]
        public string TargetSubnetName { get; set; }

        /// <summary>
        /// Gets or sets the target availability set ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetAvailabilitySetId")]
        public string TargetAvailabilitySetId { get; set; }

        /// <summary>
        /// Gets or sets the target boot diagnostics storage account ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetBootDiagnosticsStorageAccountId")]
        public string TargetBootDiagnosticsStorageAccountId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VmwareMachineId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VmwareMachineId");
            }
            if (DisksToInclude == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisksToInclude");
            }
            if (DataMoverRunAsAccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataMoverRunAsAccountId");
            }
            if (SnapshotRunAsAccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SnapshotRunAsAccountId");
            }
            if (TargetResourceGroupId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetResourceGroupId");
            }
            if (TargetNetworkId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetNetworkId");
            }
            if (DisksToInclude != null)
            {
                foreach (var element in DisksToInclude)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
