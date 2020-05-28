// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DXC_OUT_KIND
    {
        DXC_OUT_NONE = 0,
        DXC_OUT_OBJECT = 1,
        DXC_OUT_ERRORS = 2,
        DXC_OUT_PDB = 3,
        DXC_OUT_SHADER_HASH = 4,
        DXC_OUT_DISASSEMBLY = 5,
        DXC_OUT_HLSL = 6,
        DXC_OUT_TEXT = 7,
        DXC_OUT_REFLECTION = 8,
        DXC_OUT_ROOT_SIGNATURE = 9,
        DXC_OUT_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
