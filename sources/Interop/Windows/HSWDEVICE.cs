// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSWDEVICE : IEquatable<HSWDEVICE>
    {
        public readonly nint Value;

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

        public static bool operator ==(HSWDEVICE left, HSWDEVICE right) => left.Value == right.Value;

        public static bool operator !=(HSWDEVICE left, HSWDEVICE right) => left.Value != right.Value;

        public static explicit operator HSWDEVICE(nint value) => new HSWDEVICE(value);

        public static explicit operator HSWDEVICE(nuint value) => new HSWDEVICE(value);

        public static explicit operator HSWDEVICE(void* value) => new HSWDEVICE(value);

        public static implicit operator nint(HSWDEVICE value) => (nint)(value.Value);

        public static implicit operator nuint(HSWDEVICE value) => (nuint)(value.Value);

        public static implicit operator void*(HSWDEVICE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HSWDEVICE other) && Equals(other);

        public bool Equals(HSWDEVICE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
