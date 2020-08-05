// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid ID_DOCUMENTPACKAGETARGET_MSXPS = new Guid(0x9cae40a8, 0xded1, 0x41c9, 0xa9, 0xfd, 0xd7, 0x35, 0xef, 0x33, 0xae, 0xda);

        [NativeTypeName("const GUID")]
        public static readonly Guid ID_DOCUMENTPACKAGETARGET_OPENXPS = new Guid(0x0056bb72, 0x8c9c, 0x4612, 0xbd, 0x0f, 0x93, 0x01, 0x2a, 0x87, 0x09, 0x9d);

        [NativeTypeName("const GUID")]
        public static readonly Guid ID_DOCUMENTPACKAGETARGET_OPENXPS_WITH_3D = new Guid(0x63dbd720, 0x8b14, 0x4577, 0xb0, 0x74, 0x7b, 0xb1, 0x1b, 0x59, 0x6d, 0x28);

        public static readonly Guid IID_IPrintDocumentPackageTarget = new Guid(0x1B8EFEC4, 0x3019, 0x4C27, 0x96, 0x4E, 0x36, 0x72, 0x02, 0x15, 0x69, 0x06);

        public static readonly Guid IID_IPrintDocumentPackageStatusEvent = new Guid(0xED90C8AD, 0x5C34, 0x4D05, 0xA1, 0xEC, 0x0E, 0x8A, 0x9B, 0x3A, 0xD7, 0xAF);

        public static readonly Guid IID_IPrintDocumentPackageTargetFactory = new Guid(0xD2959BF7, 0xB31B, 0x4A3D, 0x96, 0x00, 0x71, 0x2E, 0xB1, 0x33, 0x5B, 0xA4);

        public static readonly Guid CLSID_PrintDocumentPackageTarget = new Guid(0x4842669E, 0x9947, 0x46EA, 0x8B, 0xA2, 0xD8, 0xCC, 0xE4, 0x32, 0xC2, 0xCA);

        public static readonly Guid CLSID_PrintDocumentPackageTargetFactory = new Guid(0x348EF17D, 0x6C81, 0x4982, 0x92, 0xB4, 0xEE, 0x18, 0x8A, 0x43, 0x86, 0x7A);
    }
}
