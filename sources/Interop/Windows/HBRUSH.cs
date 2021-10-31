// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HBRUSH : IEquatable<HBRUSH>
    {
        public readonly nint Value;

        public HBRUSH(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HBRUSH left, HBRUSH right) => left.Value == right.Value;

        public static bool operator !=(HBRUSH left, HBRUSH right) => left.Value != right.Value;

        public static implicit operator HBRUSH(nint value) => new HBRUSH(value);

        public static implicit operator nint(HBRUSH value) => value.Value;

        public override bool Equals(object? obj) => (obj is HBRUSH other) && Equals(other);

        public bool Equals(HBRUSH other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
