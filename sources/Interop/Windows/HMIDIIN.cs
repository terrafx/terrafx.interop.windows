// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HMIDIIN : IEquatable<HMIDIIN>
    {
        public readonly nint Value;

        public HMIDIIN(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HMIDIIN left, HMIDIIN right) => left.Value == right.Value;

        public static bool operator !=(HMIDIIN left, HMIDIIN right) => left.Value != right.Value;

        public static implicit operator HMIDIIN(nint value) => new HMIDIIN(value);

        public static implicit operator nint(HMIDIIN value) => value.Value;

        public override bool Equals(object? obj) => (obj is HMIDIIN other) && Equals(other);

        public bool Equals(HMIDIIN other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
