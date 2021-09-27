// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10misc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DeviceType
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0xFB, 0x22, 0xD7,
                    0x68, 0x7A,
                    0x7A, 0x43,
                    0xB2,
                    0x0C,
                    0x58,
                    0x04,
                    0xEE,
                    0x24,
                    0x94,
                    0xA6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

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
