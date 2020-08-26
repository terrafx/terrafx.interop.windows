// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4D5466B0-A49C-11D1-ABE8-00A0C905F375")]
    [NativeTypeName("struct IAMClockAdjust : IUnknown")]
    public unsafe partial struct IAMClockAdjust
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMClockAdjust*, Guid*, void**, int>)(lpVtbl[0]))((IAMClockAdjust*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMClockAdjust*, uint>)(lpVtbl[1]))((IAMClockAdjust*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMClockAdjust*, uint>)(lpVtbl[2]))((IAMClockAdjust*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClockDelta([NativeTypeName("REFERENCE_TIME")] long rtDelta)
        {
            return ((delegate* stdcall<IAMClockAdjust*, long, int>)(lpVtbl[3]))((IAMClockAdjust*)Unsafe.AsPointer(ref this), rtDelta);
        }
    }
}
