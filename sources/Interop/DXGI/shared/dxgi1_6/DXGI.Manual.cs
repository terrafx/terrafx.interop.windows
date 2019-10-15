// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class DXGI
    {
        public static readonly Guid IID_IDXGIAdapter4 = new Guid(0x3C8D99D1, 0x4FBF, 0x4181, 0xA8, 0x2C, 0xAF, 0x66, 0xBF, 0x7B, 0xD2, 0x4E);

        public static readonly Guid IID_IDXGIOutput6 = new Guid(0x068346E8, 0xAAEC, 0x4B84, 0xAD, 0xD7, 0x13, 0x7F, 0x51, 0x3F, 0x77, 0xA1);

        public static readonly Guid IID_IDXGIFactory6 = new Guid(0xC1B6694F, 0xFF09, 0x44A9, 0xB0, 0x3C, 0x77, 0x90, 0x0A, 0x0A, 0x1D, 0x17);

        public static readonly Guid IID_IDXGIFactory7 = new Guid(0xA4966EED, 0x76DB, 0x44DA, 0x84, 0xC1, 0xEE, 0x9A, 0x7A, 0xFB, 0x20, 0xA8);
    }
}
