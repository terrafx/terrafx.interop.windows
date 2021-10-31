// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HIMC : IEquatable<HIMC>
    {
        public readonly nint Value;

        public HIMC(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HIMC left, HIMC right) => left.Value == right.Value;

        public static bool operator !=(HIMC left, HIMC right) => left.Value != right.Value;

        public static implicit operator HIMC(nint value) => new HIMC(value);

        public static implicit operator nint(HIMC value) => value.Value;

        public override bool Equals(object? obj) => (obj is HIMC other) && Equals(other);

        public bool Equals(HIMC other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
