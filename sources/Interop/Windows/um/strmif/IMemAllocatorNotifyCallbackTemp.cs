// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("92980B30-C1DE-11D2-ABF5-00A0C905F375")]
    [NativeTypeName("struct IMemAllocatorNotifyCallbackTemp : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMemAllocatorNotifyCallbackTemp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMemAllocatorNotifyCallbackTemp*, Guid*, void**, int>)(lpVtbl[0]))((IMemAllocatorNotifyCallbackTemp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMemAllocatorNotifyCallbackTemp*, uint>)(lpVtbl[1]))((IMemAllocatorNotifyCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMemAllocatorNotifyCallbackTemp*, uint>)(lpVtbl[2]))((IMemAllocatorNotifyCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT NotifyRelease()
        {
            return ((delegate* unmanaged<IMemAllocatorNotifyCallbackTemp*, int>)(lpVtbl[3]))((IMemAllocatorNotifyCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorNotifyCallbackTemp*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorNotifyCallbackTemp*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorNotifyCallbackTemp*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorNotifyCallbackTemp*, int> NotifyRelease;
        }
    }
}
