// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPWORDHANDLE : IEquatable<SPWORDHANDLE>
    {
        public readonly nint Value;

        public SPWORDHANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public SPWORDHANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public SPWORDHANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public SPWORDHANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public SPWORDHANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public SPWORDHANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(SPWORDHANDLE left, SPWORDHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPWORDHANDLE left, SPWORDHANDLE right) => left.Value != right.Value;

        public static explicit operator SPWORDHANDLE(int value) => new SPWORDHANDLE(value);

        public static explicit operator SPWORDHANDLE(uint value) => new SPWORDHANDLE(value);

        public static explicit operator SPWORDHANDLE(nint value) => new SPWORDHANDLE(value);

        public static explicit operator SPWORDHANDLE(nuint value) => new SPWORDHANDLE(value);

        public static explicit operator SPWORDHANDLE(void* value) => new SPWORDHANDLE(value);

        public static explicit operator SPWORDHANDLE(HANDLE value) => new SPWORDHANDLE(value);

        public static implicit operator int(SPWORDHANDLE value) => (int)(value.Value);

        public static implicit operator uint(SPWORDHANDLE value) => (uint)(value.Value);

        public static implicit operator nint(SPWORDHANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(SPWORDHANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(SPWORDHANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(SPWORDHANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is SPWORDHANDLE other) && Equals(other);

        public bool Equals(SPWORDHANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
