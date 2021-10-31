// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HWAVE : IEquatable<HWAVE>
    {
        public readonly nint Value;

        public HWAVE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HWAVE left, HWAVE right) => left.Value == right.Value;

        public static bool operator !=(HWAVE left, HWAVE right) => left.Value != right.Value;

        public static implicit operator HWAVE(nint value) => new HWAVE(value);

        public static implicit operator nint(HWAVE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HWAVE other) && Equals(other);

        public bool Equals(HWAVE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
