// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct COLORREF : IEquatable<COLORREF>
    {
        public readonly uint Value;

        public COLORREF(uint value)
        {
            Value = value;
        }

        public static bool operator ==(COLORREF left, COLORREF right) => left.Value == right.Value;

        public static bool operator !=(COLORREF left, COLORREF right) => left.Value != right.Value;

        public static explicit operator COLORREF(byte value) => new COLORREF((uint)(value));

        public static implicit operator byte(COLORREF value) => (byte)(value.Value);

        public static explicit operator COLORREF(short value) => new COLORREF((uint)(value));

        public static implicit operator short(COLORREF value) => (short)(value.Value);

        public static explicit operator COLORREF(int value) => new COLORREF((uint)(value));

        public static explicit operator int(COLORREF value) => (int)(value.Value);

        public static implicit operator COLORREF(long value) => new COLORREF((uint)(value));

        public static explicit operator long(COLORREF value) => (long)(value.Value);

        public static implicit operator COLORREF(nint value) => new COLORREF((uint)(value));

        public static explicit operator nint(COLORREF value) => (nint)(value.Value);

        public static explicit operator COLORREF(sbyte value) => new COLORREF((uint)(value));

        public static implicit operator sbyte(COLORREF value) => (sbyte)(value.Value);

        public static explicit operator COLORREF(ushort value) => new COLORREF((uint)(value));

        public static implicit operator ushort(COLORREF value) => (ushort)(value.Value);

        public static implicit operator COLORREF(uint value) => new COLORREF((uint)(value));

        public static implicit operator uint(COLORREF value) => (uint)(value.Value);

        public static implicit operator COLORREF(ulong value) => new COLORREF((uint)(value));

        public static explicit operator ulong(COLORREF value) => (ulong)(value.Value);

        public static implicit operator COLORREF(nuint value) => new COLORREF((uint)(value));

        public static explicit operator nuint(COLORREF value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is COLORREF other) && Equals(other);

        public bool Equals(COLORREF other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
