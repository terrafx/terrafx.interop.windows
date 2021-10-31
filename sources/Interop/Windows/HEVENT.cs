// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HEVENT : IEquatable<HEVENT>
    {
        public readonly nint Value;

        public HEVENT(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HEVENT left, HEVENT right) => left.Value == right.Value;

        public static bool operator !=(HEVENT left, HEVENT right) => left.Value != right.Value;

        public static implicit operator HEVENT(nint value) => new HEVENT(value);

        public static implicit operator nint(HEVENT value) => value.Value;

        public override bool Equals(object? obj) => (obj is HEVENT other) && Equals(other);

        public bool Equals(HEVENT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
