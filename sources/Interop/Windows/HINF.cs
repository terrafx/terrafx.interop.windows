// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HINF : IEquatable<HINF>
    {
        public readonly void* Value;

        public HINF(int value)
        {
            Value = ((void*)(value));
        }

        public HINF(uint value)
        {
            Value = ((void*)(value));
        }

        public HINF(nint value)
        {
            Value = ((void*)(value));
        }

        public HINF(nuint value)
        {
            Value = ((void*)(value));
        }

        public HINF(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(HINF left, HINF right) => left.Value == right.Value;

        public static bool operator !=(HINF left, HINF right) => left.Value != right.Value;

        public static explicit operator HINF(int value) => new HINF(value);

        public static explicit operator HINF(uint value) => new HINF(value);

        public static explicit operator HINF(nint value) => new HINF(value);

        public static explicit operator HINF(nuint value) => new HINF(value);

        public static explicit operator HINF(void* value) => new HINF(value);

        public static implicit operator int(HINF value) => (int)(value.Value);

        public static implicit operator uint(HINF value) => (uint)(value.Value);

        public static implicit operator nint(HINF value) => (nint)(value.Value);

        public static implicit operator nuint(HINF value) => (nuint)(value.Value);

        public static implicit operator void*(HINF value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HINF other) && Equals(other);

        public bool Equals(HINF other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
