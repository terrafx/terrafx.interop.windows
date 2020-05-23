// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const uint D3D11_PACKED_TILE = 0xFFFFFFFF;

        public static readonly Guid IID_ID3D11DeviceContext2 = new Guid(0x420D5B32, 0xB90C, 0x4DA4, 0xBE, 0xF0, 0x35, 0x9F, 0x6A, 0x24, 0xA8, 0x3A);

        public static readonly Guid IID_ID3D11Device2 = new Guid(0x9D06DFFA, 0xD1E5, 0x4D07, 0x83, 0xA8, 0x1B, 0xB1, 0x23, 0xF2, 0xF8, 0x41);
    }
}
