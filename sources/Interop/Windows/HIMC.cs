// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HIMC : IEquatable<HIMC>
    {
        public readonly nint Value;

        public static HIMC NULL => (HIMC)(0);

        public HIMC(int value)
        {
            Value = ((nint)(value));
        }

        public HIMC(uint value)
        {
            Value = ((nint)(value));
        }

        public HIMC(nint value)
        {
            Value = ((nint)(value));
        }

        public HIMC(nuint value)
        {
            Value = ((nint)(value));
        }

        public HIMC(void* value)
        {
            Value = ((nint)(value));
        }

        public HIMC(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HIMC left, HIMC right) => left.Value == right.Value;

        public static bool operator !=(HIMC left, HIMC right) => left.Value != right.Value;

        public static explicit operator HIMC(int value) => new HIMC(value);

        public static explicit operator HIMC(uint value) => new HIMC(value);

        public static explicit operator HIMC(nint value) => new HIMC(value);

        public static explicit operator HIMC(nuint value) => new HIMC(value);

        public static explicit operator HIMC(void* value) => new HIMC(value);

        public static explicit operator HIMC(HANDLE value) => new HIMC(value);

        public static implicit operator int(HIMC value) => (int)(value.Value);

        public static implicit operator uint(HIMC value) => (uint)(value.Value);

        public static implicit operator nint(HIMC value) => (nint)(value.Value);

        public static implicit operator nuint(HIMC value) => (nuint)(value.Value);

        public static implicit operator void*(HIMC value) => (void*)(value.Value);

        public static implicit operator HANDLE(HIMC value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HIMC other) && Equals(other);

        public bool Equals(HIMC other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
