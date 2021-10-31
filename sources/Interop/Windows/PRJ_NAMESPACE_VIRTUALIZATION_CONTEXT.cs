// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT : IEquatable<PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT>
    {
        public readonly nint Value;

        public PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(nint value)
        {
            Value = ((nint)(value));
        }

        public PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(nuint value)
        {
            Value = ((nint)(value));
        }

        public PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT left, PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT right) => left.Value == right.Value;

        public static bool operator !=(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT left, PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT right) => left.Value != right.Value;

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(nint value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(value);

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(nuint value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(value);

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(void* value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(value);

        public static implicit operator nint(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (nint)(value.Value);

        public static implicit operator nuint(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (nuint)(value.Value);

        public static implicit operator void*(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT other) && Equals(other);

        public bool Equals(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
