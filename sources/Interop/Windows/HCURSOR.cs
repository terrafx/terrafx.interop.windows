// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCURSOR : IEquatable<HCURSOR>
    {
        public readonly nint Value;

        public static HCURSOR NULL => (HCURSOR)(0);

        public HCURSOR(int value)
        {
            Value = ((nint)(value));
        }

        public HCURSOR(uint value)
        {
            Value = ((nint)(value));
        }

        public HCURSOR(nint value)
        {
            Value = ((nint)(value));
        }

        public HCURSOR(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCURSOR(void* value)
        {
            Value = ((nint)(value));
        }

        public HCURSOR(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HCURSOR left, HCURSOR right) => left.Value == right.Value;

        public static bool operator !=(HCURSOR left, HCURSOR right) => left.Value != right.Value;

        public static explicit operator HCURSOR(int value) => new HCURSOR(value);

        public static explicit operator HCURSOR(uint value) => new HCURSOR(value);

        public static explicit operator HCURSOR(nint value) => new HCURSOR(value);

        public static explicit operator HCURSOR(nuint value) => new HCURSOR(value);

        public static explicit operator HCURSOR(void* value) => new HCURSOR(value);

        public static explicit operator HCURSOR(HANDLE value) => new HCURSOR(value);

        public static explicit operator int(HCURSOR value) => (int)(value.Value);

        public static explicit operator uint(HCURSOR value) => (uint)(value.Value);

        public static implicit operator nint(HCURSOR value) => (nint)(value.Value);

        public static implicit operator nuint(HCURSOR value) => (nuint)(value.Value);

        public static implicit operator void*(HCURSOR value) => (void*)(value.Value);

        public static implicit operator HANDLE(HCURSOR value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HCURSOR other) && Equals(other);

        public bool Equals(HCURSOR other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
