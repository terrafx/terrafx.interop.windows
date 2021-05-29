// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D11_VIDEO_DECODER_CAPS
    {
        D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE = 0x1,
        D3D11_VIDEO_DECODER_CAPS_NON_REAL_TIME = 0x2,
        D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_DYNAMIC = 0x4,
        D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_REQUIRED = 0x8,
        D3D11_VIDEO_DECODER_CAPS_UNSUPPORTED = 0x10,
    }
}
