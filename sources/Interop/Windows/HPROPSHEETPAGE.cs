// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HPROPSHEETPAGE : IEquatable<HPROPSHEETPAGE>
    {
        public readonly nint Value;

        public HPROPSHEETPAGE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HPROPSHEETPAGE left, HPROPSHEETPAGE right) => left.Value == right.Value;

        public static bool operator !=(HPROPSHEETPAGE left, HPROPSHEETPAGE right) => left.Value != right.Value;

        public static implicit operator HPROPSHEETPAGE(nint value) => new HPROPSHEETPAGE(value);

        public static implicit operator nint(HPROPSHEETPAGE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HPROPSHEETPAGE other) && Equals(other);

        public bool Equals(HPROPSHEETPAGE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
