// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("45D4D0B7-1BD4-454E-8894-2BFA68443033")]
    [NativeTypeName("struct IDCompositionGaussianBlurEffect : IDCompositionFilterEffect")]
    [NativeInheritance("IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionGaussianBlurEffect : IDCompositionGaussianBlurEffect.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionGaussianBlurEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionGaussianBlurEffect*, uint>)(lpVtbl[1]))((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionGaussianBlurEffect*, uint>)(lpVtbl[2]))((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetInput(uint index, IUnknown* input, uint flags)
        {
            return ((delegate* unmanaged<IDCompositionGaussianBlurEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetStandardDeviation(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionGaussianBlurEffect*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetStandardDeviation(float amount)
        {
            return ((delegate* unmanaged<IDCompositionGaussianBlurEffect*, float, int>)(lpVtbl[5]))((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetBorderMode(D2D1_BORDER_MODE mode)
        {
            return ((delegate* unmanaged<IDCompositionGaussianBlurEffect*, D2D1_BORDER_MODE, int>)(lpVtbl[6]))((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), mode);
        }

        public interface Interface : IDCompositionFilterEffect.Interface
        {
            [VtblIndex(4)]
            HRESULT SetStandardDeviation(IDCompositionAnimation* animation);

            [VtblIndex(5)]
            HRESULT SetStandardDeviation(float amount);

            [VtblIndex(6)]
            HRESULT SetBorderMode(D2D1_BORDER_MODE mode);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionGaussianBlurEffect*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionGaussianBlurEffect*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionGaussianBlurEffect*, uint> Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionGaussianBlurEffect*, uint, IUnknown*, uint, int> SetInput;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionGaussianBlurEffect*, IDCompositionAnimation*, int> SetStandardDeviation;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionGaussianBlurEffect*, float, int> SetStandardDeviation1;

            [NativeTypeName("HRESULT (D2D1_BORDER_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionGaussianBlurEffect*, D2D1_BORDER_MODE, int> SetBorderMode;
        }
    }
}
