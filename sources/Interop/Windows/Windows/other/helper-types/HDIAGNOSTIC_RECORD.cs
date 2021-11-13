// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HDIAGNOSTIC_RECORD : IComparable, IComparable<HDIAGNOSTIC_RECORD>, IEquatable<HDIAGNOSTIC_RECORD>, IFormattable
    {
        public readonly void* Value;

        public HDIAGNOSTIC_RECORD(void* value)
        {
            Value = value;
        }

        public static HDIAGNOSTIC_RECORD INVALID_VALUE => new HDIAGNOSTIC_RECORD((void*)(-1));

        public static HDIAGNOSTIC_RECORD NULL => new HDIAGNOSTIC_RECORD(null);

        public static bool operator ==(HDIAGNOSTIC_RECORD left, HDIAGNOSTIC_RECORD right) => left.Value == right.Value;

        public static bool operator !=(HDIAGNOSTIC_RECORD left, HDIAGNOSTIC_RECORD right) => left.Value != right.Value;

        public static bool operator <(HDIAGNOSTIC_RECORD left, HDIAGNOSTIC_RECORD right) => left.Value < right.Value;

        public static bool operator <=(HDIAGNOSTIC_RECORD left, HDIAGNOSTIC_RECORD right) => left.Value <= right.Value;

        public static bool operator >(HDIAGNOSTIC_RECORD left, HDIAGNOSTIC_RECORD right) => left.Value > right.Value;

        public static bool operator >=(HDIAGNOSTIC_RECORD left, HDIAGNOSTIC_RECORD right) => left.Value >= right.Value;

        public static explicit operator HDIAGNOSTIC_RECORD(void* value) => new HDIAGNOSTIC_RECORD(value);

        public static implicit operator void*(HDIAGNOSTIC_RECORD value) => value.Value;

        public static explicit operator HDIAGNOSTIC_RECORD(HANDLE value) => new HDIAGNOSTIC_RECORD(value);

        public static implicit operator HANDLE(HDIAGNOSTIC_RECORD value) => new HANDLE(value.Value);

        public static explicit operator HDIAGNOSTIC_RECORD(byte value) => new HDIAGNOSTIC_RECORD((void*)(value));

        public static explicit operator byte(HDIAGNOSTIC_RECORD value) => (byte)(value.Value);

        public static explicit operator HDIAGNOSTIC_RECORD(short value) => new HDIAGNOSTIC_RECORD((void*)(value));

        public static explicit operator short(HDIAGNOSTIC_RECORD value) => (short)(value.Value);

        public static explicit operator HDIAGNOSTIC_RECORD(int value) => new HDIAGNOSTIC_RECORD((void*)(value));

        public static explicit operator int(HDIAGNOSTIC_RECORD value) => (int)(value.Value);

        public static explicit operator HDIAGNOSTIC_RECORD(long value) => new HDIAGNOSTIC_RECORD((void*)(value));

        public static explicit operator long(HDIAGNOSTIC_RECORD value) => (long)(value.Value);

        public static explicit operator HDIAGNOSTIC_RECORD(nint value) => new HDIAGNOSTIC_RECORD((void*)(value));

        public static implicit operator nint(HDIAGNOSTIC_RECORD value) => (nint)(value.Value);

        public static explicit operator HDIAGNOSTIC_RECORD(sbyte value) => new HDIAGNOSTIC_RECORD((void*)(value));

        public static explicit operator sbyte(HDIAGNOSTIC_RECORD value) => (sbyte)(value.Value);

        public static explicit operator HDIAGNOSTIC_RECORD(ushort value) => new HDIAGNOSTIC_RECORD((void*)(value));

        public static explicit operator ushort(HDIAGNOSTIC_RECORD value) => (ushort)(value.Value);

        public static explicit operator HDIAGNOSTIC_RECORD(uint value) => new HDIAGNOSTIC_RECORD((void*)(value));

        public static explicit operator uint(HDIAGNOSTIC_RECORD value) => (uint)(value.Value);

        public static explicit operator HDIAGNOSTIC_RECORD(ulong value) => new HDIAGNOSTIC_RECORD((void*)(value));

        public static explicit operator ulong(HDIAGNOSTIC_RECORD value) => (ulong)(value.Value);

        public static explicit operator HDIAGNOSTIC_RECORD(nuint value) => new HDIAGNOSTIC_RECORD((void*)(value));

        public static implicit operator nuint(HDIAGNOSTIC_RECORD value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDIAGNOSTIC_RECORD other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDIAGNOSTIC_RECORD.");
        }

        public int CompareTo(HDIAGNOSTIC_RECORD other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HDIAGNOSTIC_RECORD other) && Equals(other);

        public bool Equals(HDIAGNOSTIC_RECORD other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
