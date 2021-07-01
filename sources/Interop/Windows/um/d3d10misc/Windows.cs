// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10misc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_DeviceType = new Guid(0xd722fb4d, 0x7a68, 0x437a, 0xb2, 0x0c, 0x58, 0x04, 0xee, 0x24, 0x94, 0xa6);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10CreateDevice(IDXGIAdapter* pAdapter, D3D10_DRIVER_TYPE DriverType, [NativeTypeName("HMODULE")] IntPtr Software, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT")] uint SDKVersion, ID3D10Device** ppDevice);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10CreateDeviceAndSwapChain(IDXGIAdapter* pAdapter, D3D10_DRIVER_TYPE DriverType, [NativeTypeName("HMODULE")] IntPtr Software, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT")] uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D10Device** ppDevice);

        [DllImport("d3d10", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D10CreateBlob([NativeTypeName("SIZE_T")] nuint NumBytes, [NativeTypeName("LPD3D10BLOB *")] ID3DBlob** ppBuffer);
    }
}
