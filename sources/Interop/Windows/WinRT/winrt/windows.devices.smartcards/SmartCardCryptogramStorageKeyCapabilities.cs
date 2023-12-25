// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardCryptogramStorageKeyCapabilities.xml' path='doc/member[@name="SmartCardCryptogramStorageKeyCapabilities"]/*' />
[NativeTypeName("unsigned int")]
public enum SmartCardCryptogramStorageKeyCapabilities : uint
{
    /// <include file='SmartCardCryptogramStorageKeyCapabilities.xml' path='doc/member[@name="SmartCardCryptogramStorageKeyCapabilities.SmartCardCryptogramStorageKeyCapabilities_None"]/*' />
    SmartCardCryptogramStorageKeyCapabilities_None = 0,

    /// <include file='SmartCardCryptogramStorageKeyCapabilities.xml' path='doc/member[@name="SmartCardCryptogramStorageKeyCapabilities.SmartCardCryptogramStorageKeyCapabilities_HardwareProtection"]/*' />
    SmartCardCryptogramStorageKeyCapabilities_HardwareProtection = 0x1,

    /// <include file='SmartCardCryptogramStorageKeyCapabilities.xml' path='doc/member[@name="SmartCardCryptogramStorageKeyCapabilities.SmartCardCryptogramStorageKeyCapabilities_UnlockPrompt"]/*' />
    SmartCardCryptogramStorageKeyCapabilities_UnlockPrompt = 0x2,
}
