// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F6E4C0A0-46D9-4FB8-BE21-57A3EF2B626C")]
    public unsafe partial struct IAudioClockAdjustment
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioClockAdjustment*, Guid*, void**, int>)(lpVtbl[0]))((IAudioClockAdjustment*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioClockAdjustment*, uint>)(lpVtbl[1]))((IAudioClockAdjustment*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioClockAdjustment*, uint>)(lpVtbl[2]))((IAudioClockAdjustment*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSampleRate(float flSampleRate)
        {
            return ((delegate* stdcall<IAudioClockAdjustment*, float, int>)(lpVtbl[3]))((IAudioClockAdjustment*)Unsafe.AsPointer(ref this), flSampleRate);
        }
    }
}
