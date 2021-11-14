// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.MFVideoInterlaceMode;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFSerializeAttributesToStream(IMFAttributes* pAttr, [NativeTypeName("DWORD")] uint dwOptions, IStream* pStm);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFDeserializeAttributesFromStream(IMFAttributes* pAttr, [NativeTypeName("DWORD")] uint dwOptions, IStream* pStm);

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
