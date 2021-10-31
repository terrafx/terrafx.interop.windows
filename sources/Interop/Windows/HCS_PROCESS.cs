// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCS_PROCESS : IEquatable<HCS_PROCESS>
    {
        public readonly nint Value;

        public HCS_PROCESS(int value)
        {
            Value = ((nint)(value));
        }

        public HCS_PROCESS(uint value)
        {
            Value = ((nint)(value));
        }

        public HCS_PROCESS(nint value)
        {
            Value = ((nint)(value));
        }

        public HCS_PROCESS(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCS_PROCESS(void* value)
        {
            Value = ((nint)(value));
        }

        public HCS_PROCESS(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HCS_PROCESS left, HCS_PROCESS right) => left.Value == right.Value;

        public static bool operator !=(HCS_PROCESS left, HCS_PROCESS right) => left.Value != right.Value;

        public static explicit operator HCS_PROCESS(int value) => new HCS_PROCESS(value);

        public static explicit operator HCS_PROCESS(uint value) => new HCS_PROCESS(value);

        public static explicit operator HCS_PROCESS(nint value) => new HCS_PROCESS(value);

        public static explicit operator HCS_PROCESS(nuint value) => new HCS_PROCESS(value);

        public static explicit operator HCS_PROCESS(void* value) => new HCS_PROCESS(value);

        public static explicit operator HCS_PROCESS(HANDLE value) => new HCS_PROCESS(value);

        public static implicit operator int(HCS_PROCESS value) => (int)(value.Value);

        public static implicit operator uint(HCS_PROCESS value) => (uint)(value.Value);

        public static implicit operator nint(HCS_PROCESS value) => (nint)(value.Value);

        public static implicit operator nuint(HCS_PROCESS value) => (nuint)(value.Value);

        public static implicit operator void*(HCS_PROCESS value) => (void*)(value.Value);

        public static implicit operator HANDLE(HCS_PROCESS value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HCS_PROCESS other) && Equals(other);

        public bool Equals(HCS_PROCESS other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
