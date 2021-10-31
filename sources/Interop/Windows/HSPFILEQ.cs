// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HSPFILEQ : IEquatable<HSPFILEQ>
    {
        public readonly nint Value;

        public HSPFILEQ(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HSPFILEQ left, HSPFILEQ right) => left.Value == right.Value;

        public static bool operator !=(HSPFILEQ left, HSPFILEQ right) => left.Value != right.Value;

        public static implicit operator HSPFILEQ(nint value) => new HSPFILEQ(value);

        public static implicit operator nint(HSPFILEQ value) => value.Value;

        public override bool Equals(object? obj) => (obj is HSPFILEQ other) && Equals(other);

        public bool Equals(HSPFILEQ other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
