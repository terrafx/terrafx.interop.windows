// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HMIXEROBJ : IEquatable<HMIXEROBJ>
    {
        public readonly nint Value;

        public HMIXEROBJ(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HMIXEROBJ left, HMIXEROBJ right) => left.Value == right.Value;

        public static bool operator !=(HMIXEROBJ left, HMIXEROBJ right) => left.Value != right.Value;

        public static implicit operator HMIXEROBJ(nint value) => new HMIXEROBJ(value);

        public static implicit operator nint(HMIXEROBJ value) => value.Value;

        public override bool Equals(object? obj) => (obj is HMIXEROBJ other) && Equals(other);

        public bool Equals(HMIXEROBJ other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
