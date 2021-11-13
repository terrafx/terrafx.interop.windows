// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct D3DKMDT_HVIDPNSOURCEMODESET : IComparable, IComparable<D3DKMDT_HVIDPNSOURCEMODESET>, IEquatable<D3DKMDT_HVIDPNSOURCEMODESET>, IFormattable
    {
        public readonly void* Value;

        public D3DKMDT_HVIDPNSOURCEMODESET(void* value)
        {
            Value = value;
        }

        public static D3DKMDT_HVIDPNSOURCEMODESET INVALID_VALUE => new D3DKMDT_HVIDPNSOURCEMODESET((void*)(-1));

        public static D3DKMDT_HVIDPNSOURCEMODESET NULL => new D3DKMDT_HVIDPNSOURCEMODESET(null);

        public static bool operator ==(D3DKMDT_HVIDPNSOURCEMODESET left, D3DKMDT_HVIDPNSOURCEMODESET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDPNSOURCEMODESET left, D3DKMDT_HVIDPNSOURCEMODESET right) => left.Value != right.Value;

        public static bool operator <(D3DKMDT_HVIDPNSOURCEMODESET left, D3DKMDT_HVIDPNSOURCEMODESET right) => left.Value < right.Value;

        public static bool operator <=(D3DKMDT_HVIDPNSOURCEMODESET left, D3DKMDT_HVIDPNSOURCEMODESET right) => left.Value <= right.Value;

        public static bool operator >(D3DKMDT_HVIDPNSOURCEMODESET left, D3DKMDT_HVIDPNSOURCEMODESET right) => left.Value > right.Value;

        public static bool operator >=(D3DKMDT_HVIDPNSOURCEMODESET left, D3DKMDT_HVIDPNSOURCEMODESET right) => left.Value >= right.Value;

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(void* value) => new D3DKMDT_HVIDPNSOURCEMODESET(value);

        public static implicit operator void*(D3DKMDT_HVIDPNSOURCEMODESET value) => value.Value;

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(HANDLE value) => new D3DKMDT_HVIDPNSOURCEMODESET(value);

        public static implicit operator HANDLE(D3DKMDT_HVIDPNSOURCEMODESET value) => new HANDLE(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(byte value) => new D3DKMDT_HVIDPNSOURCEMODESET((void*)(value));

        public static explicit operator byte(D3DKMDT_HVIDPNSOURCEMODESET value) => (byte)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(short value) => new D3DKMDT_HVIDPNSOURCEMODESET((void*)(value));

        public static explicit operator short(D3DKMDT_HVIDPNSOURCEMODESET value) => (short)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(int value) => new D3DKMDT_HVIDPNSOURCEMODESET((void*)(value));

        public static explicit operator int(D3DKMDT_HVIDPNSOURCEMODESET value) => (int)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(long value) => new D3DKMDT_HVIDPNSOURCEMODESET((void*)(value));

        public static explicit operator long(D3DKMDT_HVIDPNSOURCEMODESET value) => (long)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(nint value) => new D3DKMDT_HVIDPNSOURCEMODESET((void*)(value));

        public static implicit operator nint(D3DKMDT_HVIDPNSOURCEMODESET value) => (nint)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(sbyte value) => new D3DKMDT_HVIDPNSOURCEMODESET((void*)(value));

        public static explicit operator sbyte(D3DKMDT_HVIDPNSOURCEMODESET value) => (sbyte)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(ushort value) => new D3DKMDT_HVIDPNSOURCEMODESET((void*)(value));

        public static explicit operator ushort(D3DKMDT_HVIDPNSOURCEMODESET value) => (ushort)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(uint value) => new D3DKMDT_HVIDPNSOURCEMODESET((void*)(value));

        public static explicit operator uint(D3DKMDT_HVIDPNSOURCEMODESET value) => (uint)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(ulong value) => new D3DKMDT_HVIDPNSOURCEMODESET((void*)(value));

        public static explicit operator ulong(D3DKMDT_HVIDPNSOURCEMODESET value) => (ulong)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(nuint value) => new D3DKMDT_HVIDPNSOURCEMODESET((void*)(value));

        public static implicit operator nuint(D3DKMDT_HVIDPNSOURCEMODESET value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is D3DKMDT_HVIDPNSOURCEMODESET other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of D3DKMDT_HVIDPNSOURCEMODESET.");
        }

        public int CompareTo(D3DKMDT_HVIDPNSOURCEMODESET other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDPNSOURCEMODESET other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDPNSOURCEMODESET other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
