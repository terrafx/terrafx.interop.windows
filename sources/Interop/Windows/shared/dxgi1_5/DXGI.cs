// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_5.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class DXGI
    {
        public static readonly Guid IID_IDXGIOutput5 = new Guid(0x80A07424, 0xAB52, 0x42EB, 0x83, 0x3C, 0x0C, 0x42, 0xFD, 0x28, 0x2D, 0x98);

        public static readonly Guid IID_IDXGISwapChain4 = new Guid(0x3D585D5A, 0xBD4A, 0x489E, 0xB1, 0xF4, 0x3D, 0xBC, 0xB6, 0x45, 0x2F, 0xFB);

        public static readonly Guid IID_IDXGIDevice4 = new Guid(0x95B4F95F, 0xD8DA, 0x4CA4, 0x9E, 0xE6, 0x3B, 0x76, 0xD5, 0x96, 0x8A, 0x10);

        public static readonly Guid IID_IDXGIFactory5 = new Guid(0x7632E1F5, 0xEE65, 0x4DCA, 0x87, 0xFD, 0x84, 0xCD, 0x75, 0xF8, 0x83, 0x8D);
    }
}
