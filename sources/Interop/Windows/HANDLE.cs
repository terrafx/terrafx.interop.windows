// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HANDLE : IEquatable<HANDLE>
    {
        public readonly nint Value;

        public HANDLE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HANDLE left, HANDLE right) => left.Value == right.Value;

        public static bool operator !=(HANDLE left, HANDLE right) => left.Value != right.Value;

        public static implicit operator HANDLE(nint value) => new HANDLE(value);

        public static implicit operator nint(HANDLE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HANDLE other) && Equals(other);

        public bool Equals(HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
