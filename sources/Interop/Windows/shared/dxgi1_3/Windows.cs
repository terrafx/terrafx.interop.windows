// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("dxgi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateDXGIFactory2([NativeTypeName("UINT")] uint Flags, [NativeTypeName("const IID &")] Guid* riid, void** ppFactory);

        [DllImport("dxgi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DXGIGetDebugInterface1([NativeTypeName("UINT")] uint Flags, [NativeTypeName("const IID &")] Guid* riid, void** pDebug);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIDevice3 = new Guid(0x6007896c, 0x3244, 0x4afd, 0xbf, 0x18, 0xa6, 0xd3, 0xbe, 0xda, 0x50, 0x23);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGISwapChain2 = new Guid(0xa8be2ac4, 0x199f, 0x4946, 0xb3, 0x31, 0x79, 0x59, 0x9f, 0xb9, 0x8d, 0xe7);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIOutput2 = new Guid(0x595e39d1, 0x2724, 0x4663, 0x99, 0xb1, 0xda, 0x96, 0x9d, 0xe2, 0x83, 0x64);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIFactory3 = new Guid(0x25483823, 0xcd46, 0x4c7d, 0x86, 0xca, 0x47, 0xaa, 0x95, 0xb8, 0x37, 0xbd);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIDecodeSwapChain = new Guid(0x2633066b, 0x4514, 0x4c7a, 0x8f, 0xd8, 0x12, 0xea, 0x98, 0x05, 0x9d, 0x18);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIFactoryMedia = new Guid(0x41e7d1f2, 0xa591, 0x4f7b, 0xa2, 0xe5, 0xfa, 0x9c, 0x84, 0x3e, 0x1c, 0x12);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGISwapChainMedia = new Guid(0xdd95b90b, 0xf05f, 0x4f6a, 0xbd, 0x65, 0x25, 0xbf, 0xb2, 0x64, 0xbd, 0x84);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIOutput3 = new Guid(0x8a6bb301, 0x7e7e, 0x41F4, 0xa8, 0xe0, 0x5b, 0x32, 0xf7, 0xf9, 0x9b, 0x18);

        [NativeTypeName("#define DXGI_CREATE_FACTORY_DEBUG 0x1")]
        public const int DXGI_CREATE_FACTORY_DEBUG = 0x1;
    }
}
