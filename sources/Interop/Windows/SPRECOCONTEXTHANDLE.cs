// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPRECOCONTEXTHANDLE : IEquatable<SPRECOCONTEXTHANDLE>
    {
        public readonly nint Value;

        public static SPRECOCONTEXTHANDLE NULL => (SPRECOCONTEXTHANDLE)(0);

        public SPRECOCONTEXTHANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public SPRECOCONTEXTHANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public SPRECOCONTEXTHANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public SPRECOCONTEXTHANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public SPRECOCONTEXTHANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public SPRECOCONTEXTHANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(SPRECOCONTEXTHANDLE left, SPRECOCONTEXTHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPRECOCONTEXTHANDLE left, SPRECOCONTEXTHANDLE right) => left.Value != right.Value;

        public static explicit operator SPRECOCONTEXTHANDLE(int value) => new SPRECOCONTEXTHANDLE(value);

        public static explicit operator SPRECOCONTEXTHANDLE(uint value) => new SPRECOCONTEXTHANDLE(value);

        public static explicit operator SPRECOCONTEXTHANDLE(nint value) => new SPRECOCONTEXTHANDLE(value);

        public static explicit operator SPRECOCONTEXTHANDLE(nuint value) => new SPRECOCONTEXTHANDLE(value);

        public static explicit operator SPRECOCONTEXTHANDLE(void* value) => new SPRECOCONTEXTHANDLE(value);

        public static explicit operator SPRECOCONTEXTHANDLE(HANDLE value) => new SPRECOCONTEXTHANDLE(value);

        public static explicit operator int(SPRECOCONTEXTHANDLE value) => (int)(value.Value);

        public static explicit operator uint(SPRECOCONTEXTHANDLE value) => (uint)(value.Value);

        public static implicit operator nint(SPRECOCONTEXTHANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(SPRECOCONTEXTHANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(SPRECOCONTEXTHANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(SPRECOCONTEXTHANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is SPRECOCONTEXTHANDLE other) && Equals(other);

        public bool Equals(SPRECOCONTEXTHANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
