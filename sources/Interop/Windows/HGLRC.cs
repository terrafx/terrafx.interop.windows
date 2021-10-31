// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HGLRC : IEquatable<HGLRC>
    {
        public readonly nint Value;

        public HGLRC(int value)
        {
            Value = ((nint)(value));
        }

        public HGLRC(uint value)
        {
            Value = ((nint)(value));
        }

        public HGLRC(nint value)
        {
            Value = ((nint)(value));
        }

        public HGLRC(nuint value)
        {
            Value = ((nint)(value));
        }

        public HGLRC(void* value)
        {
            Value = ((nint)(value));
        }

        public HGLRC(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HGLRC left, HGLRC right) => left.Value == right.Value;

        public static bool operator !=(HGLRC left, HGLRC right) => left.Value != right.Value;

        public static explicit operator HGLRC(int value) => new HGLRC(value);

        public static explicit operator HGLRC(uint value) => new HGLRC(value);

        public static explicit operator HGLRC(nint value) => new HGLRC(value);

        public static explicit operator HGLRC(nuint value) => new HGLRC(value);

        public static explicit operator HGLRC(void* value) => new HGLRC(value);

        public static explicit operator HGLRC(HANDLE value) => new HGLRC(value);

        public static implicit operator int(HGLRC value) => (int)(value.Value);

        public static implicit operator uint(HGLRC value) => (uint)(value.Value);

        public static implicit operator nint(HGLRC value) => (nint)(value.Value);

        public static implicit operator nuint(HGLRC value) => (nuint)(value.Value);

        public static implicit operator void*(HGLRC value) => (void*)(value.Value);

        public static implicit operator HANDLE(HGLRC value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HGLRC other) && Equals(other);

        public bool Equals(HGLRC other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
