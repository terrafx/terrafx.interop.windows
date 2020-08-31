// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("88DDCD21-03C3-4275-91ED-55EE3929328F")]
    [NativeTypeName("struct IMFRateControl : IUnknown")]
    public unsafe partial struct IMFRateControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFRateControl*, Guid*, void**, int>)(lpVtbl[0]))((IMFRateControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFRateControl*, uint>)(lpVtbl[1]))((IMFRateControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFRateControl*, uint>)(lpVtbl[2]))((IMFRateControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRate([NativeTypeName("BOOL")] int fThin, float flRate)
        {
            return ((delegate* stdcall<IMFRateControl*, int, float, int>)(lpVtbl[3]))((IMFRateControl*)Unsafe.AsPointer(ref this), fThin, flRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRate([NativeTypeName("BOOL *")] int* pfThin, [NativeTypeName("float *")] float* pflRate)
        {
            return ((delegate* stdcall<IMFRateControl*, int*, float*, int>)(lpVtbl[4]))((IMFRateControl*)Unsafe.AsPointer(ref this), pfThin, pflRate);
        }
    }
}
