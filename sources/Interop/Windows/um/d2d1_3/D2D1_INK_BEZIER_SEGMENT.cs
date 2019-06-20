// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Represents a Bezier segment to be used in the creation of an ID2D1Ink object. This structure differs from D2D1_BEZIER_SEGMENT in that it is composed of D2D1_INK_POINT s, which contain a radius in addition to x- and y-coordinates.</summary>
    [Unmanaged]
    public struct D2D1_INK_BEZIER_SEGMENT
    {
        #region Fields
        public D2D1_INK_POINT point1;

        public D2D1_INK_POINT point2;

        public D2D1_INK_POINT point3;
        #endregion
    }
}
