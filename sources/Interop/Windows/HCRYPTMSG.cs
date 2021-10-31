// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HCRYPTMSG : IEquatable<HCRYPTMSG>
    {
        public readonly nint Value;

        public HCRYPTMSG(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HCRYPTMSG left, HCRYPTMSG right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTMSG left, HCRYPTMSG right) => left.Value != right.Value;

        public static implicit operator HCRYPTMSG(nint value) => new HCRYPTMSG(value);

        public static implicit operator nint(HCRYPTMSG value) => value.Value;

        public override bool Equals(object? obj) => (obj is HCRYPTMSG other) && Equals(other);

        public bool Equals(HCRYPTMSG other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
