// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MOUSE_WHEEL_PARAMETER
    {
        MOUSE_WHEEL_PARAMETER_CHAR_TRANSLATION_X = 0x00000001,
        MOUSE_WHEEL_PARAMETER_CHAR_TRANSLATION_Y = 0x00000002,
        MOUSE_WHEEL_PARAMETER_DELTA_SCALE = 0x00000003,
        MOUSE_WHEEL_PARAMETER_DELTA_ROTATION = 0x00000004,
        MOUSE_WHEEL_PARAMETER_PAGE_TRANSLATION_X = 0x00000005,
        MOUSE_WHEEL_PARAMETER_PAGE_TRANSLATION_Y = 0x00000006,
        MOUSE_WHEEL_PARAMETER_MAX = unchecked((int)(0xffffffff)),
    }
}
