// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct BOOL : IEquatable<BOOL>
    {
        public readonly int Value;

        public BOOL(int value)
        {
            Value = value;
        }

        public static BOOL FALSE => new BOOL(0);

        public static BOOL TRUE => new BOOL(1);

        public static bool operator ==(BOOL left, BOOL right) => left.Value == right.Value;

        public static bool operator !=(BOOL left, BOOL right) => left.Value != right.Value;

        public static implicit operator bool(BOOL value) => value.Value != 0;

        public static implicit operator BOOL(bool value) => new BOOL(value ? 1 : 0);

        public static bool operator false(BOOL value) => value.Value == 0;

        public static bool operator true(BOOL value) => value.Value != 0;

        public static explicit operator BOOL(byte value) => new BOOL((int)(value));

        public static implicit operator byte(BOOL value) => (byte)(value.Value);

        public static explicit operator BOOL(short value) => new BOOL((int)(value));

        public static implicit operator short(BOOL value) => (short)(value.Value);

        public static implicit operator BOOL(int value) => new BOOL((int)(value));

        public static implicit operator int(BOOL value) => (int)(value.Value);

        public static implicit operator BOOL(long value) => new BOOL((int)(value));

        public static explicit operator long(BOOL value) => (long)(value.Value);

        public static implicit operator BOOL(nint value) => new BOOL((int)(value));

        public static explicit operator nint(BOOL value) => (nint)(value.Value);

        public static explicit operator BOOL(sbyte value) => new BOOL((int)(value));

        public static implicit operator sbyte(BOOL value) => (sbyte)(value.Value);

        public static explicit operator BOOL(ushort value) => new BOOL((int)(value));

        public static implicit operator ushort(BOOL value) => (ushort)(value.Value);

        public static explicit operator BOOL(uint value) => new BOOL((int)(value));

        public static explicit operator uint(BOOL value) => (uint)(value.Value);

        public static implicit operator BOOL(ulong value) => new BOOL((int)(value));

        public static explicit operator ulong(BOOL value) => (ulong)(value.Value);

        public static implicit operator BOOL(nuint value) => new BOOL((int)(value));

        public static explicit operator nuint(BOOL value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is BOOL other) && Equals(other);

        public bool Equals(BOOL other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
