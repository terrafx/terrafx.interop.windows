// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCERTSTOREPROV
    {
        public static explicit operator HCERTSTOREPROV(nuint value) => new HCERTSTOREPROV((nint)(value));

        public static explicit operator nuint(HCERTSTOREPROV value) => (nuint)(value.Value);

        public static explicit operator HCERTSTOREPROV(void* value) => new HCERTSTOREPROV((nint)(value));

        public static explicit operator void*(HCERTSTOREPROV value) => (void*)(value.Value);
    }
}
