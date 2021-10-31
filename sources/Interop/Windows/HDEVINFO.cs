// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HDEVINFO : IEquatable<HDEVINFO>
    {
        public readonly nint Value;

        public HDEVINFO(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HDEVINFO left, HDEVINFO right) => left.Value == right.Value;

        public static bool operator !=(HDEVINFO left, HDEVINFO right) => left.Value != right.Value;

        public static implicit operator HDEVINFO(nint value) => new HDEVINFO(value);

        public static implicit operator nint(HDEVINFO value) => value.Value;

        public override bool Equals(object? obj) => (obj is HDEVINFO other) && Equals(other);

        public bool Equals(HDEVINFO other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
