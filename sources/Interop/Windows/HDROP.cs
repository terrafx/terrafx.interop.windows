// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDROP : IEquatable<HDROP>
    {
        public readonly nint Value;

        public static HDROP NULL => (HDROP)(0);

        public HDROP(int value)
        {
            Value = ((nint)(value));
        }

        public HDROP(uint value)
        {
            Value = ((nint)(value));
        }

        public HDROP(nint value)
        {
            Value = ((nint)(value));
        }

        public HDROP(nuint value)
        {
            Value = ((nint)(value));
        }

        public HDROP(void* value)
        {
            Value = ((nint)(value));
        }

        public HDROP(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HDROP left, HDROP right) => left.Value == right.Value;

        public static bool operator !=(HDROP left, HDROP right) => left.Value != right.Value;

        public static explicit operator HDROP(int value) => new HDROP(value);

        public static explicit operator HDROP(uint value) => new HDROP(value);

        public static explicit operator HDROP(nint value) => new HDROP(value);

        public static explicit operator HDROP(nuint value) => new HDROP(value);

        public static explicit operator HDROP(void* value) => new HDROP(value);

        public static explicit operator HDROP(HANDLE value) => new HDROP(value);

        public static explicit operator int(HDROP value) => (int)(value.Value);

        public static explicit operator uint(HDROP value) => (uint)(value.Value);

        public static implicit operator nint(HDROP value) => (nint)(value.Value);

        public static implicit operator nuint(HDROP value) => (nuint)(value.Value);

        public static implicit operator void*(HDROP value) => (void*)(value.Value);

        public static implicit operator HANDLE(HDROP value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HDROP other) && Equals(other);

        public bool Equals(HDROP other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
