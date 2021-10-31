// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HIFTIMESTAMPCHANGE : IEquatable<HIFTIMESTAMPCHANGE>
    {
        public readonly nint Value;

        public HIFTIMESTAMPCHANGE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HIFTIMESTAMPCHANGE left, HIFTIMESTAMPCHANGE right) => left.Value == right.Value;

        public static bool operator !=(HIFTIMESTAMPCHANGE left, HIFTIMESTAMPCHANGE right) => left.Value != right.Value;

        public static implicit operator HIFTIMESTAMPCHANGE(nint value) => new HIFTIMESTAMPCHANGE(value);

        public static implicit operator nint(HIFTIMESTAMPCHANGE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HIFTIMESTAMPCHANGE other) && Equals(other);

        public bool Equals(HIFTIMESTAMPCHANGE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
