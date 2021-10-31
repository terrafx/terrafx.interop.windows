// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCS_SYSTEM : IEquatable<HCS_SYSTEM>
    {
        public readonly nint Value;

        public HCS_SYSTEM(int value)
        {
            Value = ((nint)(value));
        }

        public HCS_SYSTEM(uint value)
        {
            Value = ((nint)(value));
        }

        public HCS_SYSTEM(nint value)
        {
            Value = ((nint)(value));
        }

        public HCS_SYSTEM(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCS_SYSTEM(void* value)
        {
            Value = ((nint)(value));
        }

        public HCS_SYSTEM(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HCS_SYSTEM left, HCS_SYSTEM right) => left.Value == right.Value;

        public static bool operator !=(HCS_SYSTEM left, HCS_SYSTEM right) => left.Value != right.Value;

        public static explicit operator HCS_SYSTEM(int value) => new HCS_SYSTEM(value);

        public static explicit operator HCS_SYSTEM(uint value) => new HCS_SYSTEM(value);

        public static explicit operator HCS_SYSTEM(nint value) => new HCS_SYSTEM(value);

        public static explicit operator HCS_SYSTEM(nuint value) => new HCS_SYSTEM(value);

        public static explicit operator HCS_SYSTEM(void* value) => new HCS_SYSTEM(value);

        public static explicit operator HCS_SYSTEM(HANDLE value) => new HCS_SYSTEM(value);

        public static implicit operator int(HCS_SYSTEM value) => (int)(value.Value);

        public static implicit operator uint(HCS_SYSTEM value) => (uint)(value.Value);

        public static implicit operator nint(HCS_SYSTEM value) => (nint)(value.Value);

        public static implicit operator nuint(HCS_SYSTEM value) => (nuint)(value.Value);

        public static implicit operator void*(HCS_SYSTEM value) => (void*)(value.Value);

        public static implicit operator HANDLE(HCS_SYSTEM value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HCS_SYSTEM other) && Equals(other);

        public bool Equals(HCS_SYSTEM other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
