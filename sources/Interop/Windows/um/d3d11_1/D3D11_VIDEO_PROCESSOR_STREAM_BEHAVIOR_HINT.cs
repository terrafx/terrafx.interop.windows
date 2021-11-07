// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0")]
    public partial struct D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT
    {
        public BOOL Enable;

        public uint Width;

        public uint Height;

        public DXGI_FORMAT Format;
    }
}
