// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public struct D3D12_DEPTH_STENCIL_VIEW_DESC
    {
        #region Fields
        public DXGI_FORMAT Format;

        public D3D12_DSV_DIMENSION ViewDimension;

        public D3D12_DSV_FLAGS Flags;

        public _Anonymous_e__Union Anonymous;
        #endregion

        #region Structs
        [StructLayout(LayoutKind.Explicit)]
        public struct _Anonymous_e__Union
        {
            #region Fields
            [FieldOffset(0)]
            public D3D12_TEX1D_DSV Texture1D;

            [FieldOffset(0)]
            public D3D12_TEX1D_ARRAY_DSV Texture1DArray;

            [FieldOffset(0)]
            public D3D12_TEX2D_DSV Texture2D;

            [FieldOffset(0)]
            public D3D12_TEX2D_ARRAY_DSV Texture2DArray;

            [FieldOffset(0)]
            public D3D12_TEX2DMS_DSV Texture2DMS;

            [FieldOffset(0)]
            public D3D12_TEX2DMS_ARRAY_DSV Texture2DMSArray;
            #endregion
        }
        #endregion
    }
}
