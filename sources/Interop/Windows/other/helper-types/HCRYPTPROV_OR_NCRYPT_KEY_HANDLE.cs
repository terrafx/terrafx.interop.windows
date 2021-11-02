// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTPROV_OR_NCRYPT_KEY_HANDLE : IEquatable<HCRYPTPROV_OR_NCRYPT_KEY_HANDLE>
    {
        public readonly nint Value;

        public HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(nint value)
        {
            Value = value;
        }

        public static HCRYPTPROV_OR_NCRYPT_KEY_HANDLE INVALID_VALUE => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(-1);

        public static HCRYPTPROV_OR_NCRYPT_KEY_HANDLE NULL => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(0);

        public static bool operator ==(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE left, HCRYPTPROV_OR_NCRYPT_KEY_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE left, HCRYPTPROV_OR_NCRYPT_KEY_HANDLE right) => left.Value != right.Value;

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(void* value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE((nint)(value));

        public static implicit operator void*(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (void*)(value.Value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(HANDLE value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(value);

        public static implicit operator HANDLE(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(byte value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE((nint)(value));

        public static explicit operator byte(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (byte)(value.Value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(short value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE((nint)(value));

        public static explicit operator short(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (short)(value.Value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(int value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE((nint)(value));

        public static explicit operator int(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (int)(value.Value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(long value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE((nint)(value));

        public static implicit operator long(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (long)(value.Value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(nint value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE((nint)(value));

        public static implicit operator nint(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (nint)(value.Value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(sbyte value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE((nint)(value));

        public static explicit operator sbyte(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(ushort value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE((nint)(value));

        public static explicit operator ushort(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (ushort)(value.Value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(uint value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE((nint)(value));

        public static explicit operator uint(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (uint)(value.Value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(ulong value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE((nint)(value));

        public static explicit operator ulong(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (ulong)(value.Value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(nuint value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE((nint)(value));

        public static explicit operator nuint(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTPROV_OR_NCRYPT_KEY_HANDLE other) && Equals(other);

        public bool Equals(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
