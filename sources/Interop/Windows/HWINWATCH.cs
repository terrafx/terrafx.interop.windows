// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWINWATCH : IEquatable<HWINWATCH>
    {
        public readonly nint Value;

        public HWINWATCH(int value)
        {
            Value = ((nint)(value));
        }

        public HWINWATCH(uint value)
        {
            Value = ((nint)(value));
        }

        public HWINWATCH(nint value)
        {
            Value = ((nint)(value));
        }

        public HWINWATCH(nuint value)
        {
            Value = ((nint)(value));
        }

        public HWINWATCH(void* value)
        {
            Value = ((nint)(value));
        }

        public HWINWATCH(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HWINWATCH left, HWINWATCH right) => left.Value == right.Value;

        public static bool operator !=(HWINWATCH left, HWINWATCH right) => left.Value != right.Value;

        public static explicit operator HWINWATCH(int value) => new HWINWATCH(value);

        public static explicit operator HWINWATCH(uint value) => new HWINWATCH(value);

        public static explicit operator HWINWATCH(nint value) => new HWINWATCH(value);

        public static explicit operator HWINWATCH(nuint value) => new HWINWATCH(value);

        public static explicit operator HWINWATCH(void* value) => new HWINWATCH(value);

        public static explicit operator HWINWATCH(HANDLE value) => new HWINWATCH(value);

        public static implicit operator int(HWINWATCH value) => (int)(value.Value);

        public static implicit operator uint(HWINWATCH value) => (uint)(value.Value);

        public static implicit operator nint(HWINWATCH value) => (nint)(value.Value);

        public static implicit operator nuint(HWINWATCH value) => (nuint)(value.Value);

        public static implicit operator void*(HWINWATCH value) => (void*)(value.Value);

        public static implicit operator HANDLE(HWINWATCH value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HWINWATCH other) && Equals(other);

        public bool Equals(HWINWATCH other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
