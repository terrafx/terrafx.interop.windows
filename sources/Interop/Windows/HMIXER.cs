// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMIXER : IEquatable<HMIXER>
    {
        public readonly nint Value;

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

        public static bool operator ==(HMIXER left, HMIXER right) => left.Value == right.Value;

        public static bool operator !=(HMIXER left, HMIXER right) => left.Value != right.Value;

        public static explicit operator HMIXER(nint value) => new HMIXER(value);

        public static explicit operator HMIXER(nuint value) => new HMIXER(value);

        public static explicit operator HMIXER(void* value) => new HMIXER(value);

        public static implicit operator nint(HMIXER value) => (nint)(value.Value);

        public static implicit operator nuint(HMIXER value) => (nuint)(value.Value);

        public static implicit operator void*(HMIXER value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HMIXER other) && Equals(other);

        public bool Equals(HMIXER other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
