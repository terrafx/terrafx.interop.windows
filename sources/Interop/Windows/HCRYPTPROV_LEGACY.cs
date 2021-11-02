// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTPROV_LEGACY : IEquatable<HCRYPTPROV_LEGACY>
    {
        public readonly nint Value;

        public HCRYPTPROV_LEGACY(nint value)
        {
            Value = value;
        }

        public static HCRYPTPROV_LEGACY INVALID_HANDLE_VALUE => new HCRYPTPROV_LEGACY(-1);

        public static HCRYPTPROV_LEGACY NULL => new HCRYPTPROV_LEGACY(0);

        public static bool operator ==(HCRYPTPROV_LEGACY left, HCRYPTPROV_LEGACY right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTPROV_LEGACY left, HCRYPTPROV_LEGACY right) => left.Value != right.Value;

        public static explicit operator HCRYPTPROV_LEGACY(void* value) => new HCRYPTPROV_LEGACY((nint)(value));

        public static implicit operator void*(HCRYPTPROV_LEGACY value) => (void*)(value.Value);

        public static explicit operator HCRYPTPROV_LEGACY(HANDLE value) => new HCRYPTPROV_LEGACY(value);

        public static implicit operator HANDLE(HCRYPTPROV_LEGACY value) => new HCRYPTPROV_LEGACY(value);

        public static explicit operator HCRYPTPROV_LEGACY(byte value) => new HCRYPTPROV_LEGACY((nint)(value));

        public static implicit operator byte(HCRYPTPROV_LEGACY value) => (byte)(value.Value);

        public static explicit operator HCRYPTPROV_LEGACY(short value) => new HCRYPTPROV_LEGACY((nint)(value));

        public static implicit operator short(HCRYPTPROV_LEGACY value) => (short)(value.Value);

        public static explicit operator HCRYPTPROV_LEGACY(int value) => new HCRYPTPROV_LEGACY((nint)(value));

        public static implicit operator int(HCRYPTPROV_LEGACY value) => (int)(value.Value);

        public static explicit operator HCRYPTPROV_LEGACY(long value) => new HCRYPTPROV_LEGACY((nint)(value));

        public static explicit operator long(HCRYPTPROV_LEGACY value) => (long)(value.Value);

        public static explicit operator HCRYPTPROV_LEGACY(nint value) => new HCRYPTPROV_LEGACY((nint)(value));

        public static implicit operator nint(HCRYPTPROV_LEGACY value) => (nint)(value.Value);

        public static explicit operator HCRYPTPROV_LEGACY(sbyte value) => new HCRYPTPROV_LEGACY((nint)(value));

        public static implicit operator sbyte(HCRYPTPROV_LEGACY value) => (sbyte)(value.Value);

        public static explicit operator HCRYPTPROV_LEGACY(ushort value) => new HCRYPTPROV_LEGACY((nint)(value));

        public static implicit operator ushort(HCRYPTPROV_LEGACY value) => (ushort)(value.Value);

        public static explicit operator HCRYPTPROV_LEGACY(uint value) => new HCRYPTPROV_LEGACY((nint)(value));

        public static implicit operator uint(HCRYPTPROV_LEGACY value) => (uint)(value.Value);

        public static explicit operator HCRYPTPROV_LEGACY(ulong value) => new HCRYPTPROV_LEGACY((nint)(value));

        public static explicit operator ulong(HCRYPTPROV_LEGACY value) => (ulong)(value.Value);

        public static explicit operator HCRYPTPROV_LEGACY(nuint value) => new HCRYPTPROV_LEGACY((nint)(value));

        public static explicit operator nuint(HCRYPTPROV_LEGACY value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTPROV_LEGACY other) && Equals(other);

        public bool Equals(HCRYPTPROV_LEGACY other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
