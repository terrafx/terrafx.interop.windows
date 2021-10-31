// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HACMSTREAM : IEquatable<HACMSTREAM>
    {
        public readonly nint Value;

        public static HACMSTREAM NULL => (HACMSTREAM)(0);

        public HACMSTREAM(int value)
        {
            Value = ((nint)(value));
        }

        public HACMSTREAM(uint value)
        {
            Value = ((nint)(value));
        }

        public HACMSTREAM(nint value)
        {
            Value = ((nint)(value));
        }

        public HACMSTREAM(nuint value)
        {
            Value = ((nint)(value));
        }

        public HACMSTREAM(void* value)
        {
            Value = ((nint)(value));
        }

        public HACMSTREAM(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HACMSTREAM left, HACMSTREAM right) => left.Value == right.Value;

        public static bool operator !=(HACMSTREAM left, HACMSTREAM right) => left.Value != right.Value;

        public static explicit operator HACMSTREAM(int value) => new HACMSTREAM(value);

        public static explicit operator HACMSTREAM(uint value) => new HACMSTREAM(value);

        public static explicit operator HACMSTREAM(nint value) => new HACMSTREAM(value);

        public static explicit operator HACMSTREAM(nuint value) => new HACMSTREAM(value);

        public static explicit operator HACMSTREAM(void* value) => new HACMSTREAM(value);

        public static explicit operator HACMSTREAM(HANDLE value) => new HACMSTREAM(value);

        public static explicit operator int(HACMSTREAM value) => (int)(value.Value);

        public static explicit operator uint(HACMSTREAM value) => (uint)(value.Value);

        public static implicit operator nint(HACMSTREAM value) => (nint)(value.Value);

        public static implicit operator nuint(HACMSTREAM value) => (nuint)(value.Value);

        public static implicit operator void*(HACMSTREAM value) => (void*)(value.Value);

        public static implicit operator HANDLE(HACMSTREAM value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HACMSTREAM other) && Equals(other);

        public bool Equals(HACMSTREAM other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
