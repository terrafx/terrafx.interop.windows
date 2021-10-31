// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HMETAFILE : IEquatable<HMETAFILE>
    {
        public readonly nint Value;

        public HMETAFILE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HMETAFILE left, HMETAFILE right) => left.Value == right.Value;

        public static bool operator !=(HMETAFILE left, HMETAFILE right) => left.Value != right.Value;

        public static implicit operator HMETAFILE(nint value) => new HMETAFILE(value);

        public static implicit operator nint(HMETAFILE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HMETAFILE other) && Equals(other);

        public bool Equals(HMETAFILE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
