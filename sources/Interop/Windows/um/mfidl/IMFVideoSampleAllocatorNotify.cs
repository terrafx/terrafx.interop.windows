// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A792CDBE-C374-4E89-8335-278E7B9956A4")]
    public unsafe partial struct IMFVideoSampleAllocatorNotify
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoSampleAllocatorNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorNotify*, uint>)(lpVtbl[1]))((IMFVideoSampleAllocatorNotify*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorNotify*, uint>)(lpVtbl[2]))((IMFVideoSampleAllocatorNotify*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int NotifyRelease()
        {
            return ((delegate* stdcall<IMFVideoSampleAllocatorNotify*, int>)(lpVtbl[3]))((IMFVideoSampleAllocatorNotify*)Unsafe.AsPointer(ref this));
        }
    }
}
