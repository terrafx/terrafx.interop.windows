// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/timezoneapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct TIME_ZONE_INFORMATION
    {
        [NativeTypeName("LONG")]
        public int Bias;

        [NativeTypeName("WCHAR [32]")]
        public fixed ushort StandardName[32];

        public SYSTEMTIME StandardDate;

        [NativeTypeName("LONG")]
        public int StandardBias;

        [NativeTypeName("WCHAR [32]")]
        public fixed ushort DaylightName[32];

        public SYSTEMTIME DaylightDate;

        [NativeTypeName("LONG")]
        public int DaylightBias;
    }
}
