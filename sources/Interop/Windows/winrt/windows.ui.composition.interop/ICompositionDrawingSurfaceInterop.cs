// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FD04E6E3-FE0C-4C3C-AB19-A07601A576EE")]
    [NativeTypeName("struct ICompositionDrawingSurfaceInterop : IUnknown")]
    public unsafe partial struct ICompositionDrawingSurfaceInterop
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop*, uint>)(lpVtbl[1]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop*, uint>)(lpVtbl[2]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** updateObject, [NativeTypeName("POINT *")] POINT* updateOffset)
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop*, RECT*, Guid*, void**, POINT*, int>)(lpVtbl[3]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop*, int>)(lpVtbl[4]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Resize(SIZE sizePixels)
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop*, SIZE, int>)(lpVtbl[5]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this), sizePixels);
        }

        [return: NativeTypeName("HRESULT")]
        public int Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY)
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop*, RECT*, RECT*, int, int, int>)(lpVtbl[6]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
        }

        [return: NativeTypeName("HRESULT")]
        public int ResumeDraw()
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop*, int>)(lpVtbl[7]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SuspendDraw()
        {
            return ((delegate* stdcall<ICompositionDrawingSurfaceInterop*, int>)(lpVtbl[8]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
        }
    }
}
