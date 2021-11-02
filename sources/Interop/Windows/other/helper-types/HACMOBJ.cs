// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HACMOBJ : IComparable, IComparable<HACMOBJ>, IEquatable<HACMOBJ>, IFormattable
    {
        public readonly void* Value;

        public HACMOBJ(void* value)
        {
            Value = value;
        }

        public static HACMOBJ INVALID_VALUE => new HACMOBJ((void*)(-1));

        public static HACMOBJ NULL => new HACMOBJ(null);

        public static bool operator ==(HACMOBJ left, HACMOBJ right) => left.Value == right.Value;

        public static bool operator !=(HACMOBJ left, HACMOBJ right) => left.Value != right.Value;

        public static bool operator <(HACMOBJ left, HACMOBJ right) => left.Value < right.Value;

        public static bool operator <=(HACMOBJ left, HACMOBJ right) => left.Value <= right.Value;

        public static bool operator >(HACMOBJ left, HACMOBJ right) => left.Value > right.Value;

        public static bool operator >=(HACMOBJ left, HACMOBJ right) => left.Value >= right.Value;

        public static explicit operator HACMOBJ(void* value) => new HACMOBJ(value);

        public static implicit operator void*(HACMOBJ value) => value.Value;

        public static explicit operator HACMOBJ(HANDLE value) => new HACMOBJ(value);

        public static implicit operator HANDLE(HACMOBJ value) => new HANDLE(value.Value);

        public static explicit operator HACMOBJ(byte value) => new HACMOBJ((void*)(value));

        public static explicit operator byte(HACMOBJ value) => (byte)(value.Value);

        public static explicit operator HACMOBJ(short value) => new HACMOBJ((void*)(value));

        public static explicit operator short(HACMOBJ value) => (short)(value.Value);

        public static explicit operator HACMOBJ(int value) => new HACMOBJ((void*)(value));

        public static explicit operator int(HACMOBJ value) => (int)(value.Value);

        public static explicit operator HACMOBJ(long value) => new HACMOBJ((void*)(value));

        public static explicit operator long(HACMOBJ value) => (long)(value.Value);

        public static explicit operator HACMOBJ(nint value) => new HACMOBJ((void*)(value));

        public static implicit operator nint(HACMOBJ value) => (nint)(value.Value);

        public static explicit operator HACMOBJ(sbyte value) => new HACMOBJ((void*)(value));

        public static explicit operator sbyte(HACMOBJ value) => (sbyte)(value.Value);

        public static explicit operator HACMOBJ(ushort value) => new HACMOBJ((void*)(value));

        public static explicit operator ushort(HACMOBJ value) => (ushort)(value.Value);

        public static explicit operator HACMOBJ(uint value) => new HACMOBJ((void*)(value));

        public static explicit operator uint(HACMOBJ value) => (uint)(value.Value);

        public static explicit operator HACMOBJ(ulong value) => new HACMOBJ((void*)(value));

        public static explicit operator ulong(HACMOBJ value) => (ulong)(value.Value);

        public static explicit operator HACMOBJ(nuint value) => new HACMOBJ((void*)(value));

        public static implicit operator nuint(HACMOBJ value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HACMOBJ other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HACMOBJ.");
        }

        public int CompareTo(HACMOBJ other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HACMOBJ other) && Equals(other);

        public bool Equals(HACMOBJ other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
