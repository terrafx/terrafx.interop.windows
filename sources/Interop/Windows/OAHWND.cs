// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct OAHWND : IEquatable<OAHWND>
    {
        public readonly nint Value;

        public OAHWND(nint value)
        {
            Value = value;
        }

        public static bool operator ==(OAHWND left, OAHWND right) => left.Value == right.Value;

        public static bool operator !=(OAHWND left, OAHWND right) => left.Value != right.Value;

        public static implicit operator OAHWND(nint value) => new OAHWND(value);

        public static implicit operator nint(OAHWND value) => value.Value;

        public override bool Equals(object? obj) => (obj is OAHWND other) && Equals(other);

        public bool Equals(OAHWND other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
