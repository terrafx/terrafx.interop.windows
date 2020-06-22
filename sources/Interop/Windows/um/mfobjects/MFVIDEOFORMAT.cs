// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct MFVIDEOFORMAT
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        public MFVideoInfo videoInfo;

        [NativeTypeName("GUID")]
        public Guid guidFormat;

        public MFVideoCompressedInfo compressedInfo;

        public MFVideoSurfaceInfo surfaceInfo;
    }
}
