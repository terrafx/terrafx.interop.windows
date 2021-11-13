// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateMediaSession(IMFAttributes* pConfiguration, IMFMediaSession** ppMediaSession);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreatePMPMediaSession([NativeTypeName("DWORD")] uint dwCreationFlags, IMFAttributes* pConfiguration, IMFMediaSession** ppMediaSession, IMFActivate** ppEnablerActivate);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateSourceResolver(IMFSourceResolver** ppISourceResolver);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT CreatePropertyStore(IPropertyStore** ppStore);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetSupportedSchemes(PROPVARIANT* pPropVarSchemeArray);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetSupportedMimeTypes(PROPVARIANT* pPropVarMimeTypeArray);

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

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTopology(IMFTopology** ppTopo);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTopologyNode(MF_TOPOLOGY_TYPE NodeType, IMFTopologyNode** ppNode);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetTopoNodeCurrentType(IMFTopologyNode* pNode, [NativeTypeName("DWORD")] uint dwStreamIndex, BOOL fOutput, IMFMediaType** ppType);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetService(IUnknown* punkObject, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("MFTIME")]
        public static extern long MFGetSystemTime();

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreatePresentationClock(IMFPresentationClock** ppPresentationClock);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateSystemTimeSource(IMFPresentationTimeSource** ppSystemTimeSource);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreatePresentationDescriptor([NativeTypeName("DWORD")] uint cStreamDescriptors, IMFStreamDescriptor** apStreamDescriptors, IMFPresentationDescriptor** ppPresentationDescriptor);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFRequireProtectedEnvironment(IMFPresentationDescriptor* pPresentationDescriptor);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFSerializePresentationDescriptor(IMFPresentationDescriptor* pPD, [NativeTypeName("DWORD *")] uint* pcbData, byte** ppbData);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFDeserializePresentationDescriptor([NativeTypeName("DWORD")] uint cbData, byte* pbData, IMFPresentationDescriptor** ppPD);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateStreamDescriptor([NativeTypeName("DWORD")] uint dwStreamIdentifier, [NativeTypeName("DWORD")] uint cMediaTypes, IMFMediaType** apMediaTypes, IMFStreamDescriptor** ppDescriptor);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSimpleTypeHandler(IMFMediaTypeHandler** ppHandler);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFShutdownObject(IUnknown* pUnk);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateAudioRenderer(IMFAttributes* pAudioAttributes, IMFMediaSink** ppSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateAudioRendererActivate(IMFActivate** ppActivate);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateVideoRendererActivate(HWND hwndVideo, IMFActivate** ppActivate);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateMPEG4MediaSink(IMFByteStream* pIByteStream, IMFMediaType* pVideoMediaType, IMFMediaType* pAudioMediaType, IMFMediaSink** ppIMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreate3GPMediaSink(IMFByteStream* pIByteStream, IMFMediaType* pVideoMediaType, IMFMediaType* pAudioMediaType, IMFMediaSink** ppIMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateMP3MediaSink(IMFByteStream* pTargetByteStream, IMFMediaSink** ppMediaSink);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateAC3MediaSink(IMFByteStream* pTargetByteStream, IMFMediaType* pAudioMediaType, IMFMediaSink** ppMediaSink);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateADTSMediaSink(IMFByteStream* pTargetByteStream, IMFMediaType* pAudioMediaType, IMFMediaSink** ppMediaSink);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateMuxSink(Guid guidOutputSubType, IMFAttributes* pOutputAttributes, IMFByteStream* pOutputByteStream, IMFMediaSink** ppMuxSink);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateFMPEG4MediaSink(IMFByteStream* pIByteStream, IMFMediaType* pVideoMediaType, IMFMediaType* pAudioMediaType, IMFMediaSink** ppIMediaSink);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("mfsrcsnk", ExactSpelling = true)]
        public static extern HRESULT MFCreateAVIMediaSink(IMFByteStream* pIByteStream, IMFMediaType* pVideoMediaType, IMFMediaType* pAudioMediaType, IMFMediaSink** ppIMediaSink);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("mfsrcsnk", ExactSpelling = true)]
        public static extern HRESULT MFCreateWAVEMediaSink(IMFByteStream* pTargetByteStream, IMFMediaType* pAudioMediaType, IMFMediaSink** ppMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTopoLoader(IMFTopoLoader** ppObj);

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
        public static extern HRESULT MFCreateSampleGrabberSinkActivate(IMFMediaType* pIMFMediaType, IMFSampleGrabberSinkCallback* pIMFSampleGrabberSinkCallback, IMFActivate** ppIActivate);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateStandardQualityManager(IMFQualityManager** ppQualityManager);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSequencerSource(IUnknown* pReserved, IMFSequencerSource** ppSequencerSource);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSequencerSegmentOffset([NativeTypeName("MFSequencerElementId")] uint dwId, [NativeTypeName("MFTIME")] long hnsOffset, PROPVARIANT* pvarSegmentOffset);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateAggregateSource(IMFCollection* pSourceCollection, IMFMediaSource** ppAggSource);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateCredentialCache(IMFNetCredentialCache** ppCache);

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
        public static extern HRESULT MFCreateProxyLocator([NativeTypeName("LPCWSTR")] ushort* pszProtocol, IPropertyStore* pProxyConfig, IMFNetProxyLocator** ppProxyLocator);

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
        public static extern HRESULT MFCreateNetSchemePlugin([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvHandler);

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
        public static extern HRESULT MFCreatePMPServer([NativeTypeName("DWORD")] uint dwCreationFlags, IMFPMPServer** ppPMPServer);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateRemoteDesktopPlugin(IMFRemoteDesktopPlugin** ppPlugin);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT CreateNamedPropertyStore(INamedPropertyStore** ppStore);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSampleCopierMFT(IMFTransform** ppCopierMFT);

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

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTranscodeProfile(IMFTranscodeProfile** ppTranscodeProfile);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTranscodeTopology(IMFMediaSource* pSrc, [NativeTypeName("LPCWSTR")] ushort* pwszOutputFilePath, IMFTranscodeProfile* pProfile, IMFTopology** ppTranscodeTopo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTranscodeTopologyFromByteStream(IMFMediaSource* pSrc, IMFByteStream* pOutputStream, IMFTranscodeProfile* pProfile, IMFTopology** ppTranscodeTopo);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFTranscodeGetAudioOutputAvailableTypes([NativeTypeName("const GUID &")] Guid* guidSubType, [NativeTypeName("DWORD")] uint dwMFTFlags, IMFAttributes* pCodecConfig, IMFCollection** ppAvailableTypes);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTranscodeSinkActivate(IMFActivate** ppActivate);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateTrackedSample(IMFTrackedSample** ppMFSample);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMFByteStreamOnStream(IStream* pStream, IMFByteStream** ppByteStream);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateStreamOnMFByteStream(IMFByteStream* pByteStream, IStream** ppStream);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMFByteStreamOnStreamEx(IUnknown* punkStream, IMFByteStream** ppByteStream);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateStreamOnMFByteStreamEx(IMFByteStream* pByteStream, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMediaTypeFromProperties(IUnknown* punkStream, IMFMediaType** ppMediaType);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreatePropertiesFromMediaType(IMFMediaType* pMediaType, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

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
        public static extern HRESULT MFEnumDeviceSources(IMFAttributes* pAttributes, IMFActivate*** pppSourceActivate, [NativeTypeName("UINT32 *")] uint* pcSourceActivate);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateDeviceSource(IMFAttributes* pAttributes, IMFMediaSource** ppSource);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateDeviceSourceActivate(IMFAttributes* pAttributes, IMFActivate** ppActivate);

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

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateProtectedEnvironmentAccess(IMFProtectedEnvironmentAccess** ppAccess);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFLoadSignedLibrary([NativeTypeName("LPCWSTR")] ushort* pszName, IMFSignedLibrary** ppLib);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetSystemId(IMFSystemId** ppId);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetLocalId([NativeTypeName("const BYTE *")] byte* verifier, [NativeTypeName("UINT32")] uint size, [NativeTypeName("LPWSTR *")] ushort** id);

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

        [SupportedOSPlatform("windows10.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateContentProtectionDevice([NativeTypeName("const GUID &")] Guid* ProtectionSystemId, IMFContentProtectionDevice** ContentProtectionDevice);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFIsContentProtectionDeviceSupported([NativeTypeName("const GUID &")] Guid* ProtectionSystemId, BOOL* isSupported);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateContentDecryptorContext([NativeTypeName("const GUID &")] Guid* guidMediaProtectionSystemId, IMFDXGIDeviceManager* pD3DManager, IMFContentProtectionDevice* pContentProtectionDevice, IMFContentDecryptorContext** ppContentDecryptorContext);

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

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorGroup([NativeTypeName("LPCWSTR")] ushort* SensorGroupSymbolicLink, IMFSensorGroup** ppSensorGroup);

        [SupportedOSPlatform("windows10.0.17134.0")]
        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorProfile([NativeTypeName("const GUID &")] Guid* ProfileType, [NativeTypeName("UINT32")] uint ProfileIndex, [NativeTypeName("LPCWSTR")] ushort* Constraints, IMFSensorProfile** ppProfile);

        [SupportedOSPlatform("windows10.0.15063.0")]
        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorProfileCollection(IMFSensorProfileCollection** ppSensorProfile);

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorActivityMonitor(IMFSensorActivitiesReportCallback* pCallback, IMFSensorActivityMonitor** ppActivityMonitor);

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

        [SupportedOSPlatform("windows10.0.19041.0")]
        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateRelativePanelWatcher([NativeTypeName("PCWSTR")] ushort* videoDeviceId, [NativeTypeName("PCWSTR")] ushort* displayMonitorDeviceId, IMFRelativePanelWatcher** ppRelativePanelWatcher);

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

        [NativeTypeName("#define MFRR_INFO_VERSION 0")]
        public const int MFRR_INFO_VERSION = 0;

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
