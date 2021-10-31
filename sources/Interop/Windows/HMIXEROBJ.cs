// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMIXEROBJ : IEquatable<HMIXEROBJ>
    {
        public readonly nint Value;

        public HMIXEROBJ(nint value)
        {
            Value = ((nint)(value));
        }

        public HMIXEROBJ(nuint value)
        {
            Value = ((nint)(value));
        }

        public HMIXEROBJ(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HMIXEROBJ left, HMIXEROBJ right) => left.Value == right.Value;

        public static bool operator !=(HMIXEROBJ left, HMIXEROBJ right) => left.Value != right.Value;

        public static explicit operator HMIXEROBJ(nint value) => new HMIXEROBJ(value);

        public static explicit operator HMIXEROBJ(nuint value) => new HMIXEROBJ(value);

        public static explicit operator HMIXEROBJ(void* value) => new HMIXEROBJ(value);

        public static implicit operator nint(HMIXEROBJ value) => (nint)(value.Value);

        public static implicit operator nuint(HMIXEROBJ value) => (nuint)(value.Value);

        public static implicit operator void*(HMIXEROBJ value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HMIXEROBJ other) && Equals(other);

        public bool Equals(HMIXEROBJ other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
