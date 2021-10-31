// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPTRANSITIONID : IEquatable<SPTRANSITIONID>
    {
        public readonly nint Value;

        public static SPTRANSITIONID NULL => (SPTRANSITIONID)(0);

        public SPTRANSITIONID(int value)
        {
            Value = ((nint)(value));
        }

        public SPTRANSITIONID(uint value)
        {
            Value = ((nint)(value));
        }

        public SPTRANSITIONID(nint value)
        {
            Value = ((nint)(value));
        }

        public SPTRANSITIONID(nuint value)
        {
            Value = ((nint)(value));
        }

        public SPTRANSITIONID(void* value)
        {
            Value = ((nint)(value));
        }

        public SPTRANSITIONID(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(SPTRANSITIONID left, SPTRANSITIONID right) => left.Value == right.Value;

        public static bool operator !=(SPTRANSITIONID left, SPTRANSITIONID right) => left.Value != right.Value;

        public static explicit operator SPTRANSITIONID(int value) => new SPTRANSITIONID(value);

        public static explicit operator SPTRANSITIONID(uint value) => new SPTRANSITIONID(value);

        public static explicit operator SPTRANSITIONID(nint value) => new SPTRANSITIONID(value);

        public static explicit operator SPTRANSITIONID(nuint value) => new SPTRANSITIONID(value);

        public static explicit operator SPTRANSITIONID(void* value) => new SPTRANSITIONID(value);

        public static explicit operator SPTRANSITIONID(HANDLE value) => new SPTRANSITIONID(value);

        public static implicit operator int(SPTRANSITIONID value) => (int)(value.Value);

        public static implicit operator uint(SPTRANSITIONID value) => (uint)(value.Value);

        public static implicit operator nint(SPTRANSITIONID value) => (nint)(value.Value);

        public static implicit operator nuint(SPTRANSITIONID value) => (nuint)(value.Value);

        public static implicit operator void*(SPTRANSITIONID value) => (void*)(value.Value);

        public static implicit operator HANDLE(SPTRANSITIONID value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is SPTRANSITIONID other) && Equals(other);

        public bool Equals(SPTRANSITIONID other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
