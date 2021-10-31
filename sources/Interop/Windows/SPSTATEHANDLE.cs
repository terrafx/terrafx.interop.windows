// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct SPSTATEHANDLE : IEquatable<SPSTATEHANDLE>
    {
        public readonly nint Value;

        public SPSTATEHANDLE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(SPSTATEHANDLE left, SPSTATEHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPSTATEHANDLE left, SPSTATEHANDLE right) => left.Value != right.Value;

        public static implicit operator SPSTATEHANDLE(nint value) => new SPSTATEHANDLE(value);

        public static implicit operator nint(SPSTATEHANDLE value) => value.Value;

        public override bool Equals(object? obj) => (obj is SPSTATEHANDLE other) && Equals(other);

        public bool Equals(SPSTATEHANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
