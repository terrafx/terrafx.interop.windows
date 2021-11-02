// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRASCONN : IEquatable<HRASCONN>
    {
        public readonly nint Value;

        public HRASCONN(nint value)
        {
            Value = value;
        }

        public static HRASCONN INVALID_VALUE => new HRASCONN(-1);

        public static HRASCONN NULL => new HRASCONN(0);

        public static bool operator ==(HRASCONN left, HRASCONN right) => left.Value == right.Value;

        public static bool operator !=(HRASCONN left, HRASCONN right) => left.Value != right.Value;

        public static explicit operator HRASCONN(void* value) => new HRASCONN((nint)(value));

        public static implicit operator void*(HRASCONN value) => (void*)(value.Value);

        public static explicit operator HRASCONN(HANDLE value) => new HRASCONN(value);

        public static implicit operator HANDLE(HRASCONN value) => new HANDLE(value.Value);

        public static explicit operator HRASCONN(byte value) => new HRASCONN((nint)(value));

        public static explicit operator byte(HRASCONN value) => (byte)(value.Value);

        public static explicit operator HRASCONN(short value) => new HRASCONN((nint)(value));

        public static explicit operator short(HRASCONN value) => (short)(value.Value);

        public static explicit operator HRASCONN(int value) => new HRASCONN((nint)(value));

        public static explicit operator int(HRASCONN value) => (int)(value.Value);

        public static explicit operator HRASCONN(long value) => new HRASCONN((nint)(value));

        public static implicit operator long(HRASCONN value) => (long)(value.Value);

        public static explicit operator HRASCONN(nint value) => new HRASCONN((nint)(value));

        public static implicit operator nint(HRASCONN value) => (nint)(value.Value);

        public static explicit operator HRASCONN(sbyte value) => new HRASCONN((nint)(value));

        public static explicit operator sbyte(HRASCONN value) => (sbyte)(value.Value);

        public static explicit operator HRASCONN(ushort value) => new HRASCONN((nint)(value));

        public static explicit operator ushort(HRASCONN value) => (ushort)(value.Value);

        public static explicit operator HRASCONN(uint value) => new HRASCONN((nint)(value));

        public static explicit operator uint(HRASCONN value) => (uint)(value.Value);

        public static explicit operator HRASCONN(ulong value) => new HRASCONN((nint)(value));

        public static explicit operator ulong(HRASCONN value) => (ulong)(value.Value);

        public static explicit operator HRASCONN(nuint value) => new HRASCONN((nint)(value));

        public static explicit operator nuint(HRASCONN value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HRASCONN other) && Equals(other);

        public bool Equals(HRASCONN other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
