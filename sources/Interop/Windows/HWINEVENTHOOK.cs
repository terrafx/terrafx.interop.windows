// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWINEVENTHOOK : IEquatable<HWINEVENTHOOK>
    {
        public readonly nint Value;

        public static HWINEVENTHOOK NULL => (HWINEVENTHOOK)(0);

        public HWINEVENTHOOK(int value)
        {
            Value = ((nint)(value));
        }

        public HWINEVENTHOOK(uint value)
        {
            Value = ((nint)(value));
        }

        public HWINEVENTHOOK(nint value)
        {
            Value = ((nint)(value));
        }

        public HWINEVENTHOOK(nuint value)
        {
            Value = ((nint)(value));
        }

        public HWINEVENTHOOK(void* value)
        {
            Value = ((nint)(value));
        }

        public HWINEVENTHOOK(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HWINEVENTHOOK left, HWINEVENTHOOK right) => left.Value == right.Value;

        public static bool operator !=(HWINEVENTHOOK left, HWINEVENTHOOK right) => left.Value != right.Value;

        public static explicit operator HWINEVENTHOOK(int value) => new HWINEVENTHOOK(value);

        public static explicit operator HWINEVENTHOOK(uint value) => new HWINEVENTHOOK(value);

        public static explicit operator HWINEVENTHOOK(nint value) => new HWINEVENTHOOK(value);

        public static explicit operator HWINEVENTHOOK(nuint value) => new HWINEVENTHOOK(value);

        public static explicit operator HWINEVENTHOOK(void* value) => new HWINEVENTHOOK(value);

        public static explicit operator HWINEVENTHOOK(HANDLE value) => new HWINEVENTHOOK(value);

        public static implicit operator int(HWINEVENTHOOK value) => (int)(value.Value);

        public static implicit operator uint(HWINEVENTHOOK value) => (uint)(value.Value);

        public static implicit operator nint(HWINEVENTHOOK value) => (nint)(value.Value);

        public static implicit operator nuint(HWINEVENTHOOK value) => (nuint)(value.Value);

        public static implicit operator void*(HWINEVENTHOOK value) => (void*)(value.Value);

        public static implicit operator HANDLE(HWINEVENTHOOK value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HWINEVENTHOOK other) && Equals(other);

        public bool Equals(HWINEVENTHOOK other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
