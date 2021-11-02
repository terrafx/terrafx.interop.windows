// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NFC_REMOTE_DEV_HANDLE : IComparable, IComparable<NFC_REMOTE_DEV_HANDLE>, IEquatable<NFC_REMOTE_DEV_HANDLE>, IFormattable
    {
        public readonly nint Value;

        public NFC_REMOTE_DEV_HANDLE(nint value)
        {
            Value = value;
        }

        public static NFC_REMOTE_DEV_HANDLE INVALID_VALUE => new NFC_REMOTE_DEV_HANDLE(-1);

        public static NFC_REMOTE_DEV_HANDLE NULL => new NFC_REMOTE_DEV_HANDLE(0);

        public static bool operator ==(NFC_REMOTE_DEV_HANDLE left, NFC_REMOTE_DEV_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(NFC_REMOTE_DEV_HANDLE left, NFC_REMOTE_DEV_HANDLE right) => left.Value != right.Value;

        public static bool operator <(NFC_REMOTE_DEV_HANDLE left, NFC_REMOTE_DEV_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(NFC_REMOTE_DEV_HANDLE left, NFC_REMOTE_DEV_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(NFC_REMOTE_DEV_HANDLE left, NFC_REMOTE_DEV_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(NFC_REMOTE_DEV_HANDLE left, NFC_REMOTE_DEV_HANDLE right) => left.Value >= right.Value;

        public static explicit operator NFC_REMOTE_DEV_HANDLE(void* value) => new NFC_REMOTE_DEV_HANDLE((nint)(value));

        public static implicit operator void*(NFC_REMOTE_DEV_HANDLE value) => (void*)(value.Value);

        public static explicit operator NFC_REMOTE_DEV_HANDLE(HANDLE value) => new NFC_REMOTE_DEV_HANDLE(value);

        public static implicit operator HANDLE(NFC_REMOTE_DEV_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator NFC_REMOTE_DEV_HANDLE(byte value) => new NFC_REMOTE_DEV_HANDLE((nint)(value));

        public static explicit operator byte(NFC_REMOTE_DEV_HANDLE value) => (byte)(value.Value);

        public static explicit operator NFC_REMOTE_DEV_HANDLE(short value) => new NFC_REMOTE_DEV_HANDLE((nint)(value));

        public static explicit operator short(NFC_REMOTE_DEV_HANDLE value) => (short)(value.Value);

        public static explicit operator NFC_REMOTE_DEV_HANDLE(int value) => new NFC_REMOTE_DEV_HANDLE((nint)(value));

        public static explicit operator int(NFC_REMOTE_DEV_HANDLE value) => (int)(value.Value);

        public static explicit operator NFC_REMOTE_DEV_HANDLE(long value) => new NFC_REMOTE_DEV_HANDLE((nint)(value));

        public static implicit operator long(NFC_REMOTE_DEV_HANDLE value) => value.Value;

        public static explicit operator NFC_REMOTE_DEV_HANDLE(nint value) => new NFC_REMOTE_DEV_HANDLE((nint)(value));

        public static implicit operator nint(NFC_REMOTE_DEV_HANDLE value) => value.Value;

        public static explicit operator NFC_REMOTE_DEV_HANDLE(sbyte value) => new NFC_REMOTE_DEV_HANDLE((nint)(value));

        public static explicit operator sbyte(NFC_REMOTE_DEV_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator NFC_REMOTE_DEV_HANDLE(ushort value) => new NFC_REMOTE_DEV_HANDLE((nint)(value));

        public static explicit operator ushort(NFC_REMOTE_DEV_HANDLE value) => (ushort)(value.Value);

        public static explicit operator NFC_REMOTE_DEV_HANDLE(uint value) => new NFC_REMOTE_DEV_HANDLE((nint)(value));

        public static explicit operator uint(NFC_REMOTE_DEV_HANDLE value) => (uint)(value.Value);

        public static explicit operator NFC_REMOTE_DEV_HANDLE(ulong value) => new NFC_REMOTE_DEV_HANDLE((nint)(value));

        public static explicit operator ulong(NFC_REMOTE_DEV_HANDLE value) => (ulong)(value.Value);

        public static explicit operator NFC_REMOTE_DEV_HANDLE(nuint value) => new NFC_REMOTE_DEV_HANDLE((nint)(value));

        public static explicit operator nuint(NFC_REMOTE_DEV_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is NFC_REMOTE_DEV_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of NFC_REMOTE_DEV_HANDLE.");
        }

        public int CompareTo(NFC_REMOTE_DEV_HANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is NFC_REMOTE_DEV_HANDLE other) && Equals(other);

        public bool Equals(NFC_REMOTE_DEV_HANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
