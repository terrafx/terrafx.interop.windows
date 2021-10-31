// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HPCON : IEquatable<HPCON>
    {
        public readonly nint Value;

        public HPCON(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HPCON left, HPCON right) => left.Value == right.Value;

        public static bool operator !=(HPCON left, HPCON right) => left.Value != right.Value;

        public static implicit operator HPCON(nint value) => new HPCON(value);

        public static implicit operator nint(HPCON value) => value.Value;

        public override bool Equals(object? obj) => (obj is HPCON other) && Equals(other);

        public bool Equals(HPCON other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
