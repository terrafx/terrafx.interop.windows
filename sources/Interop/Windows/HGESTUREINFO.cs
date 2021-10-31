// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HGESTUREINFO : IEquatable<HGESTUREINFO>
    {
        public readonly nint Value;

        public HGESTUREINFO(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HGESTUREINFO left, HGESTUREINFO right) => left.Value == right.Value;

        public static bool operator !=(HGESTUREINFO left, HGESTUREINFO right) => left.Value != right.Value;

        public static implicit operator HGESTUREINFO(nint value) => new HGESTUREINFO(value);

        public static implicit operator nint(HGESTUREINFO value) => value.Value;

        public override bool Equals(object? obj) => (obj is HGESTUREINFO other) && Equals(other);

        public bool Equals(HGESTUREINFO other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
