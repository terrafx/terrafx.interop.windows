// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HCOMDB : IEquatable<HCOMDB>
    {
        public readonly nint Value;

        public HCOMDB(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HCOMDB left, HCOMDB right) => left.Value == right.Value;

        public static bool operator !=(HCOMDB left, HCOMDB right) => left.Value != right.Value;

        public static implicit operator HCOMDB(nint value) => new HCOMDB(value);

        public static implicit operator nint(HCOMDB value) => value.Value;

        public override bool Equals(object? obj) => (obj is HCOMDB other) && Equals(other);

        public bool Equals(HCOMDB other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
