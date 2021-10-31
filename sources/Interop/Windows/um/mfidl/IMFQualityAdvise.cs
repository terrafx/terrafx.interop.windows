// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EC15E2E9-E36B-4F7C-8758-77D452EF4CE7")]
    [NativeTypeName("struct IMFQualityAdvise : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFQualityAdvise
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFQualityAdvise*, Guid*, void**, int>)(lpVtbl[0]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFQualityAdvise*, uint>)(lpVtbl[1]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFQualityAdvise*, uint>)(lpVtbl[2]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetDropMode(MF_QUALITY_DROP_MODE eDropMode)
        {
            return ((delegate* unmanaged<IMFQualityAdvise*, MF_QUALITY_DROP_MODE, int>)(lpVtbl[3]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), eDropMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetQualityLevel(MF_QUALITY_LEVEL eQualityLevel)
        {
            return ((delegate* unmanaged<IMFQualityAdvise*, MF_QUALITY_LEVEL, int>)(lpVtbl[4]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), eQualityLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetDropMode(MF_QUALITY_DROP_MODE* peDropMode)
        {
            return ((delegate* unmanaged<IMFQualityAdvise*, MF_QUALITY_DROP_MODE*, int>)(lpVtbl[5]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), peDropMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetQualityLevel(MF_QUALITY_LEVEL* peQualityLevel)
        {
            return ((delegate* unmanaged<IMFQualityAdvise*, MF_QUALITY_LEVEL*, int>)(lpVtbl[6]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), peQualityLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT DropTime([NativeTypeName("LONGLONG")] long hnsAmountToDrop)
        {
            return ((delegate* unmanaged<IMFQualityAdvise*, long, int>)(lpVtbl[7]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), hnsAmountToDrop);
        }
    }
}
