// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTOIDFUNCADDR : IComparable, IComparable<HCRYPTOIDFUNCADDR>, IEquatable<HCRYPTOIDFUNCADDR>, IFormattable
    {
        public readonly nint Value;

        public HCRYPTOIDFUNCADDR(nint value)
        {
            Value = value;
        }

        public static HCRYPTOIDFUNCADDR INVALID_VALUE => new HCRYPTOIDFUNCADDR(-1);

        public static HCRYPTOIDFUNCADDR NULL => new HCRYPTOIDFUNCADDR(0);

        public static bool operator ==(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) => left.Value != right.Value;

        public static bool operator <(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) => left.Value < right.Value;

        public static bool operator <=(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) => left.Value <= right.Value;

        public static bool operator >(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) => left.Value > right.Value;

        public static bool operator >=(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) => left.Value >= right.Value;

        public static explicit operator HCRYPTOIDFUNCADDR(void* value) => new HCRYPTOIDFUNCADDR((nint)(value));

        public static implicit operator void*(HCRYPTOIDFUNCADDR value) => (void*)(value.Value);

        public static explicit operator HCRYPTOIDFUNCADDR(HANDLE value) => new HCRYPTOIDFUNCADDR(value);

        public static implicit operator HANDLE(HCRYPTOIDFUNCADDR value) => new HANDLE(value.Value);

        public static explicit operator HCRYPTOIDFUNCADDR(byte value) => new HCRYPTOIDFUNCADDR((nint)(value));

        public static explicit operator byte(HCRYPTOIDFUNCADDR value) => (byte)(value.Value);

        public static explicit operator HCRYPTOIDFUNCADDR(short value) => new HCRYPTOIDFUNCADDR((nint)(value));

        public static explicit operator short(HCRYPTOIDFUNCADDR value) => (short)(value.Value);

        public static explicit operator HCRYPTOIDFUNCADDR(int value) => new HCRYPTOIDFUNCADDR((nint)(value));

        public static explicit operator int(HCRYPTOIDFUNCADDR value) => (int)(value.Value);

        public static explicit operator HCRYPTOIDFUNCADDR(long value) => new HCRYPTOIDFUNCADDR((nint)(value));

        public static implicit operator long(HCRYPTOIDFUNCADDR value) => (long)(value.Value);

        public static explicit operator HCRYPTOIDFUNCADDR(nint value) => new HCRYPTOIDFUNCADDR((nint)(value));

        public static implicit operator nint(HCRYPTOIDFUNCADDR value) => (nint)(value.Value);

        public static explicit operator HCRYPTOIDFUNCADDR(sbyte value) => new HCRYPTOIDFUNCADDR((nint)(value));

        public static explicit operator sbyte(HCRYPTOIDFUNCADDR value) => (sbyte)(value.Value);

        public static explicit operator HCRYPTOIDFUNCADDR(ushort value) => new HCRYPTOIDFUNCADDR((nint)(value));

        public static explicit operator ushort(HCRYPTOIDFUNCADDR value) => (ushort)(value.Value);

        public static explicit operator HCRYPTOIDFUNCADDR(uint value) => new HCRYPTOIDFUNCADDR((nint)(value));

        public static explicit operator uint(HCRYPTOIDFUNCADDR value) => (uint)(value.Value);

        public static explicit operator HCRYPTOIDFUNCADDR(ulong value) => new HCRYPTOIDFUNCADDR((nint)(value));

        public static explicit operator ulong(HCRYPTOIDFUNCADDR value) => (ulong)(value.Value);

        public static explicit operator HCRYPTOIDFUNCADDR(nuint value) => new HCRYPTOIDFUNCADDR((nint)(value));

        public static explicit operator nuint(HCRYPTOIDFUNCADDR value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCRYPTOIDFUNCADDR other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCRYPTOIDFUNCADDR.");
        }

        public int CompareTo(HCRYPTOIDFUNCADDR other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTOIDFUNCADDR other) && Equals(other);

        public bool Equals(HCRYPTOIDFUNCADDR other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
