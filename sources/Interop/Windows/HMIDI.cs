// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HMIDI : IEquatable<HMIDI>
    {
        public readonly nint Value;

        public HMIDI(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HMIDI left, HMIDI right) => left.Value == right.Value;

        public static bool operator !=(HMIDI left, HMIDI right) => left.Value != right.Value;

        public static implicit operator HMIDI(nint value) => new HMIDI(value);

        public static implicit operator nint(HMIDI value) => value.Value;

        public override bool Equals(object? obj) => (obj is HMIDI other) && Equals(other);

        public bool Equals(HMIDI other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
