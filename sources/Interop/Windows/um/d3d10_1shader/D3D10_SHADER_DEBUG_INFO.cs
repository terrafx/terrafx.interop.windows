// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D10_SHADER_DEBUG_INFO
    {
        [NativeTypeName("UINT")]
        public uint Size;

        [NativeTypeName("UINT")]
        public uint Creator;

        [NativeTypeName("UINT")]
        public uint EntrypointName;

        [NativeTypeName("UINT")]
        public uint ShaderTarget;

        [NativeTypeName("UINT")]
        public uint CompileFlags;

        [NativeTypeName("UINT")]
        public uint Files;

        [NativeTypeName("UINT")]
        public uint FileInfo;

        [NativeTypeName("UINT")]
        public uint Instructions;

        [NativeTypeName("UINT")]
        public uint InstructionInfo;

        [NativeTypeName("UINT")]
        public uint Variables;

        [NativeTypeName("UINT")]
        public uint VariableInfo;

        [NativeTypeName("UINT")]
        public uint InputVariables;

        [NativeTypeName("UINT")]
        public uint InputVariableInfo;

        [NativeTypeName("UINT")]
        public uint Tokens;

        [NativeTypeName("UINT")]
        public uint TokenInfo;

        [NativeTypeName("UINT")]
        public uint Scopes;

        [NativeTypeName("UINT")]
        public uint ScopeInfo;

        [NativeTypeName("UINT")]
        public uint ScopeVariables;

        [NativeTypeName("UINT")]
        public uint ScopeVariableInfo;

        [NativeTypeName("UINT")]
        public uint UintOffset;

        [NativeTypeName("UINT")]
        public uint StringOffset;
    }
}
