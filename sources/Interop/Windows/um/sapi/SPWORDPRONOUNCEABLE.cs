// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SPWORDPRONOUNCEABLE
    {
        SPWP_UNKNOWN_WORD_UNPRONOUNCEABLE = 0,
        SPWP_UNKNOWN_WORD_PRONOUNCEABLE = 1,
        SPWP_KNOWN_WORD_PRONOUNCEABLE = 2,
    }
}
