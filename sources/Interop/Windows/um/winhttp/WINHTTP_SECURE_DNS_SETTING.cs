// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WINHTTP_SECURE_DNS_SETTING
    {
        WinHttpSecureDnsSettingDefault = 0,
        WinHttpSecureDnsSettingForcePlaintext = 1,
        WinHttpSecureDnsSettingRequireEncryption = 2,
        WinHttpSecureDnsSettingTryEncryptionWithFallback = 3,
        WinHttpSecureDnsSettingMax = 4,
    }
}
