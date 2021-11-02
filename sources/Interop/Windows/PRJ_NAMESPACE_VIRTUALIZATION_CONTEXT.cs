// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT : IEquatable<PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT>
    {
        public readonly nint Value;

        public PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(nint value)
        {
            Value = value;
        }

        public static PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT INVALID_HANDLE_VALUE => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(-1);

        public static PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT NULL => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(0);

        public static bool operator ==(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT left, PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT right) => left.Value == right.Value;

        public static bool operator !=(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT left, PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT right) => left.Value != right.Value;

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(void* value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT((nint)(value));

        public static implicit operator void*(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (void*)(value.Value);

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(HANDLE value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(value);

        public static implicit operator HANDLE(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(value);

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(byte value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT((nint)(value));

        public static implicit operator byte(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (byte)(value.Value);

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(short value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT((nint)(value));

        public static implicit operator short(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (short)(value.Value);

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(int value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT((nint)(value));

        public static implicit operator int(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (int)(value.Value);

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(long value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT((nint)(value));

        public static explicit operator long(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (long)(value.Value);

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(nint value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT((nint)(value));

        public static implicit operator nint(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (nint)(value.Value);

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(sbyte value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT((nint)(value));

        public static implicit operator sbyte(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (sbyte)(value.Value);

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(ushort value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT((nint)(value));

        public static implicit operator ushort(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (ushort)(value.Value);

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(uint value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT((nint)(value));

        public static implicit operator uint(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (uint)(value.Value);

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(ulong value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT((nint)(value));

        public static explicit operator ulong(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (ulong)(value.Value);

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(nuint value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT((nint)(value));

        public static explicit operator nuint(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT other) && Equals(other);

        public bool Equals(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
