// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct AUTHZ_ACCESS_CHECK_RESULTS_HANDLE : IEquatable<AUTHZ_ACCESS_CHECK_RESULTS_HANDLE>
    {
        public readonly nint Value;

        public AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(nint value)
        {
            Value = value;
        }

        public static AUTHZ_ACCESS_CHECK_RESULTS_HANDLE INVALID_HANDLE_VALUE => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(-1);

        public static AUTHZ_ACCESS_CHECK_RESULTS_HANDLE NULL => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(0);

        public static bool operator ==(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE left, AUTHZ_ACCESS_CHECK_RESULTS_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE left, AUTHZ_ACCESS_CHECK_RESULTS_HANDLE right) => left.Value != right.Value;

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(void* value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE((nint)(value));

        public static implicit operator void*(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (void*)(value.Value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(HANDLE value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(value);

        public static implicit operator HANDLE(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(byte value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE((nint)(value));

        public static explicit operator byte(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (byte)(value.Value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(short value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE((nint)(value));

        public static explicit operator short(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (short)(value.Value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(int value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE((nint)(value));

        public static explicit operator int(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (int)(value.Value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(long value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE((nint)(value));

        public static implicit operator long(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (long)(value.Value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(nint value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE((nint)(value));

        public static implicit operator nint(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (nint)(value.Value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(sbyte value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE((nint)(value));

        public static explicit operator sbyte(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(ushort value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE((nint)(value));

        public static explicit operator ushort(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (ushort)(value.Value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(uint value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE((nint)(value));

        public static explicit operator uint(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (uint)(value.Value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(ulong value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE((nint)(value));

        public static implicit operator ulong(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (ulong)(value.Value);

        public static explicit operator AUTHZ_ACCESS_CHECK_RESULTS_HANDLE(nuint value) => new AUTHZ_ACCESS_CHECK_RESULTS_HANDLE((nint)(value));

        public static explicit operator nuint(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is AUTHZ_ACCESS_CHECK_RESULTS_HANDLE other) && Equals(other);

        public bool Equals(AUTHZ_ACCESS_CHECK_RESULTS_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
