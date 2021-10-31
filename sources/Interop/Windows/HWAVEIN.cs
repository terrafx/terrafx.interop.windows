// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HWAVEIN : IEquatable<HWAVEIN>
    {
        public readonly nint Value;

        public HWAVEIN(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HWAVEIN left, HWAVEIN right) => left.Value == right.Value;

        public static bool operator !=(HWAVEIN left, HWAVEIN right) => left.Value != right.Value;

        public static implicit operator HWAVEIN(nint value) => new HWAVEIN(value);

        public static implicit operator nint(HWAVEIN value) => value.Value;

        public override bool Equals(object? obj) => (obj is HWAVEIN other) && Equals(other);

        public bool Equals(HWAVEIN other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
