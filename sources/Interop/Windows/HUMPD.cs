// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HUMPD : IEquatable<HUMPD>
    {
        public readonly nint Value;

        public HUMPD(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HUMPD left, HUMPD right) => left.Value == right.Value;

        public static bool operator !=(HUMPD left, HUMPD right) => left.Value != right.Value;

        public static implicit operator HUMPD(nint value) => new HUMPD(value);

        public static implicit operator nint(HUMPD value) => value.Value;

        public override bool Equals(object? obj) => (obj is HUMPD other) && Equals(other);

        public bool Equals(HUMPD other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
