// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.MFVideoInterlaceMode;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFSerializeAttributesToStream(IMFAttributes* pAttr, [NativeTypeName("DWORD")] uint dwOptions, IStream* pStm);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFDeserializeAttributesFromStream(IMFAttributes* pAttr, [NativeTypeName("DWORD")] uint dwOptions, IStream* pStm);

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

        public static readonly Guid IID_IMFAttributes = new Guid(0x2CD2D921, 0xC447, 0x44A7, 0xA1, 0x3C, 0x4A, 0xDA, 0xBF, 0xC2, 0x47, 0xE3);

        public static readonly Guid IID_IMFMediaBuffer = new Guid(0x045FA593, 0x8799, 0x42B8, 0xBC, 0x8D, 0x89, 0x68, 0xC6, 0x45, 0x35, 0x07);

        public static readonly Guid IID_IMFSample = new Guid(0xC40A00F2, 0xB93A, 0x4D80, 0xAE, 0x8C, 0x5A, 0x1C, 0x63, 0x4F, 0x58, 0xE4);

        public static readonly Guid IID_IMF2DBuffer = new Guid(0x7DC9D5F9, 0x9ED9, 0x44EC, 0x9B, 0xBF, 0x06, 0x00, 0xBB, 0x58, 0x9F, 0xBB);

        public static readonly Guid IID_IMF2DBuffer2 = new Guid(0x33AE5EA6, 0x4316, 0x436F, 0x8D, 0xDD, 0xD7, 0x3D, 0x22, 0xF8, 0x29, 0xEC);

        public static readonly Guid IID_IMFDXGIBuffer = new Guid(0xE7174CFA, 0x1C9E, 0x48B1, 0x88, 0x66, 0x62, 0x62, 0x26, 0xBF, 0xC2, 0x58);

        public static readonly Guid IID_IMFMediaType = new Guid(0x44AE0FA8, 0xEA31, 0x4109, 0x8D, 0x2E, 0x4C, 0xAE, 0x49, 0x97, 0xC5, 0x55);

        public static readonly Guid IID_IMFAudioMediaType = new Guid(0x26A0ADC3, 0xCE26, 0x4672, 0x93, 0x04, 0x69, 0x55, 0x2E, 0xDD, 0x3F, 0xAF);

        public static readonly Guid IID_IMFVideoMediaType = new Guid(0xB99F381F, 0xA8F9, 0x47A2, 0xA5, 0xAF, 0xCA, 0x3A, 0x22, 0x5A, 0x38, 0x90);

        public static readonly Guid IID_IMFAsyncResult = new Guid(0xAC6B7889, 0x0740, 0x4D51, 0x86, 0x19, 0x90, 0x59, 0x94, 0xA5, 0x5C, 0xC6);

        public static readonly Guid IID_IMFAsyncCallback = new Guid(0xA27003CF, 0x2354, 0x4F2A, 0x8D, 0x6A, 0xAB, 0x7C, 0xFF, 0x15, 0x43, 0x7E);

        public static readonly Guid IID_IMFAsyncCallbackLogging = new Guid(0xC7A4DCA1, 0xF5F0, 0x47B6, 0xB9, 0x2B, 0xBF, 0x01, 0x06, 0xD2, 0x57, 0x91);

        public static readonly Guid IID_IMFMediaEvent = new Guid(0xDF598932, 0xF10C, 0x4E39, 0xBB, 0xA2, 0xC3, 0x08, 0xF1, 0x01, 0xDA, 0xA3);

        public static readonly Guid IID_IMFMediaEventGenerator = new Guid(0x2CD0BD52, 0xBCD5, 0x4B89, 0xB6, 0x2C, 0xEA, 0xDC, 0x0C, 0x03, 0x1E, 0x7D);

        public static readonly Guid IID_IMFRemoteAsyncCallback = new Guid(0xA27003D0, 0x2354, 0x4F2A, 0x8D, 0x6A, 0xAB, 0x7C, 0xFF, 0x15, 0x43, 0x7E);

        public static readonly Guid IID_IMFByteStream = new Guid(0xAD4C1B00, 0x4BF7, 0x422F, 0x91, 0x75, 0x75, 0x66, 0x93, 0xD9, 0x13, 0x0D);

        public static readonly Guid IID_IMFByteStreamProxyClassFactory = new Guid(0xA6B43F84, 0x5C0A, 0x42E8, 0xA4, 0x4D, 0xB1, 0x85, 0x7A, 0x76, 0x99, 0x2F);

        public static readonly Guid IID_IMFSampleOutputStream = new Guid(0x8FEED468, 0x6F7E, 0x440D, 0x86, 0x9A, 0x49, 0xBD, 0xD2, 0x83, 0xAD, 0x0D);

        public static readonly Guid IID_IMFCollection = new Guid(0x5BC8A76B, 0x869A, 0x46A3, 0x9B, 0x03, 0xFA, 0x21, 0x8A, 0x66, 0xAE, 0xBE);

        public static readonly Guid IID_IMFMediaEventQueue = new Guid(0x36F846FC, 0x2256, 0x48B6, 0xB5, 0x8E, 0xE2, 0xB6, 0x38, 0x31, 0x65, 0x81);

        public static readonly Guid IID_IMFActivate = new Guid(0x7FEE9E9A, 0x4A89, 0x47A6, 0x89, 0x9C, 0xB6, 0xA5, 0x3A, 0x70, 0xFB, 0x67);

        public static readonly Guid IID_IMFPluginControl = new Guid(0x5C6C44BF, 0x1DB6, 0x435B, 0x92, 0x49, 0xE8, 0xCD, 0x10, 0xFD, 0xEC, 0x96);

        public static readonly Guid IID_IMFPluginControl2 = new Guid(0xC6982083, 0x3DDC, 0x45CB, 0xAF, 0x5E, 0x0F, 0x7A, 0x8C, 0xE4, 0xDE, 0x77);

        public static readonly Guid IID_IMFDXGIDeviceManager = new Guid(0xEB533D5D, 0x2DB6, 0x40F8, 0x97, 0xA9, 0x49, 0x46, 0x92, 0x01, 0x4F, 0x07);

        public static readonly Guid IID_IMFMuxStreamAttributesManager = new Guid(0xCE8BD576, 0xE440, 0x43B3, 0xBE, 0x34, 0x1E, 0x53, 0xF5, 0x65, 0xF7, 0xE8);

        public static readonly Guid IID_IMFMuxStreamMediaTypeManager = new Guid(0x505A2C72, 0x42F7, 0x4690, 0xAE, 0xAB, 0x8F, 0x51, 0x3D, 0x0F, 0xFD, 0xB8);

        public static readonly Guid IID_IMFMuxStreamSampleManager = new Guid(0x74ABBC19, 0xB1CC, 0x4E41, 0xBB, 0x8B, 0x9D, 0x9B, 0x86, 0xA8, 0xF6, 0xCA);

        public static readonly Guid IID_IMFSecureBuffer = new Guid(0xC1209904, 0xE584, 0x4752, 0xA2, 0xD6, 0x7F, 0x21, 0x69, 0x3F, 0x8B, 0x21);
    }
}
