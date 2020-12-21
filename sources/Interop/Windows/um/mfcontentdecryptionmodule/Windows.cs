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

        [DllImport("mf", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateEncryptedMediaExtensionsStoreActivate([NativeTypeName("IMFPMPHostApp *")] IMFPMPHostApp* pmpHost, [NativeTypeName("IStream *")] IStream* objectStream, [NativeTypeName("LPCWSTR")] ushort* classId, [NativeTypeName("IMFActivate **")] IMFActivate** activate);

        public static readonly Guid IID_IMFContentDecryptionModuleSession = new Guid(0x4E233EFD, 0x1DD2, 0x49E8, 0xB5, 0x77, 0xD6, 0x3E, 0xEE, 0x4C, 0x0D, 0x33);

        public static readonly Guid IID_IMFContentDecryptionModuleSessionCallbacks = new Guid(0x3F96EE40, 0xAD81, 0x4096, 0x84, 0x70, 0x59, 0xA4, 0xB7, 0x70, 0xF8, 0x9A);

        public static readonly Guid IID_IMFContentDecryptionModule = new Guid(0x87BE986C, 0x10BE, 0x4943, 0xBF, 0x48, 0x4B, 0x54, 0xCE, 0x19, 0x83, 0xA2);

        public static readonly Guid IID_IMFContentDecryptionModuleAccess = new Guid(0xA853D1F4, 0xE2A0, 0x4303, 0x9E, 0xDC, 0xF1, 0xA6, 0x8E, 0xE4, 0x31, 0x36);

        public static readonly Guid IID_IMFContentDecryptionModuleFactory = new Guid(0x7D5ABF16, 0x4CBB, 0x4E08, 0xB9, 0x77, 0x9B, 0xA5, 0x90, 0x49, 0x94, 0x3E);
    }
}
