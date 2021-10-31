// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HEMF : IEquatable<HEMF>
    {
        public readonly nint Value;

        public static HEMF NULL => (HEMF)(0);

        public HEMF(int value)
        {
            Value = ((nint)(value));
        }

        public HEMF(uint value)
        {
            Value = ((nint)(value));
        }

        public HEMF(nint value)
        {
            Value = ((nint)(value));
        }

        public HEMF(nuint value)
        {
            Value = ((nint)(value));
        }

        public HEMF(void* value)
        {
            Value = ((nint)(value));
        }

        public HEMF(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HEMF left, HEMF right) => left.Value == right.Value;

        public static bool operator !=(HEMF left, HEMF right) => left.Value != right.Value;

        public static explicit operator HEMF(int value) => new HEMF(value);

        public static explicit operator HEMF(uint value) => new HEMF(value);

        public static explicit operator HEMF(nint value) => new HEMF(value);

        public static explicit operator HEMF(nuint value) => new HEMF(value);

        public static explicit operator HEMF(void* value) => new HEMF(value);

        public static explicit operator HEMF(HANDLE value) => new HEMF(value);

        public static explicit operator int(HEMF value) => (int)(value.Value);

        public static explicit operator uint(HEMF value) => (uint)(value.Value);

        public static implicit operator nint(HEMF value) => (nint)(value.Value);

        public static implicit operator nuint(HEMF value) => (nuint)(value.Value);

        public static implicit operator void*(HEMF value) => (void*)(value.Value);

        public static implicit operator HANDLE(HEMF value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HEMF other) && Equals(other);

        public bool Equals(HEMF other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
