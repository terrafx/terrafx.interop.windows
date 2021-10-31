// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HCRYPTHASH : IEquatable<HCRYPTHASH>
    {
        public readonly nint Value;

        public HCRYPTHASH(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HCRYPTHASH left, HCRYPTHASH right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTHASH left, HCRYPTHASH right) => left.Value != right.Value;

        public static implicit operator HCRYPTHASH(nint value) => new HCRYPTHASH(value);

        public static implicit operator nint(HCRYPTHASH value) => value.Value;

        public override bool Equals(object? obj) => (obj is HCRYPTHASH other) && Equals(other);

        public bool Equals(HCRYPTHASH other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
