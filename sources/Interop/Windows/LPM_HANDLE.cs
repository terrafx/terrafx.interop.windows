// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct LPM_HANDLE : IEquatable<LPM_HANDLE>
    {
        public readonly nint Value;

        public LPM_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public LPM_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public LPM_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public LPM_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public LPM_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public LPM_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(LPM_HANDLE left, LPM_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(LPM_HANDLE left, LPM_HANDLE right) => left.Value != right.Value;

        public static explicit operator LPM_HANDLE(int value) => new LPM_HANDLE(value);

        public static explicit operator LPM_HANDLE(uint value) => new LPM_HANDLE(value);

        public static explicit operator LPM_HANDLE(nint value) => new LPM_HANDLE(value);

        public static explicit operator LPM_HANDLE(nuint value) => new LPM_HANDLE(value);

        public static explicit operator LPM_HANDLE(void* value) => new LPM_HANDLE(value);

        public static explicit operator LPM_HANDLE(HANDLE value) => new LPM_HANDLE(value);

        public static implicit operator int(LPM_HANDLE value) => (int)(value.Value);

        public static implicit operator uint(LPM_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(LPM_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(LPM_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(LPM_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(LPM_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is LPM_HANDLE other) && Equals(other);

        public bool Equals(LPM_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
