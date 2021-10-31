// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPCON : IEquatable<HPCON>
    {
        public readonly void* Value;

        public HPCON(int value)
        {
            Value = ((void*)(value));
        }

        public HPCON(uint value)
        {
            Value = ((void*)(value));
        }

        public HPCON(nint value)
        {
            Value = ((void*)(value));
        }

        public HPCON(nuint value)
        {
            Value = ((void*)(value));
        }

        public HPCON(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(HPCON left, HPCON right) => left.Value == right.Value;

        public static bool operator !=(HPCON left, HPCON right) => left.Value != right.Value;

        public static explicit operator HPCON(int value) => new HPCON(value);

        public static explicit operator HPCON(uint value) => new HPCON(value);

        public static explicit operator HPCON(nint value) => new HPCON(value);

        public static explicit operator HPCON(nuint value) => new HPCON(value);

        public static explicit operator HPCON(void* value) => new HPCON(value);

        public static implicit operator int(HPCON value) => (int)(value.Value);

        public static implicit operator uint(HPCON value) => (uint)(value.Value);

        public static implicit operator nint(HPCON value) => (nint)(value.Value);

        public static implicit operator nuint(HPCON value) => (nuint)(value.Value);

        public static implicit operator void*(HPCON value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HPCON other) && Equals(other);

        public bool Equals(HPCON other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
