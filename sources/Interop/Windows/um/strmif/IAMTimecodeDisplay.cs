// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B496CE2-811B-11CF-8C77-00AA006B6814")]
    [NativeTypeName("struct IAMTimecodeDisplay : IUnknown")]
    public unsafe partial struct IAMTimecodeDisplay
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAMTimecodeDisplay*, Guid*, void**, int>)(lpVtbl[0]))((IAMTimecodeDisplay*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMTimecodeDisplay*, uint>)(lpVtbl[1]))((IAMTimecodeDisplay*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMTimecodeDisplay*, uint>)(lpVtbl[2]))((IAMTimecodeDisplay*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTCDisplayEnable([NativeTypeName("long *")] int* pState)
        {
            return ((delegate* unmanaged<IAMTimecodeDisplay*, int*, int>)(lpVtbl[3]))((IAMTimecodeDisplay*)Unsafe.AsPointer(ref this), pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTCDisplayEnable([NativeTypeName("long")] int State)
        {
            return ((delegate* unmanaged<IAMTimecodeDisplay*, int, int>)(lpVtbl[4]))((IAMTimecodeDisplay*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTCDisplay([NativeTypeName("long")] int Param, [NativeTypeName("long *")] int* pValue)
        {
            return ((delegate* unmanaged<IAMTimecodeDisplay*, int, int*, int>)(lpVtbl[5]))((IAMTimecodeDisplay*)Unsafe.AsPointer(ref this), Param, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTCDisplay([NativeTypeName("long")] int Param, [NativeTypeName("long")] int Value)
        {
            return ((delegate* unmanaged<IAMTimecodeDisplay*, int, int, int>)(lpVtbl[6]))((IAMTimecodeDisplay*)Unsafe.AsPointer(ref this), Param, Value);
        }
    }
}
