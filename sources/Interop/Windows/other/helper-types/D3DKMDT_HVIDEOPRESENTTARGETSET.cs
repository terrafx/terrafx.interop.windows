// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HVIDEOPRESENTTARGETSET : IEquatable<D3DKMDT_HVIDEOPRESENTTARGETSET>
    {
        public readonly nint Value;

        public D3DKMDT_HVIDEOPRESENTTARGETSET(nint value)
        {
            Value = value;
        }

        public static D3DKMDT_HVIDEOPRESENTTARGETSET INVALID_VALUE => new D3DKMDT_HVIDEOPRESENTTARGETSET(-1);

        public static D3DKMDT_HVIDEOPRESENTTARGETSET NULL => new D3DKMDT_HVIDEOPRESENTTARGETSET(0);

        public static bool operator ==(D3DKMDT_HVIDEOPRESENTTARGETSET left, D3DKMDT_HVIDEOPRESENTTARGETSET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDEOPRESENTTARGETSET left, D3DKMDT_HVIDEOPRESENTTARGETSET right) => left.Value != right.Value;

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(void* value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((nint)(value));

        public static implicit operator void*(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (void*)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(HANDLE value) => new D3DKMDT_HVIDEOPRESENTTARGETSET(value);

        public static implicit operator HANDLE(D3DKMDT_HVIDEOPRESENTTARGETSET value) => new HANDLE(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(byte value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((nint)(value));

        public static explicit operator byte(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (byte)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(short value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((nint)(value));

        public static explicit operator short(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (short)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(int value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((nint)(value));

        public static explicit operator int(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (int)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(long value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((nint)(value));

        public static implicit operator long(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (long)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(nint value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((nint)(value));

        public static implicit operator nint(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (nint)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(sbyte value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((nint)(value));

        public static explicit operator sbyte(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (sbyte)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(ushort value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((nint)(value));

        public static explicit operator ushort(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (ushort)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(uint value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((nint)(value));

        public static explicit operator uint(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (uint)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(ulong value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((nint)(value));

        public static explicit operator ulong(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (ulong)(value.Value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(nuint value) => new D3DKMDT_HVIDEOPRESENTTARGETSET((nint)(value));

        public static explicit operator nuint(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDEOPRESENTTARGETSET other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDEOPRESENTTARGETSET other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
