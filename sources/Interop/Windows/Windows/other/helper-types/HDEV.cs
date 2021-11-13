// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HDEV : IComparable, IComparable<HDEV>, IEquatable<HDEV>, IFormattable
    {
        public readonly void* Value;

        public HDEV(void* value)
        {
            Value = value;
        }

        public static HDEV INVALID_VALUE => new HDEV((void*)(-1));

        public static HDEV NULL => new HDEV(null);

        public static bool operator ==(HDEV left, HDEV right) => left.Value == right.Value;

        public static bool operator !=(HDEV left, HDEV right) => left.Value != right.Value;

        public static bool operator <(HDEV left, HDEV right) => left.Value < right.Value;

        public static bool operator <=(HDEV left, HDEV right) => left.Value <= right.Value;

        public static bool operator >(HDEV left, HDEV right) => left.Value > right.Value;

        public static bool operator >=(HDEV left, HDEV right) => left.Value >= right.Value;

        public static explicit operator HDEV(void* value) => new HDEV(value);

        public static implicit operator void*(HDEV value) => value.Value;

        public static explicit operator HDEV(HANDLE value) => new HDEV(value);

        public static implicit operator HANDLE(HDEV value) => new HANDLE(value.Value);

        public static explicit operator HDEV(byte value) => new HDEV((void*)(value));

        public static explicit operator byte(HDEV value) => (byte)(value.Value);

        public static explicit operator HDEV(short value) => new HDEV((void*)(value));

        public static explicit operator short(HDEV value) => (short)(value.Value);

        public static explicit operator HDEV(int value) => new HDEV((void*)(value));

        public static explicit operator int(HDEV value) => (int)(value.Value);

        public static explicit operator HDEV(long value) => new HDEV((void*)(value));

        public static explicit operator long(HDEV value) => (long)(value.Value);

        public static explicit operator HDEV(nint value) => new HDEV((void*)(value));

        public static implicit operator nint(HDEV value) => (nint)(value.Value);

        public static explicit operator HDEV(sbyte value) => new HDEV((void*)(value));

        public static explicit operator sbyte(HDEV value) => (sbyte)(value.Value);

        public static explicit operator HDEV(ushort value) => new HDEV((void*)(value));

        public static explicit operator ushort(HDEV value) => (ushort)(value.Value);

        public static explicit operator HDEV(uint value) => new HDEV((void*)(value));

        public static explicit operator uint(HDEV value) => (uint)(value.Value);

        public static explicit operator HDEV(ulong value) => new HDEV((void*)(value));

        public static explicit operator ulong(HDEV value) => (ulong)(value.Value);

        public static explicit operator HDEV(nuint value) => new HDEV((void*)(value));

        public static implicit operator nuint(HDEV value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDEV other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDEV.");
        }

        public int CompareTo(HDEV other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HDEV other) && Equals(other);

        public bool Equals(HDEV other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
