// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HVIDPNSOURCEMODESET : IEquatable<D3DKMDT_HVIDPNSOURCEMODESET>
    {
        public readonly nint Value;

        public D3DKMDT_HVIDPNSOURCEMODESET(nint value)
        {
            Value = value;
        }

        public static D3DKMDT_HVIDPNSOURCEMODESET INVALID_HANDLE_VALUE => new D3DKMDT_HVIDPNSOURCEMODESET(-1);

        public static D3DKMDT_HVIDPNSOURCEMODESET NULL => new D3DKMDT_HVIDPNSOURCEMODESET(0);

        public static bool operator ==(D3DKMDT_HVIDPNSOURCEMODESET left, D3DKMDT_HVIDPNSOURCEMODESET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDPNSOURCEMODESET left, D3DKMDT_HVIDPNSOURCEMODESET right) => left.Value != right.Value;

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(void* value) => new D3DKMDT_HVIDPNSOURCEMODESET((nint)(value));

        public static implicit operator void*(D3DKMDT_HVIDPNSOURCEMODESET value) => (void*)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(HANDLE value) => new D3DKMDT_HVIDPNSOURCEMODESET(value);

        public static implicit operator HANDLE(D3DKMDT_HVIDPNSOURCEMODESET value) => new D3DKMDT_HVIDPNSOURCEMODESET(value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(byte value) => new D3DKMDT_HVIDPNSOURCEMODESET((nint)(value));

        public static explicit operator byte(D3DKMDT_HVIDPNSOURCEMODESET value) => (byte)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(short value) => new D3DKMDT_HVIDPNSOURCEMODESET((nint)(value));

        public static explicit operator short(D3DKMDT_HVIDPNSOURCEMODESET value) => (short)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(int value) => new D3DKMDT_HVIDPNSOURCEMODESET((nint)(value));

        public static explicit operator int(D3DKMDT_HVIDPNSOURCEMODESET value) => (int)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(long value) => new D3DKMDT_HVIDPNSOURCEMODESET((nint)(value));

        public static implicit operator long(D3DKMDT_HVIDPNSOURCEMODESET value) => (long)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(nint value) => new D3DKMDT_HVIDPNSOURCEMODESET((nint)(value));

        public static implicit operator nint(D3DKMDT_HVIDPNSOURCEMODESET value) => (nint)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(sbyte value) => new D3DKMDT_HVIDPNSOURCEMODESET((nint)(value));

        public static explicit operator sbyte(D3DKMDT_HVIDPNSOURCEMODESET value) => (sbyte)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(ushort value) => new D3DKMDT_HVIDPNSOURCEMODESET((nint)(value));

        public static explicit operator ushort(D3DKMDT_HVIDPNSOURCEMODESET value) => (ushort)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(uint value) => new D3DKMDT_HVIDPNSOURCEMODESET((nint)(value));

        public static explicit operator uint(D3DKMDT_HVIDPNSOURCEMODESET value) => (uint)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(ulong value) => new D3DKMDT_HVIDPNSOURCEMODESET((nint)(value));

        public static implicit operator ulong(D3DKMDT_HVIDPNSOURCEMODESET value) => (ulong)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(nuint value) => new D3DKMDT_HVIDPNSOURCEMODESET((nint)(value));

        public static explicit operator nuint(D3DKMDT_HVIDPNSOURCEMODESET value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDPNSOURCEMODESET other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDPNSOURCEMODESET other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
