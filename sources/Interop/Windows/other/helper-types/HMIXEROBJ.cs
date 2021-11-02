// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMIXEROBJ : IComparable, IComparable<HMIXEROBJ>, IEquatable<HMIXEROBJ>, IFormattable
    {
        public readonly nint Value;

        public HMIXEROBJ(nint value)
        {
            Value = value;
        }

        public static HMIXEROBJ INVALID_VALUE => new HMIXEROBJ(-1);

        public static HMIXEROBJ NULL => new HMIXEROBJ(0);

        public static bool operator ==(HMIXEROBJ left, HMIXEROBJ right) => left.Value == right.Value;

        public static bool operator !=(HMIXEROBJ left, HMIXEROBJ right) => left.Value != right.Value;

        public static bool operator <(HMIXEROBJ left, HMIXEROBJ right) => left.Value < right.Value;

        public static bool operator <=(HMIXEROBJ left, HMIXEROBJ right) => left.Value <= right.Value;

        public static bool operator >(HMIXEROBJ left, HMIXEROBJ right) => left.Value > right.Value;

        public static bool operator >=(HMIXEROBJ left, HMIXEROBJ right) => left.Value >= right.Value;

        public static explicit operator HMIXEROBJ(void* value) => new HMIXEROBJ((nint)(value));

        public static implicit operator void*(HMIXEROBJ value) => (void*)(value.Value);

        public static explicit operator HMIXEROBJ(HANDLE value) => new HMIXEROBJ(value);

        public static implicit operator HANDLE(HMIXEROBJ value) => new HANDLE(value.Value);

        public static explicit operator HMIXEROBJ(byte value) => new HMIXEROBJ((nint)(value));

        public static explicit operator byte(HMIXEROBJ value) => (byte)(value.Value);

        public static explicit operator HMIXEROBJ(short value) => new HMIXEROBJ((nint)(value));

        public static explicit operator short(HMIXEROBJ value) => (short)(value.Value);

        public static explicit operator HMIXEROBJ(int value) => new HMIXEROBJ((nint)(value));

        public static explicit operator int(HMIXEROBJ value) => (int)(value.Value);

        public static explicit operator HMIXEROBJ(long value) => new HMIXEROBJ((nint)(value));

        public static implicit operator long(HMIXEROBJ value) => (long)(value.Value);

        public static explicit operator HMIXEROBJ(nint value) => new HMIXEROBJ((nint)(value));

        public static implicit operator nint(HMIXEROBJ value) => (nint)(value.Value);

        public static explicit operator HMIXEROBJ(sbyte value) => new HMIXEROBJ((nint)(value));

        public static explicit operator sbyte(HMIXEROBJ value) => (sbyte)(value.Value);

        public static explicit operator HMIXEROBJ(ushort value) => new HMIXEROBJ((nint)(value));

        public static explicit operator ushort(HMIXEROBJ value) => (ushort)(value.Value);

        public static explicit operator HMIXEROBJ(uint value) => new HMIXEROBJ((nint)(value));

        public static explicit operator uint(HMIXEROBJ value) => (uint)(value.Value);

        public static explicit operator HMIXEROBJ(ulong value) => new HMIXEROBJ((nint)(value));

        public static explicit operator ulong(HMIXEROBJ value) => (ulong)(value.Value);

        public static explicit operator HMIXEROBJ(nuint value) => new HMIXEROBJ((nint)(value));

        public static explicit operator nuint(HMIXEROBJ value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HMIXEROBJ other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HMIXEROBJ.");
        }

        public int CompareTo(HMIXEROBJ other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HMIXEROBJ other) && Equals(other);

        public bool Equals(HMIXEROBJ other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
