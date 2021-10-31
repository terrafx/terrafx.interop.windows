// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDIAGNOSTIC_DATA_QUERY_SESSION : IEquatable<HDIAGNOSTIC_DATA_QUERY_SESSION>
    {
        public readonly nint Value;

        public static HDIAGNOSTIC_DATA_QUERY_SESSION NULL => (HDIAGNOSTIC_DATA_QUERY_SESSION)(0);

        public HDIAGNOSTIC_DATA_QUERY_SESSION(int value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_DATA_QUERY_SESSION(uint value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_DATA_QUERY_SESSION(nint value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_DATA_QUERY_SESSION(nuint value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_DATA_QUERY_SESSION(void* value)
        {
            Value = ((nint)(value));
        }

        public HDIAGNOSTIC_DATA_QUERY_SESSION(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HDIAGNOSTIC_DATA_QUERY_SESSION left, HDIAGNOSTIC_DATA_QUERY_SESSION right) => left.Value == right.Value;

        public static bool operator !=(HDIAGNOSTIC_DATA_QUERY_SESSION left, HDIAGNOSTIC_DATA_QUERY_SESSION right) => left.Value != right.Value;

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(int value) => new HDIAGNOSTIC_DATA_QUERY_SESSION(value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(uint value) => new HDIAGNOSTIC_DATA_QUERY_SESSION(value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(nint value) => new HDIAGNOSTIC_DATA_QUERY_SESSION(value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(nuint value) => new HDIAGNOSTIC_DATA_QUERY_SESSION(value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(void* value) => new HDIAGNOSTIC_DATA_QUERY_SESSION(value);

        public static explicit operator HDIAGNOSTIC_DATA_QUERY_SESSION(HANDLE value) => new HDIAGNOSTIC_DATA_QUERY_SESSION(value);

        public static implicit operator int(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (int)(value.Value);

        public static implicit operator uint(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (uint)(value.Value);

        public static implicit operator nint(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (nint)(value.Value);

        public static implicit operator nuint(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (nuint)(value.Value);

        public static implicit operator void*(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (void*)(value.Value);

        public static implicit operator HANDLE(HDIAGNOSTIC_DATA_QUERY_SESSION value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HDIAGNOSTIC_DATA_QUERY_SESSION other) && Equals(other);

        public bool Equals(HDIAGNOSTIC_DATA_QUERY_SESSION other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
