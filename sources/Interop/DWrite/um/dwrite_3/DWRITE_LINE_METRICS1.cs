// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Information about a formatted line of text.</summary>
    public struct DWRITE_LINE_METRICS1
    {
        public DWRITE_LINE_METRICS BaseValue;

        /// <summary>White space before the content of the line. This is included in the line height and baseline distances. If the line is formatted horizontally either with a uniform line spacing or with proportional line spacing, this value represents the extra space above the content.</summary>
        [NativeTypeName("FLOAT")]
        public float leadingBefore;

        /// <summary>White space after the content of the line. This is included in the height of the line. If the line is formatted horizontally either with a uniform line spacing or with proportional line spacing, this value represents the extra space below the content.</summary>
        [NativeTypeName("FLOAT")]
        public float leadingAfter;
    }
}
