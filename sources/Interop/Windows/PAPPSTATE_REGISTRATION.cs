// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PAPPSTATE_REGISTRATION : IEquatable<PAPPSTATE_REGISTRATION>
    {
        public readonly void* Value;

        public PAPPSTATE_REGISTRATION(int value)
        {
            Value = ((void*)(value));
        }

        public PAPPSTATE_REGISTRATION(uint value)
        {
            Value = ((void*)(value));
        }

        public PAPPSTATE_REGISTRATION(nint value)
        {
            Value = ((void*)(value));
        }

        public PAPPSTATE_REGISTRATION(nuint value)
        {
            Value = ((void*)(value));
        }

        public PAPPSTATE_REGISTRATION(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(PAPPSTATE_REGISTRATION left, PAPPSTATE_REGISTRATION right) => left.Value == right.Value;

        public static bool operator !=(PAPPSTATE_REGISTRATION left, PAPPSTATE_REGISTRATION right) => left.Value != right.Value;

        public static explicit operator PAPPSTATE_REGISTRATION(int value) => new PAPPSTATE_REGISTRATION(value);

        public static explicit operator PAPPSTATE_REGISTRATION(uint value) => new PAPPSTATE_REGISTRATION(value);

        public static explicit operator PAPPSTATE_REGISTRATION(nint value) => new PAPPSTATE_REGISTRATION(value);

        public static explicit operator PAPPSTATE_REGISTRATION(nuint value) => new PAPPSTATE_REGISTRATION(value);

        public static explicit operator PAPPSTATE_REGISTRATION(void* value) => new PAPPSTATE_REGISTRATION(value);

        public static explicit operator int(PAPPSTATE_REGISTRATION value) => (int)(value.Value);

        public static explicit operator uint(PAPPSTATE_REGISTRATION value) => (uint)(value.Value);

        public static implicit operator nint(PAPPSTATE_REGISTRATION value) => (nint)(value.Value);

        public static implicit operator nuint(PAPPSTATE_REGISTRATION value) => (nuint)(value.Value);

        public static implicit operator void*(PAPPSTATE_REGISTRATION value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is PAPPSTATE_REGISTRATION other) && Equals(other);

        public bool Equals(PAPPSTATE_REGISTRATION other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
