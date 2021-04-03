// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2347D60B-3FB5-480C-8803-8DF3ADCD3EF0")]
    [NativeTypeName("struct IMFRealTimeClient : IUnknown")]
    public unsafe partial struct IMFRealTimeClient
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFRealTimeClient*, Guid*, void**, int>)(lpVtbl[0]))((IMFRealTimeClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFRealTimeClient*, uint>)(lpVtbl[1]))((IMFRealTimeClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFRealTimeClient*, uint>)(lpVtbl[2]))((IMFRealTimeClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterThreads([NativeTypeName("DWORD")] uint dwTaskIndex, [NativeTypeName("LPCWSTR")] ushort* wszClass)
        {
            return ((delegate* unmanaged<IMFRealTimeClient*, uint, ushort*, int>)(lpVtbl[3]))((IMFRealTimeClient*)Unsafe.AsPointer(ref this), dwTaskIndex, wszClass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterThreads()
        {
            return ((delegate* unmanaged<IMFRealTimeClient*, int>)(lpVtbl[4]))((IMFRealTimeClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWorkQueue([NativeTypeName("DWORD")] uint dwWorkQueueId)
        {
            return ((delegate* unmanaged<IMFRealTimeClient*, uint, int>)(lpVtbl[5]))((IMFRealTimeClient*)Unsafe.AsPointer(ref this), dwWorkQueueId);
        }
    }
}
