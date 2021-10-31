// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HTASK : IEquatable<HTASK>
    {
        public readonly nint Value;

        public HTASK(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HTASK left, HTASK right) => left.Value == right.Value;

        public static bool operator !=(HTASK left, HTASK right) => left.Value != right.Value;

        public static implicit operator HTASK(nint value) => new HTASK(value);

        public static implicit operator nint(HTASK value) => value.Value;

        public override bool Equals(object? obj) => (obj is HTASK other) && Equals(other);

        public bool Equals(HTASK other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
