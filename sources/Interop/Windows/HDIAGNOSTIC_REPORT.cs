// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDIAGNOSTIC_REPORT : IEquatable<HDIAGNOSTIC_REPORT>
    {
        public readonly nint Value;

        public static HDIAGNOSTIC_REPORT NULL => (HDIAGNOSTIC_REPORT)(0);

        public HDIAGNOSTIC_REPORT(int value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_REPORT(uint value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_REPORT(nint value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_REPORT(nuint value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_REPORT(void* value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_REPORT(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HDIAGNOSTIC_REPORT left, HDIAGNOSTIC_REPORT right) => left.Value == right.Value;

        public static bool operator !=(HDIAGNOSTIC_REPORT left, HDIAGNOSTIC_REPORT right) => left.Value != right.Value;

        public static explicit operator HDIAGNOSTIC_REPORT(int value) => new HDIAGNOSTIC_REPORT(value);

        public static explicit operator HDIAGNOSTIC_REPORT(uint value) => new HDIAGNOSTIC_REPORT(value);

        public static explicit operator HDIAGNOSTIC_REPORT(nint value) => new HDIAGNOSTIC_REPORT(value);

        public static explicit operator HDIAGNOSTIC_REPORT(nuint value) => new HDIAGNOSTIC_REPORT(value);

        public static explicit operator HDIAGNOSTIC_REPORT(void* value) => new HDIAGNOSTIC_REPORT(value);

        public static explicit operator HDIAGNOSTIC_REPORT(HANDLE value) => new HDIAGNOSTIC_REPORT(value);

        public static implicit operator int(HDIAGNOSTIC_REPORT value) => (int)(value.Value);

        public static implicit operator uint(HDIAGNOSTIC_REPORT value) => (uint)(value.Value);

        public static implicit operator nint(HDIAGNOSTIC_REPORT value) => (nint)(value.Value);

        public static implicit operator nuint(HDIAGNOSTIC_REPORT value) => (nuint)(value.Value);

        public static implicit operator void*(HDIAGNOSTIC_REPORT value) => (void*)(value.Value);

        public static implicit operator HANDLE(HDIAGNOSTIC_REPORT value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HDIAGNOSTIC_REPORT other) && Equals(other);

        public bool Equals(HDIAGNOSTIC_REPORT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
