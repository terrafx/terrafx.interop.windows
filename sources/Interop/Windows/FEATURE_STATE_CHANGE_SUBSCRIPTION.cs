// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct FEATURE_STATE_CHANGE_SUBSCRIPTION : IEquatable<FEATURE_STATE_CHANGE_SUBSCRIPTION>
    {
        public readonly nint Value;

        public FEATURE_STATE_CHANGE_SUBSCRIPTION(int value)
        {
            Value = ((nint)(value));
        }

        public FEATURE_STATE_CHANGE_SUBSCRIPTION(uint value)
        {
            Value = ((nint)(value));
        }

        public FEATURE_STATE_CHANGE_SUBSCRIPTION(nint value)
        {
            Value = ((nint)(value));
        }

        public FEATURE_STATE_CHANGE_SUBSCRIPTION(nuint value)
        {
            Value = ((nint)(value));
        }

        public FEATURE_STATE_CHANGE_SUBSCRIPTION(void* value)
        {
            Value = ((nint)(value));
        }

        public FEATURE_STATE_CHANGE_SUBSCRIPTION(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(FEATURE_STATE_CHANGE_SUBSCRIPTION left, FEATURE_STATE_CHANGE_SUBSCRIPTION right) => left.Value == right.Value;

        public static bool operator !=(FEATURE_STATE_CHANGE_SUBSCRIPTION left, FEATURE_STATE_CHANGE_SUBSCRIPTION right) => left.Value != right.Value;

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(int value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION(value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(uint value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION(value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(nint value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION(value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(nuint value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION(value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(void* value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION(value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(HANDLE value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION(value);

        public static implicit operator int(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (int)(value.Value);

        public static implicit operator uint(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (uint)(value.Value);

        public static implicit operator nint(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (nint)(value.Value);

        public static implicit operator nuint(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (nuint)(value.Value);

        public static implicit operator void*(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (void*)(value.Value);

        public static implicit operator HANDLE(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is FEATURE_STATE_CHANGE_SUBSCRIPTION other) && Equals(other);

        public bool Equals(FEATURE_STATE_CHANGE_SUBSCRIPTION other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
