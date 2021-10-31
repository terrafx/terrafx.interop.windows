// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCS_OPERATION : IEquatable<HCS_OPERATION>
    {
        public readonly nint Value;

        public static HCS_OPERATION NULL => (HCS_OPERATION)(0);

        public HCS_OPERATION(int value)
        {
            Value = ((nint)(value));
        }

        public HCS_OPERATION(uint value)
        {
            Value = ((nint)(value));
        }

        public HCS_OPERATION(nint value)
        {
            Value = ((nint)(value));
        }

        public HCS_OPERATION(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCS_OPERATION(void* value)
        {
            Value = ((nint)(value));
        }

        public HCS_OPERATION(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HCS_OPERATION left, HCS_OPERATION right) => left.Value == right.Value;

        public static bool operator !=(HCS_OPERATION left, HCS_OPERATION right) => left.Value != right.Value;

        public static explicit operator HCS_OPERATION(int value) => new HCS_OPERATION(value);

        public static explicit operator HCS_OPERATION(uint value) => new HCS_OPERATION(value);

        public static explicit operator HCS_OPERATION(nint value) => new HCS_OPERATION(value);

        public static explicit operator HCS_OPERATION(nuint value) => new HCS_OPERATION(value);

        public static explicit operator HCS_OPERATION(void* value) => new HCS_OPERATION(value);

        public static explicit operator HCS_OPERATION(HANDLE value) => new HCS_OPERATION(value);

        public static explicit operator int(HCS_OPERATION value) => (int)(value.Value);

        public static explicit operator uint(HCS_OPERATION value) => (uint)(value.Value);

        public static implicit operator nint(HCS_OPERATION value) => (nint)(value.Value);

        public static implicit operator nuint(HCS_OPERATION value) => (nuint)(value.Value);

        public static implicit operator void*(HCS_OPERATION value) => (void*)(value.Value);

        public static implicit operator HANDLE(HCS_OPERATION value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HCS_OPERATION other) && Equals(other);

        public bool Equals(HCS_OPERATION other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
