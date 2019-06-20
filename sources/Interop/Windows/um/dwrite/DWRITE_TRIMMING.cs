// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>The DWRITE_TRIMMING public structure specifies the trimming option for text overflowing the layout box.</summary>
    [Unmanaged]
    public struct DWRITE_TRIMMING
    {
        #region Fields
        /// <summary>Text granularity of which trimming applies.</summary>
        public DWRITE_TRIMMING_GRANULARITY granularity;

        /// <summary>Character code used as the delimiter signaling the beginning of the portion of text to be preserved, most useful for path ellipsis, where the delimiter would be a slash. Leave this zero if there is no delimiter.</summary>
        [NativeTypeName("UINT32")]
        public uint delimiter;

        /// <summary>How many occurrences of the delimiter to step back. Leave this zero if there is no delimiter.</summary>
        [NativeTypeName("UINT32")]
        public uint delimiterCount;
        #endregion
    }
}
