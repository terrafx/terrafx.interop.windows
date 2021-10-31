// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct ROPARAMIIDHANDLE : IEquatable<ROPARAMIIDHANDLE>
    {
        public readonly nint Value;

        public static ROPARAMIIDHANDLE NULL => (ROPARAMIIDHANDLE)(0);

        public ROPARAMIIDHANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public ROPARAMIIDHANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public ROPARAMIIDHANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public ROPARAMIIDHANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public ROPARAMIIDHANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public ROPARAMIIDHANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(ROPARAMIIDHANDLE left, ROPARAMIIDHANDLE right) => left.Value == right.Value;

        public static bool operator !=(ROPARAMIIDHANDLE left, ROPARAMIIDHANDLE right) => left.Value != right.Value;

        public static explicit operator ROPARAMIIDHANDLE(int value) => new ROPARAMIIDHANDLE(value);

        public static explicit operator ROPARAMIIDHANDLE(uint value) => new ROPARAMIIDHANDLE(value);

        public static explicit operator ROPARAMIIDHANDLE(nint value) => new ROPARAMIIDHANDLE(value);

        public static explicit operator ROPARAMIIDHANDLE(nuint value) => new ROPARAMIIDHANDLE(value);

        public static explicit operator ROPARAMIIDHANDLE(void* value) => new ROPARAMIIDHANDLE(value);

        public static explicit operator ROPARAMIIDHANDLE(HANDLE value) => new ROPARAMIIDHANDLE(value);

        public static explicit operator int(ROPARAMIIDHANDLE value) => (int)(value.Value);

        public static explicit operator uint(ROPARAMIIDHANDLE value) => (uint)(value.Value);

        public static implicit operator nint(ROPARAMIIDHANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(ROPARAMIIDHANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(ROPARAMIIDHANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(ROPARAMIIDHANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is ROPARAMIIDHANDLE other) && Equals(other);

        public bool Equals(ROPARAMIIDHANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
