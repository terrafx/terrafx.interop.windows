// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DVD_HMSF_TIMECODE
    {
        [NativeTypeName("BYTE")]
        public byte bHours;

        [NativeTypeName("BYTE")]
        public byte bMinutes;

        [NativeTypeName("BYTE")]
        public byte bSeconds;

        [NativeTypeName("BYTE")]
        public byte bFrames;
    }
}
