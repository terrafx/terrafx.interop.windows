// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("54298223-41E1-4A41-9C08-02E8256864A1")]
    [NativeTypeName("struct ISurfaceImageSourceNativeWithD2D : IUnknown")]
    public unsafe partial struct ISurfaceImageSourceNativeWithD2D
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, Guid*, void**, int>)(lpVtbl[0]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, uint>)(lpVtbl[1]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, uint>)(lpVtbl[2]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDevice(IUnknown* device)
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, IUnknown*, int>)(lpVtbl[3]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this), device);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginDraw([NativeTypeName("const RECT &")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, void** updateObject, POINT* offset)
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, RECT*, Guid*, void**, POINT*, int>)(lpVtbl[4]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, int>)(lpVtbl[5]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SuspendDraw()
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, int>)(lpVtbl[6]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResumeDraw()
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D*, int>)(lpVtbl[7]))((ISurfaceImageSourceNativeWithD2D*)Unsafe.AsPointer(ref this));
        }
    }
}
