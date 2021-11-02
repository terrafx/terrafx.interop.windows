// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTKEY : IEquatable<HCRYPTKEY>
    {
        public readonly nint Value;

        public HCRYPTKEY(nint value)
        {
            Value = value;
        }

        public static HCRYPTKEY INVALID_HANDLE_VALUE => new HCRYPTKEY(-1);

        public static HCRYPTKEY NULL => new HCRYPTKEY(0);

        public static bool operator ==(HCRYPTKEY left, HCRYPTKEY right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTKEY left, HCRYPTKEY right) => left.Value != right.Value;

        public static explicit operator HCRYPTKEY(void* value) => new HCRYPTKEY((nint)(value));

        public static implicit operator void*(HCRYPTKEY value) => (void*)(value.Value);

        public static explicit operator HCRYPTKEY(HANDLE value) => new HCRYPTKEY(value);

        public static implicit operator HANDLE(HCRYPTKEY value) => new HCRYPTKEY(value);

        public static explicit operator HCRYPTKEY(byte value) => new HCRYPTKEY((nint)(value));

        public static implicit operator byte(HCRYPTKEY value) => (byte)(value.Value);

        public static explicit operator HCRYPTKEY(short value) => new HCRYPTKEY((nint)(value));

        public static implicit operator short(HCRYPTKEY value) => (short)(value.Value);

        public static explicit operator HCRYPTKEY(int value) => new HCRYPTKEY((nint)(value));

        public static implicit operator int(HCRYPTKEY value) => (int)(value.Value);

        public static explicit operator HCRYPTKEY(long value) => new HCRYPTKEY((nint)(value));

        public static explicit operator long(HCRYPTKEY value) => (long)(value.Value);

        public static explicit operator HCRYPTKEY(nint value) => new HCRYPTKEY((nint)(value));

        public static implicit operator nint(HCRYPTKEY value) => (nint)(value.Value);

        public static explicit operator HCRYPTKEY(sbyte value) => new HCRYPTKEY((nint)(value));

        public static implicit operator sbyte(HCRYPTKEY value) => (sbyte)(value.Value);

        public static explicit operator HCRYPTKEY(ushort value) => new HCRYPTKEY((nint)(value));

        public static implicit operator ushort(HCRYPTKEY value) => (ushort)(value.Value);

        public static explicit operator HCRYPTKEY(uint value) => new HCRYPTKEY((nint)(value));

        public static implicit operator uint(HCRYPTKEY value) => (uint)(value.Value);

        public static explicit operator HCRYPTKEY(ulong value) => new HCRYPTKEY((nint)(value));

        public static explicit operator ulong(HCRYPTKEY value) => (ulong)(value.Value);

        public static explicit operator HCRYPTKEY(nuint value) => new HCRYPTKEY((nint)(value));

        public static explicit operator nuint(HCRYPTKEY value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTKEY other) && Equals(other);

        public bool Equals(HCRYPTKEY other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
