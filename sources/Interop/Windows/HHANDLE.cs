// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HHANDLE : IEquatable<HHANDLE>
    {
        public readonly nint Value;

        public HHANDLE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HHANDLE left, HHANDLE right) => left.Value == right.Value;

        public static bool operator !=(HHANDLE left, HHANDLE right) => left.Value != right.Value;

        public static implicit operator HHANDLE(nint value) => new HHANDLE(value);

        public static implicit operator nint(HHANDLE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HHANDLE other) && Equals(other);

        public bool Equals(HHANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
