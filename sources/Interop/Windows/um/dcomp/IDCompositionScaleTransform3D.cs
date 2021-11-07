// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("2A9E9EAD-364B-4B15-A7C4-A1997F78B389")]
    [NativeTypeName("struct IDCompositionScaleTransform3D : IDCompositionTransform3D")]
    [NativeInheritance("IDCompositionTransform3D")]
    public unsafe partial struct IDCompositionScaleTransform3D : IDCompositionScaleTransform3D.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, uint>)(lpVtbl[1]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, uint>)(lpVtbl[2]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetScaleX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetScaleX(float scaleX)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[4]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetScaleY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetScaleY(float scaleY)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[6]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetScaleZ(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetScaleZ(float scaleZ)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[8]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetCenterX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetCenterX(float centerX)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[10]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetCenterY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetCenterY(float centerY)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[12]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetCenterZ(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetCenterZ(float centerZ)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[14]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerZ);
        }

        public interface Interface : IDCompositionTransform3D.Interface
        {
            [VtblIndex(3)]
            HRESULT SetScaleX(IDCompositionAnimation* animation);

            [VtblIndex(4)]
            HRESULT SetScaleX(float scaleX);

            [VtblIndex(5)]
            HRESULT SetScaleY(IDCompositionAnimation* animation);

            [VtblIndex(6)]
            HRESULT SetScaleY(float scaleY);

            [VtblIndex(7)]
            HRESULT SetScaleZ(IDCompositionAnimation* animation);

            [VtblIndex(8)]
            HRESULT SetScaleZ(float scaleZ);

            [VtblIndex(9)]
            HRESULT SetCenterX(IDCompositionAnimation* animation);

            [VtblIndex(10)]
            HRESULT SetCenterX(float centerX);

            [VtblIndex(11)]
            HRESULT SetCenterY(IDCompositionAnimation* animation);

            [VtblIndex(12)]
            HRESULT SetCenterY(float centerY);

            [VtblIndex(13)]
            HRESULT SetCenterZ(IDCompositionAnimation* animation);

            [VtblIndex(14)]
            HRESULT SetCenterZ(float centerZ);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, uint> Release;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int> SetScaleX;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, float, int> SetScaleX1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int> SetScaleY;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, float, int> SetScaleY1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int> SetScaleZ;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, float, int> SetScaleZ1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int> SetCenterX;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, float, int> SetCenterX1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int> SetCenterY;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, float, int> SetCenterY1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int> SetCenterZ;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionScaleTransform3D*, float, int> SetCenterZ1;
        }
    }
}
