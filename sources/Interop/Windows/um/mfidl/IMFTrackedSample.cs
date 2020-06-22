// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("245BF8E9-0755-40F7-88A5-AE0F18D55E17")]
    public unsafe partial struct IMFTrackedSample
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFTrackedSample*, Guid*, void**, int>)(lpVtbl[0]))((IMFTrackedSample*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFTrackedSample*, uint>)(lpVtbl[1]))((IMFTrackedSample*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFTrackedSample*, uint>)(lpVtbl[2]))((IMFTrackedSample*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAllocator([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pSampleAllocator, [NativeTypeName("IUnknown *")] IUnknown* pUnkState)
        {
            return ((delegate* stdcall<IMFTrackedSample*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFTrackedSample*)Unsafe.AsPointer(ref this), pSampleAllocator, pUnkState);
        }
    }
}
