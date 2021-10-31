// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HACMDRIVER : IEquatable<HACMDRIVER>
    {
        public readonly nint Value;

        public static HACMDRIVER NULL => (HACMDRIVER)(0);

        public HACMDRIVER(int value)
        {
            Value = ((nint)(value));
        }

        public HACMDRIVER(uint value)
        {
            Value = ((nint)(value));
        }

        public HACMDRIVER(nint value)
        {
            Value = ((nint)(value));
        }

        public HACMDRIVER(nuint value)
        {
            Value = ((nint)(value));
        }

        public HACMDRIVER(void* value)
        {
            Value = ((nint)(value));
        }

        public HACMDRIVER(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HACMDRIVER left, HACMDRIVER right) => left.Value == right.Value;

        public static bool operator !=(HACMDRIVER left, HACMDRIVER right) => left.Value != right.Value;

        public static explicit operator HACMDRIVER(int value) => new HACMDRIVER(value);

        public static explicit operator HACMDRIVER(uint value) => new HACMDRIVER(value);

        public static explicit operator HACMDRIVER(nint value) => new HACMDRIVER(value);

        public static explicit operator HACMDRIVER(nuint value) => new HACMDRIVER(value);

        public static explicit operator HACMDRIVER(void* value) => new HACMDRIVER(value);

        public static explicit operator HACMDRIVER(HANDLE value) => new HACMDRIVER(value);

        public static explicit operator int(HACMDRIVER value) => (int)(value.Value);

        public static explicit operator uint(HACMDRIVER value) => (uint)(value.Value);

        public static implicit operator nint(HACMDRIVER value) => (nint)(value.Value);

        public static implicit operator nuint(HACMDRIVER value) => (nuint)(value.Value);

        public static implicit operator void*(HACMDRIVER value) => (void*)(value.Value);

        public static implicit operator HANDLE(HACMDRIVER value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HACMDRIVER other) && Equals(other);

        public bool Equals(HACMDRIVER other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
