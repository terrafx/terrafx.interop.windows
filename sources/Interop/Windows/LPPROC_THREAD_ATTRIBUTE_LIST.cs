// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct LPPROC_THREAD_ATTRIBUTE_LIST : IEquatable<LPPROC_THREAD_ATTRIBUTE_LIST>
    {
        public readonly nint Value;

        public LPPROC_THREAD_ATTRIBUTE_LIST(nint value)
        {
            Value = ((nint)(value));
        }

        public LPPROC_THREAD_ATTRIBUTE_LIST(nuint value)
        {
            Value = ((nint)(value));
        }

        public LPPROC_THREAD_ATTRIBUTE_LIST(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(LPPROC_THREAD_ATTRIBUTE_LIST left, LPPROC_THREAD_ATTRIBUTE_LIST right) => left.Value == right.Value;

        public static bool operator !=(LPPROC_THREAD_ATTRIBUTE_LIST left, LPPROC_THREAD_ATTRIBUTE_LIST right) => left.Value != right.Value;

        public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(nint value) => new LPPROC_THREAD_ATTRIBUTE_LIST(value);

        public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(nuint value) => new LPPROC_THREAD_ATTRIBUTE_LIST(value);

        public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(void* value) => new LPPROC_THREAD_ATTRIBUTE_LIST(value);

        public static implicit operator nint(LPPROC_THREAD_ATTRIBUTE_LIST value) => (nint)(value.Value);

        public static implicit operator nuint(LPPROC_THREAD_ATTRIBUTE_LIST value) => (nuint)(value.Value);

        public static implicit operator void*(LPPROC_THREAD_ATTRIBUTE_LIST value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is LPPROC_THREAD_ATTRIBUTE_LIST other) && Equals(other);

        public bool Equals(LPPROC_THREAD_ATTRIBUTE_LIST other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
