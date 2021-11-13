// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct D3DKMDT_HVIDEOPRESENTTARGETSET : IComparable, IComparable<D3DKMDT_HVIDEOPRESENTTARGETSET>, IEquatable<D3DKMDT_HVIDEOPRESENTTARGETSET>, IFormattable
    {
        public readonly void* Value;

        public D3DKMDT_HVIDEOPRESENTTARGETSET(void* value)
        {
            Value = value;
        }

        public static D3DKMDT_HVIDEOPRESENTTARGETSET INVALID_VALUE => new D3DKMDT_HVIDEOPRESENTTARGETSET((void*)(-1));

        public static D3DKMDT_HVIDEOPRESENTTARGETSET NULL => new D3DKMDT_HVIDEOPRESENTTARGETSET(null);

        public static bool operator ==(D3DKMDT_HVIDEOPRESENTTARGETSET left, D3DKMDT_HVIDEOPRESENTTARGETSET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDEOPRESENTTARGETSET left, D3DKMDT_HVIDEOPRESENTTARGETSET right) => left.Value != right.Value;

        public static bool operator <(D3DKMDT_HVIDEOPRESENTTARGETSET left, D3DKMDT_HVIDEOPRESENTTARGETSET right) => left.Value < right.Value;

        public static bool operator <=(D3DKMDT_HVIDEOPRESENTTARGETSET left, D3DKMDT_HVIDEOPRESENTTARGETSET right) => left.Value <= right.Value;

        public static bool operator >(D3DKMDT_HVIDEOPRESENTTARGETSET left, D3DKMDT_HVIDEOPRESENTTARGETSET right) => left.Value > right.Value;

        public static bool operator >=(D3DKMDT_HVIDEOPRESENTTARGETSET left, D3DKMDT_HVIDEOPRESENTTARGETSET right) => left.Value >= right.Value;

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(void* value) => new D3DKMDT_HVIDEOPRESENTTARGETSET(value);

        public static implicit operator void*(D3DKMDT_HVIDEOPRESENTTARGETSET value) => value.Value;

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(HANDLE value) => new D3DKMDT_HVIDEOPRESENTTARGETSET(value);

        public static implicit operator HANDLE(D3DKMDT_HVIDEOPRESENTTARGETSET value) => new HANDLE(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(byte value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((void*)(value));

        public static explicit operator byte(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (byte)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(short value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((void*)(value));

        public static explicit operator short(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (short)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(int value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((void*)(value));

        public static explicit operator int(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (int)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(long value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((void*)(value));

        public static explicit operator long(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (long)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(nint value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((void*)(value));

        public static implicit operator nint(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (nint)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(sbyte value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((void*)(value));

        public static explicit operator sbyte(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (sbyte)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(ushort value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((void*)(value));

        public static explicit operator ushort(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (ushort)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(uint value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((void*)(value));

        public static explicit operator uint(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (uint)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(ulong value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((void*)(value));

        public static explicit operator ulong(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (ulong)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(nuint value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((void*)(value));

        public static implicit operator nuint(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is D3DKMDT_HVIDEOPRESENTTARGETSET other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of D3DKMDT_HVIDEOPRESENTTARGETSET.");
        }

        public int CompareTo(D3DKMDT_HVIDEOPRESENTTARGETSET other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDEOPRESENTTARGETSET other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDEOPRESENTTARGETSET other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
