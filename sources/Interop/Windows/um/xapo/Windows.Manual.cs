// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int FACILITY_XAPO = 0x897;

        public const int XAPO_E_FORMAT_UNSUPPORTED = unchecked((int)0x88970001);

        public const int XAPO_MIN_CHANNELS = 1;

        public const int XAPO_MAX_CHANNELS = 64;

        public const int XAPO_MIN_FRAMERATE = 1000;

        public const int XAPO_MAX_FRAMERATE = 200000;

        public const int XAPO_REGISTRATION_STRING_LENGTH = 256;

        public const int XAPO_FLAG_CHANNELS_MUST_MATCH = 0x00000001;

        public const int XAPO_FLAG_FRAMERATE_MUST_MATCH = 0x00000002;

        public const int XAPO_FLAG_BITSPERSAMPLE_MUST_MATCH = 0x00000004;

        public const int XAPO_FLAG_BUFFERCOUNT_MUST_MATCH = 0x00000008;

        public const int XAPO_FLAG_INPLACE_REQUIRED = 0x00000020;

        public const int XAPO_FLAG_INPLACE_SUPPORTED = 0x00000010;

        public static void* XAPOAlloc(nuint size) => CoTaskMemAlloc(size);

        public static void XAPOFree(void* p) => CoTaskMemFree(p);
    }
}
