// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HDRVR : IEquatable<HDRVR>
    {
        public readonly nint Value;

        public HDRVR(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HDRVR left, HDRVR right) => left.Value == right.Value;

        public static bool operator !=(HDRVR left, HDRVR right) => left.Value != right.Value;

        public static implicit operator HDRVR(nint value) => new HDRVR(value);

        public static implicit operator nint(HDRVR value) => value.Value;

        public override bool Equals(object? obj) => (obj is HDRVR other) && Equals(other);

        public bool Equals(HDRVR other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
