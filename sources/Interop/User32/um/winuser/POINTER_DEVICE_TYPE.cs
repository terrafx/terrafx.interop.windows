// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum POINTER_DEVICE_TYPE : uint
    {
        POINTER_DEVICE_TYPE_INTEGRATED_PEN = 0x00000001,
        POINTER_DEVICE_TYPE_EXTERNAL_PEN = 0x00000002,
        POINTER_DEVICE_TYPE_TOUCH = 0x00000003,
        POINTER_DEVICE_TYPE_TOUCH_PAD = 0x00000004,
        POINTER_DEVICE_TYPE_MAX = 0xFFFFFFFF,
    }
}
