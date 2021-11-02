// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HVIDPNTARGETMODESET : IComparable, IComparable<D3DKMDT_HVIDPNTARGETMODESET>, IEquatable<D3DKMDT_HVIDPNTARGETMODESET>, IFormattable
    {
        public readonly void* Value;

        public D3DKMDT_HVIDPNTARGETMODESET(void* value)
        {
            Value = value;
        }

        public static D3DKMDT_HVIDPNTARGETMODESET INVALID_VALUE => new D3DKMDT_HVIDPNTARGETMODESET((void*)(-1));

        public static D3DKMDT_HVIDPNTARGETMODESET NULL => new D3DKMDT_HVIDPNTARGETMODESET(null);

        public static bool operator ==(D3DKMDT_HVIDPNTARGETMODESET left, D3DKMDT_HVIDPNTARGETMODESET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDPNTARGETMODESET left, D3DKMDT_HVIDPNTARGETMODESET right) => left.Value != right.Value;

        public static bool operator <(D3DKMDT_HVIDPNTARGETMODESET left, D3DKMDT_HVIDPNTARGETMODESET right) => left.Value < right.Value;

        public static bool operator <=(D3DKMDT_HVIDPNTARGETMODESET left, D3DKMDT_HVIDPNTARGETMODESET right) => left.Value <= right.Value;

        public static bool operator >(D3DKMDT_HVIDPNTARGETMODESET left, D3DKMDT_HVIDPNTARGETMODESET right) => left.Value > right.Value;

        public static bool operator >=(D3DKMDT_HVIDPNTARGETMODESET left, D3DKMDT_HVIDPNTARGETMODESET right) => left.Value >= right.Value;

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(void* value) => new D3DKMDT_HVIDPNTARGETMODESET(value);

        public static implicit operator void*(D3DKMDT_HVIDPNTARGETMODESET value) => value.Value;

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(HANDLE value) => new D3DKMDT_HVIDPNTARGETMODESET(value);

        public static implicit operator HANDLE(D3DKMDT_HVIDPNTARGETMODESET value) => new HANDLE(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(byte value) => new D3DKMDT_HVIDPNTARGETMODESET((void*)(value));

        public static explicit operator byte(D3DKMDT_HVIDPNTARGETMODESET value) => (byte)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(short value) => new D3DKMDT_HVIDPNTARGETMODESET((void*)(value));

        public static explicit operator short(D3DKMDT_HVIDPNTARGETMODESET value) => (short)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(int value) => new D3DKMDT_HVIDPNTARGETMODESET((void*)(value));

        public static explicit operator int(D3DKMDT_HVIDPNTARGETMODESET value) => (int)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(long value) => new D3DKMDT_HVIDPNTARGETMODESET((void*)(value));

        public static explicit operator long(D3DKMDT_HVIDPNTARGETMODESET value) => (long)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(nint value) => new D3DKMDT_HVIDPNTARGETMODESET((void*)(value));

        public static implicit operator nint(D3DKMDT_HVIDPNTARGETMODESET value) => (nint)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(sbyte value) => new D3DKMDT_HVIDPNTARGETMODESET((void*)(value));

        public static explicit operator sbyte(D3DKMDT_HVIDPNTARGETMODESET value) => (sbyte)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(ushort value) => new D3DKMDT_HVIDPNTARGETMODESET((void*)(value));

        public static explicit operator ushort(D3DKMDT_HVIDPNTARGETMODESET value) => (ushort)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(uint value) => new D3DKMDT_HVIDPNTARGETMODESET((void*)(value));

        public static explicit operator uint(D3DKMDT_HVIDPNTARGETMODESET value) => (uint)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(ulong value) => new D3DKMDT_HVIDPNTARGETMODESET((void*)(value));

        public static explicit operator ulong(D3DKMDT_HVIDPNTARGETMODESET value) => (ulong)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(nuint value) => new D3DKMDT_HVIDPNTARGETMODESET((void*)(value));

        public static implicit operator nuint(D3DKMDT_HVIDPNTARGETMODESET value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is D3DKMDT_HVIDPNTARGETMODESET other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of D3DKMDT_HVIDPNTARGETMODESET.");
        }

        public int CompareTo(D3DKMDT_HVIDPNTARGETMODESET other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDPNTARGETMODESET other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDPNTARGETMODESET other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
