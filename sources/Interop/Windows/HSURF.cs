// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSURF : IEquatable<HSURF>
    {
        public readonly nint Value;

        public static HSURF NULL => (HSURF)(0);

        public HSURF(int value)
        {
            Value = ((nint)(value));
        }

        public HSURF(uint value)
        {
            Value = ((nint)(value));
        }

        public HSURF(nint value)
        {
            Value = ((nint)(value));
        }

        public HSURF(nuint value)
        {
            Value = ((nint)(value));
        }

        public HSURF(void* value)
        {
            Value = ((nint)(value));
        }

        public HSURF(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HSURF left, HSURF right) => left.Value == right.Value;

        public static bool operator !=(HSURF left, HSURF right) => left.Value != right.Value;

        public static explicit operator HSURF(int value) => new HSURF(value);

        public static explicit operator HSURF(uint value) => new HSURF(value);

        public static explicit operator HSURF(nint value) => new HSURF(value);

        public static explicit operator HSURF(nuint value) => new HSURF(value);

        public static explicit operator HSURF(void* value) => new HSURF(value);

        public static explicit operator HSURF(HANDLE value) => new HSURF(value);

        public static explicit operator int(HSURF value) => (int)(value.Value);

        public static explicit operator uint(HSURF value) => (uint)(value.Value);

        public static implicit operator nint(HSURF value) => (nint)(value.Value);

        public static implicit operator nuint(HSURF value) => (nuint)(value.Value);

        public static implicit operator void*(HSURF value) => (void*)(value.Value);

        public static implicit operator HANDLE(HSURF value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HSURF other) && Equals(other);

        public bool Equals(HSURF other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
