// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>The DWRITE_MATRIX public structure specifies the graphics transform to be applied to rendered glyphs.</summary>
    [Unmanaged]
    public struct DWRITE_MATRIX
    {
        #region Fields
        /// <summary>Horizontal scaling / cosine of rotation</summary>
        [NativeTypeName("FLOAT")]
        public float m11;

        /// <summary>Vertical shear / sine of rotation</summary>
        [NativeTypeName("FLOAT")]
        public float m12;

        /// <summary>Horizontal shear / negative sine of rotation</summary>
        [NativeTypeName("FLOAT")]
        public float m21;

        /// <summary>Vertical scaling / cosine of rotation</summary>
        [NativeTypeName("FLOAT")]
        public float m22;

        /// <summary>Horizontal shift (always orthogonal regardless of rotation)</summary>
        [NativeTypeName("FLOAT")]
        public float dx;

        /// <summary>Vertical shift (always orthogonal regardless of rotation)</summary>
        [NativeTypeName("FLOAT")]
        public float dy;
        #endregion
    }
}
