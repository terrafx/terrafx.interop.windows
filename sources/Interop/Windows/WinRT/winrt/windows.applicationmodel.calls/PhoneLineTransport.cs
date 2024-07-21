// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneLineTransport.xml' path='doc/member[@name="PhoneLineTransport"]/*' />
public enum PhoneLineTransport
{
    /// <include file='PhoneLineTransport.xml' path='doc/member[@name="PhoneLineTransport.PhoneLineTransport_Cellular"]/*' />
    PhoneLineTransport_Cellular = 0,

    /// <include file='PhoneLineTransport.xml' path='doc/member[@name="PhoneLineTransport.PhoneLineTransport_VoipApp"]/*' />
    PhoneLineTransport_VoipApp = 1,

    /// <include file='PhoneLineTransport.xml' path='doc/member[@name="PhoneLineTransport.PhoneLineTransport_Bluetooth"]/*' />
    PhoneLineTransport_Bluetooth = 2,
}
