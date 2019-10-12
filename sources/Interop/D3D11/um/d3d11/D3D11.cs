// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d11.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class D3D11
    {
        private const string LibraryPath = "D3D11";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl, EntryPoint = "D3D11CreateDevice", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D11CreateDevice([NativeTypeName("IDXGIAdapter *")] IDXGIAdapter* pAdapter, D3D_DRIVER_TYPE DriverType, [NativeTypeName("HMODULE")] IntPtr Software, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, [NativeTypeName("UINT")] uint FeatureLevels, [NativeTypeName("UINT")] uint SDKVersion, [NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice, [NativeTypeName("D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevel, [NativeTypeName("ID3D11DeviceContext **")] ID3D11DeviceContext** ppImmediateContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl, EntryPoint = "D3D11CreateDeviceAndSwapChain", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D11CreateDeviceAndSwapChain([NativeTypeName("IDXGIAdapter *")] IDXGIAdapter* pAdapter, D3D_DRIVER_TYPE DriverType, [NativeTypeName("HMODULE")] IntPtr Software, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels, [NativeTypeName("UINT")] uint FeatureLevels, [NativeTypeName("UINT")] uint SDKVersion, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, [NativeTypeName("IDXGISwapChain **")] IDXGISwapChain** ppSwapChain, [NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice, [NativeTypeName("D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevel, [NativeTypeName("ID3D11DeviceContext **")] ID3D11DeviceContext** ppImmediateContext);
    }
}
