// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMF : IEquatable<HMF>
    {
        public readonly nint Value;

        public static HMF NULL => (HMF)(0);

        public HMF(int value)
        {
            Value = ((nint)(value));
        }

        public HMF(uint value)
        {
            Value = ((nint)(value));
        }

        public HMF(nint value)
        {
            Value = ((nint)(value));
        }

        public HMF(nuint value)
        {
            Value = ((nint)(value));
        }

        public HMF(void* value)
        {
            Value = ((nint)(value));
        }

        public HMF(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HMF left, HMF right) => left.Value == right.Value;

        public static bool operator !=(HMF left, HMF right) => left.Value != right.Value;

        public static explicit operator HMF(int value) => new HMF(value);

        public static explicit operator HMF(uint value) => new HMF(value);

        public static explicit operator HMF(nint value) => new HMF(value);

        public static explicit operator HMF(nuint value) => new HMF(value);

        public static explicit operator HMF(void* value) => new HMF(value);

        public static explicit operator HMF(HANDLE value) => new HMF(value);

        public static implicit operator int(HMF value) => (int)(value.Value);

        public static implicit operator uint(HMF value) => (uint)(value.Value);

        public static implicit operator nint(HMF value) => (nint)(value.Value);

        public static implicit operator nuint(HMF value) => (nuint)(value.Value);

        public static implicit operator void*(HMF value) => (void*)(value.Value);

        public static implicit operator HANDLE(HMF value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HMF other) && Equals(other);

        public bool Equals(HMF other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
