// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HMONITORFREQUENCYRANGESET : IEquatable<D3DKMDT_HMONITORFREQUENCYRANGESET>
    {
        public readonly nint Value;

        public static D3DKMDT_HMONITORFREQUENCYRANGESET NULL => (D3DKMDT_HMONITORFREQUENCYRANGESET)(0);

        public D3DKMDT_HMONITORFREQUENCYRANGESET(int value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORFREQUENCYRANGESET(uint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORFREQUENCYRANGESET(nint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORFREQUENCYRANGESET(nuint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORFREQUENCYRANGESET(void* value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORFREQUENCYRANGESET(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(D3DKMDT_HMONITORFREQUENCYRANGESET left, D3DKMDT_HMONITORFREQUENCYRANGESET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HMONITORFREQUENCYRANGESET left, D3DKMDT_HMONITORFREQUENCYRANGESET right) => left.Value != right.Value;

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(int value) => new D3DKMDT_HMONITORFREQUENCYRANGESET(value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(uint value) => new D3DKMDT_HMONITORFREQUENCYRANGESET(value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(nint value) => new D3DKMDT_HMONITORFREQUENCYRANGESET(value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(nuint value) => new D3DKMDT_HMONITORFREQUENCYRANGESET(value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(void* value) => new D3DKMDT_HMONITORFREQUENCYRANGESET(value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(HANDLE value) => new D3DKMDT_HMONITORFREQUENCYRANGESET(value);

        public static implicit operator int(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (int)(value.Value);

        public static implicit operator uint(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (uint)(value.Value);

        public static implicit operator nint(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (nint)(value.Value);

        public static implicit operator nuint(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (nuint)(value.Value);

        public static implicit operator void*(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (void*)(value.Value);

        public static implicit operator HANDLE(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HMONITORFREQUENCYRANGESET other) && Equals(other);

        public bool Equals(D3DKMDT_HMONITORFREQUENCYRANGESET other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
