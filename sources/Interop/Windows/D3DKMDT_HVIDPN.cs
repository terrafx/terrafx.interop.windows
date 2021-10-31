// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HVIDPN : IEquatable<D3DKMDT_HVIDPN>
    {
        public readonly nint Value;

        public D3DKMDT_HVIDPN(int value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPN(uint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPN(nint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPN(nuint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPN(void* value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPN(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(D3DKMDT_HVIDPN left, D3DKMDT_HVIDPN right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDPN left, D3DKMDT_HVIDPN right) => left.Value != right.Value;

        public static explicit operator D3DKMDT_HVIDPN(int value) => new D3DKMDT_HVIDPN(value);

        public static explicit operator D3DKMDT_HVIDPN(uint value) => new D3DKMDT_HVIDPN(value);

        public static explicit operator D3DKMDT_HVIDPN(nint value) => new D3DKMDT_HVIDPN(value);

        public static explicit operator D3DKMDT_HVIDPN(nuint value) => new D3DKMDT_HVIDPN(value);

        public static explicit operator D3DKMDT_HVIDPN(void* value) => new D3DKMDT_HVIDPN(value);

        public static explicit operator D3DKMDT_HVIDPN(HANDLE value) => new D3DKMDT_HVIDPN(value);

        public static implicit operator int(D3DKMDT_HVIDPN value) => (int)(value.Value);

        public static implicit operator uint(D3DKMDT_HVIDPN value) => (uint)(value.Value);

        public static implicit operator nint(D3DKMDT_HVIDPN value) => (nint)(value.Value);

        public static implicit operator nuint(D3DKMDT_HVIDPN value) => (nuint)(value.Value);

        public static implicit operator void*(D3DKMDT_HVIDPN value) => (void*)(value.Value);

        public static implicit operator HANDLE(D3DKMDT_HVIDPN value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDPN other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDPN other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
