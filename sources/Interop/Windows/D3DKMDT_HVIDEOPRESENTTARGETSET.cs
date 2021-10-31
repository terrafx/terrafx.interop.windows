// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HVIDEOPRESENTTARGETSET : IEquatable<D3DKMDT_HVIDEOPRESENTTARGETSET>
    {
        public readonly nint Value;

        public D3DKMDT_HVIDEOPRESENTTARGETSET(int value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDEOPRESENTTARGETSET(uint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDEOPRESENTTARGETSET(nint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDEOPRESENTTARGETSET(nuint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDEOPRESENTTARGETSET(void* value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HVIDEOPRESENTTARGETSET(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(D3DKMDT_HVIDEOPRESENTTARGETSET left, D3DKMDT_HVIDEOPRESENTTARGETSET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDEOPRESENTTARGETSET left, D3DKMDT_HVIDEOPRESENTTARGETSET right) => left.Value != right.Value;

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(int value) => new D3DKMDT_HVIDEOPRESENTTARGETSET(value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(uint value) => new D3DKMDT_HVIDEOPRESENTTARGETSET(value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(nint value) => new D3DKMDT_HVIDEOPRESENTTARGETSET(value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(nuint value) => new D3DKMDT_HVIDEOPRESENTTARGETSET(value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(void* value) => new D3DKMDT_HVIDEOPRESENTTARGETSET(value);

        public static explicit operator D3DKMDT_HVIDEOPRESENTTARGETSET(HANDLE value) => new D3DKMDT_HVIDEOPRESENTTARGETSET(value);

        public static implicit operator int(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (int)(value.Value);

        public static implicit operator uint(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (uint)(value.Value);

        public static implicit operator nint(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (nint)(value.Value);

        public static implicit operator nuint(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (nuint)(value.Value);

        public static implicit operator void*(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (void*)(value.Value);

        public static implicit operator HANDLE(D3DKMDT_HVIDEOPRESENTTARGETSET value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDEOPRESENTTARGETSET other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDEOPRESENTTARGETSET other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
