// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCMNOTIFICATION : IEquatable<HCMNOTIFICATION>
    {
        public readonly nint Value;

        public HCMNOTIFICATION(int value)
        {
            Value = ((nint)(value));
        }

        public HCMNOTIFICATION(uint value)
        {
            Value = ((nint)(value));
        }

        public HCMNOTIFICATION(nint value)
        {
            Value = ((nint)(value));
        }

        public HCMNOTIFICATION(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCMNOTIFICATION(void* value)
        {
            Value = ((nint)(value));
        }

        public HCMNOTIFICATION(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HCMNOTIFICATION left, HCMNOTIFICATION right) => left.Value == right.Value;

        public static bool operator !=(HCMNOTIFICATION left, HCMNOTIFICATION right) => left.Value != right.Value;

        public static explicit operator HCMNOTIFICATION(int value) => new HCMNOTIFICATION(value);

        public static explicit operator HCMNOTIFICATION(uint value) => new HCMNOTIFICATION(value);

        public static explicit operator HCMNOTIFICATION(nint value) => new HCMNOTIFICATION(value);

        public static explicit operator HCMNOTIFICATION(nuint value) => new HCMNOTIFICATION(value);

        public static explicit operator HCMNOTIFICATION(void* value) => new HCMNOTIFICATION(value);

        public static explicit operator HCMNOTIFICATION(HANDLE value) => new HCMNOTIFICATION(value);

        public static implicit operator int(HCMNOTIFICATION value) => (int)(value.Value);

        public static implicit operator uint(HCMNOTIFICATION value) => (uint)(value.Value);

        public static implicit operator nint(HCMNOTIFICATION value) => (nint)(value.Value);

        public static implicit operator nuint(HCMNOTIFICATION value) => (nuint)(value.Value);

        public static implicit operator void*(HCMNOTIFICATION value) => (void*)(value.Value);

        public static implicit operator HANDLE(HCMNOTIFICATION value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HCMNOTIFICATION other) && Equals(other);

        public bool Equals(HCMNOTIFICATION other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
