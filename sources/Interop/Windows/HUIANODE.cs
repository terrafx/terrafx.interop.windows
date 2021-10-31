// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HUIANODE : IEquatable<HUIANODE>
    {
        public readonly nint Value;

        public HUIANODE(int value)
        {
            Value = ((nint)(value));
        }

        public HUIANODE(uint value)
        {
            Value = ((nint)(value));
        }

        public HUIANODE(nint value)
        {
            Value = ((nint)(value));
        }

        public HUIANODE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HUIANODE(void* value)
        {
            Value = ((nint)(value));
        }

        public HUIANODE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HUIANODE left, HUIANODE right) => left.Value == right.Value;

        public static bool operator !=(HUIANODE left, HUIANODE right) => left.Value != right.Value;

        public static explicit operator HUIANODE(int value) => new HUIANODE(value);

        public static explicit operator HUIANODE(uint value) => new HUIANODE(value);

        public static explicit operator HUIANODE(nint value) => new HUIANODE(value);

        public static explicit operator HUIANODE(nuint value) => new HUIANODE(value);

        public static explicit operator HUIANODE(void* value) => new HUIANODE(value);

        public static explicit operator HUIANODE(HANDLE value) => new HUIANODE(value);

        public static implicit operator int(HUIANODE value) => (int)(value.Value);

        public static implicit operator uint(HUIANODE value) => (uint)(value.Value);

        public static implicit operator nint(HUIANODE value) => (nint)(value.Value);

        public static implicit operator nuint(HUIANODE value) => (nuint)(value.Value);

        public static implicit operator void*(HUIANODE value) => (void*)(value.Value);

        public static implicit operator HANDLE(HUIANODE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HUIANODE other) && Equals(other);

        public bool Equals(HUIANODE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
