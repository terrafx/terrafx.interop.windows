// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSAVEDUILANGUAGES : IEquatable<HSAVEDUILANGUAGES>
    {
        public readonly nint Value;

        public static HSAVEDUILANGUAGES NULL => (HSAVEDUILANGUAGES)(0);

        public HSAVEDUILANGUAGES(int value)
        {
            Value = ((nint)(value));
        }

        public HSAVEDUILANGUAGES(uint value)
        {
            Value = ((nint)(value));
        }

        public HSAVEDUILANGUAGES(nint value)
        {
            Value = ((nint)(value));
        }

        public HSAVEDUILANGUAGES(nuint value)
        {
            Value = ((nint)(value));
        }

        public HSAVEDUILANGUAGES(void* value)
        {
            Value = ((nint)(value));
        }

        public HSAVEDUILANGUAGES(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HSAVEDUILANGUAGES left, HSAVEDUILANGUAGES right) => left.Value == right.Value;

        public static bool operator !=(HSAVEDUILANGUAGES left, HSAVEDUILANGUAGES right) => left.Value != right.Value;

        public static explicit operator HSAVEDUILANGUAGES(int value) => new HSAVEDUILANGUAGES(value);

        public static explicit operator HSAVEDUILANGUAGES(uint value) => new HSAVEDUILANGUAGES(value);

        public static explicit operator HSAVEDUILANGUAGES(nint value) => new HSAVEDUILANGUAGES(value);

        public static explicit operator HSAVEDUILANGUAGES(nuint value) => new HSAVEDUILANGUAGES(value);

        public static explicit operator HSAVEDUILANGUAGES(void* value) => new HSAVEDUILANGUAGES(value);

        public static explicit operator HSAVEDUILANGUAGES(HANDLE value) => new HSAVEDUILANGUAGES(value);

        public static implicit operator int(HSAVEDUILANGUAGES value) => (int)(value.Value);

        public static implicit operator uint(HSAVEDUILANGUAGES value) => (uint)(value.Value);

        public static implicit operator nint(HSAVEDUILANGUAGES value) => (nint)(value.Value);

        public static implicit operator nuint(HSAVEDUILANGUAGES value) => (nuint)(value.Value);

        public static implicit operator void*(HSAVEDUILANGUAGES value) => (void*)(value.Value);

        public static implicit operator HANDLE(HSAVEDUILANGUAGES value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HSAVEDUILANGUAGES other) && Equals(other);

        public bool Equals(HSAVEDUILANGUAGES other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
