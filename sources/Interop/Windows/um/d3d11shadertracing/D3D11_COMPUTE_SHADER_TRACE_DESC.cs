// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_COMPUTE_SHADER_TRACE_DESC
    {
        [NativeTypeName("UINT64")]
        public ulong Invocation;

        [NativeTypeName("UINT [3]")]
        public fixed uint ThreadIDInGroup[3];

        [NativeTypeName("UINT [3]")]
        public fixed uint ThreadGroupID[3];
    }
}
