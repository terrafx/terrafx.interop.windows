// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HKEY : IEquatable<HKEY>
    {
        public readonly nint Value;

        public static HKEY NULL => (HKEY)(0);

        public HKEY(int value)
        {
            Value = ((nint)(value));
        }

        public HKEY(uint value)
        {
            Value = ((nint)(value));
        }

        public HKEY(nint value)
        {
            Value = ((nint)(value));
        }

        public HKEY(nuint value)
        {
            Value = ((nint)(value));
        }

        public HKEY(void* value)
        {
            Value = ((nint)(value));
        }

        public HKEY(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HKEY left, HKEY right) => left.Value == right.Value;

        public static bool operator !=(HKEY left, HKEY right) => left.Value != right.Value;

        public static explicit operator HKEY(int value) => new HKEY(value);

        public static explicit operator HKEY(uint value) => new HKEY(value);

        public static explicit operator HKEY(nint value) => new HKEY(value);

        public static explicit operator HKEY(nuint value) => new HKEY(value);

        public static explicit operator HKEY(void* value) => new HKEY(value);

        public static explicit operator HKEY(HANDLE value) => new HKEY(value);

        public static explicit operator int(HKEY value) => (int)(value.Value);

        public static explicit operator uint(HKEY value) => (uint)(value.Value);

        public static implicit operator nint(HKEY value) => (nint)(value.Value);

        public static implicit operator nuint(HKEY value) => (nuint)(value.Value);

        public static implicit operator void*(HKEY value) => (void*)(value.Value);

        public static implicit operator HANDLE(HKEY value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HKEY other) && Equals(other);

        public bool Equals(HKEY other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
