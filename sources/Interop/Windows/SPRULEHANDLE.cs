// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPRULEHANDLE : IEquatable<SPRULEHANDLE>
    {
        public readonly nint Value;

        public SPRULEHANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public SPRULEHANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public SPRULEHANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public SPRULEHANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public SPRULEHANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public SPRULEHANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(SPRULEHANDLE left, SPRULEHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPRULEHANDLE left, SPRULEHANDLE right) => left.Value != right.Value;

        public static explicit operator SPRULEHANDLE(int value) => new SPRULEHANDLE(value);

        public static explicit operator SPRULEHANDLE(uint value) => new SPRULEHANDLE(value);

        public static explicit operator SPRULEHANDLE(nint value) => new SPRULEHANDLE(value);

        public static explicit operator SPRULEHANDLE(nuint value) => new SPRULEHANDLE(value);

        public static explicit operator SPRULEHANDLE(void* value) => new SPRULEHANDLE(value);

        public static explicit operator SPRULEHANDLE(HANDLE value) => new SPRULEHANDLE(value);

        public static implicit operator int(SPRULEHANDLE value) => (int)(value.Value);

        public static implicit operator uint(SPRULEHANDLE value) => (uint)(value.Value);

        public static implicit operator nint(SPRULEHANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(SPRULEHANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(SPRULEHANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(SPRULEHANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is SPRULEHANDLE other) && Equals(other);

        public bool Equals(SPRULEHANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
