// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D12_INDIRECT_ARGUMENT_DESC
    {
        public D3D12_INDIRECT_ARGUMENT_TYPE Type;

        [NativeTypeName("D3D12_INDIRECT_ARGUMENT_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d12.h:3951:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref _Anonymous_e__Union._VertexBuffer_e__Struct VertexBuffer => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.VertexBuffer, 1));

        public ref _Anonymous_e__Union._Constant_e__Struct Constant => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Constant, 1));

        public ref _Anonymous_e__Union._ConstantBufferView_e__Struct ConstantBufferView => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ConstantBufferView, 1));

        public ref _Anonymous_e__Union._ShaderResourceView_e__Struct ShaderResourceView => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ShaderResourceView, 1));

        public ref _Anonymous_e__Union._UnorderedAccessView_e__Struct UnorderedAccessView => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.UnorderedAccessView, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d12.h:3953:9)")]
            public _VertexBuffer_e__Struct VertexBuffer;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d12.h:3957:9)")]
            public _Constant_e__Struct Constant;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d12.h:3963:9)")]
            public _ConstantBufferView_e__Struct ConstantBufferView;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d12.h:3967:9)")]
            public _ShaderResourceView_e__Struct ShaderResourceView;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d12.h:3971:9)")]
            public _UnorderedAccessView_e__Struct UnorderedAccessView;

            public partial struct _VertexBuffer_e__Struct
            {
                [NativeTypeName("UINT")]
                public uint Slot;
            }

            public partial struct _Constant_e__Struct
            {
                [NativeTypeName("UINT")]
                public uint RootParameterIndex;

                [NativeTypeName("UINT")]
                public uint DestOffsetIn32BitValues;

                [NativeTypeName("UINT")]
                public uint Num32BitValuesToSet;
            }

            public partial struct _ConstantBufferView_e__Struct
            {
                [NativeTypeName("UINT")]
                public uint RootParameterIndex;
            }

            public partial struct _ShaderResourceView_e__Struct
            {
                [NativeTypeName("UINT")]
                public uint RootParameterIndex;
            }

            public partial struct _UnorderedAccessView_e__Struct
            {
                [NativeTypeName("UINT")]
                public uint RootParameterIndex;
            }
        }
    }
}
