// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWAVEOUT : IEquatable<HWAVEOUT>
    {
        public readonly nint Value;

        public HWAVEOUT(int value)
        {
            Value = ((nint)(value));
        }

        public HWAVEOUT(uint value)
        {
            Value = ((nint)(value));
        }

        public HWAVEOUT(nint value)
        {
            Value = ((nint)(value));
        }

        public HWAVEOUT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HWAVEOUT(void* value)
        {
            Value = ((nint)(value));
        }

        public HWAVEOUT(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HWAVEOUT left, HWAVEOUT right) => left.Value == right.Value;

        public static bool operator !=(HWAVEOUT left, HWAVEOUT right) => left.Value != right.Value;

        public static explicit operator HWAVEOUT(int value) => new HWAVEOUT(value);

        public static explicit operator HWAVEOUT(uint value) => new HWAVEOUT(value);

        public static explicit operator HWAVEOUT(nint value) => new HWAVEOUT(value);

        public static explicit operator HWAVEOUT(nuint value) => new HWAVEOUT(value);

        public static explicit operator HWAVEOUT(void* value) => new HWAVEOUT(value);

        public static explicit operator HWAVEOUT(HANDLE value) => new HWAVEOUT(value);

        public static implicit operator int(HWAVEOUT value) => (int)(value.Value);

        public static implicit operator uint(HWAVEOUT value) => (uint)(value.Value);

        public static implicit operator nint(HWAVEOUT value) => (nint)(value.Value);

        public static implicit operator nuint(HWAVEOUT value) => (nuint)(value.Value);

        public static implicit operator void*(HWAVEOUT value) => (void*)(value.Value);

        public static implicit operator HANDLE(HWAVEOUT value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HWAVEOUT other) && Equals(other);

        public bool Equals(HWAVEOUT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
