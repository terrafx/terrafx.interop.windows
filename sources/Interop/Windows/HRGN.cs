// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HRGN : IEquatable<HRGN>
    {
        public readonly nint Value;

        public HRGN(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HRGN left, HRGN right) => left.Value == right.Value;

        public static bool operator !=(HRGN left, HRGN right) => left.Value != right.Value;

        public static implicit operator HRGN(nint value) => new HRGN(value);

        public static implicit operator nint(HRGN value) => value.Value;

        public override bool Equals(object? obj) => (obj is HRGN other) && Equals(other);

        public bool Equals(HRGN other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
