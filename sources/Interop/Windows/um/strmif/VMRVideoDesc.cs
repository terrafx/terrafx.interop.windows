// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct VMRVideoDesc
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwSampleWidth;

        [NativeTypeName("DWORD")]
        public uint dwSampleHeight;

        public BOOL SingleFieldPerSample;

        [NativeTypeName("DWORD")]
        public uint dwFourCC;

        public VMRFrequency InputSampleFreq;

        public VMRFrequency OutputFrameFreq;
    }
}
