// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSPFILEQ : IEquatable<HSPFILEQ>
    {
        public readonly void* Value;

        public HSPFILEQ(int value)
        {
            Value = ((void*)(value));
        }

        public HSPFILEQ(uint value)
        {
            Value = ((void*)(value));
        }

        public HSPFILEQ(nint value)
        {
            Value = ((void*)(value));
        }

        public HSPFILEQ(nuint value)
        {
            Value = ((void*)(value));
        }

        public HSPFILEQ(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(HSPFILEQ left, HSPFILEQ right) => left.Value == right.Value;

        public static bool operator !=(HSPFILEQ left, HSPFILEQ right) => left.Value != right.Value;

        public static explicit operator HSPFILEQ(int value) => new HSPFILEQ(value);

        public static explicit operator HSPFILEQ(uint value) => new HSPFILEQ(value);

        public static explicit operator HSPFILEQ(nint value) => new HSPFILEQ(value);

        public static explicit operator HSPFILEQ(nuint value) => new HSPFILEQ(value);

        public static explicit operator HSPFILEQ(void* value) => new HSPFILEQ(value);

        public static explicit operator int(HSPFILEQ value) => (int)(value.Value);

        public static explicit operator uint(HSPFILEQ value) => (uint)(value.Value);

        public static implicit operator nint(HSPFILEQ value) => (nint)(value.Value);

        public static implicit operator nuint(HSPFILEQ value) => (nuint)(value.Value);

        public static implicit operator void*(HSPFILEQ value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HSPFILEQ other) && Equals(other);

        public bool Equals(HSPFILEQ other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
