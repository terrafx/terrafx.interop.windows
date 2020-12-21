// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.MFWaveFormatExConvertFlags;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFStartup([NativeTypeName("ULONG")] uint Version, [NativeTypeName("DWORD")] uint dwFlags = 0);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFShutdown();

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLockPlatform();

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnlockPlatform();

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWorkItem([NativeTypeName("DWORD")] uint dwQueue, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWorkItem2([NativeTypeName("DWORD")] uint dwQueue, [NativeTypeName("LONG")] int Priority, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWorkItemEx([NativeTypeName("DWORD")] uint dwQueue, [NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWorkItemEx2([NativeTypeName("DWORD")] uint dwQueue, [NativeTypeName("LONG")] int Priority, [NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWaitingWorkItem([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("LONG")] int Priority, [NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("MFWORKITEM_KEY *")] ulong* pKey);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFAllocateSerialWorkQueue([NativeTypeName("DWORD")] uint dwWorkQueue, [NativeTypeName("DWORD *")] uint* pdwWorkQueue);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFScheduleWorkItemEx([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("INT64")] long Timeout, [NativeTypeName("MFWORKITEM_KEY *")] ulong* pKey);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFScheduleWorkItem([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState, [NativeTypeName("INT64")] long Timeout, [NativeTypeName("MFWORKITEM_KEY *")] ulong* pKey);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCancelWorkItem([NativeTypeName("MFWORKITEM_KEY")] ulong Key);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetTimerPeriodicity([NativeTypeName("DWORD *")] uint* Periodicity);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
#if !NETSTANDARD2_0
        public static extern int MFAddPeriodicCallback([NativeTypeName("MFPERIODICCALLBACK")] delegate* unmanaged[Cdecl]<IUnknown*, void> Callback, [NativeTypeName("IUnknown *")] IUnknown* pContext, [NativeTypeName("DWORD *")] uint* pdwKey);
#else
        public static extern int MFAddPeriodicCallback([NativeTypeName("MFPERIODICCALLBACK")] delegate* unmanaged[Cdecl]<IUnknown*, void> Callback, [NativeTypeName("IUnknown *")] IUnknown* pContext, [NativeTypeName("DWORD *")] uint* pdwKey);
#endif


        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRemovePeriodicCallback([NativeTypeName("DWORD")] uint dwKey);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFAllocateWorkQueueEx(MFASYNC_WORKQUEUE_TYPE WorkQueueType, [NativeTypeName("DWORD *")] uint* pdwWorkQueue);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFAllocateWorkQueue([NativeTypeName("DWORD *")] uint* pdwWorkQueue);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLockWorkQueue([NativeTypeName("DWORD")] uint dwWorkQueue);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnlockWorkQueue([NativeTypeName("DWORD")] uint dwWorkQueue);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFBeginRegisterWorkQueueWithMMCSS([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LPCWSTR")] ushort* wszClass, [NativeTypeName("DWORD")] uint dwTaskId, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pDoneCallback, [NativeTypeName("IUnknown *")] IUnknown* pDoneState);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFBeginRegisterWorkQueueWithMMCSSEx([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LPCWSTR")] ushort* wszClass, [NativeTypeName("DWORD")] uint dwTaskId, [NativeTypeName("LONG")] int lPriority, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pDoneCallback, [NativeTypeName("IUnknown *")] IUnknown* pDoneState);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFEndRegisterWorkQueueWithMMCSS([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("DWORD *")] uint* pdwTaskId);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFBeginUnregisterWorkQueueWithMMCSS([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pDoneCallback, [NativeTypeName("IUnknown *")] IUnknown* pDoneState);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFEndUnregisterWorkQueueWithMMCSS([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetWorkQueueMMCSSClass([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LPWSTR")] ushort* pwszClass, [NativeTypeName("DWORD *")] uint* pcchClass);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetWorkQueueMMCSSTaskId([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LPDWORD")] uint* pdwTaskId);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRegisterPlatformWithMMCSS([NativeTypeName("PCWSTR")] ushort* wszClass, [NativeTypeName("DWORD *")] uint* pdwTaskId, [NativeTypeName("LONG")] int lPriority);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnregisterPlatformFromMMCSS();

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLockSharedWorkQueue([NativeTypeName("PCWSTR")] ushort* wszClass, [NativeTypeName("LONG")] int BasePriority, [NativeTypeName("DWORD *")] uint* pdwTaskId, [NativeTypeName("DWORD *")] uint* pID);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetWorkQueueMMCSSPriority([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LONG *")] int* lPriority);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAsyncResult([NativeTypeName("IUnknown *")] IUnknown* punkObject, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState, [NativeTypeName("IMFAsyncResult **")] IMFAsyncResult** ppAsyncResult);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInvokeCallback([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pAsyncResult);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateFile(MF_FILE_ACCESSMODE AccessMode, MF_FILE_OPENMODE OpenMode, MF_FILE_FLAGS fFlags, [NativeTypeName("LPCWSTR")] ushort* pwszFileURL, [NativeTypeName("IMFByteStream **")] IMFByteStream** ppIByteStream);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTempFile(MF_FILE_ACCESSMODE AccessMode, MF_FILE_OPENMODE OpenMode, MF_FILE_FLAGS fFlags, [NativeTypeName("IMFByteStream **")] IMFByteStream** ppIByteStream);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFBeginCreateFile(MF_FILE_ACCESSMODE AccessMode, MF_FILE_OPENMODE OpenMode, MF_FILE_FLAGS fFlags, [NativeTypeName("LPCWSTR")] ushort* pwszFilePath, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState, [NativeTypeName("IUnknown **")] IUnknown** ppCancelCookie);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFEndCreateFile([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("IMFByteStream **")] IMFByteStream** ppFile);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCancelCreateFile([NativeTypeName("IUnknown *")] IUnknown* pCancelCookie);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMemoryBuffer([NativeTypeName("DWORD")] uint cbMaxLength, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaBufferWrapper([NativeTypeName("IMFMediaBuffer *")] IMFMediaBuffer* pBuffer, [NativeTypeName("DWORD")] uint cbOffset, [NativeTypeName("DWORD")] uint dwLength, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateLegacyMediaBufferOnMFMediaBuffer([NativeTypeName("IMFSample *")] IMFSample* pSample, [NativeTypeName("IMFMediaBuffer *")] IMFMediaBuffer* pMFMediaBuffer, [NativeTypeName("DWORD")] uint cbOffset, [NativeTypeName("IMediaBuffer **")] IMediaBuffer** ppMediaBuffer);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern DXGI_FORMAT MFMapDX9FormatToDXGIFormat([NativeTypeName("DWORD")] uint dx9);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MFMapDXGIFormatToDX9Format(DXGI_FORMAT dx11);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLockDXGIDeviceManager([NativeTypeName("UINT *")] uint* pResetToken, [NativeTypeName("IMFDXGIDeviceManager **")] IMFDXGIDeviceManager** ppManager);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnlockDXGIDeviceManager();

        [DllImport("evr", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDXSurfaceBuffer([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punkSurface, [NativeTypeName("BOOL")] int fBottomUpWhenLinear, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateWICBitmapBuffer([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punkSurface, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDXGISurfaceBuffer([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punkSurface, [NativeTypeName("UINT")] uint uSubresourceIndex, [NativeTypeName("BOOL")] int fBottomUpWhenLinear, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoSampleAllocatorEx([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppSampleAllocator);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDXGIDeviceManager([NativeTypeName("UINT *")] uint* resetToken, [NativeTypeName("IMFDXGIDeviceManager **")] IMFDXGIDeviceManager** ppDeviceManager);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAlignedMemoryBuffer([NativeTypeName("DWORD")] uint cbMaxLength, [NativeTypeName("DWORD")] uint cbAligment, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, [NativeTypeName("HRESULT")] int hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue, [NativeTypeName("IMFMediaEvent **")] IMFMediaEvent** ppEvent);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateEventQueue([NativeTypeName("IMFMediaEventQueue **")] IMFMediaEventQueue** ppMediaEventQueue);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_SESSIONCAPS = new Guid(0x7e5ebcd0, 0x11b8, 0x4abe, 0xaf, 0xad, 0x10, 0xf6, 0x59, 0x9a, 0x7f, 0x42);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_SESSIONCAPS_DELTA = new Guid(0x7e5ebcd1, 0x11b8, 0x4abe, 0xaf, 0xad, 0x10, 0xf6, 0x59, 0x9a, 0x7f, 0x42);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_TOPOLOGY_STATUS = new Guid(0x30c5018d, 0x9a53, 0x454b, 0xad, 0x9e, 0x6d, 0x5f, 0x8f, 0xa7, 0xc4, 0x3b);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_START_PRESENTATION_TIME = new Guid(0x5ad914d0, 0x9b45, 0x4a8d, 0xa2, 0xc0, 0x81, 0xd1, 0xe5, 0xb, 0xfb, 0x7);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_PRESENTATION_TIME_OFFSET = new Guid(0x5ad914d1, 0x9b45, 0x4a8d, 0xa2, 0xc0, 0x81, 0xd1, 0xe5, 0xb, 0xfb, 0x7);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_START_PRESENTATION_TIME_AT_OUTPUT = new Guid(0x5ad914d2, 0x9b45, 0x4a8d, 0xa2, 0xc0, 0x81, 0xd1, 0xe5, 0xb, 0xfb, 0x7);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_SOURCE_FAKE_START = new Guid(0xa8cc55a7, 0x6b31, 0x419f, 0x84, 0x5d, 0xff, 0xb3, 0x51, 0xa2, 0x43, 0x4b);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_SOURCE_PROJECTSTART = new Guid(0xa8cc55a8, 0x6b31, 0x419f, 0x84, 0x5d, 0xff, 0xb3, 0x51, 0xa2, 0x43, 0x4b);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_SOURCE_ACTUAL_START = new Guid(0xa8cc55a9, 0x6b31, 0x419f, 0x84, 0x5d, 0xff, 0xb3, 0x51, 0xa2, 0x43, 0x4b);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_SOURCE_TOPOLOGY_CANCELED = new Guid(0xdb62f650, 0x9a5e, 0x4704, 0xac, 0xf3, 0x56, 0x3b, 0xc6, 0xa7, 0x33, 0x64);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_SOURCE_CHARACTERISTICS = new Guid(0x47db8490, 0x8b22, 0x4f52, 0xaf, 0xda, 0x9c, 0xe1, 0xb2, 0xd3, 0xcf, 0xa8);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_SOURCE_CHARACTERISTICS_OLD = new Guid(0x47db8491, 0x8b22, 0x4f52, 0xaf, 0xda, 0x9c, 0xe1, 0xb2, 0xd3, 0xcf, 0xa8);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_DO_THINNING = new Guid(0x321ea6fb, 0xdad9, 0x46e4, 0xb3, 0x1d, 0xd2, 0xea, 0xe7, 0x9, 0xe, 0x30);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_SCRUBSAMPLE_TIME = new Guid(0x9ac712b3, 0xdcb8, 0x44d5, 0x8d, 0xc, 0x37, 0x45, 0x5a, 0x27, 0x82, 0xe3);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_OUTPUT_NODE = new Guid(0x830f1a8b, 0xc060, 0x46dd, 0xa8, 0x01, 0x1c, 0x95, 0xde, 0xc9, 0xb1, 0x07);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_MFT_INPUT_STREAM_ID = new Guid(0xf29c2cca, 0x7ae6, 0x42d2, 0xb2, 0x84, 0xbf, 0x83, 0x7c, 0xc8, 0x74, 0xe2);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_MFT_CONTEXT = new Guid(0xb7cd31f1, 0x899e, 0x4b41, 0x80, 0xc9, 0x26, 0xa8, 0x96, 0xd3, 0x29, 0x77);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_STREAM_METADATA_KEYDATA = new Guid(0xcd59a4a1, 0x4a3b, 0x4bbd, 0x86, 0x65, 0x72, 0xa4, 0xf, 0xbe, 0xa7, 0x76);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_STREAM_METADATA_CONTENT_KEYIDS = new Guid(0x5063449d, 0xcc29, 0x4fc6, 0xa7, 0x5a, 0xd2, 0x47, 0xb3, 0x5a, 0xf8, 0x5c);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_EVENT_STREAM_METADATA_SYSTEMID = new Guid(0x1ea2ef64, 0xba16, 0x4a36, 0x87, 0x19, 0xfe, 0x75, 0x60, 0xba, 0x32, 0xad);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSample([NativeTypeName("IMFSample **")] IMFSample** ppIMFSample);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_MaxDecodeFrameSize = new Guid(0xd3cc654f, 0xf9f3, 0x4a13, 0x88, 0x9f, 0xf0, 0x4e, 0xb2, 0xb5, 0xb9, 0x57);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_AccumulatedNonRefPicPercent = new Guid(0x79ea74df, 0xa740, 0x445b, 0xbc, 0x98, 0xc9, 0xed, 0x1f, 0x26, 0xe, 0xee);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_ProtectionScheme = new Guid(0xd054d096, 0x28bb, 0x45da, 0x87, 0xec, 0x74, 0xf3, 0x51, 0x87, 0x14, 0x6);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_CryptByteBlock = new Guid(0x9d84289b, 0xc7f, 0x4713, 0xab, 0x95, 0x10, 0x8a, 0xb4, 0x2a, 0xd8, 0x1);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_SkipByteBlock = new Guid(0xd550548, 0x8317, 0x4ab1, 0x84, 0x5f, 0xd0, 0x63, 0x6, 0xe2, 0x93, 0xe3);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_SubSample_Mapping = new Guid(0x8444F27A, 0x69A1, 0x48DA, 0xBD, 0x08, 0x11, 0xCE, 0xF3, 0x68, 0x30, 0xD2);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_ClearSliceHeaderData = new Guid(0x5509a4f4, 0x320d, 0x4e6c, 0x8d, 0x1a, 0x94, 0xc6, 0x6d, 0xd2, 0xc, 0xb0);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_HardwareProtection_KeyInfoID = new Guid(0x8cbfcceb, 0x94a5, 0x4de1, 0x82, 0x31, 0xa8, 0x5e, 0x47, 0xcf, 0x81, 0xe7);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_HardwareProtection_KeyInfo = new Guid(0xb2372080, 0x455b, 0x4dd7, 0x99, 0x89, 0x1a, 0x95, 0x57, 0x84, 0xb7, 0x54);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_HardwareProtection_VideoDecryptorContext = new Guid(0x693470c8, 0xe837, 0x47a0, 0x88, 0xcb, 0x53, 0x5b, 0x90, 0x5e, 0x35, 0x82);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_Opaque_Data = new Guid(0x224d77e5, 0x1391, 0x4ffb, 0x9f, 0x41, 0xb4, 0x32, 0xf6, 0x8c, 0x61, 0x1d);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_NALULengthInfo = new Guid(0x19124E7C, 0xAD4B, 0x465F, 0xBB, 0x18, 0x20, 0x18, 0x62, 0x87, 0xB6, 0xAF);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_ResumeVideoOutput = new Guid(0xa435aba5, 0xafde, 0x4cf5, 0xbc, 0x1c, 0xf6, 0xac, 0xaf, 0x13, 0x94, 0x9d);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_NALUTypes = new Guid(0xb0f067c7, 0x714c, 0x416c, 0x8d, 0x59, 0x5f, 0x4d, 0xdf, 0x89, 0x13, 0xb6);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_SPSPPSData = new Guid(0xaede0fa2, 0xe0c, 0x453c, 0xb7, 0xf3, 0xde, 0x86, 0x93, 0x36, 0x4d, 0x11);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_SEIData = new Guid(0x3cf0e972, 0x4542, 0x4687, 0x99, 0x99, 0x58, 0x5f, 0x56, 0x5f, 0xba, 0x7d);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_HardwareProtection = new Guid(0x9a2b2d2b, 0x8270, 0x43e3, 0x84, 0x48, 0x99, 0x4f, 0x42, 0x6e, 0x88, 0x86);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_CleanPoint = new Guid(0x9cdf01d8, 0xa0f0, 0x43ba, 0xb0, 0x77, 0xea, 0xa0, 0x6c, 0xbd, 0x72, 0x8a);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Discontinuity = new Guid(0x9cdf01d9, 0xa0f0, 0x43ba, 0xb0, 0x77, 0xea, 0xa0, 0x6c, 0xbd, 0x72, 0x8a);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Token = new Guid(0x8294da66, 0xf328, 0x4805, 0xb5, 0x51, 0x00, 0xde, 0xb4, 0xc5, 0x7a, 0x61);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_ClosedCaption_CEA708 = new Guid(0x26f09068, 0xe744, 0x47dc, 0xaa, 0x03, 0xdb, 0xf2, 0x04, 0x03, 0xbd, 0xe6);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_DecodeTimestamp = new Guid(0x73a954d4, 0x9e2, 0x4861, 0xbe, 0xfc, 0x94, 0xbd, 0x97, 0xc0, 0x8e, 0x6e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_VideoEncodeQP = new Guid(0xb2efe478, 0xf979, 0x4c66, 0xb9, 0x5e, 0xee, 0x2b, 0x82, 0xc8, 0x2f, 0x36);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_VideoEncodePictureType = new Guid(0x973704e6, 0xcd14, 0x483c, 0x8f, 0x20, 0xc9, 0xfc, 0x9, 0x28, 0xba, 0xd5);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_FrameCorruption = new Guid(0xb4dd4a8c, 0xbeb, 0x44c4, 0x8b, 0x75, 0xb0, 0x2b, 0x91, 0x3b, 0x4, 0xf0);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_DirtyRects = new Guid(0x9ba70225, 0xb342, 0x4e97, 0x91, 0x26, 0x0b, 0x56, 0x6a, 0xb7, 0xea, 0x7e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_MoveRegions = new Guid(0xe2a6c693, 0x3a8b, 0x4b8d, 0x95, 0xd0, 0xf6, 0x02, 0x81, 0xa1, 0x2f, 0xb7);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_HDCP_OptionalHeader = new Guid(0x9a2e7390, 0x121f, 0x455f, 0x83, 0x76, 0xc9, 0x74, 0x28, 0xe0, 0xb5, 0x40);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_HDCP_FrameCounter = new Guid(0x9d389c60, 0xf507, 0x4aa6, 0xa4, 0xa, 0x71, 0x2, 0x7a, 0x2, 0xf3, 0xde);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_HDCP_StreamID = new Guid(0x177e5d74, 0xc370, 0x4a7a, 0x95, 0xa2, 0x36, 0x83, 0x3c, 0x01, 0xd0, 0xaf);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Timestamp = new Guid(0x1e436999, 0x69be, 0x4c7a, 0x93, 0x69, 0x70, 0x06, 0x8c, 0x02, 0x60, 0xcb);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_RepeatFrame = new Guid(0x88be738f, 0x711, 0x4f42, 0xb4, 0x58, 0x34, 0x4a, 0xed, 0x42, 0xec, 0x2f);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_ENCODER_ERROR = new Guid(0xc8d1eda4, 0x98e4, 0x41d5, 0x92, 0x97, 0x44, 0xf5, 0x38, 0x52, 0xf9, 0x0e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_GFX_DRIVER_VERSION_ID_Attribute = new Guid(0xf34b9093, 0x05e0, 0x4b16, 0x99, 0x3d, 0x3e, 0x2a, 0x2c, 0xde, 0x6a, 0xd3);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_DescrambleData = new Guid(0x43483be6, 0x4903, 0x4314, 0xb0, 0x32, 0x29, 0x51, 0x36, 0x59, 0x36, 0xfc);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_SampleKeyID = new Guid(0x9ed713c8, 0x9b87, 0x4b26, 0x82, 0x97, 0xa9, 0x3b, 0x0c, 0x5a, 0x8a, 0xcc);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_GenKeyFunc = new Guid(0x441ca1ee, 0x6b1f, 0x4501, 0x90, 0x3a, 0xde, 0x87, 0xdf, 0x42, 0xf6, 0xed);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_GenKeyCtx = new Guid(0x188120cb, 0xd7da, 0x4b59, 0x9b, 0x3e, 0x92, 0x52, 0xfd, 0x37, 0x30, 0x1c);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_PacketCrossOffsets = new Guid(0x2789671d, 0x389f, 0x40bb, 0x90, 0xd9, 0xc2, 0x82, 0xf7, 0x7f, 0x9a, 0xbd);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_SampleID = new Guid(0x6698b84e, 0x0afa, 0x4330, 0xae, 0xb2, 0x1c, 0x0a, 0x98, 0xd7, 0xa4, 0x4d);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_KeyID = new Guid(0x76376591, 0x795f, 0x4da1, 0x86, 0xed, 0x9d, 0x46, 0xec, 0xa1, 0x09, 0xa9);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Content_KeyID = new Guid(0xc6c7f5b0, 0xacca, 0x415b, 0x87, 0xd9, 0x10, 0x44, 0x14, 0x69, 0xef, 0xc6);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Encryption_SubSampleMappingSplit = new Guid(0xfe0254b9, 0x2aa5, 0x4edc, 0x99, 0xf7, 0x17, 0xe8, 0x9d, 0xbf, 0x91, 0x74);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Interlaced = new Guid(0xb1d5830a, 0xdeb8, 0x40e3, 0x90, 0xfa, 0x38, 0x99, 0x43, 0x71, 0x64, 0x61);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_BottomFieldFirst = new Guid(0x941ce0a3, 0x6ae3, 0x4dda, 0x9a, 0x08, 0xa6, 0x42, 0x98, 0x34, 0x06, 0x17);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_RepeatFirstField = new Guid(0x304d257c, 0x7493, 0x4fbd, 0xb1, 0x49, 0x92, 0x28, 0xde, 0x8d, 0x9a, 0x99);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_SingleField = new Guid(0x9d85f816, 0x658b, 0x455a, 0xbd, 0xe0, 0x9f, 0xa7, 0xe1, 0x5a, 0xb8, 0xf9);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_DerivedFromTopField = new Guid(0x6852465a, 0xae1c, 0x4553, 0x8e, 0x9b, 0xc3, 0x42, 0x0f, 0xcb, 0x16, 0x37);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_MeanAbsoluteDifference = new Guid(0x1cdbde11, 0x08b4, 0x4311, 0xa6, 0xdd, 0x0f, 0x9f, 0x37, 0x19, 0x07, 0xaa);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_LongTermReferenceFrameInfo = new Guid(0x9154733f, 0xe1bd, 0x41bf, 0x81, 0xd3, 0xfc, 0xd9, 0x18, 0xf7, 0x13, 0x32);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_ROIRectangle = new Guid(0x3414a438, 0x4998, 0x4d2c, 0xbe, 0x82, 0xbe, 0x3c, 0xa0, 0xb2, 0x4d, 0x43);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_LastSlice = new Guid(0x2b5d5457, 0x5547, 0x4f07, 0xb8, 0xc8, 0xb4, 0xa3, 0xa9, 0xa1, 0xda, 0xac);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_FeatureMap = new Guid(0xa032d165, 0x46fc, 0x400a, 0xb4, 0x49, 0x49, 0xde, 0x53, 0xe6, 0x2a, 0x6e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_ChromaOnly = new Guid(0x1eb9179c, 0xa01f, 0x4845, 0x8c, 0x04, 0x0e, 0x65, 0xa2, 0x6e, 0xb0, 0x4f);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_PhotoThumbnail = new Guid(0x74BBC85C, 0xC8BB, 0x42DC, 0xB5, 0x86, 0xDA, 0x17, 0xFF, 0xD3, 0x5D, 0xCC);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_PhotoThumbnailMediaType = new Guid(0x61AD5420, 0xEBF8, 0x4143, 0x89, 0xAF, 0x6B, 0xF2, 0x5F, 0x67, 0x2D, 0xEF);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_CaptureMetadata = new Guid(0x2EBE23A8, 0xFAF5, 0x444A, 0xA6, 0xA2, 0xEB, 0x81, 0x08, 0x80, 0xAB, 0x5D);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_MDLCacheCookie = new Guid(0x5F002AF9, 0xD8F9, 0x41A3, 0xB6, 0xC3, 0xA2, 0xAD, 0x43, 0xF6, 0x47, 0xAD);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_PHOTO_FRAME_FLASH = new Guid(0x0F9DD6C6, 0x6003, 0x45D8, 0xBD, 0x59, 0xF1, 0xF5, 0x3E, 0x3D, 0x04, 0xE8);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_FRAME_RAWSTREAM = new Guid(0x9252077B, 0x2680, 0x49B9, 0xAE, 0x02, 0xB1, 0x90, 0x75, 0x97, 0x3B, 0x70);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_FOCUSSTATE = new Guid(0xa87ee154, 0x997f, 0x465d, 0xb9, 0x1f, 0x29, 0xd5, 0x3b, 0x98, 0x2b, 0x88);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_REQUESTED_FRAME_SETTING_ID = new Guid(0xbb3716d9, 0x8a61, 0x47a4, 0x81, 0x97, 0x45, 0x9c, 0x7f, 0xf1, 0x74, 0xd5);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_EXPOSURE_TIME = new Guid(0x16b9ae99, 0xcd84, 0x4063, 0x87, 0x9d, 0xa2, 0x8c, 0x76, 0x33, 0x72, 0x9e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_EXPOSURE_COMPENSATION = new Guid(0xd198aa75, 0x4b62, 0x4345, 0xab, 0xf3, 0x3c, 0x31, 0xfa, 0x12, 0xc2, 0x99);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_ISO_SPEED = new Guid(0xe528a68f, 0xb2e3, 0x44fe, 0x8b, 0x65, 0x7, 0xbf, 0x4b, 0x5a, 0x13, 0xff);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_LENS_POSITION = new Guid(0xb5fc8e86, 0x11d1, 0x4e70, 0x81, 0x9b, 0x72, 0x3a, 0x89, 0xfa, 0x45, 0x20);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_SCENE_MODE = new Guid(0x9cc3b54d, 0x5ed3, 0x4bae, 0xb3, 0x88, 0x76, 0x70, 0xae, 0xf5, 0x9e, 0x13);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_FLASH = new Guid(0x4a51520b, 0xfb36, 0x446c, 0x9d, 0xf2, 0x68, 0x17, 0x1b, 0x9a, 0x3, 0x89);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_FLASH_POWER = new Guid(0x9c0e0d49, 0x205, 0x491a, 0xbc, 0x9d, 0x2d, 0x6e, 0x1f, 0x4d, 0x56, 0x84);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_WHITEBALANCE = new Guid(0xc736fd77, 0xfb9, 0x4e2e, 0x97, 0xa2, 0xfc, 0xd4, 0x90, 0x73, 0x9e, 0xe9);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_ZOOMFACTOR = new Guid(0xe50b0b81, 0xe501, 0x42c2, 0xab, 0xf2, 0x85, 0x7e, 0xcb, 0x13, 0xfa, 0x5c);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_FACEROIS = new Guid(0x864f25a6, 0x349f, 0x46b1, 0xa3, 0xe, 0x54, 0xcc, 0x22, 0x92, 0x8a, 0x47);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_FACEROITIMESTAMPS = new Guid(0xe94d50cc, 0x3da0, 0x44d4, 0xbb, 0x34, 0x83, 0x19, 0x8a, 0x74, 0x18, 0x68);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_FACEROICHARACTERIZATIONS = new Guid(0xb927a1a8, 0x18ef, 0x46d3, 0xb3, 0xaf, 0x69, 0x37, 0x2f, 0x94, 0xd9, 0xb2);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_ISO_GAINS = new Guid(0x5802ac9, 0xe1d, 0x41c7, 0xa8, 0xc8, 0x7e, 0x73, 0x69, 0xf8, 0x4e, 0x1e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_SENSORFRAMERATE = new Guid(0xdb51357e, 0x9d3d, 0x4962, 0xb0, 0x6d, 0x7, 0xce, 0x65, 0xd, 0x9a, 0xa);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_WHITEBALANCE_GAINS = new Guid(0xe7570c8f, 0x2dcb, 0x4c7c, 0xaa, 0xce, 0x22, 0xec, 0xe7, 0xcc, 0xe6, 0x47);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_HISTOGRAM = new Guid(0x85358432, 0x2ef6, 0x4ba9, 0xa3, 0xfb, 0x6, 0xd8, 0x29, 0x74, 0xb8, 0x95);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_EXIF = new Guid(0x2e9575b8, 0x8c31, 0x4a02, 0x85, 0x75, 0x42, 0xb1, 0x97, 0xb7, 0x15, 0x92);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_FRAME_ILLUMINATION = new Guid(0x6D688FFC, 0x63D3, 0x46FE, 0xBA, 0xDA, 0x5B, 0x94, 0x7D, 0xB0, 0xD0, 0x80);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_UVC_PAYLOADHEADER = new Guid(0xf9f88a87, 0xe1dd, 0x441e, 0x95, 0xcb, 0x42, 0xe2, 0x1a, 0x64, 0xf1, 0xd9);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Depth_MinReliableDepth = new Guid(0x5f8582b2, 0xe36b, 0x47c8, 0x9b, 0x87, 0xfe, 0xe1, 0xca, 0x72, 0xc5, 0xb0);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_Depth_MaxReliableDepth = new Guid(0xe45545d1, 0x1f0f, 0x4a32, 0xa8, 0xa7, 0x61, 0x1, 0xa2, 0x4e, 0xa8, 0xbe);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_FIRST_SCANLINE_START_TIME_QPC = new Guid(0x6a2c49f1, 0xe052, 0x46b6, 0xb2, 0xd9, 0x73, 0xc1, 0x55, 0x87, 0x09, 0xaf);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_LAST_SCANLINE_END_TIME_QPC = new Guid(0xdccadecb, 0xc4d4, 0x400d, 0xb4, 0x18, 0x10, 0xe8, 0x85, 0x25, 0xe1, 0xf6);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_SCANLINE_TIME_QPC_ACCURACY = new Guid(0x4cd79c51, 0xf765, 0x4b09, 0xb1, 0xe1, 0x27, 0xd1, 0xf7, 0xeb, 0xea, 0x09);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_CAPTURE_METADATA_SCANLINE_DIRECTION = new Guid(0x6496a3ba, 0x1907, 0x49e6, 0xb0, 0xc3, 0x12, 0x37, 0x95, 0xf3, 0x80, 0xa9);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAttributes([NativeTypeName("IMFAttributes **")] IMFAttributes** ppMFAttributes, [NativeTypeName("UINT32")] uint cInitialSize);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitAttributesFromBlob([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT")] uint cbBufSize);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetAttributesAsBlobSize([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("UINT32 *")] uint* pcbBufSize);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetAttributesAsBlob([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT")] uint cbBufSize);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_CATEGORY_VIDEO_DECODER = new Guid(0xd6c02d4b, 0x6833, 0x45b4, 0x97, 0x1a, 0x05, 0xa4, 0xb0, 0x4b, 0xab, 0x91);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_CATEGORY_VIDEO_ENCODER = new Guid(0xf79eac7d, 0xe545, 0x4387, 0xbd, 0xee, 0xd6, 0x47, 0xd7, 0xbd, 0xe4, 0x2a);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_CATEGORY_VIDEO_EFFECT = new Guid(0x12e17c21, 0x532c, 0x4a6e, 0x8a, 0x1c, 0x40, 0x82, 0x5a, 0x73, 0x63, 0x97);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_CATEGORY_MULTIPLEXER = new Guid(0x059c561e, 0x05ae, 0x4b61, 0xb6, 0x9d, 0x55, 0xb6, 0x1e, 0xe5, 0x4a, 0x7b);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_CATEGORY_DEMULTIPLEXER = new Guid(0xa8700a7a, 0x939b, 0x44c5, 0x99, 0xd7, 0x76, 0x22, 0x6b, 0x23, 0xb3, 0xf1);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_CATEGORY_AUDIO_DECODER = new Guid(0x9ea73fb4, 0xef7a, 0x4559, 0x8d, 0x5d, 0x71, 0x9d, 0x8f, 0x04, 0x26, 0xc7);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_CATEGORY_AUDIO_ENCODER = new Guid(0x91c64bd0, 0xf91e, 0x4d8c, 0x92, 0x76, 0xdb, 0x24, 0x82, 0x79, 0xd9, 0x75);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_CATEGORY_AUDIO_EFFECT = new Guid(0x11064c48, 0x3648, 0x4ed0, 0x93, 0x2e, 0x05, 0xce, 0x8a, 0xc8, 0x11, 0xb7);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_CATEGORY_VIDEO_PROCESSOR = new Guid(0x302ea3fc, 0xaa5f, 0x47f9, 0x9f, 0x7a, 0xc2, 0x18, 0x8b, 0xb1, 0x63, 0x2);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_CATEGORY_OTHER = new Guid(0x90175d57, 0xb7ea, 0x4901, 0xae, 0xb3, 0x93, 0x3a, 0x87, 0x47, 0x75, 0x6f);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_CATEGORY_ENCRYPTOR = new Guid(0xb0c687be, 0x01cd, 0x44b5, 0xb8, 0xb2, 0x7c, 0x1d, 0x7e, 0x05, 0x8b, 0x1f);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_CATEGORY_VIDEO_RENDERER_EFFECT = new Guid(0x145cd8b4, 0x92f4, 0x4b23, 0x8a, 0xe7, 0xe0, 0xdf, 0x6, 0xc2, 0xda, 0x95);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTRegister([NativeTypeName("CLSID")] Guid clsidMFT, [NativeTypeName("GUID")] Guid guidCategory, [NativeTypeName("LPWSTR")] ushort* pszName, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("UINT32")] uint cInputTypes, [NativeTypeName("MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputTypes, [NativeTypeName("UINT32")] uint cOutputTypes, [NativeTypeName("MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputTypes, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTUnregister([NativeTypeName("CLSID")] Guid clsidMFT);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTRegisterLocal([NativeTypeName("IClassFactory *")] IClassFactory* pClassFactory, [NativeTypeName("const GUID &")] Guid* guidCategory, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("UINT32")] uint cInputTypes, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputTypes, [NativeTypeName("UINT32")] uint cOutputTypes, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputTypes);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTUnregisterLocal([NativeTypeName("IClassFactory *")] IClassFactory* pClassFactory);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTRegisterLocalByCLSID([NativeTypeName("const IID &")] Guid* clisdMFT, [NativeTypeName("const GUID &")] Guid* guidCategory, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("UINT32")] uint cInputTypes, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputTypes, [NativeTypeName("UINT32")] uint cOutputTypes, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputTypes);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTUnregisterLocalByCLSID([NativeTypeName("CLSID")] Guid clsidMFT);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTEnum([NativeTypeName("GUID")] Guid guidCategory, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputType, [NativeTypeName("MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputType, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("CLSID **")] Guid** ppclsidMFT, [NativeTypeName("UINT32 *")] uint* pcMFTs);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTEnumEx([NativeTypeName("GUID")] Guid guidCategory, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputType, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputType, [NativeTypeName("IMFActivate ***")] IMFActivate*** pppMFTActivate, [NativeTypeName("UINT32 *")] uint* pnumMFTActivate);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_ENUM_VIDEO_RENDERER_EXTENSION_PROFILE = new Guid(0x62c56928, 0x9a4e, 0x443b, 0xb9, 0xdc, 0xca, 0xc8, 0x30, 0xc2, 0x41, 0x0);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_ENUM_ADAPTER_LUID = new Guid(0x1d39518c, 0xe220, 0x4da8, 0xa0, 0x7f, 0xba, 0x17, 0x25, 0x52, 0xd6, 0xb1);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTEnum2([NativeTypeName("GUID")] Guid guidCategory, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputType, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputType, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFActivate ***")] IMFActivate*** pppMFTActivate, [NativeTypeName("UINT32 *")] uint* pnumMFTActivate);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTGetInfo([NativeTypeName("CLSID")] Guid clsidMFT, [NativeTypeName("LPWSTR *")] ushort** pszName, [NativeTypeName("MFT_REGISTER_TYPE_INFO **")] MFT_REGISTER_TYPE_INFO** ppInputTypes, [NativeTypeName("UINT32 *")] uint* pcInputTypes, [NativeTypeName("MFT_REGISTER_TYPE_INFO **")] MFT_REGISTER_TYPE_INFO** ppOutputTypes, [NativeTypeName("UINT32 *")] uint* pcOutputTypes, [NativeTypeName("IMFAttributes **")] IMFAttributes** ppAttributes);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetPluginControl([NativeTypeName("IMFPluginControl **")] IMFPluginControl** ppPluginControl);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetMFTMerit([NativeTypeName("IUnknown *")] IUnknown* pMFT, [NativeTypeName("UINT32")] uint cbVerifier, [NativeTypeName("const BYTE *")] byte* verifier, [NativeTypeName("DWORD *")] uint* merit);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRegisterLocalSchemeHandler([NativeTypeName("PCWSTR")] ushort* szScheme, [NativeTypeName("IMFActivate *")] IMFActivate* pActivate);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRegisterLocalByteStreamHandler([NativeTypeName("PCWSTR")] ushort* szFileExtension, [NativeTypeName("PCWSTR")] ushort* szMimeType, [NativeTypeName("IMFActivate *")] IMFActivate* pActivate);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMFByteStreamWrapper([NativeTypeName("IMFByteStream *")] IMFByteStream* pStream, [NativeTypeName("IMFByteStream **")] IMFByteStream** ppStreamWrapper);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaExtensionActivate([NativeTypeName("PCWSTR")] ushort* szActivatableClassId, [NativeTypeName("IUnknown *")] IUnknown* pConfiguration, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFT_SUPPORT_DYNAMIC_FORMAT_CHANGE = new Guid(0x53476a11, 0x3f13, 0x49fb, 0xac, 0x42, 0xee, 0x27, 0x33, 0xc9, 0x67, 0x41);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_Base = new Guid(0x00000000, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_RGB32 = new Guid(22, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_ARGB32 = new Guid(21, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_RGB24 = new Guid(20, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_RGB555 = new Guid(24, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_RGB565 = new Guid(23, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_RGB8 = new Guid(41, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_L8 = new Guid(50, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_L16 = new Guid(81, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_D16 = new Guid(80, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_AI44 = new Guid(((((uint)(0x41493434) & 0xFF) << 24) | (((uint)(0x41493434) & 0xFF00) << 8) | (((uint)(0x41493434) & 0xFF0000) >> 8) | (((uint)(0x41493434) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_AYUV = new Guid(((((uint)(0x41595556) & 0xFF) << 24) | (((uint)(0x41595556) & 0xFF00) << 8) | (((uint)(0x41595556) & 0xFF0000) >> 8) | (((uint)(0x41595556) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_YUY2 = new Guid(((((uint)(0x59555932) & 0xFF) << 24) | (((uint)(0x59555932) & 0xFF00) << 8) | (((uint)(0x59555932) & 0xFF0000) >> 8) | (((uint)(0x59555932) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_YVYU = new Guid(((((uint)(0x59565955) & 0xFF) << 24) | (((uint)(0x59565955) & 0xFF00) << 8) | (((uint)(0x59565955) & 0xFF0000) >> 8) | (((uint)(0x59565955) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_YVU9 = new Guid(((((uint)(0x59565539) & 0xFF) << 24) | (((uint)(0x59565539) & 0xFF00) << 8) | (((uint)(0x59565539) & 0xFF0000) >> 8) | (((uint)(0x59565539) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_UYVY = new Guid(((((uint)(0x55595659) & 0xFF) << 24) | (((uint)(0x55595659) & 0xFF00) << 8) | (((uint)(0x55595659) & 0xFF0000) >> 8) | (((uint)(0x55595659) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_NV11 = new Guid(((((uint)(0x4E563131) & 0xFF) << 24) | (((uint)(0x4E563131) & 0xFF00) << 8) | (((uint)(0x4E563131) & 0xFF0000) >> 8) | (((uint)(0x4E563131) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_NV12 = new Guid(((((uint)(0x4E563132) & 0xFF) << 24) | (((uint)(0x4E563132) & 0xFF00) << 8) | (((uint)(0x4E563132) & 0xFF0000) >> 8) | (((uint)(0x4E563132) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_YV12 = new Guid(((((uint)(0x59563132) & 0xFF) << 24) | (((uint)(0x59563132) & 0xFF00) << 8) | (((uint)(0x59563132) & 0xFF0000) >> 8) | (((uint)(0x59563132) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_I420 = new Guid(((((uint)(0x49343230) & 0xFF) << 24) | (((uint)(0x49343230) & 0xFF00) << 8) | (((uint)(0x49343230) & 0xFF0000) >> 8) | (((uint)(0x49343230) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_IYUV = new Guid(((((uint)(0x49595556) & 0xFF) << 24) | (((uint)(0x49595556) & 0xFF00) << 8) | (((uint)(0x49595556) & 0xFF0000) >> 8) | (((uint)(0x49595556) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_Y210 = new Guid(((((uint)(0x59323130) & 0xFF) << 24) | (((uint)(0x59323130) & 0xFF00) << 8) | (((uint)(0x59323130) & 0xFF0000) >> 8) | (((uint)(0x59323130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_Y216 = new Guid(((((uint)(0x59323136) & 0xFF) << 24) | (((uint)(0x59323136) & 0xFF00) << 8) | (((uint)(0x59323136) & 0xFF0000) >> 8) | (((uint)(0x59323136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_Y410 = new Guid(((((uint)(0x59343130) & 0xFF) << 24) | (((uint)(0x59343130) & 0xFF00) << 8) | (((uint)(0x59343130) & 0xFF0000) >> 8) | (((uint)(0x59343130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_Y416 = new Guid(((((uint)(0x59343136) & 0xFF) << 24) | (((uint)(0x59343136) & 0xFF00) << 8) | (((uint)(0x59343136) & 0xFF0000) >> 8) | (((uint)(0x59343136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_Y41P = new Guid(((((uint)(0x59343150) & 0xFF) << 24) | (((uint)(0x59343150) & 0xFF00) << 8) | (((uint)(0x59343150) & 0xFF0000) >> 8) | (((uint)(0x59343150) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_Y41T = new Guid(((((uint)(0x59343154) & 0xFF) << 24) | (((uint)(0x59343154) & 0xFF00) << 8) | (((uint)(0x59343154) & 0xFF0000) >> 8) | (((uint)(0x59343154) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_Y42T = new Guid(((((uint)(0x59343254) & 0xFF) << 24) | (((uint)(0x59343254) & 0xFF00) << 8) | (((uint)(0x59343254) & 0xFF0000) >> 8) | (((uint)(0x59343254) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_P210 = new Guid(((((uint)(0x50323130) & 0xFF) << 24) | (((uint)(0x50323130) & 0xFF00) << 8) | (((uint)(0x50323130) & 0xFF0000) >> 8) | (((uint)(0x50323130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_P216 = new Guid(((((uint)(0x50323136) & 0xFF) << 24) | (((uint)(0x50323136) & 0xFF00) << 8) | (((uint)(0x50323136) & 0xFF0000) >> 8) | (((uint)(0x50323136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_P010 = new Guid(((((uint)(0x50303130) & 0xFF) << 24) | (((uint)(0x50303130) & 0xFF00) << 8) | (((uint)(0x50303130) & 0xFF0000) >> 8) | (((uint)(0x50303130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_P016 = new Guid(((((uint)(0x50303136) & 0xFF) << 24) | (((uint)(0x50303136) & 0xFF00) << 8) | (((uint)(0x50303136) & 0xFF0000) >> 8) | (((uint)(0x50303136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_v210 = new Guid(((((uint)(0x76323130) & 0xFF) << 24) | (((uint)(0x76323130) & 0xFF00) << 8) | (((uint)(0x76323130) & 0xFF0000) >> 8) | (((uint)(0x76323130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_v216 = new Guid(((((uint)(0x76323136) & 0xFF) << 24) | (((uint)(0x76323136) & 0xFF00) << 8) | (((uint)(0x76323136) & 0xFF0000) >> 8) | (((uint)(0x76323136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_v410 = new Guid(((((uint)(0x76343130) & 0xFF) << 24) | (((uint)(0x76343130) & 0xFF00) << 8) | (((uint)(0x76343130) & 0xFF0000) >> 8) | (((uint)(0x76343130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_MP43 = new Guid(((((uint)(0x4D503433) & 0xFF) << 24) | (((uint)(0x4D503433) & 0xFF00) << 8) | (((uint)(0x4D503433) & 0xFF0000) >> 8) | (((uint)(0x4D503433) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_MP4S = new Guid(((((uint)(0x4D503453) & 0xFF) << 24) | (((uint)(0x4D503453) & 0xFF00) << 8) | (((uint)(0x4D503453) & 0xFF0000) >> 8) | (((uint)(0x4D503453) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_M4S2 = new Guid(((((uint)(0x4D345332) & 0xFF) << 24) | (((uint)(0x4D345332) & 0xFF00) << 8) | (((uint)(0x4D345332) & 0xFF0000) >> 8) | (((uint)(0x4D345332) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_MP4V = new Guid(((((uint)(0x4D503456) & 0xFF) << 24) | (((uint)(0x4D503456) & 0xFF00) << 8) | (((uint)(0x4D503456) & 0xFF0000) >> 8) | (((uint)(0x4D503456) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_WMV1 = new Guid(((((uint)(0x574D5631) & 0xFF) << 24) | (((uint)(0x574D5631) & 0xFF00) << 8) | (((uint)(0x574D5631) & 0xFF0000) >> 8) | (((uint)(0x574D5631) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_WMV2 = new Guid(((((uint)(0x574D5632) & 0xFF) << 24) | (((uint)(0x574D5632) & 0xFF00) << 8) | (((uint)(0x574D5632) & 0xFF0000) >> 8) | (((uint)(0x574D5632) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_WMV3 = new Guid(((((uint)(0x574D5633) & 0xFF) << 24) | (((uint)(0x574D5633) & 0xFF00) << 8) | (((uint)(0x574D5633) & 0xFF0000) >> 8) | (((uint)(0x574D5633) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_WVC1 = new Guid(((((uint)(0x57564331) & 0xFF) << 24) | (((uint)(0x57564331) & 0xFF00) << 8) | (((uint)(0x57564331) & 0xFF0000) >> 8) | (((uint)(0x57564331) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_MSS1 = new Guid(((((uint)(0x4D535331) & 0xFF) << 24) | (((uint)(0x4D535331) & 0xFF00) << 8) | (((uint)(0x4D535331) & 0xFF0000) >> 8) | (((uint)(0x4D535331) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_MSS2 = new Guid(((((uint)(0x4D535332) & 0xFF) << 24) | (((uint)(0x4D535332) & 0xFF00) << 8) | (((uint)(0x4D535332) & 0xFF0000) >> 8) | (((uint)(0x4D535332) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_MPG1 = new Guid(((((uint)(0x4D504731) & 0xFF) << 24) | (((uint)(0x4D504731) & 0xFF00) << 8) | (((uint)(0x4D504731) & 0xFF0000) >> 8) | (((uint)(0x4D504731) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_DVSL = new Guid(((((uint)(0x6476736C) & 0xFF) << 24) | (((uint)(0x6476736C) & 0xFF00) << 8) | (((uint)(0x6476736C) & 0xFF0000) >> 8) | (((uint)(0x6476736C) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_DVSD = new Guid(((((uint)(0x64767364) & 0xFF) << 24) | (((uint)(0x64767364) & 0xFF00) << 8) | (((uint)(0x64767364) & 0xFF0000) >> 8) | (((uint)(0x64767364) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_DVHD = new Guid(((((uint)(0x64766864) & 0xFF) << 24) | (((uint)(0x64766864) & 0xFF00) << 8) | (((uint)(0x64766864) & 0xFF0000) >> 8) | (((uint)(0x64766864) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_DV25 = new Guid(((((uint)(0x64763235) & 0xFF) << 24) | (((uint)(0x64763235) & 0xFF00) << 8) | (((uint)(0x64763235) & 0xFF0000) >> 8) | (((uint)(0x64763235) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_DV50 = new Guid(((((uint)(0x64763530) & 0xFF) << 24) | (((uint)(0x64763530) & 0xFF00) << 8) | (((uint)(0x64763530) & 0xFF0000) >> 8) | (((uint)(0x64763530) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_DVH1 = new Guid(((((uint)(0x64766831) & 0xFF) << 24) | (((uint)(0x64766831) & 0xFF00) << 8) | (((uint)(0x64766831) & 0xFF0000) >> 8) | (((uint)(0x64766831) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_DVC = new Guid(((((uint)(0x64766320) & 0xFF) << 24) | (((uint)(0x64766320) & 0xFF00) << 8) | (((uint)(0x64766320) & 0xFF0000) >> 8) | (((uint)(0x64766320) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_H264 = new Guid(((((uint)(0x48323634) & 0xFF) << 24) | (((uint)(0x48323634) & 0xFF00) << 8) | (((uint)(0x48323634) & 0xFF0000) >> 8) | (((uint)(0x48323634) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_H265 = new Guid(((((uint)(0x48323635) & 0xFF) << 24) | (((uint)(0x48323635) & 0xFF00) << 8) | (((uint)(0x48323635) & 0xFF0000) >> 8) | (((uint)(0x48323635) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_MJPG = new Guid(((((uint)(0x4D4A5047) & 0xFF) << 24) | (((uint)(0x4D4A5047) & 0xFF00) << 8) | (((uint)(0x4D4A5047) & 0xFF0000) >> 8) | (((uint)(0x4D4A5047) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_420O = new Guid(((((uint)(0x3432304F) & 0xFF) << 24) | (((uint)(0x3432304F) & 0xFF00) << 8) | (((uint)(0x3432304F) & 0xFF0000) >> 8) | (((uint)(0x3432304F) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_HEVC = new Guid(((((uint)(0x48455643) & 0xFF) << 24) | (((uint)(0x48455643) & 0xFF00) << 8) | (((uint)(0x48455643) & 0xFF0000) >> 8) | (((uint)(0x48455643) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_HEVC_ES = new Guid(((((uint)(0x48455653) & 0xFF) << 24) | (((uint)(0x48455653) & 0xFF00) << 8) | (((uint)(0x48455653) & 0xFF0000) >> 8) | (((uint)(0x48455653) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_VP80 = new Guid(((((uint)(0x56503830) & 0xFF) << 24) | (((uint)(0x56503830) & 0xFF00) << 8) | (((uint)(0x56503830) & 0xFF0000) >> 8) | (((uint)(0x56503830) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_VP90 = new Guid(((((uint)(0x56503930) & 0xFF) << 24) | (((uint)(0x56503930) & 0xFF00) << 8) | (((uint)(0x56503930) & 0xFF0000) >> 8) | (((uint)(0x56503930) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_ORAW = new Guid(((((uint)(0x4F524157) & 0xFF) << 24) | (((uint)(0x4F524157) & 0xFF00) << 8) | (((uint)(0x4F524157) & 0xFF0000) >> 8) | (((uint)(0x4F524157) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_H263 = new Guid(((((uint)(0x48323633) & 0xFF) << 24) | (((uint)(0x48323633) & 0xFF00) << 8) | (((uint)(0x48323633) & 0xFF0000) >> 8) | (((uint)(0x48323633) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_A2R10G10B10 = new Guid(31, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_A16B16G16R16F = new Guid(113, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_VP10 = new Guid(((((uint)(0x56503130) & 0xFF) << 24) | (((uint)(0x56503130) & 0xFF00) << 8) | (((uint)(0x56503130) & 0xFF0000) >> 8) | (((uint)(0x56503130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_AV1 = new Guid(((((uint)(0x41563031) & 0xFF) << 24) | (((uint)(0x41563031) & 0xFF00) << 8) | (((uint)(0x41563031) & 0xFF0000) >> 8) | (((uint)(0x41563031) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_H264_ES = new Guid(0x3f40f4f0, 0x5622, 0x4ff8, 0xb6, 0xd8, 0xa1, 0x7a, 0x58, 0x4b, 0xee, 0x5e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_MPEG2 = new Guid(0xe06d8026, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_Base = new Guid(0x00000000, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_PCM = new Guid(1, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_Float = new Guid(0x0003, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_DTS = new Guid(0x0008, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_Dolby_AC3_SPDIF = new Guid(0x0092, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_DRM = new Guid(0x0009, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_WMAudioV8 = new Guid(0x0161, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_WMAudioV9 = new Guid(0x0162, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_WMAudio_Lossless = new Guid(0x0163, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_WMASPDIF = new Guid(0x0164, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_MSP1 = new Guid(0x000A, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_MP3 = new Guid(0x0055, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_MPEG = new Guid(0x0050, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_AAC = new Guid(0x1610, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_ADTS = new Guid(0x1600, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_AMR_NB = new Guid(0x7361, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_AMR_WB = new Guid(0x7362, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_AMR_WP = new Guid(0x7363, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_FLAC = new Guid(0xF1AC, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_ALAC = new Guid(0x6C61, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_Opus = new Guid(0x704F, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_Dolby_AC3 = new Guid(0xe06d802c, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x05f, 0x6c, 0xbb, 0xea);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_Dolby_DDPlus = new Guid(0xa7fb87af, 0x2d02, 0x42fb, 0xa4, 0xd4, 0x5, 0xcd, 0x93, 0x84, 0x3b, 0xdd);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_Vorbis = new Guid(0x8D2FD10B, 0x5841, 0x4a6b, 0x89, 0x05, 0x58, 0x8F, 0xEC, 0x1A, 0xDE, 0xD9);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_DTS_RAW = new Guid(0xE06D8033, 0xDB46, 0x11CF, 0xB4, 0xD1, 0x00, 0x80, 0x5F, 0x6C, 0xBB, 0xEA);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_DTS_HD = new Guid(0xA2E58EB7, 0x0FA9, 0x48BB, 0xA4, 0x0C, 0xFA, 0x0E, 0x15, 0x6D, 0x06, 0x45);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_DTS_XLL = new Guid(0x45B37C1B, 0x8C70, 0x4E59, 0xA7, 0xBE, 0xA1, 0xE4, 0x2C, 0x81, 0xC8, 0x0D);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_DTS_LBR = new Guid(0xC2FE6F0A, 0x4E3C, 0x4DF1, 0x9B, 0x60, 0x50, 0x86, 0x30, 0x91, 0xE4, 0xB9);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_DTS_UHD = new Guid(0x87020117, 0xACE3, 0x42DE, 0xB7, 0x3E, 0xC6, 0x56, 0x70, 0x62, 0x63, 0xF8);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_DTS_UHDY = new Guid(0x9B9CCA00, 0x91B9, 0x4CCC, 0x88, 0x3A, 0x8F, 0x78, 0x7A, 0xC3, 0xCC, 0x86);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_Float_SpatialObjects = new Guid(0xfa39cd94, 0xbc64, 0x4ab1, 0x9b, 0x71, 0xdc, 0xd0, 0x9d, 0x5a, 0x7e, 0x7a);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_LPCM = new Guid(0xe06d8032, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_PCM_HDCP = new Guid(0xa5e7ff01, 0x8411, 0x4acc, 0xa8, 0x65, 0x5f, 0x49, 0x41, 0x28, 0x8d, 0x80);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_Dolby_AC3_HDCP = new Guid(0x97663a80, 0x8ffb, 0x4445, 0xa6, 0xba, 0x79, 0x2d, 0x90, 0x8f, 0x49, 0x7f);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_AAC_HDCP = new Guid(0x419bce76, 0x8b72, 0x400f, 0xad, 0xeb, 0x84, 0xb5, 0x7d, 0x63, 0x48, 0x4d);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_ADTS_HDCP = new Guid(0xda4963a3, 0x14d8, 0x4dcf, 0x92, 0xb7, 0x19, 0x3e, 0xb8, 0x43, 0x63, 0xdb);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFAudioFormat_Base_HDCP = new Guid(0x3884b5bc, 0xe277, 0x43fd, 0x98, 0x3d, 0x03, 0x8a, 0xa8, 0xd9, 0xb6, 0x05);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_H264_HDCP = new Guid(0x5d0ce9dd, 0x9817, 0x49da, 0xbd, 0xfd, 0xf5, 0xf5, 0xb9, 0x8f, 0x18, 0xa6);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_HEVC_HDCP = new Guid(0x3cfe0fe6, 0x05c4, 0x47dc, 0x9d, 0x70, 0x4b, 0xdb, 0x29, 0x59, 0x72, 0x0f);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFVideoFormat_Base_HDCP = new Guid(0xeac3b9d5, 0xbd14, 0x4237, 0x8f, 0x1f, 0xba, 0xb4, 0x28, 0xe4, 0x93, 0x12);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMPEG4Format_Base = new Guid(0x00000000, 0x767a, 0x494d, 0xb4, 0x78, 0xf2, 0x9d, 0x25, 0xdc, 0x90, 0x37);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSubtitleFormat_XML = new Guid(0x2006f94f, 0x29ca, 0x4195, 0xb8, 0xdb, 0x00, 0xde, 0xd8, 0xff, 0x0c, 0x97);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSubtitleFormat_TTML = new Guid(0x73e73992, 0x9a10, 0x4356, 0x95, 0x57, 0x71, 0x94, 0xe9, 0x1e, 0x3e, 0x54);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSubtitleFormat_ATSC = new Guid(0x7fa7faa3, 0xfeae, 0x4e16, 0xae, 0xdf, 0x36, 0xb9, 0xac, 0xfb, 0xb0, 0x99);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSubtitleFormat_WebVTT = new Guid(0xc886d215, 0xf485, 0x40bb, 0x8d, 0xb6, 0xfa, 0xdb, 0xc6, 0x19, 0xa4, 0x5d);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSubtitleFormat_SRT = new Guid(0x5e467f2e, 0x77ca, 0x4ca5, 0x83, 0x91, 0xd1, 0x42, 0xed, 0x4b, 0x76, 0xc8);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSubtitleFormat_SSA = new Guid(0x57176a1b, 0x1a9e, 0x4eea, 0xab, 0xef, 0xc6, 0x17, 0x60, 0x19, 0x8a, 0xc4);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSubtitleFormat_CustomUserData = new Guid(0x1bb3d849, 0x6614, 0x4d80, 0x88, 0x82, 0xed, 0x24, 0xaa, 0x82, 0xda, 0x92);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSubtitleFormat_PGS = new Guid(0x71f40e4a, 0x1278, 0x4442, 0xb3, 0x0d, 0x39, 0xdd, 0x1d, 0x77, 0x22, 0xbc);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSubtitleFormat_VobSub = new Guid(0x6b8e40f4, 0x8d2c, 0x4ced, 0xad, 0x91, 0x59, 0x60, 0xe4, 0x5b, 0x44, 0x33);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFBinaryFormat_Base = new Guid(0x00000000, 0xbf10, 0x48b4, 0xbc, 0x18, 0x59, 0x3d, 0xc1, 0xdb, 0x95, 0xf);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFBinaryFormat_GPMD = new Guid(0x67706D64, 0xbf10, 0x48b4, 0xbc, 0x18, 0x59, 0x3d, 0xc1, 0xdb, 0x95, 0xf);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MAJOR_TYPE = new Guid(0x48eba18e, 0xf8c9, 0x4687, 0xbf, 0x11, 0x0a, 0x74, 0xc9, 0xf9, 0x6a, 0x8f);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_SUBTYPE = new Guid(0xf7e34c9a, 0x42e8, 0x4714, 0xb7, 0x4b, 0xcb, 0x29, 0xd7, 0x2c, 0x35, 0xe5);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_ALL_SAMPLES_INDEPENDENT = new Guid(0xc9173739, 0x5e56, 0x461c, 0xb7, 0x13, 0x46, 0xfb, 0x99, 0x5c, 0xb9, 0x5f);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_FIXED_SIZE_SAMPLES = new Guid(0xb8ebefaf, 0xb718, 0x4e04, 0xb0, 0xa9, 0x11, 0x67, 0x75, 0xe3, 0x32, 0x1b);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_COMPRESSED = new Guid(0x3afd0cee, 0x18f2, 0x4ba5, 0xa1, 0x10, 0x8b, 0xea, 0x50, 0x2e, 0x1f, 0x92);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_SAMPLE_SIZE = new Guid(0xdad3ab78, 0x1990, 0x408b, 0xbc, 0xe2, 0xeb, 0xa6, 0x73, 0xda, 0xcc, 0x10);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_WRAPPED_TYPE = new Guid(0x4d3f7b23, 0xd02f, 0x4e6c, 0x9b, 0xee, 0xe4, 0xbf, 0x2c, 0x6c, 0x69, 0x5d);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_3D = new Guid(0xcb5e88cf, 0x7b5b, 0x476b, 0x85, 0xaa, 0x1c, 0xa5, 0xae, 0x18, 0x75, 0x55);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_3D_FORMAT = new Guid(0x5315d8a0, 0x87c5, 0x4697, 0xb7, 0x93, 0x66, 0x6, 0xc6, 0x7c, 0x4, 0x9b);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_3D_NUM_VIEWS = new Guid(0xbb077e8a, 0xdcbf, 0x42eb, 0xaf, 0x60, 0x41, 0x8d, 0xf9, 0x8a, 0xa4, 0x95);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_3D_LEFT_IS_BASE = new Guid(0x6d4b7bff, 0x5629, 0x4404, 0x94, 0x8c, 0xc6, 0x34, 0xf4, 0xce, 0x26, 0xd4);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_3D_FIRST_IS_LEFT = new Guid(0xec298493, 0xada, 0x4ea1, 0xa4, 0xfe, 0xcb, 0xbd, 0x36, 0xce, 0x93, 0x31);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_3DVideo = new Guid(0xf86f97a4, 0xdd54, 0x4e2e, 0x9a, 0x5e, 0x55, 0xfc, 0x2d, 0x74, 0xa0, 0x05);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_3DVideo_SampleFormat = new Guid(0x8671772, 0xe36f, 0x4cff, 0x97, 0xb3, 0xd7, 0x2e, 0x20, 0x98, 0x7a, 0x48);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_ROTATION = new Guid(0xc380465d, 0x2271, 0x428c, 0x9b, 0x83, 0xec, 0xea, 0x3b, 0x4a, 0x85, 0xc1);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_DEVICESTREAM_MULTIPLEXED_MANAGER = new Guid(0x6ea542b0, 0x281f, 0x4231, 0xa4, 0x64, 0xfe, 0x2f, 0x50, 0x22, 0x50, 0x1c);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MEDIATYPE_MULTIPLEXED_MANAGER = new Guid(0x13c78fb5, 0xf275, 0x4ea0, 0xbb, 0x5f, 0x2, 0x49, 0x83, 0x2b, 0xd, 0x6e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_MULTIPLEXED_MANAGER = new Guid(0x8dcdee79, 0x6b5a, 0x4c45, 0x8d, 0xb9, 0x20, 0xb3, 0x95, 0xf0, 0x2f, 0xcf);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMuxStreamAttributes([NativeTypeName("IMFCollection *")] IMFCollection* pAttributesToMux, [NativeTypeName("IMFAttributes **")] IMFAttributes** ppMuxAttribs);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMuxStreamMediaType([NativeTypeName("IMFCollection *")] IMFCollection* pMediaTypesToMux, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMuxMediaType);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMuxStreamSample([NativeTypeName("IMFCollection *")] IMFCollection* pSamplesToMux, [NativeTypeName("IMFSample **")] IMFSample** ppMuxSample);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_SECURE = new Guid(0xc5acc4fd, 0x0304, 0x4ecf, 0x80, 0x9f, 0x47, 0xbc, 0x97, 0xff, 0x63, 0xbd);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_DEVICESTREAM_ATTRIBUTE_FRAMESOURCE_TYPES = new Guid(0x17145fd1, 0x1b2b, 0x423c, 0x80, 0x1, 0x2b, 0x68, 0x33, 0xed, 0x35, 0x88);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_ALPHA_MODE = new Guid(0x5D959B0D, 0x4CBF, 0x4D04, 0x91, 0x9F, 0x3F, 0x5F, 0x7F, 0x28, 0x42, 0x11);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_DEPTH_MEASUREMENT = new Guid(0xfd5ac489, 0x917, 0x4bb6, 0x9d, 0x54, 0x31, 0x22, 0xbf, 0x70, 0x14, 0x4b);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_DEPTH_VALUE_UNIT = new Guid(0x21a800f5, 0x3189, 0x4797, 0xbe, 0xba, 0xf1, 0x3c, 0xd9, 0xa3, 0x1a, 0x5e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_NO_FRAME_ORDERING = new Guid(0x3f5b106f, 0x6bc2, 0x4ee3, 0xb7, 0xed, 0x89, 0x2, 0xc1, 0x8f, 0x53, 0x51);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_H264_NO_FMOASO = new Guid(0xed461cd6, 0xec9f, 0x416a, 0xa8, 0xa3, 0x26, 0xd7, 0xd3, 0x10, 0x18, 0xd7);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_ForwardedDecodeUnits = new Guid(0x424c754c, 0x97c8, 0x48d6, 0x87, 0x77, 0xfc, 0x41, 0xf7, 0xb6, 0x8, 0x79);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_TargetGlobalLuminance = new Guid(0x3f60ef36, 0x31ef, 0x4daf, 0x83, 0x60, 0x94, 0x3, 0x97, 0xe4, 0x1e, 0xf3);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_ForwardedDecodeUnitType = new Guid(0x89e57c7, 0x47d3, 0x4a26, 0xbf, 0x9c, 0x4b, 0x64, 0xfa, 0xfb, 0x5d, 0x1e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_FORWARD_CUSTOM_NALU = new Guid(0xed336efd, 0x244f, 0x428d, 0x91, 0x53, 0x28, 0xf3, 0x99, 0x45, 0x88, 0x90);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_FORWARD_CUSTOM_SEI = new Guid(0xe27362f1, 0xb136, 0x41d1, 0x95, 0x94, 0x3a, 0x7e, 0x4f, 0xeb, 0xf2, 0xd1);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_RENDERER_EXTENSION_PROFILE = new Guid(0x8437d4b9, 0xd448, 0x4fcd, 0x9b, 0x6b, 0x83, 0x9b, 0xf9, 0x6c, 0x77, 0x98);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_DECODER_FWD_CUSTOM_SEI_DECODE_ORDER = new Guid(0xf13bbe3c, 0x36d4, 0x410a, 0xb9, 0x85, 0x7a, 0x95, 0x1a, 0x1e, 0x62, 0x94);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_VIDEO_RENDERER_EFFECT_APP_SERVICE_NAME = new Guid(0xc6052a80, 0x6d9c, 0x40a3, 0x9d, 0xb8, 0xf0, 0x27, 0xa2, 0x5c, 0x9a, 0xb9);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_NUM_CHANNELS = new Guid(0x37e48bf5, 0x645e, 0x4c5b, 0x89, 0xde, 0xad, 0xa9, 0xe2, 0x9b, 0x69, 0x6a);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_SAMPLES_PER_SECOND = new Guid(0x5faeeae7, 0x0290, 0x4c31, 0x9e, 0x8a, 0xc5, 0x34, 0xf6, 0x8d, 0x9d, 0xba);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_FLOAT_SAMPLES_PER_SECOND = new Guid(0xfb3b724a, 0xcfb5, 0x4319, 0xae, 0xfe, 0x6e, 0x42, 0xb2, 0x40, 0x61, 0x32);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_AVG_BYTES_PER_SECOND = new Guid(0x1aab75c8, 0xcfef, 0x451c, 0xab, 0x95, 0xac, 0x03, 0x4b, 0x8e, 0x17, 0x31);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_BLOCK_ALIGNMENT = new Guid(0x322de230, 0x9eeb, 0x43bd, 0xab, 0x7a, 0xff, 0x41, 0x22, 0x51, 0x54, 0x1d);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_BITS_PER_SAMPLE = new Guid(0xf2deb57f, 0x40fa, 0x4764, 0xaa, 0x33, 0xed, 0x4f, 0x2d, 0x1f, 0xf6, 0x69);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_VALID_BITS_PER_SAMPLE = new Guid(0xd9bf8d6a, 0x9530, 0x4b7c, 0x9d, 0xdf, 0xff, 0x6f, 0xd5, 0x8b, 0xbd, 0x06);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_SAMPLES_PER_BLOCK = new Guid(0xaab15aac, 0xe13a, 0x4995, 0x92, 0x22, 0x50, 0x1e, 0xa1, 0x5c, 0x68, 0x77);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_CHANNEL_MASK = new Guid(0x55fb5765, 0x644a, 0x4caf, 0x84, 0x79, 0x93, 0x89, 0x83, 0xbb, 0x15, 0x88);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_FOLDDOWN_MATRIX = new Guid(0x9d62927c, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_WMADRC_PEAKREF = new Guid(0x9d62927d, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_WMADRC_PEAKTARGET = new Guid(0x9d62927e, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_WMADRC_AVGREF = new Guid(0x9d62927f, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_WMADRC_AVGTARGET = new Guid(0x9d629280, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_PREFER_WAVEFORMATEX = new Guid(0xa901aaba, 0xe037, 0x458a, 0xbd, 0xf6, 0x54, 0x5b, 0xe2, 0x07, 0x40, 0x42);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AAC_PAYLOAD_TYPE = new Guid(0xbfbabe79, 0x7434, 0x4d1c, 0x94, 0xf0, 0x72, 0xa3, 0xb9, 0xe1, 0x71, 0x88);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AAC_AUDIO_PROFILE_LEVEL_INDICATION = new Guid(0x7632f0e6, 0x9538, 0x4d61, 0xac, 0xda, 0xea, 0x29, 0xc8, 0xc1, 0x44, 0x56);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AUDIO_FLAC_MAX_BLOCK_SIZE = new Guid(0x8b81adae, 0x4b5a, 0x4d40, 0x80, 0x22, 0xf3, 0x8d, 0x9, 0xca, 0x3c, 0x5c);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_SPATIAL_AUDIO_MAX_DYNAMIC_OBJECTS = new Guid(0xdcfba24a, 0x2609, 0x4240, 0xa7, 0x21, 0x3f, 0xae, 0xa7, 0x6a, 0x4d, 0xf9);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_SPATIAL_AUDIO_OBJECT_METADATA_FORMAT_ID = new Guid(0x2ab71bc0, 0x6223, 0x4ba7, 0xad, 0x64, 0x7b, 0x94, 0xb4, 0x7a, 0xe7, 0x92);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_SPATIAL_AUDIO_OBJECT_METADATA_LENGTH = new Guid(0x94ba8be, 0xd723, 0x489f, 0x92, 0xfa, 0x76, 0x67, 0x77, 0xb3, 0x47, 0x26);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_SPATIAL_AUDIO_MAX_METADATA_ITEMS = new Guid(0x11aa80b4, 0xe0da, 0x47c6, 0x80, 0x60, 0x96, 0xc1, 0x25, 0x9a, 0xe5, 0xd);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_SPATIAL_AUDIO_MIN_METADATA_ITEM_OFFSET_SPACING = new Guid(0x83e96ec9, 0x1184, 0x417e, 0x82, 0x54, 0x9f, 0x26, 0x91, 0x58, 0xfc, 0x6);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_SPATIAL_AUDIO_DATA_PRESENT = new Guid(0x6842f6e7, 0xd43e, 0x4ebb, 0x9c, 0x9c, 0xc9, 0x6f, 0x41, 0x78, 0x48, 0x63);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_FRAME_SIZE = new Guid(0x1652c33d, 0xd6b2, 0x4012, 0xb8, 0x34, 0x72, 0x03, 0x08, 0x49, 0xa3, 0x7d);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_FRAME_RATE = new Guid(0xc459a2e8, 0x3d2c, 0x4e44, 0xb1, 0x32, 0xfe, 0xe5, 0x15, 0x6c, 0x7b, 0xb0);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_PIXEL_ASPECT_RATIO = new Guid(0xc6376a1e, 0x8d0a, 0x4027, 0xbe, 0x45, 0x6d, 0x9a, 0x0a, 0xd3, 0x9b, 0xb6);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_DRM_FLAGS = new Guid(0x8772f323, 0x355a, 0x4cc7, 0xbb, 0x78, 0x6d, 0x61, 0xa0, 0x48, 0xae, 0x82);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_TIMESTAMP_CAN_BE_DTS = new Guid(0x24974215, 0x1b7b, 0x41e4, 0x86, 0x25, 0xac, 0x46, 0x9f, 0x2d, 0xed, 0xaa);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_PAD_CONTROL_FLAGS = new Guid(0x4d0e73e5, 0x80ea, 0x4354, 0xa9, 0xd0, 0x11, 0x76, 0xce, 0xb0, 0x28, 0xea);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_SOURCE_CONTENT_HINT = new Guid(0x68aca3cc, 0x22d0, 0x44e6, 0x85, 0xf8, 0x28, 0x16, 0x71, 0x97, 0xfa, 0x38);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_CHROMA_SITING = new Guid(0x65df2370, 0xc773, 0x4c33, 0xaa, 0x64, 0x84, 0x3e, 0x06, 0x8e, 0xfb, 0x0c);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_INTERLACE_MODE = new Guid(0xe2724bb8, 0xe676, 0x4806, 0xb4, 0xb2, 0xa8, 0xd6, 0xef, 0xb4, 0x4c, 0xcd);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_TRANSFER_FUNCTION = new Guid(0x5fb0fce9, 0xbe5c, 0x4935, 0xa8, 0x11, 0xec, 0x83, 0x8f, 0x8e, 0xed, 0x93);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_PRIMARIES = new Guid(0xdbfbe4d7, 0x0740, 0x4ee0, 0x81, 0x92, 0x85, 0x0a, 0xb0, 0xe2, 0x19, 0x35);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MAX_LUMINANCE_LEVEL = new Guid(0x50253128, 0xc110, 0x4de4, 0x98, 0xae, 0x46, 0xa3, 0x24, 0xfa, 0xe6, 0xda);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MAX_FRAME_AVERAGE_LUMINANCE_LEVEL = new Guid(0x58d4bf57, 0x6f52, 0x4733, 0xa1, 0x95, 0xa9, 0xe2, 0x9e, 0xcf, 0x9e, 0x27);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MAX_MASTERING_LUMINANCE = new Guid(0xd6c6b997, 0x272f, 0x4ca1, 0x8d, 0x0, 0x80, 0x42, 0x11, 0x1a, 0xf, 0xf6);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MIN_MASTERING_LUMINANCE = new Guid(0x839a4460, 0x4e7e, 0x4b4f, 0xae, 0x79, 0xcc, 0x8, 0x90, 0x5c, 0x7b, 0x27);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_DECODER_USE_MAX_RESOLUTION = new Guid(0x4c547c24, 0xaf9a, 0x4f38, 0x96, 0xad, 0x97, 0x87, 0x73, 0xcf, 0x53, 0xe7);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_DECODER_MAX_DPB_COUNT = new Guid(0x67be144c, 0x88b7, 0x4ca9, 0x96, 0x28, 0xc8, 0x8, 0xd5, 0x26, 0x22, 0x17);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_CUSTOM_VIDEO_PRIMARIES = new Guid(0x47537213, 0x8cfb, 0x4722, 0xaa, 0x34, 0xfb, 0xc9, 0xe2, 0x4d, 0x77, 0xb8);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_YUV_MATRIX = new Guid(0x3e23d450, 0x2c75, 0x4d25, 0xa0, 0x0e, 0xb9, 0x16, 0x70, 0xd1, 0x23, 0x27);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_LIGHTING = new Guid(0x53a0529c, 0x890b, 0x4216, 0x8b, 0xf9, 0x59, 0x93, 0x67, 0xad, 0x6d, 0x20);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_NOMINAL_RANGE = new Guid(0xc21b8ee5, 0xb956, 0x4071, 0x8d, 0xaf, 0x32, 0x5e, 0xdf, 0x5c, 0xab, 0x11);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_GEOMETRIC_APERTURE = new Guid(0x66758743, 0x7e5f, 0x400d, 0x98, 0x0a, 0xaa, 0x85, 0x96, 0xc8, 0x56, 0x96);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MINIMUM_DISPLAY_APERTURE = new Guid(0xd7388766, 0x18fe, 0x48c6, 0xa1, 0x77, 0xee, 0x89, 0x48, 0x67, 0xc8, 0xc4);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_PAN_SCAN_APERTURE = new Guid(0x79614dde, 0x9187, 0x48fb, 0xb8, 0xc7, 0x4d, 0x52, 0x68, 0x9d, 0xe6, 0x49);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_PAN_SCAN_ENABLED = new Guid(0x4b7f6bc3, 0x8b13, 0x40b2, 0xa9, 0x93, 0xab, 0xf6, 0x30, 0xb8, 0x20, 0x4e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AVG_BITRATE = new Guid(0x20332624, 0xfb0d, 0x4d9e, 0xbd, 0x0d, 0xcb, 0xf6, 0x78, 0x6c, 0x10, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AVG_BIT_ERROR_RATE = new Guid(0x799cabd6, 0x3508, 0x4db4, 0xa3, 0xc7, 0x56, 0x9c, 0xd5, 0x33, 0xde, 0xb1);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MAX_KEYFRAME_SPACING = new Guid(0xc16eb52b, 0x73a1, 0x476f, 0x8d, 0x62, 0x83, 0x9d, 0x6a, 0x02, 0x06, 0x52);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_USER_DATA = new Guid(0xb6bc765f, 0x4c3b, 0x40a4, 0xbd, 0x51, 0x25, 0x35, 0xb6, 0x6f, 0xe0, 0x9d);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_OUTPUT_BUFFER_NUM = new Guid(0xa505d3ac, 0xf930, 0x436e, 0x8e, 0xde, 0x93, 0xa5, 0x09, 0xce, 0x23, 0xb2);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_REALTIME_CONTENT = new Guid(0xbb12d222, 0x2bdb, 0x425e, 0x91, 0xec, 0x23, 0x08, 0xe1, 0x89, 0xa5, 0x8f);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_DEFAULT_STRIDE = new Guid(0x644b4e48, 0x1e02, 0x4516, 0xb0, 0xeb, 0xc0, 0x1c, 0xa9, 0xd4, 0x9a, 0xc6);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_PALETTE = new Guid(0x6d283f42, 0x9846, 0x4410, 0xaf, 0xd9, 0x65, 0x4d, 0x50, 0x3b, 0x1a, 0x54);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_AM_FORMAT_TYPE = new Guid(0x73d1072d, 0x1870, 0x4174, 0xa0, 0x63, 0x29, 0xff, 0x4f, 0xf6, 0xc1, 0x1e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_PROFILE = new Guid(0xad76a80b, 0x2d5c, 0x4e0b, 0xb3, 0x75, 0x64, 0xe5, 0x20, 0x13, 0x70, 0x36);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_VIDEO_LEVEL = new Guid(0x96f66574, 0x11c5, 0x4015, 0x86, 0x66, 0xbf, 0xf5, 0x16, 0x43, 0x6d, 0xa7);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MPEG_START_TIME_CODE = new Guid(0x91f67885, 0x4333, 0x4280, 0x97, 0xcd, 0xbd, 0x5a, 0x6c, 0x03, 0xa0, 0x6e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MPEG2_PROFILE = new Guid(0xad76a80b, 0x2d5c, 0x4e0b, 0xb3, 0x75, 0x64, 0xe5, 0x20, 0x13, 0x70, 0x36);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MPEG2_LEVEL = new Guid(0x96f66574, 0x11c5, 0x4015, 0x86, 0x66, 0xbf, 0xf5, 0x16, 0x43, 0x6d, 0xa7);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MPEG2_FLAGS = new Guid(0x31e3991d, 0xf701, 0x4b2f, 0xb4, 0x26, 0x8a, 0xe3, 0xbd, 0xa9, 0xe0, 0x4b);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MPEG_SEQUENCE_HEADER = new Guid(0x3c036de7, 0x3ad0, 0x4c9e, 0x92, 0x16, 0xee, 0x6d, 0x6a, 0xc2, 0x1c, 0xb3);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MPEG2_STANDARD = new Guid(0xa20af9e8, 0x928a, 0x4b26, 0xaa, 0xa9, 0xf0, 0x5c, 0x74, 0xca, 0xc4, 0x7c);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MPEG2_TIMECODE = new Guid(0x5229ba10, 0xe29d, 0x4f80, 0xa5, 0x9c, 0xdf, 0x4f, 0x18, 0x2, 0x7, 0xd2);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MPEG2_CONTENT_PACKET = new Guid(0x825d55e4, 0x4f12, 0x4197, 0x9e, 0xb3, 0x59, 0xb6, 0xe4, 0x71, 0xf, 0x6);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MPEG2_ONE_FRAME_PER_PACKET = new Guid(0x91a49eb5, 0x1d20, 0x4b42, 0xac, 0xe8, 0x80, 0x42, 0x69, 0xbf, 0x95, 0xed);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MPEG2_HDCP = new Guid(0x168f1b4a, 0x3e91, 0x450f, 0xae, 0xa7, 0xe4, 0xba, 0xea, 0xda, 0xe5, 0xba);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_H264_MAX_CODEC_CONFIG_DELAY = new Guid(0xf5929986, 0x4c45, 0x4fbb, 0xbb, 0x49, 0x6c, 0xc5, 0x34, 0xd0, 0x5b, 0x9b);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_H264_SUPPORTED_SLICE_MODES = new Guid(0xc8be1937, 0x4d64, 0x4549, 0x83, 0x43, 0xa8, 0x8, 0x6c, 0xb, 0xfd, 0xa5);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_H264_SUPPORTED_SYNC_FRAME_TYPES = new Guid(0x89a52c01, 0xf282, 0x48d2, 0xb5, 0x22, 0x22, 0xe6, 0xae, 0x63, 0x31, 0x99);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_H264_RESOLUTION_SCALING = new Guid(0xe3854272, 0xf715, 0x4757, 0xba, 0x90, 0x1b, 0x69, 0x6c, 0x77, 0x34, 0x57);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_H264_SIMULCAST_SUPPORT = new Guid(0x9ea2d63d, 0x53f0, 0x4a34, 0xb9, 0x4e, 0x9d, 0xe4, 0x9a, 0x7, 0x8c, 0xb3);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_H264_SUPPORTED_RATE_CONTROL_MODES = new Guid(0x6a8ac47e, 0x519c, 0x4f18, 0x9b, 0xb3, 0x7e, 0xea, 0xae, 0xa5, 0x59, 0x4d);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_H264_MAX_MB_PER_SEC = new Guid(0x45256d30, 0x7215, 0x4576, 0x93, 0x36, 0xb0, 0xf1, 0xbc, 0xd5, 0x9b, 0xb2);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_H264_SUPPORTED_USAGES = new Guid(0x60b1a998, 0xdc01, 0x40ce, 0x97, 0x36, 0xab, 0xa8, 0x45, 0xa2, 0xdb, 0xdc);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_H264_CAPABILITIES = new Guid(0xbb3bd508, 0x490a, 0x11e0, 0x99, 0xe4, 0x13, 0x16, 0xdf, 0xd7, 0x20, 0x85);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_H264_SVC_CAPABILITIES = new Guid(0xf8993abe, 0xd937, 0x4a8f, 0xbb, 0xca, 0x69, 0x66, 0xfe, 0x9e, 0x11, 0x52);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_H264_USAGE = new Guid(0x359ce3a5, 0xaf00, 0x49ca, 0xa2, 0xf4, 0x2a, 0xc9, 0x4c, 0xa8, 0x2b, 0x61);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_H264_RATE_CONTROL_MODES = new Guid(0x705177d8, 0x45cb, 0x11e0, 0xac, 0x7d, 0xb9, 0x1c, 0xe0, 0xd7, 0x20, 0x85);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_H264_LAYOUT_PER_STREAM = new Guid(0x85e299b2, 0x90e3, 0x4fe8, 0xb2, 0xf5, 0xc0, 0x67, 0xe0, 0xbf, 0xe5, 0x7a);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_IN_BAND_PARAMETER_SET = new Guid(0x75da5090, 0x910b, 0x4a03, 0x89, 0x6c, 0x7b, 0x89, 0x8f, 0xee, 0xa5, 0xaf);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MPEG4_TRACK_TYPE = new Guid(0x54f486dd, 0x9327, 0x4f6d, 0x80, 0xab, 0x6f, 0x70, 0x9e, 0xbb, 0x4c, 0xce);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_CONTAINER_RATE_SCALING = new Guid(0x83877f5e, 0x444, 0x4e28, 0x84, 0x79, 0x6d, 0xb0, 0x98, 0x9b, 0x8c, 0x9);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_DV_AAUX_SRC_PACK_0 = new Guid(0x84bd5d88, 0x0fb8, 0x4ac8, 0xbe, 0x4b, 0xa8, 0x84, 0x8b, 0xef, 0x98, 0xf3);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_DV_AAUX_CTRL_PACK_0 = new Guid(0xf731004e, 0x1dd1, 0x4515, 0xaa, 0xbe, 0xf0, 0xc0, 0x6a, 0xa5, 0x36, 0xac);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_DV_AAUX_SRC_PACK_1 = new Guid(0x720e6544, 0x0225, 0x4003, 0xa6, 0x51, 0x01, 0x96, 0x56, 0x3a, 0x95, 0x8e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_DV_AAUX_CTRL_PACK_1 = new Guid(0xcd1f470d, 0x1f04, 0x4fe0, 0xbf, 0xb9, 0xd0, 0x7a, 0xe0, 0x38, 0x6a, 0xd8);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_DV_VAUX_SRC_PACK = new Guid(0x41402d9d, 0x7b57, 0x43c6, 0xb1, 0x29, 0x2c, 0xb9, 0x97, 0xf1, 0x50, 0x09);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_DV_VAUX_CTRL_PACK = new Guid(0x2f84e1c4, 0x0da1, 0x4788, 0x93, 0x8e, 0x0d, 0xfb, 0xfb, 0xb3, 0x4b, 0x48);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_ARBITRARY_HEADER = new Guid(0x9e6bd6f5, 0x109, 0x4f95, 0x84, 0xac, 0x93, 0x9, 0x15, 0x3a, 0x19, 0xfc);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_ARBITRARY_FORMAT = new Guid(0x5a75b249, 0xd7d, 0x49a1, 0xa1, 0xc3, 0xe0, 0xd8, 0x7f, 0xc, 0xad, 0xe5);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_IMAGE_LOSS_TOLERANT = new Guid(0xed062cf4, 0xe34e, 0x4922, 0xbe, 0x99, 0x93, 0x40, 0x32, 0x13, 0x3d, 0x7c);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MPEG4_SAMPLE_DESCRIPTION = new Guid(0x261e9d83, 0x9529, 0x4b8f, 0xa1, 0x11, 0x8b, 0x9c, 0x95, 0x0a, 0x81, 0xa9);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_MPEG4_CURRENT_SAMPLE_ENTRY = new Guid(0x9aa7e155, 0xb64a, 0x4c1d, 0xa5, 0x00, 0x45, 0x5d, 0x60, 0x0b, 0x65, 0x60);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_SD_AMBISONICS_SAMPLE3D_DESCRIPTION = new Guid(0xf715cf3e, 0xa964, 0x4c3f, 0x94, 0xae, 0x9d, 0x6b, 0xa7, 0x26, 0x46, 0x41);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_ORIGINAL_4CC = new Guid(0xd7be3fe0, 0x2bc7, 0x492d, 0xb8, 0x43, 0x61, 0xa1, 0x91, 0x9b, 0x70, 0xc3);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_ORIGINAL_WAVE_FORMAT_TAG = new Guid(0x8cbbc843, 0x9fd9, 0x49c2, 0x88, 0x2f, 0xa7, 0x25, 0x86, 0xc4, 0x08, 0xad);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_FRAME_RATE_RANGE_MIN = new Guid(0xd2e7558c, 0xdc1f, 0x403f, 0x9a, 0x72, 0xd2, 0x8b, 0xb1, 0xeb, 0x3b, 0x5e);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_MT_FRAME_RATE_RANGE_MAX = new Guid(0xe3371d41, 0xb4cf, 0x4a05, 0xbd, 0x4e, 0x20, 0xb8, 0x8b, 0xb2, 0xc4, 0xd6);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_LOW_LATENCY = new Guid(0x9c27891a, 0xed7a, 0x40e1, 0x88, 0xe8, 0xb2, 0x27, 0x27, 0xa0, 0x24, 0xee);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_VIDEO_MAX_MB_PER_SEC = new Guid(0xe3f2e203, 0xd445, 0x4b8c, 0x92, 0x11, 0xae, 0x39, 0xd, 0x3b, 0xa0, 0x17);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_DISABLE_FRAME_CORRUPTION_INFO = new Guid(0x7086e16c, 0x49c5, 0x4201, 0x88, 0x2a, 0x85, 0x38, 0xf3, 0x8c, 0xf1, 0x3a);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFStreamExtension_CameraExtrinsics = new Guid(0x686196d0, 0x13e2, 0x41d9, 0x96, 0x38, 0xef, 0x3, 0x2c, 0x27, 0x2a, 0x52);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_CameraExtrinsics = new Guid(0x6b761658, 0xb7ec, 0x4c3b, 0x82, 0x25, 0x86, 0x23, 0xca, 0xbe, 0xc3, 0x1d);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFStreamExtension_PinholeCameraIntrinsics = new Guid(0xdbac0455, 0xec8, 0x4aef, 0x9c, 0x32, 0x7a, 0x3e, 0xe3, 0x45, 0x6f, 0x53);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFSampleExtension_PinholeCameraIntrinsics = new Guid(0x4ee3b6c5, 0x6a15, 0x4e72, 0x97, 0x61, 0x70, 0xc1, 0xdb, 0x8b, 0x9f, 0xe3);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMediaType_Default = new Guid(0x81A412E6, 0x8103, 0x4B06, 0x85, 0x7F, 0x18, 0x62, 0x78, 0x10, 0x24, 0xAC);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMediaType_Audio = new Guid(0x73647561, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMediaType_Video = new Guid(0x73646976, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMediaType_Protected = new Guid(0x7b4b6fe6, 0x9d04, 0x4494, 0xbe, 0x14, 0x7e, 0x0b, 0xd0, 0x76, 0xc8, 0xe4);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMediaType_SAMI = new Guid(0xe69669a0, 0x3dcd, 0x40cb, 0x9e, 0x2e, 0x37, 0x08, 0x38, 0x7c, 0x06, 0x16);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMediaType_Script = new Guid(0x72178C22, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMediaType_Image = new Guid(0x72178C23, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMediaType_HTML = new Guid(0x72178C24, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMediaType_Binary = new Guid(0x72178C25, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMediaType_FileTransfer = new Guid(0x72178C26, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMediaType_Stream = new Guid(0xe436eb83, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMediaType_MultiplexedFrames = new Guid(0x6ea542b0, 0x281f, 0x4231, 0xa4, 0x64, 0xfe, 0x2f, 0x50, 0x22, 0x50, 0x1c);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMediaType_Subtitle = new Guid(0xa6d13581, 0xed50, 0x4e65, 0xae, 0x08, 0x26, 0x06, 0x55, 0x76, 0xaa, 0xcc);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFMediaType_Perception = new Guid(0x597ff6f9, 0x6ea2, 0x4670, 0x85, 0xb4, 0xea, 0x84, 0x7, 0x3f, 0xe9, 0x40);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFImageFormat_JPEG = new Guid(0x19e4a5aa, 0x5662, 0x4fc5, 0xa0, 0xc0, 0x17, 0x58, 0x02, 0x8e, 0x10, 0x57);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFImageFormat_RGB32 = new Guid(0x00000016, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFStreamFormat_MPEG2Transport = new Guid(0xe06d8023, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea);

        [NativeTypeName("const GUID")]
        public static readonly Guid MFStreamFormat_MPEG2Program = new Guid(0x263067d1, 0xd330, 0x45dc, 0xb6, 0x69, 0x34, 0xd9, 0x86, 0xe4, 0xe3, 0xe1);

        [NativeTypeName("const GUID")]
        public static readonly Guid AM_MEDIA_TYPE_REPRESENTATION = new Guid(0xe2e42ad2, 0x132c, 0x491e, 0xa2, 0x68, 0x3c, 0x7c, 0x2d, 0xca, 0x18, 0x1f);

        [NativeTypeName("const GUID")]
        public static readonly Guid FORMAT_MFVideoFormat = new Guid(0xaed4ab2d, 0x7326, 0x43cb, 0x94, 0x64, 0xc8, 0x79, 0xca, 0xb9, 0xc4, 0x3d);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFValidateMediaTypeSize([NativeTypeName("GUID")] Guid FormatType, [NativeTypeName("UINT8 *")] byte* pBlock, [NativeTypeName("UINT32")] uint cbSize);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaType([NativeTypeName("IMFMediaType **")] IMFMediaType** ppMFType);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMFVideoFormatFromMFMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("MFVIDEOFORMAT **")] MFVIDEOFORMAT** ppMFVF, [NativeTypeName("UINT32 *")] uint* pcbSize);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateWaveFormatExFromMFMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppWF, [NativeTypeName("UINT32 *")] uint* pcbSize, [NativeTypeName("UINT32")] uint Flags = (uint)(MFWaveFormatExConvertFlag_Normal));

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromVideoInfoHeader([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("const VIDEOINFOHEADER *")] VIDEOINFOHEADER* pVIH, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("const GUID *")] Guid* pSubtype = null);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromVideoInfoHeader2([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("const VIDEOINFOHEADER2 *")] VIDEOINFOHEADER2* pVIH2, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("const GUID *")] Guid* pSubtype = null);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromMPEG1VideoInfo([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("const MPEG1VIDEOINFO *")] MPEG1VIDEOINFO* pMP1VI, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("const GUID *")] Guid* pSubtype = null);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromMPEG2VideoInfo([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("const MPEG2VIDEOINFO *")] MPEG2VIDEOINFO* pMP2VI, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("const GUID *")] Guid* pSubtype = null);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCalculateBitmapImageSize([NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pBMIH, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbImageSize, [NativeTypeName("BOOL *")] int* pbKnown = null);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCalculateImageSize([NativeTypeName("const GUID &")] Guid* guidSubtype, [NativeTypeName("UINT32")] uint unWidth, [NativeTypeName("UINT32")] uint unHeight, [NativeTypeName("UINT32 *")] uint* pcbImageSize);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFFrameRateToAverageTimePerFrame([NativeTypeName("UINT32")] uint unNumerator, [NativeTypeName("UINT32")] uint unDenominator, [NativeTypeName("UINT64 *")] ulong* punAverageTimePerFrame);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFAverageTimePerFrameToFrameRate([NativeTypeName("UINT64")] ulong unAverageTimePerFrame, [NativeTypeName("UINT32 *")] uint* punNumerator, [NativeTypeName("UINT32 *")] uint* punDenominator);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromMFVideoFormat([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pMFVF, [NativeTypeName("UINT32")] uint cbBufSize);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromWaveFormatEx([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormat, [NativeTypeName("UINT32")] uint cbBufSize);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromAMMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pAMType);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitAMMediaTypeFromMFMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("GUID")] Guid guidFormatBlockType, [NativeTypeName("AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pAMType);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAMMediaTypeFromMFMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("GUID")] Guid guidFormatBlockType, [NativeTypeName("AM_MEDIA_TYPE **")] AM_MEDIA_TYPE** ppAMType);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MFCompareFullToPartialMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFTypeFull, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMFTypePartial);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFWrapMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pOrig, [NativeTypeName("const GUID &")] Guid* MajorType, [NativeTypeName("const GUID &")] Guid* SubType, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppWrap);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnwrapMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pWrap, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppOrig);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoMediaType([NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pVideoFormat, [NativeTypeName("IMFVideoMediaType **")] IMFVideoMediaType** ppIVideoMediaType);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoMediaTypeFromSubtype([NativeTypeName("const GUID *")] Guid* pAMSubtype, [NativeTypeName("IMFVideoMediaType **")] IMFVideoMediaType** ppIVideoMediaType);

        [DllImport("evr", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MFIsFormatYUV([NativeTypeName("DWORD")] uint Format);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoMediaTypeFromBitMapInfoHeader([NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pbmihBitMapInfoHeader, [NativeTypeName("DWORD")] uint dwPixelAspectRatioX, [NativeTypeName("DWORD")] uint dwPixelAspectRatioY, MFVideoInterlaceMode InterlaceMode, [NativeTypeName("QWORD")] ulong VideoFlags, [NativeTypeName("QWORD")] ulong qwFramesPerSecondNumerator, [NativeTypeName("QWORD")] ulong qwFramesPerSecondDenominator, [NativeTypeName("DWORD")] uint dwMaxBitRate, [NativeTypeName("IMFVideoMediaType **")] IMFVideoMediaType** ppIVideoMediaType);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetStrideForBitmapInfoHeader([NativeTypeName("DWORD")] uint format, [NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("LONG *")] int* pStride);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetPlaneSize([NativeTypeName("DWORD")] uint format, [NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD *")] uint* pdwPlaneSize);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoMediaTypeFromBitMapInfoHeaderEx([NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pbmihBitMapInfoHeader, [NativeTypeName("UINT32")] uint cbBitMapInfoHeader, [NativeTypeName("DWORD")] uint dwPixelAspectRatioX, [NativeTypeName("DWORD")] uint dwPixelAspectRatioY, MFVideoInterlaceMode InterlaceMode, [NativeTypeName("QWORD")] ulong VideoFlags, [NativeTypeName("DWORD")] uint dwFramesPerSecondNumerator, [NativeTypeName("DWORD")] uint dwFramesPerSecondDenominator, [NativeTypeName("DWORD")] uint dwMaxBitRate, [NativeTypeName("IMFVideoMediaType **")] IMFVideoMediaType** ppIVideoMediaType);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaTypeFromRepresentation([NativeTypeName("GUID")] Guid guidRepresentation, [NativeTypeName("LPVOID")] void* pvRepresentation, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppIMediaType);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAudioMediaType([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pAudioFormat, [NativeTypeName("IMFAudioMediaType **")] IMFAudioMediaType** ppIAudioMediaType);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MFGetUncompressedVideoFormat([NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pVideoFormat);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitVideoFormat([NativeTypeName("MFVIDEOFORMAT *")] MFVIDEOFORMAT* pVideoFormat, MFStandardVideoFormat type);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitVideoFormat_RGB([NativeTypeName("MFVIDEOFORMAT *")] MFVIDEOFORMAT* pVideoFormat, [NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint D3Dfmt);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFConvertColorInfoToDXVA([NativeTypeName("DWORD *")] uint* pdwToDXVA, [NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pFromFormat);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFConvertColorInfoFromDXVA([NativeTypeName("MFVIDEOFORMAT *")] MFVIDEOFORMAT* pToFormat, [NativeTypeName("DWORD")] uint dwFromDXVA);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCopyImage([NativeTypeName("BYTE *")] byte* pDest, [NativeTypeName("LONG")] int lDestStride, [NativeTypeName("const BYTE *")] byte* pSrc, [NativeTypeName("LONG")] int lSrcStride, [NativeTypeName("DWORD")] uint dwWidthInBytes, [NativeTypeName("DWORD")] uint dwLines);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFConvertFromFP16Array([NativeTypeName("float *")] float* pDest, [NativeTypeName("const WORD *")] ushort* pSrc, [NativeTypeName("DWORD")] uint dwCount);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFConvertToFP16Array([NativeTypeName("WORD *")] ushort* pDest, [NativeTypeName("const float *")] float* pSrc, [NativeTypeName("DWORD")] uint dwCount);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreate2DMediaBuffer([NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint dwFourCC, [NativeTypeName("BOOL")] int fBottomUp, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaBufferFromMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType, [NativeTypeName("LONGLONG")] long llDuration, [NativeTypeName("DWORD")] uint dwMinLength, [NativeTypeName("DWORD")] uint dwMinAlignment, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

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
            Unpack2UINT32AsUINT64(unPacked, (uint*)(pnNumerator), punDenominator);
        }

        [return: NativeTypeName("UINT32")]
        public static uint MFGetAttributeUINT32([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unDefault)
        {
            uint unRet;

            if ((((int)(pAttributes->GetUINT32(guidKey, &unRet))) < 0))
            {
                unRet = unDefault;
            }

            return unRet;
        }

        [return: NativeTypeName("UINT64")]
        public static ulong MFGetAttributeUINT64([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unDefault)
        {
            ulong unRet;

            if ((((int)(pAttributes->GetUINT64(guidKey, &unRet))) < 0))
            {
                unRet = unDefault;
            }

            return unRet;
        }

        public static double MFGetAttributeDouble([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, double fDefault)
        {
            double fRet;

            if ((((int)(pAttributes->GetDouble(guidKey, &fRet))) < 0))
            {
                fRet = fDefault;
            }

            return fRet;
        }

        [return: NativeTypeName("HRESULT")]
        public static int MFGetAttribute2UINT32asUINT64([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punHigh32, [NativeTypeName("UINT32 *")] uint* punLow32)
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
        public static int MFSetAttribute2UINT32asUINT64([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unHigh32, [NativeTypeName("UINT32")] uint unLow32)
        {
            return pAttributes->SetUINT64(guidKey, Pack2UINT32AsUINT64(unHigh32, unLow32));
        }

        [return: NativeTypeName("HRESULT")]
        public static int MFGetAttributeRatio([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punNumerator, [NativeTypeName("UINT32 *")] uint* punDenominator)
        {
            return MFGetAttribute2UINT32asUINT64(pAttributes, guidKey, punNumerator, punDenominator);
        }

        [return: NativeTypeName("HRESULT")]
        public static int MFGetAttributeSize([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punWidth, [NativeTypeName("UINT32 *")] uint* punHeight)
        {
            return MFGetAttribute2UINT32asUINT64(pAttributes, guidKey, punWidth, punHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public static int MFSetAttributeRatio([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unNumerator, [NativeTypeName("UINT32")] uint unDenominator)
        {
            return MFSetAttribute2UINT32asUINT64(pAttributes, guidKey, unNumerator, unDenominator);
        }

        [return: NativeTypeName("HRESULT")]
        public static int MFSetAttributeSize([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unWidth, [NativeTypeName("UINT32")] uint unHeight)
        {
            return MFSetAttribute2UINT32asUINT64(pAttributes, guidKey, unWidth, unHeight);
        }

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateCollection([NativeTypeName("IMFCollection **")] IMFCollection** ppIMFCollection);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("void *")]
        public static extern void* MFHeapAlloc([NativeTypeName("size_t")] nuint nSize, [NativeTypeName("ULONG")] uint dwFlags, [NativeTypeName("char *")] sbyte* pszFile, int line, EAllocationType eat);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void MFHeapFree([NativeTypeName("void *")] void* pv);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_MFSourceResolver = new Guid(0x90eab60f, 0xe43a, 0x4188, 0xbc, 0xc4, 0xe4, 0x7f, 0xdf, 0x04, 0x86, 0x8c);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONGLONG")]
        public static extern long MFllMulDiv([NativeTypeName("LONGLONG")] long a, [NativeTypeName("LONGLONG")] long b, [NativeTypeName("LONGLONG")] long c, [NativeTypeName("LONGLONG")] long d);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetContentProtectionSystemCLSID([NativeTypeName("const GUID &")] Guid* guidProtectionSystemID, [NativeTypeName("CLSID *")] Guid* pclsid);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_DEVICESTREAM_ATTRIBUTE_FACEAUTH_CAPABILITY = new Guid(0xCB6FD12A, 0x2248, 0x4E41, 0xAD, 0x46, 0xE7, 0x8B, 0xB9, 0x0A, 0xB9, 0xFC);

        [NativeTypeName("const GUID")]
        public static readonly Guid MF_DEVICESTREAM_ATTRIBUTE_SECURE_CAPABILITY = new Guid(0x940FD626, 0xEA6E, 0x4684, 0x98, 0x40, 0x36, 0xBD, 0x6E, 0xC9, 0xFB, 0xEF);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCombineSamples([NativeTypeName("IMFSample *")] IMFSample* pSample, [NativeTypeName("IMFSample *")] IMFSample* pSampleToAdd, [NativeTypeName("DWORD")] uint dwMaxMergedDurationInMS, [NativeTypeName("BOOL *")] int* pMerged);

        [DllImport("mfplat", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFSplitSample([NativeTypeName("IMFSample *")] IMFSample* pSample, [NativeTypeName("IMFSample **")] IMFSample** pOutputSamples, [NativeTypeName("DWORD")] uint dwOutputSampleMaxCount, [NativeTypeName("DWORD *")] uint* pdwOutputSampleCount);

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
        public static readonly Guid MFVideoFormat_MPG2 = MFVideoFormat_MPEG2;
    }
}
