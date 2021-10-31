// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPALETTE : IEquatable<HPALETTE>
    {
        public readonly nint Value;

        public HPALETTE(int value)
        {
            Value = ((nint)(value));
        }

        public HPALETTE(uint value)
        {
            Value = ((nint)(value));
        }

        public HPALETTE(nint value)
        {
            Value = ((nint)(value));
        }

        public HPALETTE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HPALETTE(void* value)
        {
            Value = ((nint)(value));
        }

        public HPALETTE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HPALETTE left, HPALETTE right) => left.Value == right.Value;

        public static bool operator !=(HPALETTE left, HPALETTE right) => left.Value != right.Value;

        public static explicit operator HPALETTE(int value) => new HPALETTE(value);

        public static explicit operator HPALETTE(uint value) => new HPALETTE(value);

        public static explicit operator HPALETTE(nint value) => new HPALETTE(value);

        public static explicit operator HPALETTE(nuint value) => new HPALETTE(value);

        public static explicit operator HPALETTE(void* value) => new HPALETTE(value);

        public static explicit operator HPALETTE(HANDLE value) => new HPALETTE(value);

        public static implicit operator int(HPALETTE value) => (int)(value.Value);

        public static implicit operator uint(HPALETTE value) => (uint)(value.Value);

        public static implicit operator nint(HPALETTE value) => (nint)(value.Value);

        public static implicit operator nuint(HPALETTE value) => (nuint)(value.Value);

        public static implicit operator void*(HPALETTE value) => (void*)(value.Value);

        public static implicit operator HANDLE(HPALETTE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HPALETTE other) && Equals(other);

        public bool Equals(HPALETTE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
