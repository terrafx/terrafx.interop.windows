// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HAMSISESSION : IEquatable<HAMSISESSION>
    {
        public readonly nint Value;

        public static HAMSISESSION NULL => (HAMSISESSION)(0);

        public HAMSISESSION(int value)
        {
            Value = ((nint)(value));
        }

        public HAMSISESSION(uint value)
        {
            Value = ((nint)(value));
        }

        public HAMSISESSION(nint value)
        {
            Value = ((nint)(value));
        }

        public HAMSISESSION(nuint value)
        {
            Value = ((nint)(value));
        }

        public HAMSISESSION(void* value)
        {
            Value = ((nint)(value));
        }

        public HAMSISESSION(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HAMSISESSION left, HAMSISESSION right) => left.Value == right.Value;

        public static bool operator !=(HAMSISESSION left, HAMSISESSION right) => left.Value != right.Value;

        public static explicit operator HAMSISESSION(int value) => new HAMSISESSION(value);

        public static explicit operator HAMSISESSION(uint value) => new HAMSISESSION(value);

        public static explicit operator HAMSISESSION(nint value) => new HAMSISESSION(value);

        public static explicit operator HAMSISESSION(nuint value) => new HAMSISESSION(value);

        public static explicit operator HAMSISESSION(void* value) => new HAMSISESSION(value);

        public static explicit operator HAMSISESSION(HANDLE value) => new HAMSISESSION(value);

        public static implicit operator int(HAMSISESSION value) => (int)(value.Value);

        public static implicit operator uint(HAMSISESSION value) => (uint)(value.Value);

        public static implicit operator nint(HAMSISESSION value) => (nint)(value.Value);

        public static implicit operator nuint(HAMSISESSION value) => (nuint)(value.Value);

        public static implicit operator void*(HAMSISESSION value) => (void*)(value.Value);

        public static implicit operator HANDLE(HAMSISESSION value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HAMSISESSION other) && Equals(other);

        public bool Equals(HAMSISESSION other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
