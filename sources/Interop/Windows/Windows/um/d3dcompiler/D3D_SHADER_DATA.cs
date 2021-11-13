// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcompiler.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct D3D_SHADER_DATA
    {
        [NativeTypeName("LPCVOID")]
        public void* pBytecode;

        [NativeTypeName("SIZE_T")]
        public nuint BytecodeLength;
    }
}
