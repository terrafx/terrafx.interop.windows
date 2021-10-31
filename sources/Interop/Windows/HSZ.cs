// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSZ : IEquatable<HSZ>
    {
        public readonly nint Value;

        public static HSZ NULL => (HSZ)(0);

        public HSZ(int value)
        {
            Value = ((nint)(value));
        }

        public HSZ(uint value)
        {
            Value = ((nint)(value));
        }

        public HSZ(nint value)
        {
            Value = ((nint)(value));
        }

        public HSZ(nuint value)
        {
            Value = ((nint)(value));
        }

        public HSZ(void* value)
        {
            Value = ((nint)(value));
        }

        public HSZ(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HSZ left, HSZ right) => left.Value == right.Value;

        public static bool operator !=(HSZ left, HSZ right) => left.Value != right.Value;

        public static explicit operator HSZ(int value) => new HSZ(value);

        public static explicit operator HSZ(uint value) => new HSZ(value);

        public static explicit operator HSZ(nint value) => new HSZ(value);

        public static explicit operator HSZ(nuint value) => new HSZ(value);

        public static explicit operator HSZ(void* value) => new HSZ(value);

        public static explicit operator HSZ(HANDLE value) => new HSZ(value);

        public static implicit operator int(HSZ value) => (int)(value.Value);

        public static implicit operator uint(HSZ value) => (uint)(value.Value);

        public static implicit operator nint(HSZ value) => (nint)(value.Value);

        public static implicit operator nuint(HSZ value) => (nuint)(value.Value);

        public static implicit operator void*(HSZ value) => (void*)(value.Value);

        public static implicit operator HANDLE(HSZ value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HSZ other) && Equals(other);

        public bool Equals(HSZ other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
