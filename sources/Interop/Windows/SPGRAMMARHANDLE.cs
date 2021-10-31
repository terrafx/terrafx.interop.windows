// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPGRAMMARHANDLE : IEquatable<SPGRAMMARHANDLE>
    {
        public readonly nint Value;

        public static SPGRAMMARHANDLE NULL => (SPGRAMMARHANDLE)(0);

        public SPGRAMMARHANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public SPGRAMMARHANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public SPGRAMMARHANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public SPGRAMMARHANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public SPGRAMMARHANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public SPGRAMMARHANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Value != right.Value;

        public static explicit operator SPGRAMMARHANDLE(int value) => new SPGRAMMARHANDLE(value);

        public static explicit operator SPGRAMMARHANDLE(uint value) => new SPGRAMMARHANDLE(value);

        public static explicit operator SPGRAMMARHANDLE(nint value) => new SPGRAMMARHANDLE(value);

        public static explicit operator SPGRAMMARHANDLE(nuint value) => new SPGRAMMARHANDLE(value);

        public static explicit operator SPGRAMMARHANDLE(void* value) => new SPGRAMMARHANDLE(value);

        public static explicit operator SPGRAMMARHANDLE(HANDLE value) => new SPGRAMMARHANDLE(value);

        public static explicit operator int(SPGRAMMARHANDLE value) => (int)(value.Value);

        public static explicit operator uint(SPGRAMMARHANDLE value) => (uint)(value.Value);

        public static implicit operator nint(SPGRAMMARHANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(SPGRAMMARHANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(SPGRAMMARHANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(SPGRAMMARHANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is SPGRAMMARHANDLE other) && Equals(other);

        public bool Equals(SPGRAMMARHANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
