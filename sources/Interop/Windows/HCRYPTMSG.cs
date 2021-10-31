// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTMSG : IEquatable<HCRYPTMSG>
    {
        public readonly void* Value;

        public HCRYPTMSG(int value)
        {
            Value = ((void*)(value));
        }

        public HCRYPTMSG(uint value)
        {
            Value = ((void*)(value));
        }

        public HCRYPTMSG(nint value)
        {
            Value = ((void*)(value));
        }

        public HCRYPTMSG(nuint value)
        {
            Value = ((void*)(value));
        }

        public HCRYPTMSG(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(HCRYPTMSG left, HCRYPTMSG right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTMSG left, HCRYPTMSG right) => left.Value != right.Value;

        public static explicit operator HCRYPTMSG(int value) => new HCRYPTMSG(value);

        public static explicit operator HCRYPTMSG(uint value) => new HCRYPTMSG(value);

        public static explicit operator HCRYPTMSG(nint value) => new HCRYPTMSG(value);

        public static explicit operator HCRYPTMSG(nuint value) => new HCRYPTMSG(value);

        public static explicit operator HCRYPTMSG(void* value) => new HCRYPTMSG(value);

        public static implicit operator int(HCRYPTMSG value) => (int)(value.Value);

        public static implicit operator uint(HCRYPTMSG value) => (uint)(value.Value);

        public static implicit operator nint(HCRYPTMSG value) => (nint)(value.Value);

        public static implicit operator nuint(HCRYPTMSG value) => (nuint)(value.Value);

        public static implicit operator void*(HCRYPTMSG value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTMSG other) && Equals(other);

        public bool Equals(HCRYPTMSG other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
