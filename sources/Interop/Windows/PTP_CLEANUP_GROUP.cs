// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PTP_CLEANUP_GROUP : IEquatable<PTP_CLEANUP_GROUP>
    {
        public readonly void* Value;

        public PTP_CLEANUP_GROUP(int value)
        {
            Value = ((void*)(value));
        }

        public PTP_CLEANUP_GROUP(uint value)
        {
            Value = ((void*)(value));
        }

        public PTP_CLEANUP_GROUP(nint value)
        {
            Value = ((void*)(value));
        }

        public PTP_CLEANUP_GROUP(nuint value)
        {
            Value = ((void*)(value));
        }

        public PTP_CLEANUP_GROUP(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(PTP_CLEANUP_GROUP left, PTP_CLEANUP_GROUP right) => left.Value == right.Value;

        public static bool operator !=(PTP_CLEANUP_GROUP left, PTP_CLEANUP_GROUP right) => left.Value != right.Value;

        public static explicit operator PTP_CLEANUP_GROUP(int value) => new PTP_CLEANUP_GROUP(value);

        public static explicit operator PTP_CLEANUP_GROUP(uint value) => new PTP_CLEANUP_GROUP(value);

        public static explicit operator PTP_CLEANUP_GROUP(nint value) => new PTP_CLEANUP_GROUP(value);

        public static explicit operator PTP_CLEANUP_GROUP(nuint value) => new PTP_CLEANUP_GROUP(value);

        public static explicit operator PTP_CLEANUP_GROUP(void* value) => new PTP_CLEANUP_GROUP(value);

        public static explicit operator int(PTP_CLEANUP_GROUP value) => (int)(value.Value);

        public static explicit operator uint(PTP_CLEANUP_GROUP value) => (uint)(value.Value);

        public static implicit operator nint(PTP_CLEANUP_GROUP value) => (nint)(value.Value);

        public static implicit operator nuint(PTP_CLEANUP_GROUP value) => (nuint)(value.Value);

        public static implicit operator void*(PTP_CLEANUP_GROUP value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is PTP_CLEANUP_GROUP other) && Equals(other);

        public bool Equals(PTP_CLEANUP_GROUP other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
