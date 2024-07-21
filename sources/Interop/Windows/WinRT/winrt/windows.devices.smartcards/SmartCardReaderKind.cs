// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardReaderKind.xml' path='doc/member[@name="SmartCardReaderKind"]/*' />
public enum SmartCardReaderKind
{
    /// <include file='SmartCardReaderKind.xml' path='doc/member[@name="SmartCardReaderKind.SmartCardReaderKind_Any"]/*' />
    SmartCardReaderKind_Any = 0,

    /// <include file='SmartCardReaderKind.xml' path='doc/member[@name="SmartCardReaderKind.SmartCardReaderKind_Generic"]/*' />
    SmartCardReaderKind_Generic = 1,

    /// <include file='SmartCardReaderKind.xml' path='doc/member[@name="SmartCardReaderKind.SmartCardReaderKind_Tpm"]/*' />
    SmartCardReaderKind_Tpm = 2,

    /// <include file='SmartCardReaderKind.xml' path='doc/member[@name="SmartCardReaderKind.SmartCardReaderKind_Nfc"]/*' />
    SmartCardReaderKind_Nfc = 3,

    /// <include file='SmartCardReaderKind.xml' path='doc/member[@name="SmartCardReaderKind.SmartCardReaderKind_Uicc"]/*' />
    SmartCardReaderKind_Uicc = 4,

    /// <include file='SmartCardReaderKind.xml' path='doc/member[@name="SmartCardReaderKind.SmartCardReaderKind_EmbeddedSE"]/*' />
    SmartCardReaderKind_EmbeddedSE = 5,
}
