// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HVIDEOPRESENTSOURCESET : IEquatable<D3DKMDT_HVIDEOPRESENTSOURCESET>
    {
        public readonly nint Value;

        public D3DKMDT_HVIDEOPRESENTSOURCESET(int value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDEOPRESENTSOURCESET(uint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDEOPRESENTSOURCESET(nint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDEOPRESENTSOURCESET(nuint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDEOPRESENTSOURCESET(void* value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDEOPRESENTSOURCESET(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(D3DKMDT_HVIDEOPRESENTSOURCESET left, D3DKMDT_HVIDEOPRESENTSOURCESET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDEOPRESENTSOURCESET left, D3DKMDT_HVIDEOPRESENTSOURCESET right) => left.Value != right.Value;

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(int value) => new D3DKMDT_HVIDEOPRESENTSOURCESET(value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(uint value) => new D3DKMDT_HVIDEOPRESENTSOURCESET(value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(nint value) => new D3DKMDT_HVIDEOPRESENTSOURCESET(value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(nuint value) => new D3DKMDT_HVIDEOPRESENTSOURCESET(value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(void* value) => new D3DKMDT_HVIDEOPRESENTSOURCESET(value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTSOURCESET(HANDLE value) => new D3DKMDT_HVIDEOPRESENTSOURCESET(value);

        public static implicit operator int(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (int)(value.Value);

        public static implicit operator uint(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (uint)(value.Value);

        public static implicit operator nint(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (nint)(value.Value);

        public static implicit operator nuint(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (nuint)(value.Value);

        public static implicit operator void*(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (void*)(value.Value);

        public static implicit operator HANDLE(D3DKMDT_HVIDEOPRESENTSOURCESET value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDEOPRESENTSOURCESET other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDEOPRESENTSOURCESET other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
