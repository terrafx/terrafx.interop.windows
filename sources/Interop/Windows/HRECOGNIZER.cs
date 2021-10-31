// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRECOGNIZER : IEquatable<HRECOGNIZER>
    {
        public readonly nint Value;

        public static HRECOGNIZER NULL => (HRECOGNIZER)(0);

        public HRECOGNIZER(int value)
        {
            Value = ((nint)(value));
        }

        public HRECOGNIZER(uint value)
        {
            Value = ((nint)(value));
        }

        public HRECOGNIZER(nint value)
        {
            Value = ((nint)(value));
        }

        public HRECOGNIZER(nuint value)
        {
            Value = ((nint)(value));
        }

        public HRECOGNIZER(void* value)
        {
            Value = ((nint)(value));
        }

        public HRECOGNIZER(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HRECOGNIZER left, HRECOGNIZER right) => left.Value == right.Value;

        public static bool operator !=(HRECOGNIZER left, HRECOGNIZER right) => left.Value != right.Value;

        public static explicit operator HRECOGNIZER(int value) => new HRECOGNIZER(value);

        public static explicit operator HRECOGNIZER(uint value) => new HRECOGNIZER(value);

        public static explicit operator HRECOGNIZER(nint value) => new HRECOGNIZER(value);

        public static explicit operator HRECOGNIZER(nuint value) => new HRECOGNIZER(value);

        public static explicit operator HRECOGNIZER(void* value) => new HRECOGNIZER(value);

        public static explicit operator HRECOGNIZER(HANDLE value) => new HRECOGNIZER(value);

        public static explicit operator int(HRECOGNIZER value) => (int)(value.Value);

        public static explicit operator uint(HRECOGNIZER value) => (uint)(value.Value);

        public static implicit operator nint(HRECOGNIZER value) => (nint)(value.Value);

        public static implicit operator nuint(HRECOGNIZER value) => (nuint)(value.Value);

        public static implicit operator void*(HRECOGNIZER value) => (void*)(value.Value);

        public static implicit operator HANDLE(HRECOGNIZER value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HRECOGNIZER other) && Equals(other);

        public bool Equals(HRECOGNIZER other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
