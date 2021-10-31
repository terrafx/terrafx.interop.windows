// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTPROV : IEquatable<HCRYPTPROV>
    {
        public readonly nuint Value;

        public HCRYPTPROV(int value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTPROV(uint value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTPROV(nint value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTPROV(nuint value)
        {
            Value = ((nuint)(value));
        }

        public HCRYPTPROV(void* value)
        {
            Value = ((nuint)(value));
        }

        public static bool operator ==(HCRYPTPROV left, HCRYPTPROV right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTPROV left, HCRYPTPROV right) => left.Value != right.Value;

        public static explicit operator HCRYPTPROV(int value) => new HCRYPTPROV(value);

        public static explicit operator HCRYPTPROV(uint value) => new HCRYPTPROV(value);

        public static explicit operator HCRYPTPROV(nint value) => new HCRYPTPROV(value);

        public static explicit operator HCRYPTPROV(nuint value) => new HCRYPTPROV(value);

        public static explicit operator HCRYPTPROV(void* value) => new HCRYPTPROV(value);

        public static implicit operator int(HCRYPTPROV value) => (int)(value.Value);

        public static implicit operator uint(HCRYPTPROV value) => (uint)(value.Value);

        public static implicit operator nint(HCRYPTPROV value) => (nint)(value.Value);

        public static implicit operator nuint(HCRYPTPROV value) => (nuint)(value.Value);

        public static implicit operator void*(HCRYPTPROV value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTPROV other) && Equals(other);

        public bool Equals(HCRYPTPROV other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
