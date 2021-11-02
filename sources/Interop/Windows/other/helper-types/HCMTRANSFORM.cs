// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCMTRANSFORM : IComparable, IComparable<HCMTRANSFORM>, IEquatable<HCMTRANSFORM>, IFormattable
    {
        public readonly nint Value;

        public HCMTRANSFORM(nint value)
        {
            Value = value;
        }

        public static HCMTRANSFORM INVALID_VALUE => new HCMTRANSFORM(-1);

        public static HCMTRANSFORM NULL => new HCMTRANSFORM(0);

        public static bool operator ==(HCMTRANSFORM left, HCMTRANSFORM right) => left.Value == right.Value;

        public static bool operator !=(HCMTRANSFORM left, HCMTRANSFORM right) => left.Value != right.Value;

        public static bool operator <(HCMTRANSFORM left, HCMTRANSFORM right) => left.Value < right.Value;

        public static bool operator <=(HCMTRANSFORM left, HCMTRANSFORM right) => left.Value <= right.Value;

        public static bool operator >(HCMTRANSFORM left, HCMTRANSFORM right) => left.Value > right.Value;

        public static bool operator >=(HCMTRANSFORM left, HCMTRANSFORM right) => left.Value >= right.Value;

        public static explicit operator HCMTRANSFORM(void* value) => new HCMTRANSFORM((nint)(value));

        public static implicit operator void*(HCMTRANSFORM value) => (void*)(value.Value);

        public static explicit operator HCMTRANSFORM(HANDLE value) => new HCMTRANSFORM(value);

        public static implicit operator HANDLE(HCMTRANSFORM value) => new HANDLE(value.Value);

        public static explicit operator HCMTRANSFORM(byte value) => new HCMTRANSFORM((nint)(value));

        public static explicit operator byte(HCMTRANSFORM value) => (byte)(value.Value);

        public static explicit operator HCMTRANSFORM(short value) => new HCMTRANSFORM((nint)(value));

        public static explicit operator short(HCMTRANSFORM value) => (short)(value.Value);

        public static explicit operator HCMTRANSFORM(int value) => new HCMTRANSFORM((nint)(value));

        public static explicit operator int(HCMTRANSFORM value) => (int)(value.Value);

        public static explicit operator HCMTRANSFORM(long value) => new HCMTRANSFORM((nint)(value));

        public static implicit operator long(HCMTRANSFORM value) => value.Value;

        public static explicit operator HCMTRANSFORM(nint value) => new HCMTRANSFORM((nint)(value));

        public static implicit operator nint(HCMTRANSFORM value) => value.Value;

        public static explicit operator HCMTRANSFORM(sbyte value) => new HCMTRANSFORM((nint)(value));

        public static explicit operator sbyte(HCMTRANSFORM value) => (sbyte)(value.Value);

        public static explicit operator HCMTRANSFORM(ushort value) => new HCMTRANSFORM((nint)(value));

        public static explicit operator ushort(HCMTRANSFORM value) => (ushort)(value.Value);

        public static explicit operator HCMTRANSFORM(uint value) => new HCMTRANSFORM((nint)(value));

        public static explicit operator uint(HCMTRANSFORM value) => (uint)(value.Value);

        public static explicit operator HCMTRANSFORM(ulong value) => new HCMTRANSFORM((nint)(value));

        public static explicit operator ulong(HCMTRANSFORM value) => (ulong)(value.Value);

        public static explicit operator HCMTRANSFORM(nuint value) => new HCMTRANSFORM((nint)(value));

        public static explicit operator nuint(HCMTRANSFORM value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCMTRANSFORM other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCMTRANSFORM.");
        }

        public int CompareTo(HCMTRANSFORM other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HCMTRANSFORM other) && Equals(other);

        public bool Equals(HCMTRANSFORM other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
