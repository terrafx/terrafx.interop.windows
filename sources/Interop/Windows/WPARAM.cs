// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct WPARAM : IEquatable<WPARAM>
    {
        public readonly nuint Value;

        public WPARAM(nuint value)
        {
            Value = value;
        }

        public static bool operator ==(WPARAM left, WPARAM right) => left.Value == right.Value;

        public static bool operator !=(WPARAM left, WPARAM right) => left.Value != right.Value;

        public static explicit operator WPARAM(byte value) => new WPARAM((nuint)(value));

        public static implicit operator byte(WPARAM value) => (byte)(value.Value);

        public static explicit operator WPARAM(short value) => new WPARAM((nuint)(value));

        public static implicit operator short(WPARAM value) => (short)(value.Value);

        public static explicit operator WPARAM(int value) => new WPARAM((nuint)(value));

        public static implicit operator int(WPARAM value) => (int)(value.Value);

        public static implicit operator WPARAM(long value) => new WPARAM((nuint)(value));

        public static explicit operator long(WPARAM value) => (long)(value.Value);

        public static explicit operator WPARAM(nint value) => new WPARAM((nuint)(value));

        public static explicit operator nint(WPARAM value) => (nint)(value.Value);

        public static explicit operator WPARAM(sbyte value) => new WPARAM((nuint)(value));

        public static implicit operator sbyte(WPARAM value) => (sbyte)(value.Value);

        public static explicit operator WPARAM(ushort value) => new WPARAM((nuint)(value));

        public static implicit operator ushort(WPARAM value) => (ushort)(value.Value);

        public static explicit operator WPARAM(uint value) => new WPARAM((nuint)(value));

        public static implicit operator uint(WPARAM value) => (uint)(value.Value);

        public static implicit operator WPARAM(ulong value) => new WPARAM((nuint)(value));

        public static explicit operator ulong(WPARAM value) => (ulong)(value.Value);

        public static implicit operator WPARAM(nuint value) => new WPARAM((nuint)(value));

        public static implicit operator nuint(WPARAM value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is WPARAM other) && Equals(other);

        public bool Equals(WPARAM other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
