// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d11.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS : uint
    {
        D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_32 = 0x1,
        D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_22 = 0x2,
        D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_2224 = 0x4,
        D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_2332 = 0x8,
        D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_32322 = 0x10,
        D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_55 = 0x20,
        D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_64 = 0x40,
        D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_87 = 0x80,
        D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_222222222223 = 0x100,
        D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_OTHER = 0x80000000,
    }
}
