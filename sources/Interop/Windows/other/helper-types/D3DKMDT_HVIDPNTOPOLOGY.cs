// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HVIDPNTOPOLOGY : IComparable, IComparable<D3DKMDT_HVIDPNTOPOLOGY>, IEquatable<D3DKMDT_HVIDPNTOPOLOGY>, IFormattable
    {
        public readonly void* Value;

        public D3DKMDT_HVIDPNTOPOLOGY(void* value)
        {
            Value = value;
        }

        public static D3DKMDT_HVIDPNTOPOLOGY INVALID_VALUE => new D3DKMDT_HVIDPNTOPOLOGY((void*)(-1));

        public static D3DKMDT_HVIDPNTOPOLOGY NULL => new D3DKMDT_HVIDPNTOPOLOGY(null);

        public static bool operator ==(D3DKMDT_HVIDPNTOPOLOGY left, D3DKMDT_HVIDPNTOPOLOGY right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDPNTOPOLOGY left, D3DKMDT_HVIDPNTOPOLOGY right) => left.Value != right.Value;

        public static bool operator <(D3DKMDT_HVIDPNTOPOLOGY left, D3DKMDT_HVIDPNTOPOLOGY right) => left.Value < right.Value;

        public static bool operator <=(D3DKMDT_HVIDPNTOPOLOGY left, D3DKMDT_HVIDPNTOPOLOGY right) => left.Value <= right.Value;

        public static bool operator >(D3DKMDT_HVIDPNTOPOLOGY left, D3DKMDT_HVIDPNTOPOLOGY right) => left.Value > right.Value;

        public static bool operator >=(D3DKMDT_HVIDPNTOPOLOGY left, D3DKMDT_HVIDPNTOPOLOGY right) => left.Value >= right.Value;

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(void* value) => new D3DKMDT_HVIDPNTOPOLOGY(value);

        public static implicit operator void*(D3DKMDT_HVIDPNTOPOLOGY value) => value.Value;

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(HANDLE value) => new D3DKMDT_HVIDPNTOPOLOGY(value);

        public static implicit operator HANDLE(D3DKMDT_HVIDPNTOPOLOGY value) => new HANDLE(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(byte value) => new D3DKMDT_HVIDPNTOPOLOGY((void*)(value));

        public static explicit operator byte(D3DKMDT_HVIDPNTOPOLOGY value) => (byte)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(short value) => new D3DKMDT_HVIDPNTOPOLOGY((void*)(value));

        public static explicit operator short(D3DKMDT_HVIDPNTOPOLOGY value) => (short)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(int value) => new D3DKMDT_HVIDPNTOPOLOGY((void*)(value));

        public static explicit operator int(D3DKMDT_HVIDPNTOPOLOGY value) => (int)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(long value) => new D3DKMDT_HVIDPNTOPOLOGY((void*)(value));

        public static explicit operator long(D3DKMDT_HVIDPNTOPOLOGY value) => (long)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(nint value) => new D3DKMDT_HVIDPNTOPOLOGY((void*)(value));

        public static implicit operator nint(D3DKMDT_HVIDPNTOPOLOGY value) => (nint)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(sbyte value) => new D3DKMDT_HVIDPNTOPOLOGY((void*)(value));

        public static explicit operator sbyte(D3DKMDT_HVIDPNTOPOLOGY value) => (sbyte)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(ushort value) => new D3DKMDT_HVIDPNTOPOLOGY((void*)(value));

        public static explicit operator ushort(D3DKMDT_HVIDPNTOPOLOGY value) => (ushort)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(uint value) => new D3DKMDT_HVIDPNTOPOLOGY((void*)(value));

        public static explicit operator uint(D3DKMDT_HVIDPNTOPOLOGY value) => (uint)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(ulong value) => new D3DKMDT_HVIDPNTOPOLOGY((void*)(value));

        public static explicit operator ulong(D3DKMDT_HVIDPNTOPOLOGY value) => (ulong)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(nuint value) => new D3DKMDT_HVIDPNTOPOLOGY((void*)(value));

        public static implicit operator nuint(D3DKMDT_HVIDPNTOPOLOGY value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is D3DKMDT_HVIDPNTOPOLOGY other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of D3DKMDT_HVIDPNTOPOLOGY.");
        }

        public int CompareTo(D3DKMDT_HVIDPNTOPOLOGY other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDPNTOPOLOGY other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDPNTOPOLOGY other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
