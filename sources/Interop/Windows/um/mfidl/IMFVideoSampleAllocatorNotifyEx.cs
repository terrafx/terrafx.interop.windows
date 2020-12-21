// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3978AA1A-6D5B-4B7F-A340-90899189AE34")]
    [NativeTypeName("struct IMFVideoSampleAllocatorNotifyEx : IMFVideoSampleAllocatorNotify")]
    public unsafe partial struct IMFVideoSampleAllocatorNotifyEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoSampleAllocatorNotifyEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoSampleAllocatorNotifyEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoSampleAllocatorNotifyEx*, uint>)(lpVtbl[1]))((IMFVideoSampleAllocatorNotifyEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoSampleAllocatorNotifyEx*, uint>)(lpVtbl[2]))((IMFVideoSampleAllocatorNotifyEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyRelease()
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoSampleAllocatorNotifyEx*, int>)(lpVtbl[3]))((IMFVideoSampleAllocatorNotifyEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyPrune([NativeTypeName("IMFSample *")] IMFSample* __MIDL__IMFVideoSampleAllocatorNotifyEx0000)
        {
            return ((delegate* unmanaged[Stdcall]<IMFVideoSampleAllocatorNotifyEx*, IMFSample*, int>)(lpVtbl[4]))((IMFVideoSampleAllocatorNotifyEx*)Unsafe.AsPointer(ref this), __MIDL__IMFVideoSampleAllocatorNotifyEx0000);
        }
    }
}
