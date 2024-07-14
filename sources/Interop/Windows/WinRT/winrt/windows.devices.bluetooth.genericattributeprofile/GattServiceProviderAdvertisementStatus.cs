// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GattServiceProviderAdvertisementStatus.xml' path='doc/member[@name="GattServiceProviderAdvertisementStatus"]/*' />
public enum GattServiceProviderAdvertisementStatus
{
    /// <include file='GattServiceProviderAdvertisementStatus.xml' path='doc/member[@name="GattServiceProviderAdvertisementStatus.GattServiceProviderAdvertisementStatus_Created"]/*' />
    GattServiceProviderAdvertisementStatus_Created = 0,

    /// <include file='GattServiceProviderAdvertisementStatus.xml' path='doc/member[@name="GattServiceProviderAdvertisementStatus.GattServiceProviderAdvertisementStatus_Stopped"]/*' />
    GattServiceProviderAdvertisementStatus_Stopped = 1,

    /// <include file='GattServiceProviderAdvertisementStatus.xml' path='doc/member[@name="GattServiceProviderAdvertisementStatus.GattServiceProviderAdvertisementStatus_Started"]/*' />
    GattServiceProviderAdvertisementStatus_Started = 2,

    /// <include file='GattServiceProviderAdvertisementStatus.xml' path='doc/member[@name="GattServiceProviderAdvertisementStatus.GattServiceProviderAdvertisementStatus_Aborted"]/*' />
    GattServiceProviderAdvertisementStatus_Aborted = 3,

    /// <include file='GattServiceProviderAdvertisementStatus.xml' path='doc/member[@name="GattServiceProviderAdvertisementStatus.GattServiceProviderAdvertisementStatus_StartedWithoutAllAdvertisementData"]/*' />
    GattServiceProviderAdvertisementStatus_StartedWithoutAllAdvertisementData = 4,
}
