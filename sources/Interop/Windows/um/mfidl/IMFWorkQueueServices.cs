// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("35FE1BB8-A3A9-40FE-BBEC-EB569C9CCCA3")]
    public unsafe partial struct IMFWorkQueueServices
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, Guid*, void**, int>)(lpVtbl[0]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, uint>)(lpVtbl[1]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, uint>)(lpVtbl[2]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginRegisterTopologyWorkQueuesWithMMCSS([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState)
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this), pCallback, pState);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndRegisterTopologyWorkQueuesWithMMCSS([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult)
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, IMFAsyncResult*, int>)(lpVtbl[4]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this), pResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginUnregisterTopologyWorkQueuesWithMMCSS([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState)
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[5]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this), pCallback, pState);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndUnregisterTopologyWorkQueuesWithMMCSS([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult)
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, IMFAsyncResult*, int>)(lpVtbl[6]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this), pResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTopologyWorkQueueMMCSSClass([NativeTypeName("DWORD")] uint dwTopologyWorkQueueId, [NativeTypeName("LPWSTR")] ushort* pwszClass, [NativeTypeName("DWORD *")] uint* pcchClass)
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, uint, ushort*, uint*, int>)(lpVtbl[7]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this), dwTopologyWorkQueueId, pwszClass, pcchClass);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTopologyWorkQueueMMCSSTaskId([NativeTypeName("DWORD")] uint dwTopologyWorkQueueId, [NativeTypeName("DWORD *")] uint* pdwTaskId)
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, uint, uint*, int>)(lpVtbl[8]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this), dwTopologyWorkQueueId, pdwTaskId);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginRegisterPlatformWorkQueueWithMMCSS([NativeTypeName("DWORD")] uint dwPlatformWorkQueue, [NativeTypeName("LPCWSTR")] ushort* wszClass, [NativeTypeName("DWORD")] uint dwTaskId, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState)
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, uint, ushort*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[9]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this), dwPlatformWorkQueue, wszClass, dwTaskId, pCallback, pState);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndRegisterPlatformWorkQueueWithMMCSS([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("DWORD *")] uint* pdwTaskId)
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, IMFAsyncResult*, uint*, int>)(lpVtbl[10]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this), pResult, pdwTaskId);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginUnregisterPlatformWorkQueueWithMMCSS([NativeTypeName("DWORD")] uint dwPlatformWorkQueue, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState)
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[11]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this), dwPlatformWorkQueue, pCallback, pState);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndUnregisterPlatformWorkQueueWithMMCSS([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult)
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, IMFAsyncResult*, int>)(lpVtbl[12]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this), pResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPlaftormWorkQueueMMCSSClass([NativeTypeName("DWORD")] uint dwPlatformWorkQueueId, [NativeTypeName("LPWSTR")] ushort* pwszClass, [NativeTypeName("DWORD *")] uint* pcchClass)
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, uint, ushort*, uint*, int>)(lpVtbl[13]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this), dwPlatformWorkQueueId, pwszClass, pcchClass);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPlatformWorkQueueMMCSSTaskId([NativeTypeName("DWORD")] uint dwPlatformWorkQueueId, [NativeTypeName("DWORD *")] uint* pdwTaskId)
        {
            return ((delegate* stdcall<IMFWorkQueueServices*, uint, uint*, int>)(lpVtbl[14]))((IMFWorkQueueServices*)Unsafe.AsPointer(ref this), dwPlatformWorkQueueId, pdwTaskId);
        }
    }
}
