// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct NFC_SE_HANDLE : IComparable, IComparable<NFC_SE_HANDLE>, IEquatable<NFC_SE_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public NFC_SE_HANDLE(void* value)
        {
            Value = value;
        }

        public static NFC_SE_HANDLE INVALID_VALUE => new NFC_SE_HANDLE((void*)(-1));

        public static NFC_SE_HANDLE NULL => new NFC_SE_HANDLE(null);

        public static bool operator ==(NFC_SE_HANDLE left, NFC_SE_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(NFC_SE_HANDLE left, NFC_SE_HANDLE right) => left.Value != right.Value;

        public static bool operator <(NFC_SE_HANDLE left, NFC_SE_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(NFC_SE_HANDLE left, NFC_SE_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(NFC_SE_HANDLE left, NFC_SE_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(NFC_SE_HANDLE left, NFC_SE_HANDLE right) => left.Value >= right.Value;

        public static explicit operator NFC_SE_HANDLE(void* value) => new NFC_SE_HANDLE(value);

        public static implicit operator void*(NFC_SE_HANDLE value) => value.Value;

        public static explicit operator NFC_SE_HANDLE(HANDLE value) => new NFC_SE_HANDLE(value);

        public static implicit operator HANDLE(NFC_SE_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator NFC_SE_HANDLE(byte value) => new NFC_SE_HANDLE((void*)(value));

        public static explicit operator byte(NFC_SE_HANDLE value) => (byte)(value.Value);

        public static explicit operator NFC_SE_HANDLE(short value) => new NFC_SE_HANDLE((void*)(value));

        public static explicit operator short(NFC_SE_HANDLE value) => (short)(value.Value);

        public static explicit operator NFC_SE_HANDLE(int value) => new NFC_SE_HANDLE((void*)(value));

        public static explicit operator int(NFC_SE_HANDLE value) => (int)(value.Value);

        public static explicit operator NFC_SE_HANDLE(long value) => new NFC_SE_HANDLE((void*)(value));

        public static explicit operator long(NFC_SE_HANDLE value) => (long)(value.Value);

        public static explicit operator NFC_SE_HANDLE(nint value) => new NFC_SE_HANDLE((void*)(value));

        public static implicit operator nint(NFC_SE_HANDLE value) => (nint)(value.Value);

        public static explicit operator NFC_SE_HANDLE(sbyte value) => new NFC_SE_HANDLE((void*)(value));

        public static explicit operator sbyte(NFC_SE_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator NFC_SE_HANDLE(ushort value) => new NFC_SE_HANDLE((void*)(value));

        public static explicit operator ushort(NFC_SE_HANDLE value) => (ushort)(value.Value);

        public static explicit operator NFC_SE_HANDLE(uint value) => new NFC_SE_HANDLE((void*)(value));

        public static explicit operator uint(NFC_SE_HANDLE value) => (uint)(value.Value);

        public static explicit operator NFC_SE_HANDLE(ulong value) => new NFC_SE_HANDLE((void*)(value));

        public static explicit operator ulong(NFC_SE_HANDLE value) => (ulong)(value.Value);

        public static explicit operator NFC_SE_HANDLE(nuint value) => new NFC_SE_HANDLE((void*)(value));

        public static implicit operator nuint(NFC_SE_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is NFC_SE_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of NFC_SE_HANDLE.");
        }

        public int CompareTo(NFC_SE_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is NFC_SE_HANDLE other) && Equals(other);

        public bool Equals(NFC_SE_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
