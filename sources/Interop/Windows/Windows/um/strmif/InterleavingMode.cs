// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum InterleavingMode
    {
        INTERLEAVE_NONE = 0,
        INTERLEAVE_CAPTURE = (INTERLEAVE_NONE + 1),
        INTERLEAVE_FULL = (INTERLEAVE_CAPTURE + 1),
        INTERLEAVE_NONE_BUFFERED = (INTERLEAVE_FULL + 1),
    }
}
