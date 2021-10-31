// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HRAWINPUT : IEquatable<HRAWINPUT>
    {
        public readonly nint Value;

        public HRAWINPUT(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HRAWINPUT left, HRAWINPUT right) => left.Value == right.Value;

        public static bool operator !=(HRAWINPUT left, HRAWINPUT right) => left.Value != right.Value;

        public static implicit operator HRAWINPUT(nint value) => new HRAWINPUT(value);

        public static implicit operator nint(HRAWINPUT value) => value.Value;

        public override bool Equals(object? obj) => (obj is HRAWINPUT other) && Equals(other);

        public bool Equals(HRAWINPUT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
