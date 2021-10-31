// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWINSTA : IEquatable<HWINSTA>
    {
        public readonly nint Value;

        public static HWINSTA NULL => (HWINSTA)(0);

        public HWINSTA(int value)
        {
            Value = ((nint)(value));
        }

        public HWINSTA(uint value)
        {
            Value = ((nint)(value));
        }

        public HWINSTA(nint value)
        {
            Value = ((nint)(value));
        }

        public HWINSTA(nuint value)
        {
            Value = ((nint)(value));
        }

        public HWINSTA(void* value)
        {
            Value = ((nint)(value));
        }

        public HWINSTA(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HWINSTA left, HWINSTA right) => left.Value == right.Value;

        public static bool operator !=(HWINSTA left, HWINSTA right) => left.Value != right.Value;

        public static explicit operator HWINSTA(int value) => new HWINSTA(value);

        public static explicit operator HWINSTA(uint value) => new HWINSTA(value);

        public static explicit operator HWINSTA(nint value) => new HWINSTA(value);

        public static explicit operator HWINSTA(nuint value) => new HWINSTA(value);

        public static explicit operator HWINSTA(void* value) => new HWINSTA(value);

        public static explicit operator HWINSTA(HANDLE value) => new HWINSTA(value);

        public static implicit operator int(HWINSTA value) => (int)(value.Value);

        public static implicit operator uint(HWINSTA value) => (uint)(value.Value);

        public static implicit operator nint(HWINSTA value) => (nint)(value.Value);

        public static implicit operator nuint(HWINSTA value) => (nuint)(value.Value);

        public static implicit operator void*(HWINSTA value) => (void*)(value.Value);

        public static implicit operator HANDLE(HWINSTA value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HWINSTA other) && Equals(other);

        public bool Equals(HWINSTA other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
