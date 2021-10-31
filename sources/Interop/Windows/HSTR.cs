// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HSTR : IEquatable<HSTR>
    {
        public readonly nint Value;

        public HSTR(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HSTR left, HSTR right) => left.Value == right.Value;

        public static bool operator !=(HSTR left, HSTR right) => left.Value != right.Value;

        public static implicit operator HSTR(nint value) => new HSTR(value);

        public static implicit operator nint(HSTR value) => value.Value;

        public override bool Equals(object? obj) => (obj is HSTR other) && Equals(other);

        public bool Equals(HSTR other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
