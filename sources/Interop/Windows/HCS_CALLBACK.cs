// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCS_CALLBACK : IEquatable<HCS_CALLBACK>
    {
        public readonly nint Value;

        public static HCS_CALLBACK NULL => (HCS_CALLBACK)(0);

        public HCS_CALLBACK(int value)
        {
            Value = ((nint)(value));
        }

        public HCS_CALLBACK(uint value)
        {
            Value = ((nint)(value));
        }

        public HCS_CALLBACK(nint value)
        {
            Value = ((nint)(value));
        }

        public HCS_CALLBACK(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCS_CALLBACK(void* value)
        {
            Value = ((nint)(value));
        }

        public HCS_CALLBACK(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HCS_CALLBACK left, HCS_CALLBACK right) => left.Value == right.Value;

        public static bool operator !=(HCS_CALLBACK left, HCS_CALLBACK right) => left.Value != right.Value;

        public static explicit operator HCS_CALLBACK(int value) => new HCS_CALLBACK(value);

        public static explicit operator HCS_CALLBACK(uint value) => new HCS_CALLBACK(value);

        public static explicit operator HCS_CALLBACK(nint value) => new HCS_CALLBACK(value);

        public static explicit operator HCS_CALLBACK(nuint value) => new HCS_CALLBACK(value);

        public static explicit operator HCS_CALLBACK(void* value) => new HCS_CALLBACK(value);

        public static explicit operator HCS_CALLBACK(HANDLE value) => new HCS_CALLBACK(value);

        public static explicit operator int(HCS_CALLBACK value) => (int)(value.Value);

        public static explicit operator uint(HCS_CALLBACK value) => (uint)(value.Value);

        public static implicit operator nint(HCS_CALLBACK value) => (nint)(value.Value);

        public static implicit operator nuint(HCS_CALLBACK value) => (nuint)(value.Value);

        public static implicit operator void*(HCS_CALLBACK value) => (void*)(value.Value);

        public static implicit operator HANDLE(HCS_CALLBACK value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HCS_CALLBACK other) && Equals(other);

        public bool Equals(HCS_CALLBACK other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
