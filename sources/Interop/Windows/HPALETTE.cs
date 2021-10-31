// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HPALETTE : IEquatable<HPALETTE>
    {
        public readonly nint Value;

        public HPALETTE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HPALETTE left, HPALETTE right) => left.Value == right.Value;

        public static bool operator !=(HPALETTE left, HPALETTE right) => left.Value != right.Value;

        public static implicit operator HPALETTE(nint value) => new HPALETTE(value);

        public static implicit operator nint(HPALETTE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HPALETTE other) && Equals(other);

        public bool Equals(HPALETTE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
