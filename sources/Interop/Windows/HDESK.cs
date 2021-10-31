// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDESK : IEquatable<HDESK>
    {
        public readonly nint Value;

        public static HDESK NULL => (HDESK)(0);

        public HDESK(int value)
        {
            Value = ((nint)(value));
        }

        public HDESK(uint value)
        {
            Value = ((nint)(value));
        }

        public HDESK(nint value)
        {
            Value = ((nint)(value));
        }

        public HDESK(nuint value)
        {
            Value = ((nint)(value));
        }

        public HDESK(void* value)
        {
            Value = ((nint)(value));
        }

        public HDESK(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HDESK left, HDESK right) => left.Value == right.Value;

        public static bool operator !=(HDESK left, HDESK right) => left.Value != right.Value;

        public static explicit operator HDESK(int value) => new HDESK(value);

        public static explicit operator HDESK(uint value) => new HDESK(value);

        public static explicit operator HDESK(nint value) => new HDESK(value);

        public static explicit operator HDESK(nuint value) => new HDESK(value);

        public static explicit operator HDESK(void* value) => new HDESK(value);

        public static explicit operator HDESK(HANDLE value) => new HDESK(value);

        public static implicit operator int(HDESK value) => (int)(value.Value);

        public static implicit operator uint(HDESK value) => (uint)(value.Value);

        public static implicit operator nint(HDESK value) => (nint)(value.Value);

        public static implicit operator nuint(HDESK value) => (nuint)(value.Value);

        public static implicit operator void*(HDESK value) => (void*)(value.Value);

        public static implicit operator HANDLE(HDESK value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HDESK other) && Equals(other);

        public bool Equals(HDESK other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
