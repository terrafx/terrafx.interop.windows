// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HKL : IEquatable<HKL>
    {
        public readonly nint Value;

        public HKL(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HKL left, HKL right) => left.Value == right.Value;

        public static bool operator !=(HKL left, HKL right) => left.Value != right.Value;

        public static implicit operator HKL(nint value) => new HKL(value);

        public static implicit operator nint(HKL value) => value.Value;

        public override bool Equals(object? obj) => (obj is HKL other) && Equals(other);

        public bool Equals(HKL other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
