// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBRUSH : IEquatable<HBRUSH>
    {
        public readonly nint Value;

        public HBRUSH(nint value)
        {
            Value = ((nint)(value));
        }

        public HBRUSH(nuint value)
        {
            Value = ((nint)(value));
        }

        public HBRUSH(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HBRUSH left, HBRUSH right) => left.Value == right.Value;

        public static bool operator !=(HBRUSH left, HBRUSH right) => left.Value != right.Value;

        public static explicit operator HBRUSH(nint value) => new HBRUSH(value);

        public static explicit operator HBRUSH(nuint value) => new HBRUSH(value);

        public static explicit operator HBRUSH(void* value) => new HBRUSH(value);

        public static implicit operator nint(HBRUSH value) => (nint)(value.Value);

        public static implicit operator nuint(HBRUSH value) => (nuint)(value.Value);

        public static implicit operator void*(HBRUSH value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HBRUSH other) && Equals(other);

        public bool Equals(HBRUSH other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
