// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Defines the general pen tip shape and the transform used in an ID2D1InkStyle object.</summary>
    [Unmanaged]
    public struct D2D1_INK_STYLE_PROPERTIES
    {
        #region Fields
        /// <summary>The general shape of the nib used to draw a given ink object.</summary>
        public D2D1_INK_NIB_SHAPE nibShape;

        /// <summary>The transform applied to shape of the nib. _31 and _32 are ignored.</summary>
        [NativeTypeName("D2D1_MATRIX_3X2_F")]
        public D2D_MATRIX_3X2_F nibTransform;
        #endregion
    }
}
