// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MachineGlobalObjectTableRegistrationToken : IEquatable<MachineGlobalObjectTableRegistrationToken>
    {
        public readonly void* Value;

        public MachineGlobalObjectTableRegistrationToken(int value)
        {
            Value = ((void*)(value));
        }

        public MachineGlobalObjectTableRegistrationToken(uint value)
        {
            Value = ((void*)(value));
        }

        public MachineGlobalObjectTableRegistrationToken(nint value)
        {
            Value = ((void*)(value));
        }

        public MachineGlobalObjectTableRegistrationToken(nuint value)
        {
            Value = ((void*)(value));
        }

        public MachineGlobalObjectTableRegistrationToken(void* value)
        {
            Value = ((void*)(value));
        }

        public static bool operator ==(MachineGlobalObjectTableRegistrationToken left, MachineGlobalObjectTableRegistrationToken right) => left.Value == right.Value;

        public static bool operator !=(MachineGlobalObjectTableRegistrationToken left, MachineGlobalObjectTableRegistrationToken right) => left.Value != right.Value;

        public static explicit operator MachineGlobalObjectTableRegistrationToken(int value) => new MachineGlobalObjectTableRegistrationToken(value);

        public static explicit operator MachineGlobalObjectTableRegistrationToken(uint value) => new MachineGlobalObjectTableRegistrationToken(value);

        public static explicit operator MachineGlobalObjectTableRegistrationToken(nint value) => new MachineGlobalObjectTableRegistrationToken(value);

        public static explicit operator MachineGlobalObjectTableRegistrationToken(nuint value) => new MachineGlobalObjectTableRegistrationToken(value);

        public static explicit operator MachineGlobalObjectTableRegistrationToken(void* value) => new MachineGlobalObjectTableRegistrationToken(value);

        public static explicit operator int(MachineGlobalObjectTableRegistrationToken value) => (int)(value.Value);

        public static explicit operator uint(MachineGlobalObjectTableRegistrationToken value) => (uint)(value.Value);

        public static implicit operator nint(MachineGlobalObjectTableRegistrationToken value) => (nint)(value.Value);

        public static implicit operator nuint(MachineGlobalObjectTableRegistrationToken value) => (nuint)(value.Value);

        public static implicit operator void*(MachineGlobalObjectTableRegistrationToken value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is MachineGlobalObjectTableRegistrationToken other) && Equals(other);

        public bool Equals(MachineGlobalObjectTableRegistrationToken other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
