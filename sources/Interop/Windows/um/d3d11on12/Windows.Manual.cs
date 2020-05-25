// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid IID_ID3D11On12Device = new Guid(0x85611E73, 0x70A9, 0x490E, 0x96, 0x14, 0xA9, 0xE3, 0x02, 0x77, 0x79, 0x04);

        public static readonly Guid IID_ID3D11On12Device1 = new Guid(0xBDB64DF4, 0xEA2F, 0x4C70, 0xB8, 0x61, 0xAA, 0xAB, 0x12, 0x58, 0xBB, 0x5D);

        public static readonly Guid IID_ID3D11On12Device2 = new Guid(0xDC90F331, 0x4740, 0x43FA, 0x86, 0x6E, 0x67, 0xF1, 0x2C, 0xB5, 0x82, 0x23);
    }
}
