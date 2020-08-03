// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("92980B30-C1DE-11D2-ABF5-00A0C905F375")]
    public unsafe partial struct IMemAllocatorNotifyCallbackTemp
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMemAllocatorNotifyCallbackTemp*, Guid*, void**, int>)(lpVtbl[0]))((IMemAllocatorNotifyCallbackTemp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMemAllocatorNotifyCallbackTemp*, uint>)(lpVtbl[1]))((IMemAllocatorNotifyCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMemAllocatorNotifyCallbackTemp*, uint>)(lpVtbl[2]))((IMemAllocatorNotifyCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int NotifyRelease()
        {
            return ((delegate* stdcall<IMemAllocatorNotifyCallbackTemp*, int>)(lpVtbl[3]))((IMemAllocatorNotifyCallbackTemp*)Unsafe.AsPointer(ref this));
        }
    }
}
