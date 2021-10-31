// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HINTERACTIONCONTEXT : IEquatable<HINTERACTIONCONTEXT>
    {
        public readonly nint Value;

        public static HINTERACTIONCONTEXT NULL => (HINTERACTIONCONTEXT)(0);

        public HINTERACTIONCONTEXT(int value)
        {
            Value = ((nint)(value));
        }

        public HINTERACTIONCONTEXT(uint value)
        {
            Value = ((nint)(value));
        }

        public HINTERACTIONCONTEXT(nint value)
        {
            Value = ((nint)(value));
        }

        public HINTERACTIONCONTEXT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HINTERACTIONCONTEXT(void* value)
        {
            Value = ((nint)(value));
        }

        public HINTERACTIONCONTEXT(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) => left.Value == right.Value;

        public static bool operator !=(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) => left.Value != right.Value;

        public static explicit operator HINTERACTIONCONTEXT(int value) => new HINTERACTIONCONTEXT(value);

        public static explicit operator HINTERACTIONCONTEXT(uint value) => new HINTERACTIONCONTEXT(value);

        public static explicit operator HINTERACTIONCONTEXT(nint value) => new HINTERACTIONCONTEXT(value);

        public static explicit operator HINTERACTIONCONTEXT(nuint value) => new HINTERACTIONCONTEXT(value);

        public static explicit operator HINTERACTIONCONTEXT(void* value) => new HINTERACTIONCONTEXT(value);

        public static explicit operator HINTERACTIONCONTEXT(HANDLE value) => new HINTERACTIONCONTEXT(value);

        public static explicit operator int(HINTERACTIONCONTEXT value) => (int)(value.Value);

        public static explicit operator uint(HINTERACTIONCONTEXT value) => (uint)(value.Value);

        public static implicit operator nint(HINTERACTIONCONTEXT value) => (nint)(value.Value);

        public static implicit operator nuint(HINTERACTIONCONTEXT value) => (nuint)(value.Value);

        public static implicit operator void*(HINTERACTIONCONTEXT value) => (void*)(value.Value);

        public static implicit operator HANDLE(HINTERACTIONCONTEXT value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HINTERACTIONCONTEXT other) && Equals(other);

        public bool Equals(HINTERACTIONCONTEXT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
