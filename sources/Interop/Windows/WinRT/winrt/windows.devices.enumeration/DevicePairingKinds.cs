// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DevicePairingKinds.xml' path='doc/member[@name="DevicePairingKinds"]/*' />
[NativeTypeName("unsigned int")]
public enum DevicePairingKinds : uint
{
    /// <include file='DevicePairingKinds.xml' path='doc/member[@name="DevicePairingKinds.DevicePairingKinds_None"]/*' />
    DevicePairingKinds_None = 0,

    /// <include file='DevicePairingKinds.xml' path='doc/member[@name="DevicePairingKinds.DevicePairingKinds_ConfirmOnly"]/*' />
    DevicePairingKinds_ConfirmOnly = 0x1,

    /// <include file='DevicePairingKinds.xml' path='doc/member[@name="DevicePairingKinds.DevicePairingKinds_DisplayPin"]/*' />
    DevicePairingKinds_DisplayPin = 0x2,

    /// <include file='DevicePairingKinds.xml' path='doc/member[@name="DevicePairingKinds.DevicePairingKinds_ProvidePin"]/*' />
    DevicePairingKinds_ProvidePin = 0x4,

    /// <include file='DevicePairingKinds.xml' path='doc/member[@name="DevicePairingKinds.DevicePairingKinds_ConfirmPinMatch"]/*' />
    DevicePairingKinds_ConfirmPinMatch = 0x8,

    /// <include file='DevicePairingKinds.xml' path='doc/member[@name="DevicePairingKinds.DevicePairingKinds_ProvidePasswordCredential"]/*' />
    DevicePairingKinds_ProvidePasswordCredential = 0x10,

    /// <include file='DevicePairingKinds.xml' path='doc/member[@name="DevicePairingKinds.DevicePairingKinds_ProvideAddress"]/*' />
    DevicePairingKinds_ProvideAddress = 0x20,
}
