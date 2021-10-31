// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBRUSH : IEquatable<HBRUSH>
    {
        public readonly nint Value;

        public static HBRUSH NULL => (HBRUSH)(0);

        public HBRUSH(int value)
        {
            Value = ((nint)(value));
        }

        public HBRUSH(uint value)
        {
            Value = ((nint)(value));
        }

        public HBRUSH(nint value)
        {
            Value = ((nint)(value));
        }

        public HBRUSH(nuint value)
        {
            Value = ((nint)(value));
        }

        public HBRUSH(void* value)
        {
            Value = ((nint)(value));
        }

        public HBRUSH(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HBRUSH left, HBRUSH right) => left.Value == right.Value;

        public static bool operator !=(HBRUSH left, HBRUSH right) => left.Value != right.Value;

        public static explicit operator HBRUSH(int value) => new HBRUSH(value);

        public static explicit operator HBRUSH(uint value) => new HBRUSH(value);

        public static explicit operator HBRUSH(nint value) => new HBRUSH(value);

        public static explicit operator HBRUSH(nuint value) => new HBRUSH(value);

        public static explicit operator HBRUSH(void* value) => new HBRUSH(value);

        public static explicit operator HBRUSH(HANDLE value) => new HBRUSH(value);

        public static implicit operator int(HBRUSH value) => (int)(value.Value);

        public static implicit operator uint(HBRUSH value) => (uint)(value.Value);

        public static implicit operator nint(HBRUSH value) => (nint)(value.Value);

        public static implicit operator nuint(HBRUSH value) => (nuint)(value.Value);

        public static implicit operator void*(HBRUSH value) => (void*)(value.Value);

        public static implicit operator HANDLE(HBRUSH value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HBRUSH other) && Equals(other);

        public bool Equals(HBRUSH other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
