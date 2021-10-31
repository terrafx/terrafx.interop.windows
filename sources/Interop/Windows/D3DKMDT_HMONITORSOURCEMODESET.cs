// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HMONITORSOURCEMODESET : IEquatable<D3DKMDT_HMONITORSOURCEMODESET>
    {
        public readonly nint Value;

        public static D3DKMDT_HMONITORSOURCEMODESET NULL => (D3DKMDT_HMONITORSOURCEMODESET)(0);

        public D3DKMDT_HMONITORSOURCEMODESET(int value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORSOURCEMODESET(uint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORSOURCEMODESET(nint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORSOURCEMODESET(nuint value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORSOURCEMODESET(void* value)
        {
            Value = ((nint)(value));
        }

        public D3DKMDT_HMONITORSOURCEMODESET(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(D3DKMDT_HMONITORSOURCEMODESET left, D3DKMDT_HMONITORSOURCEMODESET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HMONITORSOURCEMODESET left, D3DKMDT_HMONITORSOURCEMODESET right) => left.Value != right.Value;

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(int value) => new D3DKMDT_HMONITORSOURCEMODESET(value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(uint value) => new D3DKMDT_HMONITORSOURCEMODESET(value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(nint value) => new D3DKMDT_HMONITORSOURCEMODESET(value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(nuint value) => new D3DKMDT_HMONITORSOURCEMODESET(value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(void* value) => new D3DKMDT_HMONITORSOURCEMODESET(value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(HANDLE value) => new D3DKMDT_HMONITORSOURCEMODESET(value);

        public static implicit operator int(D3DKMDT_HMONITORSOURCEMODESET value) => (int)(value.Value);

        public static implicit operator uint(D3DKMDT_HMONITORSOURCEMODESET value) => (uint)(value.Value);

        public static implicit operator nint(D3DKMDT_HMONITORSOURCEMODESET value) => (nint)(value.Value);

        public static implicit operator nuint(D3DKMDT_HMONITORSOURCEMODESET value) => (nuint)(value.Value);

        public static implicit operator void*(D3DKMDT_HMONITORSOURCEMODESET value) => (void*)(value.Value);

        public static implicit operator HANDLE(D3DKMDT_HMONITORSOURCEMODESET value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HMONITORSOURCEMODESET other) && Equals(other);

        public bool Equals(D3DKMDT_HMONITORSOURCEMODESET other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
