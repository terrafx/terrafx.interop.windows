// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMIDISTRM : IEquatable<HMIDISTRM>
    {
        public readonly nint Value;

        public HMIDISTRM(int value)
        {
            Value = ((nint)(value));
        }

        public HMIDISTRM(uint value)
        {
            Value = ((nint)(value));
        }

        public HMIDISTRM(nint value)
        {
            Value = ((nint)(value));
        }

        public HMIDISTRM(nuint value)
        {
            Value = ((nint)(value));
        }

        public HMIDISTRM(void* value)
        {
            Value = ((nint)(value));
        }

        public HMIDISTRM(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HMIDISTRM left, HMIDISTRM right) => left.Value == right.Value;

        public static bool operator !=(HMIDISTRM left, HMIDISTRM right) => left.Value != right.Value;

        public static explicit operator HMIDISTRM(int value) => new HMIDISTRM(value);

        public static explicit operator HMIDISTRM(uint value) => new HMIDISTRM(value);

        public static explicit operator HMIDISTRM(nint value) => new HMIDISTRM(value);

        public static explicit operator HMIDISTRM(nuint value) => new HMIDISTRM(value);

        public static explicit operator HMIDISTRM(void* value) => new HMIDISTRM(value);

        public static explicit operator HMIDISTRM(HANDLE value) => new HMIDISTRM(value);

        public static implicit operator int(HMIDISTRM value) => (int)(value.Value);

        public static implicit operator uint(HMIDISTRM value) => (uint)(value.Value);

        public static implicit operator nint(HMIDISTRM value) => (nint)(value.Value);

        public static implicit operator nuint(HMIDISTRM value) => (nuint)(value.Value);

        public static implicit operator void*(HMIDISTRM value) => (void*)(value.Value);

        public static implicit operator HANDLE(HMIDISTRM value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HMIDISTRM other) && Equals(other);

        public bool Equals(HMIDISTRM other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
