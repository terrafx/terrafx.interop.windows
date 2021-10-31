// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HSPFILELOG : IEquatable<HSPFILELOG>
    {
        public readonly nint Value;

        public HSPFILELOG(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HSPFILELOG left, HSPFILELOG right) => left.Value == right.Value;

        public static bool operator !=(HSPFILELOG left, HSPFILELOG right) => left.Value != right.Value;

        public static implicit operator HSPFILELOG(nint value) => new HSPFILELOG(value);

        public static implicit operator nint(HSPFILELOG value) => value.Value;

        public override bool Equals(object? obj) => (obj is HSPFILELOG other) && Equals(other);

        public bool Equals(HSPFILELOG other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
