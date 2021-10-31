// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HMETAFILEPICT : IEquatable<HMETAFILEPICT>
    {
        public readonly nint Value;

        public HMETAFILEPICT(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HMETAFILEPICT left, HMETAFILEPICT right) => left.Value == right.Value;

        public static bool operator !=(HMETAFILEPICT left, HMETAFILEPICT right) => left.Value != right.Value;

        public static implicit operator HMETAFILEPICT(nint value) => new HMETAFILEPICT(value);

        public static implicit operator nint(HMETAFILEPICT value) => value.Value;

        public override bool Equals(object? obj) => (obj is HMETAFILEPICT other) && Equals(other);

        public bool Equals(HMETAFILEPICT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
