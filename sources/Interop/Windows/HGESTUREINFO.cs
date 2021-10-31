// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HGESTUREINFO : IEquatable<HGESTUREINFO>
    {
        public readonly nint Value;

        public static HGESTUREINFO NULL => (HGESTUREINFO)(0);

        public HGESTUREINFO(int value)
        {
            Value = ((nint)(value));
        }

        public HGESTUREINFO(uint value)
        {
            Value = ((nint)(value));
        }

        public HGESTUREINFO(nint value)
        {
            Value = ((nint)(value));
        }

        public HGESTUREINFO(nuint value)
        {
            Value = ((nint)(value));
        }

        public HGESTUREINFO(void* value)
        {
            Value = ((nint)(value));
        }

        public HGESTUREINFO(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HGESTUREINFO left, HGESTUREINFO right) => left.Value == right.Value;

        public static bool operator !=(HGESTUREINFO left, HGESTUREINFO right) => left.Value != right.Value;

        public static explicit operator HGESTUREINFO(int value) => new HGESTUREINFO(value);

        public static explicit operator HGESTUREINFO(uint value) => new HGESTUREINFO(value);

        public static explicit operator HGESTUREINFO(nint value) => new HGESTUREINFO(value);

        public static explicit operator HGESTUREINFO(nuint value) => new HGESTUREINFO(value);

        public static explicit operator HGESTUREINFO(void* value) => new HGESTUREINFO(value);

        public static explicit operator HGESTUREINFO(HANDLE value) => new HGESTUREINFO(value);

        public static explicit operator int(HGESTUREINFO value) => (int)(value.Value);

        public static explicit operator uint(HGESTUREINFO value) => (uint)(value.Value);

        public static implicit operator nint(HGESTUREINFO value) => (nint)(value.Value);

        public static implicit operator nuint(HGESTUREINFO value) => (nuint)(value.Value);

        public static implicit operator void*(HGESTUREINFO value) => (void*)(value.Value);

        public static implicit operator HANDLE(HGESTUREINFO value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HGESTUREINFO other) && Equals(other);

        public bool Equals(HGESTUREINFO other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
