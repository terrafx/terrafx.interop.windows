// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HDROP : IEquatable<HDROP>
    {
        public readonly nint Value;

        public HDROP(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HDROP left, HDROP right) => left.Value == right.Value;

        public static bool operator !=(HDROP left, HDROP right) => left.Value != right.Value;

        public static implicit operator HDROP(nint value) => new HDROP(value);

        public static implicit operator nint(HDROP value) => value.Value;

        public override bool Equals(object? obj) => (obj is HDROP other) && Equals(other);

        public bool Equals(HDROP other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
