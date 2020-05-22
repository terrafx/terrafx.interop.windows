// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class DXGI
    {
        public const uint DXGI_USAGE_SHADER_INPUT = 0x00000010;

        public const uint DXGI_USAGE_RENDER_TARGET_OUTPUT = 0x00000020;

        public const uint DXGI_USAGE_BACK_BUFFER = 0x00000040;

        public const uint DXGI_USAGE_SHARED = 0x00000080;

        public const uint DXGI_USAGE_READ_ONLY = 0x00000100;

        public const uint DXGI_USAGE_DISCARD_ON_PRESENT = 0x00000200;

        public const uint DXGI_USAGE_UNORDERED_ACCESS = 0x00000400;

        public const uint DXGI_RESOURCE_PRIORITY_MINIMUM = 0x28000000;

        public const uint DXGI_RESOURCE_PRIORITY_LOW = 0x50000000;

        public const uint DXGI_RESOURCE_PRIORITY_NORMAL = 0x78000000;

        public const uint DXGI_RESOURCE_PRIORITY_HIGH = 0xA0000000;

        public const uint DXGI_RESOURCE_PRIORITY_MAXIMUM = 0xC8000000;

        public const uint DXGI_MAP_READ = 1;

        public const uint DXGI_MAP_WRITE = 2;

        public const uint DXGI_MAP_DISCARD = 4;

        public const uint DXGI_ENUM_MODES_INTERLACED = 1;

        public const uint DXGI_ENUM_MODES_SCALING = 2;

        public const uint DXGI_MAX_SWAP_CHAIN_BUFFERS = 16;

        public const uint DXGI_PRESENT_TEST = 0x00000001;

        public const uint DXGI_PRESENT_DO_NOT_SEQUENCE = 0x00000002;

        public const uint DXGI_PRESENT_RESTART = 0x00000004;

        public const uint DXGI_PRESENT_DO_NOT_WAIT = 0x00000008;

        public const uint DXGI_PRESENT_STEREO_PREFER_RIGHT = 0x00000010;

        public const uint DXGI_PRESENT_STEREO_TEMPORARY_MONO = 0x00000020;

        public const uint DXGI_PRESENT_RESTRICT_TO_OUTPUT = 0x00000040;

        public const uint DXGI_PRESENT_USE_DURATION = 0x00000100;

        public const uint DXGI_PRESENT_ALLOW_TEARING = 0x00000200;

        public const uint DXGI_MWA_NO_WINDOW_CHANGES = 1 << 0;

        public const uint DXGI_MWA_NO_ALT_ENTER = 1 << 1;

        public const uint DXGI_MWA_NO_PRINT_SCREEN = 1 << 2;

        public const uint DXGI_MWA_VALID = 0x7;

        public static readonly Guid IID_IDXGIObject = new Guid(0xAEC22FB8, 0x76F3, 0x4639, 0x9B, 0xE0, 0x28, 0xEB, 0x43, 0xA6, 0x7A, 0x2E);

        public static readonly Guid IID_IDXGIDeviceSubObject = new Guid(0x3D3E0379, 0xF9DE, 0x4D58, 0xBB, 0x6C, 0x18, 0xD6, 0x29, 0x92, 0xF1, 0xA6);

        public static readonly Guid IID_IDXGIResource = new Guid(0x035F3AB4, 0x482E, 0x4E50, 0xB4, 0x1F, 0x8A, 0x7F, 0x8B, 0xD8, 0x96, 0x0B);

        public static readonly Guid IID_IDXGIKeyedMutex = new Guid(0x9D8E1289, 0xD7B3, 0x465F, 0x81, 0x26, 0x25, 0x0E, 0x34, 0x9A, 0xF8, 0x5D);

        public static readonly Guid IID_IDXGISurface = new Guid(0xCAFCB56C, 0x6AC3, 0x4889, 0xBF, 0x47, 0x9E, 0x23, 0xBB, 0xD2, 0x60, 0xEC);

        public static readonly Guid IID_IDXGISurface1 = new Guid(0x4AE63092, 0x6327, 0x4C1B, 0x80, 0xAE, 0xBF, 0xE1, 0x2E, 0xA3, 0x2B, 0x86);

        public static readonly Guid IID_IDXGIAdapter = new Guid(0x2411E7E1, 0x12AC, 0x4CCF, 0xBD, 0x14, 0x97, 0x98, 0xE8, 0x53, 0x4D, 0xC0);

        public static readonly Guid IID_IDXGIOutput = new Guid(0xAE02EEDB, 0xC735, 0x4690, 0x8D, 0x52, 0x5A, 0x8D, 0xC2, 0x02, 0x13, 0xAA);

        public static readonly Guid IID_IDXGISwapChain = new Guid(0x310D36A0, 0xD2E7, 0x4C0A, 0xAA, 0x04, 0x6A, 0x9D, 0x23, 0xB8, 0x88, 0x6A);

        public static readonly Guid IID_IDXGIFactory = new Guid(0x7B7166EC, 0x21C7, 0x44AE, 0xB2, 0x1A, 0xC9, 0xAE, 0x32, 0x1A, 0xE3, 0x69);

        public static readonly Guid IID_IDXGIDevice = new Guid(0x54EC77FA, 0x1377, 0x44E6, 0x8C, 0x32, 0x88, 0xFD, 0x5F, 0x44, 0xC8, 0x4C);

        public static readonly Guid IID_IDXGIFactory1 = new Guid(0x770AAE78, 0xF26F, 0x4DBA, 0xA8, 0x29, 0x25, 0x3C, 0x83, 0xD1, 0xB3, 0x87);

        public static readonly Guid IID_IDXGIAdapter1 = new Guid(0x29038F61, 0x3839, 0x4626, 0x91, 0xFD, 0x08, 0x68, 0x79, 0x01, 0x1A, 0x05);

        public static readonly Guid IID_IDXGIDevice1 = new Guid(0x77DB970F, 0x6276, 0x48BA, 0xBA, 0x28, 0x07, 0x01, 0x43, 0xB4, 0x39, 0x2C);
    }
}
