// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct MFVideoCompressedInfo
    {
        [NativeTypeName("LONGLONG")]
        public long AvgBitrate;

        [NativeTypeName("LONGLONG")]
        public long AvgBitErrorRate;

        [NativeTypeName("DWORD")]
        public uint MaxKeyFrameSpacing;
    }
}
