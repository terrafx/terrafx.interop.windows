// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HVIDPNSOURCEMODESET : IEquatable<D3DKMDT_HVIDPNSOURCEMODESET>
    {
        public readonly nint Value;

        public static D3DKMDT_HVIDPNSOURCEMODESET NULL => (D3DKMDT_HVIDPNSOURCEMODESET)(0);

        public D3DKMDT_HVIDPNSOURCEMODESET(int value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNSOURCEMODESET(uint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNSOURCEMODESET(nint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNSOURCEMODESET(nuint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNSOURCEMODESET(void* value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNSOURCEMODESET(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(D3DKMDT_HVIDPNSOURCEMODESET left, D3DKMDT_HVIDPNSOURCEMODESET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDPNSOURCEMODESET left, D3DKMDT_HVIDPNSOURCEMODESET right) => left.Value != right.Value;

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(int value) => new D3DKMDT_HVIDPNSOURCEMODESET(value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(uint value) => new D3DKMDT_HVIDPNSOURCEMODESET(value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(nint value) => new D3DKMDT_HVIDPNSOURCEMODESET(value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(nuint value) => new D3DKMDT_HVIDPNSOURCEMODESET(value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(void* value) => new D3DKMDT_HVIDPNSOURCEMODESET(value);

        public static explicit operator D3DKMDT_HVIDPNSOURCEMODESET(HANDLE value) => new D3DKMDT_HVIDPNSOURCEMODESET(value);

        public static implicit operator int(D3DKMDT_HVIDPNSOURCEMODESET value) => (int)(value.Value);

        public static implicit operator uint(D3DKMDT_HVIDPNSOURCEMODESET value) => (uint)(value.Value);

        public static implicit operator nint(D3DKMDT_HVIDPNSOURCEMODESET value) => (nint)(value.Value);

        public static implicit operator nuint(D3DKMDT_HVIDPNSOURCEMODESET value) => (nuint)(value.Value);

        public static implicit operator void*(D3DKMDT_HVIDPNSOURCEMODESET value) => (void*)(value.Value);

        public static implicit operator HANDLE(D3DKMDT_HVIDPNSOURCEMODESET value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDPNSOURCEMODESET other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDPNSOURCEMODESET other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
