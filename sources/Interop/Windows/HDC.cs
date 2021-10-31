// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDC : IEquatable<HDC>
    {
        public readonly nint Value;

        public HDC(nint value)
        {
            Value = ((nint)(value));
        }

        public HDC(nuint value)
        {
            Value = ((nint)(value));
        }

        public HDC(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HDC left, HDC right) => left.Value == right.Value;

        public static bool operator !=(HDC left, HDC right) => left.Value != right.Value;

        public static explicit operator HDC(nint value) => new HDC(value);

        public static explicit operator HDC(nuint value) => new HDC(value);

        public static explicit operator HDC(void* value) => new HDC(value);

        public static implicit operator nint(HDC value) => (nint)(value.Value);

        public static implicit operator nuint(HDC value) => (nuint)(value.Value);

        public static implicit operator void*(HDC value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HDC other) && Equals(other);

        public bool Equals(HDC other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
