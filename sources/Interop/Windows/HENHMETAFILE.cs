// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HENHMETAFILE : IEquatable<HENHMETAFILE>
    {
        public readonly nint Value;

        public HENHMETAFILE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HENHMETAFILE left, HENHMETAFILE right) => left.Value == right.Value;

        public static bool operator !=(HENHMETAFILE left, HENHMETAFILE right) => left.Value != right.Value;

        public static implicit operator HENHMETAFILE(nint value) => new HENHMETAFILE(value);

        public static implicit operator nint(HENHMETAFILE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HENHMETAFILE other) && Equals(other);

        public bool Equals(HENHMETAFILE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
