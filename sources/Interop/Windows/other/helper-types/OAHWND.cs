// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct OAHWND : IEquatable<OAHWND>
    {
        public readonly nint Value;

        public OAHWND(nint value)
        {
            Value = value;
        }

        public static OAHWND NULL => new OAHWND(0);

        public static bool operator ==(OAHWND left, OAHWND right) => left.Value == right.Value;

        public static bool operator !=(OAHWND left, OAHWND right) => left.Value != right.Value;

        public static explicit operator OAHWND(void* value) => new OAHWND((nint)(value));

        public static implicit operator void*(OAHWND value) => (void*)(value.Value);

        public static explicit operator OAHWND(byte value) => new OAHWND((nint)(value));

        public static implicit operator byte(OAHWND value) => (byte)(value.Value);

        public static explicit operator OAHWND(short value) => new OAHWND((nint)(value));

        public static implicit operator short(OAHWND value) => (short)(value.Value);

        public static explicit operator OAHWND(int value) => new OAHWND((nint)(value));

        public static implicit operator int(OAHWND value) => (int)(value.Value);

        public static explicit operator OAHWND(long value) => new OAHWND((nint)(value));

        public static explicit operator long(OAHWND value) => (long)(value.Value);

        public static explicit operator OAHWND(nint value) => new OAHWND((nint)(value));

        public static implicit operator nint(OAHWND value) => (nint)(value.Value);

        public static explicit operator OAHWND(sbyte value) => new OAHWND((nint)(value));

        public static implicit operator sbyte(OAHWND value) => (sbyte)(value.Value);

        public static explicit operator OAHWND(ushort value) => new OAHWND((nint)(value));

        public static implicit operator ushort(OAHWND value) => (ushort)(value.Value);

        public static explicit operator OAHWND(uint value) => new OAHWND((nint)(value));

        public static implicit operator uint(OAHWND value) => (uint)(value.Value);

        public static explicit operator OAHWND(ulong value) => new OAHWND((nint)(value));

        public static explicit operator ulong(OAHWND value) => (ulong)(value.Value);

        public static explicit operator OAHWND(nuint value) => new OAHWND((nint)(value));

        public static explicit operator nuint(OAHWND value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is OAHWND other) && Equals(other);

        public bool Equals(OAHWND other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
