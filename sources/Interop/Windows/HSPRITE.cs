// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HSPRITE : IEquatable<HSPRITE>
    {
        public readonly nint Value;

        public HSPRITE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HSPRITE left, HSPRITE right) => left.Value == right.Value;

        public static bool operator !=(HSPRITE left, HSPRITE right) => left.Value != right.Value;

        public static implicit operator HSPRITE(nint value) => new HSPRITE(value);

        public static implicit operator nint(HSPRITE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HSPRITE other) && Equals(other);

        public bool Equals(HSPRITE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
