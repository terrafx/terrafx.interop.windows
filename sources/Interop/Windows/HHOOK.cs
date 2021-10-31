// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HHOOK : IEquatable<HHOOK>
    {
        public readonly nint Value;

        public HHOOK(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HHOOK left, HHOOK right) => left.Value == right.Value;

        public static bool operator !=(HHOOK left, HHOOK right) => left.Value != right.Value;

        public static implicit operator HHOOK(nint value) => new HHOOK(value);

        public static implicit operator nint(HHOOK value) => value.Value;

        public override bool Equals(object? obj) => (obj is HHOOK other) && Equals(other);

        public bool Equals(HHOOK other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
