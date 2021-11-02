// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PACKAGE_INFO_REFERENCE : IEquatable<PACKAGE_INFO_REFERENCE>
    {
        public readonly nint Value;

        public PACKAGE_INFO_REFERENCE(nint value)
        {
            Value = value;
        }

        public static PACKAGE_INFO_REFERENCE NULL => new PACKAGE_INFO_REFERENCE(0);

        public static bool operator ==(PACKAGE_INFO_REFERENCE left, PACKAGE_INFO_REFERENCE right) => left.Value == right.Value;

        public static bool operator !=(PACKAGE_INFO_REFERENCE left, PACKAGE_INFO_REFERENCE right) => left.Value != right.Value;

        public static explicit operator PACKAGE_INFO_REFERENCE(void* value) => new PACKAGE_INFO_REFERENCE((nint)(value));

        public static implicit operator void*(PACKAGE_INFO_REFERENCE value) => (void*)(value.Value);

        public static explicit operator PACKAGE_INFO_REFERENCE(byte value) => new PACKAGE_INFO_REFERENCE((nint)(value));

        public static implicit operator byte(PACKAGE_INFO_REFERENCE value) => (byte)(value.Value);

        public static explicit operator PACKAGE_INFO_REFERENCE(short value) => new PACKAGE_INFO_REFERENCE((nint)(value));

        public static implicit operator short(PACKAGE_INFO_REFERENCE value) => (short)(value.Value);

        public static explicit operator PACKAGE_INFO_REFERENCE(int value) => new PACKAGE_INFO_REFERENCE((nint)(value));

        public static implicit operator int(PACKAGE_INFO_REFERENCE value) => (int)(value.Value);

        public static explicit operator PACKAGE_INFO_REFERENCE(long value) => new PACKAGE_INFO_REFERENCE((nint)(value));

        public static explicit operator long(PACKAGE_INFO_REFERENCE value) => (long)(value.Value);

        public static explicit operator PACKAGE_INFO_REFERENCE(nint value) => new PACKAGE_INFO_REFERENCE((nint)(value));

        public static implicit operator nint(PACKAGE_INFO_REFERENCE value) => (nint)(value.Value);

        public static explicit operator PACKAGE_INFO_REFERENCE(sbyte value) => new PACKAGE_INFO_REFERENCE((nint)(value));

        public static implicit operator sbyte(PACKAGE_INFO_REFERENCE value) => (sbyte)(value.Value);

        public static explicit operator PACKAGE_INFO_REFERENCE(ushort value) => new PACKAGE_INFO_REFERENCE((nint)(value));

        public static implicit operator ushort(PACKAGE_INFO_REFERENCE value) => (ushort)(value.Value);

        public static explicit operator PACKAGE_INFO_REFERENCE(uint value) => new PACKAGE_INFO_REFERENCE((nint)(value));

        public static implicit operator uint(PACKAGE_INFO_REFERENCE value) => (uint)(value.Value);

        public static explicit operator PACKAGE_INFO_REFERENCE(ulong value) => new PACKAGE_INFO_REFERENCE((nint)(value));

        public static explicit operator ulong(PACKAGE_INFO_REFERENCE value) => (ulong)(value.Value);

        public static explicit operator PACKAGE_INFO_REFERENCE(nuint value) => new PACKAGE_INFO_REFERENCE((nint)(value));

        public static explicit operator nuint(PACKAGE_INFO_REFERENCE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is PACKAGE_INFO_REFERENCE other) && Equals(other);

        public bool Equals(PACKAGE_INFO_REFERENCE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
