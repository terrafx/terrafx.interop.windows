// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWAVE : IEquatable<HWAVE>
    {
        public readonly nint Value;

        public static HWAVE NULL => (HWAVE)(0);

        public HWAVE(int value)
        {
            Value = ((nint)(value));
        }

        public HWAVE(uint value)
        {
            Value = ((nint)(value));
        }

        public HWAVE(nint value)
        {
            Value = ((nint)(value));
        }

        public HWAVE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HWAVE(void* value)
        {
            Value = ((nint)(value));
        }

        public HWAVE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HWAVE left, HWAVE right) => left.Value == right.Value;

        public static bool operator !=(HWAVE left, HWAVE right) => left.Value != right.Value;

        public static explicit operator HWAVE(int value) => new HWAVE(value);

        public static explicit operator HWAVE(uint value) => new HWAVE(value);

        public static explicit operator HWAVE(nint value) => new HWAVE(value);

        public static explicit operator HWAVE(nuint value) => new HWAVE(value);

        public static explicit operator HWAVE(void* value) => new HWAVE(value);

        public static explicit operator HWAVE(HANDLE value) => new HWAVE(value);

        public static explicit operator int(HWAVE value) => (int)(value.Value);

        public static explicit operator uint(HWAVE value) => (uint)(value.Value);

        public static implicit operator nint(HWAVE value) => (nint)(value.Value);

        public static implicit operator nuint(HWAVE value) => (nuint)(value.Value);

        public static implicit operator void*(HWAVE value) => (void*)(value.Value);

        public static implicit operator HANDLE(HWAVE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HWAVE other) && Equals(other);

        public bool Equals(HWAVE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
