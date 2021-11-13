// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum SCRIPT_TIMER_TYPE
    {
        STT_TIMEOUT = 0,
        STT_INTERVAL = 0x1,
        STT_IMMEDIATE = 0x2,
        STT_ANIMATION_FRAME = 0x3,
        SCRIPT_TIMER_TYPE_Max = 2147483647,
    }
}
