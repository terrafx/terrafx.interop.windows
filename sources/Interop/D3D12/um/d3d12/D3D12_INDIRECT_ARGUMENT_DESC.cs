// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D12_INDIRECT_ARGUMENT_DESC
    {
        public D3D12_INDIRECT_ARGUMENT_TYPE Type;

        [NativeTypeName("D3D12_INDIRECT_ARGUMENT_DESC::(anonymous union at um/d3d12.h:3840:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at um/d3d12.h:3842:9)")]
            public _VertexBuffer_e__Struct VertexBuffer;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at um/d3d12.h:3846:9)")]
            public _Constant_e__Struct Constant;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at um/d3d12.h:3852:9)")]
            public _ConstantBufferView_e__Struct ConstantBufferView;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at um/d3d12.h:3856:9)")]
            public _ShaderResourceView_e__Struct ShaderResourceView;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at um/d3d12.h:3860:9)")]
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
