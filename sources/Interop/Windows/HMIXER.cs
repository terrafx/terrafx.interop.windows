// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMIXER : IEquatable<HMIXER>
    {
        public readonly nint Value;

        public static HMIXER NULL => (HMIXER)(0);

        public HMIXER(int value)
        {
            Value = ((nint)(value));
        }

        public HMIXER(uint value)
        {
            Value = ((nint)(value));
        }

        public HMIXER(nint value)
        {
            Value = ((nint)(value));
        }

        public HMIXER(nuint value)
        {
            Value = ((nint)(value));
        }

        public HMIXER(void* value)
        {
            Value = ((nint)(value));
        }

        public HMIXER(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HMIXER left, HMIXER right) => left.Value == right.Value;

        public static bool operator !=(HMIXER left, HMIXER right) => left.Value != right.Value;

        public static explicit operator HMIXER(int value) => new HMIXER(value);

        public static explicit operator HMIXER(uint value) => new HMIXER(value);

        public static explicit operator HMIXER(nint value) => new HMIXER(value);

        public static explicit operator HMIXER(nuint value) => new HMIXER(value);

        public static explicit operator HMIXER(void* value) => new HMIXER(value);

        public static explicit operator HMIXER(HANDLE value) => new HMIXER(value);

        public static explicit operator int(HMIXER value) => (int)(value.Value);

        public static explicit operator uint(HMIXER value) => (uint)(value.Value);

        public static implicit operator nint(HMIXER value) => (nint)(value.Value);

        public static implicit operator nuint(HMIXER value) => (nuint)(value.Value);

        public static implicit operator void*(HMIXER value) => (void*)(value.Value);

        public static implicit operator HANDLE(HMIXER value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HMIXER other) && Equals(other);

        public bool Equals(HMIXER other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
