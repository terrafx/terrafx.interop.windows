// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX
{
    public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES
    {
        public uint NodeIndex;

        public uint ProfileCount;

        public Guid* pProfiles;
    }
}
