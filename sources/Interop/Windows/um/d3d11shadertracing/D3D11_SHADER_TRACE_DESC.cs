// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_SHADER_TRACE_DESC
    {
        public D3D11_SHADER_TYPE Type;

        [NativeTypeName("UINT")]
        public uint Flags;

        [NativeTypeName("D3D11_SHADER_TRACE_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d11shadertracing.h:126:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D11_VERTEX_SHADER_TRACE_DESC VertexShaderTraceDesc;

            [FieldOffset(0)]
            public D3D11_HULL_SHADER_TRACE_DESC HullShaderTraceDesc;

            [FieldOffset(0)]
            public D3D11_DOMAIN_SHADER_TRACE_DESC DomainShaderTraceDesc;

            [FieldOffset(0)]
            public D3D11_GEOMETRY_SHADER_TRACE_DESC GeometryShaderTraceDesc;

            [FieldOffset(0)]
            public D3D11_PIXEL_SHADER_TRACE_DESC PixelShaderTraceDesc;

            [FieldOffset(0)]
            public D3D11_COMPUTE_SHADER_TRACE_DESC ComputeShaderTraceDesc;
        }
    }
}
