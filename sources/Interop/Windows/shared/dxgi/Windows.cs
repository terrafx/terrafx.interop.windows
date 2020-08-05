// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("dxgi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateDXGIFactory([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppFactory);

        [DllImport("dxgi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateDXGIFactory1([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppFactory);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIObject = new Guid(0xaec22fb8, 0x76f3, 0x4639, 0x9b, 0xe0, 0x28, 0xeb, 0x43, 0xa6, 0x7a, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIDeviceSubObject = new Guid(0x3d3e0379, 0xf9de, 0x4d58, 0xbb, 0x6c, 0x18, 0xd6, 0x29, 0x92, 0xf1, 0xa6);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIResource = new Guid(0x035f3ab4, 0x482e, 0x4e50, 0xb4, 0x1f, 0x8a, 0x7f, 0x8b, 0xd8, 0x96, 0x0b);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIKeyedMutex = new Guid(0x9d8e1289, 0xd7b3, 0x465f, 0x81, 0x26, 0x25, 0x0e, 0x34, 0x9a, 0xf8, 0x5d);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGISurface = new Guid(0xcafcb56c, 0x6ac3, 0x4889, 0xbf, 0x47, 0x9e, 0x23, 0xbb, 0xd2, 0x60, 0xec);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGISurface1 = new Guid(0x4AE63092, 0x6327, 0x4c1b, 0x80, 0xAE, 0xBF, 0xE1, 0x2E, 0xA3, 0x2B, 0x86);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIAdapter = new Guid(0x2411e7e1, 0x12ac, 0x4ccf, 0xbd, 0x14, 0x97, 0x98, 0xe8, 0x53, 0x4d, 0xc0);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIOutput = new Guid(0xae02eedb, 0xc735, 0x4690, 0x8d, 0x52, 0x5a, 0x8d, 0xc2, 0x02, 0x13, 0xaa);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGISwapChain = new Guid(0x310d36a0, 0xd2e7, 0x4c0a, 0xaa, 0x04, 0x6a, 0x9d, 0x23, 0xb8, 0x88, 0x6a);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIFactory = new Guid(0x7b7166ec, 0x21c7, 0x44ae, 0xb2, 0x1a, 0xc9, 0xae, 0x32, 0x1a, 0xe3, 0x69);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIDevice = new Guid(0x54ec77fa, 0x1377, 0x44e6, 0x8c, 0x32, 0x88, 0xfd, 0x5f, 0x44, 0xc8, 0x4c);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIFactory1 = new Guid(0x770aae78, 0xf26f, 0x4dba, 0xa8, 0x29, 0x25, 0x3c, 0x83, 0xd1, 0xb3, 0x87);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIAdapter1 = new Guid(0x29038f61, 0x3839, 0x4626, 0x91, 0xfd, 0x08, 0x68, 0x79, 0x01, 0x1a, 0x05);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIDevice1 = new Guid(0x77db970f, 0x6276, 0x48ba, 0xba, 0x28, 0x07, 0x01, 0x43, 0xb4, 0x39, 0x2c);

        [NativeTypeName("#define DXGI_USAGE_SHADER_INPUT 0x00000010UL")]
        public const uint DXGI_USAGE_SHADER_INPUT = 0x00000010U;

        [NativeTypeName("#define DXGI_USAGE_RENDER_TARGET_OUTPUT 0x00000020UL")]
        public const uint DXGI_USAGE_RENDER_TARGET_OUTPUT = 0x00000020U;

        [NativeTypeName("#define DXGI_USAGE_BACK_BUFFER 0x00000040UL")]
        public const uint DXGI_USAGE_BACK_BUFFER = 0x00000040U;

        [NativeTypeName("#define DXGI_USAGE_SHARED 0x00000080UL")]
        public const uint DXGI_USAGE_SHARED = 0x00000080U;

        [NativeTypeName("#define DXGI_USAGE_READ_ONLY 0x00000100UL")]
        public const uint DXGI_USAGE_READ_ONLY = 0x00000100U;

        [NativeTypeName("#define DXGI_USAGE_DISCARD_ON_PRESENT 0x00000200UL")]
        public const uint DXGI_USAGE_DISCARD_ON_PRESENT = 0x00000200U;

        [NativeTypeName("#define DXGI_USAGE_UNORDERED_ACCESS 0x00000400UL")]
        public const uint DXGI_USAGE_UNORDERED_ACCESS = 0x00000400U;

        [NativeTypeName("#define DXGI_RESOURCE_PRIORITY_MINIMUM ( 0x28000000 )")]
        public const int DXGI_RESOURCE_PRIORITY_MINIMUM = (0x28000000);

        [NativeTypeName("#define DXGI_RESOURCE_PRIORITY_LOW ( 0x50000000 )")]
        public const int DXGI_RESOURCE_PRIORITY_LOW = (0x50000000);

        [NativeTypeName("#define DXGI_RESOURCE_PRIORITY_NORMAL ( 0x78000000 )")]
        public const int DXGI_RESOURCE_PRIORITY_NORMAL = (0x78000000);

        [NativeTypeName("#define DXGI_RESOURCE_PRIORITY_HIGH ( 0xa0000000 )")]
        public const uint DXGI_RESOURCE_PRIORITY_HIGH = (0xa0000000);

        [NativeTypeName("#define DXGI_RESOURCE_PRIORITY_MAXIMUM ( 0xc8000000 )")]
        public const uint DXGI_RESOURCE_PRIORITY_MAXIMUM = (0xc8000000);

        [NativeTypeName("#define DXGI_MAP_READ ( 1UL )")]
        public const uint DXGI_MAP_READ = (1U);

        [NativeTypeName("#define DXGI_MAP_WRITE ( 2UL )")]
        public const uint DXGI_MAP_WRITE = (2U);

        [NativeTypeName("#define DXGI_MAP_DISCARD ( 4UL )")]
        public const uint DXGI_MAP_DISCARD = (4U);

        [NativeTypeName("#define DXGI_ENUM_MODES_INTERLACED ( 1UL )")]
        public const uint DXGI_ENUM_MODES_INTERLACED = (1U);

        [NativeTypeName("#define DXGI_ENUM_MODES_SCALING ( 2UL )")]
        public const uint DXGI_ENUM_MODES_SCALING = (2U);

        [NativeTypeName("#define DXGI_MAX_SWAP_CHAIN_BUFFERS ( 16 )")]
        public const int DXGI_MAX_SWAP_CHAIN_BUFFERS = (16);

        [NativeTypeName("#define DXGI_PRESENT_TEST 0x00000001UL")]
        public const uint DXGI_PRESENT_TEST = 0x00000001U;

        [NativeTypeName("#define DXGI_PRESENT_DO_NOT_SEQUENCE 0x00000002UL")]
        public const uint DXGI_PRESENT_DO_NOT_SEQUENCE = 0x00000002U;

        [NativeTypeName("#define DXGI_PRESENT_RESTART 0x00000004UL")]
        public const uint DXGI_PRESENT_RESTART = 0x00000004U;

        [NativeTypeName("#define DXGI_PRESENT_DO_NOT_WAIT 0x00000008UL")]
        public const uint DXGI_PRESENT_DO_NOT_WAIT = 0x00000008U;

        [NativeTypeName("#define DXGI_PRESENT_STEREO_PREFER_RIGHT 0x00000010UL")]
        public const uint DXGI_PRESENT_STEREO_PREFER_RIGHT = 0x00000010U;

        [NativeTypeName("#define DXGI_PRESENT_STEREO_TEMPORARY_MONO 0x00000020UL")]
        public const uint DXGI_PRESENT_STEREO_TEMPORARY_MONO = 0x00000020U;

        [NativeTypeName("#define DXGI_PRESENT_RESTRICT_TO_OUTPUT 0x00000040UL")]
        public const uint DXGI_PRESENT_RESTRICT_TO_OUTPUT = 0x00000040U;

        [NativeTypeName("#define DXGI_PRESENT_USE_DURATION 0x00000100UL")]
        public const uint DXGI_PRESENT_USE_DURATION = 0x00000100U;

        [NativeTypeName("#define DXGI_PRESENT_ALLOW_TEARING 0x00000200UL")]
        public const uint DXGI_PRESENT_ALLOW_TEARING = 0x00000200U;

        [NativeTypeName("#define DXGI_MWA_NO_WINDOW_CHANGES ( 1 << 0 )")]
        public const int DXGI_MWA_NO_WINDOW_CHANGES = (1 << 0);

        [NativeTypeName("#define DXGI_MWA_NO_ALT_ENTER ( 1 << 1 )")]
        public const int DXGI_MWA_NO_ALT_ENTER = (1 << 1);

        [NativeTypeName("#define DXGI_MWA_NO_PRINT_SCREEN ( 1 << 2 )")]
        public const int DXGI_MWA_NO_PRINT_SCREEN = (1 << 2);

        [NativeTypeName("#define DXGI_MWA_VALID ( 0x7 )")]
        public const int DXGI_MWA_VALID = (0x7);
    }
}
