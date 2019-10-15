// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_VIDEO_DECODE_ARGUMENT_TYPE
    {
        D3D12_VIDEO_DECODE_ARGUMENT_TYPE_PICTURE_PARAMETERS = 0,
        D3D12_VIDEO_DECODE_ARGUMENT_TYPE_INVERSE_QUANTIZATION_MATRIX = 1,
        D3D12_VIDEO_DECODE_ARGUMENT_TYPE_SLICE_CONTROL = 2,
        D3D12_VIDEO_DECODE_ARGUMENT_TYPE_MAX_VALID = 3,
    }
}
