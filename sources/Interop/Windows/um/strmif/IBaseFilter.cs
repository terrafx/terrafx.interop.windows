// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A86895-0AD4-11CE-B03A-0020AF0BA770")]
    public unsafe partial struct IBaseFilter
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IBaseFilter*, Guid*, void**, int>)(lpVtbl[0]))((IBaseFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IBaseFilter*, uint>)(lpVtbl[1]))((IBaseFilter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IBaseFilter*, uint>)(lpVtbl[2]))((IBaseFilter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* stdcall<IBaseFilter*, Guid*, int>)(lpVtbl[3]))((IBaseFilter*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* stdcall<IBaseFilter*, int>)(lpVtbl[4]))((IBaseFilter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* stdcall<IBaseFilter*, int>)(lpVtbl[5]))((IBaseFilter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Run([NativeTypeName("REFERENCE_TIME")] long tStart)
        {
            return ((delegate* stdcall<IBaseFilter*, long, int>)(lpVtbl[6]))((IBaseFilter*)Unsafe.AsPointer(ref this), tStart);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("DWORD")] uint dwMilliSecsTimeout, [NativeTypeName("FILTER_STATE *")] FILTER_STATE* State)
        {
            return ((delegate* stdcall<IBaseFilter*, uint, FILTER_STATE*, int>)(lpVtbl[7]))((IBaseFilter*)Unsafe.AsPointer(ref this), dwMilliSecsTimeout, State);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSyncSource([NativeTypeName("IReferenceClock *")] IReferenceClock* pClock)
        {
            return ((delegate* stdcall<IBaseFilter*, IReferenceClock*, int>)(lpVtbl[8]))((IBaseFilter*)Unsafe.AsPointer(ref this), pClock);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSyncSource([NativeTypeName("IReferenceClock **")] IReferenceClock** pClock)
        {
            return ((delegate* stdcall<IBaseFilter*, IReferenceClock**, int>)(lpVtbl[9]))((IBaseFilter*)Unsafe.AsPointer(ref this), pClock);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumPins([NativeTypeName("IEnumPins **")] IEnumPins** ppEnum)
        {
            return ((delegate* stdcall<IBaseFilter*, IEnumPins**, int>)(lpVtbl[10]))((IBaseFilter*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindPin([NativeTypeName("LPCWSTR")] ushort* Id, [NativeTypeName("IPin **")] IPin** ppPin)
        {
            return ((delegate* stdcall<IBaseFilter*, ushort*, IPin**, int>)(lpVtbl[11]))((IBaseFilter*)Unsafe.AsPointer(ref this), Id, ppPin);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryFilterInfo([NativeTypeName("FILTER_INFO *")] FILTER_INFO* pInfo)
        {
            return ((delegate* stdcall<IBaseFilter*, FILTER_INFO*, int>)(lpVtbl[12]))((IBaseFilter*)Unsafe.AsPointer(ref this), pInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int JoinFilterGraph([NativeTypeName("IFilterGraph *")] IFilterGraph* pGraph, [NativeTypeName("LPCWSTR")] ushort* pName)
        {
            return ((delegate* stdcall<IBaseFilter*, IFilterGraph*, ushort*, int>)(lpVtbl[13]))((IBaseFilter*)Unsafe.AsPointer(ref this), pGraph, pName);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryVendorInfo([NativeTypeName("LPWSTR *")] ushort** pVendorInfo)
        {
            return ((delegate* stdcall<IBaseFilter*, ushort**, int>)(lpVtbl[14]))((IBaseFilter*)Unsafe.AsPointer(ref this), pVendorInfo);
        }
    }
}
