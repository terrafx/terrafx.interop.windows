// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.MFVideoInterlaceMode;

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

        [NativeTypeName("#define MF_MEDIATYPE_EQUAL_MAJOR_TYPES 0x00000001")]
        public const int MF_MEDIATYPE_EQUAL_MAJOR_TYPES = 0x00000001;

        [NativeTypeName("#define MF_MEDIATYPE_EQUAL_FORMAT_TYPES 0x00000002")]
        public const int MF_MEDIATYPE_EQUAL_FORMAT_TYPES = 0x00000002;

        [NativeTypeName("#define MF_MEDIATYPE_EQUAL_FORMAT_DATA 0x00000004")]
        public const int MF_MEDIATYPE_EQUAL_FORMAT_DATA = 0x00000004;

        [NativeTypeName("#define MF_MEDIATYPE_EQUAL_FORMAT_USER_DATA 0x00000008")]
        public const int MF_MEDIATYPE_EQUAL_FORMAT_USER_DATA = 0x00000008;

        [NativeTypeName("#define MFVideoInterlace_FieldSingleUpperFirst MFVideoInterlace_FieldSingleUpper")]
        public const MFVideoInterlaceMode MFVideoInterlace_FieldSingleUpperFirst = MFVideoInterlace_FieldSingleUpper;

        [NativeTypeName("#define MFVideoInterlace_FieldSingleLowerFirst MFVideoInterlace_FieldSingleLower")]
        public const MFVideoInterlaceMode MFVideoInterlace_FieldSingleLowerFirst = MFVideoInterlace_FieldSingleLower;

        [NativeTypeName("#define MFASYNC_FAST_IO_PROCESSING_CALLBACK 0x00000001")]
        public const int MFASYNC_FAST_IO_PROCESSING_CALLBACK = 0x00000001;

        [NativeTypeName("#define MFASYNC_SIGNAL_CALLBACK 0x00000002")]
        public const int MFASYNC_SIGNAL_CALLBACK = 0x00000002;

        [NativeTypeName("#define MFASYNC_BLOCKING_CALLBACK 0x00000004")]
        public const int MFASYNC_BLOCKING_CALLBACK = 0x00000004;

        [NativeTypeName("#define MFASYNC_REPLY_CALLBACK 0x00000008")]
        public const int MFASYNC_REPLY_CALLBACK = 0x00000008;

        [NativeTypeName("#define MFASYNC_LOCALIZE_REMOTE_CALLBACK 0x00000010")]
        public const int MFASYNC_LOCALIZE_REMOTE_CALLBACK = 0x00000010;

        [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_UNDEFINED 0x00000000")]
        public const int MFASYNC_CALLBACK_QUEUE_UNDEFINED = 0x00000000;

        [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_STANDARD 0x00000001")]
        public const int MFASYNC_CALLBACK_QUEUE_STANDARD = 0x00000001;

        [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_RT 0x00000002")]
        public const int MFASYNC_CALLBACK_QUEUE_RT = 0x00000002;

        [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_IO 0x00000003")]
        public const int MFASYNC_CALLBACK_QUEUE_IO = 0x00000003;

        [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_TIMER 0x00000004")]
        public const int MFASYNC_CALLBACK_QUEUE_TIMER = 0x00000004;

        [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_MULTITHREADED 0x00000005")]
        public const int MFASYNC_CALLBACK_QUEUE_MULTITHREADED = 0x00000005;

        [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_LONG_FUNCTION 0x00000007")]
        public const int MFASYNC_CALLBACK_QUEUE_LONG_FUNCTION = 0x00000007;

        [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_PRIVATE_MASK 0xFFFF0000")]
        public const uint MFASYNC_CALLBACK_QUEUE_PRIVATE_MASK = 0xFFFF0000;

        [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_ALL 0xFFFFFFFF")]
        public const uint MFASYNC_CALLBACK_QUEUE_ALL = 0xFFFFFFFF;

        [NativeTypeName("#define MF_EVENT_FLAG_NO_WAIT 0x00000001")]
        public const int MF_EVENT_FLAG_NO_WAIT = 0x00000001;

        [NativeTypeName("#define MFBYTESTREAM_IS_READABLE 0x00000001")]
        public const int MFBYTESTREAM_IS_READABLE = 0x00000001;

        [NativeTypeName("#define MFBYTESTREAM_IS_WRITABLE 0x00000002")]
        public const int MFBYTESTREAM_IS_WRITABLE = 0x00000002;

        [NativeTypeName("#define MFBYTESTREAM_IS_SEEKABLE 0x00000004")]
        public const int MFBYTESTREAM_IS_SEEKABLE = 0x00000004;

        [NativeTypeName("#define MFBYTESTREAM_IS_REMOTE 0x00000008")]
        public const int MFBYTESTREAM_IS_REMOTE = 0x00000008;

        [NativeTypeName("#define MFBYTESTREAM_IS_DIRECTORY 0x00000080")]
        public const int MFBYTESTREAM_IS_DIRECTORY = 0x00000080;

        [NativeTypeName("#define MFBYTESTREAM_HAS_SLOW_SEEK 0x00000100")]
        public const int MFBYTESTREAM_HAS_SLOW_SEEK = 0x00000100;

        [NativeTypeName("#define MFBYTESTREAM_IS_PARTIALLY_DOWNLOADED 0x00000200")]
        public const int MFBYTESTREAM_IS_PARTIALLY_DOWNLOADED = 0x00000200;

        [NativeTypeName("#define MFBYTESTREAM_SHARE_WRITE 0x00000400")]
        public const int MFBYTESTREAM_SHARE_WRITE = 0x00000400;

        [NativeTypeName("#define MFBYTESTREAM_DOES_NOT_USE_NETWORK 0x00000800")]
        public const int MFBYTESTREAM_DOES_NOT_USE_NETWORK = 0x00000800;

        [NativeTypeName("#define MFBYTESTREAM_SEEK_FLAG_CANCEL_PENDING_IO 0x00000001")]
        public const int MFBYTESTREAM_SEEK_FLAG_CANCEL_PENDING_IO = 0x00000001;
    }
}
