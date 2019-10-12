// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_SHADER_TYPE_DESC
    {
        public D3D_SHADER_VARIABLE_CLASS Class;

        public D3D_SHADER_VARIABLE_TYPE Type;

        [NativeTypeName("UINT")]
        public uint Rows;

        [NativeTypeName("UINT")]
        public uint Columns;

        [NativeTypeName("UINT")]
        public uint Elements;

        [NativeTypeName("UINT")]
        public uint Members;

        [NativeTypeName("UINT")]
        public uint Offset;

        [NativeTypeName("LPCSTR")]
        public sbyte* Name;
    }
}
