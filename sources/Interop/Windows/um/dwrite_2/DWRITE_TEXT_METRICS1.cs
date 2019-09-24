// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Overall metrics associated with text after layout. All coordinates are in device independent pixels (DIPs).</summary>
    public struct DWRITE_TEXT_METRICS1
    {
        public DWRITE_TEXT_METRICS BaseValue;

        /// <summary>The height of the formatted text taking into account the trailing whitespace at the end of each line, which will matter for vertical reading directions.</summary>
        [NativeTypeName("FLOAT")]
        public float heightIncludingTrailingWhitespace;
    }
}
