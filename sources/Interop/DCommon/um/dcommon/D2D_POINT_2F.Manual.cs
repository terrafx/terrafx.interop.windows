// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D2D_POINT_2F : IEquatable<D2D_POINT_2F>
    {
        public static readonly D2D_POINT_2F DEFAULT = new D2D_POINT_2F(0.0f, 0.0f);

        public D2D_POINT_2F(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public bool Equals(D2D_POINT_2F other) => this == other;

        public override bool Equals(object? obj) => (obj is D2D_POINT_2F other) && this == other;

        public override int GetHashCode() => HashCode.Combine(x, y);

        public static bool operator ==(D2D_POINT_2F left, D2D_POINT_2F right) => left.x == right.x && left.y == right.y;

        public static bool operator !=(D2D_POINT_2F left, D2D_POINT_2F right) => left.x != right.x || left.y != right.y;
    }
}
