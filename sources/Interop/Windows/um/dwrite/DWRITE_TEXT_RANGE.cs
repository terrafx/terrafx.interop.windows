// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>The DWRITE_TEXT_RANGE public structure specifies a range of text positions where format is applied.</summary>
    [Unmanaged]
    public struct DWRITE_TEXT_RANGE
    {
        #region Fields
        /// <summary>The start text position of the range.</summary>
        [NativeTypeName("UINT32")]
        public uint startPosition;

        /// <summary>The number of text positions in the range.</summary>
        [NativeTypeName("UINT32")]
        public uint length;
        #endregion
    }
}
