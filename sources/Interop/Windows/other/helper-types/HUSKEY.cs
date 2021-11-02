// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HUSKEY : IEquatable<HUSKEY>
    {
        public readonly nint Value;

        public HUSKEY(nint value)
        {
            Value = value;
        }

        public static HUSKEY INVALID_VALUE => new HUSKEY(-1);

        public static HUSKEY NULL => new HUSKEY(0);

        public static bool operator ==(HUSKEY left, HUSKEY right) => left.Value == right.Value;

        public static bool operator !=(HUSKEY left, HUSKEY right) => left.Value != right.Value;

        public static explicit operator HUSKEY(void* value) => new HUSKEY((nint)(value));

        public static implicit operator void*(HUSKEY value) => (void*)(value.Value);

        public static explicit operator HUSKEY(HANDLE value) => new HUSKEY(value);

        public static implicit operator HANDLE(HUSKEY value) => new HANDLE(value.Value);

        public static explicit operator HUSKEY(byte value) => new HUSKEY((nint)(value));

        public static explicit operator byte(HUSKEY value) => (byte)(value.Value);

        public static explicit operator HUSKEY(short value) => new HUSKEY((nint)(value));

        public static explicit operator short(HUSKEY value) => (short)(value.Value);

        public static explicit operator HUSKEY(int value) => new HUSKEY((nint)(value));

        public static explicit operator int(HUSKEY value) => (int)(value.Value);

        public static explicit operator HUSKEY(long value) => new HUSKEY((nint)(value));

        public static implicit operator long(HUSKEY value) => (long)(value.Value);

        public static explicit operator HUSKEY(nint value) => new HUSKEY((nint)(value));

        public static implicit operator nint(HUSKEY value) => (nint)(value.Value);

        public static explicit operator HUSKEY(sbyte value) => new HUSKEY((nint)(value));

        public static explicit operator sbyte(HUSKEY value) => (sbyte)(value.Value);

        public static explicit operator HUSKEY(ushort value) => new HUSKEY((nint)(value));

        public static explicit operator ushort(HUSKEY value) => (ushort)(value.Value);

        public static explicit operator HUSKEY(uint value) => new HUSKEY((nint)(value));

        public static explicit operator uint(HUSKEY value) => (uint)(value.Value);

        public static explicit operator HUSKEY(ulong value) => new HUSKEY((nint)(value));

        public static explicit operator ulong(HUSKEY value) => (ulong)(value.Value);

        public static explicit operator HUSKEY(nuint value) => new HUSKEY((nint)(value));

        public static explicit operator nuint(HUSKEY value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HUSKEY other) && Equals(other);

        public bool Equals(HUSKEY other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
