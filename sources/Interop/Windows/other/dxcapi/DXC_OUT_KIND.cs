// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcapi.h in the microsoft/DirectXCompiler commit 747ee519eb9b65f893bb891bc6d229dfe9687e6a
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum DXC_OUT_KIND : uint
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
        DXC_OUT_EXTRA_OUTPUTS = 10,
        DXC_OUT_FORCE_DWORD = 0xFFFFFFFF,
    }
}
