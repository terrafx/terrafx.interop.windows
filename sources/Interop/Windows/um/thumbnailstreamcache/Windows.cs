// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbnailstreamcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IThumbnailStreamCache = new Guid(0x90E11430, 0x9569, 0x41D8, 0xAE, 0x75, 0x6D, 0x4D, 0x2A, 0xE7, 0xCC, 0xA0);

        public static readonly Guid IID_ThumbnailStreamCache = new Guid(0xCBE0FED3, 0x4B91, 0x4E90, 0x83, 0x54, 0x8A, 0x8C, 0x84, 0xEC, 0x68, 0x72);
    }
}
