// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const int ROTFLAGS_REGISTRATIONKEEPSALIVE = 0x1;

        public const int ROTFLAGS_ALLOWANYCLIENT = 0x2;

        public const int ROT_COMPARE_MAX = 2048;

        public const int WDT_INPROC_CALL = 0x48746457;

        public const int WDT_REMOTE_CALL = 0x52746457;

        public const int WDT_INPROC64_CALL = 0x50746457;

        public const short VARIANT_TRUE = -1;

        public const short VARIANT_FALSE = 0;
    }
}
