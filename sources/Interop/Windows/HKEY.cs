// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HKEY : IEquatable<HKEY>
    {
        public readonly nint Value;

        public HKEY(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HKEY left, HKEY right) => left.Value == right.Value;

        public static bool operator !=(HKEY left, HKEY right) => left.Value != right.Value;

        public static implicit operator HKEY(nint value) => new HKEY(value);

        public static implicit operator nint(HKEY value) => value.Value;

        public override bool Equals(object? obj) => (obj is HKEY other) && Equals(other);

        public bool Equals(HKEY other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
