// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_4.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class DXGI
    {
        public static readonly Guid IID_IDXGISwapChain3 = new Guid(0x94D99BDB, 0xF1F8, 0x4AB0, 0xB2, 0x36, 0x7D, 0xA0, 0x17, 0x0E, 0xDA, 0xB1);

        public static readonly Guid IID_IDXGIOutput4 = new Guid(0xDC7DCA35, 0x2196, 0x414D, 0x9F, 0x53, 0x61, 0x78, 0x84, 0x03, 0x2A, 0x60);

        public static readonly Guid IID_IDXGIFactory4 = new Guid(0x1BC6EA02, 0xEF36, 0x464F, 0xBF, 0x0C, 0x21, 0xCA, 0x39, 0xE5, 0x16, 0x8A);

        public static readonly Guid IID_IDXGIAdapter3 = new Guid(0x645967A4, 0x1392, 0x4310, 0xA7, 0x98, 0x80, 0x53, 0xCE, 0x3E, 0x93, 0xFD);
    }
}
