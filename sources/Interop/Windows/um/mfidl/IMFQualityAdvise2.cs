// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F3706F0D-8EA2-4886-8000-7155E9EC2EAE")]
    [NativeTypeName("struct IMFQualityAdvise2 : IMFQualityAdvise")]
    public unsafe partial struct IMFQualityAdvise2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFQualityAdvise2*, Guid*, void**, int>)(lpVtbl[0]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFQualityAdvise2*, uint>)(lpVtbl[1]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFQualityAdvise2*, uint>)(lpVtbl[2]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDropMode(MF_QUALITY_DROP_MODE eDropMode)
        {
            return ((delegate* stdcall<IMFQualityAdvise2*, MF_QUALITY_DROP_MODE, int>)(lpVtbl[3]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this), eDropMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetQualityLevel(MF_QUALITY_LEVEL eQualityLevel)
        {
            return ((delegate* stdcall<IMFQualityAdvise2*, MF_QUALITY_LEVEL, int>)(lpVtbl[4]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this), eQualityLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDropMode([NativeTypeName("MF_QUALITY_DROP_MODE *")] MF_QUALITY_DROP_MODE* peDropMode)
        {
            return ((delegate* stdcall<IMFQualityAdvise2*, MF_QUALITY_DROP_MODE*, int>)(lpVtbl[5]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this), peDropMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQualityLevel([NativeTypeName("MF_QUALITY_LEVEL *")] MF_QUALITY_LEVEL* peQualityLevel)
        {
            return ((delegate* stdcall<IMFQualityAdvise2*, MF_QUALITY_LEVEL*, int>)(lpVtbl[6]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this), peQualityLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int DropTime([NativeTypeName("LONGLONG")] long hnsAmountToDrop)
        {
            return ((delegate* stdcall<IMFQualityAdvise2*, long, int>)(lpVtbl[7]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this), hnsAmountToDrop);
        }

        [return: NativeTypeName("HRESULT")]
        public int NotifyQualityEvent([NativeTypeName("IMFMediaEvent *")] IMFMediaEvent* pEvent, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* stdcall<IMFQualityAdvise2*, IMFMediaEvent*, uint*, int>)(lpVtbl[8]))((IMFQualityAdvise2*)Unsafe.AsPointer(ref this), pEvent, pdwFlags);
        }
    }
}
