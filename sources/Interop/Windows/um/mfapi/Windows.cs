// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.MFWaveFormatExConvertFlags;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFStartup([NativeTypeName("ULONG")] uint Version, [NativeTypeName("DWORD")] uint dwFlags = 0);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFShutdown();

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLockPlatform();

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnlockPlatform();

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWorkItem([NativeTypeName("DWORD")] uint dwQueue, IMFAsyncCallback* pCallback, IUnknown* pState);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWorkItem2([NativeTypeName("DWORD")] uint dwQueue, [NativeTypeName("LONG")] int Priority, IMFAsyncCallback* pCallback, IUnknown* pState);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWorkItemEx([NativeTypeName("DWORD")] uint dwQueue, IMFAsyncResult* pResult);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWorkItemEx2([NativeTypeName("DWORD")] uint dwQueue, [NativeTypeName("LONG")] int Priority, IMFAsyncResult* pResult);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWaitingWorkItem([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("LONG")] int Priority, IMFAsyncResult* pResult, [NativeTypeName("MFWORKITEM_KEY *")] ulong* pKey);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFAllocateSerialWorkQueue([NativeTypeName("DWORD")] uint dwWorkQueue, [NativeTypeName("DWORD *")] uint* pdwWorkQueue);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFScheduleWorkItemEx(IMFAsyncResult* pResult, [NativeTypeName("INT64")] long Timeout, [NativeTypeName("MFWORKITEM_KEY *")] ulong* pKey);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFScheduleWorkItem(IMFAsyncCallback* pCallback, IUnknown* pState, [NativeTypeName("INT64")] long Timeout, [NativeTypeName("MFWORKITEM_KEY *")] ulong* pKey);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCancelWorkItem([NativeTypeName("MFWORKITEM_KEY")] ulong Key);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetTimerPeriodicity([NativeTypeName("DWORD *")] uint* Periodicity);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFAddPeriodicCallback([NativeTypeName("MFPERIODICCALLBACK")] delegate* unmanaged<IUnknown*, void> Callback, IUnknown* pContext, [NativeTypeName("DWORD *")] uint* pdwKey);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRemovePeriodicCallback([NativeTypeName("DWORD")] uint dwKey);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFAllocateWorkQueueEx(MFASYNC_WORKQUEUE_TYPE WorkQueueType, [NativeTypeName("DWORD *")] uint* pdwWorkQueue);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFAllocateWorkQueue([NativeTypeName("DWORD *")] uint* pdwWorkQueue);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLockWorkQueue([NativeTypeName("DWORD")] uint dwWorkQueue);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnlockWorkQueue([NativeTypeName("DWORD")] uint dwWorkQueue);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFBeginRegisterWorkQueueWithMMCSS([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LPCWSTR")] ushort* wszClass, [NativeTypeName("DWORD")] uint dwTaskId, IMFAsyncCallback* pDoneCallback, IUnknown* pDoneState);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFBeginRegisterWorkQueueWithMMCSSEx([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LPCWSTR")] ushort* wszClass, [NativeTypeName("DWORD")] uint dwTaskId, [NativeTypeName("LONG")] int lPriority, IMFAsyncCallback* pDoneCallback, IUnknown* pDoneState);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFEndRegisterWorkQueueWithMMCSS(IMFAsyncResult* pResult, [NativeTypeName("DWORD *")] uint* pdwTaskId);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFBeginUnregisterWorkQueueWithMMCSS([NativeTypeName("DWORD")] uint dwWorkQueueId, IMFAsyncCallback* pDoneCallback, IUnknown* pDoneState);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFEndUnregisterWorkQueueWithMMCSS(IMFAsyncResult* pResult);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetWorkQueueMMCSSClass([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LPWSTR")] ushort* pwszClass, [NativeTypeName("DWORD *")] uint* pcchClass);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetWorkQueueMMCSSTaskId([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LPDWORD")] uint* pdwTaskId);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRegisterPlatformWithMMCSS([NativeTypeName("PCWSTR")] ushort* wszClass, [NativeTypeName("DWORD *")] uint* pdwTaskId, [NativeTypeName("LONG")] int lPriority);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnregisterPlatformFromMMCSS();

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLockSharedWorkQueue([NativeTypeName("PCWSTR")] ushort* wszClass, [NativeTypeName("LONG")] int BasePriority, [NativeTypeName("DWORD *")] uint* pdwTaskId, [NativeTypeName("DWORD *")] uint* pID);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetWorkQueueMMCSSPriority([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LONG *")] int* lPriority);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAsyncResult(IUnknown* punkObject, IMFAsyncCallback* pCallback, IUnknown* punkState, IMFAsyncResult** ppAsyncResult);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInvokeCallback(IMFAsyncResult* pAsyncResult);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateFile(MF_FILE_ACCESSMODE AccessMode, MF_FILE_OPENMODE OpenMode, MF_FILE_FLAGS fFlags, [NativeTypeName("LPCWSTR")] ushort* pwszFileURL, IMFByteStream** ppIByteStream);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTempFile(MF_FILE_ACCESSMODE AccessMode, MF_FILE_OPENMODE OpenMode, MF_FILE_FLAGS fFlags, IMFByteStream** ppIByteStream);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFBeginCreateFile(MF_FILE_ACCESSMODE AccessMode, MF_FILE_OPENMODE OpenMode, MF_FILE_FLAGS fFlags, [NativeTypeName("LPCWSTR")] ushort* pwszFilePath, IMFAsyncCallback* pCallback, IUnknown* pState, IUnknown** ppCancelCookie);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFEndCreateFile(IMFAsyncResult* pResult, IMFByteStream** ppFile);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCancelCreateFile(IUnknown* pCancelCookie);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMemoryBuffer([NativeTypeName("DWORD")] uint cbMaxLength, IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaBufferWrapper(IMFMediaBuffer* pBuffer, [NativeTypeName("DWORD")] uint cbOffset, [NativeTypeName("DWORD")] uint dwLength, IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateLegacyMediaBufferOnMFMediaBuffer(IMFSample* pSample, IMFMediaBuffer* pMFMediaBuffer, [NativeTypeName("DWORD")] uint cbOffset, IMediaBuffer** ppMediaBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern DXGI_FORMAT MFMapDX9FormatToDXGIFormat([NativeTypeName("DWORD")] uint dx9);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MFMapDXGIFormatToDX9Format(DXGI_FORMAT dx11);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLockDXGIDeviceManager([NativeTypeName("UINT *")] uint* pResetToken, IMFDXGIDeviceManager** ppManager);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnlockDXGIDeviceManager();

        [DllImport("evr", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDXSurfaceBuffer([NativeTypeName("const IID &")] Guid* riid, IUnknown* punkSurface, [NativeTypeName("BOOL")] int fBottomUpWhenLinear, IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateWICBitmapBuffer([NativeTypeName("const IID &")] Guid* riid, IUnknown* punkSurface, IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDXGISurfaceBuffer([NativeTypeName("const IID &")] Guid* riid, IUnknown* punkSurface, [NativeTypeName("UINT")] uint uSubresourceIndex, [NativeTypeName("BOOL")] int fBottomUpWhenLinear, IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoSampleAllocatorEx([NativeTypeName("const IID &")] Guid* riid, void** ppSampleAllocator);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDXGIDeviceManager([NativeTypeName("UINT *")] uint* resetToken, IMFDXGIDeviceManager** ppDeviceManager);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAlignedMemoryBuffer([NativeTypeName("DWORD")] uint cbMaxLength, [NativeTypeName("DWORD")] uint cbAligment, IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, [NativeTypeName("HRESULT")] int hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue, IMFMediaEvent** ppEvent);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateEventQueue(IMFMediaEventQueue** ppMediaEventQueue);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_SESSIONCAPS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0xBC, 0x5E, 0x7E,
                    0xB8, 0x11,
                    0xBE, 0x4A,
                    0xAF,
                    0xAD,
                    0x10,
                    0xF6,
                    0x59,
                    0x9A,
                    0x7F,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_SESSIONCAPS_DELTA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD1, 0xBC, 0x5E, 0x7E,
                    0xB8, 0x11,
                    0xBE, 0x4A,
                    0xAF,
                    0xAD,
                    0x10,
                    0xF6,
                    0x59,
                    0x9A,
                    0x7F,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_TOPOLOGY_STATUS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8D, 0x01, 0xC5, 0x30,
                    0x53, 0x9A,
                    0x4B, 0x45,
                    0xAD,
                    0x9E,
                    0x6D,
                    0x5F,
                    0x8F,
                    0xA7,
                    0xC4,
                    0x3B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_START_PRESENTATION_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0x14, 0xD9, 0x5A,
                    0x45, 0x9B,
                    0x8D, 0x4A,
                    0xA2,
                    0xC0,
                    0x81,
                    0xD1,
                    0xE5,
                    0x0B,
                    0xFB,
                    0x07
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_PRESENTATION_TIME_OFFSET
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD1, 0x14, 0xD9, 0x5A,
                    0x45, 0x9B,
                    0x8D, 0x4A,
                    0xA2,
                    0xC0,
                    0x81,
                    0xD1,
                    0xE5,
                    0x0B,
                    0xFB,
                    0x07
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_START_PRESENTATION_TIME_AT_OUTPUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD2, 0x14, 0xD9, 0x5A,
                    0x45, 0x9B,
                    0x8D, 0x4A,
                    0xA2,
                    0xC0,
                    0x81,
                    0xD1,
                    0xE5,
                    0x0B,
                    0xFB,
                    0x07
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_SOURCE_FAKE_START
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA7, 0x55, 0xCC, 0xA8,
                    0x31, 0x6B,
                    0x9F, 0x41,
                    0x84,
                    0x5D,
                    0xFF,
                    0xB3,
                    0x51,
                    0xA2,
                    0x43,
                    0x4B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_SOURCE_PROJECTSTART
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA8, 0x55, 0xCC, 0xA8,
                    0x31, 0x6B,
                    0x9F, 0x41,
                    0x84,
                    0x5D,
                    0xFF,
                    0xB3,
                    0x51,
                    0xA2,
                    0x43,
                    0x4B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_SOURCE_ACTUAL_START
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA9, 0x55, 0xCC, 0xA8,
                    0x31, 0x6B,
                    0x9F, 0x41,
                    0x84,
                    0x5D,
                    0xFF,
                    0xB3,
                    0x51,
                    0xA2,
                    0x43,
                    0x4B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_SOURCE_TOPOLOGY_CANCELED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0xF6, 0x62, 0xDB,
                    0x5E, 0x9A,
                    0x04, 0x47,
                    0xAC,
                    0xF3,
                    0x56,
                    0x3B,
                    0xC6,
                    0xA7,
                    0x33,
                    0x64
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_SOURCE_CHARACTERISTICS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0x84, 0xDB, 0x47,
                    0x22, 0x8B,
                    0x52, 0x4F,
                    0xAF,
                    0xDA,
                    0x9C,
                    0xE1,
                    0xB2,
                    0xD3,
                    0xCF,
                    0xA8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_SOURCE_CHARACTERISTICS_OLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x91, 0x84, 0xDB, 0x47,
                    0x22, 0x8B,
                    0x52, 0x4F,
                    0xAF,
                    0xDA,
                    0x9C,
                    0xE1,
                    0xB2,
                    0xD3,
                    0xCF,
                    0xA8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_DO_THINNING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFB, 0xA6, 0x1E, 0x32,
                    0xD9, 0xDA,
                    0xE4, 0x46,
                    0xB3,
                    0x1D,
                    0xD2,
                    0xEA,
                    0xE7,
                    0x09,
                    0x0E,
                    0x30
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_SCRUBSAMPLE_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB3, 0x12, 0xC7, 0x9A,
                    0xB8, 0xDC,
                    0xD5, 0x44,
                    0x8D,
                    0x0C,
                    0x37,
                    0x45,
                    0x5A,
                    0x27,
                    0x82,
                    0xE3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_OUTPUT_NODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8B, 0x1A, 0x0F, 0x83,
                    0x60, 0xC0,
                    0xDD, 0x46,
                    0xA8,
                    0x01,
                    0x1C,
                    0x95,
                    0xDE,
                    0xC9,
                    0xB1,
                    0x07
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_MFT_INPUT_STREAM_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCA, 0x2C, 0x9C, 0xF2,
                    0xE6, 0x7A,
                    0xD2, 0x42,
                    0xB2,
                    0x84,
                    0xBF,
                    0x83,
                    0x7C,
                    0xC8,
                    0x74,
                    0xE2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_MFT_CONTEXT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0x31, 0xCD, 0xB7,
                    0x9E, 0x89,
                    0x41, 0x4B,
                    0x80,
                    0xC9,
                    0x26,
                    0xA8,
                    0x96,
                    0xD3,
                    0x29,
                    0x77
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_STREAM_METADATA_KEYDATA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0xA4, 0x59, 0xCD,
                    0x3B, 0x4A,
                    0xBD, 0x4B,
                    0x86,
                    0x65,
                    0x72,
                    0xA4,
                    0x0F,
                    0xBE,
                    0xA7,
                    0x76
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_STREAM_METADATA_CONTENT_KEYIDS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9D, 0x44, 0x63, 0x50,
                    0x29, 0xCC,
                    0xC6, 0x4F,
                    0xA7,
                    0x5A,
                    0xD2,
                    0x47,
                    0xB3,
                    0x5A,
                    0xF8,
                    0x5C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_EVENT_STREAM_METADATA_SYSTEMID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0xEF, 0xA2, 0x1E,
                    0x16, 0xBA,
                    0x36, 0x4A,
                    0x87,
                    0x19,
                    0xFE,
                    0x75,
                    0x60,
                    0xBA,
                    0x32,
                    0xAD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSample(IMFSample** ppIMFSample);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_MaxDecodeFrameSize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4F, 0x65, 0xCC, 0xD3,
                    0xF3, 0xF9,
                    0x13, 0x4A,
                    0x88,
                    0x9F,
                    0xF0,
                    0x4E,
                    0xB2,
                    0xB5,
                    0xB9,
                    0x57
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_AccumulatedNonRefPicPercent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0x74, 0xEA, 0x79,
                    0x40, 0xA7,
                    0x5B, 0x44,
                    0xBC,
                    0x98,
                    0xC9,
                    0xED,
                    0x1F,
                    0x26,
                    0x0E,
                    0xEE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_ProtectionScheme
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x96, 0xD0, 0x54, 0xD0,
                    0xBB, 0x28,
                    0xDA, 0x45,
                    0x87,
                    0xEC,
                    0x74,
                    0xF3,
                    0x51,
                    0x87,
                    0x14,
                    0x06
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_CryptByteBlock
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9B, 0x28, 0x84, 0x9D,
                    0x7F, 0x0C,
                    0x13, 0x47,
                    0xAB,
                    0x95,
                    0x10,
                    0x8A,
                    0xB4,
                    0x2A,
                    0xD8,
                    0x01
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_SkipByteBlock
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0x05, 0x55, 0x0D,
                    0x17, 0x83,
                    0xB1, 0x4A,
                    0x84,
                    0x5F,
                    0xD0,
                    0x63,
                    0x06,
                    0xE2,
                    0x93,
                    0xE3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_SubSample_Mapping
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7A, 0xF2, 0x44, 0x84,
                    0xA1, 0x69,
                    0xDA, 0x48,
                    0xBD,
                    0x08,
                    0x11,
                    0xCE,
                    0xF3,
                    0x68,
                    0x30,
                    0xD2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_ClearSliceHeaderData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF4, 0xA4, 0x09, 0x55,
                    0x0D, 0x32,
                    0x6C, 0x4E,
                    0x8D,
                    0x1A,
                    0x94,
                    0xC6,
                    0x6D,
                    0xD2,
                    0x0C,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_HardwareProtection_KeyInfoID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEB, 0xCC, 0xBF, 0x8C,
                    0xA5, 0x94,
                    0xE1, 0x4D,
                    0x82,
                    0x31,
                    0xA8,
                    0x5E,
                    0x47,
                    0xCF,
                    0x81,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_HardwareProtection_KeyInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x20, 0x37, 0xB2,
                    0x5B, 0x45,
                    0xD7, 0x4D,
                    0x99,
                    0x89,
                    0x1A,
                    0x95,
                    0x57,
                    0x84,
                    0xB7,
                    0x54
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_HardwareProtection_VideoDecryptorContext
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC8, 0x70, 0x34, 0x69,
                    0x37, 0xE8,
                    0xA0, 0x47,
                    0x88,
                    0xCB,
                    0x53,
                    0x5B,
                    0x90,
                    0x5E,
                    0x35,
                    0x82
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_Opaque_Data
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE5, 0x77, 0x4D, 0x22,
                    0x91, 0x13,
                    0xFB, 0x4F,
                    0x9F,
                    0x41,
                    0xB4,
                    0x32,
                    0xF6,
                    0x8C,
                    0x61,
                    0x1D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_NALULengthInfo
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

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_ResumeVideoOutput
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA5, 0xAB, 0x35, 0xA4,
                    0xDE, 0xAF,
                    0xF5, 0x4C,
                    0xBC,
                    0x1C,
                    0xF6,
                    0xAC,
                    0xAF,
                    0x13,
                    0x94,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_NALUTypes
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC7, 0x67, 0xF0, 0xB0,
                    0x4C, 0x71,
                    0x6C, 0x41,
                    0x8D,
                    0x59,
                    0x5F,
                    0x4D,
                    0xDF,
                    0x89,
                    0x13,
                    0xB6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_SPSPPSData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0x0F, 0xDE, 0xAE,
                    0x0C, 0x0E,
                    0x3C, 0x45,
                    0xB7,
                    0xF3,
                    0xDE,
                    0x86,
                    0x93,
                    0x36,
                    0x4D,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_SEIData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0xE9, 0xF0, 0x3C,
                    0x42, 0x45,
                    0x87, 0x46,
                    0x99,
                    0x99,
                    0x58,
                    0x5F,
                    0x56,
                    0x5F,
                    0xBA,
                    0x7D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_HardwareProtection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0x2D, 0x2B, 0x9A,
                    0x70, 0x82,
                    0xE3, 0x43,
                    0x84,
                    0x48,
                    0x99,
                    0x4F,
                    0x42,
                    0x6E,
                    0x88,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_CleanPoint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0x01, 0xDF, 0x9C,
                    0xF0, 0xA0,
                    0xBA, 0x43,
                    0xB0,
                    0x77,
                    0xEA,
                    0xA0,
                    0x6C,
                    0xBD,
                    0x72,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Discontinuity
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD9, 0x01, 0xDF, 0x9C,
                    0xF0, 0xA0,
                    0xBA, 0x43,
                    0xB0,
                    0x77,
                    0xEA,
                    0xA0,
                    0x6C,
                    0xBD,
                    0x72,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Token
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0xDA, 0x94, 0x82,
                    0x28, 0xF3,
                    0x05, 0x48,
                    0xB5,
                    0x51,
                    0x00,
                    0xDE,
                    0xB4,
                    0xC5,
                    0x7A,
                    0x61
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_ClosedCaption_CEA708
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x68, 0x90, 0xF0, 0x26,
                    0x44, 0xE7,
                    0xDC, 0x47,
                    0xAA,
                    0x03,
                    0xDB,
                    0xF2,
                    0x04,
                    0x03,
                    0xBD,
                    0xE6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_DecodeTimestamp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD4, 0x54, 0xA9, 0x73,
                    0xE2, 0x09,
                    0x61, 0x48,
                    0xBE,
                    0xFC,
                    0x94,
                    0xBD,
                    0x97,
                    0xC0,
                    0x8E,
                    0x6E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_VideoEncodeQP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x78, 0xE4, 0xEF, 0xB2,
                    0x79, 0xF9,
                    0x66, 0x4C,
                    0xB9,
                    0x5E,
                    0xEE,
                    0x2B,
                    0x82,
                    0xC8,
                    0x2F,
                    0x36
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_VideoEncodePictureType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE6, 0x04, 0x37, 0x97,
                    0x14, 0xCD,
                    0x3C, 0x48,
                    0x8F,
                    0x20,
                    0xC9,
                    0xFC,
                    0x09,
                    0x28,
                    0xBA,
                    0xD5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_FrameCorruption
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8C, 0x4A, 0xDD, 0xB4,
                    0xEB, 0x0B,
                    0xC4, 0x44,
                    0x8B,
                    0x75,
                    0xB0,
                    0x2B,
                    0x91,
                    0x3B,
                    0x04,
                    0xF0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_DirtyRects
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x25, 0x02, 0xA7, 0x9B,
                    0x42, 0xB3,
                    0x97, 0x4E,
                    0x91,
                    0x26,
                    0x0B,
                    0x56,
                    0x6A,
                    0xB7,
                    0xEA,
                    0x7E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_MoveRegions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x93, 0xC6, 0xA6, 0xE2,
                    0x8B, 0x3A,
                    0x8D, 0x4B,
                    0x95,
                    0xD0,
                    0xF6,
                    0x02,
                    0x81,
                    0xA1,
                    0x2F,
                    0xB7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_HDCP_OptionalHeader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0x73, 0x2E, 0x9A,
                    0x1F, 0x12,
                    0x5F, 0x45,
                    0x83,
                    0x76,
                    0xC9,
                    0x74,
                    0x28,
                    0xE0,
                    0xB5,
                    0x40
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_HDCP_FrameCounter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0x9C, 0x38, 0x9D,
                    0x07, 0xF5,
                    0xA6, 0x4A,
                    0xA4,
                    0x0A,
                    0x71,
                    0x02,
                    0x7A,
                    0x02,
                    0xF3,
                    0xDE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_HDCP_StreamID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0x5D, 0x7E, 0x17,
                    0x70, 0xC3,
                    0x7A, 0x4A,
                    0x95,
                    0xA2,
                    0x36,
                    0x83,
                    0x3C,
                    0x01,
                    0xD0,
                    0xAF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Timestamp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x99, 0x69, 0x43, 0x1E,
                    0xBE, 0x69,
                    0x7A, 0x4C,
                    0x93,
                    0x69,
                    0x70,
                    0x06,
                    0x8C,
                    0x02,
                    0x60,
                    0xCB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_RepeatFrame
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8F, 0x73, 0xBE, 0x88,
                    0x11, 0x07,
                    0x42, 0x4F,
                    0xB4,
                    0x58,
                    0x34,
                    0x4A,
                    0xED,
                    0x42,
                    0xEC,
                    0x2F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_ENCODER_ERROR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0xED, 0xD1, 0xC8,
                    0xE4, 0x98,
                    0xD5, 0x41,
                    0x92,
                    0x97,
                    0x44,
                    0xF5,
                    0x38,
                    0x52,
                    0xF9,
                    0x0E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_GFX_DRIVER_VERSION_ID_Attribute
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x93, 0x90, 0x4B, 0xF3,
                    0xE0, 0x05,
                    0x16, 0x4B,
                    0x99,
                    0x3D,
                    0x3E,
                    0x2A,
                    0x2C,
                    0xDE,
                    0x6A,
                    0xD3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_DescrambleData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE6, 0x3B, 0x48, 0x43,
                    0x03, 0x49,
                    0x14, 0x43,
                    0xB0,
                    0x32,
                    0x29,
                    0x51,
                    0x36,
                    0x59,
                    0x36,
                    0xFC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_SampleKeyID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC8, 0x13, 0xD7, 0x9E,
                    0x87, 0x9B,
                    0x26, 0x4B,
                    0x82,
                    0x97,
                    0xA9,
                    0x3B,
                    0x0C,
                    0x5A,
                    0x8A,
                    0xCC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_GenKeyFunc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0xA1, 0x1C, 0x44,
                    0x1F, 0x6B,
                    0x01, 0x45,
                    0x90,
                    0x3A,
                    0xDE,
                    0x87,
                    0xDF,
                    0x42,
                    0xF6,
                    0xED
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_GenKeyCtx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCB, 0x20, 0x81, 0x18,
                    0xDA, 0xD7,
                    0x59, 0x4B,
                    0x9B,
                    0x3E,
                    0x92,
                    0x52,
                    0xFD,
                    0x37,
                    0x30,
                    0x1C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_PacketCrossOffsets
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1D, 0x67, 0x89, 0x27,
                    0x9F, 0x38,
                    0xBB, 0x40,
                    0x90,
                    0xD9,
                    0xC2,
                    0x82,
                    0xF7,
                    0x7F,
                    0x9A,
                    0xBD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_SampleID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4E, 0xB8, 0x98, 0x66,
                    0xFA, 0x0A,
                    0x30, 0x43,
                    0xAE,
                    0xB2,
                    0x1C,
                    0x0A,
                    0x98,
                    0xD7,
                    0xA4,
                    0x4D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_KeyID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x91, 0x65, 0x37, 0x76,
                    0x5F, 0x79,
                    0xA1, 0x4D,
                    0x86,
                    0xED,
                    0x9D,
                    0x46,
                    0xEC,
                    0xA1,
                    0x09,
                    0xA9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Content_KeyID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0xF5, 0xC7, 0xC6,
                    0xCA, 0xAC,
                    0x5B, 0x41,
                    0x87,
                    0xD9,
                    0x10,
                    0x44,
                    0x14,
                    0x69,
                    0xEF,
                    0xC6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Encryption_SubSampleMappingSplit
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB9, 0x54, 0x02, 0xFE,
                    0xA5, 0x2A,
                    0xDC, 0x4E,
                    0x99,
                    0xF7,
                    0x17,
                    0xE8,
                    0x9D,
                    0xBF,
                    0x91,
                    0x74
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Interlaced
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0A, 0x83, 0xD5, 0xB1,
                    0xB8, 0xDE,
                    0xE3, 0x40,
                    0x90,
                    0xFA,
                    0x38,
                    0x99,
                    0x43,
                    0x71,
                    0x64,
                    0x61
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_BottomFieldFirst
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0xE0, 0x1C, 0x94,
                    0xE3, 0x6A,
                    0xDA, 0x4D,
                    0x9A,
                    0x08,
                    0xA6,
                    0x42,
                    0x98,
                    0x34,
                    0x06,
                    0x17
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_RepeatFirstField
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0x25, 0x4D, 0x30,
                    0x93, 0x74,
                    0xBD, 0x4F,
                    0xB1,
                    0x49,
                    0x92,
                    0x28,
                    0xDE,
                    0x8D,
                    0x9A,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_SingleField
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0xF8, 0x85, 0x9D,
                    0x8B, 0x65,
                    0x5A, 0x45,
                    0xBD,
                    0xE0,
                    0x9F,
                    0xA7,
                    0xE1,
                    0x5A,
                    0xB8,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_DerivedFromTopField
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5A, 0x46, 0x52, 0x68,
                    0x1C, 0xAE,
                    0x53, 0x45,
                    0x8E,
                    0x9B,
                    0xC3,
                    0x42,
                    0x0F,
                    0xCB,
                    0x16,
                    0x37
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_MeanAbsoluteDifference
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x11, 0xDE, 0xDB, 0x1C,
                    0xB4, 0x08,
                    0x11, 0x43,
                    0xA6,
                    0xDD,
                    0x0F,
                    0x9F,
                    0x37,
                    0x19,
                    0x07,
                    0xAA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_LongTermReferenceFrameInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3F, 0x73, 0x54, 0x91,
                    0xBD, 0xE1,
                    0xBF, 0x41,
                    0x81,
                    0xD3,
                    0xFC,
                    0xD9,
                    0x18,
                    0xF7,
                    0x13,
                    0x32
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_ROIRectangle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x38, 0xA4, 0x14, 0x34,
                    0x98, 0x49,
                    0x2C, 0x4D,
                    0xBE,
                    0x82,
                    0xBE,
                    0x3C,
                    0xA0,
                    0xB2,
                    0x4D,
                    0x43
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_LastSlice
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x57, 0x54, 0x5D, 0x2B,
                    0x47, 0x55,
                    0x07, 0x4F,
                    0xB8,
                    0xC8,
                    0xB4,
                    0xA3,
                    0xA9,
                    0xA1,
                    0xDA,
                    0xAC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_FeatureMap
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x65, 0xD1, 0x32, 0xA0,
                    0xFC, 0x46,
                    0x0A, 0x40,
                    0xB4,
                    0x49,
                    0x49,
                    0xDE,
                    0x53,
                    0xE6,
                    0x2A,
                    0x6E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_ChromaOnly
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9C, 0x17, 0xB9, 0x1E,
                    0x1F, 0xA0,
                    0x45, 0x48,
                    0x8C,
                    0x04,
                    0x0E,
                    0x65,
                    0xA2,
                    0x6E,
                    0xB0,
                    0x4F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_PhotoThumbnail
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5C, 0xC8, 0xBB, 0x74,
                    0xBB, 0xC8,
                    0xDC, 0x42,
                    0xB5,
                    0x86,
                    0xDA,
                    0x17,
                    0xFF,
                    0xD3,
                    0x5D,
                    0xCC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_PhotoThumbnailMediaType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0x54, 0xAD, 0x61,
                    0xF8, 0xEB,
                    0x43, 0x41,
                    0x89,
                    0xAF,
                    0x6B,
                    0xF2,
                    0x5F,
                    0x67,
                    0x2D,
                    0xEF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_CaptureMetadata
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA8, 0x23, 0xBE, 0x2E,
                    0xF5, 0xFA,
                    0x4A, 0x44,
                    0xA6,
                    0xA2,
                    0xEB,
                    0x81,
                    0x08,
                    0x80,
                    0xAB,
                    0x5D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_MDLCacheCookie
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0x2A, 0x00, 0x5F,
                    0xF9, 0xD8,
                    0xA3, 0x41,
                    0xB6,
                    0xC3,
                    0xA2,
                    0xAD,
                    0x43,
                    0xF6,
                    0x47,
                    0xAD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_PHOTO_FRAME_FLASH
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC6, 0xD6, 0x9D, 0x0F,
                    0x03, 0x60,
                    0xD8, 0x45,
                    0xBD,
                    0x59,
                    0xF1,
                    0xF5,
                    0x3E,
                    0x3D,
                    0x04,
                    0xE8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_FRAME_RAWSTREAM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7B, 0x07, 0x52, 0x92,
                    0x80, 0x26,
                    0xB9, 0x49,
                    0xAE,
                    0x02,
                    0xB1,
                    0x90,
                    0x75,
                    0x97,
                    0x3B,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_FOCUSSTATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x54, 0xE1, 0x7E, 0xA8,
                    0x7F, 0x99,
                    0x5D, 0x46,
                    0xB9,
                    0x1F,
                    0x29,
                    0xD5,
                    0x3B,
                    0x98,
                    0x2B,
                    0x88
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_REQUESTED_FRAME_SETTING_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD9, 0x16, 0x37, 0xBB,
                    0x61, 0x8A,
                    0xA4, 0x47,
                    0x81,
                    0x97,
                    0x45,
                    0x9C,
                    0x7F,
                    0xF1,
                    0x74,
                    0xD5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_EXPOSURE_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x99, 0xAE, 0xB9, 0x16,
                    0x84, 0xCD,
                    0x63, 0x40,
                    0x87,
                    0x9D,
                    0xA2,
                    0x8C,
                    0x76,
                    0x33,
                    0x72,
                    0x9E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_EXPOSURE_COMPENSATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x75, 0xAA, 0x98, 0xD1,
                    0x62, 0x4B,
                    0x45, 0x43,
                    0xAB,
                    0xF3,
                    0x3C,
                    0x31,
                    0xFA,
                    0x12,
                    0xC2,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_ISO_SPEED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8F, 0xA6, 0x28, 0xE5,
                    0xE3, 0xB2,
                    0xFE, 0x44,
                    0x8B,
                    0x65,
                    0x07,
                    0xBF,
                    0x4B,
                    0x5A,
                    0x13,
                    0xFF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_LENS_POSITION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x86, 0x8E, 0xFC, 0xB5,
                    0xD1, 0x11,
                    0x70, 0x4E,
                    0x81,
                    0x9B,
                    0x72,
                    0x3A,
                    0x89,
                    0xFA,
                    0x45,
                    0x20
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_SCENE_MODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0xB5, 0xC3, 0x9C,
                    0xD3, 0x5E,
                    0xAE, 0x4B,
                    0xB3,
                    0x88,
                    0x76,
                    0x70,
                    0xAE,
                    0xF5,
                    0x9E,
                    0x13
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_FLASH
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0B, 0x52, 0x51, 0x4A,
                    0x36, 0xFB,
                    0x6C, 0x44,
                    0x9D,
                    0xF2,
                    0x68,
                    0x17,
                    0x1B,
                    0x9A,
                    0x03,
                    0x89
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_FLASH_POWER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0x0D, 0x0E, 0x9C,
                    0x05, 0x02,
                    0x1A, 0x49,
                    0xBC,
                    0x9D,
                    0x2D,
                    0x6E,
                    0x1F,
                    0x4D,
                    0x56,
                    0x84
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_WHITEBALANCE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x77, 0xFD, 0x36, 0xC7,
                    0xB9, 0x0F,
                    0x2E, 0x4E,
                    0x97,
                    0xA2,
                    0xFC,
                    0xD4,
                    0x90,
                    0x73,
                    0x9E,
                    0xE9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_ZOOMFACTOR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0x0B, 0x0B, 0xE5,
                    0x01, 0xE5,
                    0xC2, 0x42,
                    0xAB,
                    0xF2,
                    0x85,
                    0x7E,
                    0xCB,
                    0x13,
                    0xFA,
                    0x5C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_FACEROIS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA6, 0x25, 0x4F, 0x86,
                    0x9F, 0x34,
                    0xB1, 0x46,
                    0xA3,
                    0x0E,
                    0x54,
                    0xCC,
                    0x22,
                    0x92,
                    0x8A,
                    0x47
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_FACEROITIMESTAMPS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCC, 0x50, 0x4D, 0xE9,
                    0xA0, 0x3D,
                    0xD4, 0x44,
                    0xBB,
                    0x34,
                    0x83,
                    0x19,
                    0x8A,
                    0x74,
                    0x18,
                    0x68
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_FACEROICHARACTERIZATIONS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA8, 0xA1, 0x27, 0xB9,
                    0xEF, 0x18,
                    0xD3, 0x46,
                    0xB3,
                    0xAF,
                    0x69,
                    0x37,
                    0x2F,
                    0x94,
                    0xD9,
                    0xB2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_ISO_GAINS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC9, 0x2A, 0x80, 0x05,
                    0x1D, 0x0E,
                    0xC7, 0x41,
                    0xA8,
                    0xC8,
                    0x7E,
                    0x73,
                    0x69,
                    0xF8,
                    0x4E,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_SENSORFRAMERATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7E, 0x35, 0x51, 0xDB,
                    0x3D, 0x9D,
                    0x62, 0x49,
                    0xB0,
                    0x6D,
                    0x07,
                    0xCE,
                    0x65,
                    0x0D,
                    0x9A,
                    0x0A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_WHITEBALANCE_GAINS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8F, 0x0C, 0x57, 0xE7,
                    0xCB, 0x2D,
                    0x7C, 0x4C,
                    0xAA,
                    0xCE,
                    0x22,
                    0xEC,
                    0xE7,
                    0xCC,
                    0xE6,
                    0x47
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_HISTOGRAM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x32, 0x84, 0x35, 0x85,
                    0xF6, 0x2E,
                    0xA9, 0x4B,
                    0xA3,
                    0xFB,
                    0x06,
                    0xD8,
                    0x29,
                    0x74,
                    0xB8,
                    0x95
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_EXIF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB8, 0x75, 0x95, 0x2E,
                    0x31, 0x8C,
                    0x02, 0x4A,
                    0x85,
                    0x75,
                    0x42,
                    0xB1,
                    0x97,
                    0xB7,
                    0x15,
                    0x92
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_FRAME_ILLUMINATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFC, 0x8F, 0x68, 0x6D,
                    0xD3, 0x63,
                    0xFE, 0x46,
                    0xBA,
                    0xDA,
                    0x5B,
                    0x94,
                    0x7D,
                    0xB0,
                    0xD0,
                    0x80
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_UVC_PAYLOADHEADER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x87, 0x8A, 0xF8, 0xF9,
                    0xDD, 0xE1,
                    0x1E, 0x44,
                    0x95,
                    0xCB,
                    0x42,
                    0xE2,
                    0x1A,
                    0x64,
                    0xF1,
                    0xD9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Depth_MinReliableDepth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB2, 0x82, 0x85, 0x5F,
                    0x6B, 0xE3,
                    0xC8, 0x47,
                    0x9B,
                    0x87,
                    0xFE,
                    0xE1,
                    0xCA,
                    0x72,
                    0xC5,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_Depth_MaxReliableDepth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD1, 0x45, 0x55, 0xE4,
                    0x0F, 0x1F,
                    0x32, 0x4A,
                    0xA8,
                    0xA7,
                    0x61,
                    0x01,
                    0xA2,
                    0x4E,
                    0xA8,
                    0xBE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_FIRST_SCANLINE_START_TIME_QPC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0x49, 0x2C, 0x6A,
                    0x52, 0xE0,
                    0xB6, 0x46,
                    0xB2,
                    0xD9,
                    0x73,
                    0xC1,
                    0x55,
                    0x87,
                    0x09,
                    0xAF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_LAST_SCANLINE_END_TIME_QPC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCB, 0xDE, 0xCA, 0xDC,
                    0xD4, 0xC4,
                    0x0D, 0x40,
                    0xB4,
                    0x18,
                    0x10,
                    0xE8,
                    0x85,
                    0x25,
                    0xE1,
                    0xF6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_SCANLINE_TIME_QPC_ACCURACY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x51, 0x9C, 0xD7, 0x4C,
                    0x65, 0xF7,
                    0x09, 0x4B,
                    0xB1,
                    0xE1,
                    0x27,
                    0xD1,
                    0xF7,
                    0xEB,
                    0xEA,
                    0x09
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_SCANLINE_DIRECTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBA, 0xA3, 0x96, 0x64,
                    0x07, 0x19,
                    0xE6, 0x49,
                    0xB0,
                    0xC3,
                    0x12,
                    0x37,
                    0x95,
                    0xF3,
                    0x80,
                    0xA9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_CAPTURE_METADATA_DIGITALWINDOW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0x72, 0x6F, 0x27,
                    0xC8, 0x59,
                    0x69, 0x4F,
                    0x97,
                    0xB4,
                    0x06,
                    0x8B,
                    0x8C,
                    0x0E,
                    0xC0,
                    0x44
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAttributes(IMFAttributes** ppMFAttributes, [NativeTypeName("UINT32")] uint cInitialSize);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitAttributesFromBlob(IMFAttributes* pAttributes, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT")] uint cbBufSize);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetAttributesAsBlobSize(IMFAttributes* pAttributes, [NativeTypeName("UINT32 *")] uint* pcbBufSize);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetAttributesAsBlob(IMFAttributes* pAttributes, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT")] uint cbBufSize);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_CATEGORY_VIDEO_DECODER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4B, 0x2D, 0xC0, 0xD6,
                    0x33, 0x68,
                    0xB4, 0x45,
                    0x97,
                    0x1A,
                    0x05,
                    0xA4,
                    0xB0,
                    0x4B,
                    0xAB,
                    0x91
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_CATEGORY_VIDEO_ENCODER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7D, 0xAC, 0x9E, 0xF7,
                    0x45, 0xE5,
                    0x87, 0x43,
                    0xBD,
                    0xEE,
                    0xD6,
                    0x47,
                    0xD7,
                    0xBD,
                    0xE4,
                    0x2A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_CATEGORY_VIDEO_EFFECT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0x7C, 0xE1, 0x12,
                    0x2C, 0x53,
                    0x6E, 0x4A,
                    0x8A,
                    0x1C,
                    0x40,
                    0x82,
                    0x5A,
                    0x73,
                    0x63,
                    0x97
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_CATEGORY_MULTIPLEXER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1E, 0x56, 0x9C, 0x05,
                    0xAE, 0x05,
                    0x61, 0x4B,
                    0xB6,
                    0x9D,
                    0x55,
                    0xB6,
                    0x1E,
                    0xE5,
                    0x4A,
                    0x7B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_CATEGORY_DEMULTIPLEXER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7A, 0x0A, 0x70, 0xA8,
                    0x9B, 0x93,
                    0xC5, 0x44,
                    0x99,
                    0xD7,
                    0x76,
                    0x22,
                    0x6B,
                    0x23,
                    0xB3,
                    0xF1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_CATEGORY_AUDIO_DECODER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB4, 0x3F, 0xA7, 0x9E,
                    0x7A, 0xEF,
                    0x59, 0x45,
                    0x8D,
                    0x5D,
                    0x71,
                    0x9D,
                    0x8F,
                    0x04,
                    0x26,
                    0xC7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_CATEGORY_AUDIO_ENCODER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0x4B, 0xC6, 0x91,
                    0x1E, 0xF9,
                    0x8C, 0x4D,
                    0x92,
                    0x76,
                    0xDB,
                    0x24,
                    0x82,
                    0x79,
                    0xD9,
                    0x75
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_CATEGORY_AUDIO_EFFECT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0x4C, 0x06, 0x11,
                    0x48, 0x36,
                    0xD0, 0x4E,
                    0x93,
                    0x2E,
                    0x05,
                    0xCE,
                    0x8A,
                    0xC8,
                    0x11,
                    0xB7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_CATEGORY_VIDEO_PROCESSOR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFC, 0xA3, 0x2E, 0x30,
                    0x5F, 0xAA,
                    0xF9, 0x47,
                    0x9F,
                    0x7A,
                    0xC2,
                    0x18,
                    0x8B,
                    0xB1,
                    0x63,
                    0x02
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_CATEGORY_OTHER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x57, 0x5D, 0x17, 0x90,
                    0xEA, 0xB7,
                    0x01, 0x49,
                    0xAE,
                    0xB3,
                    0x93,
                    0x3A,
                    0x87,
                    0x47,
                    0x75,
                    0x6F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_CATEGORY_ENCRYPTOR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBE, 0x87, 0xC6, 0xB0,
                    0xCD, 0x01,
                    0xB5, 0x44,
                    0xB8,
                    0xB2,
                    0x7C,
                    0x1D,
                    0x7E,
                    0x05,
                    0x8B,
                    0x1F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_CATEGORY_VIDEO_RENDERER_EFFECT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB4, 0xD8, 0x5C, 0x14,
                    0xF4, 0x92,
                    0x23, 0x4B,
                    0x8A,
                    0xE7,
                    0xE0,
                    0xDF,
                    0x06,
                    0xC2,
                    0xDA,
                    0x95
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTRegister([NativeTypeName("CLSID")] Guid clsidMFT, [NativeTypeName("GUID")] Guid guidCategory, [NativeTypeName("LPWSTR")] ushort* pszName, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("UINT32")] uint cInputTypes, MFT_REGISTER_TYPE_INFO* pInputTypes, [NativeTypeName("UINT32")] uint cOutputTypes, MFT_REGISTER_TYPE_INFO* pOutputTypes, IMFAttributes* pAttributes);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTUnregister([NativeTypeName("CLSID")] Guid clsidMFT);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTRegisterLocal(IClassFactory* pClassFactory, [NativeTypeName("const GUID &")] Guid* guidCategory, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("UINT32")] uint cInputTypes, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputTypes, [NativeTypeName("UINT32")] uint cOutputTypes, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputTypes);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTUnregisterLocal(IClassFactory* pClassFactory);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTRegisterLocalByCLSID([NativeTypeName("const IID &")] Guid* clisdMFT, [NativeTypeName("const GUID &")] Guid* guidCategory, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("UINT32")] uint cInputTypes, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputTypes, [NativeTypeName("UINT32")] uint cOutputTypes, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputTypes);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTUnregisterLocalByCLSID([NativeTypeName("CLSID")] Guid clsidMFT);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTEnum([NativeTypeName("GUID")] Guid guidCategory, [NativeTypeName("UINT32")] uint Flags, MFT_REGISTER_TYPE_INFO* pInputType, MFT_REGISTER_TYPE_INFO* pOutputType, IMFAttributes* pAttributes, [NativeTypeName("CLSID **")] Guid** ppclsidMFT, [NativeTypeName("UINT32 *")] uint* pcMFTs);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTEnumEx([NativeTypeName("GUID")] Guid guidCategory, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputType, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputType, IMFActivate*** pppMFTActivate, [NativeTypeName("UINT32 *")] uint* pnumMFTActivate);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_ENUM_VIDEO_RENDERER_EXTENSION_PROFILE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0x69, 0xC5, 0x62,
                    0x4E, 0x9A,
                    0x3B, 0x44,
                    0xB9,
                    0xDC,
                    0xCA,
                    0xC8,
                    0x30,
                    0xC2,
                    0x41,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_ENUM_ADAPTER_LUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8C, 0x51, 0x39, 0x1D,
                    0x20, 0xE2,
                    0xA8, 0x4D,
                    0xA0,
                    0x7F,
                    0xBA,
                    0x17,
                    0x25,
                    0x52,
                    0xD6,
                    0xB1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTEnum2([NativeTypeName("GUID")] Guid guidCategory, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputType, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputType, IMFAttributes* pAttributes, IMFActivate*** pppMFTActivate, [NativeTypeName("UINT32 *")] uint* pnumMFTActivate);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTGetInfo([NativeTypeName("CLSID")] Guid clsidMFT, [NativeTypeName("LPWSTR *")] ushort** pszName, MFT_REGISTER_TYPE_INFO** ppInputTypes, [NativeTypeName("UINT32 *")] uint* pcInputTypes, MFT_REGISTER_TYPE_INFO** ppOutputTypes, [NativeTypeName("UINT32 *")] uint* pcOutputTypes, IMFAttributes** ppAttributes);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetPluginControl(IMFPluginControl** ppPluginControl);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetMFTMerit(IUnknown* pMFT, [NativeTypeName("UINT32")] uint cbVerifier, [NativeTypeName("const BYTE *")] byte* verifier, [NativeTypeName("DWORD *")] uint* merit);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRegisterLocalSchemeHandler([NativeTypeName("PCWSTR")] ushort* szScheme, IMFActivate* pActivate);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRegisterLocalByteStreamHandler([NativeTypeName("PCWSTR")] ushort* szFileExtension, [NativeTypeName("PCWSTR")] ushort* szMimeType, IMFActivate* pActivate);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMFByteStreamWrapper(IMFByteStream* pStream, IMFByteStream** ppStreamWrapper);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaExtensionActivate([NativeTypeName("PCWSTR")] ushort* szActivatableClassId, IUnknown* pConfiguration, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFT_SUPPORT_DYNAMIC_FORMAT_CHANGE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x11, 0x6A, 0x47, 0x53,
                    0x13, 0x3F,
                    0xFB, 0x49,
                    0xAC,
                    0x42,
                    0xEE,
                    0x27,
                    0x33,
                    0xC9,
                    0x67,
                    0x41
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_Base
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_RGB32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_ARGB32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x15, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_RGB24
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x14, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_RGB555
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x18, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_RGB565
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x17, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_RGB8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x29, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_L8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x32, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_L16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x51, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_D16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_AI44
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0x49, 0x34, 0x34,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_AYUV
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0x59, 0x55, 0x56,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_YUY2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x55, 0x59, 0x32,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_YVYU
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x56, 0x59, 0x55,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_YVU9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x56, 0x55, 0x39,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_UYVY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x55, 0x59, 0x56, 0x59,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_NV11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4E, 0x56, 0x31, 0x31,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_NV12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4E, 0x56, 0x31, 0x32,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_YV12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x56, 0x31, 0x32,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_I420
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0x34, 0x32, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_IYUV
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0x59, 0x55, 0x56,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_Y210
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x32, 0x31, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_Y216
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x32, 0x31, 0x36,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_Y410
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x34, 0x31, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_Y416
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x34, 0x31, 0x36,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_Y41P
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x34, 0x31, 0x50,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_Y41T
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x34, 0x31, 0x54,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_Y42T
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x34, 0x32, 0x54,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_P210
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x32, 0x31, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_P216
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x32, 0x31, 0x36,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_P010
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x30, 0x31, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_P016
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x30, 0x31, 0x36,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_v210
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0x32, 0x31, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_v216
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0x32, 0x31, 0x36,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_v410
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0x34, 0x31, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_MP43
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0x50, 0x34, 0x33,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_MP4S
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0x50, 0x34, 0x53,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_M4S2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0x34, 0x53, 0x32,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_MP4V
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0x50, 0x34, 0x56,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_WMV1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x57, 0x4D, 0x56, 0x31,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_WMV2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x57, 0x4D, 0x56, 0x32,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_WMV3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x57, 0x4D, 0x56, 0x33,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_WVC1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x57, 0x56, 0x43, 0x31,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_MSS1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0x53, 0x53, 0x31,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_MSS2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0x53, 0x53, 0x32,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_MPG1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0x50, 0x47, 0x31,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_DVSL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x76, 0x73, 0x6C,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_DVSD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x76, 0x73, 0x64,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_DVHD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x76, 0x68, 0x64,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_DV25
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x76, 0x32, 0x35,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_DV50
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x76, 0x35, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_DVH1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x76, 0x68, 0x31,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_DVC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x76, 0x63, 0x20,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_H264
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0x32, 0x36, 0x34,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_H265
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0x32, 0x36, 0x35,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_MJPG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0x4A, 0x50, 0x47,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_420O
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x34, 0x32, 0x30, 0x4F,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_HEVC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0x45, 0x56, 0x43,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_HEVC_ES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0x45, 0x56, 0x53,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_VP80
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x56, 0x50, 0x38, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_VP90
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x56, 0x50, 0x39, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_ORAW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4F, 0x52, 0x41, 0x57,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_H263
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0x32, 0x36, 0x33,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_A2R10G10B10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1F, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_A16B16G16R16F
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x71, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_VP10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x56, 0x50, 0x31, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_AV1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0x56, 0x30, 0x31,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_Theora
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0x68, 0x65, 0x6F,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_H264_ES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF0, 0xF4, 0x40, 0x3F,
                    0x22, 0x56,
                    0xF8, 0x4F,
                    0xB6,
                    0xD8,
                    0xA1,
                    0x7A,
                    0x58,
                    0x4B,
                    0xEE,
                    0x5E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_MPEG2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0x80, 0x6D, 0xE0,
                    0x46, 0xDB,
                    0xCF, 0x11,
                    0xB4,
                    0xD1,
                    0x00,
                    0x80,
                    0x5F,
                    0x6C,
                    0xBB,
                    0xEA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Base
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_PCM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Float
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_DTS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x08, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Dolby_AC3_SPDIF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_DRM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x09, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_WMAudioV8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_WMAudioV9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_WMAudio_Lossless
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x63, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_WMASPDIF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x01, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_MSP1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0A, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_MP3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x55, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_MPEG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_AAC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0x16, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_ADTS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x16, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_AMR_NB
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x73, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_AMR_WB
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0x73, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_AMR_WP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x63, 0x73, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_FLAC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAC, 0xF1, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_ALAC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x6C, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Opus
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4F, 0x70, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Dolby_AC4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0xAC, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Dolby_AC3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2C, 0x80, 0x6D, 0xE0,
                    0x46, 0xDB,
                    0xCF, 0x11,
                    0xB4,
                    0xD1,
                    0x00,
                    0x80,
                    0x5F,
                    0x6C,
                    0xBB,
                    0xEA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Dolby_DDPlus
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAF, 0x87, 0xFB, 0xA7,
                    0x02, 0x2D,
                    0xFB, 0x42,
                    0xA4,
                    0xD4,
                    0x05,
                    0xCD,
                    0x93,
                    0x84,
                    0x3B,
                    0xDD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Dolby_AC4_V1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0x92, 0xB7, 0x36,
                    0x87, 0x3D,
                    0x2A, 0x4A,
                    0x91,
                    0x96,
                    0xA2,
                    0x1A,
                    0xD9,
                    0xE9,
                    0x35,
                    0xE6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Dolby_AC4_V2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0xB2, 0x98, 0x79,
                    0xDD, 0x17,
                    0xB6, 0x49,
                    0x8D,
                    0xFA,
                    0x9B,
                    0x27,
                    0x85,
                    0x52,
                    0xA2,
                    0xAC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Dolby_AC4_V1_ES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC6, 0xCC, 0x8D, 0x9D,
                    0x56, 0xD1,
                    0xB8, 0x4F,
                    0x97,
                    0x9C,
                    0xA8,
                    0x5B,
                    0xE7,
                    0xD2,
                    0x1D,
                    0xFA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Dolby_AC4_V2_ES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0xC9, 0x58, 0x7E,
                    0x70, 0xB0,
                    0xF4, 0x45,
                    0x8C,
                    0xCD,
                    0xA9,
                    0x9A,
                    0x04,
                    0x17,
                    0xC1,
                    0xAC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Vorbis
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0B, 0xD1, 0x2F, 0x8D,
                    0x41, 0x58,
                    0x6B, 0x4A,
                    0x89,
                    0x05,
                    0x58,
                    0x8F,
                    0xEC,
                    0x1A,
                    0xDE,
                    0xD9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_DTS_RAW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x33, 0x80, 0x6D, 0xE0,
                    0x46, 0xDB,
                    0xCF, 0x11,
                    0xB4,
                    0xD1,
                    0x00,
                    0x80,
                    0x5F,
                    0x6C,
                    0xBB,
                    0xEA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_DTS_HD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB7, 0x8E, 0xE5, 0xA2,
                    0xA9, 0x0F,
                    0xBB, 0x48,
                    0xA4,
                    0x0C,
                    0xFA,
                    0x0E,
                    0x15,
                    0x6D,
                    0x06,
                    0x45
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_DTS_XLL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1B, 0x7C, 0xB3, 0x45,
                    0x70, 0x8C,
                    0x59, 0x4E,
                    0xA7,
                    0xBE,
                    0xA1,
                    0xE4,
                    0x2C,
                    0x81,
                    0xC8,
                    0x0D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_DTS_LBR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0A, 0x6F, 0xFE, 0xC2,
                    0x3C, 0x4E,
                    0xF1, 0x4D,
                    0x9B,
                    0x60,
                    0x50,
                    0x86,
                    0x30,
                    0x91,
                    0xE4,
                    0xB9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_DTS_UHD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x17, 0x01, 0x02, 0x87,
                    0xE3, 0xAC,
                    0xDE, 0x42,
                    0xB7,
                    0x3E,
                    0xC6,
                    0x56,
                    0x70,
                    0x62,
                    0x63,
                    0xF8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_DTS_UHDY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0xCA, 0x9C, 0x9B,
                    0xB9, 0x91,
                    0xCC, 0x4C,
                    0x88,
                    0x3A,
                    0x8F,
                    0x78,
                    0x7A,
                    0xC3,
                    0xCC,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Float_SpatialObjects
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x94, 0xCD, 0x39, 0xFA,
                    0x64, 0xBC,
                    0xB1, 0x4A,
                    0x9B,
                    0x71,
                    0xDC,
                    0xD0,
                    0x9D,
                    0x5A,
                    0x7E,
                    0x7A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_LPCM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x32, 0x80, 0x6D, 0xE0,
                    0x46, 0xDB,
                    0xCF, 0x11,
                    0xB4,
                    0xD1,
                    0x00,
                    0x80,
                    0x5F,
                    0x6C,
                    0xBB,
                    0xEA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_PCM_HDCP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0xFF, 0xE7, 0xA5,
                    0x11, 0x84,
                    0xCC, 0x4A,
                    0xA8,
                    0x65,
                    0x5F,
                    0x49,
                    0x41,
                    0x28,
                    0x8D,
                    0x80
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Dolby_AC3_HDCP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x3A, 0x66, 0x97,
                    0xFB, 0x8F,
                    0x45, 0x44,
                    0xA6,
                    0xBA,
                    0x79,
                    0x2D,
                    0x90,
                    0x8F,
                    0x49,
                    0x7F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_AAC_HDCP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0xCE, 0x9B, 0x41,
                    0x72, 0x8B,
                    0x0F, 0x40,
                    0xAD,
                    0xEB,
                    0x84,
                    0xB5,
                    0x7D,
                    0x63,
                    0x48,
                    0x4D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_ADTS_HDCP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0x63, 0x49, 0xDA,
                    0xD8, 0x14,
                    0xCF, 0x4D,
                    0x92,
                    0xB7,
                    0x19,
                    0x3E,
                    0xB8,
                    0x43,
                    0x63,
                    0xDB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFAudioFormat_Base_HDCP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBC, 0xB5, 0x84, 0x38,
                    0x77, 0xE2,
                    0xFD, 0x43,
                    0x98,
                    0x3D,
                    0x03,
                    0x8A,
                    0xA8,
                    0xD9,
                    0xB6,
                    0x05
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_H264_HDCP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDD, 0xE9, 0x0C, 0x5D,
                    0x17, 0x98,
                    0xDA, 0x49,
                    0xBD,
                    0xFD,
                    0xF5,
                    0xF5,
                    0xB9,
                    0x8F,
                    0x18,
                    0xA6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_HEVC_HDCP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE6, 0x0F, 0xFE, 0x3C,
                    0xC4, 0x05,
                    0xDC, 0x47,
                    0x9D,
                    0x70,
                    0x4B,
                    0xDB,
                    0x29,
                    0x59,
                    0x72,
                    0x0F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFVideoFormat_Base_HDCP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD5, 0xB9, 0xC3, 0xEA,
                    0x14, 0xBD,
                    0x37, 0x42,
                    0x8F,
                    0x1F,
                    0xBA,
                    0xB4,
                    0x28,
                    0xE4,
                    0x93,
                    0x12
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMPEG4Format_Base
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x7A, 0x76,
                    0x4D, 0x49,
                    0xB4,
                    0x78,
                    0xF2,
                    0x9D,
                    0x25,
                    0xDC,
                    0x90,
                    0x37
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSubtitleFormat_XML
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4F, 0xF9, 0x06, 0x20,
                    0xCA, 0x29,
                    0x95, 0x41,
                    0xB8,
                    0xDB,
                    0x00,
                    0xDE,
                    0xD8,
                    0xFF,
                    0x0C,
                    0x97
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSubtitleFormat_TTML
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0x39, 0xE7, 0x73,
                    0x10, 0x9A,
                    0x56, 0x43,
                    0x95,
                    0x57,
                    0x71,
                    0x94,
                    0xE9,
                    0x1E,
                    0x3E,
                    0x54
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSubtitleFormat_ATSC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0xFA, 0xA7, 0x7F,
                    0xAE, 0xFE,
                    0x16, 0x4E,
                    0xAE,
                    0xDF,
                    0x36,
                    0xB9,
                    0xAC,
                    0xFB,
                    0xB0,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSubtitleFormat_WebVTT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x15, 0xD2, 0x86, 0xC8,
                    0x85, 0xF4,
                    0xBB, 0x40,
                    0x8D,
                    0xB6,
                    0xFA,
                    0xDB,
                    0xC6,
                    0x19,
                    0xA4,
                    0x5D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSubtitleFormat_SRT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2E, 0x7F, 0x46, 0x5E,
                    0xCA, 0x77,
                    0xA5, 0x4C,
                    0x83,
                    0x91,
                    0xD1,
                    0x42,
                    0xED,
                    0x4B,
                    0x76,
                    0xC8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSubtitleFormat_SSA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1B, 0x6A, 0x17, 0x57,
                    0x9E, 0x1A,
                    0xEA, 0x4E,
                    0xAB,
                    0xEF,
                    0xC6,
                    0x17,
                    0x60,
                    0x19,
                    0x8A,
                    0xC4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSubtitleFormat_CustomUserData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0xD8, 0xB3, 0x1B,
                    0x14, 0x66,
                    0x80, 0x4D,
                    0x88,
                    0x82,
                    0xED,
                    0x24,
                    0xAA,
                    0x82,
                    0xDA,
                    0x92
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSubtitleFormat_PGS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4A, 0x0E, 0xF4, 0x71,
                    0x78, 0x12,
                    0x42, 0x44,
                    0xB3,
                    0x0D,
                    0x39,
                    0xDD,
                    0x1D,
                    0x77,
                    0x22,
                    0xBC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSubtitleFormat_VobSub
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF4, 0x40, 0x8E, 0x6B,
                    0x2C, 0x8D,
                    0xED, 0x4C,
                    0xAD,
                    0x91,
                    0x59,
                    0x60,
                    0xE4,
                    0x5B,
                    0x44,
                    0x33
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFBinaryFormat_Base
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x10, 0xBF,
                    0xB4, 0x48,
                    0xBC,
                    0x18,
                    0x59,
                    0x3D,
                    0xC1,
                    0xDB,
                    0x95,
                    0x0F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFBinaryFormat_GPMD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x6D, 0x70, 0x67,
                    0x10, 0xBF,
                    0xB4, 0x48,
                    0xBC,
                    0x18,
                    0x59,
                    0x3D,
                    0xC1,
                    0xDB,
                    0x95,
                    0x0F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MAJOR_TYPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8E, 0xA1, 0xEB, 0x48,
                    0xC9, 0xF8,
                    0x87, 0x46,
                    0xBF,
                    0x11,
                    0x0A,
                    0x74,
                    0xC9,
                    0xF9,
                    0x6A,
                    0x8F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_SUBTYPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9A, 0x4C, 0xE3, 0xF7,
                    0xE8, 0x42,
                    0x14, 0x47,
                    0xB7,
                    0x4B,
                    0xCB,
                    0x29,
                    0xD7,
                    0x2C,
                    0x35,
                    0xE5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_ALL_SAMPLES_INDEPENDENT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0x37, 0x17, 0xC9,
                    0x56, 0x5E,
                    0x1C, 0x46,
                    0xB7,
                    0x13,
                    0x46,
                    0xFB,
                    0x99,
                    0x5C,
                    0xB9,
                    0x5F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_FIXED_SIZE_SAMPLES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAF, 0xEF, 0xEB, 0xB8,
                    0x18, 0xB7,
                    0x04, 0x4E,
                    0xB0,
                    0xA9,
                    0x11,
                    0x67,
                    0x75,
                    0xE3,
                    0x32,
                    0x1B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_COMPRESSED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0x0C, 0xFD, 0x3A,
                    0xF2, 0x18,
                    0xA5, 0x4B,
                    0xA1,
                    0x10,
                    0x8B,
                    0xEA,
                    0x50,
                    0x2E,
                    0x1F,
                    0x92
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_SAMPLE_SIZE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x78, 0xAB, 0xD3, 0xDA,
                    0x90, 0x19,
                    0x8B, 0x40,
                    0xBC,
                    0xE2,
                    0xEB,
                    0xA6,
                    0x73,
                    0xDA,
                    0xCC,
                    0x10
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_WRAPPED_TYPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x23, 0x7B, 0x3F, 0x4D,
                    0x2F, 0xD0,
                    0x6C, 0x4E,
                    0x9B,
                    0xEE,
                    0xE4,
                    0xBF,
                    0x2C,
                    0x6C,
                    0x69,
                    0x5D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_3D
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCF, 0x88, 0x5E, 0xCB,
                    0x5B, 0x7B,
                    0x6B, 0x47,
                    0x85,
                    0xAA,
                    0x1C,
                    0xA5,
                    0xAE,
                    0x18,
                    0x75,
                    0x55
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_3D_FORMAT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0xD8, 0x15, 0x53,
                    0xC5, 0x87,
                    0x97, 0x46,
                    0xB7,
                    0x93,
                    0x66,
                    0x06,
                    0xC6,
                    0x7C,
                    0x04,
                    0x9B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_3D_NUM_VIEWS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8A, 0x7E, 0x07, 0xBB,
                    0xBF, 0xDC,
                    0xEB, 0x42,
                    0xAF,
                    0x60,
                    0x41,
                    0x8D,
                    0xF9,
                    0x8A,
                    0xA4,
                    0x95
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_3D_LEFT_IS_BASE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFF, 0x7B, 0x4B, 0x6D,
                    0x29, 0x56,
                    0x04, 0x44,
                    0x94,
                    0x8C,
                    0xC6,
                    0x34,
                    0xF4,
                    0xCE,
                    0x26,
                    0xD4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_3D_FIRST_IS_LEFT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x93, 0x84, 0x29, 0xEC,
                    0xDA, 0x0A,
                    0xA1, 0x4E,
                    0xA4,
                    0xFE,
                    0xCB,
                    0xBD,
                    0x36,
                    0xCE,
                    0x93,
                    0x31
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_3DVideo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0x97, 0x6F, 0xF8,
                    0x54, 0xDD,
                    0x2E, 0x4E,
                    0x9A,
                    0x5E,
                    0x55,
                    0xFC,
                    0x2D,
                    0x74,
                    0xA0,
                    0x05
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_3DVideo_SampleFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0x17, 0x67, 0x08,
                    0x6F, 0xE3,
                    0xFF, 0x4C,
                    0x97,
                    0xB3,
                    0xD7,
                    0x2E,
                    0x20,
                    0x98,
                    0x7A,
                    0x48
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_ROTATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5D, 0x46, 0x80, 0xC3,
                    0x71, 0x22,
                    0x8C, 0x42,
                    0x9B,
                    0x83,
                    0xEC,
                    0xEA,
                    0x3B,
                    0x4A,
                    0x85,
                    0xC1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_DEVICESTREAM_MULTIPLEXED_MANAGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0x42, 0xA5, 0x6E,
                    0x1F, 0x28,
                    0x31, 0x42,
                    0xA4,
                    0x64,
                    0xFE,
                    0x2F,
                    0x50,
                    0x22,
                    0x50,
                    0x1C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MEDIATYPE_MULTIPLEXED_MANAGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB5, 0x8F, 0xC7, 0x13,
                    0x75, 0xF2,
                    0xA0, 0x4E,
                    0xBB,
                    0x5F,
                    0x02,
                    0x49,
                    0x83,
                    0x2B,
                    0x0D,
                    0x6E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_MULTIPLEXED_MANAGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x79, 0xEE, 0xCD, 0x8D,
                    0x5A, 0x6B,
                    0x45, 0x4C,
                    0x8D,
                    0xB9,
                    0x20,
                    0xB3,
                    0x95,
                    0xF0,
                    0x2F,
                    0xCF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMuxStreamAttributes(IMFCollection* pAttributesToMux, IMFAttributes** ppMuxAttribs);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMuxStreamMediaType(IMFCollection* pMediaTypesToMux, IMFMediaType** ppMuxMediaType);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMuxStreamSample(IMFCollection* pSamplesToMux, IMFSample** ppMuxSample);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_SECURE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFD, 0xC4, 0xAC, 0xC5,
                    0x04, 0x03,
                    0xCF, 0x4E,
                    0x80,
                    0x9F,
                    0x47,
                    0xBC,
                    0x97,
                    0xFF,
                    0x63,
                    0xBD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_DEVICESTREAM_ATTRIBUTE_FRAMESOURCE_TYPES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD1, 0x5F, 0x14, 0x17,
                    0x2B, 0x1B,
                    0x3C, 0x42,
                    0x80,
                    0x01,
                    0x2B,
                    0x68,
                    0x33,
                    0xED,
                    0x35,
                    0x88
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_ALPHA_MODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0D, 0x9B, 0x95, 0x5D,
                    0xBF, 0x4C,
                    0x04, 0x4D,
                    0x91,
                    0x9F,
                    0x3F,
                    0x5F,
                    0x7F,
                    0x28,
                    0x42,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_DEPTH_MEASUREMENT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x89, 0xC4, 0x5A, 0xFD,
                    0x17, 0x09,
                    0xB6, 0x4B,
                    0x9D,
                    0x54,
                    0x31,
                    0x22,
                    0xBF,
                    0x70,
                    0x14,
                    0x4B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_DEPTH_VALUE_UNIT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF5, 0x00, 0xA8, 0x21,
                    0x89, 0x31,
                    0x97, 0x47,
                    0xBE,
                    0xBA,
                    0xF1,
                    0x3C,
                    0xD9,
                    0xA3,
                    0x1A,
                    0x5E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_NO_FRAME_ORDERING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6F, 0x10, 0x5B, 0x3F,
                    0xC2, 0x6B,
                    0xE3, 0x4E,
                    0xB7,
                    0xED,
                    0x89,
                    0x02,
                    0xC1,
                    0x8F,
                    0x53,
                    0x51
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_H264_NO_FMOASO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD6, 0x1C, 0x46, 0xED,
                    0x9F, 0xEC,
                    0x6A, 0x41,
                    0xA8,
                    0xA3,
                    0x26,
                    0xD7,
                    0xD3,
                    0x10,
                    0x18,
                    0xD7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_ForwardedDecodeUnits
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4C, 0x75, 0x4C, 0x42,
                    0xC8, 0x97,
                    0xD6, 0x48,
                    0x87,
                    0x77,
                    0xFC,
                    0x41,
                    0xF7,
                    0xB6,
                    0x08,
                    0x79
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_TargetGlobalLuminance
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x36, 0xEF, 0x60, 0x3F,
                    0xEF, 0x31,
                    0xAF, 0x4D,
                    0x83,
                    0x60,
                    0x94,
                    0x03,
                    0x97,
                    0xE4,
                    0x1E,
                    0xF3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_ForwardedDecodeUnitType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC7, 0x57, 0x9E, 0x08,
                    0xD3, 0x47,
                    0x26, 0x4A,
                    0xBF,
                    0x9C,
                    0x4B,
                    0x64,
                    0xFA,
                    0xFB,
                    0x5D,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_FORWARD_CUSTOM_NALU
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFD, 0x6E, 0x33, 0xED,
                    0x4F, 0x24,
                    0x8D, 0x42,
                    0x91,
                    0x53,
                    0x28,
                    0xF3,
                    0x99,
                    0x45,
                    0x88,
                    0x90
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_FORWARD_CUSTOM_SEI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0x62, 0x73, 0xE2,
                    0x36, 0xB1,
                    0xD1, 0x41,
                    0x95,
                    0x94,
                    0x3A,
                    0x7E,
                    0x4F,
                    0xEB,
                    0xF2,
                    0xD1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_RENDERER_EXTENSION_PROFILE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB9, 0xD4, 0x37, 0x84,
                    0x48, 0xD4,
                    0xCD, 0x4F,
                    0x9B,
                    0x6B,
                    0x83,
                    0x9B,
                    0xF9,
                    0x6C,
                    0x77,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_DECODER_FWD_CUSTOM_SEI_DECODE_ORDER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3C, 0xBE, 0x3B, 0xF1,
                    0xD4, 0x36,
                    0x0A, 0x41,
                    0xB9,
                    0x85,
                    0x7A,
                    0x95,
                    0x1A,
                    0x1E,
                    0x62,
                    0x94
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_VIDEO_RENDERER_EFFECT_APP_SERVICE_NAME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x2A, 0x05, 0xC6,
                    0x9C, 0x6D,
                    0xA3, 0x40,
                    0x9D,
                    0xB8,
                    0xF0,
                    0x27,
                    0xA2,
                    0x5C,
                    0x9A,
                    0xB9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_NUM_CHANNELS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF5, 0x8B, 0xE4, 0x37,
                    0x5E, 0x64,
                    0x5B, 0x4C,
                    0x89,
                    0xDE,
                    0xAD,
                    0xA9,
                    0xE2,
                    0x9B,
                    0x69,
                    0x6A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_SAMPLES_PER_SECOND
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0xEA, 0xAE, 0x5F,
                    0x90, 0x02,
                    0x31, 0x4C,
                    0x9E,
                    0x8A,
                    0xC5,
                    0x34,
                    0xF6,
                    0x8D,
                    0x9D,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_FLOAT_SAMPLES_PER_SECOND
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4A, 0x72, 0x3B, 0xFB,
                    0xB5, 0xCF,
                    0x19, 0x43,
                    0xAE,
                    0xFE,
                    0x6E,
                    0x42,
                    0xB2,
                    0x40,
                    0x61,
                    0x32
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_AVG_BYTES_PER_SECOND
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC8, 0x75, 0xAB, 0x1A,
                    0xEF, 0xCF,
                    0x1C, 0x45,
                    0xAB,
                    0x95,
                    0xAC,
                    0x03,
                    0x4B,
                    0x8E,
                    0x17,
                    0x31
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_BLOCK_ALIGNMENT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0xE2, 0x2D, 0x32,
                    0xEB, 0x9E,
                    0xBD, 0x43,
                    0xAB,
                    0x7A,
                    0xFF,
                    0x41,
                    0x22,
                    0x51,
                    0x54,
                    0x1D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_BITS_PER_SAMPLE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7F, 0xB5, 0xDE, 0xF2,
                    0xFA, 0x40,
                    0x64, 0x47,
                    0xAA,
                    0x33,
                    0xED,
                    0x4F,
                    0x2D,
                    0x1F,
                    0xF6,
                    0x69
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_VALID_BITS_PER_SAMPLE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6A, 0x8D, 0xBF, 0xD9,
                    0x30, 0x95,
                    0x7C, 0x4B,
                    0x9D,
                    0xDF,
                    0xFF,
                    0x6F,
                    0xD5,
                    0x8B,
                    0xBD,
                    0x06
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_SAMPLES_PER_BLOCK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAC, 0x5A, 0xB1, 0xAA,
                    0x3A, 0xE1,
                    0x95, 0x49,
                    0x92,
                    0x22,
                    0x50,
                    0x1E,
                    0xA1,
                    0x5C,
                    0x68,
                    0x77
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_CHANNEL_MASK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x65, 0x57, 0xFB, 0x55,
                    0x4A, 0x64,
                    0xAF, 0x4C,
                    0x84,
                    0x79,
                    0x93,
                    0x89,
                    0x83,
                    0xBB,
                    0x15,
                    0x88
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_FOLDDOWN_MATRIX
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0x92, 0x62, 0x9D,
                    0xBE, 0x36,
                    0xF2, 0x4C,
                    0xB5,
                    0xC4,
                    0xA3,
                    0x92,
                    0x6E,
                    0x3E,
                    0x87,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_WMADRC_PEAKREF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7D, 0x92, 0x62, 0x9D,
                    0xBE, 0x36,
                    0xF2, 0x4C,
                    0xB5,
                    0xC4,
                    0xA3,
                    0x92,
                    0x6E,
                    0x3E,
                    0x87,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_WMADRC_PEAKTARGET
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7E, 0x92, 0x62, 0x9D,
                    0xBE, 0x36,
                    0xF2, 0x4C,
                    0xB5,
                    0xC4,
                    0xA3,
                    0x92,
                    0x6E,
                    0x3E,
                    0x87,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_WMADRC_AVGREF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7F, 0x92, 0x62, 0x9D,
                    0xBE, 0x36,
                    0xF2, 0x4C,
                    0xB5,
                    0xC4,
                    0xA3,
                    0x92,
                    0x6E,
                    0x3E,
                    0x87,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_WMADRC_AVGTARGET
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x92, 0x62, 0x9D,
                    0xBE, 0x36,
                    0xF2, 0x4C,
                    0xB5,
                    0xC4,
                    0xA3,
                    0x92,
                    0x6E,
                    0x3E,
                    0x87,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_PREFER_WAVEFORMATEX
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBA, 0xAA, 0x01, 0xA9,
                    0x37, 0xE0,
                    0x8A, 0x45,
                    0xBD,
                    0xF6,
                    0x54,
                    0x5B,
                    0xE2,
                    0x07,
                    0x40,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AAC_PAYLOAD_TYPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x79, 0xBE, 0xBA, 0xBF,
                    0x34, 0x74,
                    0x1C, 0x4D,
                    0x94,
                    0xF0,
                    0x72,
                    0xA3,
                    0xB9,
                    0xE1,
                    0x71,
                    0x88
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AAC_AUDIO_PROFILE_LEVEL_INDICATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE6, 0xF0, 0x32, 0x76,
                    0x38, 0x95,
                    0x61, 0x4D,
                    0xAC,
                    0xDA,
                    0xEA,
                    0x29,
                    0xC8,
                    0xC1,
                    0x44,
                    0x56
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AUDIO_FLAC_MAX_BLOCK_SIZE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAE, 0xAD, 0x81, 0x8B,
                    0x5A, 0x4B,
                    0x40, 0x4D,
                    0x80,
                    0x22,
                    0xF3,
                    0x8D,
                    0x09,
                    0xCA,
                    0x3C,
                    0x5C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_SPATIAL_AUDIO_MAX_DYNAMIC_OBJECTS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4A, 0xA2, 0xFB, 0xDC,
                    0x09, 0x26,
                    0x40, 0x42,
                    0xA7,
                    0x21,
                    0x3F,
                    0xAE,
                    0xA7,
                    0x6A,
                    0x4D,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_SPATIAL_AUDIO_OBJECT_METADATA_FORMAT_ID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0x1B, 0xB7, 0x2A,
                    0x23, 0x62,
                    0xA7, 0x4B,
                    0xAD,
                    0x64,
                    0x7B,
                    0x94,
                    0xB4,
                    0x7A,
                    0xE7,
                    0x92
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_SPATIAL_AUDIO_OBJECT_METADATA_LENGTH
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBE, 0xA8, 0x4B, 0x09,
                    0x23, 0xD7,
                    0x9F, 0x48,
                    0x92,
                    0xFA,
                    0x76,
                    0x67,
                    0x77,
                    0xB3,
                    0x47,
                    0x26
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_SPATIAL_AUDIO_MAX_METADATA_ITEMS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB4, 0x80, 0xAA, 0x11,
                    0xDA, 0xE0,
                    0xC6, 0x47,
                    0x80,
                    0x60,
                    0x96,
                    0xC1,
                    0x25,
                    0x9A,
                    0xE5,
                    0x0D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_SPATIAL_AUDIO_MIN_METADATA_ITEM_OFFSET_SPACING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC9, 0x6E, 0xE9, 0x83,
                    0x84, 0x11,
                    0x7E, 0x41,
                    0x82,
                    0x54,
                    0x9F,
                    0x26,
                    0x91,
                    0x58,
                    0xFC,
                    0x06
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_SPATIAL_AUDIO_DATA_PRESENT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0xF6, 0x42, 0x68,
                    0x3E, 0xD4,
                    0xBB, 0x4E,
                    0x9C,
                    0x9C,
                    0xC9,
                    0x6F,
                    0x41,
                    0x78,
                    0x48,
                    0x63
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_FRAME_SIZE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3D, 0xC3, 0x52, 0x16,
                    0xB2, 0xD6,
                    0x12, 0x40,
                    0xB8,
                    0x34,
                    0x72,
                    0x03,
                    0x08,
                    0x49,
                    0xA3,
                    0x7D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_FRAME_RATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE8, 0xA2, 0x59, 0xC4,
                    0x2C, 0x3D,
                    0x44, 0x4E,
                    0xB1,
                    0x32,
                    0xFE,
                    0xE5,
                    0x15,
                    0x6C,
                    0x7B,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_PIXEL_ASPECT_RATIO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1E, 0x6A, 0x37, 0xC6,
                    0x0A, 0x8D,
                    0x27, 0x40,
                    0xBE,
                    0x45,
                    0x6D,
                    0x9A,
                    0x0A,
                    0xD3,
                    0x9B,
                    0xB6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_DRM_FLAGS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x23, 0xF3, 0x72, 0x87,
                    0x5A, 0x35,
                    0xC7, 0x4C,
                    0xBB,
                    0x78,
                    0x6D,
                    0x61,
                    0xA0,
                    0x48,
                    0xAE,
                    0x82
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_TIMESTAMP_CAN_BE_DTS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x15, 0x42, 0x97, 0x24,
                    0x7B, 0x1B,
                    0xE4, 0x41,
                    0x86,
                    0x25,
                    0xAC,
                    0x46,
                    0x9F,
                    0x2D,
                    0xED,
                    0xAA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_PAD_CONTROL_FLAGS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE5, 0x73, 0x0E, 0x4D,
                    0xEA, 0x80,
                    0x54, 0x43,
                    0xA9,
                    0xD0,
                    0x11,
                    0x76,
                    0xCE,
                    0xB0,
                    0x28,
                    0xEA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_SOURCE_CONTENT_HINT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCC, 0xA3, 0xAC, 0x68,
                    0xD0, 0x22,
                    0xE6, 0x44,
                    0x85,
                    0xF8,
                    0x28,
                    0x16,
                    0x71,
                    0x97,
                    0xFA,
                    0x38
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_CHROMA_SITING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x70, 0x23, 0xDF, 0x65,
                    0x73, 0xC7,
                    0x33, 0x4C,
                    0xAA,
                    0x64,
                    0x84,
                    0x3E,
                    0x06,
                    0x8E,
                    0xFB,
                    0x0C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_INTERLACE_MODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB8, 0x4B, 0x72, 0xE2,
                    0x76, 0xE6,
                    0x06, 0x48,
                    0xB4,
                    0xB2,
                    0xA8,
                    0xD6,
                    0xEF,
                    0xB4,
                    0x4C,
                    0xCD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_TRANSFER_FUNCTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE9, 0xFC, 0xB0, 0x5F,
                    0x5C, 0xBE,
                    0x35, 0x49,
                    0xA8,
                    0x11,
                    0xEC,
                    0x83,
                    0x8F,
                    0x8E,
                    0xED,
                    0x93
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_PRIMARIES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD7, 0xE4, 0xFB, 0xDB,
                    0x40, 0x07,
                    0xE0, 0x4E,
                    0x81,
                    0x92,
                    0x85,
                    0x0A,
                    0xB0,
                    0xE2,
                    0x19,
                    0x35
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MAX_LUMINANCE_LEVEL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0x31, 0x25, 0x50,
                    0x10, 0xC1,
                    0xE4, 0x4D,
                    0x98,
                    0xAE,
                    0x46,
                    0xA3,
                    0x24,
                    0xFA,
                    0xE6,
                    0xDA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MAX_FRAME_AVERAGE_LUMINANCE_LEVEL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x57, 0xBF, 0xD4, 0x58,
                    0x52, 0x6F,
                    0x33, 0x47,
                    0xA1,
                    0x95,
                    0xA9,
                    0xE2,
                    0x9E,
                    0xCF,
                    0x9E,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MAX_MASTERING_LUMINANCE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x97, 0xB9, 0xC6, 0xD6,
                    0x2F, 0x27,
                    0xA1, 0x4C,
                    0x8D,
                    0x00,
                    0x80,
                    0x42,
                    0x11,
                    0x1A,
                    0x0F,
                    0xF6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MIN_MASTERING_LUMINANCE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0x44, 0x9A, 0x83,
                    0x7E, 0x4E,
                    0x4F, 0x4B,
                    0xAE,
                    0x79,
                    0xCC,
                    0x08,
                    0x90,
                    0x5C,
                    0x7B,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_DECODER_USE_MAX_RESOLUTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0x7C, 0x54, 0x4C,
                    0x9A, 0xAF,
                    0x38, 0x4F,
                    0x96,
                    0xAD,
                    0x97,
                    0x87,
                    0x73,
                    0xCF,
                    0x53,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_DECODER_MAX_DPB_COUNT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4C, 0x14, 0xBE, 0x67,
                    0xB7, 0x88,
                    0xA9, 0x4C,
                    0x96,
                    0x28,
                    0xC8,
                    0x08,
                    0xD5,
                    0x26,
                    0x22,
                    0x17
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_CUSTOM_VIDEO_PRIMARIES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x13, 0x72, 0x53, 0x47,
                    0xFB, 0x8C,
                    0x22, 0x47,
                    0xAA,
                    0x34,
                    0xFB,
                    0xC9,
                    0xE2,
                    0x4D,
                    0x77,
                    0xB8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_YUV_MATRIX
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0xD4, 0x23, 0x3E,
                    0x75, 0x2C,
                    0x25, 0x4D,
                    0xA0,
                    0x0E,
                    0xB9,
                    0x16,
                    0x70,
                    0xD1,
                    0x23,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_LIGHTING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9C, 0x52, 0xA0, 0x53,
                    0x0B, 0x89,
                    0x16, 0x42,
                    0x8B,
                    0xF9,
                    0x59,
                    0x93,
                    0x67,
                    0xAD,
                    0x6D,
                    0x20
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_NOMINAL_RANGE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE5, 0x8E, 0x1B, 0xC2,
                    0x56, 0xB9,
                    0x71, 0x40,
                    0x8D,
                    0xAF,
                    0x32,
                    0x5E,
                    0xDF,
                    0x5C,
                    0xAB,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_GEOMETRIC_APERTURE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x43, 0x87, 0x75, 0x66,
                    0x5F, 0x7E,
                    0x0D, 0x40,
                    0x98,
                    0x0A,
                    0xAA,
                    0x85,
                    0x96,
                    0xC8,
                    0x56,
                    0x96
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MINIMUM_DISPLAY_APERTURE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0x87, 0x38, 0xD7,
                    0xFE, 0x18,
                    0xC6, 0x48,
                    0xA1,
                    0x77,
                    0xEE,
                    0x89,
                    0x48,
                    0x67,
                    0xC8,
                    0xC4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_PAN_SCAN_APERTURE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDE, 0x4D, 0x61, 0x79,
                    0x87, 0x91,
                    0xFB, 0x48,
                    0xB8,
                    0xC7,
                    0x4D,
                    0x52,
                    0x68,
                    0x9D,
                    0xE6,
                    0x49
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_PAN_SCAN_ENABLED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC3, 0x6B, 0x7F, 0x4B,
                    0x13, 0x8B,
                    0xB2, 0x40,
                    0xA9,
                    0x93,
                    0xAB,
                    0xF6,
                    0x30,
                    0xB8,
                    0x20,
                    0x4E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AVG_BITRATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0x26, 0x33, 0x20,
                    0x0D, 0xFB,
                    0x9E, 0x4D,
                    0xBD,
                    0x0D,
                    0xCB,
                    0xF6,
                    0x78,
                    0x6C,
                    0x10,
                    0x2E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AVG_BIT_ERROR_RATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD6, 0xAB, 0x9C, 0x79,
                    0x08, 0x35,
                    0xB4, 0x4D,
                    0xA3,
                    0xC7,
                    0x56,
                    0x9C,
                    0xD5,
                    0x33,
                    0xDE,
                    0xB1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MAX_KEYFRAME_SPACING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0xB5, 0x6E, 0xC1,
                    0xA1, 0x73,
                    0x6F, 0x47,
                    0x8D,
                    0x62,
                    0x83,
                    0x9D,
                    0x6A,
                    0x02,
                    0x06,
                    0x52
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_USER_DATA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5F, 0x76, 0xBC, 0xB6,
                    0x3B, 0x4C,
                    0xA4, 0x40,
                    0xBD,
                    0x51,
                    0x25,
                    0x35,
                    0xB6,
                    0x6F,
                    0xE0,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_OUTPUT_BUFFER_NUM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAC, 0xD3, 0x05, 0xA5,
                    0x30, 0xF9,
                    0x6E, 0x43,
                    0x8E,
                    0xDE,
                    0x93,
                    0xA5,
                    0x09,
                    0xCE,
                    0x23,
                    0xB2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_REALTIME_CONTENT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0xD2, 0x12, 0xBB,
                    0xDB, 0x2B,
                    0x5E, 0x42,
                    0x91,
                    0xEC,
                    0x23,
                    0x08,
                    0xE1,
                    0x89,
                    0xA5,
                    0x8F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_DEFAULT_STRIDE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0x4E, 0x4B, 0x64,
                    0x02, 0x1E,
                    0x16, 0x45,
                    0xB0,
                    0xEB,
                    0xC0,
                    0x1C,
                    0xA9,
                    0xD4,
                    0x9A,
                    0xC6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_PALETTE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x42, 0x3F, 0x28, 0x6D,
                    0x46, 0x98,
                    0x10, 0x44,
                    0xAF,
                    0xD9,
                    0x65,
                    0x4D,
                    0x50,
                    0x3B,
                    0x1A,
                    0x54
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_AM_FORMAT_TYPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2D, 0x07, 0xD1, 0x73,
                    0x70, 0x18,
                    0x74, 0x41,
                    0xA0,
                    0x63,
                    0x29,
                    0xFF,
                    0x4F,
                    0xF6,
                    0xC1,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_PROFILE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0B, 0xA8, 0x76, 0xAD,
                    0x5C, 0x2D,
                    0x0B, 0x4E,
                    0xB3,
                    0x75,
                    0x64,
                    0xE5,
                    0x20,
                    0x13,
                    0x70,
                    0x36
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_VIDEO_LEVEL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0x65, 0xF6, 0x96,
                    0xC5, 0x11,
                    0x15, 0x40,
                    0x86,
                    0x66,
                    0xBF,
                    0xF5,
                    0x16,
                    0x43,
                    0x6D,
                    0xA7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MPEG_START_TIME_CODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0x78, 0xF6, 0x91,
                    0x33, 0x43,
                    0x80, 0x42,
                    0x97,
                    0xCD,
                    0xBD,
                    0x5A,
                    0x6C,
                    0x03,
                    0xA0,
                    0x6E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MPEG2_PROFILE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0B, 0xA8, 0x76, 0xAD,
                    0x5C, 0x2D,
                    0x0B, 0x4E,
                    0xB3,
                    0x75,
                    0x64,
                    0xE5,
                    0x20,
                    0x13,
                    0x70,
                    0x36
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MPEG2_LEVEL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0x65, 0xF6, 0x96,
                    0xC5, 0x11,
                    0x15, 0x40,
                    0x86,
                    0x66,
                    0xBF,
                    0xF5,
                    0x16,
                    0x43,
                    0x6D,
                    0xA7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MPEG2_FLAGS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1D, 0x99, 0xE3, 0x31,
                    0x01, 0xF7,
                    0x2F, 0x4B,
                    0xB4,
                    0x26,
                    0x8A,
                    0xE3,
                    0xBD,
                    0xA9,
                    0xE0,
                    0x4B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MPEG_SEQUENCE_HEADER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0x6D, 0x03, 0x3C,
                    0xD0, 0x3A,
                    0x9E, 0x4C,
                    0x92,
                    0x16,
                    0xEE,
                    0x6D,
                    0x6A,
                    0xC2,
                    0x1C,
                    0xB3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MPEG2_STANDARD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE8, 0xF9, 0x0A, 0xA2,
                    0x8A, 0x92,
                    0x26, 0x4B,
                    0xAA,
                    0xA9,
                    0xF0,
                    0x5C,
                    0x74,
                    0xCA,
                    0xC4,
                    0x7C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MPEG2_TIMECODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0xBA, 0x29, 0x52,
                    0x9D, 0xE2,
                    0x80, 0x4F,
                    0xA5,
                    0x9C,
                    0xDF,
                    0x4F,
                    0x18,
                    0x02,
                    0x07,
                    0xD2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MPEG2_CONTENT_PACKET
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE4, 0x55, 0x5D, 0x82,
                    0x12, 0x4F,
                    0x97, 0x41,
                    0x9E,
                    0xB3,
                    0x59,
                    0xB6,
                    0xE4,
                    0x71,
                    0x0F,
                    0x06
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MPEG2_ONE_FRAME_PER_PACKET
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB5, 0x9E, 0xA4, 0x91,
                    0x20, 0x1D,
                    0x42, 0x4B,
                    0xAC,
                    0xE8,
                    0x80,
                    0x42,
                    0x69,
                    0xBF,
                    0x95,
                    0xED
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MPEG2_HDCP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4A, 0x1B, 0x8F, 0x16,
                    0x91, 0x3E,
                    0x0F, 0x45,
                    0xAE,
                    0xA7,
                    0xE4,
                    0xBA,
                    0xEA,
                    0xDA,
                    0xE5,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_H264_MAX_CODEC_CONFIG_DELAY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x86, 0x99, 0x92, 0xF5,
                    0x45, 0x4C,
                    0xBB, 0x4F,
                    0xBB,
                    0x49,
                    0x6C,
                    0xC5,
                    0x34,
                    0xD0,
                    0x5B,
                    0x9B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_H264_SUPPORTED_SLICE_MODES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0x19, 0xBE, 0xC8,
                    0x64, 0x4D,
                    0x49, 0x45,
                    0x83,
                    0x43,
                    0xA8,
                    0x08,
                    0x6C,
                    0x0B,
                    0xFD,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_H264_SUPPORTED_SYNC_FRAME_TYPES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0x2C, 0xA5, 0x89,
                    0x82, 0xF2,
                    0xD2, 0x48,
                    0xB5,
                    0x22,
                    0x22,
                    0xE6,
                    0xAE,
                    0x63,
                    0x31,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_H264_RESOLUTION_SCALING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0x42, 0x85, 0xE3,
                    0x15, 0xF7,
                    0x57, 0x47,
                    0xBA,
                    0x90,
                    0x1B,
                    0x69,
                    0x6C,
                    0x77,
                    0x34,
                    0x57
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_H264_SIMULCAST_SUPPORT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3D, 0xD6, 0xA2, 0x9E,
                    0xF0, 0x53,
                    0x34, 0x4A,
                    0xB9,
                    0x4E,
                    0x9D,
                    0xE4,
                    0x9A,
                    0x07,
                    0x8C,
                    0xB3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_H264_SUPPORTED_RATE_CONTROL_MODES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7E, 0xC4, 0x8A, 0x6A,
                    0x9C, 0x51,
                    0x18, 0x4F,
                    0x9B,
                    0xB3,
                    0x7E,
                    0xEA,
                    0xAE,
                    0xA5,
                    0x59,
                    0x4D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_H264_MAX_MB_PER_SEC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x6D, 0x25, 0x45,
                    0x15, 0x72,
                    0x76, 0x45,
                    0x93,
                    0x36,
                    0xB0,
                    0xF1,
                    0xBC,
                    0xD5,
                    0x9B,
                    0xB2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_H264_SUPPORTED_USAGES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x98, 0xA9, 0xB1, 0x60,
                    0x01, 0xDC,
                    0xCE, 0x40,
                    0x97,
                    0x36,
                    0xAB,
                    0xA8,
                    0x45,
                    0xA2,
                    0xDB,
                    0xDC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_H264_CAPABILITIES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x08, 0xD5, 0x3B, 0xBB,
                    0x0A, 0x49,
                    0xE0, 0x11,
                    0x99,
                    0xE4,
                    0x13,
                    0x16,
                    0xDF,
                    0xD7,
                    0x20,
                    0x85
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_H264_SVC_CAPABILITIES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBE, 0x3A, 0x99, 0xF8,
                    0x37, 0xD9,
                    0x8F, 0x4A,
                    0xBB,
                    0xCA,
                    0x69,
                    0x66,
                    0xFE,
                    0x9E,
                    0x11,
                    0x52
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_H264_USAGE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA5, 0xE3, 0x9C, 0x35,
                    0x00, 0xAF,
                    0xCA, 0x49,
                    0xA2,
                    0xF4,
                    0x2A,
                    0xC9,
                    0x4C,
                    0xA8,
                    0x2B,
                    0x61
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_H264_RATE_CONTROL_MODES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0x77, 0x51, 0x70,
                    0xCB, 0x45,
                    0xE0, 0x11,
                    0xAC,
                    0x7D,
                    0xB9,
                    0x1C,
                    0xE0,
                    0xD7,
                    0x20,
                    0x85
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_H264_LAYOUT_PER_STREAM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB2, 0x99, 0xE2, 0x85,
                    0xE3, 0x90,
                    0xE8, 0x4F,
                    0xB2,
                    0xF5,
                    0xC0,
                    0x67,
                    0xE0,
                    0xBF,
                    0xE5,
                    0x7A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_IN_BAND_PARAMETER_SET
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0x50, 0xDA, 0x75,
                    0x0B, 0x91,
                    0x03, 0x4A,
                    0x89,
                    0x6C,
                    0x7B,
                    0x89,
                    0x8F,
                    0xEE,
                    0xA5,
                    0xAF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MPEG4_TRACK_TYPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDD, 0x86, 0xF4, 0x54,
                    0x27, 0x93,
                    0x6D, 0x4F,
                    0x80,
                    0xAB,
                    0x6F,
                    0x70,
                    0x9E,
                    0xBB,
                    0x4C,
                    0xCE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_CONTAINER_RATE_SCALING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5E, 0x7F, 0x87, 0x83,
                    0x44, 0x04,
                    0x28, 0x4E,
                    0x84,
                    0x79,
                    0x6D,
                    0xB0,
                    0x98,
                    0x9B,
                    0x8C,
                    0x09
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_DV_AAUX_SRC_PACK_0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x88, 0x5D, 0xBD, 0x84,
                    0xB8, 0x0F,
                    0xC8, 0x4A,
                    0xBE,
                    0x4B,
                    0xA8,
                    0x84,
                    0x8B,
                    0xEF,
                    0x98,
                    0xF3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_DV_AAUX_CTRL_PACK_0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4E, 0x00, 0x31, 0xF7,
                    0xD1, 0x1D,
                    0x15, 0x45,
                    0xAA,
                    0xBE,
                    0xF0,
                    0xC0,
                    0x6A,
                    0xA5,
                    0x36,
                    0xAC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_DV_AAUX_SRC_PACK_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0x65, 0x0E, 0x72,
                    0x25, 0x02,
                    0x03, 0x40,
                    0xA6,
                    0x51,
                    0x01,
                    0x96,
                    0x56,
                    0x3A,
                    0x95,
                    0x8E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_DV_AAUX_CTRL_PACK_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0D, 0x47, 0x1F, 0xCD,
                    0x04, 0x1F,
                    0xE0, 0x4F,
                    0xBF,
                    0xB9,
                    0xD0,
                    0x7A,
                    0xE0,
                    0x38,
                    0x6A,
                    0xD8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_DV_VAUX_SRC_PACK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9D, 0x2D, 0x40, 0x41,
                    0x57, 0x7B,
                    0xC6, 0x43,
                    0xB1,
                    0x29,
                    0x2C,
                    0xB9,
                    0x97,
                    0xF1,
                    0x50,
                    0x09
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_DV_VAUX_CTRL_PACK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC4, 0xE1, 0x84, 0x2F,
                    0xA1, 0x0D,
                    0x88, 0x47,
                    0x93,
                    0x8E,
                    0x0D,
                    0xFB,
                    0xFB,
                    0xB3,
                    0x4B,
                    0x48
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_ARBITRARY_HEADER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF5, 0xD6, 0x6B, 0x9E,
                    0x09, 0x01,
                    0x95, 0x4F,
                    0x84,
                    0xAC,
                    0x93,
                    0x09,
                    0x15,
                    0x3A,
                    0x19,
                    0xFC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_ARBITRARY_FORMAT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0xB2, 0x75, 0x5A,
                    0x7D, 0x0D,
                    0xA1, 0x49,
                    0xA1,
                    0xC3,
                    0xE0,
                    0xD8,
                    0x7F,
                    0x0C,
                    0xAD,
                    0xE5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_IMAGE_LOSS_TOLERANT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF4, 0x2C, 0x06, 0xED,
                    0x4E, 0xE3,
                    0x22, 0x49,
                    0xBE,
                    0x99,
                    0x93,
                    0x40,
                    0x32,
                    0x13,
                    0x3D,
                    0x7C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MPEG4_SAMPLE_DESCRIPTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0x9D, 0x1E, 0x26,
                    0x29, 0x95,
                    0x8F, 0x4B,
                    0xA1,
                    0x11,
                    0x8B,
                    0x9C,
                    0x95,
                    0x0A,
                    0x81,
                    0xA9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_MPEG4_CURRENT_SAMPLE_ENTRY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x55, 0xE1, 0xA7, 0x9A,
                    0x4A, 0xB6,
                    0x1D, 0x4C,
                    0xA5,
                    0x00,
                    0x45,
                    0x5D,
                    0x60,
                    0x0B,
                    0x65,
                    0x60
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_SD_AMBISONICS_SAMPLE3D_DESCRIPTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3E, 0xCF, 0x15, 0xF7,
                    0x64, 0xA9,
                    0x3F, 0x4C,
                    0x94,
                    0xAE,
                    0x9D,
                    0x6B,
                    0xA7,
                    0x26,
                    0x46,
                    0x41
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_ORIGINAL_4CC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0x3F, 0xBE, 0xD7,
                    0xC7, 0x2B,
                    0x2D, 0x49,
                    0xB8,
                    0x43,
                    0x61,
                    0xA1,
                    0x91,
                    0x9B,
                    0x70,
                    0xC3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_ORIGINAL_WAVE_FORMAT_TAG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x43, 0xC8, 0xBB, 0x8C,
                    0xD9, 0x9F,
                    0xC2, 0x49,
                    0x88,
                    0x2F,
                    0xA7,
                    0x25,
                    0x86,
                    0xC4,
                    0x08,
                    0xAD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_FRAME_RATE_RANGE_MIN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8C, 0x55, 0xE7, 0xD2,
                    0x1F, 0xDC,
                    0x3F, 0x40,
                    0x9A,
                    0x72,
                    0xD2,
                    0x8B,
                    0xB1,
                    0xEB,
                    0x3B,
                    0x5E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MT_FRAME_RATE_RANGE_MAX
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0x1D, 0x37, 0xE3,
                    0xCF, 0xB4,
                    0x05, 0x4A,
                    0xBD,
                    0x4E,
                    0x20,
                    0xB8,
                    0x8B,
                    0xB2,
                    0xC4,
                    0xD6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_LOW_LATENCY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1A, 0x89, 0x27, 0x9C,
                    0x7A, 0xED,
                    0xE1, 0x40,
                    0x88,
                    0xE8,
                    0xB2,
                    0x27,
                    0x27,
                    0xA0,
                    0x24,
                    0xEE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_VIDEO_MAX_MB_PER_SEC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0xE2, 0xF2, 0xE3,
                    0x45, 0xD4,
                    0x8C, 0x4B,
                    0x92,
                    0x11,
                    0xAE,
                    0x39,
                    0x0D,
                    0x3B,
                    0xA0,
                    0x17
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_DISABLE_FRAME_CORRUPTION_INFO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6C, 0xE1, 0x86, 0x70,
                    0xC5, 0x49,
                    0x01, 0x42,
                    0x88,
                    0x2A,
                    0x85,
                    0x38,
                    0xF3,
                    0x8C,
                    0xF1,
                    0x3A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFStreamExtension_CameraExtrinsics
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0x96, 0x61, 0x68,
                    0xE2, 0x13,
                    0xD9, 0x41,
                    0x96,
                    0x38,
                    0xEF,
                    0x03,
                    0x2C,
                    0x27,
                    0x2A,
                    0x52
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_CameraExtrinsics
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x58, 0x16, 0x76, 0x6B,
                    0xEC, 0xB7,
                    0x3B, 0x4C,
                    0x82,
                    0x25,
                    0x86,
                    0x23,
                    0xCA,
                    0xBE,
                    0xC3,
                    0x1D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFStreamExtension_PinholeCameraIntrinsics
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x55, 0x04, 0xAC, 0xDB,
                    0xC8, 0x0E,
                    0xEF, 0x4A,
                    0x9C,
                    0x32,
                    0x7A,
                    0x3E,
                    0xE3,
                    0x45,
                    0x6F,
                    0x53
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_PinholeCameraIntrinsics
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC5, 0xB6, 0xE3, 0x4E,
                    0x15, 0x6A,
                    0x72, 0x4E,
                    0x97,
                    0x61,
                    0x70,
                    0xC1,
                    0xDB,
                    0x8B,
                    0x9F,
                    0xE3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_Default
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE6, 0x12, 0xA4, 0x81,
                    0x03, 0x81,
                    0x06, 0x4B,
                    0x85,
                    0x7F,
                    0x18,
                    0x62,
                    0x78,
                    0x10,
                    0x24,
                    0xAC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_Audio
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x75, 0x64, 0x73,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_Video
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0x69, 0x64, 0x73,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_Protected
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE6, 0x6F, 0x4B, 0x7B,
                    0x04, 0x9D,
                    0x94, 0x44,
                    0xBE,
                    0x14,
                    0x7E,
                    0x0B,
                    0xD0,
                    0x76,
                    0xC8,
                    0xE4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_SAMI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x69, 0x96, 0xE6,
                    0xCD, 0x3D,
                    0xCB, 0x40,
                    0x9E,
                    0x2E,
                    0x37,
                    0x08,
                    0x38,
                    0x7C,
                    0x06,
                    0x16
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_Script
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0x8C, 0x17, 0x72,
                    0x5B, 0xE4,
                    0xD5, 0x11,
                    0xBC,
                    0x2A,
                    0x00,
                    0xB0,
                    0xD0,
                    0xF3,
                    0xF4,
                    0xAB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_Image
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x23, 0x8C, 0x17, 0x72,
                    0x5B, 0xE4,
                    0xD5, 0x11,
                    0xBC,
                    0x2A,
                    0x00,
                    0xB0,
                    0xD0,
                    0xF3,
                    0xF4,
                    0xAB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_HTML
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0x8C, 0x17, 0x72,
                    0x5B, 0xE4,
                    0xD5, 0x11,
                    0xBC,
                    0x2A,
                    0x00,
                    0xB0,
                    0xD0,
                    0xF3,
                    0xF4,
                    0xAB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_Binary
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x25, 0x8C, 0x17, 0x72,
                    0x5B, 0xE4,
                    0xD5, 0x11,
                    0xBC,
                    0x2A,
                    0x00,
                    0xB0,
                    0xD0,
                    0xF3,
                    0xF4,
                    0xAB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_FileTransfer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0x8C, 0x17, 0x72,
                    0x5B, 0xE4,
                    0xD5, 0x11,
                    0xBC,
                    0x2A,
                    0x00,
                    0xB0,
                    0xD0,
                    0xF3,
                    0xF4,
                    0xAB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_Stream
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_MultiplexedFrames
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0x42, 0xA5, 0x6E,
                    0x1F, 0x28,
                    0x31, 0x42,
                    0xA4,
                    0x64,
                    0xFE,
                    0x2F,
                    0x50,
                    0x22,
                    0x50,
                    0x1C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_Subtitle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0x35, 0xD1, 0xA6,
                    0x50, 0xED,
                    0x65, 0x4E,
                    0xAE,
                    0x08,
                    0x26,
                    0x06,
                    0x55,
                    0x76,
                    0xAA,
                    0xCC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_Perception
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0xF6, 0x7F, 0x59,
                    0xA2, 0x6E,
                    0x70, 0x46,
                    0x85,
                    0xB4,
                    0xEA,
                    0x84,
                    0x07,
                    0x3F,
                    0xE9,
                    0x40
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFImageFormat_JPEG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAA, 0xA5, 0xE4, 0x19,
                    0x62, 0x56,
                    0xC5, 0x4F,
                    0xA0,
                    0xC0,
                    0x17,
                    0x58,
                    0x02,
                    0x8E,
                    0x10,
                    0x57
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFImageFormat_RGB32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFStreamFormat_MPEG2Transport
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x23, 0x80, 0x6D, 0xE0,
                    0x46, 0xDB,
                    0xCF, 0x11,
                    0xB4,
                    0xD1,
                    0x00,
                    0x80,
                    0x5F,
                    0x6C,
                    0xBB,
                    0xEA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFStreamFormat_MPEG2Program
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD1, 0x67, 0x30, 0x26,
                    0x30, 0xD3,
                    0xDC, 0x45,
                    0xB6,
                    0x69,
                    0x34,
                    0xD9,
                    0x86,
                    0xE4,
                    0xE3,
                    0xE1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid AM_MEDIA_TYPE_REPRESENTATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD2, 0x2A, 0xE4, 0xE2,
                    0x2C, 0x13,
                    0x1E, 0x49,
                    0xA2,
                    0x68,
                    0x3C,
                    0x7C,
                    0x2D,
                    0xCA,
                    0x18,
                    0x1F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FORMAT_MFVideoFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2D, 0xAB, 0xD4, 0xAE,
                    0x26, 0x73,
                    0xCB, 0x43,
                    0x94,
                    0x64,
                    0xC8,
                    0x79,
                    0xCA,
                    0xB9,
                    0xC4,
                    0x3D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFMediaType_Metadata
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0C, 0xA2, 0x8F, 0x2C,
                    0xBB, 0x82,
                    0x82, 0x47,
                    0x90,
                    0xA0,
                    0x98,
                    0xA2,
                    0xA5,
                    0xBD,
                    0x8E,
                    0xF8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFValidateMediaTypeSize([NativeTypeName("GUID")] Guid FormatType, [NativeTypeName("UINT8 *")] byte* pBlock, [NativeTypeName("UINT32")] uint cbSize);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaType(IMFMediaType** ppMFType);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMFVideoFormatFromMFMediaType(IMFMediaType* pMFType, MFVIDEOFORMAT** ppMFVF, [NativeTypeName("UINT32 *")] uint* pcbSize);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateWaveFormatExFromMFMediaType(IMFMediaType* pMFType, WAVEFORMATEX** ppWF, [NativeTypeName("UINT32 *")] uint* pcbSize, [NativeTypeName("UINT32")] uint Flags = (uint)(MFWaveFormatExConvertFlag_Normal));

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromVideoInfoHeader(IMFMediaType* pMFType, [NativeTypeName("const VIDEOINFOHEADER *")] VIDEOINFOHEADER* pVIH, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("const GUID *")] Guid* pSubtype = null);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromVideoInfoHeader2(IMFMediaType* pMFType, [NativeTypeName("const VIDEOINFOHEADER2 *")] VIDEOINFOHEADER2* pVIH2, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("const GUID *")] Guid* pSubtype = null);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromMPEG1VideoInfo(IMFMediaType* pMFType, [NativeTypeName("const MPEG1VIDEOINFO *")] MPEG1VIDEOINFO* pMP1VI, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("const GUID *")] Guid* pSubtype = null);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromMPEG2VideoInfo(IMFMediaType* pMFType, [NativeTypeName("const MPEG2VIDEOINFO *")] MPEG2VIDEOINFO* pMP2VI, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("const GUID *")] Guid* pSubtype = null);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCalculateBitmapImageSize([NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pBMIH, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbImageSize, [NativeTypeName("BOOL *")] int* pbKnown = null);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCalculateImageSize([NativeTypeName("const GUID &")] Guid* guidSubtype, [NativeTypeName("UINT32")] uint unWidth, [NativeTypeName("UINT32")] uint unHeight, [NativeTypeName("UINT32 *")] uint* pcbImageSize);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFFrameRateToAverageTimePerFrame([NativeTypeName("UINT32")] uint unNumerator, [NativeTypeName("UINT32")] uint unDenominator, [NativeTypeName("UINT64 *")] ulong* punAverageTimePerFrame);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFAverageTimePerFrameToFrameRate([NativeTypeName("UINT64")] ulong unAverageTimePerFrame, [NativeTypeName("UINT32 *")] uint* punNumerator, [NativeTypeName("UINT32 *")] uint* punDenominator);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromMFVideoFormat(IMFMediaType* pMFType, [NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pMFVF, [NativeTypeName("UINT32")] uint cbBufSize);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromWaveFormatEx(IMFMediaType* pMFType, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormat, [NativeTypeName("UINT32")] uint cbBufSize);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromAMMediaType(IMFMediaType* pMFType, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pAMType);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitAMMediaTypeFromMFMediaType(IMFMediaType* pMFType, [NativeTypeName("GUID")] Guid guidFormatBlockType, AM_MEDIA_TYPE* pAMType);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAMMediaTypeFromMFMediaType(IMFMediaType* pMFType, [NativeTypeName("GUID")] Guid guidFormatBlockType, AM_MEDIA_TYPE** ppAMType);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MFCompareFullToPartialMediaType(IMFMediaType* pMFTypeFull, IMFMediaType* pMFTypePartial);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFWrapMediaType(IMFMediaType* pOrig, [NativeTypeName("const GUID &")] Guid* MajorType, [NativeTypeName("const GUID &")] Guid* SubType, IMFMediaType** ppWrap);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnwrapMediaType(IMFMediaType* pWrap, IMFMediaType** ppOrig);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoMediaType([NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pVideoFormat, IMFVideoMediaType** ppIVideoMediaType);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoMediaTypeFromSubtype([NativeTypeName("const GUID *")] Guid* pAMSubtype, IMFVideoMediaType** ppIVideoMediaType);

        [DllImport("evr", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MFIsFormatYUV([NativeTypeName("DWORD")] uint Format);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoMediaTypeFromBitMapInfoHeader([NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pbmihBitMapInfoHeader, [NativeTypeName("DWORD")] uint dwPixelAspectRatioX, [NativeTypeName("DWORD")] uint dwPixelAspectRatioY, MFVideoInterlaceMode InterlaceMode, [NativeTypeName("QWORD")] ulong VideoFlags, [NativeTypeName("QWORD")] ulong qwFramesPerSecondNumerator, [NativeTypeName("QWORD")] ulong qwFramesPerSecondDenominator, [NativeTypeName("DWORD")] uint dwMaxBitRate, IMFVideoMediaType** ppIVideoMediaType);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetStrideForBitmapInfoHeader([NativeTypeName("DWORD")] uint format, [NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("LONG *")] int* pStride);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetPlaneSize([NativeTypeName("DWORD")] uint format, [NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD *")] uint* pdwPlaneSize);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoMediaTypeFromBitMapInfoHeaderEx([NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pbmihBitMapInfoHeader, [NativeTypeName("UINT32")] uint cbBitMapInfoHeader, [NativeTypeName("DWORD")] uint dwPixelAspectRatioX, [NativeTypeName("DWORD")] uint dwPixelAspectRatioY, MFVideoInterlaceMode InterlaceMode, [NativeTypeName("QWORD")] ulong VideoFlags, [NativeTypeName("DWORD")] uint dwFramesPerSecondNumerator, [NativeTypeName("DWORD")] uint dwFramesPerSecondDenominator, [NativeTypeName("DWORD")] uint dwMaxBitRate, IMFVideoMediaType** ppIVideoMediaType);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaTypeFromRepresentation([NativeTypeName("GUID")] Guid guidRepresentation, [NativeTypeName("LPVOID")] void* pvRepresentation, IMFMediaType** ppIMediaType);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAudioMediaType([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pAudioFormat, IMFAudioMediaType** ppIAudioMediaType);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MFGetUncompressedVideoFormat([NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pVideoFormat);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitVideoFormat(MFVIDEOFORMAT* pVideoFormat, MFStandardVideoFormat type);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitVideoFormat_RGB(MFVIDEOFORMAT* pVideoFormat, [NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint D3Dfmt);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFConvertColorInfoToDXVA([NativeTypeName("DWORD *")] uint* pdwToDXVA, [NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pFromFormat);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFConvertColorInfoFromDXVA(MFVIDEOFORMAT* pToFormat, [NativeTypeName("DWORD")] uint dwFromDXVA);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCopyImage([NativeTypeName("BYTE *")] byte* pDest, [NativeTypeName("LONG")] int lDestStride, [NativeTypeName("const BYTE *")] byte* pSrc, [NativeTypeName("LONG")] int lSrcStride, [NativeTypeName("DWORD")] uint dwWidthInBytes, [NativeTypeName("DWORD")] uint dwLines);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFConvertFromFP16Array(float* pDest, [NativeTypeName("const WORD *")] ushort* pSrc, [NativeTypeName("DWORD")] uint dwCount);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFConvertToFP16Array([NativeTypeName("WORD *")] ushort* pDest, [NativeTypeName("const float *")] float* pSrc, [NativeTypeName("DWORD")] uint dwCount);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreate2DMediaBuffer([NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint dwFourCC, [NativeTypeName("BOOL")] int fBottomUp, IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaBufferFromMediaType(IMFMediaType* pMediaType, [NativeTypeName("LONGLONG")] long llDuration, [NativeTypeName("DWORD")] uint dwMinLength, [NativeTypeName("DWORD")] uint dwMinAlignment, IMFMediaBuffer** ppBuffer);

        [return: NativeTypeName("UINT32")]
        public static uint HI32([NativeTypeName("UINT64")] ulong unPacked)
        {
            return (uint)(unPacked >> 32);
        }

        [return: NativeTypeName("UINT32")]
        public static uint LO32([NativeTypeName("UINT64")] ulong unPacked)
        {
            return (uint)(unPacked);
        }

        [return: NativeTypeName("UINT64")]
        public static ulong Pack2UINT32AsUINT64([NativeTypeName("UINT32")] uint unHigh, [NativeTypeName("UINT32")] uint unLow)
        {
            return ((ulong)(unHigh) << 32) | unLow;
        }

        public static void Unpack2UINT32AsUINT64([NativeTypeName("UINT64")] ulong unPacked, [NativeTypeName("UINT32 *")] uint* punHigh, [NativeTypeName("UINT32 *")] uint* punLow)
        {
            *punHigh = HI32(unPacked);
            *punLow = LO32(unPacked);
        }

        [return: NativeTypeName("UINT64")]
        public static ulong PackSize([NativeTypeName("UINT32")] uint unWidth, [NativeTypeName("UINT32")] uint unHeight)
        {
            return Pack2UINT32AsUINT64(unWidth, unHeight);
        }

        public static void UnpackSize([NativeTypeName("UINT64")] ulong unPacked, [NativeTypeName("UINT32 *")] uint* punWidth, [NativeTypeName("UINT32 *")] uint* punHeight)
        {
            Unpack2UINT32AsUINT64(unPacked, punWidth, punHeight);
        }

        [return: NativeTypeName("UINT64")]
        public static ulong PackRatio([NativeTypeName("INT32")] int nNumerator, [NativeTypeName("UINT32")] uint unDenominator)
        {
            return Pack2UINT32AsUINT64((uint)(nNumerator), unDenominator);
        }

        public static void UnpackRatio([NativeTypeName("UINT64")] ulong unPacked, [NativeTypeName("INT32 *")] int* pnNumerator, [NativeTypeName("UINT32 *")] uint* punDenominator)
        {
            Unpack2UINT32AsUINT64(unPacked, unchecked((uint*)(pnNumerator)), punDenominator);
        }

        [return: NativeTypeName("UINT32")]
        public static uint MFGetAttributeUINT32(IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unDefault)
        {
            uint unRet;

            if ((((int)(pAttributes->GetUINT32(guidKey, &unRet))) < 0))
            {
                unRet = unDefault;
            }

            return unRet;
        }

        [return: NativeTypeName("UINT64")]
        public static ulong MFGetAttributeUINT64(IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unDefault)
        {
            ulong unRet;

            if ((((int)(pAttributes->GetUINT64(guidKey, &unRet))) < 0))
            {
                unRet = unDefault;
            }

            return unRet;
        }

        public static double MFGetAttributeDouble(IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, double fDefault)
        {
            double fRet;

            if ((((int)(pAttributes->GetDouble(guidKey, &fRet))) < 0))
            {
                fRet = fDefault;
            }

            return fRet;
        }

        [return: NativeTypeName("HRESULT")]
        public static int MFGetAttribute2UINT32asUINT64(IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punHigh32, [NativeTypeName("UINT32 *")] uint* punLow32)
        {
            ulong unPacked;
            int hr = ((int)(0));

            hr = pAttributes->GetUINT64(guidKey, &unPacked);
            if ((((int)(hr)) < 0))
            {
                return hr;
            }

            Unpack2UINT32AsUINT64(unPacked, punHigh32, punLow32);
            return hr;
        }

        [return: NativeTypeName("HRESULT")]
        public static int MFSetAttribute2UINT32asUINT64(IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unHigh32, [NativeTypeName("UINT32")] uint unLow32)
        {
            return pAttributes->SetUINT64(guidKey, Pack2UINT32AsUINT64(unHigh32, unLow32));
        }

        [return: NativeTypeName("HRESULT")]
        public static int MFGetAttributeRatio(IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punNumerator, [NativeTypeName("UINT32 *")] uint* punDenominator)
        {
            return MFGetAttribute2UINT32asUINT64(pAttributes, guidKey, punNumerator, punDenominator);
        }

        [return: NativeTypeName("HRESULT")]
        public static int MFGetAttributeSize(IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punWidth, [NativeTypeName("UINT32 *")] uint* punHeight)
        {
            return MFGetAttribute2UINT32asUINT64(pAttributes, guidKey, punWidth, punHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public static int MFSetAttributeRatio(IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unNumerator, [NativeTypeName("UINT32")] uint unDenominator)
        {
            return MFSetAttribute2UINT32asUINT64(pAttributes, guidKey, unNumerator, unDenominator);
        }

        [return: NativeTypeName("HRESULT")]
        public static int MFSetAttributeSize(IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unWidth, [NativeTypeName("UINT32")] uint unHeight)
        {
            return MFSetAttribute2UINT32asUINT64(pAttributes, guidKey, unWidth, unHeight);
        }

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateCollection(IMFCollection** ppIMFCollection);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern void* MFHeapAlloc([NativeTypeName("size_t")] nuint nSize, [NativeTypeName("ULONG")] uint dwFlags, [NativeTypeName("char *")] sbyte* pszFile, int line, EAllocationType eat);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern void MFHeapFree(void* pv);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MFSourceResolver
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0F, 0xB6, 0xEA, 0x90,
                    0x3A, 0xE4,
                    0x88, 0x41,
                    0xBC,
                    0xC4,
                    0xE4,
                    0x7F,
                    0xDF,
                    0x04,
                    0x86,
                    0x8C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("LONGLONG")]
        public static extern long MFllMulDiv([NativeTypeName("LONGLONG")] long a, [NativeTypeName("LONGLONG")] long b, [NativeTypeName("LONGLONG")] long c, [NativeTypeName("LONGLONG")] long d);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetContentProtectionSystemCLSID([NativeTypeName("const GUID &")] Guid* guidProtectionSystemID, [NativeTypeName("CLSID *")] Guid* pclsid);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_DEVICESTREAM_ATTRIBUTE_FACEAUTH_CAPABILITY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2A, 0xD1, 0x6F, 0xCB,
                    0x48, 0x22,
                    0x41, 0x4E,
                    0xAD,
                    0x46,
                    0xE7,
                    0x8B,
                    0xB9,
                    0x0A,
                    0xB9,
                    0xFC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_DEVICESTREAM_ATTRIBUTE_SECURE_CAPABILITY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0xD6, 0x0F, 0x94,
                    0x6E, 0xEA,
                    0x84, 0x46,
                    0x98,
                    0x40,
                    0x36,
                    0xBD,
                    0x6E,
                    0xC9,
                    0xFB,
                    0xEF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCombineSamples(IMFSample* pSample, IMFSample* pSampleToAdd, [NativeTypeName("DWORD")] uint dwMaxMergedDurationInMS, [NativeTypeName("BOOL *")] int* pMerged);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFSplitSample(IMFSample* pSample, IMFSample** pOutputSamples, [NativeTypeName("DWORD")] uint dwOutputSampleMaxCount, [NativeTypeName("DWORD *")] uint* pdwOutputSampleCount);

        [NativeTypeName("#define MF_SDK_VERSION 0x0002")]
        public const int MF_SDK_VERSION = 0x0002;

        [NativeTypeName("#define MF_API_VERSION 0x0070")]
        public const int MF_API_VERSION = 0x0070;

        [NativeTypeName("#define MF_VERSION (MF_SDK_VERSION << 16 | MF_API_VERSION)")]
        public const int MF_VERSION = (0x0002 << 16 | 0x0070);

        [NativeTypeName("#define MFSTARTUP_NOSOCKET 0x1")]
        public const int MFSTARTUP_NOSOCKET = 0x1;

        [NativeTypeName("#define MFSTARTUP_LITE (MFSTARTUP_NOSOCKET)")]
        public const int MFSTARTUP_LITE = (0x1);

        [NativeTypeName("#define MFSTARTUP_FULL 0")]
        public const int MFSTARTUP_FULL = 0;

        [NativeTypeName("#define MF_E_DXGI_DEVICE_NOT_INITIALIZED ((HRESULT)0x80041000L)")]
        public const int MF_E_DXGI_DEVICE_NOT_INITIALIZED = unchecked((int)(0x80041000));

        [NativeTypeName("#define MF_E_DXGI_NEW_VIDEO_DEVICE ((HRESULT)0x80041001L)")]
        public const int MF_E_DXGI_NEW_VIDEO_DEVICE = unchecked((int)(0x80041001));

        [NativeTypeName("#define MF_E_DXGI_VIDEO_DEVICE_LOCKED ((HRESULT)0x80041002L)")]
        public const int MF_E_DXGI_VIDEO_DEVICE_LOCKED = unchecked((int)(0x80041002));

        [NativeTypeName("#define MF_1_BYTE_ALIGNMENT 0x00000000")]
        public const int MF_1_BYTE_ALIGNMENT = 0x00000000;

        [NativeTypeName("#define MF_2_BYTE_ALIGNMENT 0x00000001")]
        public const int MF_2_BYTE_ALIGNMENT = 0x00000001;

        [NativeTypeName("#define MF_4_BYTE_ALIGNMENT 0x00000003")]
        public const int MF_4_BYTE_ALIGNMENT = 0x00000003;

        [NativeTypeName("#define MF_8_BYTE_ALIGNMENT 0x00000007")]
        public const int MF_8_BYTE_ALIGNMENT = 0x00000007;

        [NativeTypeName("#define MF_16_BYTE_ALIGNMENT 0x0000000f")]
        public const int MF_16_BYTE_ALIGNMENT = 0x0000000f;

        [NativeTypeName("#define MF_32_BYTE_ALIGNMENT 0x0000001f")]
        public const int MF_32_BYTE_ALIGNMENT = 0x0000001f;

        [NativeTypeName("#define MF_64_BYTE_ALIGNMENT 0x0000003f")]
        public const int MF_64_BYTE_ALIGNMENT = 0x0000003f;

        [NativeTypeName("#define MF_128_BYTE_ALIGNMENT 0x0000007f")]
        public const int MF_128_BYTE_ALIGNMENT = 0x0000007f;

        [NativeTypeName("#define MF_256_BYTE_ALIGNMENT 0x000000ff")]
        public const int MF_256_BYTE_ALIGNMENT = 0x000000ff;

        [NativeTypeName("#define MF_512_BYTE_ALIGNMENT 0x000001ff")]
        public const int MF_512_BYTE_ALIGNMENT = 0x000001ff;

        [NativeTypeName("#define MF_1024_BYTE_ALIGNMENT 0x000003ff")]
        public const int MF_1024_BYTE_ALIGNMENT = 0x000003ff;

        [NativeTypeName("#define MF_2048_BYTE_ALIGNMENT 0x000007ff")]
        public const int MF_2048_BYTE_ALIGNMENT = 0x000007ff;

        [NativeTypeName("#define MF_4096_BYTE_ALIGNMENT 0x00000fff")]
        public const int MF_4096_BYTE_ALIGNMENT = 0x00000fff;

        [NativeTypeName("#define MF_8192_BYTE_ALIGNMENT 0x00001fff")]
        public const int MF_8192_BYTE_ALIGNMENT = 0x00001fff;

        [NativeTypeName("#define MFSESSIONCAP_START 0x00000001")]
        public const int MFSESSIONCAP_START = 0x00000001;

        [NativeTypeName("#define MFSESSIONCAP_SEEK 0x00000002")]
        public const int MFSESSIONCAP_SEEK = 0x00000002;

        [NativeTypeName("#define MFSESSIONCAP_PAUSE 0x00000004")]
        public const int MFSESSIONCAP_PAUSE = 0x00000004;

        [NativeTypeName("#define MFSESSIONCAP_RATE_FORWARD 0x00000010")]
        public const int MFSESSIONCAP_RATE_FORWARD = 0x00000010;

        [NativeTypeName("#define MFSESSIONCAP_RATE_REVERSE 0x00000020")]
        public const int MFSESSIONCAP_RATE_REVERSE = 0x00000020;

        [NativeTypeName("#define MFSESSIONCAP_DOES_NOT_USE_NETWORK 0x00000040")]
        public const int MFSESSIONCAP_DOES_NOT_USE_NETWORK = 0x00000040;

        [NativeTypeName("#define MFSampleExtension_ClosedCaption_CEA708_MAX_SIZE 256")]
        public const int MFSampleExtension_ClosedCaption_CEA708_MAX_SIZE = 256;

        [NativeTypeName("#define MACROBLOCK_FLAG_SKIP 0x00000001")]
        public const int MACROBLOCK_FLAG_SKIP = 0x00000001;

        [NativeTypeName("#define MACROBLOCK_FLAG_DIRTY 0x00000002")]
        public const int MACROBLOCK_FLAG_DIRTY = 0x00000002;

        [NativeTypeName("#define MACROBLOCK_FLAG_MOTION 0x00000004")]
        public const int MACROBLOCK_FLAG_MOTION = 0x00000004;

        [NativeTypeName("#define MACROBLOCK_FLAG_VIDEO 0x00000008")]
        public const int MACROBLOCK_FLAG_VIDEO = 0x00000008;

        [NativeTypeName("#define MACROBLOCK_FLAG_HAS_MOTION_VECTOR 0x00000010")]
        public const int MACROBLOCK_FLAG_HAS_MOTION_VECTOR = 0x00000010;

        [NativeTypeName("#define MACROBLOCK_FLAG_HAS_QP 0x00000020")]
        public const int MACROBLOCK_FLAG_HAS_QP = 0x00000020;

        [NativeTypeName("#define MFCAPTURE_METADATA_SCAN_RIGHT_LEFT 0x00000001")]
        public const int MFCAPTURE_METADATA_SCAN_RIGHT_LEFT = 0x00000001;

        [NativeTypeName("#define MFCAPTURE_METADATA_SCAN_BOTTOM_TOP 0x00000002")]
        public const int MFCAPTURE_METADATA_SCAN_BOTTOM_TOP = 0x00000002;

        [NativeTypeName("#define MFCAPTURE_METADATA_SCANLINE_VERTICAL 0x00000004")]
        public const int MFCAPTURE_METADATA_SCANLINE_VERTICAL = 0x00000004;

        [NativeTypeName("#define MF_METADATAFACIALEXPRESSION_SMILE 0x00000001")]
        public const int MF_METADATAFACIALEXPRESSION_SMILE = 0x00000001;

        [NativeTypeName("#define MF_METADATATIMESTAMPS_DEVICE 0x00000001")]
        public const int MF_METADATATIMESTAMPS_DEVICE = 0x00000001;

        [NativeTypeName("#define MF_METADATATIMESTAMPS_PRESENTATION 0x00000002")]
        public const int MF_METADATATIMESTAMPS_PRESENTATION = 0x00000002;

        [NativeTypeName("#define MF_HISTOGRAM_CHANNEL_Y 0x00000001")]
        public const int MF_HISTOGRAM_CHANNEL_Y = 0x00000001;

        [NativeTypeName("#define MF_HISTOGRAM_CHANNEL_R 0x00000002")]
        public const int MF_HISTOGRAM_CHANNEL_R = 0x00000002;

        [NativeTypeName("#define MF_HISTOGRAM_CHANNEL_G 0x00000004")]
        public const int MF_HISTOGRAM_CHANNEL_G = 0x00000004;

        [NativeTypeName("#define MF_HISTOGRAM_CHANNEL_B 0x00000008")]
        public const int MF_HISTOGRAM_CHANNEL_B = 0x00000008;

        [NativeTypeName("#define MF_HISTOGRAM_CHANNEL_Cb 0x00000010")]
        public const int MF_HISTOGRAM_CHANNEL_Cb = 0x00000010;

        [NativeTypeName("#define MF_HISTOGRAM_CHANNEL_Cr 0x00000020")]
        public const int MF_HISTOGRAM_CHANNEL_Cr = 0x00000020;

        [NativeTypeName("#define D3DFMT_R8G8B8 20")]
        public const int D3DFMT_R8G8B8 = 20;

        [NativeTypeName("#define D3DFMT_A8R8G8B8 21")]
        public const int D3DFMT_A8R8G8B8 = 21;

        [NativeTypeName("#define D3DFMT_X8R8G8B8 22")]
        public const int D3DFMT_X8R8G8B8 = 22;

        [NativeTypeName("#define D3DFMT_R5G6B5 23")]
        public const int D3DFMT_R5G6B5 = 23;

        [NativeTypeName("#define D3DFMT_X1R5G5B5 24")]
        public const int D3DFMT_X1R5G5B5 = 24;

        [NativeTypeName("#define D3DFMT_A2B10G10R10 31")]
        public const int D3DFMT_A2B10G10R10 = 31;

        [NativeTypeName("#define D3DFMT_P8 41")]
        public const int D3DFMT_P8 = 41;

        [NativeTypeName("#define D3DFMT_L8 50")]
        public const int D3DFMT_L8 = 50;

        [NativeTypeName("#define D3DFMT_D16 80")]
        public const int D3DFMT_D16 = 80;

        [NativeTypeName("#define D3DFMT_L16 81")]
        public const int D3DFMT_L16 = 81;

        [NativeTypeName("#define D3DFMT_A16B16G16R16F 113")]
        public const int D3DFMT_A16B16G16R16F = 113;

        [NativeTypeName("#define LOCAL_D3DFMT_DEFINES 1")]
        public const int LOCAL_D3DFMT_DEFINES = 1;

        [NativeTypeName("#define MFVideoFormat_MPG2 MFVideoFormat_MPEG2")]
        public static ref readonly Guid MFVideoFormat_MPG2 => ref MFVideoFormat_MPEG2;
    }
}
