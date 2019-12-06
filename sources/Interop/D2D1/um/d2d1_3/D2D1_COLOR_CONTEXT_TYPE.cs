// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum D2D1_COLOR_CONTEXT_TYPE : uint
    {
        D2D1_COLOR_CONTEXT_TYPE_ICC = 0,
        D2D1_COLOR_CONTEXT_TYPE_SIMPLE = 1,
        D2D1_COLOR_CONTEXT_TYPE_DXGI = 2,
        D2D1_COLOR_CONTEXT_TYPE_FORCE_DWORD = 0xffffffff,
    }
}
