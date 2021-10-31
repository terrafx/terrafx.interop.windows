// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct PRJ_DIR_ENTRY_BUFFER_HANDLE
    {
        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(nuint value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE((nint)(value));

        public static explicit operator nuint(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (nuint)(value.Value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(void* value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE((nint)(value));

        public static explicit operator void*(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (void*)(value.Value);
    }
}
