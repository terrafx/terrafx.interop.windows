// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dcommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Represents a rectangle defined by the coordinates of the upper-left corner (left, top) and the coordinates of the lower-right corner (right, bottom).</summary>
    public partial struct D2D_RECT_F
    {
        [NativeTypeName("FLOAT")]
        public float left;

        [NativeTypeName("FLOAT")]
        public float top;

        [NativeTypeName("FLOAT")]
        public float right;

        [NativeTypeName("FLOAT")]
        public float bottom;
    }
}
