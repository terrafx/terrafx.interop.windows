// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>The DWRITE_LINE_METRICS public structure contains information about a formatted line of text.</summary>
    [Unmanaged]
    public struct DWRITE_LINE_METRICS
    {
        #region Fields
        /// <summary>The number of total text positions in the line. This includes any trailing whitespace and newline characters.</summary>
        [NativeTypeName("UINT32")]
        public uint length;

        /// <summary>The number of whitespace positions at the end of the line. Newline sequences are considered whitespace.</summary>
        [NativeTypeName("UINT32")]
        public uint trailingWhitespaceLength;

        /// <summary>The number of characters in the newline sequence at the end of the line. If the count is zero, then the line was either wrapped or it is the end of the text.</summary>
        [NativeTypeName("UINT32")]
        public uint newlineLength;

        /// <summary>Height of the line as measured from top to bottom.</summary>
        [NativeTypeName("FLOAT")]
        public float height;

        /// <summary>Distance from the top of the line to its baseline.</summary>
        [NativeTypeName("FLOAT")]
        public float baseline;

        /// <summary>The line is trimmed.</summary>
        [NativeTypeName("BOOL")]
        public int isTrimmed;
        #endregion
    }
}
