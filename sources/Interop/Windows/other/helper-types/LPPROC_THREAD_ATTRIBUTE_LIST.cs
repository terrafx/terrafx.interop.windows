// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct LPPROC_THREAD_ATTRIBUTE_LIST : IEquatable<LPPROC_THREAD_ATTRIBUTE_LIST>
    {
        public readonly nint Value;

        public LPPROC_THREAD_ATTRIBUTE_LIST(nint value)
        {
            Value = value;
        }

        public static LPPROC_THREAD_ATTRIBUTE_LIST NULL => new LPPROC_THREAD_ATTRIBUTE_LIST(0);

        public static bool operator ==(LPPROC_THREAD_ATTRIBUTE_LIST left, LPPROC_THREAD_ATTRIBUTE_LIST right) => left.Value == right.Value;

        public static bool operator !=(LPPROC_THREAD_ATTRIBUTE_LIST left, LPPROC_THREAD_ATTRIBUTE_LIST right) => left.Value != right.Value;

        public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(void* value) => new LPPROC_THREAD_ATTRIBUTE_LIST((nint)(value));

        public static implicit operator void*(LPPROC_THREAD_ATTRIBUTE_LIST value) => (void*)(value.Value);

        public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(byte value) => new LPPROC_THREAD_ATTRIBUTE_LIST((nint)(value));

        public static explicit operator byte(LPPROC_THREAD_ATTRIBUTE_LIST value) => (byte)(value.Value);

        public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(short value) => new LPPROC_THREAD_ATTRIBUTE_LIST((nint)(value));

        public static explicit operator short(LPPROC_THREAD_ATTRIBUTE_LIST value) => (short)(value.Value);

        public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(int value) => new LPPROC_THREAD_ATTRIBUTE_LIST((nint)(value));

        public static explicit operator int(LPPROC_THREAD_ATTRIBUTE_LIST value) => (int)(value.Value);

        public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(long value) => new LPPROC_THREAD_ATTRIBUTE_LIST((nint)(value));

        public static implicit operator long(LPPROC_THREAD_ATTRIBUTE_LIST value) => (long)(value.Value);

        public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(nint value) => new LPPROC_THREAD_ATTRIBUTE_LIST((nint)(value));

        public static implicit operator nint(LPPROC_THREAD_ATTRIBUTE_LIST value) => (nint)(value.Value);

        public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(sbyte value) => new LPPROC_THREAD_ATTRIBUTE_LIST((nint)(value));

        public static explicit operator sbyte(LPPROC_THREAD_ATTRIBUTE_LIST value) => (sbyte)(value.Value);

        public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(ushort value) => new LPPROC_THREAD_ATTRIBUTE_LIST((nint)(value));

        public static explicit operator ushort(LPPROC_THREAD_ATTRIBUTE_LIST value) => (ushort)(value.Value);

        public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(uint value) => new LPPROC_THREAD_ATTRIBUTE_LIST((nint)(value));

        public static explicit operator uint(LPPROC_THREAD_ATTRIBUTE_LIST value) => (uint)(value.Value);

        public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(ulong value) => new LPPROC_THREAD_ATTRIBUTE_LIST((nint)(value));

        public static implicit operator ulong(LPPROC_THREAD_ATTRIBUTE_LIST value) => (ulong)(value.Value);

        public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(nuint value) => new LPPROC_THREAD_ATTRIBUTE_LIST((nint)(value));

        public static explicit operator nuint(LPPROC_THREAD_ATTRIBUTE_LIST value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is LPPROC_THREAD_ATTRIBUTE_LIST other) && Equals(other);

        public bool Equals(LPPROC_THREAD_ATTRIBUTE_LIST other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
