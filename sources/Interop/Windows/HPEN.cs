// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HPEN : IEquatable<HPEN>
    {
        public readonly nint Value;

        public HPEN(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HPEN left, HPEN right) => left.Value == right.Value;

        public static bool operator !=(HPEN left, HPEN right) => left.Value != right.Value;

        public static implicit operator HPEN(nint value) => new HPEN(value);

        public static implicit operator nint(HPEN value) => value.Value;

        public override bool Equals(object? obj) => (obj is HPEN other) && Equals(other);

        public bool Equals(HPEN other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
