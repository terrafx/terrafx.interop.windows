// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX
{
    public partial struct D3D10_SHADER_DEBUG_SCOPEVAR_INFO
    {
        public uint TokenId;

        public D3D10_SHADER_DEBUG_VARTYPE VarType;

        [NativeTypeName("D3D10_SHADER_VARIABLE_CLASS")]
        public D3D_SHADER_VARIABLE_CLASS Class;

        public uint Rows;

        public uint Columns;

        public uint StructMemberScope;

        public uint uArrayIndices;

        public uint ArrayElements;

        public uint ArrayStrides;

        public uint uVariables;

        public uint uFirstVariable;
    }
}
