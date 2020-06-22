// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6EF2A662-47C0-4666-B13D-CBB717F2FA2C")]
    public unsafe partial struct IMFClockConsumer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFClockConsumer*, Guid*, void**, int>)(lpVtbl[0]))((IMFClockConsumer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFClockConsumer*, uint>)(lpVtbl[1]))((IMFClockConsumer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFClockConsumer*, uint>)(lpVtbl[2]))((IMFClockConsumer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPresentationClock([NativeTypeName("IMFPresentationClock *")] IMFPresentationClock* pPresentationClock)
        {
            return ((delegate* stdcall<IMFClockConsumer*, IMFPresentationClock*, int>)(lpVtbl[3]))((IMFClockConsumer*)Unsafe.AsPointer(ref this), pPresentationClock);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPresentationClock([NativeTypeName("IMFPresentationClock **")] IMFPresentationClock** ppPresentationClock)
        {
            return ((delegate* stdcall<IMFClockConsumer*, IMFPresentationClock**, int>)(lpVtbl[4]))((IMFClockConsumer*)Unsafe.AsPointer(ref this), ppPresentationClock);
        }
    }
}
