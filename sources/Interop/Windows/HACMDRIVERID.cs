// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HACMDRIVERID : IEquatable<HACMDRIVERID>
    {
        public readonly nint Value;

        public HACMDRIVERID(int value)
        {
            Value = ((nint)(value));
        }

        public HACMDRIVERID(uint value)
        {
            Value = ((nint)(value));
        }

        public HACMDRIVERID(nint value)
        {
            Value = ((nint)(value));
        }

        public HACMDRIVERID(nuint value)
        {
            Value = ((nint)(value));
        }

        public HACMDRIVERID(void* value)
        {
            Value = ((nint)(value));
        }

        public HACMDRIVERID(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HACMDRIVERID left, HACMDRIVERID right) => left.Value == right.Value;

        public static bool operator !=(HACMDRIVERID left, HACMDRIVERID right) => left.Value != right.Value;

        public static explicit operator HACMDRIVERID(int value) => new HACMDRIVERID(value);

        public static explicit operator HACMDRIVERID(uint value) => new HACMDRIVERID(value);

        public static explicit operator HACMDRIVERID(nint value) => new HACMDRIVERID(value);

        public static explicit operator HACMDRIVERID(nuint value) => new HACMDRIVERID(value);

        public static explicit operator HACMDRIVERID(void* value) => new HACMDRIVERID(value);

        public static explicit operator HACMDRIVERID(HANDLE value) => new HACMDRIVERID(value);

        public static implicit operator int(HACMDRIVERID value) => (int)(value.Value);

        public static implicit operator uint(HACMDRIVERID value) => (uint)(value.Value);

        public static implicit operator nint(HACMDRIVERID value) => (nint)(value.Value);

        public static implicit operator nuint(HACMDRIVERID value) => (nuint)(value.Value);

        public static implicit operator void*(HACMDRIVERID value) => (void*)(value.Value);

        public static implicit operator HANDLE(HACMDRIVERID value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HACMDRIVERID other) && Equals(other);

        public bool Equals(HACMDRIVERID other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
