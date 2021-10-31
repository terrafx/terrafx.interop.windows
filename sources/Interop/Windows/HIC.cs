// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HIC : IEquatable<HIC>
    {
        public readonly nint Value;

        public static HIC NULL => (HIC)(0);

        public HIC(int value)
        {
            Value = ((nint)(value));
        }

        public HIC(uint value)
        {
            Value = ((nint)(value));
        }

        public HIC(nint value)
        {
            Value = ((nint)(value));
        }

        public HIC(nuint value)
        {
            Value = ((nint)(value));
        }

        public HIC(void* value)
        {
            Value = ((nint)(value));
        }

        public HIC(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HIC left, HIC right) => left.Value == right.Value;

        public static bool operator !=(HIC left, HIC right) => left.Value != right.Value;

        public static explicit operator HIC(int value) => new HIC(value);

        public static explicit operator HIC(uint value) => new HIC(value);

        public static explicit operator HIC(nint value) => new HIC(value);

        public static explicit operator HIC(nuint value) => new HIC(value);

        public static explicit operator HIC(void* value) => new HIC(value);

        public static explicit operator HIC(HANDLE value) => new HIC(value);

        public static implicit operator int(HIC value) => (int)(value.Value);

        public static implicit operator uint(HIC value) => (uint)(value.Value);

        public static implicit operator nint(HIC value) => (nint)(value.Value);

        public static implicit operator nuint(HIC value) => (nuint)(value.Value);

        public static implicit operator void*(HIC value) => (void*)(value.Value);

        public static implicit operator HANDLE(HIC value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HIC other) && Equals(other);

        public bool Equals(HIC other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
