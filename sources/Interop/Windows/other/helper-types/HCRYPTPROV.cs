// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTPROV : IEquatable<HCRYPTPROV>
    {
        public readonly nint Value;

        public HCRYPTPROV(nint value)
        {
            Value = value;
        }

        public static HCRYPTPROV INVALID_HANDLE_VALUE => new HCRYPTPROV(-1);

        public static HCRYPTPROV NULL => new HCRYPTPROV(0);

        public static bool operator ==(HCRYPTPROV left, HCRYPTPROV right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTPROV left, HCRYPTPROV right) => left.Value != right.Value;

        public static explicit operator HCRYPTPROV(void* value) => new HCRYPTPROV((nint)(value));

        public static implicit operator void*(HCRYPTPROV value) => (void*)(value.Value);

        public static explicit operator HCRYPTPROV(HANDLE value) => new HCRYPTPROV(value);

        public static implicit operator HANDLE(HCRYPTPROV value) => new HCRYPTPROV(value);

        public static explicit operator HCRYPTPROV(byte value) => new HCRYPTPROV((nint)(value));

        public static explicit operator byte(HCRYPTPROV value) => (byte)(value.Value);

        public static explicit operator HCRYPTPROV(short value) => new HCRYPTPROV((nint)(value));

        public static explicit operator short(HCRYPTPROV value) => (short)(value.Value);

        public static explicit operator HCRYPTPROV(int value) => new HCRYPTPROV((nint)(value));

        public static explicit operator int(HCRYPTPROV value) => (int)(value.Value);

        public static explicit operator HCRYPTPROV(long value) => new HCRYPTPROV((nint)(value));

        public static implicit operator long(HCRYPTPROV value) => (long)(value.Value);

        public static explicit operator HCRYPTPROV(nint value) => new HCRYPTPROV((nint)(value));

        public static implicit operator nint(HCRYPTPROV value) => (nint)(value.Value);

        public static explicit operator HCRYPTPROV(sbyte value) => new HCRYPTPROV((nint)(value));

        public static explicit operator sbyte(HCRYPTPROV value) => (sbyte)(value.Value);

        public static explicit operator HCRYPTPROV(ushort value) => new HCRYPTPROV((nint)(value));

        public static explicit operator ushort(HCRYPTPROV value) => (ushort)(value.Value);

        public static explicit operator HCRYPTPROV(uint value) => new HCRYPTPROV((nint)(value));

        public static explicit operator uint(HCRYPTPROV value) => (uint)(value.Value);

        public static explicit operator HCRYPTPROV(ulong value) => new HCRYPTPROV((nint)(value));

        public static implicit operator ulong(HCRYPTPROV value) => (ulong)(value.Value);

        public static explicit operator HCRYPTPROV(nuint value) => new HCRYPTPROV((nint)(value));

        public static explicit operator nuint(HCRYPTPROV value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTPROV other) && Equals(other);

        public bool Equals(HCRYPTPROV other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
