// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HCOLORSPACE : IEquatable<HCOLORSPACE>
    {
        public readonly nint Value;

        public HCOLORSPACE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HCOLORSPACE left, HCOLORSPACE right) => left.Value == right.Value;

        public static bool operator !=(HCOLORSPACE left, HCOLORSPACE right) => left.Value != right.Value;

        public static implicit operator HCOLORSPACE(nint value) => new HCOLORSPACE(value);

        public static implicit operator nint(HCOLORSPACE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HCOLORSPACE other) && Equals(other);

        public bool Equals(HCOLORSPACE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
