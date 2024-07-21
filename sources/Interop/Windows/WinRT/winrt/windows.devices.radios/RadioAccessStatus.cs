// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.radios.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RadioAccessStatus.xml' path='doc/member[@name="RadioAccessStatus"]/*' />
public enum RadioAccessStatus
{
    /// <include file='RadioAccessStatus.xml' path='doc/member[@name="RadioAccessStatus.RadioAccessStatus_Unspecified"]/*' />
    RadioAccessStatus_Unspecified = 0,

    /// <include file='RadioAccessStatus.xml' path='doc/member[@name="RadioAccessStatus.RadioAccessStatus_Allowed"]/*' />
    RadioAccessStatus_Allowed = 1,

    /// <include file='RadioAccessStatus.xml' path='doc/member[@name="RadioAccessStatus.RadioAccessStatus_DeniedByUser"]/*' />
    RadioAccessStatus_DeniedByUser = 2,

    /// <include file='RadioAccessStatus.xml' path='doc/member[@name="RadioAccessStatus.RadioAccessStatus_DeniedBySystem"]/*' />
    RadioAccessStatus_DeniedBySystem = 3,
}
