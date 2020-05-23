// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("d3d11", EntryPoint = "D3D11On12CreateDevice", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D11On12CreateDevice([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, [NativeTypeName("UINT")] uint FeatureLevels, [NativeTypeName("IUnknown *const *")] IUnknown** ppCommandQueues, [NativeTypeName("UINT")] uint NumQueues, [NativeTypeName("UINT")] uint NodeMask, [NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice, [NativeTypeName("ID3D11DeviceContext **")] ID3D11DeviceContext** ppImmediateContext, [NativeTypeName("D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pChosenFeatureLevel);
    }
}
