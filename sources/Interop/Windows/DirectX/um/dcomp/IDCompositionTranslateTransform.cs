// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("06791122-C6F0-417D-8323-269E987F5954")]
    [NativeTypeName("struct IDCompositionTranslateTransform : IDCompositionTransform")]
    [NativeInheritance("IDCompositionTransform")]
    public unsafe partial struct IDCompositionTranslateTransform : IDCompositionTranslateTransform.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform*, uint>)(lpVtbl[1]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform*, uint>)(lpVtbl[2]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetOffsetX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetOffsetX(float offsetX)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform*, float, int>)(lpVtbl[4]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), offsetX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetOffsetY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetOffsetY(float offsetY)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform*, float, int>)(lpVtbl[6]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), offsetY);
        }

        public interface Interface : IDCompositionTransform.Interface
        {
            [VtblIndex(3)]
            HRESULT SetOffsetX(IDCompositionAnimation* animation);

            [VtblIndex(4)]
            HRESULT SetOffsetX(float offsetX);

            [VtblIndex(5)]
            HRESULT SetOffsetY(IDCompositionAnimation* animation);

            [VtblIndex(6)]
            HRESULT SetOffsetY(float offsetY);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTranslateTransform*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTranslateTransform*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTranslateTransform*, uint> Release;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTranslateTransform*, IDCompositionAnimation*, int> SetOffsetX;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTranslateTransform*, float, int> SetOffsetX1;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTranslateTransform*, IDCompositionAnimation*, int> SetOffsetY;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionTranslateTransform*, float, int> SetOffsetY1;
        }
    }
}
