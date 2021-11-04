// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("54298223-41E1-4A41-9C08-02E8256864A1")]
    [NativeTypeName("struct ISurfaceImageSourceNativeWithD2D : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISurfaceImageSourceNativeWithD2D
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, Guid*, void**, int>)(lpVtbl[0]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, uint>)(lpVtbl[1]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, uint>)(lpVtbl[2]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetDevice(IUnknown* device)
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, IUnknown*, int>)(lpVtbl[3]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this), device);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT BeginDraw([NativeTypeName("const RECT &")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, void** updateObject, POINT* offset)
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, RECT*, Guid*, void**, POINT*, int>)(lpVtbl[4]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT EndDraw()
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, int>)(lpVtbl[5]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SuspendDraw()
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, int>)(lpVtbl[6]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ResumeDraw()
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, int>)(lpVtbl[7]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, IUnknown*, int> SetDevice;

            [NativeTypeName("HRESULT (const RECT &, const IID &, void **, POINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, RECT*, Guid*, void**, POINT*, int> BeginDraw;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, int> EndDraw;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, int> SuspendDraw;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, int> ResumeDraw;
        }
    }
}
