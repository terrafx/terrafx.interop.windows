// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HFONT : IEquatable<HFONT>
    {
        public readonly nint Value;

        public HFONT(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HFONT left, HFONT right) => left.Value == right.Value;

        public static bool operator !=(HFONT left, HFONT right) => left.Value != right.Value;

        public static implicit operator HFONT(nint value) => new HFONT(value);

        public static implicit operator nint(HFONT value) => value.Value;

        public override bool Equals(object? obj) => (obj is HFONT other) && Equals(other);

        public bool Equals(HFONT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
