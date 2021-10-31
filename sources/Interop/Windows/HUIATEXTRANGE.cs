// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HUIATEXTRANGE : IEquatable<HUIATEXTRANGE>
    {
        public readonly nint Value;

        public static HUIATEXTRANGE NULL => (HUIATEXTRANGE)(0);

        public HUIATEXTRANGE(int value)
        {
            Value = ((nint)(value));
        }

        public HUIATEXTRANGE(uint value)
        {
            Value = ((nint)(value));
        }

        public HUIATEXTRANGE(nint value)
        {
            Value = ((nint)(value));
        }

        public HUIATEXTRANGE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HUIATEXTRANGE(void* value)
        {
            Value = ((nint)(value));
        }

        public HUIATEXTRANGE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HUIATEXTRANGE left, HUIATEXTRANGE right) => left.Value == right.Value;

        public static bool operator !=(HUIATEXTRANGE left, HUIATEXTRANGE right) => left.Value != right.Value;

        public static explicit operator HUIATEXTRANGE(int value) => new HUIATEXTRANGE(value);

        public static explicit operator HUIATEXTRANGE(uint value) => new HUIATEXTRANGE(value);

        public static explicit operator HUIATEXTRANGE(nint value) => new HUIATEXTRANGE(value);

        public static explicit operator HUIATEXTRANGE(nuint value) => new HUIATEXTRANGE(value);

        public static explicit operator HUIATEXTRANGE(void* value) => new HUIATEXTRANGE(value);

        public static explicit operator HUIATEXTRANGE(HANDLE value) => new HUIATEXTRANGE(value);

        public static explicit operator int(HUIATEXTRANGE value) => (int)(value.Value);

        public static explicit operator uint(HUIATEXTRANGE value) => (uint)(value.Value);

        public static implicit operator nint(HUIATEXTRANGE value) => (nint)(value.Value);

        public static implicit operator nuint(HUIATEXTRANGE value) => (nuint)(value.Value);

        public static implicit operator void*(HUIATEXTRANGE value) => (void*)(value.Value);

        public static implicit operator HANDLE(HUIATEXTRANGE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HUIATEXTRANGE other) && Equals(other);

        public bool Equals(HUIATEXTRANGE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
