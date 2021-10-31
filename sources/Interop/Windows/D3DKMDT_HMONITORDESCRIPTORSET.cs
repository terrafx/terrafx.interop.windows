// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HMONITORDESCRIPTORSET : IEquatable<D3DKMDT_HMONITORDESCRIPTORSET>
    {
        public readonly nint Value;

        public D3DKMDT_HMONITORDESCRIPTORSET(int value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORDESCRIPTORSET(uint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORDESCRIPTORSET(nint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORDESCRIPTORSET(nuint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORDESCRIPTORSET(void* value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORDESCRIPTORSET(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(D3DKMDT_HMONITORDESCRIPTORSET left, D3DKMDT_HMONITORDESCRIPTORSET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HMONITORDESCRIPTORSET left, D3DKMDT_HMONITORDESCRIPTORSET right) => left.Value != right.Value;

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(int value) => new D3DKMDT_HMONITORDESCRIPTORSET(value);

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(uint value) => new D3DKMDT_HMONITORDESCRIPTORSET(value);

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(nint value) => new D3DKMDT_HMONITORDESCRIPTORSET(value);

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(nuint value) => new D3DKMDT_HMONITORDESCRIPTORSET(value);

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(void* value) => new D3DKMDT_HMONITORDESCRIPTORSET(value);

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(HANDLE value) => new D3DKMDT_HMONITORDESCRIPTORSET(value);

        public static implicit operator int(D3DKMDT_HMONITORDESCRIPTORSET value) => (int)(value.Value);

        public static implicit operator uint(D3DKMDT_HMONITORDESCRIPTORSET value) => (uint)(value.Value);

        public static implicit operator nint(D3DKMDT_HMONITORDESCRIPTORSET value) => (nint)(value.Value);

        public static implicit operator nuint(D3DKMDT_HMONITORDESCRIPTORSET value) => (nuint)(value.Value);

        public static implicit operator void*(D3DKMDT_HMONITORDESCRIPTORSET value) => (void*)(value.Value);

        public static implicit operator HANDLE(D3DKMDT_HMONITORDESCRIPTORSET value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HMONITORDESCRIPTORSET other) && Equals(other);

        public bool Equals(D3DKMDT_HMONITORDESCRIPTORSET other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
