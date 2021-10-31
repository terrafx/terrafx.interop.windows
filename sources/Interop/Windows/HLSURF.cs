// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HLSURF : IEquatable<HLSURF>
    {
        public readonly nint Value;

        public static HLSURF NULL => (HLSURF)(0);

        public HLSURF(int value)
        {
            Value = ((nint)(value));
        }

        public HLSURF(uint value)
        {
            Value = ((nint)(value));
        }

        public HLSURF(nint value)
        {
            Value = ((nint)(value));
        }

        public HLSURF(nuint value)
        {
            Value = ((nint)(value));
        }

        public HLSURF(void* value)
        {
            Value = ((nint)(value));
        }

        public HLSURF(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HLSURF left, HLSURF right) => left.Value == right.Value;

        public static bool operator !=(HLSURF left, HLSURF right) => left.Value != right.Value;

        public static explicit operator HLSURF(int value) => new HLSURF(value);

        public static explicit operator HLSURF(uint value) => new HLSURF(value);

        public static explicit operator HLSURF(nint value) => new HLSURF(value);

        public static explicit operator HLSURF(nuint value) => new HLSURF(value);

        public static explicit operator HLSURF(void* value) => new HLSURF(value);

        public static explicit operator HLSURF(HANDLE value) => new HLSURF(value);

        public static explicit operator int(HLSURF value) => (int)(value.Value);

        public static explicit operator uint(HLSURF value) => (uint)(value.Value);

        public static implicit operator nint(HLSURF value) => (nint)(value.Value);

        public static implicit operator nuint(HLSURF value) => (nuint)(value.Value);

        public static implicit operator void*(HLSURF value) => (void*)(value.Value);

        public static implicit operator HANDLE(HLSURF value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HLSURF other) && Equals(other);

        public bool Equals(HLSURF other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
