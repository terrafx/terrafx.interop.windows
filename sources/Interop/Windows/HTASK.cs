// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HTASK : IEquatable<HTASK>
    {
        public readonly nint Value;

        public static HTASK NULL => (HTASK)(0);

        public HTASK(int value)
        {
            Value = ((nint)(value));
        }

        public HTASK(uint value)
        {
            Value = ((nint)(value));
        }

        public HTASK(nint value)
        {
            Value = ((nint)(value));
        }

        public HTASK(nuint value)
        {
            Value = ((nint)(value));
        }

        public HTASK(void* value)
        {
            Value = ((nint)(value));
        }

        public HTASK(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HTASK left, HTASK right) => left.Value == right.Value;

        public static bool operator !=(HTASK left, HTASK right) => left.Value != right.Value;

        public static explicit operator HTASK(int value) => new HTASK(value);

        public static explicit operator HTASK(uint value) => new HTASK(value);

        public static explicit operator HTASK(nint value) => new HTASK(value);

        public static explicit operator HTASK(nuint value) => new HTASK(value);

        public static explicit operator HTASK(void* value) => new HTASK(value);

        public static explicit operator HTASK(HANDLE value) => new HTASK(value);

        public static implicit operator int(HTASK value) => (int)(value.Value);

        public static implicit operator uint(HTASK value) => (uint)(value.Value);

        public static implicit operator nint(HTASK value) => (nint)(value.Value);

        public static implicit operator nuint(HTASK value) => (nuint)(value.Value);

        public static implicit operator void*(HTASK value) => (void*)(value.Value);

        public static implicit operator HANDLE(HTASK value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HTASK other) && Equals(other);

        public bool Equals(HTASK other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
