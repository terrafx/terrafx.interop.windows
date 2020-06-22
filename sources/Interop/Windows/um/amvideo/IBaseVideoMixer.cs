// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IBaseVideoMixer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IBaseVideoMixer*, Guid*, void**, int>)(lpVtbl[0]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IBaseVideoMixer*, uint>)(lpVtbl[1]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IBaseVideoMixer*, uint>)(lpVtbl[2]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLeadPin(int iPin)
        {
            return ((delegate* stdcall<IBaseVideoMixer*, int, int>)(lpVtbl[3]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), iPin);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLeadPin([NativeTypeName("int *")] int* piPin)
        {
            return ((delegate* stdcall<IBaseVideoMixer*, int*, int>)(lpVtbl[4]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), piPin);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInputPinCount([NativeTypeName("int *")] int* piPinCount)
        {
            return ((delegate* stdcall<IBaseVideoMixer*, int*, int>)(lpVtbl[5]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), piPinCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsUsingClock([NativeTypeName("int *")] int* pbValue)
        {
            return ((delegate* stdcall<IBaseVideoMixer*, int*, int>)(lpVtbl[6]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), pbValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUsingClock(int bValue)
        {
            return ((delegate* stdcall<IBaseVideoMixer*, int, int>)(lpVtbl[7]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), bValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClockPeriod([NativeTypeName("int *")] int* pbValue)
        {
            return ((delegate* stdcall<IBaseVideoMixer*, int*, int>)(lpVtbl[8]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), pbValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClockPeriod(int bValue)
        {
            return ((delegate* stdcall<IBaseVideoMixer*, int, int>)(lpVtbl[9]))((IBaseVideoMixer*)Unsafe.AsPointer(ref this), bValue);
        }
    }
}
