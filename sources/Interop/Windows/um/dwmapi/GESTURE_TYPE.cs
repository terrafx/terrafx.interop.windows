// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum GESTURE_TYPE
    {
        GT_PEN_TAP = 0,
        GT_PEN_DOUBLETAP = 1,
        GT_PEN_RIGHTTAP = 2,
        GT_PEN_PRESSANDHOLD = 3,
        GT_PEN_PRESSANDHOLDABORT = 4,
        GT_TOUCH_TAP = 5,
        GT_TOUCH_DOUBLETAP = 6,
        GT_TOUCH_RIGHTTAP = 7,
        GT_TOUCH_PRESSANDHOLD = 8,
        GT_TOUCH_PRESSANDHOLDABORT = 9,
        GT_TOUCH_PRESSANDTAP = 10,
    }
}
