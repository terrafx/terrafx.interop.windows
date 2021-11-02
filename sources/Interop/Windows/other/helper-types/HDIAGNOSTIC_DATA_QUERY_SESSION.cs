// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDIAGNOSTIC_DATA_QUERY_SESSION : IEquatable<HDIAGNOSTIC_DATA_QUERY_SESSION>
    {
        public readonly nint Value;

        public HDIAGNOSTIC_DATA_QUERY_SESSION(nint value)
        {
            Value = value;
        }

        public static HDIAGNOSTIC_DATA_QUERY_SESSION INVALID_VALUE => new HDIAGNOSTIC_DATA_QUERY_SESSION(-1);

        public static HDIAGNOSTIC_DATA_QUERY_SESSION NULL => new HDIAGNOSTIC_DATA_QUERY_SESSION(0);

        public static bool operator ==(HDIAGNOSTIC_DATA_QUERY_SESSION left, HDIAGNOSTIC_DATA_QUERY_SESSION right) => left.Value == right.Value;

        public static bool operator !=(HDIAGNOSTIC_DATA_QUERY_SESSION left, HDIAGNOSTIC_DATA_QUERY_SESSION right) => left.Value != right.Value;

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(void* value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((nint)(value));

        public static implicit operator void*(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (void*)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(HANDLE value) => new HDIAGNOSTIC_DATA_QUERY_SESSION(value);

        public static implicit operator HANDLE(HDIAGNOSTIC_DATA_QUERY_SESSION value) => new HDIAGNOSTIC_DATA_QUERY_SESSION(value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(byte value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((nint)(value));

        public static explicit operator byte(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (byte)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(short value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((nint)(value));

        public static explicit operator short(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (short)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(int value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((nint)(value));

        public static explicit operator int(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (int)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(long value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((nint)(value));

        public static implicit operator long(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (long)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(nint value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((nint)(value));

        public static implicit operator nint(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (nint)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(sbyte value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((nint)(value));

        public static explicit operator sbyte(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (sbyte)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(ushort value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((nint)(value));

        public static explicit operator ushort(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (ushort)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(uint value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((nint)(value));

        public static explicit operator uint(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (uint)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(ulong value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((nint)(value));

        public static implicit operator ulong(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (ulong)(value.Value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(nuint value) => new HDIAGNOSTIC_DATA_QUERY_SESSION((nint)(value));

        public static explicit operator nuint(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HDIAGNOSTIC_DATA_QUERY_SESSION other) && Equals(other);

        public bool Equals(HDIAGNOSTIC_DATA_QUERY_SESSION other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
