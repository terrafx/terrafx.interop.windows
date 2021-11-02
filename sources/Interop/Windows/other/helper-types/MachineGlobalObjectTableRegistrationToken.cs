// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MachineGlobalObjectTableRegistrationToken : IComparable, IComparable<MachineGlobalObjectTableRegistrationToken>, IEquatable<MachineGlobalObjectTableRegistrationToken>, IFormattable
    {
        public readonly nint Value;

        public MachineGlobalObjectTableRegistrationToken(nint value)
        {
            Value = value;
        }

        public static MachineGlobalObjectTableRegistrationToken NULL => new MachineGlobalObjectTableRegistrationToken(0);

        public static bool operator ==(MachineGlobalObjectTableRegistrationToken left, MachineGlobalObjectTableRegistrationToken right) => left.Value == right.Value;

        public static bool operator !=(MachineGlobalObjectTableRegistrationToken left, MachineGlobalObjectTableRegistrationToken right) => left.Value != right.Value;

        public static bool operator <(MachineGlobalObjectTableRegistrationToken left, MachineGlobalObjectTableRegistrationToken right) => left.Value < right.Value;

        public static bool operator <=(MachineGlobalObjectTableRegistrationToken left, MachineGlobalObjectTableRegistrationToken right) => left.Value <= right.Value;

        public static bool operator >(MachineGlobalObjectTableRegistrationToken left, MachineGlobalObjectTableRegistrationToken right) => left.Value > right.Value;

        public static bool operator >=(MachineGlobalObjectTableRegistrationToken left, MachineGlobalObjectTableRegistrationToken right) => left.Value >= right.Value;

        public static explicit operator MachineGlobalObjectTableRegistrationToken(void* value) => new MachineGlobalObjectTableRegistrationToken((nint)(value));

        public static implicit operator void*(MachineGlobalObjectTableRegistrationToken value) => (void*)(value.Value);

        public static explicit operator MachineGlobalObjectTableRegistrationToken(byte value) => new MachineGlobalObjectTableRegistrationToken((nint)(value));

        public static explicit operator byte(MachineGlobalObjectTableRegistrationToken value) => (byte)(value.Value);

        public static explicit operator MachineGlobalObjectTableRegistrationToken(short value) => new MachineGlobalObjectTableRegistrationToken((nint)(value));

        public static explicit operator short(MachineGlobalObjectTableRegistrationToken value) => (short)(value.Value);

        public static explicit operator MachineGlobalObjectTableRegistrationToken(int value) => new MachineGlobalObjectTableRegistrationToken((nint)(value));

        public static explicit operator int(MachineGlobalObjectTableRegistrationToken value) => (int)(value.Value);

        public static explicit operator MachineGlobalObjectTableRegistrationToken(long value) => new MachineGlobalObjectTableRegistrationToken((nint)(value));

        public static implicit operator long(MachineGlobalObjectTableRegistrationToken value) => value.Value;

        public static explicit operator MachineGlobalObjectTableRegistrationToken(nint value) => new MachineGlobalObjectTableRegistrationToken((nint)(value));

        public static implicit operator nint(MachineGlobalObjectTableRegistrationToken value) => value.Value;

        public static explicit operator MachineGlobalObjectTableRegistrationToken(sbyte value) => new MachineGlobalObjectTableRegistrationToken((nint)(value));

        public static explicit operator sbyte(MachineGlobalObjectTableRegistrationToken value) => (sbyte)(value.Value);

        public static explicit operator MachineGlobalObjectTableRegistrationToken(ushort value) => new MachineGlobalObjectTableRegistrationToken((nint)(value));

        public static explicit operator ushort(MachineGlobalObjectTableRegistrationToken value) => (ushort)(value.Value);

        public static explicit operator MachineGlobalObjectTableRegistrationToken(uint value) => new MachineGlobalObjectTableRegistrationToken((nint)(value));

        public static explicit operator uint(MachineGlobalObjectTableRegistrationToken value) => (uint)(value.Value);

        public static explicit operator MachineGlobalObjectTableRegistrationToken(ulong value) => new MachineGlobalObjectTableRegistrationToken((nint)(value));

        public static explicit operator ulong(MachineGlobalObjectTableRegistrationToken value) => (ulong)(value.Value);

        public static explicit operator MachineGlobalObjectTableRegistrationToken(nuint value) => new MachineGlobalObjectTableRegistrationToken((nint)(value));

        public static explicit operator nuint(MachineGlobalObjectTableRegistrationToken value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is MachineGlobalObjectTableRegistrationToken other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of MachineGlobalObjectTableRegistrationToken.");
        }

        public int CompareTo(MachineGlobalObjectTableRegistrationToken other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is MachineGlobalObjectTableRegistrationToken other) && Equals(other);

        public bool Equals(MachineGlobalObjectTableRegistrationToken other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
