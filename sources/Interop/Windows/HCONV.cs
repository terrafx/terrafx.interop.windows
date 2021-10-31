// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCONV : IEquatable<HCONV>
    {
        public readonly nint Value;

        public HCONV(int value)
        {
            Value = ((nint)(value));
        }

        public HCONV(uint value)
        {
            Value = ((nint)(value));
        }

        public HCONV(nint value)
        {
            Value = ((nint)(value));
        }

        public HCONV(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCONV(void* value)
        {
            Value = ((nint)(value));
        }

        public HCONV(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HCONV left, HCONV right) => left.Value == right.Value;

        public static bool operator !=(HCONV left, HCONV right) => left.Value != right.Value;

        public static explicit operator HCONV(int value) => new HCONV(value);

        public static explicit operator HCONV(uint value) => new HCONV(value);

        public static explicit operator HCONV(nint value) => new HCONV(value);

        public static explicit operator HCONV(nuint value) => new HCONV(value);

        public static explicit operator HCONV(void* value) => new HCONV(value);

        public static explicit operator HCONV(HANDLE value) => new HCONV(value);

        public static implicit operator int(HCONV value) => (int)(value.Value);

        public static implicit operator uint(HCONV value) => (uint)(value.Value);

        public static implicit operator nint(HCONV value) => (nint)(value.Value);

        public static implicit operator nuint(HCONV value) => (nuint)(value.Value);

        public static implicit operator void*(HCONV value) => (void*)(value.Value);

        public static implicit operator HANDLE(HCONV value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HCONV other) && Equals(other);

        public bool Equals(HCONV other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
