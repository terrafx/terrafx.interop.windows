// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct COMPRESSOR_HANDLE : IEquatable<COMPRESSOR_HANDLE>
    {
        public readonly nint Value;

        public COMPRESSOR_HANDLE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(COMPRESSOR_HANDLE left, COMPRESSOR_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(COMPRESSOR_HANDLE left, COMPRESSOR_HANDLE right) => left.Value != right.Value;

        public static implicit operator COMPRESSOR_HANDLE(nint value) => new COMPRESSOR_HANDLE(value);

        public static implicit operator nint(COMPRESSOR_HANDLE value) => value.Value;

        public override bool Equals(object? obj) => (obj is COMPRESSOR_HANDLE other) && Equals(other);

        public bool Equals(COMPRESSOR_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
