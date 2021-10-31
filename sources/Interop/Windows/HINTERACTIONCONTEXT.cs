// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HINTERACTIONCONTEXT : IEquatable<HINTERACTIONCONTEXT>
    {
        public readonly nint Value;

        public HINTERACTIONCONTEXT(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) => left.Value == right.Value;

        public static bool operator !=(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) => left.Value != right.Value;

        public static implicit operator HINTERACTIONCONTEXT(nint value) => new HINTERACTIONCONTEXT(value);

        public static implicit operator nint(HINTERACTIONCONTEXT value) => value.Value;

        public override bool Equals(object? obj) => (obj is HINTERACTIONCONTEXT other) && Equals(other);

        public bool Equals(HINTERACTIONCONTEXT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
