// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HEVENT : IEquatable<HEVENT>
    {
        public readonly nint Value;

        public HEVENT(int value)
        {
            Value = ((nint)(value));
        }

        public HEVENT(uint value)
        {
            Value = ((nint)(value));
        }

        public HEVENT(nint value)
        {
            Value = ((nint)(value));
        }

        public HEVENT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HEVENT(void* value)
        {
            Value = ((nint)(value));
        }

        public HEVENT(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HEVENT left, HEVENT right) => left.Value == right.Value;

        public static bool operator !=(HEVENT left, HEVENT right) => left.Value != right.Value;

        public static explicit operator HEVENT(int value) => new HEVENT(value);

        public static explicit operator HEVENT(uint value) => new HEVENT(value);

        public static explicit operator HEVENT(nint value) => new HEVENT(value);

        public static explicit operator HEVENT(nuint value) => new HEVENT(value);

        public static explicit operator HEVENT(void* value) => new HEVENT(value);

        public static explicit operator HEVENT(HANDLE value) => new HEVENT(value);

        public static implicit operator int(HEVENT value) => (int)(value.Value);

        public static implicit operator uint(HEVENT value) => (uint)(value.Value);

        public static implicit operator nint(HEVENT value) => (nint)(value.Value);

        public static implicit operator nuint(HEVENT value) => (nuint)(value.Value);

        public static implicit operator void*(HEVENT value) => (void*)(value.Value);

        public static implicit operator HANDLE(HEVENT value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HEVENT other) && Equals(other);

        public bool Equals(HEVENT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
