// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ReplaceDevicePropertiesStatus.xml' path='doc/member[@name="ReplaceDevicePropertiesStatus"]/*' />
public enum ReplaceDevicePropertiesStatus
{
    /// <include file='ReplaceDevicePropertiesStatus.xml' path='doc/member[@name="ReplaceDevicePropertiesStatus.ReplaceDevicePropertiesStatus_Succeeded"]/*' />
    ReplaceDevicePropertiesStatus_Succeeded = 0,

    /// <include file='ReplaceDevicePropertiesStatus.xml' path='doc/member[@name="ReplaceDevicePropertiesStatus.ReplaceDevicePropertiesStatus_AccessDenied"]/*' />
    ReplaceDevicePropertiesStatus_AccessDenied = 1,

    /// <include file='ReplaceDevicePropertiesStatus.xml' path='doc/member[@name="ReplaceDevicePropertiesStatus.ReplaceDevicePropertiesStatus_OtherFailure"]/*' />
    ReplaceDevicePropertiesStatus_OtherFailure = 2,
}
