// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPEN : IEquatable<HPEN>
    {
        public readonly nint Value;

        public HPEN(nint value)
        {
            Value = value;
        }

        public static HPEN INVALID_VALUE => new HPEN(-1);

        public static HPEN NULL => new HPEN(0);

        public static bool operator ==(HPEN left, HPEN right) => left.Value == right.Value;

        public static bool operator !=(HPEN left, HPEN right) => left.Value != right.Value;

        public static explicit operator HPEN(void* value) => new HPEN((nint)(value));

        public static implicit operator void*(HPEN value) => (void*)(value.Value);

        public static explicit operator HPEN(HANDLE value) => new HPEN(value);

        public static implicit operator HANDLE(HPEN value) => new HPEN(value);

        public static explicit operator HPEN(byte value) => new HPEN((nint)(value));

        public static explicit operator byte(HPEN value) => (byte)(value.Value);

        public static explicit operator HPEN(short value) => new HPEN((nint)(value));

        public static explicit operator short(HPEN value) => (short)(value.Value);

        public static explicit operator HPEN(int value) => new HPEN((nint)(value));

        public static explicit operator int(HPEN value) => (int)(value.Value);

        public static explicit operator HPEN(long value) => new HPEN((nint)(value));

        public static implicit operator long(HPEN value) => (long)(value.Value);

        public static explicit operator HPEN(nint value) => new HPEN((nint)(value));

        public static implicit operator nint(HPEN value) => (nint)(value.Value);

        public static explicit operator HPEN(sbyte value) => new HPEN((nint)(value));

        public static explicit operator sbyte(HPEN value) => (sbyte)(value.Value);

        public static explicit operator HPEN(ushort value) => new HPEN((nint)(value));

        public static explicit operator ushort(HPEN value) => (ushort)(value.Value);

        public static explicit operator HPEN(uint value) => new HPEN((nint)(value));

        public static explicit operator uint(HPEN value) => (uint)(value.Value);

        public static explicit operator HPEN(ulong value) => new HPEN((nint)(value));

        public static explicit operator ulong(HPEN value) => (ulong)(value.Value);

        public static explicit operator HPEN(nuint value) => new HPEN((nint)(value));

        public static explicit operator nuint(HPEN value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HPEN other) && Equals(other);

        public bool Equals(HPEN other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
