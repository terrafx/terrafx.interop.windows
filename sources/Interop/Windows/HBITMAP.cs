// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HBITMAP : IEquatable<HBITMAP>
    {
        public readonly nint Value;

        public HBITMAP(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HBITMAP left, HBITMAP right) => left.Value == right.Value;

        public static bool operator !=(HBITMAP left, HBITMAP right) => left.Value != right.Value;

        public static implicit operator HBITMAP(nint value) => new HBITMAP(value);

        public static implicit operator nint(HBITMAP value) => value.Value;

        public override bool Equals(object? obj) => (obj is HBITMAP other) && Equals(other);

        public bool Equals(HBITMAP other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
