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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDXGIOutputDuplication*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDXGIOutputDuplication*, uint>)(lpVtbl[1]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDXGIOutputDuplication*, uint>)(lpVtbl[2]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<IDXGIOutputDuplication*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* stdcall<IDXGIOutputDuplication*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return ((delegate* stdcall<IDXGIOutputDuplication*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        public void GetDesc([NativeTypeName("DXGI_OUTDUPL_DESC *")] DXGI_OUTDUPL_DESC* pDesc)
        {
            ((delegate* stdcall<IDXGIOutputDuplication*, DXGI_OUTDUPL_DESC*, void>)(lpVtbl[7]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int AcquireNextFrame([NativeTypeName("UINT")] uint TimeoutInMilliseconds, [NativeTypeName("DXGI_OUTDUPL_FRAME_INFO *")] DXGI_OUTDUPL_FRAME_INFO* pFrameInfo, [NativeTypeName("IDXGIResource **")] IDXGIResource** ppDesktopResource)
        {
            return ((delegate* stdcall<IDXGIOutputDuplication*, uint, DXGI_OUTDUPL_FRAME_INFO*, IDXGIResource**, int>)(lpVtbl[8]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameDirtyRects([NativeTypeName("UINT")] uint DirtyRectsBufferSize, [NativeTypeName("RECT *")] RECT* pDirtyRectsBuffer, [NativeTypeName("UINT *")] uint* pDirtyRectsBufferSizeRequired)
        {
            return ((delegate* stdcall<IDXGIOutputDuplication*, uint, RECT*, uint*, int>)(lpVtbl[9]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameMoveRects([NativeTypeName("UINT")] uint MoveRectsBufferSize, [NativeTypeName("DXGI_OUTDUPL_MOVE_RECT *")] DXGI_OUTDUPL_MOVE_RECT* pMoveRectBuffer, [NativeTypeName("UINT *")] uint* pMoveRectsBufferSizeRequired)
        {
            return ((delegate* stdcall<IDXGIOutputDuplication*, uint, DXGI_OUTDUPL_MOVE_RECT*, uint*, int>)(lpVtbl[10]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFramePointerShape([NativeTypeName("UINT")] uint PointerShapeBufferSize, [NativeTypeName("void *")] void* pPointerShapeBuffer, [NativeTypeName("UINT *")] uint* pPointerShapeBufferSizeRequired, [NativeTypeName("DXGI_OUTDUPL_POINTER_SHAPE_INFO *")] DXGI_OUTDUPL_POINTER_SHAPE_INFO* pPointerShapeInfo)
        {
            return ((delegate* stdcall<IDXGIOutputDuplication*, uint, void*, uint*, DXGI_OUTDUPL_POINTER_SHAPE_INFO*, int>)(lpVtbl[11]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapDesktopSurface([NativeTypeName("DXGI_MAPPED_RECT *")] DXGI_MAPPED_RECT* pLockedRect)
        {
            return ((delegate* stdcall<IDXGIOutputDuplication*, DXGI_MAPPED_RECT*, int>)(lpVtbl[12]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), pLockedRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnMapDesktopSurface()
        {
            return ((delegate* stdcall<IDXGIOutputDuplication*, int>)(lpVtbl[13]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseFrame()
        {
            return ((delegate* stdcall<IDXGIOutputDuplication*, int>)(lpVtbl[14]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }
    }
}
