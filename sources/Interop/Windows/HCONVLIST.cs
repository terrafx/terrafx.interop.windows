// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCONVLIST : IEquatable<HCONVLIST>
    {
        public readonly nint Value;

        public static HCONVLIST NULL => (HCONVLIST)(0);

        public HCONVLIST(int value)
        {
            Value = ((nint)(value));
        }

        public HCONVLIST(uint value)
        {
            Value = ((nint)(value));
        }

        public HCONVLIST(nint value)
        {
            Value = ((nint)(value));
        }

        public HCONVLIST(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCONVLIST(void* value)
        {
            Value = ((nint)(value));
        }

        public HCONVLIST(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HCONVLIST left, HCONVLIST right) => left.Value == right.Value;

        public static bool operator !=(HCONVLIST left, HCONVLIST right) => left.Value != right.Value;

        public static explicit operator HCONVLIST(int value) => new HCONVLIST(value);

        public static explicit operator HCONVLIST(uint value) => new HCONVLIST(value);

        public static explicit operator HCONVLIST(nint value) => new HCONVLIST(value);

        public static explicit operator HCONVLIST(nuint value) => new HCONVLIST(value);

        public static explicit operator HCONVLIST(void* value) => new HCONVLIST(value);

        public static explicit operator HCONVLIST(HANDLE value) => new HCONVLIST(value);

        public static explicit operator int(HCONVLIST value) => (int)(value.Value);

        public static explicit operator uint(HCONVLIST value) => (uint)(value.Value);

        public static implicit operator nint(HCONVLIST value) => (nint)(value.Value);

        public static implicit operator nuint(HCONVLIST value) => (nuint)(value.Value);

        public static implicit operator void*(HCONVLIST value) => (void*)(value.Value);

        public static implicit operator HANDLE(HCONVLIST value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HCONVLIST other) && Equals(other);

        public bool Equals(HCONVLIST other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
