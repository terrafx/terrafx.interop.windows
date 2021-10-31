// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct PTP_CALLBACK_INSTANCE
    {
        public static explicit operator PTP_CALLBACK_INSTANCE(nuint value) => new PTP_CALLBACK_INSTANCE((nint)(value));

        public static explicit operator nuint(PTP_CALLBACK_INSTANCE value) => (nuint)(value.Value);

        public static explicit operator PTP_CALLBACK_INSTANCE(void* value) => new PTP_CALLBACK_INSTANCE((nint)(value));

        public static explicit operator void*(PTP_CALLBACK_INSTANCE value) => (void*)(value.Value);
    }
}
