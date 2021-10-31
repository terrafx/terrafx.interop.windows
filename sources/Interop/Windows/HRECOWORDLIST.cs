// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRECOWORDLIST : IEquatable<HRECOWORDLIST>
    {
        public readonly nint Value;

        public static HRECOWORDLIST NULL => (HRECOWORDLIST)(0);

        public HRECOWORDLIST(int value)
        {
            Value = ((nint)(value));
        }

        public HRECOWORDLIST(uint value)
        {
            Value = ((nint)(value));
        }

        public HRECOWORDLIST(nint value)
        {
            Value = ((nint)(value));
        }

        public HRECOWORDLIST(nuint value)
        {
            Value = ((nint)(value));
        }

        public HRECOWORDLIST(void* value)
        {
            Value = ((nint)(value));
        }

        public HRECOWORDLIST(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HRECOWORDLIST left, HRECOWORDLIST right) => left.Value == right.Value;

        public static bool operator !=(HRECOWORDLIST left, HRECOWORDLIST right) => left.Value != right.Value;

        public static explicit operator HRECOWORDLIST(int value) => new HRECOWORDLIST(value);

        public static explicit operator HRECOWORDLIST(uint value) => new HRECOWORDLIST(value);

        public static explicit operator HRECOWORDLIST(nint value) => new HRECOWORDLIST(value);

        public static explicit operator HRECOWORDLIST(nuint value) => new HRECOWORDLIST(value);

        public static explicit operator HRECOWORDLIST(void* value) => new HRECOWORDLIST(value);

        public static explicit operator HRECOWORDLIST(HANDLE value) => new HRECOWORDLIST(value);

        public static implicit operator int(HRECOWORDLIST value) => (int)(value.Value);

        public static implicit operator uint(HRECOWORDLIST value) => (uint)(value.Value);

        public static implicit operator nint(HRECOWORDLIST value) => (nint)(value.Value);

        public static implicit operator nuint(HRECOWORDLIST value) => (nuint)(value.Value);

        public static implicit operator void*(HRECOWORDLIST value) => (void*)(value.Value);

        public static implicit operator HANDLE(HRECOWORDLIST value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HRECOWORDLIST other) && Equals(other);

        public bool Equals(HRECOWORDLIST other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
