// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HPSS : IEquatable<HPSS>
    {
        public readonly nint Value;

        public HPSS(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HPSS left, HPSS right) => left.Value == right.Value;

        public static bool operator !=(HPSS left, HPSS right) => left.Value != right.Value;

        public static implicit operator HPSS(nint value) => new HPSS(value);

        public static implicit operator nint(HPSS value) => value.Value;

        public override bool Equals(object? obj) => (obj is HPSS other) && Equals(other);

        public bool Equals(HPSS other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
