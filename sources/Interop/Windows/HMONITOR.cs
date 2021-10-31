// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMONITOR : IEquatable<HMONITOR>
    {
        public readonly nint Value;

        public static HMONITOR NULL => (HMONITOR)(0);

        public HMONITOR(int value)
        {
            Value = ((nint)(value));
        }

        public HMONITOR(uint value)
        {
            Value = ((nint)(value));
        }

        public HMONITOR(nint value)
        {
            Value = ((nint)(value));
        }

        public HMONITOR(nuint value)
        {
            Value = ((nint)(value));
        }

        public HMONITOR(void* value)
        {
            Value = ((nint)(value));
        }

        public HMONITOR(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HMONITOR left, HMONITOR right) => left.Value == right.Value;

        public static bool operator !=(HMONITOR left, HMONITOR right) => left.Value != right.Value;

        public static explicit operator HMONITOR(int value) => new HMONITOR(value);

        public static explicit operator HMONITOR(uint value) => new HMONITOR(value);

        public static explicit operator HMONITOR(nint value) => new HMONITOR(value);

        public static explicit operator HMONITOR(nuint value) => new HMONITOR(value);

        public static explicit operator HMONITOR(void* value) => new HMONITOR(value);

        public static explicit operator HMONITOR(HANDLE value) => new HMONITOR(value);

        public static implicit operator int(HMONITOR value) => (int)(value.Value);

        public static implicit operator uint(HMONITOR value) => (uint)(value.Value);

        public static implicit operator nint(HMONITOR value) => (nint)(value.Value);

        public static implicit operator nuint(HMONITOR value) => (nuint)(value.Value);

        public static implicit operator void*(HMONITOR value) => (void*)(value.Value);

        public static implicit operator HANDLE(HMONITOR value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HMONITOR other) && Equals(other);

        public bool Equals(HMONITOR other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
