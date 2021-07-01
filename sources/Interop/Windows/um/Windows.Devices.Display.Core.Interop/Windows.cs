// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Windows.Devices.Display.Core.Interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [return: NativeTypeName("INT64")]
        public static long Int64FromLuid([NativeTypeName("const LUID &")] LUID* Luid)
        {
            LARGE_INTEGER val = new LARGE_INTEGER();

            val.Anonymous.LowPart = Luid->LowPart;
            val.Anonymous.HighPart = Luid->HighPart;
            return val.QuadPart;
        }

        public static LUID LuidFromInt64([NativeTypeName("INT64")] long Int64)
        {
            LARGE_INTEGER val = new LARGE_INTEGER();

            val.QuadPart = Int64;
            LUID Luid = new LUID();

            Luid.LowPart = val.Anonymous.LowPart;
            Luid.HighPart = val.Anonymous.HighPart;
            return Luid;
        }

        public static readonly Guid IID_IDisplayDeviceInterop = new Guid(0x64338358, 0x366A, 0x471B, 0xBD, 0x56, 0xDD, 0x8E, 0xF4, 0x8E, 0x43, 0x9B);

        public static readonly Guid IID_IDisplayPathInterop = new Guid(0xA6BA4205, 0xE59E, 0x4E71, 0xB2, 0x5B, 0x4E, 0x43, 0x6D, 0x21, 0xEE, 0x3D);
    }
}
