// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DWRITE_BREAK_CONDITION
    {
        DWRITE_BREAK_CONDITION_NEUTRAL,
        DWRITE_BREAK_CONDITION_CAN_BREAK,
        DWRITE_BREAK_CONDITION_MAY_NOT_BREAK,
        DWRITE_BREAK_CONDITION_MUST_BREAK,
    }
}
