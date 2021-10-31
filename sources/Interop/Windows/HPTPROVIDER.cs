// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPTPROVIDER : IEquatable<HPTPROVIDER>
    {
        public readonly nint Value;

        public static HPTPROVIDER NULL => (HPTPROVIDER)(0);

        public HPTPROVIDER(int value)
        {
            Value = ((nint)(value));
        }

        public HPTPROVIDER(uint value)
        {
            Value = ((nint)(value));
        }

        public HPTPROVIDER(nint value)
        {
            Value = ((nint)(value));
        }

        public HPTPROVIDER(nuint value)
        {
            Value = ((nint)(value));
        }

        public HPTPROVIDER(void* value)
        {
            Value = ((nint)(value));
        }

        public HPTPROVIDER(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HPTPROVIDER left, HPTPROVIDER right) => left.Value == right.Value;

        public static bool operator !=(HPTPROVIDER left, HPTPROVIDER right) => left.Value != right.Value;

        public static explicit operator HPTPROVIDER(int value) => new HPTPROVIDER(value);

        public static explicit operator HPTPROVIDER(uint value) => new HPTPROVIDER(value);

        public static explicit operator HPTPROVIDER(nint value) => new HPTPROVIDER(value);

        public static explicit operator HPTPROVIDER(nuint value) => new HPTPROVIDER(value);

        public static explicit operator HPTPROVIDER(void* value) => new HPTPROVIDER(value);

        public static explicit operator HPTPROVIDER(HANDLE value) => new HPTPROVIDER(value);

        public static explicit operator int(HPTPROVIDER value) => (int)(value.Value);

        public static explicit operator uint(HPTPROVIDER value) => (uint)(value.Value);

        public static implicit operator nint(HPTPROVIDER value) => (nint)(value.Value);

        public static implicit operator nuint(HPTPROVIDER value) => (nuint)(value.Value);

        public static implicit operator void*(HPTPROVIDER value) => (void*)(value.Value);

        public static implicit operator HANDLE(HPTPROVIDER value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HPTPROVIDER other) && Equals(other);

        public bool Equals(HPTPROVIDER other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
