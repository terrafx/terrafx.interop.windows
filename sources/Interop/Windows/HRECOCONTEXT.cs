// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRECOCONTEXT : IEquatable<HRECOCONTEXT>
    {
        public readonly nint Value;

        public HRECOCONTEXT(int value)
        {
            Value = ((nint)(value));
        }

        public HRECOCONTEXT(uint value)
        {
            Value = ((nint)(value));
        }

        public HRECOCONTEXT(nint value)
        {
            Value = ((nint)(value));
        }

        public HRECOCONTEXT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HRECOCONTEXT(void* value)
        {
            Value = ((nint)(value));
        }

        public HRECOCONTEXT(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HRECOCONTEXT left, HRECOCONTEXT right) => left.Value == right.Value;

        public static bool operator !=(HRECOCONTEXT left, HRECOCONTEXT right) => left.Value != right.Value;

        public static explicit operator HRECOCONTEXT(int value) => new HRECOCONTEXT(value);

        public static explicit operator HRECOCONTEXT(uint value) => new HRECOCONTEXT(value);

        public static explicit operator HRECOCONTEXT(nint value) => new HRECOCONTEXT(value);

        public static explicit operator HRECOCONTEXT(nuint value) => new HRECOCONTEXT(value);

        public static explicit operator HRECOCONTEXT(void* value) => new HRECOCONTEXT(value);

        public static explicit operator HRECOCONTEXT(HANDLE value) => new HRECOCONTEXT(value);

        public static implicit operator int(HRECOCONTEXT value) => (int)(value.Value);

        public static implicit operator uint(HRECOCONTEXT value) => (uint)(value.Value);

        public static implicit operator nint(HRECOCONTEXT value) => (nint)(value.Value);

        public static implicit operator nuint(HRECOCONTEXT value) => (nuint)(value.Value);

        public static implicit operator void*(HRECOCONTEXT value) => (void*)(value.Value);

        public static implicit operator HANDLE(HRECOCONTEXT value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HRECOCONTEXT other) && Equals(other);

        public bool Equals(HRECOCONTEXT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
