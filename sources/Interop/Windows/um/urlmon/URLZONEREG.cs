// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum URLZONEREG
    {
        URLZONEREG_DEFAULT = 0,
        URLZONEREG_HKLM = (URLZONEREG_DEFAULT + 1),
        URLZONEREG_HKCU = (URLZONEREG_HKLM + 1),
    }
}
