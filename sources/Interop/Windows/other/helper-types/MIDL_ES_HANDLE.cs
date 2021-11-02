// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MIDL_ES_HANDLE : IComparable, IComparable<MIDL_ES_HANDLE>, IEquatable<MIDL_ES_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public MIDL_ES_HANDLE(void* value)
        {
            Value = value;
        }

        public static MIDL_ES_HANDLE INVALID_VALUE => new MIDL_ES_HANDLE((void*)(-1));

        public static MIDL_ES_HANDLE NULL => new MIDL_ES_HANDLE(null);

        public static bool operator ==(MIDL_ES_HANDLE left, MIDL_ES_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(MIDL_ES_HANDLE left, MIDL_ES_HANDLE right) => left.Value != right.Value;

        public static bool operator <(MIDL_ES_HANDLE left, MIDL_ES_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(MIDL_ES_HANDLE left, MIDL_ES_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(MIDL_ES_HANDLE left, MIDL_ES_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(MIDL_ES_HANDLE left, MIDL_ES_HANDLE right) => left.Value >= right.Value;

        public static explicit operator MIDL_ES_HANDLE(void* value) => new MIDL_ES_HANDLE(value);

        public static implicit operator void*(MIDL_ES_HANDLE value) => value.Value;

        public static explicit operator MIDL_ES_HANDLE(HANDLE value) => new MIDL_ES_HANDLE(value);

        public static implicit operator HANDLE(MIDL_ES_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator MIDL_ES_HANDLE(byte value) => new MIDL_ES_HANDLE((void*)(value));

        public static explicit operator byte(MIDL_ES_HANDLE value) => (byte)(value.Value);

        public static explicit operator MIDL_ES_HANDLE(short value) => new MIDL_ES_HANDLE((void*)(value));

        public static explicit operator short(MIDL_ES_HANDLE value) => (short)(value.Value);

        public static explicit operator MIDL_ES_HANDLE(int value) => new MIDL_ES_HANDLE((void*)(value));

        public static explicit operator int(MIDL_ES_HANDLE value) => (int)(value.Value);

        public static explicit operator MIDL_ES_HANDLE(long value) => new MIDL_ES_HANDLE((void*)(value));

        public static explicit operator long(MIDL_ES_HANDLE value) => (long)(value.Value);

        public static explicit operator MIDL_ES_HANDLE(nint value) => new MIDL_ES_HANDLE((void*)(value));

        public static implicit operator nint(MIDL_ES_HANDLE value) => (nint)(value.Value);

        public static explicit operator MIDL_ES_HANDLE(sbyte value) => new MIDL_ES_HANDLE((void*)(value));

        public static explicit operator sbyte(MIDL_ES_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator MIDL_ES_HANDLE(ushort value) => new MIDL_ES_HANDLE((void*)(value));

        public static explicit operator ushort(MIDL_ES_HANDLE value) => (ushort)(value.Value);

        public static explicit operator MIDL_ES_HANDLE(uint value) => new MIDL_ES_HANDLE((void*)(value));

        public static explicit operator uint(MIDL_ES_HANDLE value) => (uint)(value.Value);

        public static explicit operator MIDL_ES_HANDLE(ulong value) => new MIDL_ES_HANDLE((void*)(value));

        public static explicit operator ulong(MIDL_ES_HANDLE value) => (ulong)(value.Value);

        public static explicit operator MIDL_ES_HANDLE(nuint value) => new MIDL_ES_HANDLE((void*)(value));

        public static implicit operator nuint(MIDL_ES_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is MIDL_ES_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of MIDL_ES_HANDLE.");
        }

        public int CompareTo(MIDL_ES_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is MIDL_ES_HANDLE other) && Equals(other);

        public bool Equals(MIDL_ES_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
