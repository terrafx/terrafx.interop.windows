// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HGDIOBJ : IEquatable<HGDIOBJ>
    {
        public readonly nint Value;

        public HGDIOBJ(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HGDIOBJ left, HGDIOBJ right) => left.Value == right.Value;

        public static bool operator !=(HGDIOBJ left, HGDIOBJ right) => left.Value != right.Value;

        public static implicit operator HGDIOBJ(nint value) => new HGDIOBJ(value);

        public static implicit operator nint(HGDIOBJ value) => value.Value;

        public override bool Equals(object? obj) => (obj is HGDIOBJ other) && Equals(other);

        public bool Equals(HGDIOBJ other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
