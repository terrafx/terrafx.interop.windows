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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return lpVtbl->SetPrivateDataInterface((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return lpVtbl->GetParent((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        public void GetDesc([NativeTypeName("DXGI_OUTDUPL_DESC *")] DXGI_OUTDUPL_DESC* pDesc)
        {
            lpVtbl->GetDesc((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int AcquireNextFrame([NativeTypeName("UINT")] uint TimeoutInMilliseconds, [NativeTypeName("DXGI_OUTDUPL_FRAME_INFO *")] DXGI_OUTDUPL_FRAME_INFO* pFrameInfo, [NativeTypeName("IDXGIResource **")] IDXGIResource** ppDesktopResource)
        {
            return lpVtbl->AcquireNextFrame((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameDirtyRects([NativeTypeName("UINT")] uint DirtyRectsBufferSize, [NativeTypeName("RECT *")] RECT* pDirtyRectsBuffer, [NativeTypeName("UINT *")] uint* pDirtyRectsBufferSizeRequired)
        {
            return lpVtbl->GetFrameDirtyRects((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameMoveRects([NativeTypeName("UINT")] uint MoveRectsBufferSize, [NativeTypeName("DXGI_OUTDUPL_MOVE_RECT *")] DXGI_OUTDUPL_MOVE_RECT* pMoveRectBuffer, [NativeTypeName("UINT *")] uint* pMoveRectsBufferSizeRequired)
        {
            return lpVtbl->GetFrameMoveRects((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFramePointerShape([NativeTypeName("UINT")] uint PointerShapeBufferSize, [NativeTypeName("void *")] void* pPointerShapeBuffer, [NativeTypeName("UINT *")] uint* pPointerShapeBufferSizeRequired, [NativeTypeName("DXGI_OUTDUPL_POINTER_SHAPE_INFO *")] DXGI_OUTDUPL_POINTER_SHAPE_INFO* pPointerShapeInfo)
        {
            return lpVtbl->GetFramePointerShape((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapDesktopSurface([NativeTypeName("DXGI_MAPPED_RECT *")] DXGI_MAPPED_RECT* pLockedRect)
        {
            return lpVtbl->MapDesktopSurface((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), pLockedRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnMapDesktopSurface()
        {
            return lpVtbl->UnMapDesktopSurface((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseFrame()
        {
            return lpVtbl->ReleaseFrame((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, Guid*, void**, int> GetParent;

            [NativeTypeName("void (DXGI_OUTDUPL_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, DXGI_OUTDUPL_DESC*, void> GetDesc;

            [NativeTypeName("HRESULT (UINT, DXGI_OUTDUPL_FRAME_INFO *, IDXGIResource **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, uint, DXGI_OUTDUPL_FRAME_INFO*, IDXGIResource**, int> AcquireNextFrame;

            [NativeTypeName("HRESULT (UINT, RECT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, uint, RECT*, uint*, int> GetFrameDirtyRects;

            [NativeTypeName("HRESULT (UINT, DXGI_OUTDUPL_MOVE_RECT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, uint, DXGI_OUTDUPL_MOVE_RECT*, uint*, int> GetFrameMoveRects;

            [NativeTypeName("HRESULT (UINT, void *, UINT *, DXGI_OUTDUPL_POINTER_SHAPE_INFO *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, uint, void*, uint*, DXGI_OUTDUPL_POINTER_SHAPE_INFO*, int> GetFramePointerShape;

            [NativeTypeName("HRESULT (DXGI_MAPPED_RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, DXGI_MAPPED_RECT*, int> MapDesktopSurface;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, int> UnMapDesktopSurface;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutputDuplication*, int> ReleaseFrame;
        }
    }
}
