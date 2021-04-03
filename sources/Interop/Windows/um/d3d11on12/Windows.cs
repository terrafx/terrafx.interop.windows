// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("d3d11", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D11On12CreateDevice(IUnknown* pDevice, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, [NativeTypeName("UINT")] uint FeatureLevels, [NativeTypeName("IUnknown *const *")] IUnknown** ppCommandQueues, [NativeTypeName("UINT")] uint NumQueues, [NativeTypeName("UINT")] uint NodeMask, ID3D11Device** ppDevice, ID3D11DeviceContext** ppImmediateContext, D3D_FEATURE_LEVEL* pChosenFeatureLevel);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11On12Device = new Guid(0x85611e73, 0x70a9, 0x490e, 0x96, 0x14, 0xa9, 0xe3, 0x02, 0x77, 0x79, 0x04);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11On12Device1 = new Guid(0xbdb64df4, 0xea2f, 0x4c70, 0xb8, 0x61, 0xaa, 0xab, 0x12, 0x58, 0xbb, 0x5d);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D11On12Device2 = new Guid(0xdc90f331, 0x4740, 0x43fa, 0x86, 0x6e, 0x67, 0xf1, 0x2c, 0xb5, 0x82, 0x23);
    }
}
