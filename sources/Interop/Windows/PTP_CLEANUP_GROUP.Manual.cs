// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct PTP_CLEANUP_GROUP
    {
        public static explicit operator PTP_CLEANUP_GROUP(nuint value) => new PTP_CLEANUP_GROUP((nint)(value));

        public static explicit operator nuint(PTP_CLEANUP_GROUP value) => (nuint)(value.Value);

        public static explicit operator PTP_CLEANUP_GROUP(void* value) => new PTP_CLEANUP_GROUP((nint)(value));

        public static explicit operator void*(PTP_CLEANUP_GROUP value) => (void*)(value.Value);
    }
}
