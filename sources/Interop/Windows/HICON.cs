// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HICON : IEquatable<HICON>
    {
        public readonly nint Value;

        public static HICON NULL => (HICON)(0);

        public HICON(int value)
        {
            Value = ((nint)(value));
        }

        public HICON(uint value)
        {
            Value = ((nint)(value));
        }

        public HICON(nint value)
        {
            Value = ((nint)(value));
        }

        public HICON(nuint value)
        {
            Value = ((nint)(value));
        }

        public HICON(void* value)
        {
            Value = ((nint)(value));
        }

        public HICON(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HICON left, HICON right) => left.Value == right.Value;

        public static bool operator !=(HICON left, HICON right) => left.Value != right.Value;

        public static explicit operator HICON(int value) => new HICON(value);

        public static explicit operator HICON(uint value) => new HICON(value);

        public static explicit operator HICON(nint value) => new HICON(value);

        public static explicit operator HICON(nuint value) => new HICON(value);

        public static explicit operator HICON(void* value) => new HICON(value);

        public static explicit operator HICON(HANDLE value) => new HICON(value);

        public static explicit operator int(HICON value) => (int)(value.Value);

        public static explicit operator uint(HICON value) => (uint)(value.Value);

        public static implicit operator nint(HICON value) => (nint)(value.Value);

        public static implicit operator nuint(HICON value) => (nuint)(value.Value);

        public static implicit operator void*(HICON value) => (void*)(value.Value);

        public static implicit operator HANDLE(HICON value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HICON other) && Equals(other);

        public bool Equals(HICON other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
