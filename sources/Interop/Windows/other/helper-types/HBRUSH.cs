// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBRUSH : IEquatable<HBRUSH>
    {
        public readonly nint Value;

        public HBRUSH(nint value)
        {
            Value = value;
        }

        public static HBRUSH INVALID_VALUE => new HBRUSH(-1);

        public static HBRUSH NULL => new HBRUSH(0);

        public static bool operator ==(HBRUSH left, HBRUSH right) => left.Value == right.Value;

        public static bool operator !=(HBRUSH left, HBRUSH right) => left.Value != right.Value;

        public static explicit operator HBRUSH(void* value) => new HBRUSH((nint)(value));

        public static implicit operator void*(HBRUSH value) => (void*)(value.Value);

        public static explicit operator HBRUSH(HANDLE value) => new HBRUSH(value);

        public static implicit operator HANDLE(HBRUSH value) => new HBRUSH(value);

        public static explicit operator HBRUSH(byte value) => new HBRUSH((nint)(value));

        public static explicit operator byte(HBRUSH value) => (byte)(value.Value);

        public static explicit operator HBRUSH(short value) => new HBRUSH((nint)(value));

        public static explicit operator short(HBRUSH value) => (short)(value.Value);

        public static explicit operator HBRUSH(int value) => new HBRUSH((nint)(value));

        public static explicit operator int(HBRUSH value) => (int)(value.Value);

        public static explicit operator HBRUSH(long value) => new HBRUSH((nint)(value));

        public static implicit operator long(HBRUSH value) => (long)(value.Value);

        public static explicit operator HBRUSH(nint value) => new HBRUSH((nint)(value));

        public static implicit operator nint(HBRUSH value) => (nint)(value.Value);

        public static explicit operator HBRUSH(sbyte value) => new HBRUSH((nint)(value));

        public static explicit operator sbyte(HBRUSH value) => (sbyte)(value.Value);

        public static explicit operator HBRUSH(ushort value) => new HBRUSH((nint)(value));

        public static explicit operator ushort(HBRUSH value) => (ushort)(value.Value);

        public static explicit operator HBRUSH(uint value) => new HBRUSH((nint)(value));

        public static explicit operator uint(HBRUSH value) => (uint)(value.Value);

        public static explicit operator HBRUSH(ulong value) => new HBRUSH((nint)(value));

        public static implicit operator ulong(HBRUSH value) => (ulong)(value.Value);

        public static explicit operator HBRUSH(nuint value) => new HBRUSH((nint)(value));

        public static explicit operator nuint(HBRUSH value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HBRUSH other) && Equals(other);

        public bool Equals(HBRUSH other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
