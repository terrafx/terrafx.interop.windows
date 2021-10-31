// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWND : IEquatable<HWND>
    {
        public readonly nint Value;

        public HWND(nint value)
        {
            Value = ((nint)(value));
        }

        public HWND(nuint value)
        {
            Value = ((nint)(value));
        }

        public HWND(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HWND left, HWND right) => left.Value == right.Value;

        public static bool operator !=(HWND left, HWND right) => left.Value != right.Value;

        public static explicit operator HWND(nint value) => new HWND(value);

        public static explicit operator HWND(nuint value) => new HWND(value);

        public static explicit operator HWND(void* value) => new HWND(value);

        public static implicit operator nint(HWND value) => (nint)(value.Value);

        public static implicit operator nuint(HWND value) => (nuint)(value.Value);

        public static implicit operator void*(HWND value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HWND other) && Equals(other);

        public bool Equals(HWND other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
