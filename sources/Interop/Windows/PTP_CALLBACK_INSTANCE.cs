// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PTP_CALLBACK_INSTANCE : IEquatable<PTP_CALLBACK_INSTANCE>
    {
        public readonly void* Value;

        public PTP_CALLBACK_INSTANCE(int value)
        {
            Value = ((void*)(value));
        }

        public PTP_CALLBACK_INSTANCE(uint value)
        {
            Value = ((void*)(value));
        }

        public PTP_CALLBACK_INSTANCE(nint value)
        {
            Value = ((void*)(value));
        }

        public PTP_CALLBACK_INSTANCE(nuint value)
        {
            Value = ((void*)(value));
        }

        public PTP_CALLBACK_INSTANCE(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(PTP_CALLBACK_INSTANCE left, PTP_CALLBACK_INSTANCE right) => left.Value == right.Value;

        public static bool operator !=(PTP_CALLBACK_INSTANCE left, PTP_CALLBACK_INSTANCE right) => left.Value != right.Value;

        public static explicit operator PTP_CALLBACK_INSTANCE(int value) => new PTP_CALLBACK_INSTANCE(value);

        public static explicit operator PTP_CALLBACK_INSTANCE(uint value) => new PTP_CALLBACK_INSTANCE(value);

        public static explicit operator PTP_CALLBACK_INSTANCE(nint value) => new PTP_CALLBACK_INSTANCE(value);

        public static explicit operator PTP_CALLBACK_INSTANCE(nuint value) => new PTP_CALLBACK_INSTANCE(value);

        public static explicit operator PTP_CALLBACK_INSTANCE(void* value) => new PTP_CALLBACK_INSTANCE(value);

        public static explicit operator int(PTP_CALLBACK_INSTANCE value) => (int)(value.Value);

        public static explicit operator uint(PTP_CALLBACK_INSTANCE value) => (uint)(value.Value);

        public static implicit operator nint(PTP_CALLBACK_INSTANCE value) => (nint)(value.Value);

        public static implicit operator nuint(PTP_CALLBACK_INSTANCE value) => (nuint)(value.Value);

        public static implicit operator void*(PTP_CALLBACK_INSTANCE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is PTP_CALLBACK_INSTANCE other) && Equals(other);

        public bool Equals(PTP_CALLBACK_INSTANCE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
