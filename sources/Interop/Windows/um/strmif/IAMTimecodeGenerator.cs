// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B496CE0-811B-11CF-8C77-00AA006B6814")]
    [NativeTypeName("struct IAMTimecodeGenerator : IUnknown")]
    public unsafe partial struct IAMTimecodeGenerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMTimecodeGenerator*, Guid*, void**, int>)(lpVtbl[0]))((IAMTimecodeGenerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMTimecodeGenerator*, uint>)(lpVtbl[1]))((IAMTimecodeGenerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMTimecodeGenerator*, uint>)(lpVtbl[2]))((IAMTimecodeGenerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTCGMode([NativeTypeName("long")] int Param, [NativeTypeName("long *")] int* pValue)
        {
            return ((delegate* stdcall<IAMTimecodeGenerator*, int, int*, int>)(lpVtbl[3]))((IAMTimecodeGenerator*)Unsafe.AsPointer(ref this), Param, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTCGMode([NativeTypeName("long")] int Param, [NativeTypeName("long")] int Value)
        {
            return ((delegate* stdcall<IAMTimecodeGenerator*, int, int, int>)(lpVtbl[4]))((IAMTimecodeGenerator*)Unsafe.AsPointer(ref this), Param, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_VITCLine([NativeTypeName("long")] int Line)
        {
            return ((delegate* stdcall<IAMTimecodeGenerator*, int, int>)(lpVtbl[5]))((IAMTimecodeGenerator*)Unsafe.AsPointer(ref this), Line);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VITCLine([NativeTypeName("long *")] int* pLine)
        {
            return ((delegate* stdcall<IAMTimecodeGenerator*, int*, int>)(lpVtbl[6]))((IAMTimecodeGenerator*)Unsafe.AsPointer(ref this), pLine);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTimecode([NativeTypeName("PTIMECODE_SAMPLE")] TIMECODE_SAMPLE* pTimecodeSample)
        {
            return ((delegate* stdcall<IAMTimecodeGenerator*, TIMECODE_SAMPLE*, int>)(lpVtbl[7]))((IAMTimecodeGenerator*)Unsafe.AsPointer(ref this), pTimecodeSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTimecode([NativeTypeName("PTIMECODE_SAMPLE")] TIMECODE_SAMPLE* pTimecodeSample)
        {
            return ((delegate* stdcall<IAMTimecodeGenerator*, TIMECODE_SAMPLE*, int>)(lpVtbl[8]))((IAMTimecodeGenerator*)Unsafe.AsPointer(ref this), pTimecodeSample);
        }
    }
}
