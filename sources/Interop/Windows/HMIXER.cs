// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HMIXER : IEquatable<HMIXER>
    {
        public readonly nint Value;

        public HMIXER(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HMIXER left, HMIXER right) => left.Value == right.Value;

        public static bool operator !=(HMIXER left, HMIXER right) => left.Value != right.Value;

        public static implicit operator HMIXER(nint value) => new HMIXER(value);

        public static implicit operator nint(HMIXER value) => value.Value;

        public override bool Equals(object? obj) => (obj is HMIXER other) && Equals(other);

        public bool Equals(HMIXER other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
