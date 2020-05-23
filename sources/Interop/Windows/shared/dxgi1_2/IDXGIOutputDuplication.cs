// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("191CFAC3-A341-470D-B26E-A864F428319C")]
    public unsafe partial struct IDXGIOutputDuplication
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIOutputDuplication* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIOutputDuplication* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIOutputDuplication* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGIOutputDuplication* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGIOutputDuplication* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGIOutputDuplication* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGIOutputDuplication* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDesc(IDXGIOutputDuplication* pThis, [NativeTypeName("DXGI_OUTDUPL_DESC *")] DXGI_OUTDUPL_DESC* pDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AcquireNextFrame(IDXGIOutputDuplication* pThis, [NativeTypeName("UINT")] uint TimeoutInMilliseconds, [NativeTypeName("DXGI_OUTDUPL_FRAME_INFO *")] DXGI_OUTDUPL_FRAME_INFO* pFrameInfo, [NativeTypeName("IDXGIResource **")] IDXGIResource** ppDesktopResource);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameDirtyRects(IDXGIOutputDuplication* pThis, [NativeTypeName("UINT")] uint DirtyRectsBufferSize, [NativeTypeName("RECT *")] RECT* pDirtyRectsBuffer, [NativeTypeName("UINT *")] uint* pDirtyRectsBufferSizeRequired);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameMoveRects(IDXGIOutputDuplication* pThis, [NativeTypeName("UINT")] uint MoveRectsBufferSize, [NativeTypeName("DXGI_OUTDUPL_MOVE_RECT *")] DXGI_OUTDUPL_MOVE_RECT* pMoveRectBuffer, [NativeTypeName("UINT *")] uint* pMoveRectsBufferSizeRequired);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFramePointerShape(IDXGIOutputDuplication* pThis, [NativeTypeName("UINT")] uint PointerShapeBufferSize, [NativeTypeName("void *")] void* pPointerShapeBuffer, [NativeTypeName("UINT *")] uint* pPointerShapeBufferSizeRequired, [NativeTypeName("DXGI_OUTDUPL_POINTER_SHAPE_INFO *")] DXGI_OUTDUPL_POINTER_SHAPE_INFO* pPointerShapeInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MapDesktopSurface(IDXGIOutputDuplication* pThis, [NativeTypeName("DXGI_MAPPED_RECT *")] DXGI_MAPPED_RECT* pLockedRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnMapDesktopSurface(IDXGIOutputDuplication* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReleaseFrame(IDXGIOutputDuplication* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        public void GetDesc([NativeTypeName("DXGI_OUTDUPL_DESC *")] DXGI_OUTDUPL_DESC* pDesc)
        {
            Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int AcquireNextFrame([NativeTypeName("UINT")] uint TimeoutInMilliseconds, [NativeTypeName("DXGI_OUTDUPL_FRAME_INFO *")] DXGI_OUTDUPL_FRAME_INFO* pFrameInfo, [NativeTypeName("IDXGIResource **")] IDXGIResource** ppDesktopResource)
        {
            return Marshal.GetDelegateForFunctionPointer<_AcquireNextFrame>(lpVtbl->AcquireNextFrame)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameDirtyRects([NativeTypeName("UINT")] uint DirtyRectsBufferSize, [NativeTypeName("RECT *")] RECT* pDirtyRectsBuffer, [NativeTypeName("UINT *")] uint* pDirtyRectsBufferSizeRequired)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFrameDirtyRects>(lpVtbl->GetFrameDirtyRects)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameMoveRects([NativeTypeName("UINT")] uint MoveRectsBufferSize, [NativeTypeName("DXGI_OUTDUPL_MOVE_RECT *")] DXGI_OUTDUPL_MOVE_RECT* pMoveRectBuffer, [NativeTypeName("UINT *")] uint* pMoveRectsBufferSizeRequired)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFrameMoveRects>(lpVtbl->GetFrameMoveRects)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFramePointerShape([NativeTypeName("UINT")] uint PointerShapeBufferSize, [NativeTypeName("void *")] void* pPointerShapeBuffer, [NativeTypeName("UINT *")] uint* pPointerShapeBufferSizeRequired, [NativeTypeName("DXGI_OUTDUPL_POINTER_SHAPE_INFO *")] DXGI_OUTDUPL_POINTER_SHAPE_INFO* pPointerShapeInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFramePointerShape>(lpVtbl->GetFramePointerShape)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapDesktopSurface([NativeTypeName("DXGI_MAPPED_RECT *")] DXGI_MAPPED_RECT* pLockedRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_MapDesktopSurface>(lpVtbl->MapDesktopSurface)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), pLockedRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnMapDesktopSurface()
        {
            return Marshal.GetDelegateForFunctionPointer<_UnMapDesktopSurface>(lpVtbl->UnMapDesktopSurface)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseFrame()
        {
            return Marshal.GetDelegateForFunctionPointer<_ReleaseFrame>(lpVtbl->ReleaseFrame)((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetParent;

            [NativeTypeName("void (DXGI_OUTDUPL_DESC *) __attribute__((stdcall))")]
            public IntPtr GetDesc;

            [NativeTypeName("HRESULT (UINT, DXGI_OUTDUPL_FRAME_INFO *, IDXGIResource **) __attribute__((stdcall))")]
            public IntPtr AcquireNextFrame;

            [NativeTypeName("HRESULT (UINT, RECT *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetFrameDirtyRects;

            [NativeTypeName("HRESULT (UINT, DXGI_OUTDUPL_MOVE_RECT *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetFrameMoveRects;

            [NativeTypeName("HRESULT (UINT, void *, UINT *, DXGI_OUTDUPL_POINTER_SHAPE_INFO *) __attribute__((stdcall))")]
            public IntPtr GetFramePointerShape;

            [NativeTypeName("HRESULT (DXGI_MAPPED_RECT *) __attribute__((stdcall))")]
            public IntPtr MapDesktopSurface;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr UnMapDesktopSurface;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr ReleaseFrame;
        }
    }
}
