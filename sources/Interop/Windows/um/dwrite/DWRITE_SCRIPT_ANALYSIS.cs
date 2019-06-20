// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Association of text and its writing system script as well as some display attributes.</summary>
    [Unmanaged]
    public struct DWRITE_SCRIPT_ANALYSIS
    {
        #region Fields
        /// <summary>Zero-based index representation of writing system script.</summary>
        [NativeTypeName("UINT16")]
        public ushort script;

        /// <summary>Additional shaping requirement of text.</summary>
        public DWRITE_SCRIPT_SHAPES shapes;
        #endregion
    }
}
