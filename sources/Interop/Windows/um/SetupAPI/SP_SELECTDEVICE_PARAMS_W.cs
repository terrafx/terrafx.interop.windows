// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SP_SELECTDEVICE_PARAMS_W
    {
        public SP_CLASSINSTALL_HEADER ClassInstallHeader;

        [NativeTypeName("WCHAR [60]")]
        public fixed ushort Title[60];

        [NativeTypeName("WCHAR [256]")]
        public fixed ushort Instructions[256];

        [NativeTypeName("WCHAR [30]")]
        public fixed ushort ListLabel[30];

        [NativeTypeName("WCHAR [256]")]
        public fixed ushort SubTitle[256];
    }
}
