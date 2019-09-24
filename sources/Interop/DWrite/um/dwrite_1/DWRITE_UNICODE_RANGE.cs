// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Range of Unicode codepoints.</summary>
    public struct DWRITE_UNICODE_RANGE
    {
        /// <summary>The first codepoint in the Unicode range.</summary>
        [NativeTypeName("UINT32")]
        public uint first;

        /// <summary>The last codepoint in the Unicode range.</summary>
        [NativeTypeName("UINT32")]
        public uint last;
    }
}
