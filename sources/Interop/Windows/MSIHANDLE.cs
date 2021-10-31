// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct MSIHANDLE : IEquatable<MSIHANDLE>
    {
        public readonly uint Value;

        public MSIHANDLE(uint value)
        {
            Value = value;
        }

        public MSIHANDLE(int value)
        {
            Value = ((uint)(value));
        }

        public static bool operator ==(MSIHANDLE left, MSIHANDLE right) => left.Value == right.Value;

        public static bool operator !=(MSIHANDLE left, MSIHANDLE right) => left.Value != right.Value;

        public static explicit operator MSIHANDLE(int value) => new MSIHANDLE(value);

        public static explicit operator int(MSIHANDLE value) => (int)(value.Value);

        public static implicit operator MSIHANDLE(uint value) => new MSIHANDLE(value);

        public static implicit operator uint(MSIHANDLE value) => value.Value;

        public override bool Equals(object? obj) => (obj is MSIHANDLE other) && Equals(other);

        public bool Equals(MSIHANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
