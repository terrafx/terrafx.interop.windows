// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies the container format of a font resource. A container format is distinct from a font file format (DWRITE_FONT_FILE_TYPE) because the container describes the container in which the underlying font file is packaged.</summary>
    public enum DWRITE_CONTAINER_TYPE
    {
        DWRITE_CONTAINER_TYPE_UNKNOWN,

        DWRITE_CONTAINER_TYPE_WOFF,

        DWRITE_CONTAINER_TYPE_WOFF2
    }
}
