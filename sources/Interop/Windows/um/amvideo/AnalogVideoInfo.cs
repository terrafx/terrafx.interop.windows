// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct AnalogVideoInfo
    {
        public RECT rcSource;

        public RECT rcTarget;

        [NativeTypeName("DWORD")]
        public uint dwActiveWidth;

        [NativeTypeName("DWORD")]
        public uint dwActiveHeight;

        [NativeTypeName("REFERENCE_TIME")]
        public long AvgTimePerFrame;
    }
}
