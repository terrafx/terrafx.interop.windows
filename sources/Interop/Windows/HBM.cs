// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBM : IEquatable<HBM>
    {
        public readonly nint Value;

        public HBM(int value)
        {
            Value = ((nint)(value));
        }

        public HBM(uint value)
        {
            Value = ((nint)(value));
        }

        public HBM(nint value)
        {
            Value = ((nint)(value));
        }

        public HBM(nuint value)
        {
            Value = ((nint)(value));
        }

        public HBM(void* value)
        {
            Value = ((nint)(value));
        }

        public HBM(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HBM left, HBM right) => left.Value == right.Value;

        public static bool operator !=(HBM left, HBM right) => left.Value != right.Value;

        public static explicit operator HBM(int value) => new HBM(value);

        public static explicit operator HBM(uint value) => new HBM(value);

        public static explicit operator HBM(nint value) => new HBM(value);

        public static explicit operator HBM(nuint value) => new HBM(value);

        public static explicit operator HBM(void* value) => new HBM(value);

        public static explicit operator HBM(HANDLE value) => new HBM(value);

        public static implicit operator int(HBM value) => (int)(value.Value);

        public static implicit operator uint(HBM value) => (uint)(value.Value);

        public static implicit operator nint(HBM value) => (nint)(value.Value);

        public static implicit operator nuint(HBM value) => (nuint)(value.Value);

        public static implicit operator void*(HBM value) => (void*)(value.Value);

        public static implicit operator HANDLE(HBM value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HBM other) && Equals(other);

        public bool Equals(HBM other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
