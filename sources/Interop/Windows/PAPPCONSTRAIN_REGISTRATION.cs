// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PAPPCONSTRAIN_REGISTRATION : IEquatable<PAPPCONSTRAIN_REGISTRATION>
    {
        public readonly nint Value;

        public PAPPCONSTRAIN_REGISTRATION(nint value)
        {
            Value = ((nint)(value));
        }

        public PAPPCONSTRAIN_REGISTRATION(nuint value)
        {
            Value = ((nint)(value));
        }

        public PAPPCONSTRAIN_REGISTRATION(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(PAPPCONSTRAIN_REGISTRATION left, PAPPCONSTRAIN_REGISTRATION right) => left.Value == right.Value;

        public static bool operator !=(PAPPCONSTRAIN_REGISTRATION left, PAPPCONSTRAIN_REGISTRATION right) => left.Value != right.Value;

        public static explicit operator PAPPCONSTRAIN_REGISTRATION(nint value) => new PAPPCONSTRAIN_REGISTRATION(value);

        public static explicit operator PAPPCONSTRAIN_REGISTRATION(nuint value) => new PAPPCONSTRAIN_REGISTRATION(value);

        public static explicit operator PAPPCONSTRAIN_REGISTRATION(void* value) => new PAPPCONSTRAIN_REGISTRATION(value);

        public static implicit operator nint(PAPPCONSTRAIN_REGISTRATION value) => (nint)(value.Value);

        public static implicit operator nuint(PAPPCONSTRAIN_REGISTRATION value) => (nuint)(value.Value);

        public static implicit operator void*(PAPPCONSTRAIN_REGISTRATION value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is PAPPCONSTRAIN_REGISTRATION other) && Equals(other);

        public bool Equals(PAPPCONSTRAIN_REGISTRATION other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
