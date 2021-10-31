// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HANDLE_PTR : IEquatable<HANDLE_PTR>
    {
        public readonly nuint Value;

        public HANDLE_PTR(int value)
        {
            Value = ((nuint)(value));
        }

        public HANDLE_PTR(uint value)
        {
            Value = ((nuint)(value));
        }

        public HANDLE_PTR(nint value)
        {
            Value = ((nuint)(value));
        }

        public HANDLE_PTR(nuint value)
        {
            Value = ((nuint)(value));
        }

        public HANDLE_PTR(void* value)
        {
            Value = ((nuint)(value));
        }

        public static bool operator ==(HANDLE_PTR left, HANDLE_PTR right) => left.Value == right.Value;

        public static bool operator !=(HANDLE_PTR left, HANDLE_PTR right) => left.Value != right.Value;

        public static explicit operator HANDLE_PTR(int value) => new HANDLE_PTR(value);

        public static explicit operator HANDLE_PTR(uint value) => new HANDLE_PTR(value);

        public static explicit operator HANDLE_PTR(nint value) => new HANDLE_PTR(value);

        public static explicit operator HANDLE_PTR(nuint value) => new HANDLE_PTR(value);

        public static explicit operator HANDLE_PTR(void* value) => new HANDLE_PTR(value);

        public static explicit operator int(HANDLE_PTR value) => (int)(value.Value);

        public static explicit operator uint(HANDLE_PTR value) => (uint)(value.Value);

        public static implicit operator nint(HANDLE_PTR value) => (nint)(value.Value);

        public static implicit operator nuint(HANDLE_PTR value) => (nuint)(value.Value);

        public static implicit operator void*(HANDLE_PTR value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HANDLE_PTR other) && Equals(other);

        public bool Equals(HANDLE_PTR other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
