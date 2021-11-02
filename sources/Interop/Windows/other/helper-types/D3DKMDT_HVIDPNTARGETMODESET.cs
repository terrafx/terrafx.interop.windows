// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HVIDPNTARGETMODESET : IEquatable<D3DKMDT_HVIDPNTARGETMODESET>
    {
        public readonly nint Value;

        public D3DKMDT_HVIDPNTARGETMODESET(nint value)
        {
            Value = value;
        }

        public static D3DKMDT_HVIDPNTARGETMODESET INVALID_VALUE => new D3DKMDT_HVIDPNTARGETMODESET(-1);

        public static D3DKMDT_HVIDPNTARGETMODESET NULL => new D3DKMDT_HVIDPNTARGETMODESET(0);

        public static bool operator ==(D3DKMDT_HVIDPNTARGETMODESET left, D3DKMDT_HVIDPNTARGETMODESET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDPNTARGETMODESET left, D3DKMDT_HVIDPNTARGETMODESET right) => left.Value != right.Value;

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(void* value) => new D3DKMDT_HVIDPNTARGETMODESET((nint)(value));

        public static implicit operator void*(D3DKMDT_HVIDPNTARGETMODESET value) => (void*)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(HANDLE value) => new D3DKMDT_HVIDPNTARGETMODESET(value);

        public static implicit operator HANDLE(D3DKMDT_HVIDPNTARGETMODESET value) => new D3DKMDT_HVIDPNTARGETMODESET(value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(byte value) => new D3DKMDT_HVIDPNTARGETMODESET((nint)(value));

        public static explicit operator byte(D3DKMDT_HVIDPNTARGETMODESET value) => (byte)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(short value) => new D3DKMDT_HVIDPNTARGETMODESET((nint)(value));

        public static explicit operator short(D3DKMDT_HVIDPNTARGETMODESET value) => (short)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(int value) => new D3DKMDT_HVIDPNTARGETMODESET((nint)(value));

        public static explicit operator int(D3DKMDT_HVIDPNTARGETMODESET value) => (int)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(long value) => new D3DKMDT_HVIDPNTARGETMODESET((nint)(value));

        public static implicit operator long(D3DKMDT_HVIDPNTARGETMODESET value) => (long)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(nint value) => new D3DKMDT_HVIDPNTARGETMODESET((nint)(value));

        public static implicit operator nint(D3DKMDT_HVIDPNTARGETMODESET value) => (nint)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(sbyte value) => new D3DKMDT_HVIDPNTARGETMODESET((nint)(value));

        public static explicit operator sbyte(D3DKMDT_HVIDPNTARGETMODESET value) => (sbyte)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(ushort value) => new D3DKMDT_HVIDPNTARGETMODESET((nint)(value));

        public static explicit operator ushort(D3DKMDT_HVIDPNTARGETMODESET value) => (ushort)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(uint value) => new D3DKMDT_HVIDPNTARGETMODESET((nint)(value));

        public static explicit operator uint(D3DKMDT_HVIDPNTARGETMODESET value) => (uint)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(ulong value) => new D3DKMDT_HVIDPNTARGETMODESET((nint)(value));

        public static implicit operator ulong(D3DKMDT_HVIDPNTARGETMODESET value) => (ulong)(value.Value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(nuint value) => new D3DKMDT_HVIDPNTARGETMODESET((nint)(value));

        public static explicit operator nuint(D3DKMDT_HVIDPNTARGETMODESET value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDPNTARGETMODESET other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDPNTARGETMODESET other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
