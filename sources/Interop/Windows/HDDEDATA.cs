// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDDEDATA : IEquatable<HDDEDATA>
    {
        public readonly nint Value;

        public static HDDEDATA NULL => (HDDEDATA)(0);

        public HDDEDATA(int value)
        {
            Value = ((nint)(value));
        }

        public HDDEDATA(uint value)
        {
            Value = ((nint)(value));
        }

        public HDDEDATA(nint value)
        {
            Value = ((nint)(value));
        }

        public HDDEDATA(nuint value)
        {
            Value = ((nint)(value));
        }

        public HDDEDATA(void* value)
        {
            Value = ((nint)(value));
        }

        public HDDEDATA(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HDDEDATA left, HDDEDATA right) => left.Value == right.Value;

        public static bool operator !=(HDDEDATA left, HDDEDATA right) => left.Value != right.Value;

        public static explicit operator HDDEDATA(int value) => new HDDEDATA(value);

        public static explicit operator HDDEDATA(uint value) => new HDDEDATA(value);

        public static explicit operator HDDEDATA(nint value) => new HDDEDATA(value);

        public static explicit operator HDDEDATA(nuint value) => new HDDEDATA(value);

        public static explicit operator HDDEDATA(void* value) => new HDDEDATA(value);

        public static explicit operator HDDEDATA(HANDLE value) => new HDDEDATA(value);

        public static explicit operator int(HDDEDATA value) => (int)(value.Value);

        public static explicit operator uint(HDDEDATA value) => (uint)(value.Value);

        public static implicit operator nint(HDDEDATA value) => (nint)(value.Value);

        public static implicit operator nuint(HDDEDATA value) => (nuint)(value.Value);

        public static implicit operator void*(HDDEDATA value) => (void*)(value.Value);

        public static implicit operator HANDLE(HDDEDATA value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HDDEDATA other) && Equals(other);

        public bool Equals(HDDEDATA other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
