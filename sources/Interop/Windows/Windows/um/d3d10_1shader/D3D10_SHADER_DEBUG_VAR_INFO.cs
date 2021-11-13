// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct D3D10_SHADER_DEBUG_VAR_INFO
    {
        public uint TokenId;

        [NativeTypeName("D3D10_SHADER_VARIABLE_TYPE")]
        public D3D_SHADER_VARIABLE_TYPE Type;

        public uint Register;

        public uint Component;

        public uint ScopeVar;

        public uint ScopeVarOffset;
    }
}
