// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("96BF961B-40FE-42F1-BA9D-320238B49700")]
    [NativeTypeName("struct IMFWorkQueueServicesEx : IMFWorkQueueServices")]
    public unsafe partial struct IMFWorkQueueServicesEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint>)(lpVtbl[1]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint>)(lpVtbl[2]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginRegisterTopologyWorkQueuesWithMMCSS(IMFAsyncCallback* pCallback, IUnknown* pState)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), pCallback, pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndRegisterTopologyWorkQueuesWithMMCSS(IMFAsyncResult* pResult)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, IMFAsyncResult*, int>)(lpVtbl[4]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginUnregisterTopologyWorkQueuesWithMMCSS(IMFAsyncCallback* pCallback, IUnknown* pState)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[5]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), pCallback, pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndUnregisterTopologyWorkQueuesWithMMCSS(IMFAsyncResult* pResult)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, IMFAsyncResult*, int>)(lpVtbl[6]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTopologyWorkQueueMMCSSClass([NativeTypeName("DWORD")] uint dwTopologyWorkQueueId, [NativeTypeName("LPWSTR")] ushort* pwszClass, [NativeTypeName("DWORD *")] uint* pcchClass)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, ushort*, uint*, int>)(lpVtbl[7]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwTopologyWorkQueueId, pwszClass, pcchClass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTopologyWorkQueueMMCSSTaskId([NativeTypeName("DWORD")] uint dwTopologyWorkQueueId, [NativeTypeName("DWORD *")] uint* pdwTaskId)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, uint*, int>)(lpVtbl[8]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwTopologyWorkQueueId, pdwTaskId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginRegisterPlatformWorkQueueWithMMCSS([NativeTypeName("DWORD")] uint dwPlatformWorkQueue, [NativeTypeName("LPCWSTR")] ushort* wszClass, [NativeTypeName("DWORD")] uint dwTaskId, IMFAsyncCallback* pCallback, IUnknown* pState)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, ushort*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[9]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwPlatformWorkQueue, wszClass, dwTaskId, pCallback, pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndRegisterPlatformWorkQueueWithMMCSS(IMFAsyncResult* pResult, [NativeTypeName("DWORD *")] uint* pdwTaskId)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, IMFAsyncResult*, uint*, int>)(lpVtbl[10]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), pResult, pdwTaskId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginUnregisterPlatformWorkQueueWithMMCSS([NativeTypeName("DWORD")] uint dwPlatformWorkQueue, IMFAsyncCallback* pCallback, IUnknown* pState)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[11]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwPlatformWorkQueue, pCallback, pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndUnregisterPlatformWorkQueueWithMMCSS(IMFAsyncResult* pResult)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, IMFAsyncResult*, int>)(lpVtbl[12]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPlaftormWorkQueueMMCSSClass([NativeTypeName("DWORD")] uint dwPlatformWorkQueueId, [NativeTypeName("LPWSTR")] ushort* pwszClass, [NativeTypeName("DWORD *")] uint* pcchClass)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, ushort*, uint*, int>)(lpVtbl[13]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwPlatformWorkQueueId, pwszClass, pcchClass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPlatformWorkQueueMMCSSTaskId([NativeTypeName("DWORD")] uint dwPlatformWorkQueueId, [NativeTypeName("DWORD *")] uint* pdwTaskId)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, uint*, int>)(lpVtbl[14]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwPlatformWorkQueueId, pdwTaskId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTopologyWorkQueueMMCSSPriority([NativeTypeName("DWORD")] uint dwTopologyWorkQueueId, [NativeTypeName("LONG *")] int* plPriority)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, int*, int>)(lpVtbl[15]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwTopologyWorkQueueId, plPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginRegisterPlatformWorkQueueWithMMCSSEx([NativeTypeName("DWORD")] uint dwPlatformWorkQueue, [NativeTypeName("LPCWSTR")] ushort* wszClass, [NativeTypeName("DWORD")] uint dwTaskId, [NativeTypeName("LONG")] int lPriority, IMFAsyncCallback* pCallback, IUnknown* pState)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, ushort*, uint, int, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[16]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwPlatformWorkQueue, wszClass, dwTaskId, lPriority, pCallback, pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPlatformWorkQueueMMCSSPriority([NativeTypeName("DWORD")] uint dwPlatformWorkQueueId, [NativeTypeName("LONG *")] int* plPriority)
        {
            return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, int*, int>)(lpVtbl[17]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwPlatformWorkQueueId, plPriority);
        }
    }
}
