// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIDisplayControl = new Guid(0xea9dbf1a, 0xc88e, 0x4486, 0x85, 0x4a, 0x98, 0xaa, 0x01, 0x38, 0xf3, 0x0c);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIOutputDuplication = new Guid(0x191cfac3, 0xa341, 0x470d, 0xb2, 0x6e, 0xa8, 0x64, 0xf4, 0x28, 0x31, 0x9c);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGISurface2 = new Guid(0xaba496dd, 0xb617, 0x4cb8, 0xa8, 0x66, 0xbc, 0x44, 0xd7, 0xeb, 0x1f, 0xa2);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIResource1 = new Guid(0x30961379, 0x4609, 0x4a41, 0x99, 0x8e, 0x54, 0xfe, 0x56, 0x7e, 0xe0, 0xc1);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIDevice2 = new Guid(0x05008617, 0xfbfd, 0x4051, 0xa7, 0x90, 0x14, 0x48, 0x84, 0xb4, 0xf6, 0xa9);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGISwapChain1 = new Guid(0x790a45f7, 0x0d42, 0x4876, 0x98, 0x3a, 0x0a, 0x55, 0xcf, 0xe6, 0xf4, 0xaa);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIFactory2 = new Guid(0x50c83a1c, 0xe072, 0x4c48, 0x87, 0xb0, 0x36, 0x30, 0xfa, 0x36, 0xa6, 0xd0);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIAdapter2 = new Guid(0x0AA1AE0A, 0xFA0E, 0x4B84, 0x86, 0x44, 0xE0, 0x5F, 0xF8, 0xE5, 0xAC, 0xB5);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIOutput1 = new Guid(0x00cddea8, 0x939b, 0x4b83, 0xa3, 0x40, 0xa6, 0x85, 0x22, 0x66, 0x66, 0xcc);

        [NativeTypeName("#define DXGI_ENUM_MODES_STEREO ( 4UL )")]
        public const uint DXGI_ENUM_MODES_STEREO = (4U);

        [NativeTypeName("#define DXGI_ENUM_MODES_DISABLED_STEREO ( 8UL )")]
        public const uint DXGI_ENUM_MODES_DISABLED_STEREO = (8U);

        [NativeTypeName("#define DXGI_SHARED_RESOURCE_READ ( 0x80000000L )")]
        public const uint DXGI_SHARED_RESOURCE_READ = (0x80000000);

        [NativeTypeName("#define DXGI_SHARED_RESOURCE_WRITE ( 1 )")]
        public const int DXGI_SHARED_RESOURCE_WRITE = (1);
    }
}
