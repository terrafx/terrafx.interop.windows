// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EC15E2E9-E36B-4F7C-8758-77D452EF4CE7")]
    [NativeTypeName("struct IMFQualityAdvise : IUnknown")]
    public unsafe partial struct IMFQualityAdvise
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFQualityAdvise*, Guid*, void**, int>)(lpVtbl[0]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFQualityAdvise*, uint>)(lpVtbl[1]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFQualityAdvise*, uint>)(lpVtbl[2]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDropMode(MF_QUALITY_DROP_MODE eDropMode)
        {
            return ((delegate* stdcall<IMFQualityAdvise*, MF_QUALITY_DROP_MODE, int>)(lpVtbl[3]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), eDropMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetQualityLevel(MF_QUALITY_LEVEL eQualityLevel)
        {
            return ((delegate* stdcall<IMFQualityAdvise*, MF_QUALITY_LEVEL, int>)(lpVtbl[4]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), eQualityLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDropMode([NativeTypeName("MF_QUALITY_DROP_MODE *")] MF_QUALITY_DROP_MODE* peDropMode)
        {
            return ((delegate* stdcall<IMFQualityAdvise*, MF_QUALITY_DROP_MODE*, int>)(lpVtbl[5]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), peDropMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetQualityLevel([NativeTypeName("MF_QUALITY_LEVEL *")] MF_QUALITY_LEVEL* peQualityLevel)
        {
            return ((delegate* stdcall<IMFQualityAdvise*, MF_QUALITY_LEVEL*, int>)(lpVtbl[6]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), peQualityLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DropTime([NativeTypeName("LONGLONG")] long hnsAmountToDrop)
        {
            return ((delegate* stdcall<IMFQualityAdvise*, long, int>)(lpVtbl[7]))((IMFQualityAdvise*)Unsafe.AsPointer(ref this), hnsAmountToDrop);
        }
    }
}
