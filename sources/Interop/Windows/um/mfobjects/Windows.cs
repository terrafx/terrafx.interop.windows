// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("mfplat", EntryPoint = "MFSerializeAttributesToStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFSerializeAttributesToStream([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttr, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("IStream *")] IStream* pStm);

        [DllImport("mfplat", EntryPoint = "MFDeserializeAttributesFromStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFDeserializeAttributesFromStream([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttr, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("IStream *")] IStream* pStm);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_BYTESTREAM_ORIGIN_NAME = new Guid(0xfc358288, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_BYTESTREAM_CONTENT_TYPE = new Guid(0xfc358289, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_BYTESTREAM_DURATION = new Guid(0xfc35828a, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_BYTESTREAM_LAST_MODIFIED_TIME = new Guid(0xfc35828b, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_BYTESTREAM_IFO_FILE_URI = new Guid(0xfc35828c, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_BYTESTREAM_DLNA_PROFILE_ID = new Guid(0xfc35828d, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_BYTESTREAM_EFFECTIVE_URL = new Guid(0x9afa0209, 0x89d1, 0x42af, 0x84, 0x56, 0x1d, 0xe6, 0xb5, 0x62, 0xd6, 0x91);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_BYTESTREAM_TRANSCODED = new Guid(0xb6c5c282, 0x4dc9, 0x4db9, 0xab, 0x48, 0xcf, 0x3b, 0x6d, 0x8b, 0xc5, 0xe0);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MFByteStreamProxyClassFactory = new Guid(0x770e8e77, 0x4916, 0x441c, 0xa9, 0xa7, 0xb3, 0x42, 0xd0, 0xee, 0xbc, 0x71);
    }
}
