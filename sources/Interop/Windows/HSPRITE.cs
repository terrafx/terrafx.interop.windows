// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSPRITE : IEquatable<HSPRITE>
    {
        public readonly nint Value;

        public static HSPRITE NULL => (HSPRITE)(0);

        public HSPRITE(int value)
        {
            Value = ((nint)(value));
        }

        public HSPRITE(uint value)
        {
            Value = ((nint)(value));
        }

        public HSPRITE(nint value)
        {
            Value = ((nint)(value));
        }

        public HSPRITE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HSPRITE(void* value)
        {
            Value = ((nint)(value));
        }

        public HSPRITE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HSPRITE left, HSPRITE right) => left.Value == right.Value;

        public static bool operator !=(HSPRITE left, HSPRITE right) => left.Value != right.Value;

        public static explicit operator HSPRITE(int value) => new HSPRITE(value);

        public static explicit operator HSPRITE(uint value) => new HSPRITE(value);

        public static explicit operator HSPRITE(nint value) => new HSPRITE(value);

        public static explicit operator HSPRITE(nuint value) => new HSPRITE(value);

        public static explicit operator HSPRITE(void* value) => new HSPRITE(value);

        public static explicit operator HSPRITE(HANDLE value) => new HSPRITE(value);

        public static explicit operator int(HSPRITE value) => (int)(value.Value);

        public static explicit operator uint(HSPRITE value) => (uint)(value.Value);

        public static implicit operator nint(HSPRITE value) => (nint)(value.Value);

        public static implicit operator nuint(HSPRITE value) => (nuint)(value.Value);

        public static implicit operator void*(HSPRITE value) => (void*)(value.Value);

        public static implicit operator HANDLE(HSPRITE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HSPRITE other) && Equals(other);

        public bool Equals(HSPRITE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
