// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D2D_SIZE_F : IEquatable<D2D_SIZE_F>
    {
        public static readonly D2D_SIZE_F DEFAULT = new D2D_SIZE_F(0.0f, 0.0f);

        public D2D_SIZE_F(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public bool Equals(D2D_SIZE_F other) => this == other;

        public override bool Equals(object? obj) => (obj is D2D_SIZE_F other) && this == other;

        public override int GetHashCode() => HashCode.Combine(width, height);

        public static bool operator ==(D2D_SIZE_F left, D2D_SIZE_F right) => left.width == right.width && left.height == right.height;

        public static bool operator !=(D2D_SIZE_F left, D2D_SIZE_F right) => left.width != right.width || left.height != right.height;

    }
}
