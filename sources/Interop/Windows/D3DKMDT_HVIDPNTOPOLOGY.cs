// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HVIDPNTOPOLOGY : IEquatable<D3DKMDT_HVIDPNTOPOLOGY>
    {
        public readonly nint Value;

        public static D3DKMDT_HVIDPNTOPOLOGY NULL => (D3DKMDT_HVIDPNTOPOLOGY)(0);

        public D3DKMDT_HVIDPNTOPOLOGY(int value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNTOPOLOGY(uint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNTOPOLOGY(nint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNTOPOLOGY(nuint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNTOPOLOGY(void* value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNTOPOLOGY(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(D3DKMDT_HVIDPNTOPOLOGY left, D3DKMDT_HVIDPNTOPOLOGY right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDPNTOPOLOGY left, D3DKMDT_HVIDPNTOPOLOGY right) => left.Value != right.Value;

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(int value) => new D3DKMDT_HVIDPNTOPOLOGY(value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(uint value) => new D3DKMDT_HVIDPNTOPOLOGY(value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(nint value) => new D3DKMDT_HVIDPNTOPOLOGY(value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(nuint value) => new D3DKMDT_HVIDPNTOPOLOGY(value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(void* value) => new D3DKMDT_HVIDPNTOPOLOGY(value);

        public static explicit operator D3DKMDT_HVIDPNTOPOLOGY(HANDLE value) => new D3DKMDT_HVIDPNTOPOLOGY(value);

        public static implicit operator int(D3DKMDT_HVIDPNTOPOLOGY value) => (int)(value.Value);

        public static implicit operator uint(D3DKMDT_HVIDPNTOPOLOGY value) => (uint)(value.Value);

        public static implicit operator nint(D3DKMDT_HVIDPNTOPOLOGY value) => (nint)(value.Value);

        public static implicit operator nuint(D3DKMDT_HVIDPNTOPOLOGY value) => (nuint)(value.Value);

        public static implicit operator void*(D3DKMDT_HVIDPNTOPOLOGY value) => (void*)(value.Value);

        public static implicit operator HANDLE(D3DKMDT_HVIDPNTOPOLOGY value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDPNTOPOLOGY other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDPNTOPOLOGY other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
