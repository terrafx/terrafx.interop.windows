// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSYNTHETICPOINTERDEVICE : IEquatable<HSYNTHETICPOINTERDEVICE>
    {
        public readonly nint Value;

        public HSYNTHETICPOINTERDEVICE(int value)
        {
            Value = ((nint)(value));
        }

        public HSYNTHETICPOINTERDEVICE(uint value)
        {
            Value = ((nint)(value));
        }

        public HSYNTHETICPOINTERDEVICE(nint value)
        {
            Value = ((nint)(value));
        }

        public HSYNTHETICPOINTERDEVICE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HSYNTHETICPOINTERDEVICE(void* value)
        {
            Value = ((nint)(value));
        }

        public HSYNTHETICPOINTERDEVICE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) => left.Value == right.Value;

        public static bool operator !=(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) => left.Value != right.Value;

        public static explicit operator HSYNTHETICPOINTERDEVICE(int value) => new HSYNTHETICPOINTERDEVICE(value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(uint value) => new HSYNTHETICPOINTERDEVICE(value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(nint value) => new HSYNTHETICPOINTERDEVICE(value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(nuint value) => new HSYNTHETICPOINTERDEVICE(value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(void* value) => new HSYNTHETICPOINTERDEVICE(value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(HANDLE value) => new HSYNTHETICPOINTERDEVICE(value);

        public static implicit operator int(HSYNTHETICPOINTERDEVICE value) => (int)(value.Value);

        public static implicit operator uint(HSYNTHETICPOINTERDEVICE value) => (uint)(value.Value);

        public static implicit operator nint(HSYNTHETICPOINTERDEVICE value) => (nint)(value.Value);

        public static implicit operator nuint(HSYNTHETICPOINTERDEVICE value) => (nuint)(value.Value);

        public static implicit operator void*(HSYNTHETICPOINTERDEVICE value) => (void*)(value.Value);

        public static implicit operator HANDLE(HSYNTHETICPOINTERDEVICE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HSYNTHETICPOINTERDEVICE other) && Equals(other);

        public bool Equals(HSYNTHETICPOINTERDEVICE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
