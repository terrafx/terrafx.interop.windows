// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D10_SHADER_DEBUG_SCOPEVAR_INFO
    {
        [NativeTypeName("UINT")]
        public uint TokenId;

        public D3D10_SHADER_DEBUG_VARTYPE VarType;

        [NativeTypeName("D3D10_SHADER_VARIABLE_CLASS")]
        public D3D_SHADER_VARIABLE_CLASS Class;

        [NativeTypeName("UINT")]
        public uint Rows;

        [NativeTypeName("UINT")]
        public uint Columns;

        [NativeTypeName("UINT")]
        public uint StructMemberScope;

        [NativeTypeName("UINT")]
        public uint uArrayIndices;

        [NativeTypeName("UINT")]
        public uint ArrayElements;

        [NativeTypeName("UINT")]
        public uint ArrayStrides;

        [NativeTypeName("UINT")]
        public uint uVariables;

        [NativeTypeName("UINT")]
        public uint uFirstVariable;
    }
}
