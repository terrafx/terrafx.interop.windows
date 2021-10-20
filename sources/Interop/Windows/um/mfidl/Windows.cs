// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_WVC1_PROG_SINGLE_SLICE_CONTENT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x25, 0xEC, 0x67,
                    0x2F, 0x0F,
                    0x20, 0x44,
                    0xA4,
                    0xDD,
                    0x2F,
                    0x8E,
                    0xE7,
                    0xA5,
                    0x73,
                    0x8B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PROGRESSIVE_CODING_CONTENT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEA, 0x0E, 0x02, 0x8F,
                    0x08, 0x15,
                    0x1F, 0x47,
                    0x9D,
                    0xA6,
                    0x50,
                    0x7D,
                    0x7C,
                    0xFA,
                    0x40,
                    0xDB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_NALU_LENGTH_SET
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x53, 0x1D, 0x91, 0xA7,
                    0xA4, 0x12,
                    0x65, 0x49,
                    0xAE,
                    0x70,
                    0x6E,
                    0xAD,
                    0xD6,
                    0xFF,
                    0x05,
                    0x51
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_NALU_LENGTH_INFORMATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0x4E, 0x12, 0x19,
                    0x4B, 0xAD,
                    0x5F, 0x46,
                    0xBB,
                    0x18,
                    0x20,
                    0x18,
                    0x62,
                    0x87,
                    0xB6,
                    0xAF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_USER_DATA_PAYLOAD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5D, 0x98, 0xD4, 0xD1,
                    0x92, 0xDC,
                    0x7A, 0x45,
                    0xB3,
                    0xA0,
                    0x65,
                    0x1A,
                    0x33,
                    0xA3,
                    0x10,
                    0x47
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MPEG4SINK_SPSPPS_PASSTHROUGH
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x34, 0xA1, 0x01, 0x56,
                    0x05, 0x20,
                    0xD2, 0x4A,
                    0xB3,
                    0x7D,
                    0x22,
                    0xA6,
                    0xC5,
                    0x54,
                    0xDE,
                    0xB2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MPEG4SINK_MOOV_BEFORE_MDAT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAC, 0xE3, 0x72, 0xF6,
                    0xE6, 0xE1,
                    0x10, 0x4F,
                    0xB5,
                    0xEC,
                    0x5F,
                    0x3B,
                    0x30,
                    0x82,
                    0x88,
                    0x16
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MPEG4SINK_MINIMUM_PROPERTIES_SIZE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0xED, 0xA1, 0xDC,
                    0x0E, 0x45,
                    0x22, 0x4A,
                    0x8C,
                    0x62,
                    0x4E,
                    0xD4,
                    0x52,
                    0xF7,
                    0xA1,
                    0x87
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MPEG4SINK_MIN_FRAGMENT_DURATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0C, 0x57, 0x0B, 0xA3,
                    0xFD, 0x8E,
                    0xE8, 0x45,
                    0x94,
                    0xFE,
                    0x27,
                    0xC8,
                    0x4B,
                    0x5B,
                    0xDF,
                    0xF6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MPEG4SINK_MAX_CODED_SEQUENCES_PER_FRAGMENT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD6, 0x3B, 0x1B, 0xFC,
                    0x2D, 0x69,
                    0xE5, 0x4C,
                    0x92,
                    0x99,
                    0x73,
                    0x8A,
                    0xA5,
                    0x46,
                    0x3E,
                    0x9A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SESSION_TOPOLOADER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0xD4, 0x83, 0x1E,
                    0x1C, 0x1F,
                    0x71, 0x45,
                    0x84,
                    0x05,
                    0x88,
                    0xF4,
                    0xB2,
                    0x18,
                    0x1F,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SESSION_GLOBAL_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0xD4, 0x83, 0x1E,
                    0x1C, 0x1F,
                    0x71, 0x45,
                    0x84,
                    0x05,
                    0x88,
                    0xF4,
                    0xB2,
                    0x18,
                    0x1F,
                    0x72
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SESSION_QUALITY_MANAGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0xD4, 0x83, 0x1E,
                    0x1C, 0x1F,
                    0x71, 0x45,
                    0x84,
                    0x05,
                    0x88,
                    0xF4,
                    0xB2,
                    0x18,
                    0x1F,
                    0x73
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SESSION_CONTENT_PROTECTION_MANAGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0xD4, 0x83, 0x1E,
                    0x1C, 0x1F,
                    0x71, 0x45,
                    0x84,
                    0x05,
                    0x88,
                    0xF4,
                    0xB2,
                    0x18,
                    0x1F,
                    0x74
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SESSION_SERVER_CONTEXT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x91, 0xB2, 0xE5, 0xAF,
                    0xFA, 0x50,
                    0xE8, 0x46,
                    0xB9,
                    0xBE,
                    0x0C,
                    0x0C,
                    0x3C,
                    0xE4,
                    0xB3,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SESSION_REMOTE_SOURCE_MODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF4, 0x3E, 0x03, 0xF4,
                    0xB3, 0x9B,
                    0x78, 0x43,
                    0x94,
                    0x1F,
                    0x85,
                    0xA0,
                    0x85,
                    0x6B,
                    0xC2,
                    0x44
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SESSION_APPROX_EVENT_OCCURRENCE_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2F, 0x85, 0x0E, 0x19,
                    0x38, 0x62,
                    0xD1, 0x42,
                    0xB5,
                    0xAF,
                    0x69,
                    0xEA,
                    0x33,
                    0x8E,
                    0xF8,
                    0x50
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PMP_SERVER_CONTEXT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0xC9, 0x00, 0x2F,
                    0xCF, 0xD2,
                    0x78, 0x42,
                    0x8B,
                    0x6A,
                    0xD0,
                    0x77,
                    0xFA,
                    0xC3,
                    0xA2,
                    0x5F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaSession(IMFAttributes* pConfiguration, IMFMediaSession** ppMediaSession);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePMPMediaSession([NativeTypeName("DWORD")] uint dwCreationFlags, IMFAttributes* pConfiguration, IMFMediaSession** ppMediaSession, IMFActivate** ppEnablerActivate);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSourceResolver(IMFSourceResolver** ppISourceResolver);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreatePropertyStore(IPropertyStore** ppStore);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetSupportedSchemes(PROPVARIANT* pPropVarSchemeArray);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetSupportedMimeTypes(PROPVARIANT* pPropVarMimeTypeArray);

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_SourceOpenMonitor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0x46, 0x4D, 0x07,
                    0xAE, 0xB5,
                    0x5D, 0x46,
                    0xAF,
                    0x17,
                    0x1A,
                    0x53,
                    0x8D,
                    0x28,
                    0x59,
                    0xDD,
                    0x02, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_ASFMediaSource_ApproxSeek
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0F, 0x27, 0xCD, 0xB4,
                    0x4D, 0x24,
                    0x69, 0x49,
                    0xBB,
                    0x92,
                    0x3F,
                    0x0F,
                    0xB8,
                    0x31,
                    0x6F,
                    0x10,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_ASFMediaSource_IterativeSeekIfNoIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDC, 0x65, 0x0B, 0x17,
                    0x4E, 0x4A,
                    0x7A, 0x40,
                    0xAC,
                    0x22,
                    0x57,
                    0x7F,
                    0x50,
                    0xE4,
                    0xA3,
                    0x7C,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_ASFMediaSource_IterativeSeek_Max_Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDC, 0x65, 0x0B, 0x17,
                    0x4E, 0x4A,
                    0x7A, 0x40,
                    0xAC,
                    0x22,
                    0x57,
                    0x7F,
                    0x50,
                    0xE4,
                    0xA3,
                    0x7C,
                    0x02, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecond
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDC, 0x65, 0x0B, 0x17,
                    0x4E, 0x4A,
                    0x7A, 0x40,
                    0xAC,
                    0x22,
                    0x57,
                    0x7F,
                    0x50,
                    0xE4,
                    0xA3,
                    0x7C,
                    0x03, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_Content_DLNA_Profile_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x45, 0x1B, 0xA3, 0xCF,
                    0x5D, 0x52,
                    0x98, 0x49,
                    0xBB,
                    0x44,
                    0x3F,
                    0x7D,
                    0x81,
                    0x54,
                    0x2F,
                    0xA4,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_MediaSource_DisableReadAhead
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x14, 0x6C, 0x36, 0x26,
                    0xBF, 0xC5,
                    0x76, 0x4C,
                    0x88,
                    0x7B,
                    0x9F,
                    0x17,
                    0x54,
                    0xDB,
                    0x5F,
                    0x09,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_SBESourceMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBB, 0x10, 0xAE, 0x3F,
                    0x59, 0xF8,
                    0x92, 0x41,
                    0xB5,
                    0x62,
                    0x18,
                    0x68,
                    0xD3,
                    0xDA,
                    0x3A,
                    0x02,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_PMP_Creation_Callback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE2, 0x4D, 0xBB, 0x28,
                    0xA2, 0x26,
                    0x70, 0x48,
                    0xB7,
                    0x20,
                    0xD2,
                    0x6B,
                    0xBE,
                    0xB1,
                    0x49,
                    0x42,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Enable_Urlmon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0xAF, 0xA8, 0xED,
                    0x71, 0xC1,
                    0x7F, 0x41,
                    0x8D,
                    0x17,
                    0x2E,
                    0x09,
                    0x18,
                    0x30,
                    0x32,
                    0x92,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Urlmon_Bind_Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0xAF, 0xA8, 0xED,
                    0x71, 0xC1,
                    0x7F, 0x41,
                    0x8D,
                    0x17,
                    0x2E,
                    0x09,
                    0x18,
                    0x30,
                    0x32,
                    0x92,
                    0x02, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Urlmon_Security_Id
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0xAF, 0xA8, 0xED,
                    0x71, 0xC1,
                    0x7F, 0x41,
                    0x8D,
                    0x17,
                    0x2E,
                    0x09,
                    0x18,
                    0x30,
                    0x32,
                    0x92,
                    0x03, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Urlmon_Window
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0xAF, 0xA8, 0xED,
                    0x71, 0xC1,
                    0x7F, 0x41,
                    0x8D,
                    0x17,
                    0x2E,
                    0x09,
                    0x18,
                    0x30,
                    0x32,
                    0x92,
                    0x04, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Urlmon_Callback_QueryService
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0xAF, 0xA8, 0xED,
                    0x71, 0xC1,
                    0x7F, 0x41,
                    0x8D,
                    0x17,
                    0x2E,
                    0x09,
                    0x18,
                    0x30,
                    0x32,
                    0x92,
                    0x05, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_MediaProtectionSystemId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1D, 0x27, 0x6B, 0x63,
                    0xC7, 0xDD,
                    0xE9, 0x49,
                    0xA6,
                    0xC6,
                    0x47,
                    0x38,
                    0x59,
                    0x62,
                    0xE5,
                    0xBD,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_MediaProtectionSystemContext
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1D, 0x27, 0x6B, 0x63,
                    0xC7, 0xDD,
                    0xE9, 0x49,
                    0xA6,
                    0xC6,
                    0x47,
                    0x38,
                    0x59,
                    0x62,
                    0xE5,
                    0xBD,
                    0x02, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_MediaProtectionSystemIdMapping
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1D, 0x27, 0x6B, 0x63,
                    0xC7, 0xDD,
                    0xE9, 0x49,
                    0xA6,
                    0xC6,
                    0x47,
                    0x38,
                    0x59,
                    0x62,
                    0xE5,
                    0xBD,
                    0x03, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_MediaProtectionContainerGuid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0x3D, 0xAF, 0x42,
                    0xCF, 0x00,
                    0x0F, 0x4A,
                    0x81,
                    0xF0,
                    0xAD,
                    0xF5,
                    0x24,
                    0xA5,
                    0xA5,
                    0xB5,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_MediaProtectionSystemContextsPerTrack
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0xB0, 0x54, 0x44,
                    0xDA, 0xD3,
                    0xB0, 0x49,
                    0x84,
                    0x52,
                    0x68,
                    0x50,
                    0xC7,
                    0xDB,
                    0x76,
                    0x4D,
                    0x03, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Download_Mode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB7, 0x11, 0x7F, 0x81,
                    0x82, 0xA9,
                    0xEC, 0x46,
                    0xA4,
                    0x49,
                    0xEF,
                    0x58,
                    0xAE,
                    0xD5,
                    0x3C,
                    0xA8,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Caching_Mode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3E, 0x40, 0xA2, 0x86,
                    0x8B, 0xC7,
                    0xD7, 0x44,
                    0x8B,
                    0xC8,
                    0xFF,
                    0x72,
                    0x58,
                    0x11,
                    0x75,
                    0x08,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFPKEY_HTTP_ByteStream_Cache_Limit
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3E, 0x40, 0xA2, 0x86,
                    0x8B, 0xC7,
                    0xD7, 0x44,
                    0x8B,
                    0xC8,
                    0xFF,
                    0x72,
                    0x58,
                    0x11,
                    0x75,
                    0x08,
                    0x02, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TIME_FORMAT_ENTRY_RELATIVE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x78, 0xF1, 0x99, 0x43,
                    0xD3, 0x46,
                    0x04, 0x45,
                    0xAF,
                    0xDA,
                    0x20,
                    0xD3,
                    0x2E,
                    0x9B,
                    0xA3,
                    0x60
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SOURCE_STREAM_SUPPORTS_HW_CONNECTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAA, 0x53, 0x82, 0xA3,
                    0x14, 0x63,
                    0xFD, 0x42,
                    0xA3,
                    0xCE,
                    0xBB,
                    0x27,
                    0xB6,
                    0x85,
                    0x99,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_STREAM_SINK_SUPPORTS_HW_CONNECTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBF, 0x5C, 0x46, 0x9B,
                    0x97, 0x05,
                    0x9E, 0x4F,
                    0x9F,
                    0x3C,
                    0xB9,
                    0x7E,
                    0xEE,
                    0xF9,
                    0x03,
                    0x59
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_STREAM_SINK_SUPPORTS_ROTATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x62, 0xE9, 0xB3,
                    0x05, 0xBD,
                    0xA5, 0x41,
                    0x97,
                    0xAD,
                    0x8A,
                    0x7F,
                    0xEE,
                    0x24,
                    0xB9,
                    0x12
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SINK_VIDEO_PTS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0xBD, 0x62, 0x21,
                    0x1E, 0x42,
                    0x90, 0x4B,
                    0x9B,
                    0x33,
                    0xE5,
                    0x8F,
                    0xBF,
                    0x1D,
                    0x58,
                    0xB6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SINK_VIDEO_NATIVE_WIDTH
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x07, 0xA7, 0xD6, 0xE6,
                    0x05, 0x15,
                    0x47, 0x47,
                    0x9B,
                    0x10,
                    0x72,
                    0xD2,
                    0xD1,
                    0x58,
                    0xCB,
                    0x3A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SINK_VIDEO_NATIVE_HEIGHT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x05, 0x67, 0xCA, 0xF0,
                    0x0C, 0x49,
                    0xE8, 0x43,
                    0x94,
                    0x1C,
                    0xC0,
                    0xB3,
                    0x20,
                    0x6B,
                    0x9A,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SINK_VIDEO_DISPLAY_ASPECT_RATIO_NUMERATOR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0x3B, 0xF3, 0xD0,
                    0x8A, 0xB7,
                    0x79, 0x48,
                    0xB4,
                    0x55,
                    0xF0,
                    0x3E,
                    0xF3,
                    0xFA,
                    0x82,
                    0xCD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SINK_VIDEO_DISPLAY_ASPECT_RATIO_DENOMINATOR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x97, 0xEB, 0xA1, 0x6E,
                    0xE0, 0x1F,
                    0x10, 0x4F,
                    0xA6,
                    0xE4,
                    0x1F,
                    0x4F,
                    0x66,
                    0x15,
                    0x64,
                    0xE0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_BD_MVC_PLANE_OFFSET_METADATA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE4, 0x54, 0xA6, 0x62,
                    0x6C, 0xB7,
                    0x01, 0x49,
                    0x98,
                    0x23,
                    0x2C,
                    0xB6,
                    0x15,
                    0xD4,
                    0x73,
                    0x18
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_LUMA_KEY_ENABLE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0F, 0x82, 0x69, 0x73,
                    0xDE, 0x76,
                    0xCA, 0x43,
                    0x92,
                    0x84,
                    0x47,
                    0xB8,
                    0xF3,
                    0x7E,
                    0x06,
                    0x49
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_LUMA_KEY_LOWER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD5, 0xB8, 0xD7, 0x93,
                    0x81, 0x0B,
                    0x15, 0x47,
                    0xAE,
                    0xA0,
                    0x87,
                    0x25,
                    0x87,
                    0x16,
                    0x21,
                    0xE9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_LUMA_KEY_UPPER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBB, 0x39, 0x9F, 0xD0,
                    0x02, 0x46,
                    0x31, 0x4C,
                    0xA7,
                    0x06,
                    0xA1,
                    0x21,
                    0x71,
                    0xA5,
                    0x11,
                    0x0A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_USER_EXTENDED_ATTRIBUTES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC6, 0xBA, 0x2A, 0xC0,
                    0xB2, 0xFE,
                    0x41, 0x45,
                    0x92,
                    0x2F,
                    0x92,
                    0x0B,
                    0x43,
                    0x70,
                    0x27,
                    0x22
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_INDEPENDENT_STILL_IMAGE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0xAF, 0x12, 0xEA,
                    0x10, 0x07,
                    0xC9, 0x42,
                    0xA1,
                    0x27,
                    0xDA,
                    0xA3,
                    0xE7,
                    0x84,
                    0x83,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_XVP_SAMPLE_LOCK_TIMEOUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x29, 0xDB, 0x4D, 0xAA,
                    0x34, 0x51,
                    0x63, 0x43,
                    0xAC,
                    0x72,
                    0x83,
                    0xEC,
                    0x4B,
                    0xC1,
                    0x04,
                    0x26
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPOLOGY_PROJECTSTART
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0xF8, 0xD3, 0x7E,
                    0xBB, 0x86,
                    0x3F, 0x4B,
                    0xB7,
                    0xE4,
                    0x7C,
                    0xB4,
                    0x3A,
                    0xFD,
                    0x4B,
                    0x80
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPOLOGY_PROJECTSTOP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0xF8, 0xD3, 0x7E,
                    0xBB, 0x86,
                    0x3F, 0x4B,
                    0xB7,
                    0xE4,
                    0x7C,
                    0xB4,
                    0x3A,
                    0xFD,
                    0x4B,
                    0x80
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPOLOGY_NO_MARKIN_MARKOUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x04, 0xF8, 0xD3, 0x7E,
                    0xBB, 0x86,
                    0x3F, 0x4B,
                    0xB7,
                    0xE4,
                    0x7C,
                    0xB4,
                    0x3A,
                    0xFD,
                    0x4B,
                    0x80
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPOLOGY_DXVA_MODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF6, 0x34, 0x8D, 0x1E,
                    0xAB, 0xF5,
                    0x23, 0x4E,
                    0xBB,
                    0x88,
                    0x87,
                    0x4A,
                    0xA3,
                    0xA1,
                    0xA7,
                    0x4D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPOLOGY_ENABLE_XVP_FOR_PLAYBACK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1F, 0x73, 0x67, 0x19,
                    0x78, 0xCD,
                    0xFC, 0x42,
                    0xB0,
                    0x26,
                    0x09,
                    0x92,
                    0xA5,
                    0x6E,
                    0x56,
                    0x93
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPOLOGY_STATIC_PLAYBACK_OPTIMIZATIONS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x42, 0xAC, 0x6C, 0xB8,
                    0xA6, 0x41,
                    0x79, 0x4B,
                    0x89,
                    0x7A,
                    0x1A,
                    0xB0,
                    0xE5,
                    0x2B,
                    0x4A,
                    0x1B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPOLOGY_PLAYBACK_MAX_DIMS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x19, 0xCF, 0x15, 0x57,
                    0x68, 0x57,
                    0xAA, 0x44,
                    0xAD,
                    0x6E,
                    0x87,
                    0x21,
                    0xF1,
                    0xB0,
                    0xF9,
                    0xBB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPOLOGY_HARDWARE_MODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFD, 0x62, 0xD3, 0xD2,
                    0x4F, 0x4E,
                    0x91, 0x41,
                    0xA5,
                    0x79,
                    0xC6,
                    0x18,
                    0xB6,
                    0x67,
                    0x06,
                    0xAF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPOLOGY_PLAYBACK_FRAMERATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7A, 0x73, 0x64, 0xC1,
                    0xB1, 0xC2,
                    0x53, 0x45,
                    0x83,
                    0xBB,
                    0x5A,
                    0x52,
                    0x60,
                    0x72,
                    0x44,
                    0x8F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPOLOGY_DYNAMIC_CHANGE_NOT_ALLOWED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0B, 0x95, 0x29, 0xD5,
                    0x84, 0xD4,
                    0x27, 0x45,
                    0xA9,
                    0xCD,
                    0xB1,
                    0x90,
                    0x95,
                    0x32,
                    0xB5,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPOLOGY_ENUMERATE_SOURCE_TYPES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6D, 0xC3, 0x48, 0x62,
                    0x0B, 0x5D,
                    0x40, 0x4F,
                    0xA0,
                    0xBB,
                    0xB0,
                    0xB3,
                    0x05,
                    0xF7,
                    0x76,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPOLOGY_START_TIME_ON_PRESENTATION_SWITCH
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3F, 0x11, 0xCC, 0xC8,
                    0x51, 0x79,
                    0x48, 0x45,
                    0xAA,
                    0xD6,
                    0x9E,
                    0xD6,
                    0x20,
                    0x2E,
                    0x62,
                    0xB3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DISABLE_LOCALLY_REGISTERED_PLUGINS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA9, 0x6D, 0xB1, 0x66,
                    0xD4, 0xAD,
                    0xE0, 0x47,
                    0xA1,
                    0x6B,
                    0x5A,
                    0xF1,
                    0xFB,
                    0x48,
                    0x36,
                    0x34
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_LOCAL_PLUGIN_CONTROL_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0x00, 0x1B, 0xD9,
                    0x6D, 0xC8,
                    0x81, 0x4F,
                    0x88,
                    0x22,
                    0x8C,
                    0x68,
                    0xE1,
                    0xD7,
                    0xFA,
                    0x04
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTopology(IMFTopology** ppTopo);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_FLUSH
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE8, 0xBC, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_DRAIN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE9, 0xBC, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_D3DAWARE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xED, 0xBC, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPOLOGY_RESOLUTION_STATUS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDE, 0xBC, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_ERRORCODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0xBC, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_CONNECT_METHOD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0xBC, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_LOCKED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF7, 0xBC, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_WORKQUEUE_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF8, 0xBC, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_WORKQUEUE_MMCSS_CLASS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0xBC, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_DECRYPTOR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFA, 0xBC, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_DISCARDABLE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFB, 0xBC, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_ERROR_MAJORTYPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFD, 0xBC, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_ERROR_SUBTYPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFE, 0xBC, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_WORKQUEUE_MMCSS_TASKID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFF, 0xBC, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_WORKQUEUE_MMCSS_PRIORITY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0xF8, 0x01, 0x50,
                    0x16, 0x28,
                    0xF4, 0x48,
                    0x93,
                    0x64,
                    0xAD,
                    0x1E,
                    0xF6,
                    0x61,
                    0xA1,
                    0x23
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_WORKQUEUE_ITEM_PRIORITY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBE, 0x99, 0xFF, 0xA1,
                    0x97, 0x5E,
                    0x53, 0x4A,
                    0xB4,
                    0x94,
                    0x56,
                    0x8C,
                    0x64,
                    0x2C,
                    0x0F,
                    0xF3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_MARKIN_HERE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0xBD, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_MARKOUT_HERE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0xBD, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_DECODER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0xBD, 0x4B, 0x49,
                    0x31, 0xB0,
                    0x38, 0x4E,
                    0x97,
                    0xC4,
                    0xD5,
                    0x42,
                    0x2D,
                    0xD6,
                    0x18,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_MEDIASTART
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEA, 0x58, 0x5C, 0x83,
                    0x75, 0xE0,
                    0xC7, 0x4B,
                    0xBC,
                    0xBA,
                    0x4D,
                    0xE0,
                    0x00,
                    0xDF,
                    0x9A,
                    0xE6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_MEDIASTOP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEB, 0x58, 0x5C, 0x83,
                    0x75, 0xE0,
                    0xC7, 0x4B,
                    0xBC,
                    0xBA,
                    0x4D,
                    0xE0,
                    0x00,
                    0xDF,
                    0x9A,
                    0xE6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_SOURCE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEC, 0x58, 0x5C, 0x83,
                    0x75, 0xE0,
                    0xC7, 0x4B,
                    0xBC,
                    0xBA,
                    0x4D,
                    0xE0,
                    0x00,
                    0xDF,
                    0x9A,
                    0xE6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_PRESENTATION_DESCRIPTOR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xED, 0x58, 0x5C, 0x83,
                    0x75, 0xE0,
                    0xC7, 0x4B,
                    0xBC,
                    0xBA,
                    0x4D,
                    0xE0,
                    0x00,
                    0xDF,
                    0x9A,
                    0xE6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_STREAM_DESCRIPTOR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0x58, 0x5C, 0x83,
                    0x75, 0xE0,
                    0xC7, 0x4B,
                    0xBC,
                    0xBA,
                    0x4D,
                    0xE0,
                    0x00,
                    0xDF,
                    0x9A,
                    0xE6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_SEQUENCE_ELEMENTID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEF, 0x58, 0x5C, 0x83,
                    0x75, 0xE0,
                    0xC7, 0x4B,
                    0xBC,
                    0xBA,
                    0x4D,
                    0xE0,
                    0x00,
                    0xDF,
                    0x9A,
                    0xE6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_TRANSFORM_OBJECTID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC9, 0xC0, 0xDC, 0x88,
                    0x3E, 0x29,
                    0x8B, 0x4E,
                    0x9A,
                    0xEB,
                    0x0A,
                    0xD6,
                    0x4C,
                    0xC0,
                    0x16,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_STREAMID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9B, 0x2F, 0x93, 0x14,
                    0x87, 0x90,
                    0xB4, 0x4B,
                    0x84,
                    0x12,
                    0x51,
                    0x67,
                    0x14,
                    0x5C,
                    0xBE,
                    0x04
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_NOSHUTDOWN_ON_REMOVE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9C, 0x2F, 0x93, 0x14,
                    0x87, 0x90,
                    0xB4, 0x4B,
                    0x84,
                    0x12,
                    0x51,
                    0x67,
                    0x14,
                    0x5C,
                    0xBE,
                    0x04
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_RATELESS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9D, 0x2F, 0x93, 0x14,
                    0x87, 0x90,
                    0xB4, 0x4B,
                    0x84,
                    0x12,
                    0x51,
                    0x67,
                    0x14,
                    0x5C,
                    0xBE,
                    0x04
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_DISABLE_PREROLL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9E, 0x2F, 0x93, 0x14,
                    0x87, 0x90,
                    0xB4, 0x4B,
                    0x84,
                    0x12,
                    0x51,
                    0x67,
                    0x14,
                    0x5C,
                    0xBE,
                    0x04
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_PRIMARYOUTPUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x99, 0xEF, 0x04, 0x63,
                    0xB2, 0x16,
                    0xBE, 0x4E,
                    0x9D,
                    0x67,
                    0xE4,
                    0xC5,
                    0x39,
                    0xB3,
                    0xA2,
                    0x59
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTopologyNode(MF_TOPOLOGY_TYPE NodeType, IMFTopologyNode** ppNode);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetTopoNodeCurrentType(IMFTopologyNode* pNode, [NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL")] int fOutput, IMFMediaType** ppType);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetService(IUnknown* punkObject, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("MFTIME")]
        public static extern long MFGetSystemTime();

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePresentationClock(IMFPresentationClock** ppPresentationClock);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSystemTimeSource(IMFPresentationTimeSource** ppSystemTimeSource);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PD_PMPHOST_CONTEXT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x31, 0x0D, 0x99, 0x6C,
                    0x8E, 0xBB,
                    0x7A, 0x47,
                    0x85,
                    0x98,
                    0x0D,
                    0x5D,
                    0x96,
                    0xFC,
                    0xD8,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PD_APP_CONTEXT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x32, 0x0D, 0x99, 0x6C,
                    0x8E, 0xBB,
                    0x7A, 0x47,
                    0x85,
                    0x98,
                    0x0D,
                    0x5D,
                    0x96,
                    0xFC,
                    0xD8,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PD_DURATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x33, 0x0D, 0x99, 0x6C,
                    0x8E, 0xBB,
                    0x7A, 0x47,
                    0x85,
                    0x98,
                    0x0D,
                    0x5D,
                    0x96,
                    0xFC,
                    0xD8,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PD_TOTAL_FILE_SIZE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x34, 0x0D, 0x99, 0x6C,
                    0x8E, 0xBB,
                    0x7A, 0x47,
                    0x85,
                    0x98,
                    0x0D,
                    0x5D,
                    0x96,
                    0xFC,
                    0xD8,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PD_AUDIO_ENCODING_BITRATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x35, 0x0D, 0x99, 0x6C,
                    0x8E, 0xBB,
                    0x7A, 0x47,
                    0x85,
                    0x98,
                    0x0D,
                    0x5D,
                    0x96,
                    0xFC,
                    0xD8,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PD_VIDEO_ENCODING_BITRATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x36, 0x0D, 0x99, 0x6C,
                    0x8E, 0xBB,
                    0x7A, 0x47,
                    0x85,
                    0x98,
                    0x0D,
                    0x5D,
                    0x96,
                    0xFC,
                    0xD8,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PD_MIME_TYPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0x0D, 0x99, 0x6C,
                    0x8E, 0xBB,
                    0x7A, 0x47,
                    0x85,
                    0x98,
                    0x0D,
                    0x5D,
                    0x96,
                    0xFC,
                    0xD8,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PD_LAST_MODIFIED_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x38, 0x0D, 0x99, 0x6C,
                    0x8E, 0xBB,
                    0x7A, 0x47,
                    0x85,
                    0x98,
                    0x0D,
                    0x5D,
                    0x96,
                    0xFC,
                    0xD8,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PD_PLAYBACK_ELEMENT_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0x0D, 0x99, 0x6C,
                    0x8E, 0xBB,
                    0x7A, 0x47,
                    0x85,
                    0x98,
                    0x0D,
                    0x5D,
                    0x96,
                    0xFC,
                    0xD8,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PD_PREFERRED_LANGUAGE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3A, 0x0D, 0x99, 0x6C,
                    0x8E, 0xBB,
                    0x7A, 0x47,
                    0x85,
                    0x98,
                    0x0D,
                    0x5D,
                    0x96,
                    0xFC,
                    0xD8,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PD_PLAYBACK_BOUNDARY_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3B, 0x0D, 0x99, 0x6C,
                    0x8E, 0xBB,
                    0x7A, 0x47,
                    0x85,
                    0x98,
                    0x0D,
                    0x5D,
                    0x96,
                    0xFC,
                    0xD8,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PD_AUDIO_ISVARIABLEBITRATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0x6E, 0x02, 0x33,
                    0x87, 0xE3,
                    0x82, 0x45,
                    0xAE,
                    0x0A,
                    0x34,
                    0xA2,
                    0xAD,
                    0x3B,
                    0xAA,
                    0x18
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_PD_ADAPTIVE_STREAMING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x97, 0x5D, 0x0D, 0xEA,
                    0xF9, 0x29,
                    0x8B, 0x48,
                    0xAE,
                    0x6B,
                    0x7D,
                    0x6B,
                    0x41,
                    0x36,
                    0x11,
                    0x2B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePresentationDescriptor([NativeTypeName("DWORD")] uint cStreamDescriptors, IMFStreamDescriptor** apStreamDescriptors, IMFPresentationDescriptor** ppPresentationDescriptor);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRequireProtectedEnvironment(IMFPresentationDescriptor* pPresentationDescriptor);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFSerializePresentationDescriptor(IMFPresentationDescriptor* pPD, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BYTE **")] byte** ppbData);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFDeserializePresentationDescriptor([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("BYTE *")] byte* pbData, IMFPresentationDescriptor** ppPD);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SD_LANGUAGE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x21, 0xAF, 0x00,
                    0xC2, 0xBD,
                    0x3C, 0x42,
                    0xAB,
                    0xCA,
                    0xF5,
                    0x03,
                    0x59,
                    0x3B,
                    0xC1,
                    0x21
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SD_PROTECTED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0x21, 0xAF, 0x00,
                    0xC2, 0xBD,
                    0x3C, 0x42,
                    0xAB,
                    0xCA,
                    0xF5,
                    0x03,
                    0x59,
                    0x3B,
                    0xC1,
                    0x21
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SD_STREAM_NAME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9D, 0x09, 0x1B, 0x4F,
                    0x14, 0xD3,
                    0xE5, 0x41,
                    0xA7,
                    0x81,
                    0x7F,
                    0xEF,
                    0xAA,
                    0x4C,
                    0x50,
                    0x1F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SD_MUTUALLY_EXCLUSIVE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9C, 0xF7, 0x3E, 0x02,
                    0x8D, 0x38,
                    0x7F, 0x48,
                    0xAC,
                    0x17,
                    0x69,
                    0x6C,
                    0xD6,
                    0xE3,
                    0xC6,
                    0xF5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateStreamDescriptor([NativeTypeName("DWORD")] uint dwStreamIdentifier, [NativeTypeName("DWORD")] uint cMediaTypes, IMFMediaType** apMediaTypes, IMFStreamDescriptor** ppDescriptor);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSimpleTypeHandler(IMFMediaTypeHandler** ppHandler);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_MIXER_CLSID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0x13, 0x49, 0xBA,
                    0x50, 0xBE,
                    0x1E, 0x45,
                    0x95,
                    0xAB,
                    0x6D,
                    0x4A,
                    0xCC,
                    0xC7,
                    0xDA,
                    0xD8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_MIXER_ACTIVATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x13, 0x49, 0xBA,
                    0x50, 0xBE,
                    0x1E, 0x45,
                    0x95,
                    0xAB,
                    0x6D,
                    0x4A,
                    0xCC,
                    0xC7,
                    0xDA,
                    0xD8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_MIXER_FLAGS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0x13, 0x49, 0xBA,
                    0x50, 0xBE,
                    0x1E, 0x45,
                    0x95,
                    0xAB,
                    0x6D,
                    0x4A,
                    0xCC,
                    0xC7,
                    0xDA,
                    0xD8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_CLSID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x13, 0x49, 0xBA,
                    0x50, 0xBE,
                    0x1E, 0x45,
                    0x95,
                    0xAB,
                    0x6D,
                    0x4A,
                    0xCC,
                    0xC7,
                    0xDA,
                    0xD8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_ACTIVATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x65, 0x13, 0x49, 0xBA,
                    0x50, 0xBE,
                    0x1E, 0x45,
                    0x95,
                    0xAB,
                    0x6D,
                    0x4A,
                    0xCC,
                    0xC7,
                    0xDA,
                    0xD8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_FLAGS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0x13, 0x49, 0xBA,
                    0x50, 0xBE,
                    0x1E, 0x45,
                    0x95,
                    0xAB,
                    0x6D,
                    0x4A,
                    0xCC,
                    0xC7,
                    0xDA,
                    0xD8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_ACTIVATE_MFT_LOCKED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3C, 0x09, 0xF6, 0xC1,
                    0x65, 0x7F,
                    0xBD, 0x4F,
                    0x9E,
                    0x39,
                    0x5F,
                    0xAE,
                    0xC3,
                    0xC4,
                    0xFB,
                    0xD7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_ACTIVATE_VIDEO_WINDOW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDD, 0xBB, 0x2D, 0x9A,
                    0x7E, 0xF5,
                    0x62, 0x41,
                    0x82,
                    0xB9,
                    0x68,
                    0x31,
                    0x37,
                    0x76,
                    0x82,
                    0xD3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFShutdownObject(IUnknown* pUnk);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAudioRenderer(IMFAttributes* pAudioAttributes, IMFMediaSink** ppSink);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAudioRendererActivate(IMFActivate** ppActivate);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0xB5, 0xE4, 0xED,
                    0x05, 0xF8,
                    0x6C, 0x4D,
                    0x99,
                    0xB3,
                    0xDB,
                    0x01,
                    0xBF,
                    0x95,
                    0xDF,
                    0xAB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_SESSION_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE3, 0xB5, 0xE4, 0xED,
                    0x05, 0xF8,
                    0x6C, 0x4D,
                    0x99,
                    0xB3,
                    0xDB,
                    0x01,
                    0xBF,
                    0x95,
                    0xDF,
                    0xAB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC3, 0xAE, 0x0A, 0xB1,
                    0x71, 0xEF,
                    0xC3, 0x4C,
                    0xB8,
                    0x73,
                    0x05,
                    0xA9,
                    0xA0,
                    0x8B,
                    0x9F,
                    0x8E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ROLE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFF, 0x44, 0xA6, 0x6B,
                    0xC5, 0x27,
                    0x02, 0x4D,
                    0x98,
                    0x87,
                    0xC2,
                    0x86,
                    0x19,
                    0xFD,
                    0xB9,
                    0x1B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_STREAM_CATEGORY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x71, 0x04, 0x77, 0xA9,
                    0xEC, 0x92,
                    0xF4, 0x4D,
                    0x94,
                    0xFE,
                    0x81,
                    0xC3,
                    0x6F,
                    0x0C,
                    0x3A,
                    0x7A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoRendererActivate([NativeTypeName("HWND")] IntPtr hwndVideo, IMFActivate** ppActivate);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMPEG4MediaSink(IMFByteStream* pIByteStream, IMFMediaType* pVideoMediaType, IMFMediaType* pAudioMediaType, IMFMediaSink** ppIMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreate3GPMediaSink(IMFByteStream* pIByteStream, IMFMediaType* pVideoMediaType, IMFMediaType* pAudioMediaType, IMFMediaSink** ppIMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMP3MediaSink(IMFByteStream* pTargetByteStream, IMFMediaSink** ppMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAC3MediaSink(IMFByteStream* pTargetByteStream, IMFMediaType* pAudioMediaType, IMFMediaSink** ppMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateADTSMediaSink(IMFByteStream* pTargetByteStream, IMFMediaType* pAudioMediaType, IMFMediaSink** ppMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMuxSink([NativeTypeName("GUID")] Guid guidOutputSubType, IMFAttributes* pOutputAttributes, IMFByteStream* pOutputByteStream, IMFMediaSink** ppMuxSink);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateFMPEG4MediaSink(IMFByteStream* pIByteStream, IMFMediaType* pVideoMediaType, IMFMediaType* pAudioMediaType, IMFMediaSink** ppIMediaSink);

        [DllImport("mfsrcsnk", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAVIMediaSink(IMFByteStream* pIByteStream, IMFMediaType* pVideoMediaType, IMFMediaType* pAudioMediaType, IMFMediaSink** ppIMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateWAVEMediaSink(IMFByteStream* pTargetByteStream, IMFMediaType* pAudioMediaType, IMFMediaSink** ppMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTopoLoader(IMFTopoLoader** ppObj);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFENABLETYPE_WMDRMV1_LicenseAcquisition
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAF, 0xEE, 0xF6, 0x4F,
                    0x43, 0x0B,
                    0x97, 0x47,
                    0x9B,
                    0x85,
                    0xAB,
                    0xF3,
                    0x18,
                    0x15,
                    0xE7,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFENABLETYPE_WMDRMV7_LicenseAcquisition
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0x06, 0x33, 0x00,
                    0x06, 0x4A,
                    0x84, 0x48,
                    0xA0,
                    0x97,
                    0xEF,
                    0x6D,
                    0x22,
                    0xEC,
                    0x84,
                    0xA3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFENABLETYPE_WMDRMV7_Individualization
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4A, 0xC8, 0xD2, 0xAC,
                    0x03, 0xB3,
                    0x65, 0x4F,
                    0xBC,
                    0x2C,
                    0x2C,
                    0x84,
                    0x8D,
                    0x01,
                    0xA9,
                    0x89
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFENABLETYPE_MF_UpdateRevocationInformation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB5, 0xB0, 0x58, 0xE5,
                    0xC4, 0xB3,
                    0xA0, 0x44,
                    0x92,
                    0x4C,
                    0x50,
                    0xD1,
                    0x78,
                    0x93,
                    0x23,
                    0x85
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFENABLETYPE_MF_UpdateUntrustedComponent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD6, 0xF3, 0x79, 0x98,
                    0xE2, 0xCE,
                    0xE6, 0x48,
                    0xB5,
                    0x73,
                    0x97,
                    0x67,
                    0xAB,
                    0x17,
                    0x2F,
                    0x16
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFENABLETYPE_MF_RebootRequired
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4B, 0x3D, 0x4D, 0x6D,
                    0xCE, 0x0E,
                    0x52, 0x46,
                    0x8B,
                    0x3A,
                    0xF2,
                    0xD2,
                    0x42,
                    0x60,
                    0xD8,
                    0x87
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_METADATA_PROVIDER_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x84, 0x40, 0x21, 0xDB,
                    0xA4, 0x58,
                    0x2E, 0x4D,
                    0xB8,
                    0x4F,
                    0x6F,
                    0x75,
                    0x5B,
                    0x2F,
                    0x7A,
                    0x0D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PROPERTY_HANDLER_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0xCE, 0xFA, 0xA3,
                    0xB8, 0x32,
                    0xDD, 0x41,
                    0x90,
                    0xE7,
                    0x5F,
                    0xEF,
                    0x7C,
                    0x89,
                    0x91,
                    0xB5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_RATE_CONTROL_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x97, 0xA2, 0x6F, 0x86,
                    0x02, 0xB8,
                    0xF8, 0x4B,
                    0x9D,
                    0xC9,
                    0x5E,
                    0x3B,
                    0x6A,
                    0x9F,
                    0x53,
                    0xC9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TIMECODE_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA7, 0x02, 0xD5, 0xA0,
                    0xB3, 0x0E,
                    0x85, 0x48,
                    0xB1,
                    0xB9,
                    0x9F,
                    0xEB,
                    0x0D,
                    0x08,
                    0x34,
                    0x54
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MR_POLICY_VOLUME_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAC, 0xA2, 0xBA, 0x1A,
                    0x3B, 0x9D,
                    0xC6, 0x47,
                    0xAB,
                    0x48,
                    0xC5,
                    0x95,
                    0x06,
                    0xDE,
                    0x78,
                    0x4D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MR_CAPTURE_POLICY_VOLUME_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCD, 0x0A, 0x03, 0x24,
                    0x7A, 0x10,
                    0x65, 0x42,
                    0x97,
                    0x5C,
                    0x41,
                    0x4E,
                    0x33,
                    0xE6,
                    0x5F,
                    0x2A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MR_STREAM_VOLUME_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2F, 0xFA, 0xB5, 0xF8,
                    0xEF, 0x32,
                    0xF5, 0x46,
                    0xB1,
                    0x72,
                    0x13,
                    0x21,
                    0x21,
                    0x2F,
                    0xB2,
                    0xC4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MR_AUDIO_POLICY_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0xD7, 0x1F, 0x91,
                    0x75, 0x67,
                    0xB0, 0x4A,
                    0xA6,
                    0x14,
                    0x29,
                    0x78,
                    0x62,
                    0xFD,
                    0xAC,
                    0x88
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSampleGrabberSinkActivate(IMFMediaType* pIMFMediaType, IMFSampleGrabberSinkCallback* pIMFSampleGrabberSinkCallback, IMFActivate** ppIActivate);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SAMPLEGRABBERSINK_SAMPLE_TIME_OFFSET
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0xD7, 0xE3, 0x62,
                    0x00, 0x81,
                    0x03, 0x4E,
                    0xA6,
                    0xE8,
                    0xBD,
                    0x38,
                    0x57,
                    0xAC,
                    0x9C,
                    0x47
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SAMPLEGRABBERSINK_IGNORE_CLOCK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0xA2, 0xFD, 0x0E,
                    0x69, 0x2B,
                    0x2E, 0x4E,
                    0xAB,
                    0x8D,
                    0x46,
                    0xDC,
                    0xBF,
                    0xF7,
                    0xD2,
                    0x5D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_QUALITY_SERVICES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x11, 0xBE, 0xE2, 0xB7,
                    0x96, 0x2F,
                    0x40, 0x46,
                    0xB5,
                    0x2C,
                    0x28,
                    0x23,
                    0x65,
                    0xBD,
                    0xF1,
                    0x6C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_WORKQUEUE_SERVICES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x89, 0xD4, 0x37, 0x8E,
                    0xE0, 0x41,
                    0x3A, 0x41,
                    0x90,
                    0x68,
                    0x28,
                    0x7C,
                    0x88,
                    0x6D,
                    0x8D,
                    0xDA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateStandardQualityManager(IMFQualityManager** ppQualityManager);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_QUALITY_NOTIFY_PROCESSING_LATENCY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF8, 0x4A, 0xB4, 0xF6,
                    0x4D, 0x60,
                    0xFE, 0x46,
                    0xA9,
                    0x5D,
                    0x45,
                    0x47,
                    0x9B,
                    0x10,
                    0xC9,
                    0xBC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_QUALITY_NOTIFY_SAMPLE_LAG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x06, 0x52, 0xD1, 0x30,
                    0x2A, 0xED,
                    0x60, 0x47,
                    0xBE,
                    0x17,
                    0xEB,
                    0x4A,
                    0x9F,
                    0x12,
                    0x29,
                    0x5C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TIME_FORMAT_SEGMENT_OFFSET
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x77, 0xBE, 0xB8, 0xC8,
                    0x9C, 0x86,
                    0x1D, 0x43,
                    0x81,
                    0x2E,
                    0x16,
                    0x96,
                    0x93,
                    0xF6,
                    0x5A,
                    0x39
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSequencerSource(IUnknown* pReserved, IMFSequencerSource** ppSequencerSource);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSequencerSegmentOffset([NativeTypeName("MFSequencerElementId")] uint dwId, [NativeTypeName("MFTIME")] long hnsOffset, PROPVARIANT* pvarSegmentOffset);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAggregateSource(IMFCollection* pSourceCollection, IMFMediaSource** ppAggSource);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SOURCE_PRESENTATION_PROVIDER_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDC, 0xAA, 0x02, 0xE0,
                    0xAF, 0xF4,
                    0xE5, 0x4E,
                    0x98,
                    0x47,
                    0x05,
                    0x3E,
                    0xDF,
                    0x84,
                    0x04,
                    0x26
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TOPONODE_ATTRIBUTE_EDITOR_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1A, 0x6E, 0x65, 0x65,
                    0x7F, 0x07,
                    0x72, 0x44,
                    0x83,
                    0xEF,
                    0x31,
                    0x6F,
                    0x11,
                    0xD5,
                    0x08,
                    0x7A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateCredentialCache(IMFNetCredentialCache** ppCache);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_SSLCERTIFICATE_MANAGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x27, 0xCB, 0xE6, 0x55,
                    0x9B, 0xE6,
                    0x67, 0x42,
                    0x94,
                    0x0C,
                    0x2D,
                    0x7E,
                    0xC5,
                    0xBB,
                    0x8A,
                    0x0F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_RESOURCE_FILTER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF6, 0x0F, 0x5D, 0x81,
                    0x5A, 0x26,
                    0x77, 0x44,
                    0x9E,
                    0x46,
                    0x7B,
                    0x80,
                    0xAD,
                    0x80,
                    0xB5,
                    0xFB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateProxyLocator([NativeTypeName("LPCWSTR")] ushort* pszProtocol, IPropertyStore* pProxyConfig, IMFNetProxyLocator** ppProxyLocator);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNET_SAVEJOB_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7F, 0x58, 0x5A, 0xB8,
                    0x02, 0x3D,
                    0x52, 0x4E,
                    0x95,
                    0x65,
                    0x55,
                    0xD3,
                    0xEC,
                    0x1E,
                    0x7F,
                    0xF7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateNetSchemePlugin([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvHandler);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_STATISTICS_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x75, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_STATISTICS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_BUFFERINGTIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_ACCELERATEDSTREAMINGDURATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x77, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_MAXUDPACCELERATEDSTREAMINGDURATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x79, 0x28, 0xAB, 0x4A,
                    0xE1, 0xBB,
                    0x94, 0x49,
                    0x9F,
                    0xF0,
                    0x54,
                    0x95,
                    0xBD,
                    0x25,
                    0x01,
                    0x29
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_MAXBUFFERTIMEMS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE6, 0x24, 0x8B, 0x40,
                    0x38, 0x40,
                    0x01, 0x44,
                    0xB5,
                    0xB2,
                    0xFE,
                    0x70,
                    0x1A,
                    0x9E,
                    0xBF,
                    0x10
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_CONNECTIONBANDWIDTH
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x78, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_CACHEENABLED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x79, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_AUTORECONNECTLIMIT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7A, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_RESENDSENABLED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7B, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_THINNINGENABLED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PROTOCOL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7D, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_TRANSPORT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7E, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PREVIEWMODEENABLED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7F, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_CREDENTIAL_MANAGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PPBANDWIDTH
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_AUTORECONNECTPROGRESS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PROXYLOCATORFACTORY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_BROWSERUSERAGENT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8B, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_BROWSERWEBPAGE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8C, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PLAYERVERSION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8D, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PLAYERID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8E, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_HOSTEXE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8F, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_HOSTVERSION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x91, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PLAYERUSERAGENT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_CLIENTGUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA6, 0xC4, 0xA2, 0x60,
                    0x97, 0xF1,
                    0x14, 0x4C,
                    0xA5,
                    0xBF,
                    0x88,
                    0x83,
                    0x0D,
                    0x24,
                    0x58,
                    0xAF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_LOGURL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x93, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_ENABLE_UDP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x94, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_ENABLE_TCP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x95, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_ENABLE_MSB
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x96, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_ENABLE_RTSP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x98, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_ENABLE_HTTP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x99, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_ENABLE_STREAMING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9C, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_ENABLE_DOWNLOAD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9D, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_ENABLE_PRIVATEMODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0x79, 0x47, 0x82,
                    0x8B, 0xF1,
                    0x05, 0x44,
                    0x8C,
                    0xF1,
                    0x46,
                    0x4F,
                    0xB5,
                    0xAA,
                    0x8F,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_UDP_PORT_RANGE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9A, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PROXYINFO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9B, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_DRMNET_LICENSE_REPRESENTATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBD, 0xE1, 0xEA, 0x47,
                    0xFE, 0xBD,
                    0xE2, 0x42,
                    0x82,
                    0xF3,
                    0x54,
                    0xA4,
                    0x8C,
                    0x17,
                    0x96,
                    0x2D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PROXYSETTINGS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x87, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PROXYHOSTNAME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x84, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PROXYPORT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x88, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PROXYEXCEPTIONLIST
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PROXYBYPASSFORLOCAL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x86, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PROXYRERUNAUTODETECTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x89, 0xF2, 0xB1, 0x3C,
                    0x05, 0x05,
                    0x5D, 0x4C,
                    0xAE,
                    0x71,
                    0x0A,
                    0x55,
                    0x63,
                    0x44,
                    0xEF,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_STREAM_LANGUAGE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x18, 0x43, 0xB4, 0x9A,
                    0xCD, 0xF7,
                    0x2D, 0x4F,
                    0x8D,
                    0x6D,
                    0xFA,
                    0x35,
                    0xB4,
                    0x92,
                    0xCE,
                    0xCB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_LOGPARAMS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE8, 0x6A, 0x93, 0x64,
                    0x18, 0x94,
                    0x3A, 0x45,
                    0x8C,
                    0xDA,
                    0x3E,
                    0x0A,
                    0x66,
                    0x8B,
                    0x35,
                    0x3B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_PEERMANAGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDB, 0x9A, 0xB2, 0x48,
                    0xBF, 0xFE,
                    0xEE, 0x45,
                    0xA9,
                    0xBF,
                    0xEF,
                    0xB8,
                    0x1C,
                    0x49,
                    0x2E,
                    0xFC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_FRIENDLYNAME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x57, 0x77, 0x2A, 0x5B,
                    0x6B, 0xBC,
                    0x7E, 0x44,
                    0xAA,
                    0x06,
                    0x0D,
                    0xDA,
                    0x1C,
                    0x64,
                    0x6E,
                    0x2F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_BYTESTREAMHANDLER_ACCEPTS_SHARE_WRITE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x33, 0xF7, 0xE1, 0xA6,
                    0x01, 0x30,
                    0x15, 0x49,
                    0x81,
                    0x50,
                    0x15,
                    0x58,
                    0xA2,
                    0x18,
                    0x0E,
                    0xC8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_BYTESTREAM_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0x5E, 0x02, 0xAB,
                    0xD9, 0x16,
                    0x80, 0x41,
                    0xA1,
                    0x27,
                    0xBA,
                    0x6C,
                    0x70,
                    0x15,
                    0x61,
                    0x61
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MEDIA_PROTECTION_MANAGER_PROPERTIES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA9, 0x81, 0xBD, 0x38,
                    0xEA, 0xAC,
                    0x73, 0x4C,
                    0x89,
                    0xB2,
                    0x55,
                    0x32,
                    0xC0,
                    0xAE,
                    0xCA,
                    0x79
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_SPDIF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x12, 0xA7, 0x94, 0x0B,
                    0x3E, 0xAD,
                    0xEE, 0x4C,
                    0x83,
                    0xCE,
                    0xCE,
                    0x32,
                    0xE3,
                    0xDB,
                    0x65,
                    0x22
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_UNKNOWN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5C, 0xEF, 0x3A, 0xAC,
                    0x43, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_PCI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5D, 0xEF, 0x3A, 0xAC,
                    0x43, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_PCIX
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5E, 0xEF, 0x3A, 0xAC,
                    0x43, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_PCI_Express
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5F, 0xEF, 0x3A, 0xAC,
                    0x43, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_AGP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0xEF, 0x3A, 0xAC,
                    0x43, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_VGA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x68, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_SVIDEO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x69, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_COMPOSITE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6A, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_COMPONENT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6B, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_DVI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6C, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_HDMI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6D, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_LVDS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6E, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_D_JPN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x70, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_SDI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x71, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_DISPLAYPORT_EXTERNAL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_DISPLAYPORT_EMBEDDED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x73, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_UDI_EXTERNAL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_UDI_EMBEDDED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x75, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_MIRACAST
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x77, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_A
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x78, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_B
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x79, 0x59, 0xCD, 0x57,
                    0x47, 0xCE,
                    0xD9, 0x11,
                    0x92,
                    0xDB,
                    0x00,
                    0x0B,
                    0xDB,
                    0x28,
                    0xFF,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_POLICY_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0xC2, 0x60, 0xB1,
                    0x59, 0xC0,
                    0xF1, 0x48,
                    0xA9,
                    0x01,
                    0x9E,
                    0xE2,
                    0x98,
                    0xA9,
                    0xA8,
                    0xC3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_DISABLE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1B, 0xD8, 0xC6, 0x8C,
                    0xC6, 0xFE,
                    0x8F, 0x4D,
                    0x96,
                    0x4B,
                    0xCF,
                    0xBA,
                    0x0B,
                    0x0D,
                    0xAD,
                    0x0D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_CONSTRICTVIDEO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCE, 0x70, 0x33, 0x19,
                    0xE4, 0xC5,
                    0x3A, 0x4C,
                    0x8A,
                    0x66,
                    0x69,
                    0x59,
                    0xB4,
                    0xDA,
                    0x44,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_CONSTRICTVIDEO_NOOPM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCD, 0xE8, 0x80, 0xA5,
                    0x47, 0xC2,
                    0x57, 0x49,
                    0xB9,
                    0x83,
                    0x3C,
                    0x2E,
                    0xEB,
                    0xD1,
                    0xFF,
                    0x59
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_CONSTRICTAUDIO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0x9B, 0xC9, 0xFF,
                    0x48, 0xDF,
                    0x16, 0x4E,
                    0x8E,
                    0x66,
                    0x09,
                    0x68,
                    0x92,
                    0xC1,
                    0x57,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_TRUSTEDAUDIODRIVERS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD2, 0xF3, 0xBD, 0x65,
                    0x68, 0x01,
                    0x16, 0x48,
                    0xA5,
                    0x33,
                    0x55,
                    0xD4,
                    0x7B,
                    0x02,
                    0x71,
                    0x01
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_HDCP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3D, 0xC0, 0x7C, 0xAE,
                    0x28, 0xC8,
                    0x21, 0x40,
                    0xAC,
                    0xB7,
                    0xD5,
                    0x78,
                    0xD2,
                    0x7A,
                    0xAF,
                    0x13
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_CGMSA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE9, 0x69, 0x7E, 0xE5,
                    0x6B, 0x22,
                    0x31, 0x4D,
                    0xB4,
                    0xE3,
                    0xD3,
                    0xDB,
                    0x00,
                    0x87,
                    0x36,
                    0xDD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_ACP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC6, 0x11, 0xFD, 0xC3,
                    0xB7, 0xF8,
                    0x20, 0x4D,
                    0xB0,
                    0x08,
                    0x1D,
                    0xB1,
                    0x7D,
                    0x61,
                    0xF2,
                    0xDA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_WMDRMOTA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0xA6, 0x67, 0xA2,
                    0x2E, 0x36,
                    0xD0, 0x47,
                    0x88,
                    0x05,
                    0x46,
                    0x28,
                    0x59,
                    0x8A,
                    0x23,
                    0xE4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_FFT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB2, 0x56, 0x2A, 0x46,
                    0x66, 0x28,
                    0xB6, 0x4B,
                    0x98,
                    0x0D,
                    0x6D,
                    0x8D,
                    0x9E,
                    0xDB,
                    0x1A,
                    0x8C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_PROTECTED_SURFACE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0x95, 0x5D, 0x4F,
                    0x42, 0xE7,
                    0x25, 0x4A,
                    0x8D,
                    0x1F,
                    0xD2,
                    0x87,
                    0xB5,
                    0xFA,
                    0x0A,
                    0xDE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_DISABLE_SCREEN_SCRAPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0x79, 0x11, 0xA2,
                    0xCD, 0xB7,
                    0xD8, 0x40,
                    0x96,
                    0x14,
                    0x8E,
                    0xF2,
                    0x37,
                    0x1B,
                    0xA7,
                    0x8D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_VIDEO_FRAMES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBC, 0x9C, 0xA5, 0x36,
                    0x01, 0x74,
                    0x8C, 0x4A,
                    0xBC,
                    0x20,
                    0x46,
                    0xA7,
                    0xC9,
                    0xE5,
                    0x97,
                    0xF0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_HARDWARE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC1, 0xF0, 0xE7, 0x4E,
                    0xD7, 0x9E,
                    0x4F, 0x42,
                    0xB6,
                    0xBE,
                    0x99,
                    0x6B,
                    0x33,
                    0x52,
                    0x88,
                    0x56
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_HDCP_WITH_TYPE_ENFORCEMENT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE8, 0x85, 0xA5, 0xA4,
                    0x60, 0xED,
                    0x2D, 0x44,
                    0x81,
                    0x4D,
                    0xDB,
                    0x4D,
                    0x42,
                    0x20,
                    0xA0,
                    0x6D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTIONATTRIBUTE_BEST_EFFORT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x31, 0x63, 0xE0, 0xC8,
                    0xF0, 0x75,
                    0xC1, 0x4E,
                    0x8E,
                    0x77,
                    0x17,
                    0x57,
                    0x8F,
                    0x77,
                    0x3B,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTIONATTRIBUTE_FAIL_OVER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC5, 0xAB, 0x36, 0x85,
                    0xF1, 0x38,
                    0x51, 0x41,
                    0x9C,
                    0xCE,
                    0xF5,
                    0x5D,
                    0x94,
                    0x12,
                    0x29,
                    0xAC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTION_GRAPHICS_TRANSFER_AES_ENCRYPTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0xDE, 0x73, 0xC8,
                    0xA5, 0xD8,
                    0xE6, 0x49,
                    0x88,
                    0xBB,
                    0xFB,
                    0x96,
                    0x3F,
                    0xD3,
                    0xD4,
                    0xCE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTIONATTRIBUTE_CONSTRICTVIDEO_IMAGESIZE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFC, 0x76, 0x84, 0x00,
                    0x58, 0x4B,
                    0x80, 0x4D,
                    0xA7,
                    0x90,
                    0xE7,
                    0x29,
                    0x76,
                    0x73,
                    0x16,
                    0x1D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTIONATTRIBUTE_HDCP_SRM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x07, 0x21, 0x30, 0x6F,
                    0x77, 0x34,
                    0x68, 0x44,
                    0x8A,
                    0x08,
                    0xEE,
                    0xF9,
                    0xDB,
                    0x10,
                    0xE2,
                    0x0F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SampleProtectionSalt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0xDE, 0x03, 0x54,
                    0xEE, 0xB9,
                    0x8F, 0x43,
                    0xAA,
                    0x83,
                    0x38,
                    0x04,
                    0x99,
                    0x7E,
                    0x56,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_REMOTE_PROXY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0E, 0xC9, 0x00, 0x2F,
                    0xCF, 0xD2,
                    0x78, 0x42,
                    0x8B,
                    0x6A,
                    0xD0,
                    0x77,
                    0xFA,
                    0xC3,
                    0xA2,
                    0x5F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_CreateMediaExtensionObject
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0xA5, 0x65, 0xEF,
                    0x88, 0x07,
                    0xB8, 0x45,
                    0x8B,
                    0x14,
                    0xBC,
                    0x0F,
                    0x6A,
                    0x6B,
                    0x51,
                    0x37
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePMPServer([NativeTypeName("DWORD")] uint dwCreationFlags, IMFPMPServer** ppPMPServer);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateRemoteDesktopPlugin(IMFRemoteDesktopPlugin** ppPlugin);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateNamedPropertyStore(INamedPropertyStore** ppStore);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SAMI_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0x9A, 0xA8, 0x49,
                    0xD9, 0xB4,
                    0xF2, 0x4E,
                    0xAA,
                    0x5C,
                    0xF6,
                    0x5A,
                    0x3E,
                    0x05,
                    0xAE,
                    0x4E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_PD_SAMI_STYLELIST
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7F, 0x3C, 0xB7, 0xE0,
                    0x6D, 0x48,
                    0x4E, 0x48,
                    0x98,
                    0x72,
                    0x4D,
                    0xE5,
                    0x19,
                    0x2A,
                    0x7B,
                    0xF8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SD_SAMI_LANGUAGE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8A, 0xB9, 0xFC, 0x36,
                    0xD0, 0x6C,
                    0xCB, 0x44,
                    0xAC,
                    0xB9,
                    0xA8,
                    0xF5,
                    0x60,
                    0x0D,
                    0xD0,
                    0xBB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSampleCopierMFT(IMFTransform** ppCopierMFT);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TRANSCODE_CONTAINERTYPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3F, 0xF2, 0x0F, 0x15,
                    0xBC, 0x4A,
                    0x8B, 0x47,
                    0xAC,
                    0x4F,
                    0xE1,
                    0x91,
                    0x6F,
                    0xBA,
                    0x1C,
                    0xCA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFTranscodeContainerType_ASF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6E, 0x6F, 0x0F, 0x43,
                    0xBF, 0xB6,
                    0xC1, 0x4F,
                    0xA0,
                    0xBD,
                    0x9E,
                    0xE4,
                    0x6E,
                    0xEE,
                    0x2A,
                    0xFB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFTranscodeContainerType_MPEG4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5D, 0xD0, 0x6C, 0xDC,
                    0xD0, 0xB9,
                    0xEF, 0x40,
                    0xBD,
                    0x35,
                    0xFA,
                    0x62,
                    0x2C,
                    0x1A,
                    0xB2,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFTranscodeContainerType_MP3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x12, 0xB9, 0x38, 0xE4,
                    0xF1, 0x83,
                    0xE6, 0x4D,
                    0x9E,
                    0x3A,
                    0x9F,
                    0xFB,
                    0xC6,
                    0xDD,
                    0x24,
                    0xD1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFTranscodeContainerType_FLAC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0x4A, 0x34, 0x31,
                    0xA9, 0x05,
                    0xB5, 0x42,
                    0x90,
                    0x1B,
                    0x8E,
                    0x9D,
                    0x42,
                    0x57,
                    0xF7,
                    0x5E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFTranscodeContainerType_3GP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x67, 0x01, 0xC5, 0x34,
                    0x72, 0x44,
                    0x34, 0x4F,
                    0x9E,
                    0xA0,
                    0xC4,
                    0x9F,
                    0xBA,
                    0xCF,
                    0x03,
                    0x7D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFTranscodeContainerType_AC3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC3, 0x91, 0x8D, 0x6D,
                    0x91, 0x8C,
                    0xD1, 0x4E,
                    0x87,
                    0x42,
                    0x8C,
                    0x34,
                    0x7D,
                    0x5B,
                    0x44,
                    0xD0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFTranscodeContainerType_ADTS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7D, 0xD2, 0x2F, 0x13,
                    0x02, 0x0F,
                    0xDE, 0x43,
                    0xA3,
                    0x01,
                    0x38,
                    0xFB,
                    0xBB,
                    0xB3,
                    0x83,
                    0x4E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFTranscodeContainerType_MPEG2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0xDB, 0xC2, 0xBF,
                    0xB4, 0x7B,
                    0x8F, 0x4F,
                    0xAF,
                    0xDE,
                    0xE1,
                    0x12,
                    0xC4,
                    0x4B,
                    0xA8,
                    0x82
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFTranscodeContainerType_WAVE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3C, 0x45, 0xC3, 0x64,
                    0x26, 0x0F,
                    0x41, 0x47,
                    0xBE,
                    0x63,
                    0x87,
                    0xBD,
                    0xF8,
                    0xBB,
                    0x93,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFTranscodeContainerType_AVI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAF, 0xE8, 0xDF, 0x7E,
                    0x2F, 0x40,
                    0x76, 0x4D,
                    0xA3,
                    0x3C,
                    0x61,
                    0x9F,
                    0xD1,
                    0x57,
                    0xD0,
                    0xF1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFTranscodeContainerType_FMPEG4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0x76, 0xA8, 0x9B,
                    0x9F, 0x41,
                    0x77, 0x4B,
                    0xA1,
                    0xE0,
                    0x35,
                    0x95,
                    0x9D,
                    0x9D,
                    0x40,
                    0x04
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFTranscodeContainerType_AMR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD3, 0x5A, 0x5D, 0x02,
                    0x1A, 0x62,
                    0x5B, 0x47,
                    0x96,
                    0x4D,
                    0x66,
                    0xB1,
                    0xC8,
                    0x24,
                    0xF0,
                    0x79
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TRANSCODE_SKIP_METADATA_TRANSFER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEF, 0x69, 0x44, 0x4E,
                    0x71, 0xB5,
                    0x59, 0x49,
                    0x8F,
                    0x83,
                    0x3D,
                    0xCF,
                    0xBA,
                    0x33,
                    0xA3,
                    0x93
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TRANSCODE_TOPOLOGYMODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0xF6, 0x3D, 0x3E,
                    0x4A, 0x39,
                    0xB2, 0x40,
                    0x9D,
                    0xEA,
                    0x3B,
                    0xAB,
                    0x65,
                    0x0B,
                    0xEB,
                    0xF2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TRANSCODE_ADJUST_PROFILE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1B, 0xC2, 0x37, 0x9C,
                    0x0F, 0x06,
                    0x7C, 0x48,
                    0xA6,
                    0x90,
                    0x80,
                    0xD7,
                    0xF5,
                    0x0D,
                    0x1C,
                    0x72
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TRANSCODE_ENCODINGPROFILE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0x78, 0x47, 0x69,
                    0x08, 0xF5,
                    0xA9, 0x4E,
                    0xB1,
                    0xE9,
                    0xA1,
                    0xFE,
                    0x3A,
                    0x49,
                    0xFB,
                    0xC9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TRANSCODE_QUALITYVSSPEED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF8, 0x2D, 0x33, 0x98,
                    0xCD, 0x03,
                    0x6B, 0x47,
                    0x89,
                    0xFA,
                    0x3F,
                    0x9E,
                    0x44,
                    0x2D,
                    0xEC,
                    0x9F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_TRANSCODE_DONOT_INSERT_ENCODER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCE, 0xA7, 0x5A, 0xF4,
                    0x24, 0xAB,
                    0x12, 0x40,
                    0xA1,
                    0x1B,
                    0xDC,
                    0x82,
                    0x20,
                    0x20,
                    0x14,
                    0x10
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_VIDEO_PROCESSOR_ALGORITHM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1F, 0x1E, 0x0A, 0x4A,
                    0x2C, 0x27,
                    0xB6, 0x4F,
                    0x9E,
                    0xB1,
                    0xDB,
                    0x33,
                    0x0C,
                    0xBC,
                    0x97,
                    0xCA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_XVP_DISABLE_FRC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x19, 0xFA, 0x0A, 0x2C,
                    0x97, 0x7A,
                    0x5A, 0x4D,
                    0x9E,
                    0xE8,
                    0x16,
                    0xD4,
                    0xFC,
                    0x51,
                    0x8D,
                    0x8C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_XVP_CALLER_ALLOCATES_OUTPUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBC, 0xCA, 0xA2, 0x04,
                    0xAB, 0x0C,
                    0xB1, 0x40,
                    0xA1,
                    0xB9,
                    0x75,
                    0xBC,
                    0x36,
                    0x58,
                    0xF0,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTranscodeProfile(IMFTranscodeProfile** ppTranscodeProfile);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTranscodeTopology(IMFMediaSource* pSrc, [NativeTypeName("LPCWSTR")] ushort* pwszOutputFilePath, IMFTranscodeProfile* pProfile, IMFTopology** ppTranscodeTopo);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTranscodeTopologyFromByteStream(IMFMediaSource* pSrc, IMFByteStream* pOutputStream, IMFTranscodeProfile* pProfile, IMFTopology** ppTranscodeTopo);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTranscodeGetAudioOutputAvailableTypes([NativeTypeName("const GUID &")] Guid* guidSubType, [NativeTypeName("DWORD")] uint dwMFTFlags, IMFAttributes* pCodecConfig, IMFCollection** ppAvailableTypes);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTranscodeSinkActivate(IMFActivate** ppActivate);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_LOCAL_MFT_REGISTRATION_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9C, 0xCF, 0xF5, 0xDD,
                    0x06, 0x45,
                    0xAA, 0x45,
                    0xAB,
                    0xF0,
                    0x6D,
                    0x5D,
                    0x94,
                    0xDD,
                    0x1B,
                    0x4A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTrackedSample(IMFTrackedSample** ppMFSample);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMFByteStreamOnStream(IStream* pStream, IMFByteStream** ppByteStream);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateStreamOnMFByteStream(IMFByteStream* pByteStream, IStream** ppStream);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMFByteStreamOnStreamEx(IUnknown* punkStream, IMFByteStream** ppByteStream);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateStreamOnMFByteStreamEx(IMFByteStream* pByteStream, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaTypeFromProperties(IUnknown* punkStream, IMFMediaType** ppMediaType);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePropertiesFromMediaType(IMFMediaType* pMediaType, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_WRAPPED_BUFFER_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0x40, 0x54, 0xAB,
                    0x69, 0xC2,
                    0xBC, 0x4E,
                    0xA5,
                    0x52,
                    0x1C,
                    0x3B,
                    0x32,
                    0xBE,
                    0xD5,
                    0xCA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_WRAPPED_SAMPLE_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF2, 0x2B, 0xF5, 0x31,
                    0x3E, 0xD0,
                    0x48, 0x40,
                    0x80,
                    0xD0,
                    0x9C,
                    0x10,
                    0x46,
                    0xD8,
                    0x7C,
                    0x61
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_WRAPPED_OBJECT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4C, 0x2C, 0x18, 0x2B,
                    0xAC, 0xD6,
                    0xF4, 0x49,
                    0x89,
                    0x15,
                    0xF7,
                    0x18,
                    0x87,
                    0xDB,
                    0x70,
                    0xCD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_HttpSchemePlugin
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0x44, 0xCB, 0x44,
                    0xA9, 0x9D,
                    0xDF, 0x49,
                    0xB3,
                    0xFD,
                    0x02,
                    0x37,
                    0x77,
                    0xB1,
                    0x6E,
                    0x50
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_UrlmonSchemePlugin
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0xB4, 0xC4, 0x9E,
                    0x29, 0x30,
                    0xAD, 0x45,
                    0x94,
                    0x7B,
                    0x34,
                    0x4D,
                    0xE2,
                    0xA2,
                    0x49,
                    0xE2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_NetSchemePlugin
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAB, 0xEB, 0xF4, 0xE9,
                    0x7B, 0xD9,
                    0x3E, 0x46,
                    0xA2,
                    0xB1,
                    0xC5,
                    0x4E,
                    0xE3,
                    0xF9,
                    0x41,
                    0x4D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFEnumDeviceSources(IMFAttributes* pAttributes, IMFActivate*** pppSourceActivate, [NativeTypeName("UINT32 *")] uint* pcSourceActivate);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDeviceSource(IMFAttributes* pAttributes, IMFMediaSource** ppSource);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDeviceSourceActivate(IMFAttributes* pAttributes, IMFActivate** ppActivate);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFE, 0xC5, 0x0A, 0xC6,
                    0x2A, 0x25,
                    0x8F, 0x47,
                    0xA0,
                    0xEF,
                    0xBC,
                    0x8F,
                    0xA5,
                    0xF7,
                    0xCA,
                    0xD3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_HW_SOURCE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBA, 0x46, 0x70, 0xDE,
                    0xD6, 0x54,
                    0x87, 0x44,
                    0xA2,
                    0xA4,
                    0xEC,
                    0x7C,
                    0x0D,
                    0x1B,
                    0xD1,
                    0x63
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_FRIENDLY_NAME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0xE5, 0xD0, 0x60,
                    0xF8, 0x52,
                    0xA2, 0x4F,
                    0xBB,
                    0xCE,
                    0xAC,
                    0xDB,
                    0x34,
                    0xA8,
                    0xEC,
                    0x01
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_MEDIA_TYPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCA, 0x19, 0xA8, 0x56,
                    0x78, 0x0C,
                    0xE4, 0x4D,
                    0xA0,
                    0xA7,
                    0x3D,
                    0xDA,
                    0xBA,
                    0x0F,
                    0x24,
                    0xD4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_CATEGORY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x69, 0xAE, 0xF0, 0x77,
                    0xBD, 0xC3,
                    0x09, 0x45,
                    0x94,
                    0x1D,
                    0x46,
                    0x7E,
                    0x4D,
                    0x24,
                    0x89,
                    0x9E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_SYMBOLIC_LINK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0xAA, 0xF0, 0x58,
                    0xBF, 0x22,
                    0x8A, 0x4F,
                    0xBB,
                    0x3D,
                    0xD2,
                    0xC4,
                    0x97,
                    0x8C,
                    0x6E,
                    0x2F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_SYMBOLIC_LINK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5E, 0x4B, 0xD2, 0x98,
                    0x30, 0x59,
                    0x14, 0x46,
                    0xB5,
                    0xA1,
                    0xF6,
                    0x00,
                    0xF9,
                    0x35,
                    0x5A,
                    0x78
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_MAX_BUFFERS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0xB7, 0xD9, 0x7D,
                    0x2D, 0x4F,
                    0xD5, 0x41,
                    0x8F,
                    0x95,
                    0x0C,
                    0xC9,
                    0xA9,
                    0x12,
                    0xBA,
                    0x26
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ENDPOINT_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x58, 0x92, 0xDA, 0x30,
                    0xB9, 0xFE,
                    0xA7, 0x47,
                    0xA4,
                    0x53,
                    0x76,
                    0x3A,
                    0x7A,
                    0x8E,
                    0x1C,
                    0x5F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ROLE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8E, 0x11, 0x9D, 0xBC,
                    0x67, 0x8C,
                    0x18, 0x4A,
                    0x85,
                    0xD4,
                    0x12,
                    0xD3,
                    0x00,
                    0x40,
                    0x05,
                    0x52
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_PROVIDER_DEVICE_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x42, 0x9D, 0x68, 0x36,
                    0x6C, 0xA0,
                    0xAE, 0x40,
                    0x84,
                    0xCF,
                    0xF5,
                    0xA0,
                    0x34,
                    0x06,
                    0x7C,
                    0xC4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_XADDRESS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0xBE, 0xA0, 0xBC,
                    0x27, 0xC3,
                    0xC7, 0x44,
                    0x9B,
                    0x7D,
                    0x7F,
                    0xA8,
                    0xD9,
                    0xB5,
                    0xBC,
                    0xDA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_STREAM_URL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD2, 0x40, 0x7B, 0x9D,
                    0x17, 0x36,
                    0x43, 0x40,
                    0x93,
                    0xE3,
                    0x8D,
                    0x6D,
                    0xA9,
                    0xBB,
                    0x34,
                    0x92
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_USERNAME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDD, 0x1A, 0xD0, 0x05,
                    0x9F, 0x94,
                    0xEB, 0x46,
                    0xBC,
                    0x8E,
                    0x8B,
                    0x0D,
                    0x2B,
                    0x32,
                    0xD7,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_PASSWORD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0x7E, 0xFD, 0xA0,
                    0xD9, 0x42,
                    0xDF, 0x49,
                    0x84,
                    0xC0,
                    0xE8,
                    0x2C,
                    0x5E,
                    0xAB,
                    0x88,
                    0x74
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_FrameServerNetworkCameraSource
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA7, 0x3A, 0x21, 0x7A,
                    0x6F, 0x86,
                    0x4A, 0x41,
                    0x8C,
                    0x1A,
                    0x27,
                    0x5C,
                    0x72,
                    0x83,
                    0xA3,
                    0x95
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1C, 0x9A, 0xDD, 0x14,
                    0xFF, 0x7C,
                    0xBE, 0x41,
                    0xB1,
                    0xB9,
                    0xBA,
                    0x1A,
                    0xC6,
                    0xEC,
                    0xB5,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7A, 0x58, 0xC3, 0x8A,
                    0xE7, 0x4A,
                    0xD8, 0x42,
                    0x99,
                    0xE0,
                    0x0A,
                    0x60,
                    0x13,
                    0xEE,
                    0xF9,
                    0x0F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_IMAGE_STREAM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x65, 0xB8, 0xFF, 0xA7,
                    0xB2, 0xE7,
                    0xB0, 0x43,
                    0x9F,
                    0x6F,
                    0x9A,
                    0xF2,
                    0xA0,
                    0xE5,
                    0x0F,
                    0xC0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_INDEPENDENT_IMAGE_STREAM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7E, 0xEC, 0xEE, 0x03,
                    0x05, 0xD6,
                    0x76, 0x45,
                    0x8B,
                    0x29,
                    0x65,
                    0x80,
                    0xB4,
                    0x90,
                    0xD7,
                    0xD3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_STREAM_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0x51, 0xBD, 0x11,
                    0x24, 0xD1,
                    0x6B, 0x44,
                    0x88,
                    0xE6,
                    0x17,
                    0x06,
                    0x02,
                    0x57,
                    0xFF,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_STREAM_CATEGORY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB8, 0xE7, 0x39, 0x29,
                    0x2E, 0xA6,
                    0x79, 0x45,
                    0xB6,
                    0x74,
                    0xD4,
                    0x07,
                    0x3D,
                    0xFA,
                    0xBB,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_FRAMESERVER_SHARED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE9, 0x78, 0xB3, 0x1C,
                    0x79, 0xB2,
                    0xD4, 0x41,
                    0xAF,
                    0x97,
                    0x34,
                    0xA2,
                    0x43,
                    0xE6,
                    0x83,
                    0x20
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_TRANSFORM_STREAM_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB7, 0x37, 0x39, 0xE6,
                    0xAF, 0xDA,
                    0x49, 0x4D,
                    0x81,
                    0x5F,
                    0xD8,
                    0x26,
                    0xF8,
                    0xAD,
                    0x31,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_EXTENSION_PLUGIN_CLSID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x58, 0x65, 0x8E, 0x04,
                    0xC4, 0x60,
                    0x73, 0x41,
                    0xBD,
                    0x5B,
                    0x6A,
                    0x3C,
                    0xA2,
                    0x89,
                    0x6A,
                    0xEE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICEMFT_EXTENSION_PLUGIN_CLSID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAE, 0xDB, 0x44, 0x08,
                    0xFA, 0x34,
                    0xA0, 0x48,
                    0xA7,
                    0x83,
                    0x8E,
                    0x69,
                    0x6F,
                    0xB1,
                    0xC9,
                    0xA8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_EXTENSION_PLUGIN_CONNECTION_POINT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5C, 0x37, 0xF9, 0x37,
                    0x64, 0xE6,
                    0xA4, 0x4E,
                    0xAA,
                    0xE4,
                    0xCB,
                    0x6D,
                    0x1D,
                    0xAC,
                    0xA1,
                    0xF4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_TAKEPHOTO_TRIGGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x34, 0x0E, 0x18, 0x1D,
                    0x8C, 0x53,
                    0xBB, 0x4F,
                    0xA7,
                    0x5A,
                    0x85,
                    0x9A,
                    0xF7,
                    0xD2,
                    0x61,
                    0xA6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_MAX_FRAME_BUFFERS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBE, 0xCE, 0x84, 0x16,
                    0x75, 0x31,
                    0x85, 0x49,
                    0x88,
                    0x2C,
                    0x0E,
                    0xFD,
                    0x3E,
                    0x8A,
                    0xC1,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICEMFT_CONNECTED_FILTER_KSCONTROL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA6, 0x4F, 0x2C, 0x6A,
                    0x79, 0xD1,
                    0xCD, 0x41,
                    0x95,
                    0x23,
                    0x82,
                    0x23,
                    0x71,
                    0xEA,
                    0x40,
                    0xE5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICEMFT_CONNECTED_PIN_KSCONTROL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF7, 0x10, 0x33, 0xE6,
                    0x44, 0xB2,
                    0xF8, 0x4E,
                    0x9A,
                    0x7D,
                    0x24,
                    0xC7,
                    0x4E,
                    0x32,
                    0xEB,
                    0xD0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICE_THERMAL_STATE_CHANGED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAF, 0xD0, 0xCC, 0x70,
                    0x9F, 0xFC,
                    0xEB, 0x4D,
                    0xA8,
                    0x75,
                    0x9F,
                    0xEC,
                    0xD1,
                    0x6C,
                    0x5B,
                    0xD4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFSampleExtension_DeviceTimestamp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0x35, 0x3E, 0x8F,
                    0xCD, 0x2D,
                    0x87, 0x48,
                    0x86,
                    0x22,
                    0x2A,
                    0x58,
                    0xBA,
                    0xA6,
                    0x52,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFSampleExtension_Spatial_CameraViewTransform
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0x1F, 0x25, 0x4E,
                    0x0F, 0x83,
                    0x70, 0x47,
                    0x85,
                    0x9A,
                    0x4B,
                    0x8D,
                    0x99,
                    0xAA,
                    0x80,
                    0x9B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFSampleExtension_Spatial_CameraCoordinateSystem
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2F, 0xC8, 0x13, 0x9D,
                    0x99, 0x21,
                    0x67, 0x4E,
                    0x91,
                    0xCD,
                    0xD1,
                    0xA4,
                    0x18,
                    0x1F,
                    0x25,
                    0x34
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFSampleExtension_Spatial_CameraProjectionTransform
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB5, 0xFC, 0xF9, 0x47,
                    0x02, 0x2A,
                    0x26, 0x4F,
                    0xA4,
                    0x77,
                    0x79,
                    0x2F,
                    0xDF,
                    0x95,
                    0x88,
                    0x6A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateProtectedEnvironmentAccess(IMFProtectedEnvironmentAccess** ppAccess);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLoadSignedLibrary([NativeTypeName("LPCWSTR")] ushort* pszName, IMFSignedLibrary** ppLib);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetSystemId(IMFSystemId** ppId);

        [DllImport("mf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetLocalId([NativeTypeName("const BYTE *")] byte* verifier, [NativeTypeName("UINT32")] uint size, [NativeTypeName("LPWSTR *")] ushort** id);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MPEG2ByteStreamPlugin
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x1C, 0x87, 0x40,
                    0x40, 0xAB,
                    0x1F, 0x47,
                    0x8D,
                    0xC3,
                    0x1F,
                    0x25,
                    0x9D,
                    0x86,
                    0x24,
                    0x79
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MEDIASOURCE_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF7, 0x92, 0x99, 0xF0,
                    0xBA, 0x9F,
                    0x4A, 0x4C,
                    0xA3,
                    0x7F,
                    0x8C,
                    0x47,
                    0xB4,
                    0xE1,
                    0xDF,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_ACCESS_CONTROLLED_MEDIASOURCE_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x31, 0x50, 0x4A, 0x01,
                    0x05, 0x2F,
                    0x6A, 0x4C,
                    0x9F,
                    0x9C,
                    0x7D,
                    0x0D,
                    0xC4,
                    0xED,
                    0xA5,
                    0xF4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateContentProtectionDevice([NativeTypeName("const GUID &")] Guid* ProtectionSystemId, IMFContentProtectionDevice** ContentProtectionDevice);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFIsContentProtectionDeviceSupported([NativeTypeName("const GUID &")] Guid* ProtectionSystemId, [NativeTypeName("BOOL *")] int* isSupported);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_CONTENT_DECRYPTOR_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x27, 0x29, 0xA7, 0x68,
                    0x7B, 0xFC,
                    0xEE, 0x44,
                    0x85,
                    0xF4,
                    0x7C,
                    0x51,
                    0xBD,
                    0x55,
                    0xA6,
                    0x59
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_CONTENT_PROTECTION_DEVICE_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6F, 0x43, 0x58, 0xFF,
                    0xA0, 0x76,
                    0xFE, 0x41,
                    0xB5,
                    0x66,
                    0x10,
                    0xCC,
                    0x53,
                    0x96,
                    0x2E,
                    0xDD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateContentDecryptorContext([NativeTypeName("const GUID &")] Guid* guidMediaProtectionSystemId, IMFDXGIDeviceManager* pD3DManager, IMFContentProtectionDevice* pContentProtectionDevice, IMFContentDecryptorContext** ppContentDecryptorContext);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SD_AUDIO_ENCODER_DELAY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2C, 0x42, 0x85, 0x8E,
                    0xDE, 0x73,
                    0x3F, 0x40,
                    0x9A,
                    0x35,
                    0x55,
                    0x0A,
                    0xD6,
                    0xE8,
                    0xB9,
                    0x51
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SD_AUDIO_ENCODER_PADDING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2C, 0x7F, 0x9C, 0x52,
                    0x4B, 0xAC,
                    0x3F, 0x4E,
                    0xBF,
                    0xC3,
                    0x09,
                    0x02,
                    0x19,
                    0x49,
                    0x82,
                    0xCB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MSH264DecoderMFT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0x7E, 0xCE, 0x62,
                    0x71, 0x4C,
                    0x20, 0x4D,
                    0xB1,
                    0x5D,
                    0x45,
                    0x28,
                    0x31,
                    0xA8,
                    0x7D,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MSH264EncoderMFT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0x03, 0xA5, 0x6C,
                    0x1A, 0x05,
                    0xED, 0x4D,
                    0x97,
                    0x79,
                    0xA4,
                    0x33,
                    0x05,
                    0x16,
                    0x5E,
                    0x35
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MSDDPlusDecMFT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFE, 0x0A, 0x7C, 0x17,
                    0x0B, 0x90,
                    0xD4, 0x48,
                    0x9E,
                    0x4C,
                    0x57,
                    0xAD,
                    0xD2,
                    0x50,
                    0xB3,
                    0xD4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MP3DecMediaObject
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0xA8, 0xEE, 0xBB,
                    0x63, 0x0A,
                    0x52, 0x4F,
                    0xA7,
                    0xAB,
                    0xA9,
                    0xB3,
                    0xA8,
                    0x4E,
                    0xD3,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MSAACDecMFT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA7, 0x86, 0xD1, 0x32,
                    0x8F, 0x21,
                    0x75, 0x4C,
                    0x88,
                    0x76,
                    0xDD,
                    0x77,
                    0x27,
                    0x3A,
                    0x89,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MSH265DecoderMFT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0x51, 0x0A, 0x42,
                    0x05, 0xD6,
                    0x0C, 0x43,
                    0xB4,
                    0xFC,
                    0x45,
                    0x27,
                    0x4F,
                    0xA6,
                    0xC5,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_WMVDecoderMFT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0x53, 0xD3, 0x82,
                    0xBD, 0x90,
                    0x82, 0x43,
                    0x8B,
                    0xC2,
                    0x3F,
                    0x61,
                    0x92,
                    0xB7,
                    0x6E,
                    0x34
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_WMADecMediaObject
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0x4A, 0xEB, 0x2E,
                    0x78, 0x45,
                    0x10, 0x4D,
                    0xBC,
                    0xA7,
                    0xBB,
                    0x95,
                    0x5F,
                    0x56,
                    0x32,
                    0x0A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MSMPEGAudDecMFT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0x7B, 0x70, 0x70,
                    0xCA, 0xB2,
                    0x15, 0x40,
                    0xAB,
                    0xEA,
                    0xF8,
                    0x44,
                    0x7D,
                    0x22,
                    0xD8,
                    0x8B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MSMPEGDecoderMFT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0x9E, 0x70, 0x2D,
                    0x3F, 0x12,
                    0xB5, 0x49,
                    0x9C,
                    0xBC,
                    0x9A,
                    0xF5,
                    0xCD,
                    0xE2,
                    0x8F,
                    0xB9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_AudioResamplerMediaObject
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9E, 0xB6, 0x47, 0xF4,
                    0x84, 0x18,
                    0x7E, 0x4A,
                    0x80,
                    0x55,
                    0x34,
                    0x6F,
                    0x74,
                    0xD6,
                    0xED,
                    0xB3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MSVPxDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0xF5, 0xAA, 0xE3,
                    0xA4, 0xC9,
                    0x6E, 0x4C,
                    0x23,
                    0x4D,
                    0x5A,
                    0xDA,
                    0x37,
                    0x4B,
                    0x00,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MSOpusDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0x7C, 0xE1, 0x63,
                    0x43, 0x2D,
                    0x42, 0x4C,
                    0x8F,
                    0xE3,
                    0x8D,
                    0x8B,
                    0x63,
                    0xE4,
                    0x6A,
                    0x6A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_VideoProcessorMFT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0x3B, 0x75, 0x88,
                    0x24, 0x5B,
                    0xBD, 0x49,
                    0xB2,
                    0xE7,
                    0x0C,
                    0x44,
                    0x5C,
                    0x78,
                    0xC9,
                    0x82
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_CROSS_ORIGIN_SUPPORT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0x20, 0x42, 0x98,
                    0x2C, 0xB0,
                    0x71, 0x42,
                    0xA2,
                    0xFC,
                    0x72,
                    0xE4,
                    0x93,
                    0x08,
                    0xE5,
                    0xC2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNETSOURCE_HTTP_DOWNLOAD_SESSION_PROVIDER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1E, 0x08, 0x55, 0x7D,
                    0x7D, 0x30,
                    0x6D, 0x4D,
                    0xA6,
                    0x63,
                    0xA9,
                    0x3B,
                    0xE9,
                    0x7C,
                    0x4B,
                    0x5C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SD_MEDIASOURCE_STATUS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8B, 0x67, 0x13, 0x19,
                    0x0F, 0xFC,
                    0xDA, 0x44,
                    0x8F,
                    0x43,
                    0x1B,
                    0xA3,
                    0xB5,
                    0x26,
                    0xF4,
                    0xAE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SD_VIDEO_SPHERICAL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0xA4, 0x1D, 0xA5,
                    0xDC, 0x3F,
                    0x8C, 0x47,
                    0xBC,
                    0xB5,
                    0x30,
                    0xBE,
                    0x76,
                    0x59,
                    0x5F,
                    0x55
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SD_VIDEO_SPHERICAL_FORMAT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x07, 0xC4, 0x8F, 0x4A,
                    0xA1, 0x6E,
                    0xC8, 0x46,
                    0xB5,
                    0x67,
                    0x69,
                    0x71,
                    0xD4,
                    0xA1,
                    0x39,
                    0xC3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_SD_VIDEO_SPHERICAL_INITIAL_VIEWDIRECTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0x5A, 0xD2, 0x11,
                    0x62, 0xBB,
                    0x7F, 0x46,
                    0x9D,
                    0xB1,
                    0xC1,
                    0x71,
                    0x65,
                    0x71,
                    0x6C,
                    0x49
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MEDIASOURCE_EXPOSE_ALL_STREAMS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB8, 0x50, 0xF2, 0xE7,
                    0xD9, 0x8F,
                    0x09, 0x4A,
                    0xB6,
                    0xC1,
                    0x6A,
                    0x31,
                    0x5C,
                    0x7C,
                    0x72,
                    0x0E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_ST_MEDIASOURCE_COLLECTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0xE9, 0x6D, 0x61,
                    0xAD, 0x83,
                    0x50, 0x49,
                    0x81,
                    0x70,
                    0x63,
                    0x0D,
                    0x19,
                    0xCB,
                    0xE3,
                    0x07
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_FILTER_KSCONTROL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCA, 0x3C, 0x78, 0x46,
                    0xF5, 0x3D,
                    0x23, 0x49,
                    0xA9,
                    0xEF,
                    0x36,
                    0xB7,
                    0x22,
                    0x3E,
                    0xDD,
                    0xE0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_PIN_KSCONTROL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA7, 0xF9, 0x3E, 0xEF,
                    0xF2, 0x87,
                    0xCA, 0x48,
                    0xBE,
                    0x02,
                    0x67,
                    0x48,
                    0x78,
                    0x91,
                    0x8E,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_SOURCE_ATTRIBUTES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x17, 0xB6, 0x8C, 0x2F,
                    0x1B, 0x36,
                    0x4F, 0x43,
                    0x85,
                    0xEA,
                    0x99,
                    0xA0,
                    0x3E,
                    0x1C,
                    0xE4,
                    0xE0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_FRAMESERVER_HIDDEN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7B, 0x56, 0x02, 0xF4,
                    0x91, 0x4D,
                    0x79, 0x41,
                    0x96,
                    0xD1,
                    0x74,
                    0xC8,
                    0x48,
                    0x0C,
                    0x20,
                    0x34
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_STF_VERSION_INFO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0xBD, 0x70, 0x67,
                    0x82, 0xEF,
                    0xEE, 0x44,
                    0xA4,
                    0x9B,
                    0x93,
                    0x4B,
                    0xEB,
                    0x24,
                    0xAE,
                    0xF7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_STF_VERSION_DATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD5, 0x65, 0xA1, 0x31,
                    0x67, 0xDF,
                    0x95, 0x40,
                    0x8E,
                    0x44,
                    0x88,
                    0x68,
                    0xFC,
                    0x20,
                    0xDB,
                    0xFD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_REQUIRED_CAPABILITIES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7E, 0x95, 0x8B, 0x6D,
                    0xF6, 0x7C,
                    0xF4, 0x43,
                    0xAF,
                    0x56,
                    0x9C,
                    0x0E,
                    0x1E,
                    0x4F,
                    0xCB,
                    0xE1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_REQUIRED_SDDL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5D, 0xE8, 0x1A, 0x33,
                    0xD3, 0xC0,
                    0xBA, 0x49,
                    0x83,
                    0xBA,
                    0x82,
                    0xA1,
                    0x2D,
                    0x63,
                    0xCD,
                    0xD6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICEMFT_SENSORPROFILE_COLLECTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0xDC, 0xEB, 0x36,
                    0x2C, 0xB1,
                    0x1B, 0x44,
                    0x89,
                    0xF4,
                    0x08,
                    0xB2,
                    0xF4,
                    0x1A,
                    0x9C,
                    0xFC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_DEVICESTREAM_SENSORSTREAM_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE4, 0x9F, 0x5B, 0xE3,
                    0x59, 0x06,
                    0xAD, 0x4C,
                    0xBB,
                    0x51,
                    0x33,
                    0x16,
                    0x0B,
                    0xE7,
                    0xE4,
                    0x13
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSensorGroup([NativeTypeName("LPCWSTR")] ushort* SensorGroupSymbolicLink, IMFSensorGroup** ppSensorGroup);

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSensorProfile([NativeTypeName("const GUID &")] Guid* ProfileType, [NativeTypeName("UINT32")] uint ProfileIndex, [NativeTypeName("LPCWSTR")] ushort* Constraints, IMFSensorProfile** ppProfile);

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSensorProfileCollection(IMFSensorProfileCollection** ppSensorProfile);

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSensorActivityMonitor(IMFSensorActivitiesReportCallback* pCallback, IMFSensorActivityMonitor** ppActivityMonitor);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFStreamExtension_ExtendedCameraIntrinsics
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0xB3, 0x74, 0xAA,
                    0x2C, 0x9A,
                    0xD6, 0x48,
                    0x83,
                    0x93,
                    0x5B,
                    0xD1,
                    0xC1,
                    0xA8,
                    0x1E,
                    0x6E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_ExtendedCameraIntrinsics
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA5, 0xC4, 0x0B, 0x56,
                    0xE0, 0x4D,
                    0x13, 0x41,
                    0x9C,
                    0xDC,
                    0x83,
                    0x2D,
                    0xB9,
                    0x74,
                    0x0F,
                    0x3D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateRelativePanelWatcher([NativeTypeName("PCWSTR")] ushort* videoDeviceId, [NativeTypeName("PCWSTR")] ushort* displayMonitorDeviceId, IMFRelativePanelWatcher** ppRelativePanelWatcher);

        [NativeTypeName("#define MEDIASINK_FIXED_STREAMS 0x00000001")]
        public const int MEDIASINK_FIXED_STREAMS = 0x00000001;

        [NativeTypeName("#define MEDIASINK_CANNOT_MATCH_CLOCK 0x00000002")]
        public const int MEDIASINK_CANNOT_MATCH_CLOCK = 0x00000002;

        [NativeTypeName("#define MEDIASINK_RATELESS 0x00000004")]
        public const int MEDIASINK_RATELESS = 0x00000004;

        [NativeTypeName("#define MEDIASINK_CLOCK_REQUIRED 0x00000008")]
        public const int MEDIASINK_CLOCK_REQUIRED = 0x00000008;

        [NativeTypeName("#define MEDIASINK_CAN_PREROLL 0x00000010")]
        public const int MEDIASINK_CAN_PREROLL = 0x00000010;

        [NativeTypeName("#define MEDIASINK_REQUIRE_REFERENCE_MEDIATYPE 0x00000020")]
        public const int MEDIASINK_REQUIRE_REFERENCE_MEDIATYPE = 0x00000020;

        [NativeTypeName("#define MFCLOCK_FREQUENCY_HNS 10000000")]
        public const int MFCLOCK_FREQUENCY_HNS = 10000000;

        [NativeTypeName("#define MFCLOCK_TOLERANCE_UNKNOWN 50000")]
        public const int MFCLOCK_TOLERANCE_UNKNOWN = 50000;

        [NativeTypeName("#define MFCLOCK_JITTER_ISR 1000")]
        public const int MFCLOCK_JITTER_ISR = 1000;

        [NativeTypeName("#define MFCLOCK_JITTER_DPC 4000")]
        public const int MFCLOCK_JITTER_DPC = 4000;

        [NativeTypeName("#define MFCLOCK_JITTER_PASSIVE 10000")]
        public const int MFCLOCK_JITTER_PASSIVE = 10000;

        [NativeTypeName("#define PRESENTATION_CURRENT_POSITION 0x7fffffffffffffff")]
        public const long PRESENTATION_CURRENT_POSITION = 0x7fffffffffffffff;

        [NativeTypeName("#define MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_CROSSPROCESS 0x00000001")]
        public const int MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_CROSSPROCESS = 0x00000001;

        [NativeTypeName("#define MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_NOPERSIST 0x00000002")]
        public const int MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_NOPERSIST = 0x00000002;

        [NativeTypeName("#define MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_DONT_ALLOW_FORMAT_CHANGES 0x00000004")]
        public const int MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_DONT_ALLOW_FORMAT_CHANGES = 0x00000004;

        [NativeTypeName("#define MFRR_INFO_VERSION 0")]
        public const int MFRR_INFO_VERSION = 0;

        [NativeTypeName("#define MF_USER_MODE_COMPONENT_LOAD 0x00000001")]
        public const int MF_USER_MODE_COMPONENT_LOAD = 0x00000001;

        [NativeTypeName("#define MF_KERNEL_MODE_COMPONENT_LOAD 0x00000002")]
        public const int MF_KERNEL_MODE_COMPONENT_LOAD = 0x00000002;

        [NativeTypeName("#define MF_GRL_LOAD_FAILED 0x00000010")]
        public const int MF_GRL_LOAD_FAILED = 0x00000010;

        [NativeTypeName("#define MF_INVALID_GRL_SIGNATURE 0x00000020")]
        public const int MF_INVALID_GRL_SIGNATURE = 0x00000020;

        [NativeTypeName("#define MF_GRL_ABSENT 0x00001000")]
        public const int MF_GRL_ABSENT = 0x00001000;

        [NativeTypeName("#define MF_COMPONENT_REVOKED 0x00002000")]
        public const int MF_COMPONENT_REVOKED = 0x00002000;

        [NativeTypeName("#define MF_COMPONENT_INVALID_EKU 0x00004000")]
        public const int MF_COMPONENT_INVALID_EKU = 0x00004000;

        [NativeTypeName("#define MF_COMPONENT_CERT_REVOKED 0x00008000")]
        public const int MF_COMPONENT_CERT_REVOKED = 0x00008000;

        [NativeTypeName("#define MF_COMPONENT_INVALID_ROOT 0x00010000")]
        public const int MF_COMPONENT_INVALID_ROOT = 0x00010000;

        [NativeTypeName("#define MF_COMPONENT_HS_CERT_REVOKED 0x00020000")]
        public const int MF_COMPONENT_HS_CERT_REVOKED = 0x00020000;

        [NativeTypeName("#define MF_COMPONENT_LS_CERT_REVOKED 0x00040000")]
        public const int MF_COMPONENT_LS_CERT_REVOKED = 0x00040000;

        [NativeTypeName("#define MF_BOOT_DRIVER_VERIFICATION_FAILED 0x00100000")]
        public const int MF_BOOT_DRIVER_VERIFICATION_FAILED = 0x00100000;

        [NativeTypeName("#define MF_TEST_SIGNED_COMPONENT_LOADING 0x01000000")]
        public const int MF_TEST_SIGNED_COMPONENT_LOADING = 0x01000000;

        [NativeTypeName("#define MF_MINCRYPT_FAILURE 0x10000000")]
        public const int MF_MINCRYPT_FAILURE = 0x10000000;

        [NativeTypeName("#define SHA_HASH_LEN 20")]
        public const int SHA_HASH_LEN = 20;

        [NativeTypeName("#define STR_HASH_LEN (SHA_HASH_LEN*2 + 3)")]
        public const int STR_HASH_LEN = (20 * 2 + 3);

        [NativeTypeName("#define MFSEQUENCER_INVALID_ELEMENT_ID ( 0xffffffff )")]
        public const uint MFSEQUENCER_INVALID_ELEMENT_ID = (0xffffffff);

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_DIGITAL ((DWORD) 0x00000001)")]
        public const uint MFOUTPUTATTRIBUTE_DIGITAL = ((uint)(0x00000001));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_NONSTANDARDIMPLEMENTATION ((DWORD) 0x00000002)")]
        public const uint MFOUTPUTATTRIBUTE_NONSTANDARDIMPLEMENTATION = ((uint)(0x00000002));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_VIDEO ((DWORD) 0x00000004)")]
        public const uint MFOUTPUTATTRIBUTE_VIDEO = ((uint)(0x00000004));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_COMPRESSED ((DWORD) 0x00000008)")]
        public const uint MFOUTPUTATTRIBUTE_COMPRESSED = ((uint)(0x00000008));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_SOFTWARE ((DWORD) 0x00000010)")]
        public const uint MFOUTPUTATTRIBUTE_SOFTWARE = ((uint)(0x00000010));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_BUS ((DWORD) 0x00000020)")]
        public const uint MFOUTPUTATTRIBUTE_BUS = ((uint)(0x00000020));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_BUSIMPLEMENTATION ((DWORD) 0x0000FF00)")]
        public const uint MFOUTPUTATTRIBUTE_BUSIMPLEMENTATION = ((uint)(0x0000FF00));

        [NativeTypeName("#define MFCONTENTPROTECTIONDEVICE_FUNCTIONID_START 0x04000000")]
        public const int MFCONTENTPROTECTIONDEVICE_FUNCTIONID_START = 0x04000000;

        [NativeTypeName("#define MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA_FUNCTIONID MFCONTENTPROTECTIONDEVICE_FUNCTIONID_START")]
        public const int MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA_FUNCTIONID = 0x04000000;

        [NativeTypeName("#define MF_UNKNOWN_DURATION 0")]
        public const int MF_UNKNOWN_DURATION = 0;

        public static ref readonly Guid IID_IMFMediaSession
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x34, 0x78, 0x37, 0x90,
                    0xD0, 0x21,
                    0xEE, 0x4D,
                    0x82,
                    0x14,
                    0xBA,
                    0x2E,
                    0x3E,
                    0x6C,
                    0x11,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSourceResolver
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2D, 0xA3, 0xE5, 0xFB,
                    0x97, 0xA4,
                    0x61, 0x4B,
                    0xBB,
                    0x85,
                    0x97,
                    0xB1,
                    0xA8,
                    0x48,
                    0xA6,
                    0xE3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaSource
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8D, 0x80, 0x9A, 0x27,
                    0xC7, 0xAE,
                    0xC8, 0x40,
                    0x9C,
                    0x6B,
                    0xA6,
                    0xB4,
                    0x92,
                    0xC7,
                    0x8A,
                    0x66
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaSourceEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB9, 0x2E, 0x9B, 0x3C,
                    0xD5, 0x86,
                    0x14, 0x45,
                    0xA3,
                    0x94,
                    0xF5,
                    0x66,
                    0x64,
                    0xF9,
                    0xF0,
                    0xD8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFClockConsumer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0xA6, 0xF2, 0x6E,
                    0xC0, 0x47,
                    0x66, 0x46,
                    0xB1,
                    0x3D,
                    0xCB,
                    0xB7,
                    0x17,
                    0xF2,
                    0xFA,
                    0x2C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8F, 0x10, 0x82, 0xD1,
                    0xC6, 0x4E,
                    0x3F, 0x44,
                    0xAA,
                    0x42,
                    0xA7,
                    0x11,
                    0x06,
                    0xEC,
                    0x82,
                    0x5F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaSink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0xA6, 0xF2, 0x6E,
                    0xC0, 0x47,
                    0x66, 0x46,
                    0xB1,
                    0x3D,
                    0xCB,
                    0xB7,
                    0x17,
                    0xF2,
                    0xFA,
                    0x2C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFStreamSink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCF, 0xB3, 0x97, 0x0A,
                    0x7C, 0x8E,
                    0x3D, 0x4A,
                    0x8F,
                    0x8C,
                    0x0C,
                    0x84,
                    0x3D,
                    0xC2,
                    0x47,
                    0xFB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFVideoSampleAllocator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0xC9, 0xCB, 0x86,
                    0x33, 0xE5,
                    0x51, 0x47,
                    0x8E,
                    0x3B,
                    0xF1,
                    0x9B,
                    0x5B,
                    0x80,
                    0x6A,
                    0x03
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFVideoSampleAllocatorNotify
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBE, 0xCD, 0x92, 0xA7,
                    0x74, 0xC3,
                    0x89, 0x4E,
                    0x83,
                    0x35,
                    0x27,
                    0x8E,
                    0x7B,
                    0x99,
                    0x56,
                    0xA4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFVideoSampleAllocatorNotifyEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1A, 0xAA, 0x78, 0x39,
                    0x5B, 0x6D,
                    0x7F, 0x4B,
                    0xA3,
                    0x40,
                    0x90,
                    0x89,
                    0x91,
                    0x89,
                    0xAE,
                    0x34
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFVideoSampleAllocatorCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB4, 0x88, 0x23, 0x99,
                    0x72, 0x33,
                    0x67, 0x4F,
                    0x8B,
                    0x6F,
                    0xC8,
                    0x4C,
                    0x07,
                    0x1F,
                    0x47,
                    0x51
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFVideoSampleAllocatorEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0x3A, 0x5B, 0x54,
                    0x83, 0x32,
                    0x62, 0x4F,
                    0x86,
                    0x6F,
                    0xA6,
                    0x2D,
                    0x8F,
                    0x59,
                    0x8F,
                    0x9F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFDXGIDeviceManagerSource
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4B, 0x07, 0xBC, 0x20,
                    0x8D, 0x7A,
                    0x09, 0x46,
                    0x8C,
                    0x3B,
                    0x64,
                    0xA0,
                    0xA3,
                    0xB5,
                    0xD7,
                    0xCE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFVideoProcessorControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD5, 0x75, 0xF6, 0xA3,
                    0x19, 0x61,
                    0x7F, 0x4F,
                    0xA1,
                    0x00,
                    0x1D,
                    0x8B,
                    0x28,
                    0x0F,
                    0x0E,
                    0xFB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFVideoProcessorControl2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD3, 0x33, 0xE6, 0xBD,
                    0xDC, 0xE1,
                    0x7F, 0x4A,
                    0xA6,
                    0x93,
                    0xBB,
                    0xAE,
                    0x39,
                    0x9C,
                    0x4A,
                    0x20
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFVideoProcessorControl3
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF2, 0xB3, 0x24, 0x24,
                    0x23, 0xEB,
                    0xF1, 0x40,
                    0x91,
                    0xAA,
                    0x74,
                    0xBD,
                    0xDE,
                    0xEA,
                    0x08,
                    0x83
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFVideoRendererEffectControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD7, 0x33, 0x4D, 0x60,
                    0x23, 0xCF,
                    0xD5, 0x41,
                    0x82,
                    0x24,
                    0x5B,
                    0xBB,
                    0xB1,
                    0xA8,
                    0x74,
                    0x75
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFTopology
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3A, 0x87, 0xCF, 0x83,
                    0xDA, 0xF6,
                    0xC8, 0x4B,
                    0x82,
                    0x3F,
                    0xBA,
                    0xCF,
                    0xD5,
                    0x5D,
                    0xC4,
                    0x33
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFTopologyNode
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3A, 0x87, 0xCF, 0x83,
                    0xDA, 0xF6,
                    0xC8, 0x4B,
                    0x82,
                    0x3F,
                    0xBA,
                    0xCF,
                    0xD5,
                    0x5D,
                    0xC4,
                    0x30
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFGetService
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x88, 0x38, 0x99, 0xFA,
                    0x83, 0x43,
                    0x5A, 0x41,
                    0xA9,
                    0x30,
                    0xDD,
                    0x47,
                    0x2A,
                    0x8C,
                    0xF6,
                    0xF7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFClock
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x45, 0xE9, 0xB1, 0x2E,
                    0xB8, 0x18,
                    0x39, 0x41,
                    0x9B,
                    0x1A,
                    0xD5,
                    0xD5,
                    0x84,
                    0x81,
                    0x85,
                    0x30
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFPresentationClock
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5C, 0xE8, 0x8C, 0x86,
                    0xA9, 0x8E,
                    0x55, 0x4F,
                    0xAB,
                    0x82,
                    0xB0,
                    0x09,
                    0xA9,
                    0x10,
                    0xA8,
                    0x05
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFPresentationTimeSource
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCE, 0x2C, 0xF1, 0x7F,
                    0x6F, 0xF7,
                    0xC2, 0x41,
                    0x86,
                    0x3B,
                    0x16,
                    0x66,
                    0xC8,
                    0xE5,
                    0xE1,
                    0x39
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFClockStateSink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0x6E, 0x69, 0xF6,
                    0xF7, 0x74,
                    0x3D, 0x4F,
                    0xA1,
                    0x78,
                    0x8A,
                    0x5E,
                    0x09,
                    0xC3,
                    0x65,
                    0x9F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFPresentationDescriptor
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x11, 0x27, 0xCB, 0x03,
                    0xD7, 0x24,
                    0xB6, 0x4D,
                    0xA1,
                    0x7F,
                    0xF3,
                    0xA7,
                    0xA4,
                    0x79,
                    0xA5,
                    0x36
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFStreamDescriptor
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9C, 0x3D, 0xC0, 0x56,
                    0xBB, 0x9D,
                    0xF5, 0x45,
                    0xAB,
                    0x4B,
                    0xD8,
                    0x0F,
                    0x47,
                    0xC0,
                    0x59,
                    0x38
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaTypeHandler
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6C, 0xCF, 0x3D, 0xE9,
                    0x07, 0x4B,
                    0x1E, 0x4E,
                    0x81,
                    0x23,
                    0xAA,
                    0x16,
                    0xED,
                    0x6E,
                    0xAD,
                    0xF5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFTimer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBD, 0x4C, 0x6E, 0xE5,
                    0x70, 0x8F,
                    0xD8, 0x49,
                    0xA0,
                    0xF8,
                    0xED,
                    0xB3,
                    0xD6,
                    0xAB,
                    0x9B,
                    0xF2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFShutdown
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0x2E, 0xEC, 0x97,
                    0x42, 0x0E,
                    0x37, 0x49,
                    0x97,
                    0xAC,
                    0x9D,
                    0x6D,
                    0x32,
                    0x88,
                    0x24,
                    0xE1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFTopoLoader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x57, 0x61, 0x9A, 0xDE,
                    0x60, 0xF6,
                    0x43, 0x46,
                    0xB5,
                    0x6A,
                    0xDF,
                    0x9F,
                    0x79,
                    0x98,
                    0xC7,
                    0xCD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFContentProtectionManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x24, 0xF9, 0xAC,
                    0x61, 0x6A,
                    0xBD, 0x42,
                    0xB5,
                    0x7C,
                    0xB4,
                    0x3E,
                    0x51,
                    0x20,
                    0x3C,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFContentEnabler
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0xEF, 0xC4, 0xD3,
                    0xCE, 0x49,
                    0x81, 0x43,
                    0x90,
                    0x71,
                    0xD5,
                    0xBC,
                    0xD0,
                    0x44,
                    0xC7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMetadata
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8C, 0xFB, 0x8C, 0xF8,
                    0x16, 0xEF,
                    0x91, 0x49,
                    0xB4,
                    0x50,
                    0xCB,
                    0x8C,
                    0x69,
                    0xE5,
                    0x17,
                    0x04
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMetadataProvider
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2D, 0x1D, 0x18, 0x56,
                    0x21, 0xE2,
                    0xDB, 0x4A,
                    0xB1,
                    0xC8,
                    0x3C,
                    0xEE,
                    0x6A,
                    0x53,
                    0xF7,
                    0x6F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFRateSupport
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBC, 0xCD, 0x9C, 0x0A,
                    0x97, 0xD7,
                    0x63, 0x45,
                    0x96,
                    0x67,
                    0x94,
                    0xEC,
                    0x5D,
                    0x79,
                    0x29,
                    0x2D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFRateControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0xCD, 0xDD, 0x88,
                    0xC3, 0x03,
                    0x75, 0x42,
                    0x91,
                    0xED,
                    0x55,
                    0xEE,
                    0x39,
                    0x29,
                    0x32,
                    0x8F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFTimecodeTranslate
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x86, 0x9D, 0xAB,
                    0xE8, 0xF7,
                    0xF4, 0x4E,
                    0x98,
                    0x61,
                    0x89,
                    0xF3,
                    0x34,
                    0xF9,
                    0x4E,
                    0x74
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSeekInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x53, 0xEA, 0xAF, 0x26,
                    0xED, 0xD9,
                    0xB5, 0x42,
                    0xAB,
                    0x80,
                    0xE6,
                    0x4F,
                    0x9E,
                    0xE3,
                    0x47,
                    0x79
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSimpleAudioVolume
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x13, 0xDF, 0x9E, 0x08,
                    0x71, 0xCF,
                    0x38, 0x43,
                    0x8D,
                    0x13,
                    0x9E,
                    0x56,
                    0x9D,
                    0xBD,
                    0xC3,
                    0x19
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFAudioStreamVolume
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDB, 0xBB, 0xB1, 0x76,
                    0xC8, 0x4E,
                    0x36, 0x4F,
                    0xB1,
                    0x06,
                    0x70,
                    0xA9,
                    0x31,
                    0x6D,
                    0xF5,
                    0x93
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFAudioPolicy
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0x8C, 0x63, 0xA0,
                    0x65, 0x64,
                    0x95, 0x43,
                    0x9A,
                    0xE7,
                    0xA3,
                    0x21,
                    0xA9,
                    0xFD,
                    0x28,
                    0x56
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSampleGrabberSinkCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBF, 0x80, 0x7B, 0x8C,
                    0x42, 0xEE,
                    0x59, 0x4B,
                    0xB1,
                    0xDF,
                    0x55,
                    0x66,
                    0x8E,
                    0x1B,
                    0xDC,
                    0xA8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSampleGrabberSinkCallback2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0xAA, 0x86, 0xCA,
                    0x6E, 0xC4,
                    0x9E, 0x42,
                    0xAB,
                    0x27,
                    0x16,
                    0xD6,
                    0xAC,
                    0x68,
                    0x44,
                    0xCB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFWorkQueueServices
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB8, 0x1B, 0xFE, 0x35,
                    0xA9, 0xA3,
                    0xFE, 0x40,
                    0xBB,
                    0xEC,
                    0xEB,
                    0x56,
                    0x9C,
                    0x9C,
                    0xCC,
                    0xA3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFWorkQueueServicesEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1B, 0x96, 0xBF, 0x96,
                    0xFE, 0x40,
                    0xF1, 0x42,
                    0xBA,
                    0x9D,
                    0x32,
                    0x02,
                    0x38,
                    0xB4,
                    0x97,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFQualityManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x86, 0x9D, 0x00, 0x8D,
                    0x9F, 0x5B,
                    0x15, 0x41,
                    0xB1,
                    0xFC,
                    0x9F,
                    0x80,
                    0xD5,
                    0x2A,
                    0xB8,
                    0xAB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFQualityAdvise
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE9, 0xE2, 0x15, 0xEC,
                    0x6B, 0xE3,
                    0x7C, 0x4F,
                    0x87,
                    0x58,
                    0x77,
                    0xD4,
                    0x52,
                    0xEF,
                    0x4C,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFQualityAdvise2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0D, 0x6F, 0x70, 0xF3,
                    0xA2, 0x8E,
                    0x86, 0x48,
                    0x80,
                    0x00,
                    0x71,
                    0x55,
                    0xE9,
                    0xEC,
                    0x2E,
                    0xAE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFQualityAdviseLimits
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0x8E, 0xCD, 0xDF,
                    0xB5, 0x30,
                    0x67, 0x45,
                    0xAC,
                    0xAA,
                    0x8E,
                    0xB5,
                    0xB7,
                    0x85,
                    0x3D,
                    0xC9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFRealTimeClient
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0B, 0xD6, 0x47, 0x23,
                    0xB5, 0x3F,
                    0x0C, 0x48,
                    0x88,
                    0x03,
                    0x8D,
                    0xF3,
                    0xAD,
                    0xCD,
                    0x3E,
                    0xF0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFRealTimeClientEx
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0x08, 0x91, 0x03,
                    0x16, 0xAB,
                    0x11, 0x46,
                    0xB1,
                    0x00,
                    0x17,
                    0xB8,
                    0x8A,
                    0xE2,
                    0xF2,
                    0x48
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSequencerSource
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x19, 0xD2, 0x7C, 0x19,
                    0xCB, 0x19,
                    0xE1, 0x4D,
                    0xA6,
                    0x4C,
                    0xAC,
                    0xF2,
                    0xED,
                    0xCB,
                    0xE5,
                    0x9E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaSourceTopologyProvider
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x09, 0x60, 0x1D, 0x0E,
                    0xF3, 0xC9,
                    0x2D, 0x44,
                    0x8C,
                    0x51,
                    0xA4,
                    0x2D,
                    0x2D,
                    0x49,
                    0x45,
                    0x2F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaSourcePresentationProvider
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0A, 0x60, 0x1D, 0x0E,
                    0xF3, 0xC9,
                    0x2D, 0x44,
                    0x8C,
                    0x51,
                    0xA4,
                    0x2D,
                    0x2D,
                    0x49,
                    0x45,
                    0x2F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFTopologyNodeAttributeEditor
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDD, 0xA6, 0x6A, 0x67,
                    0x8A, 0x23,
                    0x0D, 0x41,
                    0xBB,
                    0x99,
                    0x65,
                    0x66,
                    0x8D,
                    0x01,
                    0x60,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFByteStreamBuffering
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0xD7, 0x66, 0x6D,
                    0x4F, 0x1D,
                    0xB7, 0x4D,
                    0x8C,
                    0x63,
                    0xCB,
                    0x8C,
                    0x77,
                    0xF1,
                    0xEF,
                    0x5E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFByteStreamCacheControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0x2E, 0x04, 0xF5,
                    0x96, 0x7A,
                    0x75, 0x4A,
                    0xAA,
                    0x7B,
                    0x2B,
                    0xE1,
                    0xEF,
                    0x7F,
                    0x88,
                    0xD5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFByteStreamTimeSeek
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFA, 0x6B, 0x97, 0x64,
                    0x61, 0xFB,
                    0x41, 0x40,
                    0x90,
                    0x69,
                    0x8C,
                    0x9A,
                    0x5F,
                    0x65,
                    0x9B,
                    0xEB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFByteStreamCacheControl2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9C, 0x46, 0xCE, 0x71,
                    0x4B, 0xF3,
                    0xEA, 0x49,
                    0xA5,
                    0x6B,
                    0x2D,
                    0x2A,
                    0x10,
                    0xE5,
                    0x11,
                    0x49
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFNetCredential
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6A, 0xEF, 0x87, 0x5B,
                    0xD8, 0x7E,
                    0x4F, 0x43,
                    0xBA,
                    0x0E,
                    0x18,
                    0x4F,
                    0xAC,
                    0x16,
                    0x28,
                    0xD1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFNetCredentialManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6B, 0xEF, 0x87, 0x5B,
                    0xD8, 0x7E,
                    0x4F, 0x43,
                    0xBA,
                    0x0E,
                    0x18,
                    0x4F,
                    0xAC,
                    0x16,
                    0x28,
                    0xD1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFNetCredentialCache
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6C, 0xEF, 0x87, 0x5B,
                    0xD8, 0x7E,
                    0x4F, 0x43,
                    0xBA,
                    0x0E,
                    0x18,
                    0x4F,
                    0xAC,
                    0x16,
                    0x28,
                    0xD1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSSLCertificateManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x87, 0xD8, 0xF7, 0x61,
                    0x30, 0x12,
                    0x8B, 0x4A,
                    0xAE,
                    0xBA,
                    0x8A,
                    0xD4,
                    0x34,
                    0xD1,
                    0xA6,
                    0x4D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFNetResourceFilter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0x78, 0x18, 0x09,
                    0x11, 0xBF,
                    0x5C, 0x4A,
                    0xBC,
                    0x9F,
                    0x33,
                    0x99,
                    0x5B,
                    0x06,
                    0xEF,
                    0x2D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSourceOpenMonitor
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB3, 0x54, 0x90, 0x05,
                    0x7C, 0x02,
                    0x4C, 0x49,
                    0xA2,
                    0x7D,
                    0x91,
                    0x13,
                    0x29,
                    0x1C,
                    0xF8,
                    0x7F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFNetProxyLocator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0x03, 0xCD, 0xE9,
                    0x68, 0xA2,
                    0xB4, 0x4B,
                    0x82,
                    0xDE,
                    0x65,
                    0x8D,
                    0x53,
                    0x57,
                    0x4D,
                    0x41
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFNetProxyLocatorFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x84, 0x03, 0xCD, 0xE9,
                    0x68, 0xA2,
                    0xB4, 0x4B,
                    0x82,
                    0xDE,
                    0x65,
                    0x8D,
                    0x53,
                    0x57,
                    0x4D,
                    0x41
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSaveJob
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x63, 0x16, 0x93, 0xE9,
                    0xBF, 0x80,
                    0x6E, 0x4C,
                    0x98,
                    0xAF,
                    0x5D,
                    0xCF,
                    0x58,
                    0x74,
                    0x7D,
                    0x1F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFNetSchemeHandlerConfig
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x73, 0x9E, 0xE1, 0x7B,
                    0xBF, 0xC9,
                    0x8A, 0x46,
                    0xAC,
                    0x5A,
                    0xA5,
                    0xE8,
                    0x65,
                    0x3B,
                    0xEC,
                    0x87
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSchemeHandler
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0x7B, 0x4C, 0x6D,
                    0xA0, 0x52,
                    0xB7, 0x4B,
                    0xB0,
                    0xDB,
                    0x55,
                    0xF2,
                    0x9F,
                    0x47,
                    0xA6,
                    0x68
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFByteStreamHandler
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0x0A, 0x42, 0xBB,
                    0x5B, 0x76,
                    0x1F, 0x4A,
                    0x91,
                    0xFE,
                    0xD6,
                    0xA8,
                    0xA1,
                    0x43,
                    0x92,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFTrustedInput
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC4, 0x12, 0x26, 0x54,
                    0xB8, 0xA1,
                    0x32, 0x46,
                    0xB5,
                    0x21,
                    0xDE,
                    0x11,
                    0xEA,
                    0x64,
                    0xA0,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFInputTrustAuthority
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x98, 0x8E, 0x9F, 0xD1,
                    0x26, 0xB1,
                    0x46, 0x44,
                    0x89,
                    0x0C,
                    0x5D,
                    0xCB,
                    0x7A,
                    0xD7,
                    0x14,
                    0x53
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFTrustedOutput
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x95, 0x8E, 0x9F, 0xD1,
                    0x26, 0xB1,
                    0x46, 0x44,
                    0x89,
                    0x0C,
                    0x5D,
                    0xCB,
                    0x7A,
                    0xD7,
                    0x14,
                    0x53
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFOutputTrustAuthority
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x94, 0x8E, 0x9F, 0xD1,
                    0x26, 0xB1,
                    0x46, 0x44,
                    0x89,
                    0x0C,
                    0x5D,
                    0xCB,
                    0x7A,
                    0xD7,
                    0x14,
                    0x53
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFOutputPolicy
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0A, 0xF1, 0x00, 0x7F,
                    0xED, 0xDA,
                    0xAF, 0x41,
                    0xAB,
                    0x26,
                    0x5F,
                    0xDF,
                    0xA4,
                    0xDF,
                    0xBA,
                    0x3C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFOutputSchema
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5B, 0xFC, 0xE0, 0x7B,
                    0xD9, 0xAB,
                    0xFB, 0x44,
                    0xA5,
                    0xC8,
                    0xF5,
                    0x01,
                    0x36,
                    0xE7,
                    0x15,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSecureChannel
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5D, 0x55, 0xAE, 0xD0,
                    0x12, 0x3B,
                    0x97, 0x4D,
                    0xB0,
                    0x60,
                    0x09,
                    0x90,
                    0xBC,
                    0x5A,
                    0xEB,
                    0x67
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSampleProtection
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5F, 0x39, 0x36, 0x8E,
                    0xB9, 0xC7,
                    0xC4, 0x43,
                    0xA5,
                    0x4D,
                    0x51,
                    0x2B,
                    0x4A,
                    0xF6,
                    0x3C,
                    0x95
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaSinkPreroll
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2A, 0x4B, 0xFD, 0x5D,
                    0x74, 0x76,
                    0x10, 0x41,
                    0xA4,
                    0xE6,
                    0x8A,
                    0x68,
                    0xFD,
                    0x5F,
                    0x36,
                    0x88
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFFinalizableMediaSink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4A, 0xB7, 0xEC, 0xEA,
                    0x50, 0x9A,
                    0xCE, 0x42,
                    0x95,
                    0x41,
                    0x6A,
                    0x7F,
                    0x57,
                    0xAA,
                    0x4A,
                    0xD7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFStreamingSinkConfig
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0xAA, 0xB7, 0x9D,
                    0xC5, 0x3C,
                    0xD4, 0x40,
                    0x85,
                    0x09,
                    0x55,
                    0x58,
                    0x04,
                    0xAD,
                    0x34,
                    0xCC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFRemoteProxy
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAD, 0x23, 0x4E, 0x99,
                    0xC2, 0x1C,
                    0x3C, 0x49,
                    0xB9,
                    0xFA,
                    0x46,
                    0xF1,
                    0xCB,
                    0x04,
                    0x0F,
                    0xA4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFObjectReferenceStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE3, 0x5B, 0xEF, 0x09,
                    0xA7, 0xC8,
                    0x9E, 0x46,
                    0x8B,
                    0x70,
                    0x73,
                    0xBF,
                    0x25,
                    0xBB,
                    0x19,
                    0x3F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFPMPHost
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA9, 0xA1, 0x0C, 0xF7,
                    0xC7, 0xFD,
                    0x82, 0x47,
                    0xB9,
                    0x94,
                    0xAD,
                    0xFF,
                    0xB1,
                    0xC9,
                    0x86,
                    0x06
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFPMPClient
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5D, 0x65, 0x4E, 0x6C,
                    0xD8, 0xEA,
                    0x21, 0x44,
                    0xB6,
                    0xB9,
                    0x54,
                    0xDC,
                    0xDB,
                    0xBD,
                    0xF8,
                    0x20
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFPMPServer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAF, 0x23, 0x4E, 0x99,
                    0xC2, 0x1C,
                    0x3C, 0x49,
                    0xB9,
                    0xFA,
                    0x46,
                    0xF1,
                    0xCB,
                    0x04,
                    0x0F,
                    0xA4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFRemoteDesktopPlugin
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x09, 0x63, 0xDE, 0x1C,
                    0xE0, 0xCA,
                    0x40, 0x49,
                    0x90,
                    0x7E,
                    0xC1,
                    0xEC,
                    0x9C,
                    0x3D,
                    0x1D,
                    0x4A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSAMIStyle
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDD, 0x25, 0xE0, 0xA7,
                    0x03, 0x53,
                    0x62, 0x4A,
                    0x89,
                    0xD6,
                    0xE7,
                    0x47,
                    0xE1,
                    0xEF,
                    0xAC,
                    0x73
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFTranscodeProfile
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0xDB, 0xDF, 0x4A,
                    0xB0, 0x7A,
                    0x53, 0x49,
                    0xA6,
                    0x2B,
                    0x46,
                    0x1E,
                    0x7F,
                    0xF3,
                    0xDA,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFTranscodeSinkInfoProvider
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2E, 0xCD, 0xFF, 0x8C,
                    0x03, 0x5A,
                    0x3A, 0x4A,
                    0xAF,
                    0xF7,
                    0xED,
                    0xCD,
                    0x10,
                    0x7C,
                    0x62,
                    0x0E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFFieldOfUseMFTUnlock
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD3, 0x71, 0x8E, 0x50,
                    0x66, 0xEC,
                    0xC3, 0x4F,
                    0x87,
                    0x75,
                    0xB4,
                    0xB9,
                    0xED,
                    0x6B,
                    0xA8,
                    0x47
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFLocalMFTRegistration
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x73, 0x4D, 0x9C, 0x14,
                    0xBE, 0xB4,
                    0x8D, 0x4F,
                    0x8B,
                    0x87,
                    0x07,
                    0x9E,
                    0x92,
                    0x6B,
                    0x6A,
                    0xDD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFCapturePhotoConfirmation
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0x85, 0xF6, 0x19,
                    0x8A, 0xCA,
                    0x06, 0x47,
                    0xA4,
                    0xEF,
                    0x48,
                    0x1D,
                    0xBC,
                    0x95,
                    0xE1,
                    0x2C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFPMPHostApp
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4A, 0x05, 0xD2, 0x84,
                    0xA1, 0x3A,
                    0x28, 0x47,
                    0xA3,
                    0xB0,
                    0x44,
                    0x0A,
                    0x41,
                    0x8C,
                    0xF4,
                    0x9C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFPMPClientApp
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x46, 0xF6, 0x04, 0xC0,
                    0x2C, 0xBE,
                    0xF3, 0x48,
                    0x93,
                    0xA2,
                    0xA0,
                    0x98,
                    0x3E,
                    0xBA,
                    0x11,
                    0x08
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaStreamSourceSampleRequest
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0x9A, 0x0B, 0x38,
                    0x5B, 0xA8,
                    0x78, 0x4E,
                    0xA2,
                    0xAF,
                    0xEA,
                    0x5C,
                    0xE6,
                    0x45,
                    0xC6,
                    0xB4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFTrackedSample
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE9, 0xF8, 0x5B, 0x24,
                    0x55, 0x07,
                    0xF7, 0x40,
                    0x88,
                    0xA5,
                    0xAE,
                    0x0F,
                    0x18,
                    0xD5,
                    0x5E,
                    0x17
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFProtectedEnvironmentAccess
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x45, 0xC8, 0x5D, 0xEF,
                    0xD9, 0xF0,
                    0xC9, 0x4E,
                    0xB0,
                    0x0C,
                    0xCB,
                    0x51,
                    0x83,
                    0xD3,
                    0x84,
                    0x34
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSignedLibrary
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCA, 0x4B, 0x72, 0x4A,
                    0x6A, 0xFF,
                    0x07, 0x4C,
                    0x8E,
                    0x0D,
                    0x7A,
                    0x35,
                    0x84,
                    0x21,
                    0xCF,
                    0x06
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSystemId
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3A, 0xAF, 0xF4, 0xFF,
                    0xC1, 0x1F,
                    0xF9, 0x4E,
                    0xA2,
                    0x9B,
                    0xD2,
                    0x6C,
                    0x49,
                    0xE2,
                    0xF3,
                    0x1A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFContentProtectionDevice
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0x71, 0x25, 0xE6,
                    0x60, 0xA0,
                    0x9A, 0x4C,
                    0xA0,
                    0x88,
                    0x3B,
                    0x1B,
                    0x47,
                    0x1C,
                    0xAD,
                    0x28
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFContentDecryptorContext
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBD, 0xB1, 0xC4, 0x7E,
                    0xFB, 0x43,
                    0x63, 0x47,
                    0x85,
                    0xD2,
                    0x64,
                    0xFC,
                    0xB5,
                    0xC5,
                    0xF4,
                    0xCB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFNetCrossOriginSupport
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0x7D, 0x2B, 0xBC,
                    0x2D, 0xA7,
                    0xD5, 0x49,
                    0x83,
                    0x76,
                    0x14,
                    0x80,
                    0xDE,
                    0xE5,
                    0x8B,
                    0x22
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFHttpDownloadRequest
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0xFD, 0x79, 0xF7,
                    0xE7, 0x26,
                    0x70, 0x42,
                    0x8A,
                    0x8B,
                    0xB9,
                    0x83,
                    0xD1,
                    0x85,
                    0x9D,
                    0xE0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFHttpDownloadSession
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2C, 0x9A, 0xFA, 0x71,
                    0xCE, 0x53,
                    0x62, 0x46,
                    0xA1,
                    0x32,
                    0x1A,
                    0x7E,
                    0x8C,
                    0xBF,
                    0x62,
                    0xDB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFHttpDownloadSessionProvider
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB9, 0xF4, 0x4C, 0x1B,
                    0x16, 0x3A,
                    0x15, 0x41,
                    0x83,
                    0x9D,
                    0x03,
                    0xCC,
                    0x5C,
                    0x99,
                    0xDF,
                    0x01
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaSource2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x14, 0x34, 0xB0, 0xFB,
                    0x3B, 0xD1,
                    0x86, 0x47,
                    0x83,
                    0x19,
                    0x5A,
                    0xC5,
                    0x1F,
                    0xC0,
                    0xA1,
                    0x36
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaStream2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD6, 0x37, 0xBC, 0xC5,
                    0xC7, 0x75,
                    0xA1, 0x46,
                    0xA1,
                    0x32,
                    0x81,
                    0xB5,
                    0xF7,
                    0x23,
                    0xC2,
                    0x0F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSensorDevice
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF2, 0x48, 0x9F, 0xFB,
                    0x18, 0x2A,
                    0x28, 0x4E,
                    0x97,
                    0x30,
                    0x78,
                    0x6F,
                    0x30,
                    0xF0,
                    0x4D,
                    0xC4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSensorGroup
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3A, 0x24, 0x10, 0x41,
                    0x57, 0x97,
                    0x1F, 0x46,
                    0x89,
                    0xF1,
                    0xF2,
                    0x23,
                    0x45,
                    0xBC,
                    0xAB,
                    0x4E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSensorStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x71, 0x21, 0xA4, 0xE9,
                    0x6E, 0xC5,
                    0x8A, 0x49,
                    0x8B,
                    0x39,
                    0xED,
                    0xA5,
                    0xA0,
                    0x70,
                    0xB7,
                    0xFC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSensorTransformFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0xC2, 0xD9, 0xEE,
                    0xB4, 0x66,
                    0x18, 0x4F,
                    0xA6,
                    0x97,
                    0xAC,
                    0x7D,
                    0x39,
                    0x60,
                    0x21,
                    0x5C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSensorProfile
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD1, 0x65, 0xF7, 0x22,
                    0xAB, 0x8D,
                    0x07, 0x41,
                    0x84,
                    0x6D,
                    0x56,
                    0xBA,
                    0xF7,
                    0x22,
                    0x15,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSensorProfileCollection
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5B, 0xA5, 0x5E, 0xC9,
                    0x87, 0x01,
                    0xBE, 0x48,
                    0x93,
                    0x53,
                    0x8D,
                    0x25,
                    0x07,
                    0x66,
                    0x23,
                    0x51
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSensorProcessActivity
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4A, 0x7F, 0xDC, 0x39,
                    0x41, 0xB1,
                    0x19, 0x47,
                    0x81,
                    0x3C,
                    0xA7,
                    0xF4,
                    0x61,
                    0x62,
                    0xA2,
                    0xB8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSensorActivityReport
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0x4B, 0x8C, 0x3E,
                    0xC2, 0xA8,
                    0x28, 0x45,
                    0x90,
                    0xDE,
                    0x28,
                    0x51,
                    0xBD,
                    0xE5,
                    0xFE,
                    0xAD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSensorActivitiesReport
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5E, 0x7A, 0x3F, 0x68,
                    0x19, 0x4A,
                    0xCD, 0x43,
                    0xB1,
                    0xA9,
                    0xDB,
                    0xF4,
                    0xAB,
                    0x3F,
                    0x77,
                    0x77
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSensorActivitiesReportCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0x72, 0x50, 0xDE,
                    0xE3, 0xDB,
                    0xDC, 0x46,
                    0x8A,
                    0x87,
                    0xB6,
                    0xF6,
                    0x31,
                    0x19,
                    0x47,
                    0x51
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSensorActivityMonitor
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x45, 0xF1, 0xCE, 0xD0,
                    0xF4, 0xB3,
                    0x40, 0x43,
                    0xA2,
                    0xE5,
                    0x7A,
                    0x50,
                    0x80,
                    0xCA,
                    0x05,
                    0xCB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFExtendedCameraIntrinsicModel
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x5E, 0x59, 0x5C,
                    0x30, 0x46,
                    0x31, 0x42,
                    0x85,
                    0x5A,
                    0x12,
                    0x84,
                    0x2F,
                    0x73,
                    0x32,
                    0x45
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFExtendedCameraIntrinsicsDistortionModel6KT
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3B, 0x65, 0xC2, 0x74,
                    0x55, 0x5F,
                    0xB1, 0x4E,
                    0x9F,
                    0x0F,
                    0x18,
                    0xB8,
                    0xF6,
                    0x8B,
                    0x7D,
                    0x3D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFExtendedCameraIntrinsicsDistortionModelArcTan
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x95, 0x5F, 0x2D, 0x81,
                    0x72, 0xB5,
                    0xDC, 0x45,
                    0xBA,
                    0xFC,
                    0xAE,
                    0x24,
                    0x19,
                    0x9D,
                    0xDD,
                    0xA8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFExtendedCameraIntrinsics
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAC, 0x6D, 0x7F, 0x68,
                    0x87, 0x69,
                    0x50, 0x47,
                    0xA1,
                    0x6A,
                    0x73,
                    0x4D,
                    0x1E,
                    0x7A,
                    0x10,
                    0xFE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFExtendedCameraControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0x35, 0xE3, 0x38,
                    0xA1, 0xFC,
                    0x45, 0x48,
                    0xA2,
                    0x7A,
                    0x68,
                    0xB7,
                    0xC6,
                    0xAB,
                    0x37,
                    0x89
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFExtendedCameraController
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0xBF, 0x1E, 0xB9,
                    0x03, 0xCA,
                    0xF4, 0x4A,
                    0x8A,
                    0x82,
                    0xA3,
                    0x17,
                    0x52,
                    0xF4,
                    0xA0,
                    0xFC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFRelativePanelReport
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEA, 0x62, 0x53, 0xF2,
                    0x0E, 0x2C,
                    0x7F, 0x44,
                    0x81,
                    0xE2,
                    0x75,
                    0x59,
                    0x14,
                    0xCD,
                    0xC0,
                    0xC3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFRelativePanelWatcher
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF6, 0xF7, 0x1A, 0x42,
                    0x3E, 0x57,
                    0xD0, 0x4A,
                    0x8F,
                    0xDA,
                    0x2E,
                    0x57,
                    0xCE,
                    0xDB,
                    0x18,
                    0xC6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFVideoCaptureSampleAllocator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC7, 0x77, 0x5B, 0x72,
                    0x9F, 0xCA,
                    0xE5, 0x4F,
                    0x9D,
                    0x72,
                    0x99,
                    0x46,
                    0xBF,
                    0x9B,
                    0x3C,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSampleAllocatorControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x58, 0xB9, 0x62, 0xDA,
                    0x38, 0x3A,
                    0x97, 0x4A,
                    0xBD,
                    0x27,
                    0x14,
                    0x9C,
                    0x64,
                    0x0C,
                    0x07,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
