// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/comcat.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define IID_IEnumCLSID IID_IEnumGUID")]
        public static readonly Guid IID_IEnumCLSID = IID_IEnumGUID;

        [NativeTypeName("#define IID_IEnumCATID IID_IEnumGUID")]
        public static readonly Guid IID_IEnumCATID = IID_IEnumGUID;

        public static readonly Guid IID_IEnumGUID = new Guid(0x0002E000, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IEnumCATEGORYINFO = new Guid(0x0002E011, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ICatRegister = new Guid(0x0002E012, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ICatInformation = new Guid(0x0002E013, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);
    }
}
