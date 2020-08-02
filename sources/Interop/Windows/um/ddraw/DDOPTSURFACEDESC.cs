// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct DDOPTSURFACEDESC
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public DDSCAPS2 ddSCaps;

        public DDOSCAPS ddOSCaps;

        [NativeTypeName("GUID")]
        public Guid guid;

        [NativeTypeName("DWORD")]
        public uint dwCompressionRatio;
    }
}
