// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HFASTMUTEX : IEquatable<HFASTMUTEX>
    {
        public readonly nint Value;

        public static HFASTMUTEX NULL => (HFASTMUTEX)(0);

        public HFASTMUTEX(int value)
        {
            Value = ((nint)(value));
        }

        public HFASTMUTEX(uint value)
        {
            Value = ((nint)(value));
        }

        public HFASTMUTEX(nint value)
        {
            Value = ((nint)(value));
        }

        public HFASTMUTEX(nuint value)
        {
            Value = ((nint)(value));
        }

        public HFASTMUTEX(void* value)
        {
            Value = ((nint)(value));
        }

        public HFASTMUTEX(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HFASTMUTEX left, HFASTMUTEX right) => left.Value == right.Value;

        public static bool operator !=(HFASTMUTEX left, HFASTMUTEX right) => left.Value != right.Value;

        public static explicit operator HFASTMUTEX(int value) => new HFASTMUTEX(value);

        public static explicit operator HFASTMUTEX(uint value) => new HFASTMUTEX(value);

        public static explicit operator HFASTMUTEX(nint value) => new HFASTMUTEX(value);

        public static explicit operator HFASTMUTEX(nuint value) => new HFASTMUTEX(value);

        public static explicit operator HFASTMUTEX(void* value) => new HFASTMUTEX(value);

        public static explicit operator HFASTMUTEX(HANDLE value) => new HFASTMUTEX(value);

        public static implicit operator int(HFASTMUTEX value) => (int)(value.Value);

        public static implicit operator uint(HFASTMUTEX value) => (uint)(value.Value);

        public static implicit operator nint(HFASTMUTEX value) => (nint)(value.Value);

        public static implicit operator nuint(HFASTMUTEX value) => (nuint)(value.Value);

        public static implicit operator void*(HFASTMUTEX value) => (void*)(value.Value);

        public static implicit operator HANDLE(HFASTMUTEX value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HFASTMUTEX other) && Equals(other);

        public bool Equals(HFASTMUTEX other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
