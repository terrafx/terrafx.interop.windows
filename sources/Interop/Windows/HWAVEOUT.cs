// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HWAVEOUT : IEquatable<HWAVEOUT>
    {
        public readonly nint Value;

        public HWAVEOUT(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HWAVEOUT left, HWAVEOUT right) => left.Value == right.Value;

        public static bool operator !=(HWAVEOUT left, HWAVEOUT right) => left.Value != right.Value;

        public static implicit operator HWAVEOUT(nint value) => new HWAVEOUT(value);

        public static implicit operator nint(HWAVEOUT value) => value.Value;

        public override bool Equals(object? obj) => (obj is HWAVEOUT other) && Equals(other);

        public bool Equals(HWAVEOUT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
