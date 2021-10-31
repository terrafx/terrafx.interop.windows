// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HFONT : IEquatable<HFONT>
    {
        public readonly nint Value;

        public static HFONT NULL => (HFONT)(0);

        public HFONT(int value)
        {
            Value = ((nint)(value));
        }

        public HFONT(uint value)
        {
            Value = ((nint)(value));
        }

        public HFONT(nint value)
        {
            Value = ((nint)(value));
        }

        public HFONT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HFONT(void* value)
        {
            Value = ((nint)(value));
        }

        public HFONT(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HFONT left, HFONT right) => left.Value == right.Value;

        public static bool operator !=(HFONT left, HFONT right) => left.Value != right.Value;

        public static explicit operator HFONT(int value) => new HFONT(value);

        public static explicit operator HFONT(uint value) => new HFONT(value);

        public static explicit operator HFONT(nint value) => new HFONT(value);

        public static explicit operator HFONT(nuint value) => new HFONT(value);

        public static explicit operator HFONT(void* value) => new HFONT(value);

        public static explicit operator HFONT(HANDLE value) => new HFONT(value);

        public static explicit operator int(HFONT value) => (int)(value.Value);

        public static explicit operator uint(HFONT value) => (uint)(value.Value);

        public static implicit operator nint(HFONT value) => (nint)(value.Value);

        public static implicit operator nuint(HFONT value) => (nuint)(value.Value);

        public static implicit operator void*(HFONT value) => (void*)(value.Value);

        public static implicit operator HANDLE(HFONT value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HFONT other) && Equals(other);

        public bool Equals(HFONT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
