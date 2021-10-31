// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HVIDPNTARGETMODESET : IEquatable<D3DKMDT_HVIDPNTARGETMODESET>
    {
        public readonly nint Value;

        public static D3DKMDT_HVIDPNTARGETMODESET NULL => (D3DKMDT_HVIDPNTARGETMODESET)(0);

        public D3DKMDT_HVIDPNTARGETMODESET(int value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNTARGETMODESET(uint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNTARGETMODESET(nint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNTARGETMODESET(nuint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNTARGETMODESET(void* value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDPNTARGETMODESET(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(D3DKMDT_HVIDPNTARGETMODESET left, D3DKMDT_HVIDPNTARGETMODESET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDPNTARGETMODESET left, D3DKMDT_HVIDPNTARGETMODESET right) => left.Value != right.Value;

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(int value) => new D3DKMDT_HVIDPNTARGETMODESET(value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(uint value) => new D3DKMDT_HVIDPNTARGETMODESET(value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(nint value) => new D3DKMDT_HVIDPNTARGETMODESET(value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(nuint value) => new D3DKMDT_HVIDPNTARGETMODESET(value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(void* value) => new D3DKMDT_HVIDPNTARGETMODESET(value);

        public static explicit operator D3DKMDT_HVIDPNTARGETMODESET(HANDLE value) => new D3DKMDT_HVIDPNTARGETMODESET(value);

        public static implicit operator int(D3DKMDT_HVIDPNTARGETMODESET value) => (int)(value.Value);

        public static implicit operator uint(D3DKMDT_HVIDPNTARGETMODESET value) => (uint)(value.Value);

        public static implicit operator nint(D3DKMDT_HVIDPNTARGETMODESET value) => (nint)(value.Value);

        public static implicit operator nuint(D3DKMDT_HVIDPNTARGETMODESET value) => (nuint)(value.Value);

        public static implicit operator void*(D3DKMDT_HVIDPNTARGETMODESET value) => (void*)(value.Value);

        public static implicit operator HANDLE(D3DKMDT_HVIDPNTARGETMODESET value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDPNTARGETMODESET other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDPNTARGETMODESET other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
