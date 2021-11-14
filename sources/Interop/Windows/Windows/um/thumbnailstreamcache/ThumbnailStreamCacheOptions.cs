// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbnailstreamcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0")]
    public enum ThumbnailStreamCacheOptions
    {
        ExtractIfNotCached = 0,
        ReturnOnlyIfCached = 0x1,
        ResizeThumbnail = 0x2,
        AllowSmallerSize = 0x4,
    }
}
