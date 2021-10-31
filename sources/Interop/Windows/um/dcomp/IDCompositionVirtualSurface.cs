// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE471C51-5F53-4A24-8D3E-D0C39C30B3F0")]
    [NativeTypeName("struct IDCompositionVirtualSurface : IDCompositionSurface")]
    [NativeInheritance("IDCompositionSurface")]
    public unsafe partial struct IDCompositionVirtualSurface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionVirtualSurface*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionVirtualSurface*, uint>)(lpVtbl[1]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionVirtualSurface*, uint>)(lpVtbl[2]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, void** updateObject, POINT* updateOffset)
        {
            return ((delegate* unmanaged<IDCompositionVirtualSurface*, RECT*, Guid*, void**, POINT*, int>)(lpVtbl[3]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT EndDraw()
        {
            return ((delegate* unmanaged<IDCompositionVirtualSurface*, int>)(lpVtbl[4]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SuspendDraw()
        {
            return ((delegate* unmanaged<IDCompositionVirtualSurface*, int>)(lpVtbl[5]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ResumeDraw()
        {
            return ((delegate* unmanaged<IDCompositionVirtualSurface*, int>)(lpVtbl[6]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY)
        {
            return ((delegate* unmanaged<IDCompositionVirtualSurface*, RECT*, RECT*, int, int, int>)(lpVtbl[7]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Resize(uint width, uint height)
        {
            return ((delegate* unmanaged<IDCompositionVirtualSurface*, uint, uint, int>)(lpVtbl[8]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Trim([NativeTypeName("const RECT *")] RECT* rectangles, uint count)
        {
            return ((delegate* unmanaged<IDCompositionVirtualSurface*, RECT*, uint, int>)(lpVtbl[9]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), rectangles, count);
        }
    }
}
