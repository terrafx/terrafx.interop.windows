// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D2D_RECT_U : IEquatable<D2D_RECT_U>
    {
        public static readonly D2D_RECT_U DEFAULT = new D2D_RECT_U(0, 0, 0, 0);

        public D2D_RECT_U(uint left, uint top, uint right, uint bottom)
        {
            this.left = left;
            this.top = top;
            this.right = right;
            this.bottom = bottom;
        }

        public bool Equals(D2D_RECT_U other) => this == other;

        public override bool Equals(object? obj) => (obj is D2D_RECT_U other) && this == other;

        public override int GetHashCode() => HashCode.Combine(left, top, right, bottom);

        public static bool operator ==(D2D_RECT_U l, D2D_RECT_U r) =>
            l.left == r.left &&
            l.top == r.top &&
            l.right == r.right &&
            l.bottom == r.bottom;

        public static bool operator !=(D2D_RECT_U l, D2D_RECT_U r) =>
            l.left != r.left ||
            l.top != r.top ||
            l.right != r.right ||
            l.bottom != r.bottom;
    }
}
