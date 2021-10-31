// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBODY : IEquatable<HBODY>
    {
        public readonly nint Value;

        public static HBODY NULL => (HBODY)(0);

        public HBODY(int value)
        {
            Value = ((nint)(value));
        }

        public HBODY(uint value)
        {
            Value = ((nint)(value));
        }

        public HBODY(nint value)
        {
            Value = ((nint)(value));
        }

        public HBODY(nuint value)
        {
            Value = ((nint)(value));
        }

        public HBODY(void* value)
        {
            Value = ((nint)(value));
        }

        public HBODY(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HBODY left, HBODY right) => left.Value == right.Value;

        public static bool operator !=(HBODY left, HBODY right) => left.Value != right.Value;

        public static explicit operator HBODY(int value) => new HBODY(value);

        public static explicit operator HBODY(uint value) => new HBODY(value);

        public static explicit operator HBODY(nint value) => new HBODY(value);

        public static explicit operator HBODY(nuint value) => new HBODY(value);

        public static explicit operator HBODY(void* value) => new HBODY(value);

        public static explicit operator HBODY(HANDLE value) => new HBODY(value);

        public static explicit operator int(HBODY value) => (int)(value.Value);

        public static explicit operator uint(HBODY value) => (uint)(value.Value);

        public static implicit operator nint(HBODY value) => (nint)(value.Value);

        public static implicit operator nuint(HBODY value) => (nuint)(value.Value);

        public static implicit operator void*(HBODY value) => (void*)(value.Value);

        public static implicit operator HANDLE(HBODY value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HBODY other) && Equals(other);

        public bool Equals(HBODY other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
