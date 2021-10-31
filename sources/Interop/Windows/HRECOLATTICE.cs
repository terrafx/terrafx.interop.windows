// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRECOLATTICE : IEquatable<HRECOLATTICE>
    {
        public readonly nint Value;

        public static HRECOLATTICE NULL => (HRECOLATTICE)(0);

        public HRECOLATTICE(int value)
        {
            Value = ((nint)(value));
        }

        public HRECOLATTICE(uint value)
        {
            Value = ((nint)(value));
        }

        public HRECOLATTICE(nint value)
        {
            Value = ((nint)(value));
        }

        public HRECOLATTICE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HRECOLATTICE(void* value)
        {
            Value = ((nint)(value));
        }

        public HRECOLATTICE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HRECOLATTICE left, HRECOLATTICE right) => left.Value == right.Value;

        public static bool operator !=(HRECOLATTICE left, HRECOLATTICE right) => left.Value != right.Value;

        public static explicit operator HRECOLATTICE(int value) => new HRECOLATTICE(value);

        public static explicit operator HRECOLATTICE(uint value) => new HRECOLATTICE(value);

        public static explicit operator HRECOLATTICE(nint value) => new HRECOLATTICE(value);

        public static explicit operator HRECOLATTICE(nuint value) => new HRECOLATTICE(value);

        public static explicit operator HRECOLATTICE(void* value) => new HRECOLATTICE(value);

        public static explicit operator HRECOLATTICE(HANDLE value) => new HRECOLATTICE(value);

        public static explicit operator int(HRECOLATTICE value) => (int)(value.Value);

        public static explicit operator uint(HRECOLATTICE value) => (uint)(value.Value);

        public static implicit operator nint(HRECOLATTICE value) => (nint)(value.Value);

        public static implicit operator nuint(HRECOLATTICE value) => (nuint)(value.Value);

        public static implicit operator void*(HRECOLATTICE value) => (void*)(value.Value);

        public static implicit operator HANDLE(HRECOLATTICE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HRECOLATTICE other) && Equals(other);

        public bool Equals(HRECOLATTICE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
