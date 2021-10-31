// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HCERTSTORE : IEquatable<HCERTSTORE>
    {
        public readonly nint Value;

        public HCERTSTORE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HCERTSTORE left, HCERTSTORE right) => left.Value == right.Value;

        public static bool operator !=(HCERTSTORE left, HCERTSTORE right) => left.Value != right.Value;

        public static implicit operator HCERTSTORE(nint value) => new HCERTSTORE(value);

        public static implicit operator nint(HCERTSTORE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HCERTSTORE other) && Equals(other);

        public bool Equals(HCERTSTORE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
