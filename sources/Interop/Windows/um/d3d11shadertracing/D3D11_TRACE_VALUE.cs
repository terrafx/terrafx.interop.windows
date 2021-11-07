// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public unsafe partial struct D3D11_TRACE_VALUE
    {
        [NativeTypeName("UINT [4]")]
        public fixed uint Bits[4];

        [NativeTypeName("D3D11_TRACE_COMPONENT_MASK")]
        public byte ValidMask;
    }
}
