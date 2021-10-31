// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HTREEITEM
    {
        public static explicit operator HTREEITEM(nuint value) => new HTREEITEM((nint)(value));

        public static explicit operator nuint(HTREEITEM value) => (nuint)(value.Value);

        public static explicit operator HTREEITEM(void* value) => new HTREEITEM((nint)(value));

        public static explicit operator void*(HTREEITEM value) => (void*)(value.Value);
    }
}
