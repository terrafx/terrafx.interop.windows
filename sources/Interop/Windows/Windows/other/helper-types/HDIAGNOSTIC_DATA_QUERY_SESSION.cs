// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HDIAGNOSTIC_DATA_QUERY_SESSION : IComparable, IComparable<HDIAGNOSTIC_DATA_QUERY_SESSION>, IEquatable<HDIAGNOSTIC_DATA_QUERY_SESSION>, IFormattable
    {
        public readonly void* Value;

        public HDIAGNOSTIC_DATA_QUERY_SESSION(void* value)
        {
            Value = value;
        }

        public static HDIAGNOSTIC_DATA_QUERY_SESSION INVALID_VALUE => new HDIAGNOSTIC_DATA_QUERY_SESSION((void*)(-1));

        public static HDIAGNOSTIC_DATA_QUERY_SESSION NULL => new HDIAGNOSTIC_DATA_QUERY_SESSION(null);

        public static bool operator ==(HDIAGNOSTIC_DATA_QUERY_SESSION left, HDIAGNOSTIC_DATA_QUERY_SESSION right) => left.Value == right.Value;

        public static bool operator !=(HDIAGNOSTIC_DATA_QUERY_SESSION left, HDIAGNOSTIC_DATA_QUERY_SESSION right) => left.Value != right.Value;

        public static bool operator <(HDIAGNOSTIC_DATA_QUERY_SESSION left, HDIAGNOSTIC_DATA_QUERY_SESSION right) => left.Value < right.Value;

        public static bool operator <=(HDIAGNOSTIC_DATA_QUERY_SESSION left, HDIAGNOSTIC_DATA_QUERY_SESSION right) => left.Value <= right.Value;

        public static bool operator >(HDIAGNOSTIC_DATA_QUERY_SESSION left, HDIAGNOSTIC_DATA_QUERY_SESSION right) => left.Value > right.Value;

        public static bool operator >=(HDIAGNOSTIC_DATA_QUERY_SESSION left, HDIAGNOSTIC_DATA_QUERY_SESSION right) => left.Value >= right.Value;

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(void* value) => new HDIAGNOSTIC_DATA_QUERY_SESSION(value);

        public static implicit operator void*(HDIAGNOSTIC_DATA_QUERY_SESSION value) => value.Value;

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(HANDLE value) => new HDIAGNOSTIC_DATA_QUERY_SESSION(value);

        public static implicit operator HANDLE(HDIAGNOSTIC_DATA_QUERY_SESSION value) => new HANDLE(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(byte value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((void*)(value));

        public static explicit operator byte(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (byte)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(short value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((void*)(value));

        public static explicit operator short(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (short)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(int value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((void*)(value));

        public static explicit operator int(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (int)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(long value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((void*)(value));

        public static explicit operator long(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (long)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(nint value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((void*)(value));

        public static implicit operator nint(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (nint)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(sbyte value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((void*)(value));

        public static explicit operator sbyte(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (sbyte)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(ushort value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((void*)(value));

        public static explicit operator ushort(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (ushort)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(uint value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((void*)(value));

        public static explicit operator uint(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (uint)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(ulong value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((void*)(value));

        public static explicit operator ulong(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (ulong)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(nuint value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((void*)(value));

        public static implicit operator nuint(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDIAGNOSTIC_DATA_QUERY_SESSION other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDIAGNOSTIC_DATA_QUERY_SESSION.");
        }

        public int CompareTo(HDIAGNOSTIC_DATA_QUERY_SESSION other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HDIAGNOSTIC_DATA_QUERY_SESSION other) && Equals(other);

        public bool Equals(HDIAGNOSTIC_DATA_QUERY_SESSION other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
