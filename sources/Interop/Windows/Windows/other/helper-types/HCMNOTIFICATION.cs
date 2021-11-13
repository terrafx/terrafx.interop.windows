// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HCMNOTIFICATION : IComparable, IComparable<HCMNOTIFICATION>, IEquatable<HCMNOTIFICATION>, IFormattable
    {
        public readonly void* Value;

        public HCMNOTIFICATION(void* value)
        {
            Value = value;
        }

        public static HCMNOTIFICATION INVALID_VALUE => new HCMNOTIFICATION((void*)(-1));

        public static HCMNOTIFICATION NULL => new HCMNOTIFICATION(null);

        public static bool operator ==(HCMNOTIFICATION left, HCMNOTIFICATION right) => left.Value == right.Value;

        public static bool operator !=(HCMNOTIFICATION left, HCMNOTIFICATION right) => left.Value != right.Value;

        public static bool operator <(HCMNOTIFICATION left, HCMNOTIFICATION right) => left.Value < right.Value;

        public static bool operator <=(HCMNOTIFICATION left, HCMNOTIFICATION right) => left.Value <= right.Value;

        public static bool operator >(HCMNOTIFICATION left, HCMNOTIFICATION right) => left.Value > right.Value;

        public static bool operator >=(HCMNOTIFICATION left, HCMNOTIFICATION right) => left.Value >= right.Value;

        public static explicit operator HCMNOTIFICATION(void* value) => new HCMNOTIFICATION(value);

        public static implicit operator void*(HCMNOTIFICATION value) => value.Value;

        public static explicit operator HCMNOTIFICATION(HANDLE value) => new HCMNOTIFICATION(value);

        public static implicit operator HANDLE(HCMNOTIFICATION value) => new HANDLE(value.Value);

        public static explicit operator HCMNOTIFICATION(byte value) => new HCMNOTIFICATION((void*)(value));

        public static explicit operator byte(HCMNOTIFICATION value) => (byte)(value.Value);

        public static explicit operator HCMNOTIFICATION(short value) => new HCMNOTIFICATION((void*)(value));

        public static explicit operator short(HCMNOTIFICATION value) => (short)(value.Value);

        public static explicit operator HCMNOTIFICATION(int value) => new HCMNOTIFICATION((void*)(value));

        public static explicit operator int(HCMNOTIFICATION value) => (int)(value.Value);

        public static explicit operator HCMNOTIFICATION(long value) => new HCMNOTIFICATION((void*)(value));

        public static explicit operator long(HCMNOTIFICATION value) => (long)(value.Value);

        public static explicit operator HCMNOTIFICATION(nint value) => new HCMNOTIFICATION((void*)(value));

        public static implicit operator nint(HCMNOTIFICATION value) => (nint)(value.Value);

        public static explicit operator HCMNOTIFICATION(sbyte value) => new HCMNOTIFICATION((void*)(value));

        public static explicit operator sbyte(HCMNOTIFICATION value) => (sbyte)(value.Value);

        public static explicit operator HCMNOTIFICATION(ushort value) => new HCMNOTIFICATION((void*)(value));

        public static explicit operator ushort(HCMNOTIFICATION value) => (ushort)(value.Value);

        public static explicit operator HCMNOTIFICATION(uint value) => new HCMNOTIFICATION((void*)(value));

        public static explicit operator uint(HCMNOTIFICATION value) => (uint)(value.Value);

        public static explicit operator HCMNOTIFICATION(ulong value) => new HCMNOTIFICATION((void*)(value));

        public static explicit operator ulong(HCMNOTIFICATION value) => (ulong)(value.Value);

        public static explicit operator HCMNOTIFICATION(nuint value) => new HCMNOTIFICATION((void*)(value));

        public static implicit operator nuint(HCMNOTIFICATION value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCMNOTIFICATION other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCMNOTIFICATION.");
        }

        public int CompareTo(HCMNOTIFICATION other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HCMNOTIFICATION other) && Equals(other);

        public bool Equals(HCMNOTIFICATION other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
