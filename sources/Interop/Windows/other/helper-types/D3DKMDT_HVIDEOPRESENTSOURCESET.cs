// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HVIDEOPRESENTSOURCESET : IEquatable<D3DKMDT_HVIDEOPRESENTSOURCESET>
    {
        public readonly nint Value;

        public D3DKMDT_HVIDEOPRESENTSOURCESET(nint value)
        {
            Value = value;
        }

        public static D3DKMDT_HVIDEOPRESENTSOURCESET INVALID_HANDLE_VALUE => new D3DKMDT_HVIDEOPRESENTSOURCESET(-1);

        public static D3DKMDT_HVIDEOPRESENTSOURCESET NULL => new D3DKMDT_HVIDEOPRESENTSOURCESET(0);

        public static bool operator ==(D3DKMDT_HVIDEOPRESENTSOURCESET left, D3DKMDT_HVIDEOPRESENTSOURCESET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDEOPRESENTSOURCESET left, D3DKMDT_HVIDEOPRESENTSOURCESET right) => left.Value != right.Value;

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(void* value) => new D3DKMDT_HVIDEOPRESENTSOURCESET((nint)(value));

        public static implicit operator void*(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (void*)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(HANDLE value) => new D3DKMDT_HVIDEOPRESENTSOURCESET(value);

        public static implicit operator HANDLE(D3DKMDT_HVIDEOPRESENTSOURCESET value) => new D3DKMDT_HVIDEOPRESENTSOURCESET(value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(byte value) => new D3DKMDT_HVIDEOPRESENTSOURCESET((nint)(value));

        public static implicit operator byte(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (byte)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(short value) => new D3DKMDT_HVIDEOPRESENTSOURCESET((nint)(value));

        public static implicit operator short(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (short)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(int value) => new D3DKMDT_HVIDEOPRESENTSOURCESET((nint)(value));

        public static implicit operator int(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (int)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(long value) => new D3DKMDT_HVIDEOPRESENTSOURCESET((nint)(value));

        public static explicit operator long(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (long)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(nint value) => new D3DKMDT_HVIDEOPRESENTSOURCESET((nint)(value));

        public static implicit operator nint(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (nint)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(sbyte value) => new D3DKMDT_HVIDEOPRESENTSOURCESET((nint)(value));

        public static implicit operator sbyte(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (sbyte)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(ushort value) => new D3DKMDT_HVIDEOPRESENTSOURCESET((nint)(value));

        public static implicit operator ushort(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (ushort)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(uint value) => new D3DKMDT_HVIDEOPRESENTSOURCESET((nint)(value));

        public static implicit operator uint(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (uint)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(ulong value) => new D3DKMDT_HVIDEOPRESENTSOURCESET((nint)(value));

        public static explicit operator ulong(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (ulong)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(nuint value) => new D3DKMDT_HVIDEOPRESENTSOURCESET((nint)(value));

        public static explicit operator nuint(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDEOPRESENTSOURCESET other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDEOPRESENTSOURCESET other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
