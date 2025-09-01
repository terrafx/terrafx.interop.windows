// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VoipCallControlDeviceKind.xml' path='doc/member[@name="VoipCallControlDeviceKind"]/*' />
public enum VoipCallControlDeviceKind
{
    /// <include file='VoipCallControlDeviceKind.xml' path='doc/member[@name="VoipCallControlDeviceKind.VoipCallControlDeviceKind_Bluetooth"]/*' />
    VoipCallControlDeviceKind_Bluetooth = 0,

    /// <include file='VoipCallControlDeviceKind.xml' path='doc/member[@name="VoipCallControlDeviceKind.VoipCallControlDeviceKind_Usb"]/*' />
    VoipCallControlDeviceKind_Usb = 1,
}
