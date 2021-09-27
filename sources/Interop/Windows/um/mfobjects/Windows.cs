// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
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
        public static ref readonly Guid MF_BYTESTREAM_ORIGIN_NAME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x88, 0x82, 0x35, 0xFC,
                    0xB6, 0x3C,
                    0x0C, 0x46,
                    0xA4,
                    0x24,
                    0xB6,
                    0x68,
                    0x12,
                    0x60,
                    0x37,
                    0x5A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_BYTESTREAM_CONTENT_TYPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x89, 0x82, 0x35, 0xFC,
                    0xB6, 0x3C,
                    0x0C, 0x46,
                    0xA4,
                    0x24,
                    0xB6,
                    0x68,
                    0x12,
                    0x60,
                    0x37,
                    0x5A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_BYTESTREAM_DURATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8A, 0x82, 0x35, 0xFC,
                    0xB6, 0x3C,
                    0x0C, 0x46,
                    0xA4,
                    0x24,
                    0xB6,
                    0x68,
                    0x12,
                    0x60,
                    0x37,
                    0x5A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_BYTESTREAM_LAST_MODIFIED_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8B, 0x82, 0x35, 0xFC,
                    0xB6, 0x3C,
                    0x0C, 0x46,
                    0xA4,
                    0x24,
                    0xB6,
                    0x68,
                    0x12,
                    0x60,
                    0x37,
                    0x5A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_BYTESTREAM_IFO_FILE_URI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8C, 0x82, 0x35, 0xFC,
                    0xB6, 0x3C,
                    0x0C, 0x46,
                    0xA4,
                    0x24,
                    0xB6,
                    0x68,
                    0x12,
                    0x60,
                    0x37,
                    0x5A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_BYTESTREAM_DLNA_PROFILE_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8D, 0x82, 0x35, 0xFC,
                    0xB6, 0x3C,
                    0x0C, 0x46,
                    0xA4,
                    0x24,
                    0xB6,
                    0x68,
                    0x12,
                    0x60,
                    0x37,
                    0x5A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_BYTESTREAM_EFFECTIVE_URL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x09, 0x02, 0xFA, 0x9A,
                    0xD1, 0x89,
                    0xAF, 0x42,
                    0x84,
                    0x56,
                    0x1D,
                    0xE6,
                    0xB5,
                    0x62,
                    0xD6,
                    0x91
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_BYTESTREAM_TRANSCODED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0xC2, 0xC5, 0xB6,
                    0xC9, 0x4D,
                    0xB9, 0x4D,
                    0xAB,
                    0x48,
                    0xCF,
                    0x3B,
                    0x6D,
                    0x8B,
                    0xC5,
                    0xE0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MFByteStreamProxyClassFactory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x77, 0x8E, 0x0E, 0x77,
                    0x16, 0x49,
                    0x1C, 0x44,
                    0xA9,
                    0xA7,
                    0xB3,
                    0x42,
                    0xD0,
                    0xEE,
                    0xBC,
                    0x71
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

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

        public static ref readonly Guid IID_IMFAttributes
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0xD9, 0xD2, 0x2C,
                    0x47, 0xC4,
                    0xA7, 0x44,
                    0xA1,
                    0x3C,
                    0x4A,
                    0xDA,
                    0xBF,
                    0xC2,
                    0x47,
                    0xE3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaBuffer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x93, 0xA5, 0x5F, 0x04,
                    0x99, 0x87,
                    0xB8, 0x42,
                    0xBC,
                    0x8D,
                    0x89,
                    0x68,
                    0xC6,
                    0x45,
                    0x35,
                    0x07
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSample
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF2, 0x00, 0x0A, 0xC4,
                    0x3A, 0xB9,
                    0x80, 0x4D,
                    0xAE,
                    0x8C,
                    0x5A,
                    0x1C,
                    0x63,
                    0x4F,
                    0x58,
                    0xE4
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMF2DBuffer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0xD5, 0xC9, 0x7D,
                    0xD9, 0x9E,
                    0xEC, 0x44,
                    0x9B,
                    0xBF,
                    0x06,
                    0x00,
                    0xBB,
                    0x58,
                    0x9F,
                    0xBB
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMF2DBuffer2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA6, 0x5E, 0xAE, 0x33,
                    0x16, 0x43,
                    0x6F, 0x43,
                    0x8D,
                    0xDD,
                    0xD7,
                    0x3D,
                    0x22,
                    0xF8,
                    0x29,
                    0xEC
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFDXGIBuffer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFA, 0x4C, 0x17, 0xE7,
                    0x9E, 0x1C,
                    0xB1, 0x48,
                    0x88,
                    0x66,
                    0x62,
                    0x62,
                    0x26,
                    0xBF,
                    0xC2,
                    0x58
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaType
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA8, 0x0F, 0xAE, 0x44,
                    0x31, 0xEA,
                    0x09, 0x41,
                    0x8D,
                    0x2E,
                    0x4C,
                    0xAE,
                    0x49,
                    0x97,
                    0xC5,
                    0x55
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFAudioMediaType
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC3, 0xAD, 0xA0, 0x26,
                    0x26, 0xCE,
                    0x72, 0x46,
                    0x93,
                    0x04,
                    0x69,
                    0x55,
                    0x2E,
                    0xDD,
                    0x3F,
                    0xAF
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFVideoMediaType
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1F, 0x38, 0x9F, 0xB9,
                    0xF9, 0xA8,
                    0xA2, 0x47,
                    0xA5,
                    0xAF,
                    0xCA,
                    0x3A,
                    0x22,
                    0x5A,
                    0x38,
                    0x90
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFAsyncResult
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x89, 0x78, 0x6B, 0xAC,
                    0x40, 0x07,
                    0x51, 0x4D,
                    0x86,
                    0x19,
                    0x90,
                    0x59,
                    0x94,
                    0xA5,
                    0x5C,
                    0xC6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFAsyncCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCF, 0x03, 0x70, 0xA2,
                    0x54, 0x23,
                    0x2A, 0x4F,
                    0x8D,
                    0x6A,
                    0xAB,
                    0x7C,
                    0xFF,
                    0x15,
                    0x43,
                    0x7E
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFAsyncCallbackLogging
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0xDC, 0xA4, 0xC7,
                    0xF0, 0xF5,
                    0xB6, 0x47,
                    0xB9,
                    0x2B,
                    0xBF,
                    0x01,
                    0x06,
                    0xD2,
                    0x57,
                    0x91
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaEvent
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x32, 0x89, 0x59, 0xDF,
                    0x0C, 0xF1,
                    0x39, 0x4E,
                    0xBB,
                    0xA2,
                    0xC3,
                    0x08,
                    0xF1,
                    0x01,
                    0xDA,
                    0xA3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaEventGenerator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0xBD, 0xD0, 0x2C,
                    0xD5, 0xBC,
                    0x89, 0x4B,
                    0xB6,
                    0x2C,
                    0xEA,
                    0xDC,
                    0x0C,
                    0x03,
                    0x1E,
                    0x7D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFRemoteAsyncCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0x03, 0x70, 0xA2,
                    0x54, 0x23,
                    0x2A, 0x4F,
                    0x8D,
                    0x6A,
                    0xAB,
                    0x7C,
                    0xFF,
                    0x15,
                    0x43,
                    0x7E
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFByteStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x1B, 0x4C, 0xAD,
                    0xF7, 0x4B,
                    0x2F, 0x42,
                    0x91,
                    0x75,
                    0x75,
                    0x66,
                    0x93,
                    0xD9,
                    0x13,
                    0x0D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFByteStreamProxyClassFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x84, 0x3F, 0xB4, 0xA6,
                    0x0A, 0x5C,
                    0xE8, 0x42,
                    0xA4,
                    0x4D,
                    0xB1,
                    0x85,
                    0x7A,
                    0x76,
                    0x99,
                    0x2F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSampleOutputStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x68, 0xD4, 0xEE, 0x8F,
                    0x7E, 0x6F,
                    0x0D, 0x44,
                    0x86,
                    0x9A,
                    0x49,
                    0xBD,
                    0xD2,
                    0x83,
                    0xAD,
                    0x0D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFCollection
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6B, 0xA7, 0xC8, 0x5B,
                    0x9A, 0x86,
                    0xA3, 0x46,
                    0x9B,
                    0x03,
                    0xFA,
                    0x21,
                    0x8A,
                    0x66,
                    0xAE,
                    0xBE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaEventQueue
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFC, 0x46, 0xF8, 0x36,
                    0x56, 0x22,
                    0xB6, 0x48,
                    0xB5,
                    0x8E,
                    0xE2,
                    0xB6,
                    0x38,
                    0x31,
                    0x65,
                    0x81
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFActivate
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9A, 0x9E, 0xEE, 0x7F,
                    0x89, 0x4A,
                    0xA6, 0x47,
                    0x89,
                    0x9C,
                    0xB6,
                    0xA5,
                    0x3A,
                    0x70,
                    0xFB,
                    0x67
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFPluginControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBF, 0x44, 0x6C, 0x5C,
                    0xB6, 0x1D,
                    0x5B, 0x43,
                    0x92,
                    0x49,
                    0xE8,
                    0xCD,
                    0x10,
                    0xFD,
                    0xEC,
                    0x96
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFPluginControl2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0x20, 0x98, 0xC6,
                    0xDC, 0x3D,
                    0xCB, 0x45,
                    0xAF,
                    0x5E,
                    0x0F,
                    0x7A,
                    0x8C,
                    0xE4,
                    0xDE,
                    0x77
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFDXGIDeviceManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5D, 0x3D, 0x53, 0xEB,
                    0xB6, 0x2D,
                    0xF8, 0x40,
                    0x97,
                    0xA9,
                    0x49,
                    0x46,
                    0x92,
                    0x01,
                    0x4F,
                    0x07
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMuxStreamAttributesManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0xD5, 0x8B, 0xCE,
                    0x40, 0xE4,
                    0xB3, 0x43,
                    0xBE,
                    0x34,
                    0x1E,
                    0x53,
                    0xF5,
                    0x65,
                    0xF7,
                    0xE8
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMuxStreamMediaTypeManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0x2C, 0x5A, 0x50,
                    0xF7, 0x42,
                    0x90, 0x46,
                    0xAE,
                    0xAB,
                    0x8F,
                    0x51,
                    0x3D,
                    0x0F,
                    0xFD,
                    0xB8
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMuxStreamSampleManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x19, 0xBC, 0xAB, 0x74,
                    0xCC, 0xB1,
                    0x41, 0x4E,
                    0xBB,
                    0x8B,
                    0x9D,
                    0x9B,
                    0x86,
                    0xA8,
                    0xF6,
                    0xCA
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSecureBuffer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x04, 0x99, 0x20, 0xC1,
                    0x84, 0xE5,
                    0x52, 0x47,
                    0xA2,
                    0xD6,
                    0x7F,
                    0x21,
                    0x69,
                    0x3F,
                    0x8B,
                    0x21
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
