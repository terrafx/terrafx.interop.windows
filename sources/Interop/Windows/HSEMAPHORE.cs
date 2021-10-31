// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSEMAPHORE : IEquatable<HSEMAPHORE>
    {
        public readonly nint Value;

        public static HSEMAPHORE NULL => (HSEMAPHORE)(0);

        public HSEMAPHORE(int value)
        {
            Value = ((nint)(value));
        }

        public HSEMAPHORE(uint value)
        {
            Value = ((nint)(value));
        }

        public HSEMAPHORE(nint value)
        {
            Value = ((nint)(value));
        }

        public HSEMAPHORE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HSEMAPHORE(void* value)
        {
            Value = ((nint)(value));
        }

        public HSEMAPHORE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HSEMAPHORE left, HSEMAPHORE right) => left.Value == right.Value;

        public static bool operator !=(HSEMAPHORE left, HSEMAPHORE right) => left.Value != right.Value;

        public static explicit operator HSEMAPHORE(int value) => new HSEMAPHORE(value);

        public static explicit operator HSEMAPHORE(uint value) => new HSEMAPHORE(value);

        public static explicit operator HSEMAPHORE(nint value) => new HSEMAPHORE(value);

        public static explicit operator HSEMAPHORE(nuint value) => new HSEMAPHORE(value);

        public static explicit operator HSEMAPHORE(void* value) => new HSEMAPHORE(value);

        public static explicit operator HSEMAPHORE(HANDLE value) => new HSEMAPHORE(value);

        public static explicit operator int(HSEMAPHORE value) => (int)(value.Value);

        public static explicit operator uint(HSEMAPHORE value) => (uint)(value.Value);

        public static implicit operator nint(HSEMAPHORE value) => (nint)(value.Value);

        public static implicit operator nuint(HSEMAPHORE value) => (nuint)(value.Value);

        public static implicit operator void*(HSEMAPHORE value) => (void*)(value.Value);

        public static implicit operator HANDLE(HSEMAPHORE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HSEMAPHORE other) && Equals(other);

        public bool Equals(HSEMAPHORE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
