// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWAVEIN : IEquatable<HWAVEIN>
    {
        public readonly nint Value;

        public HWAVEIN(nint value)
        {
            Value = ((nint)(value));
        }

        public HWAVEIN(nuint value)
        {
            Value = ((nint)(value));
        }

        public HWAVEIN(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HWAVEIN left, HWAVEIN right) => left.Value == right.Value;

        public static bool operator !=(HWAVEIN left, HWAVEIN right) => left.Value != right.Value;

        public static explicit operator HWAVEIN(nint value) => new HWAVEIN(value);

        public static explicit operator HWAVEIN(nuint value) => new HWAVEIN(value);

        public static explicit operator HWAVEIN(void* value) => new HWAVEIN(value);

        public static implicit operator nint(HWAVEIN value) => (nint)(value.Value);

        public static implicit operator nuint(HWAVEIN value) => (nuint)(value.Value);

        public static implicit operator void*(HWAVEIN value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HWAVEIN other) && Equals(other);

        public bool Equals(HWAVEIN other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
