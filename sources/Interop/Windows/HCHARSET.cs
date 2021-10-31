// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCHARSET : IEquatable<HCHARSET>
    {
        public readonly nint Value;

        public HCHARSET(int value)
        {
            Value = ((nint)(value));
        }

        public HCHARSET(uint value)
        {
            Value = ((nint)(value));
        }

        public HCHARSET(nint value)
        {
            Value = ((nint)(value));
        }

        public HCHARSET(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCHARSET(void* value)
        {
            Value = ((nint)(value));
        }

        public HCHARSET(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HCHARSET left, HCHARSET right) => left.Value == right.Value;

        public static bool operator !=(HCHARSET left, HCHARSET right) => left.Value != right.Value;

        public static explicit operator HCHARSET(int value) => new HCHARSET(value);

        public static explicit operator HCHARSET(uint value) => new HCHARSET(value);

        public static explicit operator HCHARSET(nint value) => new HCHARSET(value);

        public static explicit operator HCHARSET(nuint value) => new HCHARSET(value);

        public static explicit operator HCHARSET(void* value) => new HCHARSET(value);

        public static explicit operator HCHARSET(HANDLE value) => new HCHARSET(value);

        public static implicit operator int(HCHARSET value) => (int)(value.Value);

        public static implicit operator uint(HCHARSET value) => (uint)(value.Value);

        public static implicit operator nint(HCHARSET value) => (nint)(value.Value);

        public static implicit operator nuint(HCHARSET value) => (nuint)(value.Value);

        public static implicit operator void*(HCHARSET value) => (void*)(value.Value);

        public static implicit operator HANDLE(HCHARSET value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HCHARSET other) && Equals(other);

        public bool Equals(HCHARSET other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
