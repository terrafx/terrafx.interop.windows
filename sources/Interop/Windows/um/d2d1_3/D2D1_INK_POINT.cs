// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Represents a point, radius pair that makes up part of a D2D1_INK_BEZIER_SEGMENT.</summary>
    public struct D2D1_INK_POINT
    {
        #region Fields
        [NativeTypeName("FLOAT")]
        public float x;

        [NativeTypeName("FLOAT")]
        public float y;

        [NativeTypeName("FLOAT")]
        public float radius;
        #endregion
    }
}
