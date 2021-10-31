// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HMENU : IEquatable<HMENU>
    {
        public readonly nint Value;

        public HMENU(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HMENU left, HMENU right) => left.Value == right.Value;

        public static bool operator !=(HMENU left, HMENU right) => left.Value != right.Value;

        public static implicit operator HMENU(nint value) => new HMENU(value);

        public static implicit operator nint(HMENU value) => value.Value;

        public override bool Equals(object? obj) => (obj is HMENU other) && Equals(other);

        public bool Equals(HMENU other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
