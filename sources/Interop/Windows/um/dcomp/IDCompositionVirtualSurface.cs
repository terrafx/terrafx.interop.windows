// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE471C51-5F53-4A24-8D3E-D0C39C30B3F0")]
    [NativeTypeName("struct IDCompositionVirtualSurface : IDCompositionSurface")]
    public unsafe partial struct IDCompositionVirtualSurface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, uint>)(lpVtbl[1]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, uint>)(lpVtbl[2]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** updateObject, [NativeTypeName("POINT *")] POINT* updateOffset)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, RECT*, Guid*, void**, POINT*, int>)(lpVtbl[3]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, int>)(lpVtbl[4]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SuspendDraw()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, int>)(lpVtbl[5]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResumeDraw()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, int>)(lpVtbl[6]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, RECT*, RECT*, int, int, int>)(lpVtbl[7]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resize([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, uint, uint, int>)(lpVtbl[8]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Trim([NativeTypeName("const RECT *")] RECT* rectangles, [NativeTypeName("UINT")] uint count)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, RECT*, uint, int>)(lpVtbl[9]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), rectangles, count);
        }
    }
}
