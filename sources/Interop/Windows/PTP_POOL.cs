// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PTP_POOL : IEquatable<PTP_POOL>
    {
        public readonly void* Value;

        public PTP_POOL(int value)
        {
            Value = ((void*)(value));
        }

        public PTP_POOL(uint value)
        {
            Value = ((void*)(value));
        }

        public PTP_POOL(nint value)
        {
            Value = ((void*)(value));
        }

        public PTP_POOL(nuint value)
        {
            Value = ((void*)(value));
        }

        public PTP_POOL(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(PTP_POOL left, PTP_POOL right) => left.Value == right.Value;

        public static bool operator !=(PTP_POOL left, PTP_POOL right) => left.Value != right.Value;

        public static explicit operator PTP_POOL(int value) => new PTP_POOL(value);

        public static explicit operator PTP_POOL(uint value) => new PTP_POOL(value);

        public static explicit operator PTP_POOL(nint value) => new PTP_POOL(value);

        public static explicit operator PTP_POOL(nuint value) => new PTP_POOL(value);

        public static explicit operator PTP_POOL(void* value) => new PTP_POOL(value);

        public static explicit operator int(PTP_POOL value) => (int)(value.Value);

        public static explicit operator uint(PTP_POOL value) => (uint)(value.Value);

        public static implicit operator nint(PTP_POOL value) => (nint)(value.Value);

        public static implicit operator nuint(PTP_POOL value) => (nuint)(value.Value);

        public static implicit operator void*(PTP_POOL value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is PTP_POOL other) && Equals(other);

        public bool Equals(PTP_POOL other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
