// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HHOOK : IEquatable<HHOOK>
    {
        public readonly nint Value;

        public HHOOK(nint value)
        {
            Value = ((nint)(value));
        }

        public HHOOK(nuint value)
        {
            Value = ((nint)(value));
        }

        public HHOOK(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HHOOK left, HHOOK right) => left.Value == right.Value;

        public static bool operator !=(HHOOK left, HHOOK right) => left.Value != right.Value;

        public static explicit operator HHOOK(nint value) => new HHOOK(value);

        public static explicit operator HHOOK(nuint value) => new HHOOK(value);

        public static explicit operator HHOOK(void* value) => new HHOOK(value);

        public static implicit operator nint(HHOOK value) => (nint)(value.Value);

        public static implicit operator nuint(HHOOK value) => (nuint)(value.Value);

        public static implicit operator void*(HHOOK value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HHOOK other) && Equals(other);

        public bool Equals(HHOOK other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
