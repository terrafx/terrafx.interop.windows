// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct ASYNCCOMPLETIONHANDLE : IComparable, IComparable<ASYNCCOMPLETIONHANDLE>, IEquatable<ASYNCCOMPLETIONHANDLE>, IFormattable
    {
        public readonly nuint Value;

        public ASYNCCOMPLETIONHANDLE(nuint value)
        {
            Value = value;
        }

        public static ASYNCCOMPLETIONHANDLE NULL => new ASYNCCOMPLETIONHANDLE(0);

        public static bool operator ==(ASYNCCOMPLETIONHANDLE left, ASYNCCOMPLETIONHANDLE right) => left.Value == right.Value;

        public static bool operator !=(ASYNCCOMPLETIONHANDLE left, ASYNCCOMPLETIONHANDLE right) => left.Value != right.Value;

        public static bool operator <(ASYNCCOMPLETIONHANDLE left, ASYNCCOMPLETIONHANDLE right) => left.Value < right.Value;

        public static bool operator <=(ASYNCCOMPLETIONHANDLE left, ASYNCCOMPLETIONHANDLE right) => left.Value <= right.Value;

        public static bool operator >(ASYNCCOMPLETIONHANDLE left, ASYNCCOMPLETIONHANDLE right) => left.Value > right.Value;

        public static bool operator >=(ASYNCCOMPLETIONHANDLE left, ASYNCCOMPLETIONHANDLE right) => left.Value >= right.Value;

        public static explicit operator ASYNCCOMPLETIONHANDLE(void* value) => new ASYNCCOMPLETIONHANDLE((nuint)(value));

        public static implicit operator void*(ASYNCCOMPLETIONHANDLE value) => (void*)(value.Value);

        public static explicit operator ASYNCCOMPLETIONHANDLE(byte value) => new ASYNCCOMPLETIONHANDLE((nuint)(value));

        public static explicit operator byte(ASYNCCOMPLETIONHANDLE value) => (byte)(value.Value);

        public static explicit operator ASYNCCOMPLETIONHANDLE(short value) => new ASYNCCOMPLETIONHANDLE((nuint)(value));

        public static explicit operator short(ASYNCCOMPLETIONHANDLE value) => (short)(value.Value);

        public static explicit operator ASYNCCOMPLETIONHANDLE(int value) => new ASYNCCOMPLETIONHANDLE((nuint)(value));

        public static explicit operator int(ASYNCCOMPLETIONHANDLE value) => (int)(value.Value);

        public static explicit operator ASYNCCOMPLETIONHANDLE(long value) => new ASYNCCOMPLETIONHANDLE((nuint)(value));

        public static explicit operator long(ASYNCCOMPLETIONHANDLE value) => (long)(value.Value);

        public static explicit operator ASYNCCOMPLETIONHANDLE(nint value) => new ASYNCCOMPLETIONHANDLE((nuint)(value));

        public static explicit operator nint(ASYNCCOMPLETIONHANDLE value) => (nint)(value.Value);

        public static explicit operator ASYNCCOMPLETIONHANDLE(sbyte value) => new ASYNCCOMPLETIONHANDLE((nuint)(value));

        public static explicit operator sbyte(ASYNCCOMPLETIONHANDLE value) => (sbyte)(value.Value);

        public static explicit operator ASYNCCOMPLETIONHANDLE(ushort value) => new ASYNCCOMPLETIONHANDLE((nuint)(value));

        public static explicit operator ushort(ASYNCCOMPLETIONHANDLE value) => (ushort)(value.Value);

        public static explicit operator ASYNCCOMPLETIONHANDLE(uint value) => new ASYNCCOMPLETIONHANDLE((nuint)(value));

        public static explicit operator uint(ASYNCCOMPLETIONHANDLE value) => (uint)(value.Value);

        public static explicit operator ASYNCCOMPLETIONHANDLE(ulong value) => new ASYNCCOMPLETIONHANDLE((nuint)(value));

        public static implicit operator ulong(ASYNCCOMPLETIONHANDLE value) => value.Value;

        public static explicit operator ASYNCCOMPLETIONHANDLE(nuint value) => new ASYNCCOMPLETIONHANDLE((nuint)(value));

        public static implicit operator nuint(ASYNCCOMPLETIONHANDLE value) => value.Value;

        public int CompareTo(object? obj)
        {
            if (obj is ASYNCCOMPLETIONHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of ASYNCCOMPLETIONHANDLE.");
        }

        public int CompareTo(ASYNCCOMPLETIONHANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is ASYNCCOMPLETIONHANDLE other) && Equals(other);

        public bool Equals(ASYNCCOMPLETIONHANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
