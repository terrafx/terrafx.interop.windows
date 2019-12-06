// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D2D_RECT_U : IEquatable<D2D_RECT_U>
    {
        public D2D_RECT_U([NativeTypeName("UINT32")] uint left = 0, [NativeTypeName("UINT32")] uint top = 0, [NativeTypeName("UINT32")] uint right = 0, [NativeTypeName("UINT32")] uint bottom = 0)
        {
            this.left = left;
            this.top = top;
            this.right = right;
            this.bottom = bottom;
        }

        public static bool operator ==([NativeTypeName("const D2D1_RECT_U &")] in D2D_RECT_U l, [NativeTypeName("const D2D1_RECT_U &")] in D2D_RECT_U r)
        {
            return l.left == r.left && l.top == r.top && l.right == r.right && l.bottom == r.bottom;
        }

        public static bool operator !=([NativeTypeName("const D2D1_RECT_U &")] in D2D_RECT_U l, [NativeTypeName("const D2D1_RECT_U &")] in D2D_RECT_U r)
        {
            return !(l == r);
        }

        public bool Equals(D2D_RECT_U other) => this == other;

        public override bool Equals(object? obj) => (obj is D2D_RECT_U other) && this == other;

        public override int GetHashCode() => HashCode.Combine(left, top, right, bottom);
    }
}
