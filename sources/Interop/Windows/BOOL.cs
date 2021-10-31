// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct BOOL : IEquatable<BOOL>
    {
        public readonly int Value;

        public BOOL(int value)
        {
            Value = value;
        }

        public static bool operator ==(BOOL left, BOOL right) => left.Value == right.Value;

        public static bool operator !=(BOOL left, BOOL right) => left.Value != right.Value;

        public static implicit operator BOOL(int value) => new BOOL(value);

        public static implicit operator int(BOOL value) => value.Value;

        public override bool Equals(object? obj) => (obj is BOOL other) && Equals(other);

        public bool Equals(BOOL other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
