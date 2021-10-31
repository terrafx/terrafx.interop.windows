// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HHEADERROW : IEquatable<HHEADERROW>
    {
        public readonly nint Value;

        public static HHEADERROW NULL => (HHEADERROW)(0);

        public HHEADERROW(int value)
        {
            Value = ((nint)(value));
        }

        public HHEADERROW(uint value)
        {
            Value = ((nint)(value));
        }

        public HHEADERROW(nint value)
        {
            Value = ((nint)(value));
        }

        public HHEADERROW(nuint value)
        {
            Value = ((nint)(value));
        }

        public HHEADERROW(void* value)
        {
            Value = ((nint)(value));
        }

        public HHEADERROW(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HHEADERROW left, HHEADERROW right) => left.Value == right.Value;

        public static bool operator !=(HHEADERROW left, HHEADERROW right) => left.Value != right.Value;

        public static explicit operator HHEADERROW(int value) => new HHEADERROW(value);

        public static explicit operator HHEADERROW(uint value) => new HHEADERROW(value);

        public static explicit operator HHEADERROW(nint value) => new HHEADERROW(value);

        public static explicit operator HHEADERROW(nuint value) => new HHEADERROW(value);

        public static explicit operator HHEADERROW(void* value) => new HHEADERROW(value);

        public static explicit operator HHEADERROW(HANDLE value) => new HHEADERROW(value);

        public static implicit operator int(HHEADERROW value) => (int)(value.Value);

        public static implicit operator uint(HHEADERROW value) => (uint)(value.Value);

        public static implicit operator nint(HHEADERROW value) => (nint)(value.Value);

        public static implicit operator nuint(HHEADERROW value) => (nuint)(value.Value);

        public static implicit operator void*(HHEADERROW value) => (void*)(value.Value);

        public static implicit operator HANDLE(HHEADERROW value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HHEADERROW other) && Equals(other);

        public bool Equals(HHEADERROW other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
