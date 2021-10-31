// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HUMPD : IEquatable<HUMPD>
    {
        public readonly nint Value;

        public HUMPD(nint value)
        {
            Value = ((nint)(value));
        }

        public HUMPD(nuint value)
        {
            Value = ((nint)(value));
        }

        public HUMPD(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HUMPD left, HUMPD right) => left.Value == right.Value;

        public static bool operator !=(HUMPD left, HUMPD right) => left.Value != right.Value;

        public static explicit operator HUMPD(nint value) => new HUMPD(value);

        public static explicit operator HUMPD(nuint value) => new HUMPD(value);

        public static explicit operator HUMPD(void* value) => new HUMPD(value);

        public static implicit operator nint(HUMPD value) => (nint)(value.Value);

        public static implicit operator nuint(HUMPD value) => (nuint)(value.Value);

        public static implicit operator void*(HUMPD value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HUMPD other) && Equals(other);

        public bool Equals(HUMPD other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
