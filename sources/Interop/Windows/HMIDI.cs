// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMIDI : IEquatable<HMIDI>
    {
        public readonly nint Value;

        public static HMIDI NULL => (HMIDI)(0);

        public HMIDI(int value)
        {
            Value = ((nint)(value));
        }

        public HMIDI(uint value)
        {
            Value = ((nint)(value));
        }

        public HMIDI(nint value)
        {
            Value = ((nint)(value));
        }

        public HMIDI(nuint value)
        {
            Value = ((nint)(value));
        }

        public HMIDI(void* value)
        {
            Value = ((nint)(value));
        }

        public HMIDI(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HMIDI left, HMIDI right) => left.Value == right.Value;

        public static bool operator !=(HMIDI left, HMIDI right) => left.Value != right.Value;

        public static explicit operator HMIDI(int value) => new HMIDI(value);

        public static explicit operator HMIDI(uint value) => new HMIDI(value);

        public static explicit operator HMIDI(nint value) => new HMIDI(value);

        public static explicit operator HMIDI(nuint value) => new HMIDI(value);

        public static explicit operator HMIDI(void* value) => new HMIDI(value);

        public static explicit operator HMIDI(HANDLE value) => new HMIDI(value);

        public static implicit operator int(HMIDI value) => (int)(value.Value);

        public static implicit operator uint(HMIDI value) => (uint)(value.Value);

        public static implicit operator nint(HMIDI value) => (nint)(value.Value);

        public static implicit operator nuint(HMIDI value) => (nuint)(value.Value);

        public static implicit operator void*(HMIDI value) => (void*)(value.Value);

        public static implicit operator HANDLE(HMIDI value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HMIDI other) && Equals(other);

        public bool Equals(HMIDI other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
