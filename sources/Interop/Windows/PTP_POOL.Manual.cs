// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct PTP_POOL
    {
        public static explicit operator PTP_POOL(nuint value) => new PTP_POOL((nint)(value));

        public static explicit operator nuint(PTP_POOL value) => (nuint)(value.Value);

        public static explicit operator PTP_POOL(void* value) => new PTP_POOL((nint)(value));

        public static explicit operator void*(PTP_POOL value) => (void*)(value.Value);
    }
}
