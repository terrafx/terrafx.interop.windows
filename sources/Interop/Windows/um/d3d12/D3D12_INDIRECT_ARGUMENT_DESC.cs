// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct D3D12_INDIRECT_ARGUMENT_DESC
    {
        #region Fields
        public D3D12_INDIRECT_ARGUMENT_TYPE Type;

        public _Anonymous_e__Union Anonymous;
        #endregion

        #region Structs
        [StructLayout(LayoutKind.Explicit)]
        [Unmanaged]
        public struct _Anonymous_e__Union
        {
            #region Fields
            [FieldOffset(0)]
            public _VertexBuffer_e__Struct VertexBuffer;

            [FieldOffset(0)]
            public _Constant_e__Struct Constant;

            [FieldOffset(0)]
            public _ConstantBufferView_e__Struct ConstantBufferView;

            [FieldOffset(0)]
            public _ShaderResourceView_e__Struct ShaderResourceView;

            [FieldOffset(0)]
            public _UnorderedAccessView_e__Struct UnorderedAccessView;
            #endregion

            #region Structs
            [Unmanaged]
            public struct _VertexBuffer_e__Struct
            {
                #region Fields
                public uint Slot;
                #endregion
            }

            [Unmanaged]
            public struct _Constant_e__Struct
            {
                #region Fields
                public uint RootParameterIndex;
                public uint DestOffsetIn32BitValues;
                public uint Num32BitValuesToSet;
                #endregion
            }

            [Unmanaged]
            public struct _ConstantBufferView_e__Struct
            {
                #region Fields
                public uint RootParameterIndex;
                #endregion
            }

            [Unmanaged]
            public struct _ShaderResourceView_e__Struct
            {
                #region Fields
                public uint RootParameterIndex;
                #endregion
            }

            [Unmanaged]
            public struct _UnorderedAccessView_e__Struct
            {
                #region Fields
                public uint RootParameterIndex;
                #endregion
            }
            #endregion
        }
        #endregion
    }
}
