// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct DPI_AWARENESS_CONTEXT
    {
        public static explicit operator DPI_AWARENESS_CONTEXT(nuint value) => new DPI_AWARENESS_CONTEXT((nint)(value));

        public static explicit operator nuint(DPI_AWARENESS_CONTEXT value) => (nuint)(value.Value);

        public static explicit operator DPI_AWARENESS_CONTEXT(void* value) => new DPI_AWARENESS_CONTEXT((nint)(value));

        public static explicit operator void*(DPI_AWARENESS_CONTEXT value) => (void*)(value.Value);
    }
}
