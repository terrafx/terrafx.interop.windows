// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMETAFILE : IEquatable<HMETAFILE>
    {
        public readonly nint Value;

        public HMETAFILE(int value)
        {
            Value = ((nint)(value));
        }

        public HMETAFILE(uint value)
        {
            Value = ((nint)(value));
        }

        public HMETAFILE(nint value)
        {
            Value = ((nint)(value));
        }

        public HMETAFILE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HMETAFILE(void* value)
        {
            Value = ((nint)(value));
        }

        public HMETAFILE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HMETAFILE left, HMETAFILE right) => left.Value == right.Value;

        public static bool operator !=(HMETAFILE left, HMETAFILE right) => left.Value != right.Value;

        public static explicit operator HMETAFILE(int value) => new HMETAFILE(value);

        public static explicit operator HMETAFILE(uint value) => new HMETAFILE(value);

        public static explicit operator HMETAFILE(nint value) => new HMETAFILE(value);

        public static explicit operator HMETAFILE(nuint value) => new HMETAFILE(value);

        public static explicit operator HMETAFILE(void* value) => new HMETAFILE(value);

        public static explicit operator HMETAFILE(HANDLE value) => new HMETAFILE(value);

        public static implicit operator int(HMETAFILE value) => (int)(value.Value);

        public static implicit operator uint(HMETAFILE value) => (uint)(value.Value);

        public static implicit operator nint(HMETAFILE value) => (nint)(value.Value);

        public static implicit operator nuint(HMETAFILE value) => (nuint)(value.Value);

        public static implicit operator void*(HMETAFILE value) => (void*)(value.Value);

        public static implicit operator HANDLE(HMETAFILE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HMETAFILE other) && Equals(other);

        public bool Equals(HMETAFILE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
