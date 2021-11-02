// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION : IEquatable<HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION>
    {
        public readonly nint Value;

        public HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(nint value)
        {
            Value = value;
        }

        public static HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION INVALID_VALUE => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(-1);

        public static HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION NULL => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(0);

        public static bool operator ==(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION left, HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION right) => left.Value == right.Value;

        public static bool operator !=(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION left, HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION right) => left.Value != right.Value;

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(void* value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION((nint)(value));

        public static implicit operator void*(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (void*)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(HANDLE value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(value);

        public static implicit operator HANDLE(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(byte value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION((nint)(value));

        public static explicit operator byte(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (byte)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(short value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION((nint)(value));

        public static explicit operator short(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (short)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(int value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION((nint)(value));

        public static explicit operator int(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (int)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(long value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION((nint)(value));

        public static implicit operator long(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (long)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(nint value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION((nint)(value));

        public static implicit operator nint(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (nint)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(sbyte value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION((nint)(value));

        public static explicit operator sbyte(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (sbyte)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(ushort value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION((nint)(value));

        public static explicit operator ushort(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (ushort)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(uint value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION((nint)(value));

        public static explicit operator uint(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (uint)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(ulong value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION((nint)(value));

        public static implicit operator ulong(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (ulong)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(nuint value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION((nint)(value));

        public static explicit operator nuint(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION other) && Equals(other);

        public bool Equals(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
