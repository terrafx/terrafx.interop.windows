// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("992388B4-3372-4F67-8B6F-C84C071F4751")]
    public unsafe partial struct IMFVideoSampleAllocatorCallback
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoSampleAllocatorCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorCallback*, uint>)(lpVtbl[1]))((IMFVideoSampleAllocatorCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorCallback*, uint>)(lpVtbl[2]))((IMFVideoSampleAllocatorCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCallback([NativeTypeName("IMFVideoSampleAllocatorNotify *")] IMFVideoSampleAllocatorNotify* pNotify)
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorCallback*, IMFVideoSampleAllocatorNotify*, int>)(lpVtbl[3]))((IMFVideoSampleAllocatorCallback*)Unsafe.AsPointer(ref this), pNotify);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFreeSampleCount([NativeTypeName("LONG *")] int* plSamples)
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorCallback*, int*, int>)(lpVtbl[4]))((IMFVideoSampleAllocatorCallback*)Unsafe.AsPointer(ref this), plSamples);
        }
    }
}
