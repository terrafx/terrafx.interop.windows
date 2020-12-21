// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B496CE1-811B-11CF-8C77-00AA006B6814")]
    [NativeTypeName("struct IAMTimecodeReader : IUnknown")]
    public unsafe partial struct IAMTimecodeReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAMTimecodeReader*, Guid*, void**, int>)(lpVtbl[0]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAMTimecodeReader*, uint>)(lpVtbl[1]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAMTimecodeReader*, uint>)(lpVtbl[2]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTCRMode([NativeTypeName("long")] int Param, [NativeTypeName("long *")] int* pValue)
        {
            return ((delegate* unmanaged[Stdcall]<IAMTimecodeReader*, int, int*, int>)(lpVtbl[3]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this), Param, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTCRMode([NativeTypeName("long")] int Param, [NativeTypeName("long")] int Value)
        {
            return ((delegate* unmanaged[Stdcall]<IAMTimecodeReader*, int, int, int>)(lpVtbl[4]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this), Param, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_VITCLine([NativeTypeName("long")] int Line)
        {
            return ((delegate* unmanaged[Stdcall]<IAMTimecodeReader*, int, int>)(lpVtbl[5]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this), Line);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VITCLine([NativeTypeName("long *")] int* pLine)
        {
            return ((delegate* unmanaged[Stdcall]<IAMTimecodeReader*, int*, int>)(lpVtbl[6]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this), pLine);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTimecode([NativeTypeName("PTIMECODE_SAMPLE")] TIMECODE_SAMPLE* pTimecodeSample)
        {
            return ((delegate* unmanaged[Stdcall]<IAMTimecodeReader*, TIMECODE_SAMPLE*, int>)(lpVtbl[7]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this), pTimecodeSample);
        }
    }
}
