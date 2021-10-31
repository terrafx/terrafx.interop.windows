// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct ROPARAMIIDHANDLE : IEquatable<ROPARAMIIDHANDLE>
    {
        public readonly nint Value;

        public ROPARAMIIDHANDLE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(ROPARAMIIDHANDLE left, ROPARAMIIDHANDLE right) => left.Value == right.Value;

        public static bool operator !=(ROPARAMIIDHANDLE left, ROPARAMIIDHANDLE right) => left.Value != right.Value;

        public static implicit operator ROPARAMIIDHANDLE(nint value) => new ROPARAMIIDHANDLE(value);

        public static implicit operator nint(ROPARAMIIDHANDLE value) => value.Value;

        public override bool Equals(object? obj) => (obj is ROPARAMIIDHANDLE other) && Equals(other);

        public bool Equals(ROPARAMIIDHANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
