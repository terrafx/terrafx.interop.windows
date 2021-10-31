// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct RHANDLE : IEquatable<RHANDLE>
    {
        public readonly nint Value;

        public RHANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public RHANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public RHANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public RHANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public RHANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public RHANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(RHANDLE left, RHANDLE right) => left.Value == right.Value;

        public static bool operator !=(RHANDLE left, RHANDLE right) => left.Value != right.Value;

        public static explicit operator RHANDLE(int value) => new RHANDLE(value);

        public static explicit operator RHANDLE(uint value) => new RHANDLE(value);

        public static explicit operator RHANDLE(nint value) => new RHANDLE(value);

        public static explicit operator RHANDLE(nuint value) => new RHANDLE(value);

        public static explicit operator RHANDLE(void* value) => new RHANDLE(value);

        public static explicit operator RHANDLE(HANDLE value) => new RHANDLE(value);

        public static implicit operator int(RHANDLE value) => (int)(value.Value);

        public static implicit operator uint(RHANDLE value) => (uint)(value.Value);

        public static implicit operator nint(RHANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(RHANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(RHANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(RHANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is RHANDLE other) && Equals(other);

        public bool Equals(RHANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
