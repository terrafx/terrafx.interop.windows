// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HTRANSFORM : IComparable, IComparable<HTRANSFORM>, IEquatable<HTRANSFORM>, IFormattable
    {
        public readonly nint Value;

        public HTRANSFORM(nint value)
        {
            Value = value;
        }

        public static HTRANSFORM INVALID_VALUE => new HTRANSFORM(-1);

        public static HTRANSFORM NULL => new HTRANSFORM(0);

        public static bool operator ==(HTRANSFORM left, HTRANSFORM right) => left.Value == right.Value;

        public static bool operator !=(HTRANSFORM left, HTRANSFORM right) => left.Value != right.Value;

        public static bool operator <(HTRANSFORM left, HTRANSFORM right) => left.Value < right.Value;

        public static bool operator <=(HTRANSFORM left, HTRANSFORM right) => left.Value <= right.Value;

        public static bool operator >(HTRANSFORM left, HTRANSFORM right) => left.Value > right.Value;

        public static bool operator >=(HTRANSFORM left, HTRANSFORM right) => left.Value >= right.Value;

        public static explicit operator HTRANSFORM(void* value) => new HTRANSFORM((nint)(value));

        public static implicit operator void*(HTRANSFORM value) => (void*)(value.Value);

        public static explicit operator HTRANSFORM(HANDLE value) => new HTRANSFORM(value);

        public static implicit operator HANDLE(HTRANSFORM value) => new HANDLE(value.Value);

        public static explicit operator HTRANSFORM(byte value) => new HTRANSFORM((nint)(value));

        public static explicit operator byte(HTRANSFORM value) => (byte)(value.Value);

        public static explicit operator HTRANSFORM(short value) => new HTRANSFORM((nint)(value));

        public static explicit operator short(HTRANSFORM value) => (short)(value.Value);

        public static explicit operator HTRANSFORM(int value) => new HTRANSFORM((nint)(value));

        public static explicit operator int(HTRANSFORM value) => (int)(value.Value);

        public static explicit operator HTRANSFORM(long value) => new HTRANSFORM((nint)(value));

        public static implicit operator long(HTRANSFORM value) => value.Value;

        public static explicit operator HTRANSFORM(nint value) => new HTRANSFORM((nint)(value));

        public static implicit operator nint(HTRANSFORM value) => value.Value;

        public static explicit operator HTRANSFORM(sbyte value) => new HTRANSFORM((nint)(value));

        public static explicit operator sbyte(HTRANSFORM value) => (sbyte)(value.Value);

        public static explicit operator HTRANSFORM(ushort value) => new HTRANSFORM((nint)(value));

        public static explicit operator ushort(HTRANSFORM value) => (ushort)(value.Value);

        public static explicit operator HTRANSFORM(uint value) => new HTRANSFORM((nint)(value));

        public static explicit operator uint(HTRANSFORM value) => (uint)(value.Value);

        public static explicit operator HTRANSFORM(ulong value) => new HTRANSFORM((nint)(value));

        public static explicit operator ulong(HTRANSFORM value) => (ulong)(value.Value);

        public static explicit operator HTRANSFORM(nuint value) => new HTRANSFORM((nint)(value));

        public static explicit operator nuint(HTRANSFORM value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HTRANSFORM other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HTRANSFORM.");
        }

        public int CompareTo(HTRANSFORM other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HTRANSFORM other) && Equals(other);

        public bool Equals(HTRANSFORM other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
