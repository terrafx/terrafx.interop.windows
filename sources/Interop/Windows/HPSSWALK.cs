// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HPSSWALK : IEquatable<HPSSWALK>
    {
        public readonly nint Value;

        public HPSSWALK(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HPSSWALK left, HPSSWALK right) => left.Value == right.Value;

        public static bool operator !=(HPSSWALK left, HPSSWALK right) => left.Value != right.Value;

        public static implicit operator HPSSWALK(nint value) => new HPSSWALK(value);

        public static implicit operator nint(HPSSWALK value) => value.Value;

        public override bool Equals(object? obj) => (obj is HPSSWALK other) && Equals(other);

        public bool Equals(HPSSWALK other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
