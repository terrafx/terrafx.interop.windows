// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HDC : IEquatable<HDC>
    {
        public readonly nint Value;

        public HDC(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HDC left, HDC right) => left.Value == right.Value;

        public static bool operator !=(HDC left, HDC right) => left.Value != right.Value;

        public static implicit operator HDC(nint value) => new HDC(value);

        public static implicit operator nint(HDC value) => value.Value;

        public override bool Equals(object? obj) => (obj is HDC other) && Equals(other);

        public bool Equals(HDC other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
