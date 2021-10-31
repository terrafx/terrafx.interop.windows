// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMODULE : IEquatable<HMODULE>
    {
        public readonly nint Value;

        public static HMODULE NULL => (HMODULE)(0);

        public HMODULE(int value)
        {
            Value = ((nint)(value));
        }

        public HMODULE(uint value)
        {
            Value = ((nint)(value));
        }

        public HMODULE(nint value)
        {
            Value = ((nint)(value));
        }

        public HMODULE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HMODULE(void* value)
        {
            Value = ((nint)(value));
        }

        public HMODULE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HMODULE left, HMODULE right) => left.Value == right.Value;

        public static bool operator !=(HMODULE left, HMODULE right) => left.Value != right.Value;

        public static explicit operator HMODULE(int value) => new HMODULE(value);

        public static explicit operator HMODULE(uint value) => new HMODULE(value);

        public static explicit operator HMODULE(nint value) => new HMODULE(value);

        public static explicit operator HMODULE(nuint value) => new HMODULE(value);

        public static explicit operator HMODULE(void* value) => new HMODULE(value);

        public static explicit operator HMODULE(HANDLE value) => new HMODULE(value);

        public static explicit operator int(HMODULE value) => (int)(value.Value);

        public static explicit operator uint(HMODULE value) => (uint)(value.Value);

        public static implicit operator nint(HMODULE value) => (nint)(value.Value);

        public static implicit operator nuint(HMODULE value) => (nuint)(value.Value);

        public static implicit operator void*(HMODULE value) => (void*)(value.Value);

        public static implicit operator HANDLE(HMODULE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HMODULE other) && Equals(other);

        public bool Equals(HMODULE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
