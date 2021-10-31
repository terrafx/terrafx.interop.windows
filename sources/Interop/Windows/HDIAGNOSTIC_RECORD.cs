// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDIAGNOSTIC_RECORD : IEquatable<HDIAGNOSTIC_RECORD>
    {
        public readonly nint Value;

        public static HDIAGNOSTIC_RECORD NULL => (HDIAGNOSTIC_RECORD)(0);

        public HDIAGNOSTIC_RECORD(int value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_RECORD(uint value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_RECORD(nint value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_RECORD(nuint value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_RECORD(void* value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_RECORD(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HDIAGNOSTIC_RECORD left, HDIAGNOSTIC_RECORD right) => left.Value == right.Value;

        public static bool operator !=(HDIAGNOSTIC_RECORD left, HDIAGNOSTIC_RECORD right) => left.Value != right.Value;

        public static explicit operator HDIAGNOSTIC_RECORD(int value) => new HDIAGNOSTIC_RECORD(value);

        public static explicit operator HDIAGNOSTIC_RECORD(uint value) => new HDIAGNOSTIC_RECORD(value);

        public static explicit operator HDIAGNOSTIC_RECORD(nint value) => new HDIAGNOSTIC_RECORD(value);

        public static explicit operator HDIAGNOSTIC_RECORD(nuint value) => new HDIAGNOSTIC_RECORD(value);

        public static explicit operator HDIAGNOSTIC_RECORD(void* value) => new HDIAGNOSTIC_RECORD(value);

        public static explicit operator HDIAGNOSTIC_RECORD(HANDLE value) => new HDIAGNOSTIC_RECORD(value);

        public static implicit operator int(HDIAGNOSTIC_RECORD value) => (int)(value.Value);

        public static implicit operator uint(HDIAGNOSTIC_RECORD value) => (uint)(value.Value);

        public static implicit operator nint(HDIAGNOSTIC_RECORD value) => (nint)(value.Value);

        public static implicit operator nuint(HDIAGNOSTIC_RECORD value) => (nuint)(value.Value);

        public static implicit operator void*(HDIAGNOSTIC_RECORD value) => (void*)(value.Value);

        public static implicit operator HANDLE(HDIAGNOSTIC_RECORD value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HDIAGNOSTIC_RECORD other) && Equals(other);

        public bool Equals(HDIAGNOSTIC_RECORD other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
