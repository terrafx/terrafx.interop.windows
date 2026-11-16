// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='STI_DEVICE_STATUS.xml' path='doc/member[@name="STI_DEVICE_STATUS"]/*' />
public partial struct STI_DEVICE_STATUS
{
    /// <include file='STI_DEVICE_STATUS.xml' path='doc/member[@name="STI_DEVICE_STATUS.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='STI_DEVICE_STATUS.xml' path='doc/member[@name="STI_DEVICE_STATUS.StatusMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint StatusMask;

    /// <include file='STI_DEVICE_STATUS.xml' path='doc/member[@name="STI_DEVICE_STATUS.dwOnlineState"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOnlineState;

    /// <include file='STI_DEVICE_STATUS.xml' path='doc/member[@name="STI_DEVICE_STATUS.dwHardwareStatusCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHardwareStatusCode;

    /// <include file='STI_DEVICE_STATUS.xml' path='doc/member[@name="STI_DEVICE_STATUS.dwEventHandlingState"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwEventHandlingState;

    /// <include file='STI_DEVICE_STATUS.xml' path='doc/member[@name="STI_DEVICE_STATUS.dwPollingInterval"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPollingInterval;
}
