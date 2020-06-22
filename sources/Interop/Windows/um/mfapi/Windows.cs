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
        [DllImport("mfplat", EntryPoint = "MFStartup", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFStartup([NativeTypeName("ULONG")] uint Version, [NativeTypeName("DWORD")] uint dwFlags = 0);

        [DllImport("mfplat", EntryPoint = "MFShutdown", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFShutdown();

        [DllImport("mfplat", EntryPoint = "MFLockPlatform", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLockPlatform();

        [DllImport("mfplat", EntryPoint = "MFUnlockPlatform", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnlockPlatform();

        [DllImport("mfplat", EntryPoint = "MFPutWorkItem", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWorkItem([NativeTypeName("DWORD")] uint dwQueue, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState);

        [DllImport("mfplat", EntryPoint = "MFPutWorkItem2", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWorkItem2([NativeTypeName("DWORD")] uint dwQueue, [NativeTypeName("LONG")] int Priority, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState);

        [DllImport("mfplat", EntryPoint = "MFPutWorkItemEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWorkItemEx([NativeTypeName("DWORD")] uint dwQueue, [NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult);

        [DllImport("mfplat", EntryPoint = "MFPutWorkItemEx2", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWorkItemEx2([NativeTypeName("DWORD")] uint dwQueue, [NativeTypeName("LONG")] int Priority, [NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult);

        [DllImport("mfplat", EntryPoint = "MFPutWaitingWorkItem", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPutWaitingWorkItem([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("LONG")] int Priority, [NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("MFWORKITEM_KEY *")] ulong* pKey);

        [DllImport("mfplat", EntryPoint = "MFAllocateSerialWorkQueue", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFAllocateSerialWorkQueue([NativeTypeName("DWORD")] uint dwWorkQueue, [NativeTypeName("DWORD *")] uint* pdwWorkQueue);

        [DllImport("mfplat", EntryPoint = "MFScheduleWorkItemEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFScheduleWorkItemEx([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("INT64")] long Timeout, [NativeTypeName("MFWORKITEM_KEY *")] ulong* pKey);

        [DllImport("mfplat", EntryPoint = "MFScheduleWorkItem", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFScheduleWorkItem([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState, [NativeTypeName("INT64")] long Timeout, [NativeTypeName("MFWORKITEM_KEY *")] ulong* pKey);

        [DllImport("mfplat", EntryPoint = "MFCancelWorkItem", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCancelWorkItem([NativeTypeName("MFWORKITEM_KEY")] ulong Key);

        [DllImport("mfplat", EntryPoint = "MFGetTimerPeriodicity", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetTimerPeriodicity([NativeTypeName("DWORD *")] uint* Periodicity);

        [DllImport("mfplat", EntryPoint = "MFAddPeriodicCallback", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFAddPeriodicCallback([NativeTypeName("MFPERIODICCALLBACK")] delegate* stdcall<IUnknown*, void> Callback, [NativeTypeName("IUnknown *")] IUnknown* pContext, [NativeTypeName("DWORD *")] uint* pdwKey);

        [DllImport("mfplat", EntryPoint = "MFRemovePeriodicCallback", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRemovePeriodicCallback([NativeTypeName("DWORD")] uint dwKey);

        [DllImport("mfplat", EntryPoint = "MFAllocateWorkQueueEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFAllocateWorkQueueEx(MFASYNC_WORKQUEUE_TYPE WorkQueueType, [NativeTypeName("DWORD *")] uint* pdwWorkQueue);

        [DllImport("mfplat", EntryPoint = "MFAllocateWorkQueue", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFAllocateWorkQueue([NativeTypeName("DWORD *")] uint* pdwWorkQueue);

        [DllImport("mfplat", EntryPoint = "MFLockWorkQueue", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLockWorkQueue([NativeTypeName("DWORD")] uint dwWorkQueue);

        [DllImport("mfplat", EntryPoint = "MFUnlockWorkQueue", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnlockWorkQueue([NativeTypeName("DWORD")] uint dwWorkQueue);

        [DllImport("mfplat", EntryPoint = "MFBeginRegisterWorkQueueWithMMCSS", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFBeginRegisterWorkQueueWithMMCSS([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LPCWSTR")] ushort* wszClass, [NativeTypeName("DWORD")] uint dwTaskId, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pDoneCallback, [NativeTypeName("IUnknown *")] IUnknown* pDoneState);

        [DllImport("mfplat", EntryPoint = "MFBeginRegisterWorkQueueWithMMCSSEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFBeginRegisterWorkQueueWithMMCSSEx([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LPCWSTR")] ushort* wszClass, [NativeTypeName("DWORD")] uint dwTaskId, [NativeTypeName("LONG")] int lPriority, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pDoneCallback, [NativeTypeName("IUnknown *")] IUnknown* pDoneState);

        [DllImport("mfplat", EntryPoint = "MFEndRegisterWorkQueueWithMMCSS", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFEndRegisterWorkQueueWithMMCSS([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("DWORD *")] uint* pdwTaskId);

        [DllImport("mfplat", EntryPoint = "MFBeginUnregisterWorkQueueWithMMCSS", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFBeginUnregisterWorkQueueWithMMCSS([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pDoneCallback, [NativeTypeName("IUnknown *")] IUnknown* pDoneState);

        [DllImport("mfplat", EntryPoint = "MFEndUnregisterWorkQueueWithMMCSS", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFEndUnregisterWorkQueueWithMMCSS([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult);

        [DllImport("mfplat", EntryPoint = "MFGetWorkQueueMMCSSClass", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetWorkQueueMMCSSClass([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LPWSTR")] ushort* pwszClass, [NativeTypeName("DWORD *")] uint* pcchClass);

        [DllImport("mfplat", EntryPoint = "MFGetWorkQueueMMCSSTaskId", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetWorkQueueMMCSSTaskId([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LPDWORD")] uint* pdwTaskId);

        [DllImport("mfplat", EntryPoint = "MFRegisterPlatformWithMMCSS", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRegisterPlatformWithMMCSS([NativeTypeName("PCWSTR")] ushort* wszClass, [NativeTypeName("DWORD *")] uint* pdwTaskId, [NativeTypeName("LONG")] int lPriority);

        [DllImport("mfplat", EntryPoint = "MFUnregisterPlatformFromMMCSS", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnregisterPlatformFromMMCSS();

        [DllImport("mfplat", EntryPoint = "MFLockSharedWorkQueue", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLockSharedWorkQueue([NativeTypeName("PCWSTR")] ushort* wszClass, [NativeTypeName("LONG")] int BasePriority, [NativeTypeName("DWORD *")] uint* pdwTaskId, [NativeTypeName("DWORD *")] uint* pID);

        [DllImport("mfplat", EntryPoint = "MFGetWorkQueueMMCSSPriority", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetWorkQueueMMCSSPriority([NativeTypeName("DWORD")] uint dwWorkQueueId, [NativeTypeName("LONG *")] int* lPriority);

        [DllImport("mfplat", EntryPoint = "MFCreateAsyncResult", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAsyncResult([NativeTypeName("IUnknown *")] IUnknown* punkObject, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState, [NativeTypeName("IMFAsyncResult **")] IMFAsyncResult** ppAsyncResult);

        [DllImport("mfplat", EntryPoint = "MFInvokeCallback", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInvokeCallback([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pAsyncResult);

        [DllImport("mfplat", EntryPoint = "MFCreateFile", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateFile(MF_FILE_ACCESSMODE AccessMode, MF_FILE_OPENMODE OpenMode, MF_FILE_FLAGS fFlags, [NativeTypeName("LPCWSTR")] ushort* pwszFileURL, [NativeTypeName("IMFByteStream **")] IMFByteStream** ppIByteStream);

        [DllImport("mfplat", EntryPoint = "MFCreateTempFile", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTempFile(MF_FILE_ACCESSMODE AccessMode, MF_FILE_OPENMODE OpenMode, MF_FILE_FLAGS fFlags, [NativeTypeName("IMFByteStream **")] IMFByteStream** ppIByteStream);

        [DllImport("mfplat", EntryPoint = "MFBeginCreateFile", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFBeginCreateFile(MF_FILE_ACCESSMODE AccessMode, MF_FILE_OPENMODE OpenMode, MF_FILE_FLAGS fFlags, [NativeTypeName("LPCWSTR")] ushort* pwszFilePath, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState, [NativeTypeName("IUnknown **")] IUnknown** ppCancelCookie);

        [DllImport("mfplat", EntryPoint = "MFEndCreateFile", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFEndCreateFile([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("IMFByteStream **")] IMFByteStream** ppFile);

        [DllImport("mfplat", EntryPoint = "MFCancelCreateFile", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCancelCreateFile([NativeTypeName("IUnknown *")] IUnknown* pCancelCookie);

        [DllImport("mfplat", EntryPoint = "MFCreateMemoryBuffer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMemoryBuffer([NativeTypeName("DWORD")] uint cbMaxLength, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", EntryPoint = "MFCreateMediaBufferWrapper", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaBufferWrapper([NativeTypeName("IMFMediaBuffer *")] IMFMediaBuffer* pBuffer, [NativeTypeName("DWORD")] uint cbOffset, [NativeTypeName("DWORD")] uint dwLength, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", EntryPoint = "MFCreateLegacyMediaBufferOnMFMediaBuffer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateLegacyMediaBufferOnMFMediaBuffer([NativeTypeName("IMFSample *")] IMFSample* pSample, [NativeTypeName("IMFMediaBuffer *")] IMFMediaBuffer* pMFMediaBuffer, [NativeTypeName("DWORD")] uint cbOffset, [NativeTypeName("IMediaBuffer **")] IMediaBuffer** ppMediaBuffer);

        [DllImport("mfplat", EntryPoint = "MFMapDX9FormatToDXGIFormat", ExactSpelling = true)]
        public static extern DXGI_FORMAT MFMapDX9FormatToDXGIFormat([NativeTypeName("DWORD")] uint dx9);

        [DllImport("mfplat", EntryPoint = "MFMapDXGIFormatToDX9Format", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MFMapDXGIFormatToDX9Format(DXGI_FORMAT dx11);

        [DllImport("mfplat", EntryPoint = "MFLockDXGIDeviceManager", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLockDXGIDeviceManager([NativeTypeName("UINT *")] uint* pResetToken, [NativeTypeName("IMFDXGIDeviceManager **")] IMFDXGIDeviceManager** ppManager);

        [DllImport("mfplat", EntryPoint = "MFUnlockDXGIDeviceManager", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnlockDXGIDeviceManager();

        [DllImport("evr", EntryPoint = "MFCreateDXSurfaceBuffer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDXSurfaceBuffer([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punkSurface, [NativeTypeName("BOOL")] int fBottomUpWhenLinear, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", EntryPoint = "MFCreateWICBitmapBuffer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateWICBitmapBuffer([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punkSurface, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", EntryPoint = "MFCreateDXGISurfaceBuffer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDXGISurfaceBuffer([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punkSurface, [NativeTypeName("UINT")] uint uSubresourceIndex, [NativeTypeName("BOOL")] int fBottomUpWhenLinear, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", EntryPoint = "MFCreateVideoSampleAllocatorEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoSampleAllocatorEx([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppSampleAllocator);

        [DllImport("mfplat", EntryPoint = "MFCreateDXGIDeviceManager", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDXGIDeviceManager([NativeTypeName("UINT *")] uint* resetToken, [NativeTypeName("IMFDXGIDeviceManager **")] IMFDXGIDeviceManager** ppDeviceManager);

        [DllImport("mfplat", EntryPoint = "MFCreateAlignedMemoryBuffer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAlignedMemoryBuffer([NativeTypeName("DWORD")] uint cbMaxLength, [NativeTypeName("DWORD")] uint cbAligment, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

        // [NativeTypeName("const GUID")]
        // public static extern Guid MR_BUFFER_SERVICE;

        [DllImport("mfplat", EntryPoint = "MFCreateMediaEvent", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, [NativeTypeName("HRESULT")] int hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue, [NativeTypeName("IMFMediaEvent **")] IMFMediaEvent** ppEvent);

        [DllImport("mfplat", EntryPoint = "MFCreateEventQueue", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateEventQueue([NativeTypeName("IMFMediaEventQueue **")] IMFMediaEventQueue** ppMediaEventQueue);

        [DllImport("mfplat", EntryPoint = "MFCreateSample", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSample([NativeTypeName("IMFSample **")] IMFSample** ppIMFSample);

        [DllImport("mfplat", EntryPoint = "MFCreateAttributes", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAttributes([NativeTypeName("IMFAttributes **")] IMFAttributes** ppMFAttributes, [NativeTypeName("UINT32")] uint cInitialSize);

        [DllImport("mfplat", EntryPoint = "MFInitAttributesFromBlob", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitAttributesFromBlob([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT")] uint cbBufSize);

        [DllImport("mfplat", EntryPoint = "MFGetAttributesAsBlobSize", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetAttributesAsBlobSize([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("UINT32 *")] uint* pcbBufSize);

        [DllImport("mfplat", EntryPoint = "MFGetAttributesAsBlob", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetAttributesAsBlob([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT")] uint cbBufSize);

        [DllImport("mfplat", EntryPoint = "MFTRegister", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTRegister([NativeTypeName("CLSID")] Guid clsidMFT, [NativeTypeName("GUID")] Guid guidCategory, [NativeTypeName("LPWSTR")] ushort* pszName, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("UINT32")] uint cInputTypes, [NativeTypeName("MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputTypes, [NativeTypeName("UINT32")] uint cOutputTypes, [NativeTypeName("MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputTypes, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes);

        [DllImport("mfplat", EntryPoint = "MFTUnregister", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTUnregister([NativeTypeName("CLSID")] Guid clsidMFT);

        [DllImport("mfplat", EntryPoint = "MFTRegisterLocal", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTRegisterLocal([NativeTypeName("IClassFactory *")] IClassFactory* pClassFactory, [NativeTypeName("const GUID &")] Guid* guidCategory, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("UINT32")] uint cInputTypes, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputTypes, [NativeTypeName("UINT32")] uint cOutputTypes, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputTypes);

        [DllImport("mfplat", EntryPoint = "MFTUnregisterLocal", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTUnregisterLocal([NativeTypeName("IClassFactory *")] IClassFactory* pClassFactory);

        [DllImport("mfplat", EntryPoint = "MFTRegisterLocalByCLSID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTRegisterLocalByCLSID([NativeTypeName("const IID &")] Guid* clisdMFT, [NativeTypeName("const GUID &")] Guid* guidCategory, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("UINT32")] uint cInputTypes, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputTypes, [NativeTypeName("UINT32")] uint cOutputTypes, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputTypes);

        [DllImport("mfplat", EntryPoint = "MFTUnregisterLocalByCLSID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTUnregisterLocalByCLSID([NativeTypeName("CLSID")] Guid clsidMFT);

        [DllImport("mfplat", EntryPoint = "MFTEnum", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTEnum([NativeTypeName("GUID")] Guid guidCategory, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputType, [NativeTypeName("MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputType, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("CLSID **")] Guid** ppclsidMFT, [NativeTypeName("UINT32 *")] uint* pcMFTs);

        [DllImport("mfplat", EntryPoint = "MFTEnumEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTEnumEx([NativeTypeName("GUID")] Guid guidCategory, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputType, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputType, [NativeTypeName("IMFActivate ***")] IMFActivate*** pppMFTActivate, [NativeTypeName("UINT32 *")] uint* pnumMFTActivate);

        [DllImport("mfplat", EntryPoint = "MFTEnum2", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTEnum2([NativeTypeName("GUID")] Guid guidCategory, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputType, [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputType, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFActivate ***")] IMFActivate*** pppMFTActivate, [NativeTypeName("UINT32 *")] uint* pnumMFTActivate);

        [DllImport("mfplat", EntryPoint = "MFTGetInfo", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTGetInfo([NativeTypeName("CLSID")] Guid clsidMFT, [NativeTypeName("LPWSTR *")] ushort** pszName, [NativeTypeName("MFT_REGISTER_TYPE_INFO **")] MFT_REGISTER_TYPE_INFO** ppInputTypes, [NativeTypeName("UINT32 *")] uint* pcInputTypes, [NativeTypeName("MFT_REGISTER_TYPE_INFO **")] MFT_REGISTER_TYPE_INFO** ppOutputTypes, [NativeTypeName("UINT32 *")] uint* pcOutputTypes, [NativeTypeName("IMFAttributes **")] IMFAttributes** ppAttributes);

        [DllImport("mfplat", EntryPoint = "MFGetPluginControl", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetPluginControl([NativeTypeName("IMFPluginControl **")] IMFPluginControl** ppPluginControl);

        [DllImport("mfplat", EntryPoint = "MFGetMFTMerit", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetMFTMerit([NativeTypeName("IUnknown *")] IUnknown* pMFT, [NativeTypeName("UINT32")] uint cbVerifier, [NativeTypeName("const BYTE *")] byte* verifier, [NativeTypeName("DWORD *")] uint* merit);

        [DllImport("mfplat", EntryPoint = "MFRegisterLocalSchemeHandler", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRegisterLocalSchemeHandler([NativeTypeName("PCWSTR")] ushort* szScheme, [NativeTypeName("IMFActivate *")] IMFActivate* pActivate);

        [DllImport("mfplat", EntryPoint = "MFRegisterLocalByteStreamHandler", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRegisterLocalByteStreamHandler([NativeTypeName("PCWSTR")] ushort* szFileExtension, [NativeTypeName("PCWSTR")] ushort* szMimeType, [NativeTypeName("IMFActivate *")] IMFActivate* pActivate);

        [DllImport("mfplat", EntryPoint = "MFCreateMFByteStreamWrapper", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMFByteStreamWrapper([NativeTypeName("IMFByteStream *")] IMFByteStream* pStream, [NativeTypeName("IMFByteStream **")] IMFByteStream** ppStreamWrapper);

        [DllImport("mfplat", EntryPoint = "MFCreateMediaExtensionActivate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaExtensionActivate([NativeTypeName("PCWSTR")] ushort* szActivatableClassId, [NativeTypeName("IUnknown *")] IUnknown* pConfiguration, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);

        [DllImport("mfplat", EntryPoint = "MFCreateMuxStreamAttributes", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMuxStreamAttributes([NativeTypeName("IMFCollection *")] IMFCollection* pAttributesToMux, [NativeTypeName("IMFAttributes **")] IMFAttributes** ppMuxAttribs);

        [DllImport("mfplat", EntryPoint = "MFCreateMuxStreamMediaType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMuxStreamMediaType([NativeTypeName("IMFCollection *")] IMFCollection* pMediaTypesToMux, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMuxMediaType);

        [DllImport("mfplat", EntryPoint = "MFCreateMuxStreamSample", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMuxStreamSample([NativeTypeName("IMFCollection *")] IMFCollection* pSamplesToMux, [NativeTypeName("IMFSample **")] IMFSample** ppMuxSample);

        [DllImport("mfplat", EntryPoint = "MFValidateMediaTypeSize", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFValidateMediaTypeSize([NativeTypeName("GUID")] Guid FormatType, [NativeTypeName("UINT8 *")] byte* pBlock, [NativeTypeName("UINT32")] uint cbSize);

        [DllImport("mfplat", EntryPoint = "MFCreateMediaType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaType([NativeTypeName("IMFMediaType **")] IMFMediaType** ppMFType);

        [DllImport("mfplat", EntryPoint = "MFCreateMFVideoFormatFromMFMediaType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMFVideoFormatFromMFMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("MFVIDEOFORMAT **")] MFVIDEOFORMAT** ppMFVF, [NativeTypeName("UINT32 *")] uint* pcbSize);

        [DllImport("mfplat", EntryPoint = "MFCreateWaveFormatExFromMFMediaType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateWaveFormatExFromMFMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppWF, [NativeTypeName("UINT32 *")] uint* pcbSize, [NativeTypeName("UINT32")] uint Flags = (uint)MFWaveFormatExConvertFlag_Normal);

        [DllImport("mfplat", EntryPoint = "MFInitMediaTypeFromVideoInfoHeader", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromVideoInfoHeader([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("const VIDEOINFOHEADER *")] VIDEOINFOHEADER* pVIH, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("const GUID *")] Guid* pSubtype = null);

        [DllImport("mfplat", EntryPoint = "MFInitMediaTypeFromVideoInfoHeader2", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromVideoInfoHeader2([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("const VIDEOINFOHEADER2 *")] VIDEOINFOHEADER2* pVIH2, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("const GUID *")] Guid* pSubtype = null);

        [DllImport("mfplat", EntryPoint = "MFInitMediaTypeFromMPEG1VideoInfo", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromMPEG1VideoInfo([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("const MPEG1VIDEOINFO *")] MPEG1VIDEOINFO* pMP1VI, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("const GUID *")] Guid* pSubtype = null);

        [DllImport("mfplat", EntryPoint = "MFInitMediaTypeFromMPEG2VideoInfo", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromMPEG2VideoInfo([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("const MPEG2VIDEOINFO *")] MPEG2VIDEOINFO* pMP2VI, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("const GUID *")] Guid* pSubtype = null);

        [DllImport("mfplat", EntryPoint = "MFCalculateBitmapImageSize", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCalculateBitmapImageSize([NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pBMIH, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbImageSize, [NativeTypeName("BOOL *")] int* pbKnown = null);

        [DllImport("mfplat", EntryPoint = "MFCalculateImageSize", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCalculateImageSize([NativeTypeName("const GUID &")] Guid* guidSubtype, [NativeTypeName("UINT32")] uint unWidth, [NativeTypeName("UINT32")] uint unHeight, [NativeTypeName("UINT32 *")] uint* pcbImageSize);

        [DllImport("mfplat", EntryPoint = "MFFrameRateToAverageTimePerFrame", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFFrameRateToAverageTimePerFrame([NativeTypeName("UINT32")] uint unNumerator, [NativeTypeName("UINT32")] uint unDenominator, [NativeTypeName("UINT64 *")] ulong* punAverageTimePerFrame);

        [DllImport("mfplat", EntryPoint = "MFAverageTimePerFrameToFrameRate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFAverageTimePerFrameToFrameRate([NativeTypeName("UINT64")] ulong unAverageTimePerFrame, [NativeTypeName("UINT32 *")] uint* punNumerator, [NativeTypeName("UINT32 *")] uint* punDenominator);

        [DllImport("mfplat", EntryPoint = "MFInitMediaTypeFromMFVideoFormat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromMFVideoFormat([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pMFVF, [NativeTypeName("UINT32")] uint cbBufSize);

        [DllImport("mfplat", EntryPoint = "MFInitMediaTypeFromWaveFormatEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromWaveFormatEx([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormat, [NativeTypeName("UINT32")] uint cbBufSize);

        [DllImport("mfplat", EntryPoint = "MFInitMediaTypeFromAMMediaType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitMediaTypeFromAMMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pAMType);

        [DllImport("mfplat", EntryPoint = "MFInitAMMediaTypeFromMFMediaType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitAMMediaTypeFromMFMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("GUID")] Guid guidFormatBlockType, [NativeTypeName("AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pAMType);

        [DllImport("mfplat", EntryPoint = "MFCreateAMMediaTypeFromMFMediaType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAMMediaTypeFromMFMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFType, [NativeTypeName("GUID")] Guid guidFormatBlockType, [NativeTypeName("AM_MEDIA_TYPE **")] AM_MEDIA_TYPE** ppAMType);

        [DllImport("mfplat", EntryPoint = "MFCompareFullToPartialMediaType", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MFCompareFullToPartialMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMFTypeFull, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMFTypePartial);

        [DllImport("mfplat", EntryPoint = "MFWrapMediaType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFWrapMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pOrig, [NativeTypeName("const GUID &")] Guid* MajorType, [NativeTypeName("const GUID &")] Guid* SubType, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppWrap);

        [DllImport("mfplat", EntryPoint = "MFUnwrapMediaType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFUnwrapMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pWrap, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppOrig);

        [DllImport("mfplat", EntryPoint = "MFCreateVideoMediaType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoMediaType([NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pVideoFormat, [NativeTypeName("IMFVideoMediaType **")] IMFVideoMediaType** ppIVideoMediaType);

        [DllImport("mfplat", EntryPoint = "MFCreateVideoMediaTypeFromSubtype", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoMediaTypeFromSubtype([NativeTypeName("const GUID *")] Guid* pAMSubtype, [NativeTypeName("IMFVideoMediaType **")] IMFVideoMediaType** ppIVideoMediaType);

        [DllImport("evr", EntryPoint = "MFIsFormatYUV", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MFIsFormatYUV([NativeTypeName("DWORD")] uint Format);

        [DllImport("mfplat", EntryPoint = "MFCreateVideoMediaTypeFromBitMapInfoHeader", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoMediaTypeFromBitMapInfoHeader([NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pbmihBitMapInfoHeader, [NativeTypeName("DWORD")] uint dwPixelAspectRatioX, [NativeTypeName("DWORD")] uint dwPixelAspectRatioY, MFVideoInterlaceMode InterlaceMode, [NativeTypeName("QWORD")] ulong VideoFlags, [NativeTypeName("QWORD")] ulong qwFramesPerSecondNumerator, [NativeTypeName("QWORD")] ulong qwFramesPerSecondDenominator, [NativeTypeName("DWORD")] uint dwMaxBitRate, [NativeTypeName("IMFVideoMediaType **")] IMFVideoMediaType** ppIVideoMediaType);

        [DllImport("mfplat", EntryPoint = "MFGetStrideForBitmapInfoHeader", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetStrideForBitmapInfoHeader([NativeTypeName("DWORD")] uint format, [NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("LONG *")] int* pStride);

        [DllImport("mfplat", EntryPoint = "MFGetPlaneSize", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetPlaneSize([NativeTypeName("DWORD")] uint format, [NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD *")] uint* pdwPlaneSize);

        [DllImport("mfplat", EntryPoint = "MFCreateVideoMediaTypeFromBitMapInfoHeaderEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoMediaTypeFromBitMapInfoHeaderEx([NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pbmihBitMapInfoHeader, [NativeTypeName("UINT32")] uint cbBitMapInfoHeader, [NativeTypeName("DWORD")] uint dwPixelAspectRatioX, [NativeTypeName("DWORD")] uint dwPixelAspectRatioY, MFVideoInterlaceMode InterlaceMode, [NativeTypeName("QWORD")] ulong VideoFlags, [NativeTypeName("DWORD")] uint dwFramesPerSecondNumerator, [NativeTypeName("DWORD")] uint dwFramesPerSecondDenominator, [NativeTypeName("DWORD")] uint dwMaxBitRate, [NativeTypeName("IMFVideoMediaType **")] IMFVideoMediaType** ppIVideoMediaType);

        [DllImport("mfplat", EntryPoint = "MFCreateMediaTypeFromRepresentation", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaTypeFromRepresentation([NativeTypeName("GUID")] Guid guidRepresentation, [NativeTypeName("LPVOID")] void* pvRepresentation, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppIMediaType);

        [DllImport("mfplat", EntryPoint = "MFCreateAudioMediaType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAudioMediaType([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pAudioFormat, [NativeTypeName("IMFAudioMediaType **")] IMFAudioMediaType** ppIAudioMediaType);

        [DllImport("mfplat", EntryPoint = "MFGetUncompressedVideoFormat", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MFGetUncompressedVideoFormat([NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pVideoFormat);

        [DllImport("mfplat", EntryPoint = "MFInitVideoFormat", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitVideoFormat([NativeTypeName("MFVIDEOFORMAT *")] MFVIDEOFORMAT* pVideoFormat, MFStandardVideoFormat type);

        [DllImport("mfplat", EntryPoint = "MFInitVideoFormat_RGB", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFInitVideoFormat_RGB([NativeTypeName("MFVIDEOFORMAT *")] MFVIDEOFORMAT* pVideoFormat, [NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint D3Dfmt);

        [DllImport("mfplat", EntryPoint = "MFConvertColorInfoToDXVA", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFConvertColorInfoToDXVA([NativeTypeName("DWORD *")] uint* pdwToDXVA, [NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pFromFormat);

        [DllImport("mfplat", EntryPoint = "MFConvertColorInfoFromDXVA", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFConvertColorInfoFromDXVA([NativeTypeName("MFVIDEOFORMAT *")] MFVIDEOFORMAT* pToFormat, [NativeTypeName("DWORD")] uint dwFromDXVA);

        [DllImport("mfplat", EntryPoint = "MFCopyImage", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCopyImage([NativeTypeName("BYTE *")] byte* pDest, [NativeTypeName("LONG")] int lDestStride, [NativeTypeName("const BYTE *")] byte* pSrc, [NativeTypeName("LONG")] int lSrcStride, [NativeTypeName("DWORD")] uint dwWidthInBytes, [NativeTypeName("DWORD")] uint dwLines);

        [DllImport("mfplat", EntryPoint = "MFConvertFromFP16Array", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFConvertFromFP16Array([NativeTypeName("float *")] float* pDest, [NativeTypeName("const WORD *")] ushort* pSrc, [NativeTypeName("DWORD")] uint dwCount);

        [DllImport("mfplat", EntryPoint = "MFConvertToFP16Array", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFConvertToFP16Array([NativeTypeName("WORD *")] ushort* pDest, [NativeTypeName("const float *")] float* pSrc, [NativeTypeName("DWORD")] uint dwCount);

        [DllImport("mfplat", EntryPoint = "MFCreate2DMediaBuffer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreate2DMediaBuffer([NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint dwFourCC, [NativeTypeName("BOOL")] int fBottomUp, [NativeTypeName("IMFMediaBuffer **")] IMFMediaBuffer** ppBuffer);

        [DllImport("mfplat", EntryPoint = "MFCreateMediaBufferFromMediaType", ExactSpelling = true)]
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
            return (uint)unPacked;
        }

        [return: NativeTypeName("UINT64")]
        public static ulong Pack2UINT32AsUINT64([NativeTypeName("UINT32")] uint unHigh, [NativeTypeName("UINT32")] uint unLow)
        {
            return ((ulong)unHigh << 32) | unLow;
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
            return Pack2UINT32AsUINT64((uint)nNumerator, unDenominator);
        }

        public static void UnpackRatio([NativeTypeName("UINT64")] ulong unPacked, [NativeTypeName("INT32 *")] int* pnNumerator, [NativeTypeName("UINT32 *")] uint* punDenominator)
        {
            Unpack2UINT32AsUINT64(unPacked, (uint*)pnNumerator, punDenominator);
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
            int hr = ((int)0);

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

        [DllImport("mfplat", EntryPoint = "MFCreateCollection", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateCollection([NativeTypeName("IMFCollection **")] IMFCollection** ppIMFCollection);

        [DllImport("mfplat", EntryPoint = "MFHeapAlloc", ExactSpelling = true)]
        [return: NativeTypeName("void *")]
        public static extern void* MFHeapAlloc([NativeTypeName("size_t")] nuint nSize, [NativeTypeName("ULONG")] uint dwFlags, [NativeTypeName("char *")] sbyte* pszFile, int line, EAllocationType eat);

        [DllImport("mfplat", EntryPoint = "MFHeapFree", ExactSpelling = true)]
        public static extern void MFHeapFree([NativeTypeName("void *")] void* pv);

        [DllImport("mfplat", EntryPoint = "MFllMulDiv", ExactSpelling = true)]
        [return: NativeTypeName("LONGLONG")]
        public static extern long MFllMulDiv([NativeTypeName("LONGLONG")] long a, [NativeTypeName("LONGLONG")] long b, [NativeTypeName("LONGLONG")] long c, [NativeTypeName("LONGLONG")] long d);

        [DllImport("mfplat", EntryPoint = "MFGetContentProtectionSystemCLSID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetContentProtectionSystemCLSID([NativeTypeName("const GUID &")] Guid* guidProtectionSystemID, [NativeTypeName("CLSID *")] Guid* pclsid);

        [DllImport("mfplat", EntryPoint = "MFCombineSamples", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCombineSamples([NativeTypeName("IMFSample *")] IMFSample* pSample, [NativeTypeName("IMFSample *")] IMFSample* pSampleToAdd, [NativeTypeName("DWORD")] uint dwMaxMergedDurationInMS, [NativeTypeName("BOOL *")] int* pMerged);

        [DllImport("mfplat", EntryPoint = "MFSplitSample", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFSplitSample([NativeTypeName("IMFSample *")] IMFSample* pSample, [NativeTypeName("IMFSample **")] IMFSample** pOutputSamples, [NativeTypeName("DWORD")] uint dwOutputSampleMaxCount, [NativeTypeName("DWORD *")] uint* pdwOutputSampleCount);
    }
}
