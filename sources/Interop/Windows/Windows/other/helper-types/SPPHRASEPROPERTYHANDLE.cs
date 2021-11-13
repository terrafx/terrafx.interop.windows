// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SPPHRASEPROPERTYHANDLE : IComparable, IComparable<SPPHRASEPROPERTYHANDLE>, IEquatable<SPPHRASEPROPERTYHANDLE>, IFormattable
    {
        public readonly void* Value;

        public SPPHRASEPROPERTYHANDLE(void* value)
        {
            Value = value;
        }

        public static SPPHRASEPROPERTYHANDLE INVALID_VALUE => new SPPHRASEPROPERTYHANDLE((void*)(-1));

        public static SPPHRASEPROPERTYHANDLE NULL => new SPPHRASEPROPERTYHANDLE(null);

        public static bool operator ==(SPPHRASEPROPERTYHANDLE left, SPPHRASEPROPERTYHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPPHRASEPROPERTYHANDLE left, SPPHRASEPROPERTYHANDLE right) => left.Value != right.Value;

        public static bool operator <(SPPHRASEPROPERTYHANDLE left, SPPHRASEPROPERTYHANDLE right) => left.Value < right.Value;

        public static bool operator <=(SPPHRASEPROPERTYHANDLE left, SPPHRASEPROPERTYHANDLE right) => left.Value <= right.Value;

        public static bool operator >(SPPHRASEPROPERTYHANDLE left, SPPHRASEPROPERTYHANDLE right) => left.Value > right.Value;

        public static bool operator >=(SPPHRASEPROPERTYHANDLE left, SPPHRASEPROPERTYHANDLE right) => left.Value >= right.Value;

        public static explicit operator SPPHRASEPROPERTYHANDLE(void* value) => new SPPHRASEPROPERTYHANDLE(value);

        public static implicit operator void*(SPPHRASEPROPERTYHANDLE value) => value.Value;

        public static explicit operator SPPHRASEPROPERTYHANDLE(HANDLE value) => new SPPHRASEPROPERTYHANDLE(value);

        public static implicit operator HANDLE(SPPHRASEPROPERTYHANDLE value) => new HANDLE(value.Value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(byte value) => new SPPHRASEPROPERTYHANDLE((void*)(value));

        public static explicit operator byte(SPPHRASEPROPERTYHANDLE value) => (byte)(value.Value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(short value) => new SPPHRASEPROPERTYHANDLE((void*)(value));

        public static explicit operator short(SPPHRASEPROPERTYHANDLE value) => (short)(value.Value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(int value) => new SPPHRASEPROPERTYHANDLE((void*)(value));

        public static explicit operator int(SPPHRASEPROPERTYHANDLE value) => (int)(value.Value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(long value) => new SPPHRASEPROPERTYHANDLE((void*)(value));

        public static explicit operator long(SPPHRASEPROPERTYHANDLE value) => (long)(value.Value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(nint value) => new SPPHRASEPROPERTYHANDLE((void*)(value));

        public static implicit operator nint(SPPHRASEPROPERTYHANDLE value) => (nint)(value.Value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(sbyte value) => new SPPHRASEPROPERTYHANDLE((void*)(value));

        public static explicit operator sbyte(SPPHRASEPROPERTYHANDLE value) => (sbyte)(value.Value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(ushort value) => new SPPHRASEPROPERTYHANDLE((void*)(value));

        public static explicit operator ushort(SPPHRASEPROPERTYHANDLE value) => (ushort)(value.Value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(uint value) => new SPPHRASEPROPERTYHANDLE((void*)(value));

        public static explicit operator uint(SPPHRASEPROPERTYHANDLE value) => (uint)(value.Value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(ulong value) => new SPPHRASEPROPERTYHANDLE((void*)(value));

        public static explicit operator ulong(SPPHRASEPROPERTYHANDLE value) => (ulong)(value.Value);

        public static explicit operator SPPHRASEPROPERTYHANDLE(nuint value) => new SPPHRASEPROPERTYHANDLE((void*)(value));

        public static implicit operator nuint(SPPHRASEPROPERTYHANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is SPPHRASEPROPERTYHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SPPHRASEPROPERTYHANDLE.");
        }

        public int CompareTo(SPPHRASEPROPERTYHANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is SPPHRASEPROPERTYHANDLE other) && Equals(other);

        public bool Equals(SPPHRASEPROPERTYHANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
