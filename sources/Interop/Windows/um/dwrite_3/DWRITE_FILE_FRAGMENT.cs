// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>DWRITE_FILE_FRAGMENT represents a range of bytes in a font file.</summary>
    [Unmanaged]
    public struct DWRITE_FILE_FRAGMENT
    {
        #region Fields
        /// <summary>Starting offset of the fragment from the beginning of the file.</summary>
        [NativeTypeName("UINT64")]
        public ulong fileOffset;

        /// <summary>Size of the file fragment, in bytes.</summary>
        [NativeTypeName("UINT64")]
        public ulong fragmentSize;
        #endregion
    }
}
