// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E57AA735-DCDB-4C72-9C61-0591F58889EE")]
    [NativeTypeName("struct IDCompositionSkewTransform : IDCompositionTransform")]
    [NativeInheritance("IDCompositionTransform")]
    public unsafe partial struct IDCompositionSkewTransform : IDCompositionSkewTransform.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, uint>)(lpVtbl[1]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, uint>)(lpVtbl[2]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetAngleX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetAngleX(float angleX)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, float, int>)(lpVtbl[4]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), angleX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetAngleY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetAngleY(float angleY)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, float, int>)(lpVtbl[6]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), angleY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetCenterX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetCenterX(float centerX)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, float, int>)(lpVtbl[8]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), centerX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetCenterY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetCenterY(float centerY)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, float, int>)(lpVtbl[10]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), centerY);
        }

        public interface Interface : IDCompositionTransform.Interface
        {
            [VtblIndex(3)]
            HRESULT SetAngleX(IDCompositionAnimation* animation);

            [VtblIndex(4)]
            HRESULT SetAngleX(float angleX);

            [VtblIndex(5)]
            HRESULT SetAngleY(IDCompositionAnimation* animation);

            [VtblIndex(6)]
            HRESULT SetAngleY(float angleY);

            [VtblIndex(7)]
            HRESULT SetCenterX(IDCompositionAnimation* animation);

            [VtblIndex(8)]
            HRESULT SetCenterX(float centerX);

            [VtblIndex(9)]
            HRESULT SetCenterY(IDCompositionAnimation* animation);

            [VtblIndex(10)]
            HRESULT SetCenterY(float centerY);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSkewTransform*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSkewTransform*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSkewTransform*, uint> Release;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSkewTransform*, IDCompositionAnimation*, int> SetAngleX;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSkewTransform*, float, int> SetAngleX1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSkewTransform*, IDCompositionAnimation*, int> SetAngleY;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSkewTransform*, float, int> SetAngleY1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSkewTransform*, IDCompositionAnimation*, int> SetCenterX;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSkewTransform*, float, int> SetCenterX1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSkewTransform*, IDCompositionAnimation*, int> SetCenterY;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSkewTransform*, float, int> SetCenterY1;
        }
    }
}
