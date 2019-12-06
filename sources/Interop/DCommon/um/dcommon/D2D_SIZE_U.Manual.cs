// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D2D_SIZE_U : IEquatable<D2D_SIZE_U>
    {
        public static readonly D2D_SIZE_U DEFAULT = new D2D_SIZE_U(0, 0);

        public D2D_SIZE_U(uint width, uint height)
        {
            this.width = width;
            this.height = height;
        }

        public bool Equals(D2D_SIZE_U other) => this == other;

        public override bool Equals(object? obj) => (obj is D2D_SIZE_U other) && this == other;

        public override int GetHashCode() => HashCode.Combine(width, height);

        public static bool operator ==(D2D_SIZE_U l, D2D_SIZE_U r) => l.width == r.width && l.height == r.height;

        public static bool operator !=(D2D_SIZE_U l, D2D_SIZE_U r) => l.width != r.width || l.height != r.height;
    }
}
