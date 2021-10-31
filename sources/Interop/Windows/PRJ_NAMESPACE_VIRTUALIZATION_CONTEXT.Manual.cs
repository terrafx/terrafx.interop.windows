// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT
    {
        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(nuint value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT((nint)(value));

        public static explicit operator nuint(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (nuint)(value.Value);

        public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(void* value) => new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT((nint)(value));

        public static explicit operator void*(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) => (void*)(value.Value);
    }
}
