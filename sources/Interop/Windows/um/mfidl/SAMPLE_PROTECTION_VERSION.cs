// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SAMPLE_PROTECTION_VERSION
    {
        SAMPLE_PROTECTION_VERSION_NO = 0,
        SAMPLE_PROTECTION_VERSION_BASIC_LOKI = 1,
        SAMPLE_PROTECTION_VERSION_SCATTER = 2,
        SAMPLE_PROTECTION_VERSION_RC4 = 3,
        SAMPLE_PROTECTION_VERSION_AES128CTR = 4,
    }
}
