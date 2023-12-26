// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='KeySize.xml' path='doc/member[@name="KeySize"]/*' />
public enum KeySize
{
    /// <include file='KeySize.xml' path='doc/member[@name="KeySize.KeySize_Invalid"]/*' />
    KeySize_Invalid = 0,

    /// <include file='KeySize.xml' path='doc/member[@name="KeySize.KeySize_Rsa2048"]/*' />
    KeySize_Rsa2048 = 2048,

    /// <include file='KeySize.xml' path='doc/member[@name="KeySize.KeySize_Rsa4096"]/*' />
    KeySize_Rsa4096 = 4096,
}
