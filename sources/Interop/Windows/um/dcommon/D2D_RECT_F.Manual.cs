// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D2D_RECT_F : IEquatable<D2D_RECT_F>
    {
        public static readonly D2D_RECT_F Infinite = new D2D_RECT_F(-float.MaxValue, -float.MaxValue, float.MaxValue, float.MaxValue);

        public D2D_RECT_F([NativeTypeName("FLOAT")] float left = 0.0f, [NativeTypeName("FLOAT")] float top = 0.0f, [NativeTypeName("FLOAT")] float right = 0.0f, [NativeTypeName("FLOAT")] float bottom = 0.0f)
        {
            this.left = left;
            this.top = top;
            this.right = right;
            this.bottom = bottom;
        }

        public static bool operator ==([NativeTypeName("const D2D1_RECT_F &")] in D2D_RECT_F l, [NativeTypeName("const D2D1_RECT_F &")] in D2D_RECT_F r)
        {
            return l.left == r.left && l.top == r.top && l.right == r.right && l.bottom == r.bottom;
        }

        public static bool operator !=([NativeTypeName("const D2D1_RECT_F &")] in D2D_RECT_F l, [NativeTypeName("const D2D1_RECT_F &")] in D2D_RECT_F r)
        {
            return !(l == r);
        }

        public bool Equals(D2D_RECT_F other) => this == other;

        public override bool Equals(object? obj) => (obj is D2D_RECT_F other) && this == other;

        public override int GetHashCode() => HashCode.Combine(left, top, right, bottom);
    }
}
