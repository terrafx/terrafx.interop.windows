// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IQualProp : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IQualProp : IQualProp.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IQualProp*, Guid*, void**, int>)(lpVtbl[0]))((IQualProp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IQualProp*, uint>)(lpVtbl[1]))((IQualProp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IQualProp*, uint>)(lpVtbl[2]))((IQualProp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_FramesDroppedInRenderer(int* pcFrames)
        {
            return ((delegate* unmanaged<IQualProp*, int*, int>)(lpVtbl[3]))((IQualProp*)Unsafe.AsPointer(ref this), pcFrames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_FramesDrawn(int* pcFramesDrawn)
        {
            return ((delegate* unmanaged<IQualProp*, int*, int>)(lpVtbl[4]))((IQualProp*)Unsafe.AsPointer(ref this), pcFramesDrawn);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT get_AvgFrameRate(int* piAvgFrameRate)
        {
            return ((delegate* unmanaged<IQualProp*, int*, int>)(lpVtbl[5]))((IQualProp*)Unsafe.AsPointer(ref this), piAvgFrameRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT get_Jitter(int* iJitter)
        {
            return ((delegate* unmanaged<IQualProp*, int*, int>)(lpVtbl[6]))((IQualProp*)Unsafe.AsPointer(ref this), iJitter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_AvgSyncOffset(int* piAvg)
        {
            return ((delegate* unmanaged<IQualProp*, int*, int>)(lpVtbl[7]))((IQualProp*)Unsafe.AsPointer(ref this), piAvg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_DevSyncOffset(int* piDev)
        {
            return ((delegate* unmanaged<IQualProp*, int*, int>)(lpVtbl[8]))((IQualProp*)Unsafe.AsPointer(ref this), piDev);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT get_FramesDroppedInRenderer(int* pcFrames);

            [VtblIndex(4)]
            HRESULT get_FramesDrawn(int* pcFramesDrawn);

            [VtblIndex(5)]
            HRESULT get_AvgFrameRate(int* piAvgFrameRate);

            [VtblIndex(6)]
            HRESULT get_Jitter(int* iJitter);

            [VtblIndex(7)]
            HRESULT get_AvgSyncOffset(int* piAvg);

            [VtblIndex(8)]
            HRESULT get_DevSyncOffset(int* piDev);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IQualProp*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IQualProp*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IQualProp*, uint> Release;

            [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IQualProp*, int*, int> get_FramesDroppedInRenderer;

            [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IQualProp*, int*, int> get_FramesDrawn;

            [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IQualProp*, int*, int> get_AvgFrameRate;

            [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IQualProp*, int*, int> get_Jitter;

            [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IQualProp*, int*, int> get_AvgSyncOffset;

            [NativeTypeName("HRESULT (int *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IQualProp*, int*, int> get_DevSyncOffset;
        }
    }
}
