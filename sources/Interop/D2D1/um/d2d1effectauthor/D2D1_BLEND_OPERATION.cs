// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum D2D1_BLEND_OPERATION : uint
    {
        D2D1_BLEND_OPERATION_ADD = 1,
        D2D1_BLEND_OPERATION_SUBTRACT = 2,
        D2D1_BLEND_OPERATION_REV_SUBTRACT = 3,
        D2D1_BLEND_OPERATION_MIN = 4,
        D2D1_BLEND_OPERATION_MAX = 5,
        D2D1_BLEND_OPERATION_FORCE_DWORD = 0xffffffff,
    }
}
