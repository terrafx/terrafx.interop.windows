// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION : IEquatable<HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION>
    {
        public readonly nint Value;

        public HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(int value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(uint value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(nint value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(nuint value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(void* value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION left, HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION right) => left.Value == right.Value;

        public static bool operator !=(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION left, HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION right) => left.Value != right.Value;

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(int value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(uint value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(nint value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(nuint value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(void* value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(value);

        public static explicit operator HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(HANDLE value) => new HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION(value);

        public static implicit operator int(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (int)(value.Value);

        public static implicit operator uint(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (uint)(value.Value);

        public static implicit operator nint(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (nint)(value.Value);

        public static implicit operator nuint(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (nuint)(value.Value);

        public static implicit operator void*(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (void*)(value.Value);

        public static implicit operator HANDLE(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION other) && Equals(other);

        public bool Equals(HDIAGNOSTIC_EVENT_PRODUCER_DESCRIPTION other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
