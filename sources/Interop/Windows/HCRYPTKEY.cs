// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTKEY : IEquatable<HCRYPTKEY>
    {
        public readonly nuint Value;

        public HCRYPTKEY(int value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTKEY(uint value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTKEY(nint value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTKEY(nuint value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTKEY(void* value)
        {
            Value = ((nuint)(value));
        }

        public static bool operator ==(HCRYPTKEY left, HCRYPTKEY right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTKEY left, HCRYPTKEY right) => left.Value != right.Value;

        public static explicit operator HCRYPTKEY(int value) => new HCRYPTKEY(value);

        public static explicit operator HCRYPTKEY(uint value) => new HCRYPTKEY(value);

        public static explicit operator HCRYPTKEY(nint value) => new HCRYPTKEY(value);

        public static explicit operator HCRYPTKEY(nuint value) => new HCRYPTKEY(value);

        public static explicit operator HCRYPTKEY(void* value) => new HCRYPTKEY(value);

        public static implicit operator int(HCRYPTKEY value) => (int)(value.Value);

        public static implicit operator uint(HCRYPTKEY value) => (uint)(value.Value);

        public static implicit operator nint(HCRYPTKEY value) => (nint)(value.Value);

        public static implicit operator nuint(HCRYPTKEY value) => (nuint)(value.Value);

        public static implicit operator void*(HCRYPTKEY value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTKEY other) && Equals(other);

        public bool Equals(HCRYPTKEY other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
