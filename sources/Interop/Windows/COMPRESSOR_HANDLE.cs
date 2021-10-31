// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct COMPRESSOR_HANDLE : IEquatable<COMPRESSOR_HANDLE>
    {
        public readonly nint Value;

        public COMPRESSOR_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public COMPRESSOR_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public COMPRESSOR_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public COMPRESSOR_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public COMPRESSOR_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public COMPRESSOR_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(COMPRESSOR_HANDLE left, COMPRESSOR_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(COMPRESSOR_HANDLE left, COMPRESSOR_HANDLE right) => left.Value != right.Value;

        public static explicit operator COMPRESSOR_HANDLE(int value) => new COMPRESSOR_HANDLE(value);

        public static explicit operator COMPRESSOR_HANDLE(uint value) => new COMPRESSOR_HANDLE(value);

        public static explicit operator COMPRESSOR_HANDLE(nint value) => new COMPRESSOR_HANDLE(value);

        public static explicit operator COMPRESSOR_HANDLE(nuint value) => new COMPRESSOR_HANDLE(value);

        public static explicit operator COMPRESSOR_HANDLE(void* value) => new COMPRESSOR_HANDLE(value);

        public static explicit operator COMPRESSOR_HANDLE(HANDLE value) => new COMPRESSOR_HANDLE(value);

        public static implicit operator int(COMPRESSOR_HANDLE value) => (int)(value.Value);

        public static implicit operator uint(COMPRESSOR_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(COMPRESSOR_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(COMPRESSOR_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(COMPRESSOR_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(COMPRESSOR_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is COMPRESSOR_HANDLE other) && Equals(other);

        public bool Equals(COMPRESSOR_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
