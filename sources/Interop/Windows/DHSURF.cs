// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct DHSURF : IEquatable<DHSURF>
    {
        public readonly nint Value;

        public static DHSURF NULL => (DHSURF)(0);

        public DHSURF(int value)
        {
            Value = ((nint)(value));
        }

        public DHSURF(uint value)
        {
            Value = ((nint)(value));
        }

        public DHSURF(nint value)
        {
            Value = ((nint)(value));
        }

        public DHSURF(nuint value)
        {
            Value = ((nint)(value));
        }

        public DHSURF(void* value)
        {
            Value = ((nint)(value));
        }

        public DHSURF(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(DHSURF left, DHSURF right) => left.Value == right.Value;

        public static bool operator !=(DHSURF left, DHSURF right) => left.Value != right.Value;

        public static explicit operator DHSURF(int value) => new DHSURF(value);

        public static explicit operator DHSURF(uint value) => new DHSURF(value);

        public static explicit operator DHSURF(nint value) => new DHSURF(value);

        public static explicit operator DHSURF(nuint value) => new DHSURF(value);

        public static explicit operator DHSURF(void* value) => new DHSURF(value);

        public static explicit operator DHSURF(HANDLE value) => new DHSURF(value);

        public static explicit operator int(DHSURF value) => (int)(value.Value);

        public static explicit operator uint(DHSURF value) => (uint)(value.Value);

        public static implicit operator nint(DHSURF value) => (nint)(value.Value);

        public static implicit operator nuint(DHSURF value) => (nuint)(value.Value);

        public static implicit operator void*(DHSURF value) => (void*)(value.Value);

        public static implicit operator HANDLE(DHSURF value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is DHSURF other) && Equals(other);

        public bool Equals(DHSURF other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
