// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HLSURF : IEquatable<HLSURF>
    {
        public readonly nint Value;

        public HLSURF(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HLSURF left, HLSURF right) => left.Value == right.Value;

        public static bool operator !=(HLSURF left, HLSURF right) => left.Value != right.Value;

        public static implicit operator HLSURF(nint value) => new HLSURF(value);

        public static implicit operator nint(HLSURF value) => value.Value;

        public override bool Equals(object? obj) => (obj is HLSURF other) && Equals(other);

        public bool Equals(HLSURF other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
