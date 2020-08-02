// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_CONTENTDECRYPTIONMODULE_INPRIVATESTOREPATH = new PROPERTYKEY
        {
            fmtid = new Guid(0x730cb3ac, 0x51dc, 0x49da, 0xa5, 0x78, 0xb9, 0x53, 0x86, 0xb6, 0x2a, 0xfe),
            pid = 0x01,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_CONTENTDECRYPTIONMODULE_STOREPATH = new PROPERTYKEY
        {
            fmtid = new Guid(0x77d993b9, 0xba61, 0x4bb7, 0x92, 0xc6, 0x18, 0xc8, 0x6a, 0x18, 0x9c, 0x06),
            pid = 0x02,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY MF_CONTENTDECRYPTIONMODULE_PMPSTORECONTEXT = new PROPERTYKEY
        {
            fmtid = new Guid(0x6d2a2835, 0xc3a9, 0x4681, 0x97, 0xf2, 0x0a, 0xf5, 0x6b, 0xe9, 0x34, 0x46),
            pid = 0x03,
        };

        [NativeTypeName("const IID")]
        public static readonly Guid MF_CONTENTDECRYPTIONMODULE_SERVICE = new Guid(0x15320c45, 0xff80, 0x484a, 0x9d, 0xcb, 0xd, 0xf8, 0x94, 0xe6, 0x9a, 0x1);

        [DllImport("mf", EntryPoint = "MFCreateEncryptedMediaExtensionsStoreActivate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateEncryptedMediaExtensionsStoreActivate([NativeTypeName("IMFPMPHostApp *")] IMFPMPHostApp* pmpHost, [NativeTypeName("IStream *")] IStream* objectStream, [NativeTypeName("LPCWSTR")] ushort* classId, [NativeTypeName("IMFActivate **")] IMFActivate** activate);
    }
}
