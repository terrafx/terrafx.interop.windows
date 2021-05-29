// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_VIDEO_PROCESSOR_CAPS
    {
        [NativeTypeName("UINT")]
        public uint DeviceCaps;

        [NativeTypeName("UINT")]
        public uint FeatureCaps;

        [NativeTypeName("UINT")]
        public uint FilterCaps;

        [NativeTypeName("UINT")]
        public uint InputFormatCaps;

        [NativeTypeName("UINT")]
        public uint AutoStreamCaps;

        [NativeTypeName("UINT")]
        public uint StereoCaps;

        [NativeTypeName("UINT")]
        public uint RateConversionCapsCount;

        [NativeTypeName("UINT")]
        public uint MaxInputStreams;

        [NativeTypeName("UINT")]
        public uint MaxStreamStates;
    }
}
