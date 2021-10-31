// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HAMSICONTEXT : IEquatable<HAMSICONTEXT>
    {
        public readonly nint Value;

        public static HAMSICONTEXT NULL => (HAMSICONTEXT)(0);

        public HAMSICONTEXT(int value)
        {
            Value = ((nint)(value));
        }

        public HAMSICONTEXT(uint value)
        {
            Value = ((nint)(value));
        }

        public HAMSICONTEXT(nint value)
        {
            Value = ((nint)(value));
        }

        public HAMSICONTEXT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HAMSICONTEXT(void* value)
        {
            Value = ((nint)(value));
        }

        public HAMSICONTEXT(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HAMSICONTEXT left, HAMSICONTEXT right) => left.Value == right.Value;

        public static bool operator !=(HAMSICONTEXT left, HAMSICONTEXT right) => left.Value != right.Value;

        public static explicit operator HAMSICONTEXT(int value) => new HAMSICONTEXT(value);

        public static explicit operator HAMSICONTEXT(uint value) => new HAMSICONTEXT(value);

        public static explicit operator HAMSICONTEXT(nint value) => new HAMSICONTEXT(value);

        public static explicit operator HAMSICONTEXT(nuint value) => new HAMSICONTEXT(value);

        public static explicit operator HAMSICONTEXT(void* value) => new HAMSICONTEXT(value);

        public static explicit operator HAMSICONTEXT(HANDLE value) => new HAMSICONTEXT(value);

        public static explicit operator int(HAMSICONTEXT value) => (int)(value.Value);

        public static explicit operator uint(HAMSICONTEXT value) => (uint)(value.Value);

        public static implicit operator nint(HAMSICONTEXT value) => (nint)(value.Value);

        public static implicit operator nuint(HAMSICONTEXT value) => (nuint)(value.Value);

        public static implicit operator void*(HAMSICONTEXT value) => (void*)(value.Value);

        public static implicit operator HANDLE(HAMSICONTEXT value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HAMSICONTEXT other) && Equals(other);

        public bool Equals(HAMSICONTEXT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
