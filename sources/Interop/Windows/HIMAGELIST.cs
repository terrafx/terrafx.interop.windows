// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HIMAGELIST : IEquatable<HIMAGELIST>
    {
        public readonly nint Value;

        public HIMAGELIST(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HIMAGELIST left, HIMAGELIST right) => left.Value == right.Value;

        public static bool operator !=(HIMAGELIST left, HIMAGELIST right) => left.Value != right.Value;

        public static implicit operator HIMAGELIST(nint value) => new HIMAGELIST(value);

        public static implicit operator nint(HIMAGELIST value) => value.Value;

        public override bool Equals(object? obj) => (obj is HIMAGELIST other) && Equals(other);

        public bool Equals(HIMAGELIST other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
