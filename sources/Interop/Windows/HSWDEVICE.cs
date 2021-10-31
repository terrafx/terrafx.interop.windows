// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSWDEVICE : IEquatable<HSWDEVICE>
    {
        public readonly nint Value;

        public static HSWDEVICE NULL => (HSWDEVICE)(0);

        public HSWDEVICE(int value)
        {
            Value = ((nint)(value));
        }

        public HSWDEVICE(uint value)
        {
            Value = ((nint)(value));
        }

        public HSWDEVICE(nint value)
        {
            Value = ((nint)(value));
        }

        public HSWDEVICE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HSWDEVICE(void* value)
        {
            Value = ((nint)(value));
        }

        public HSWDEVICE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HSWDEVICE left, HSWDEVICE right) => left.Value == right.Value;

        public static bool operator !=(HSWDEVICE left, HSWDEVICE right) => left.Value != right.Value;

        public static explicit operator HSWDEVICE(int value) => new HSWDEVICE(value);

        public static explicit operator HSWDEVICE(uint value) => new HSWDEVICE(value);

        public static explicit operator HSWDEVICE(nint value) => new HSWDEVICE(value);

        public static explicit operator HSWDEVICE(nuint value) => new HSWDEVICE(value);

        public static explicit operator HSWDEVICE(void* value) => new HSWDEVICE(value);

        public static explicit operator HSWDEVICE(HANDLE value) => new HSWDEVICE(value);

        public static implicit operator int(HSWDEVICE value) => (int)(value.Value);

        public static implicit operator uint(HSWDEVICE value) => (uint)(value.Value);

        public static implicit operator nint(HSWDEVICE value) => (nint)(value.Value);

        public static implicit operator nuint(HSWDEVICE value) => (nuint)(value.Value);

        public static implicit operator void*(HSWDEVICE value) => (void*)(value.Value);

        public static implicit operator HANDLE(HSWDEVICE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HSWDEVICE other) && Equals(other);

        public bool Equals(HSWDEVICE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
