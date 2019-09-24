// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies the locality of a resource.</summary>
    public enum DWRITE_LOCALITY
    {
        /// <summary>The resource is remote, and information is unknown yet, including the file size and date. Attempting to create a font or file stream will fail until locality becomes at least partial.</summary>
        DWRITE_LOCALITY_REMOTE,

        /// <summary>The resource is partially local, meaning you can query the size and date of the file stream, and you may be able to create a font face and retrieve the particular glyphs for metrics and drawing, but not all the glyphs will be present.</summary>
        DWRITE_LOCALITY_PARTIAL,

        /// <summary>The resource is completely local, and all font functions can be called without concern of missing data or errors related to network connectivity.</summary>
        DWRITE_LOCALITY_LOCAL
    }
}
