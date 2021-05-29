// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F6E4C0A0-46D9-4FB8-BE21-57A3EF2B626C")]
    [NativeTypeName("struct IAudioClockAdjustment : IUnknown")]
    public unsafe partial struct IAudioClockAdjustment
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioClockAdjustment*, Guid*, void**, int>)(lpVtbl[0]))((IAudioClockAdjustment*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioClockAdjustment*, uint>)(lpVtbl[1]))((IAudioClockAdjustment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioClockAdjustment*, uint>)(lpVtbl[2]))((IAudioClockAdjustment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSampleRate(float flSampleRate)
        {
            return ((delegate* unmanaged<IAudioClockAdjustment*, float, int>)(lpVtbl[3]))((IAudioClockAdjustment*)Unsafe.AsPointer(ref this), flSampleRate);
        }
    }
}
