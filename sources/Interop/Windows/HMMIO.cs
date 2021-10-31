// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMMIO : IEquatable<HMMIO>
    {
        public readonly nint Value;

        public static HMMIO NULL => (HMMIO)(0);

        public HMMIO(int value)
        {
            Value = ((nint)(value));
        }

        public HMMIO(uint value)
        {
            Value = ((nint)(value));
        }

        public HMMIO(nint value)
        {
            Value = ((nint)(value));
        }

        public HMMIO(nuint value)
        {
            Value = ((nint)(value));
        }

        public HMMIO(void* value)
        {
            Value = ((nint)(value));
        }

        public HMMIO(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HMMIO left, HMMIO right) => left.Value == right.Value;

        public static bool operator !=(HMMIO left, HMMIO right) => left.Value != right.Value;

        public static explicit operator HMMIO(int value) => new HMMIO(value);

        public static explicit operator HMMIO(uint value) => new HMMIO(value);

        public static explicit operator HMMIO(nint value) => new HMMIO(value);

        public static explicit operator HMMIO(nuint value) => new HMMIO(value);

        public static explicit operator HMMIO(void* value) => new HMMIO(value);

        public static explicit operator HMMIO(HANDLE value) => new HMMIO(value);

        public static explicit operator int(HMMIO value) => (int)(value.Value);

        public static explicit operator uint(HMMIO value) => (uint)(value.Value);

        public static implicit operator nint(HMMIO value) => (nint)(value.Value);

        public static implicit operator nuint(HMMIO value) => (nuint)(value.Value);

        public static implicit operator void*(HMMIO value) => (void*)(value.Value);

        public static implicit operator HANDLE(HMMIO value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HMMIO other) && Equals(other);

        public bool Equals(HMMIO other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
