// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D10_SHADER_DEBUG_SCOPE_INFO
    {
        public D3D10_SHADER_DEBUG_SCOPETYPE ScopeType;

        [NativeTypeName("UINT")]
        public uint Name;

        [NativeTypeName("UINT")]
        public uint uNameLen;

        [NativeTypeName("UINT")]
        public uint uVariables;

        [NativeTypeName("UINT")]
        public uint VariableData;
    }
}
