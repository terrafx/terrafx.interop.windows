// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTMSG : IEquatable<HCRYPTMSG>
    {
        public readonly nint Value;

        public HCRYPTMSG(nint value)
        {
            Value = ((nint)(value));
        }

        public HCRYPTMSG(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCRYPTMSG(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HCRYPTMSG left, HCRYPTMSG right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTMSG left, HCRYPTMSG right) => left.Value != right.Value;

        public static explicit operator HCRYPTMSG(nint value) => new HCRYPTMSG(value);

        public static explicit operator HCRYPTMSG(nuint value) => new HCRYPTMSG(value);

        public static explicit operator HCRYPTMSG(void* value) => new HCRYPTMSG(value);

        public static implicit operator nint(HCRYPTMSG value) => (nint)(value.Value);

        public static implicit operator nuint(HCRYPTMSG value) => (nuint)(value.Value);

        public static implicit operator void*(HCRYPTMSG value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTMSG other) && Equals(other);

        public bool Equals(HCRYPTMSG other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
