// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HACCEL : IEquatable<HACCEL>
    {
        public readonly nint Value;

        public HACCEL(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HACCEL left, HACCEL right) => left.Value == right.Value;

        public static bool operator !=(HACCEL left, HACCEL right) => left.Value != right.Value;

        public static implicit operator HACCEL(nint value) => new HACCEL(value);

        public static implicit operator nint(HACCEL value) => value.Value;

        public override bool Equals(object? obj) => (obj is HACCEL other) && Equals(other);

        public bool Equals(HACCEL other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
