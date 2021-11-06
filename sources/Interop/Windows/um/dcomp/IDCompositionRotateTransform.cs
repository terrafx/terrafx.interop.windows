// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("641ED83C-AE96-46C5-90DC-32774CC5C6D5")]
    [NativeTypeName("struct IDCompositionRotateTransform : IDCompositionTransform")]
    [NativeInheritance("IDCompositionTransform")]
    public unsafe partial struct IDCompositionRotateTransform : IDCompositionRotateTransform.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform*, uint>)(lpVtbl[1]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform*, uint>)(lpVtbl[2]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetAngle(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetAngle(float angle)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform*, float, int>)(lpVtbl[4]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), angle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetCenterX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetCenterX(float centerX)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform*, float, int>)(lpVtbl[6]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), centerX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetCenterY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetCenterY(float centerY)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform*, float, int>)(lpVtbl[8]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), centerY);
        }

        public interface Interface : IDCompositionTransform.Interface
        {
            [VtblIndex(3)]
            HRESULT SetAngle(IDCompositionAnimation* animation);

            [VtblIndex(4)]
            HRESULT SetAngle(float angle);

            [VtblIndex(5)]
            HRESULT SetCenterX(IDCompositionAnimation* animation);

            [VtblIndex(6)]
            HRESULT SetCenterX(float centerX);

            [VtblIndex(7)]
            HRESULT SetCenterY(IDCompositionAnimation* animation);

            [VtblIndex(8)]
            HRESULT SetCenterY(float centerY);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRotateTransform*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRotateTransform*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRotateTransform*, uint> Release;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRotateTransform*, IDCompositionAnimation*, int> SetAngle;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRotateTransform*, float, int> SetAngle1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRotateTransform*, IDCompositionAnimation*, int> SetCenterX;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRotateTransform*, float, int> SetCenterX1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRotateTransform*, IDCompositionAnimation*, int> SetCenterY;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionRotateTransform*, float, int> SetCenterY1;
        }
    }
}
