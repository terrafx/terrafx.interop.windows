// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [DllImport("dxgi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DXGIDeclareAdapterRemovalSupport();

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIAdapter4 = new Guid(0x3c8d99d1, 0x4fbf, 0x4181, 0xa8, 0x2c, 0xaf, 0x66, 0xbf, 0x7b, 0xd2, 0x4e);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIOutput6 = new Guid(0x068346e8, 0xaaec, 0x4b84, 0xad, 0xd7, 0x13, 0x7f, 0x51, 0x3f, 0x77, 0xa1);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIFactory6 = new Guid(0xc1b6694f, 0xff09, 0x44a9, 0xb0, 0x3c, 0x77, 0x90, 0x0a, 0x0a, 0x1d, 0x17);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDXGIFactory7 = new Guid(0xa4966eed, 0x76db, 0x44da, 0x84, 0xc1, 0xee, 0x9a, 0x7a, 0xfb, 0x20, 0xa8);
    }
}
