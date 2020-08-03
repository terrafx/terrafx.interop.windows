// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D12_SHADER_RESOURCE_VIEW_DESC
    {
        public DXGI_FORMAT Format;

        public D3D12_SRV_DIMENSION ViewDimension;

        [NativeTypeName("UINT")]
        public uint Shader4ComponentMapping;

        [NativeTypeName("D3D12_SHADER_RESOURCE_VIEW_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d12.h:2965:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref D3D12_BUFFER_SRV Buffer => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Buffer, 1));

        public ref D3D12_TEX1D_SRV Texture1D => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture1D, 1));

        public ref D3D12_TEX1D_ARRAY_SRV Texture1DArray => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture1DArray, 1));

        public ref D3D12_TEX2D_SRV Texture2D => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2D, 1));

        public ref D3D12_TEX2D_ARRAY_SRV Texture2DArray => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2DArray, 1));

        public ref D3D12_TEX2DMS_SRV Texture2DMS => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2DMS, 1));

        public ref D3D12_TEX2DMS_ARRAY_SRV Texture2DMSArray => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2DMSArray, 1));

        public ref D3D12_TEX3D_SRV Texture3D => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture3D, 1));

        public ref D3D12_TEXCUBE_SRV TextureCube => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.TextureCube, 1));

        public ref D3D12_TEXCUBE_ARRAY_SRV TextureCubeArray => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.TextureCubeArray, 1));

        public ref D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV RaytracingAccelerationStructure => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.RaytracingAccelerationStructure, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D12_BUFFER_SRV Buffer;

            [FieldOffset(0)]
            public D3D12_TEX1D_SRV Texture1D;

            [FieldOffset(0)]
            public D3D12_TEX1D_ARRAY_SRV Texture1DArray;

            [FieldOffset(0)]
            public D3D12_TEX2D_SRV Texture2D;

            [FieldOffset(0)]
            public D3D12_TEX2D_ARRAY_SRV Texture2DArray;

            [FieldOffset(0)]
            public D3D12_TEX2DMS_SRV Texture2DMS;

            [FieldOffset(0)]
            public D3D12_TEX2DMS_ARRAY_SRV Texture2DMSArray;

            [FieldOffset(0)]
            public D3D12_TEX3D_SRV Texture3D;

            [FieldOffset(0)]
            public D3D12_TEXCUBE_SRV TextureCube;

            [FieldOffset(0)]
            public D3D12_TEXCUBE_ARRAY_SRV TextureCubeArray;

            [FieldOffset(0)]
            public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV RaytracingAccelerationStructure;
        }
    }
}
