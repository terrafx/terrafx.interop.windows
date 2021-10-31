// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HWINSTA : IEquatable<HWINSTA>
    {
        public readonly nint Value;

        public HWINSTA(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HWINSTA left, HWINSTA right) => left.Value == right.Value;

        public static bool operator !=(HWINSTA left, HWINSTA right) => left.Value != right.Value;

        public static implicit operator HWINSTA(nint value) => new HWINSTA(value);

        public static implicit operator nint(HWINSTA value) => value.Value;

        public override bool Equals(object? obj) => (obj is HWINSTA other) && Equals(other);

        public bool Equals(HWINSTA other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
