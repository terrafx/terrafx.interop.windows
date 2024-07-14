// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GattOpenStatus.xml' path='doc/member[@name="GattOpenStatus"]/*' />
public enum GattOpenStatus
{
    /// <include file='GattOpenStatus.xml' path='doc/member[@name="GattOpenStatus.GattOpenStatus_Unspecified"]/*' />
    GattOpenStatus_Unspecified = 0,

    /// <include file='GattOpenStatus.xml' path='doc/member[@name="GattOpenStatus.GattOpenStatus_Success"]/*' />
    GattOpenStatus_Success = 1,

    /// <include file='GattOpenStatus.xml' path='doc/member[@name="GattOpenStatus.GattOpenStatus_AlreadyOpened"]/*' />
    GattOpenStatus_AlreadyOpened = 2,

    /// <include file='GattOpenStatus.xml' path='doc/member[@name="GattOpenStatus.GattOpenStatus_NotFound"]/*' />
    GattOpenStatus_NotFound = 3,

    /// <include file='GattOpenStatus.xml' path='doc/member[@name="GattOpenStatus.GattOpenStatus_SharingViolation"]/*' />
    GattOpenStatus_SharingViolation = 4,

    /// <include file='GattOpenStatus.xml' path='doc/member[@name="GattOpenStatus.GattOpenStatus_AccessDenied"]/*' />
    GattOpenStatus_AccessDenied = 5,
}
