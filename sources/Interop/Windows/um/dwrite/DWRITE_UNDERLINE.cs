// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>The DWRITE_UNDERLINE public structure contains information about the size and placement of underlines. All coordinates are in device independent pixels (DIPs).</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [Unmanaged]
    public unsafe struct DWRITE_UNDERLINE
    {
        #region Fields
        /// <summary>Width of the underline, measured parallel to the baseline.</summary>
        [NativeTypeName("FLOAT")]
        public float width;

        /// <summary>Thickness of the underline, measured perpendicular to the
        /// baseline.</summary>
        [NativeTypeName("FLOAT")]
        public float thickness;

        /// <summary>Offset of the underline from the baseline. A positive offset represents a position below the baseline and a negative offset is above.</summary>
        [NativeTypeName("FLOAT")]
        public float offset;

        /// <summary>Height of the tallest run where the underline applies.</summary>
        [NativeTypeName("FLOAT")]
        public float runHeight;

        /// <summary>Reading direction of the text associated with the underline.  This value is used to interpret whether the width value runs horizontally or vertically.</summary>
        public DWRITE_READING_DIRECTION readingDirection;

        /// <summary>Flow direction of the text associated with the underline.  This value is used to interpret whether the thickness value advances top to bottom, left to right, or right to left.</summary>
        public DWRITE_FLOW_DIRECTION flowDirection;

        /// <summary>Locale of the text the underline is being drawn under. Can be pertinent where the locale affects how the underline is drawn. For example, in vertical text, the underline belongs on the left for Chinese but on the right for Japanese. This choice is completely left up to higher levels.</summary>
        [NativeTypeName("WCHAR[]")]
        public char* localeName;

        /// <summary>The measuring mode can be useful to the renderer to determine how
        /// underlines are rendered, e.g. rounding the thickness to a whole pixel
        /// in GDI-compatible modes.</summary>
        public DWRITE_MEASURING_MODE measuringMode;
        #endregion
    }
}
