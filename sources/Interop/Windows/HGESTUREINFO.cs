// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HGESTUREINFO : IEquatable<HGESTUREINFO>
    {
        public readonly nint Value;

        public HGESTUREINFO(nint value)
        {
            Value = value;
        }

        public static HGESTUREINFO INVALID_HANDLE_VALUE => new HGESTUREINFO(-1);

        public static HGESTUREINFO NULL => new HGESTUREINFO(0);

        public static bool operator ==(HGESTUREINFO left, HGESTUREINFO right) => left.Value == right.Value;

        public static bool operator !=(HGESTUREINFO left, HGESTUREINFO right) => left.Value != right.Value;

        public static explicit operator HGESTUREINFO(void* value) => new HGESTUREINFO((nint)(value));

        public static implicit operator void*(HGESTUREINFO value) => (void*)(value.Value);

        public static explicit operator HGESTUREINFO(HANDLE value) => new HGESTUREINFO(value);

        public static implicit operator HANDLE(HGESTUREINFO value) => new HGESTUREINFO(value);

        public static explicit operator HGESTUREINFO(byte value) => new HGESTUREINFO((nint)(value));

        public static implicit operator byte(HGESTUREINFO value) => (byte)(value.Value);

        public static explicit operator HGESTUREINFO(short value) => new HGESTUREINFO((nint)(value));

        public static implicit operator short(HGESTUREINFO value) => (short)(value.Value);

        public static explicit operator HGESTUREINFO(int value) => new HGESTUREINFO((nint)(value));

        public static implicit operator int(HGESTUREINFO value) => (int)(value.Value);

        public static explicit operator HGESTUREINFO(long value) => new HGESTUREINFO((nint)(value));

        public static explicit operator long(HGESTUREINFO value) => (long)(value.Value);

        public static explicit operator HGESTUREINFO(nint value) => new HGESTUREINFO((nint)(value));

        public static implicit operator nint(HGESTUREINFO value) => (nint)(value.Value);

        public static explicit operator HGESTUREINFO(sbyte value) => new HGESTUREINFO((nint)(value));

        public static implicit operator sbyte(HGESTUREINFO value) => (sbyte)(value.Value);

        public static explicit operator HGESTUREINFO(ushort value) => new HGESTUREINFO((nint)(value));

        public static implicit operator ushort(HGESTUREINFO value) => (ushort)(value.Value);

        public static explicit operator HGESTUREINFO(uint value) => new HGESTUREINFO((nint)(value));

        public static implicit operator uint(HGESTUREINFO value) => (uint)(value.Value);

        public static explicit operator HGESTUREINFO(ulong value) => new HGESTUREINFO((nint)(value));

        public static explicit operator ulong(HGESTUREINFO value) => (ulong)(value.Value);

        public static explicit operator HGESTUREINFO(nuint value) => new HGESTUREINFO((nint)(value));

        public static explicit operator nuint(HGESTUREINFO value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HGESTUREINFO other) && Equals(other);

        public bool Equals(HGESTUREINFO other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
