// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Contains the control point and end point for a quadratic Bezier segment.</summary>
    [Unmanaged]
    public struct D2D1_QUADRATIC_BEZIER_SEGMENT
    {
        #region Fields
        [NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F point1;

        [NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F point2;
        #endregion
    }
}
