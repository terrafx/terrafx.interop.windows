// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SAFER_LEVEL_HANDLE : IEquatable<SAFER_LEVEL_HANDLE>
    {
        public readonly nint Value;

        public SAFER_LEVEL_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public SAFER_LEVEL_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public SAFER_LEVEL_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public SAFER_LEVEL_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public SAFER_LEVEL_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public SAFER_LEVEL_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(SAFER_LEVEL_HANDLE left, SAFER_LEVEL_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(SAFER_LEVEL_HANDLE left, SAFER_LEVEL_HANDLE right) => left.Value != right.Value;

        public static explicit operator SAFER_LEVEL_HANDLE(int value) => new SAFER_LEVEL_HANDLE(value);

        public static explicit operator SAFER_LEVEL_HANDLE(uint value) => new SAFER_LEVEL_HANDLE(value);

        public static explicit operator SAFER_LEVEL_HANDLE(nint value) => new SAFER_LEVEL_HANDLE(value);

        public static explicit operator SAFER_LEVEL_HANDLE(nuint value) => new SAFER_LEVEL_HANDLE(value);

        public static explicit operator SAFER_LEVEL_HANDLE(void* value) => new SAFER_LEVEL_HANDLE(value);

        public static explicit operator SAFER_LEVEL_HANDLE(HANDLE value) => new SAFER_LEVEL_HANDLE(value);

        public static implicit operator int(SAFER_LEVEL_HANDLE value) => (int)(value.Value);

        public static implicit operator uint(SAFER_LEVEL_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(SAFER_LEVEL_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(SAFER_LEVEL_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(SAFER_LEVEL_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(SAFER_LEVEL_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is SAFER_LEVEL_HANDLE other) && Equals(other);

        public bool Equals(SAFER_LEVEL_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
