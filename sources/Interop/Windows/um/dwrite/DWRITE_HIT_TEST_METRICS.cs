// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Geometry enclosing of text positions.</summary>
    [Unmanaged]
    public struct DWRITE_HIT_TEST_METRICS
    {
        #region Fields
        /// <summary>First text position within the geometry.</summary>
        [NativeTypeName("UINT32")]
        public uint textPosition;

        /// <summary>Number of text positions within the geometry.</summary>
        [NativeTypeName("UINT32")]
        public uint length;

        /// <summary>Left position of the top-left coordinate of the geometry.</summary>
        [NativeTypeName("FLOAT")]
        public float left;

        /// <summary>Top position of the top-left coordinate of the geometry.</summary>
        [NativeTypeName("FLOAT")]
        public float top;

        /// <summary>Geometry's width.</summary>
        [NativeTypeName("FLOAT")]
        public float width;

        /// <summary>Geometry's height.</summary>
        [NativeTypeName("FLOAT")]
        public float height;

        /// <summary>Bidi level of text positions enclosed within the geometry.</summary>
        [NativeTypeName("UINT32")]
        public uint bidiLevel;

        /// <summary>Geometry encloses text?</summary>
        [NativeTypeName("BOOL")]
        public int isText;

        /// <summary>Range is trimmed.</summary>
        [NativeTypeName("BOOL")]
        public int isTrimmed;
        #endregion
    }
}
