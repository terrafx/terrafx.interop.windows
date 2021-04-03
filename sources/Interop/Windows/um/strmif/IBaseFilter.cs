// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A86895-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IBaseFilter : IMediaFilter")]
    public unsafe partial struct IBaseFilter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBaseFilter*, Guid*, void**, int>)(lpVtbl[0]))((IBaseFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBaseFilter*, uint>)(lpVtbl[1]))((IBaseFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBaseFilter*, uint>)(lpVtbl[2]))((IBaseFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IBaseFilter*, Guid*, int>)(lpVtbl[3]))((IBaseFilter*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<IBaseFilter*, int>)(lpVtbl[4]))((IBaseFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged<IBaseFilter*, int>)(lpVtbl[5]))((IBaseFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Run([NativeTypeName("REFERENCE_TIME")] long tStart)
        {
            return ((delegate* unmanaged<IBaseFilter*, long, int>)(lpVtbl[6]))((IBaseFilter*)Unsafe.AsPointer(ref this), tStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("DWORD")] uint dwMilliSecsTimeout, FILTER_STATE* State)
        {
            return ((delegate* unmanaged<IBaseFilter*, uint, FILTER_STATE*, int>)(lpVtbl[7]))((IBaseFilter*)Unsafe.AsPointer(ref this), dwMilliSecsTimeout, State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSyncSource(IReferenceClock* pClock)
        {
            return ((delegate* unmanaged<IBaseFilter*, IReferenceClock*, int>)(lpVtbl[8]))((IBaseFilter*)Unsafe.AsPointer(ref this), pClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSyncSource(IReferenceClock** pClock)
        {
            return ((delegate* unmanaged<IBaseFilter*, IReferenceClock**, int>)(lpVtbl[9]))((IBaseFilter*)Unsafe.AsPointer(ref this), pClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumPins(IEnumPins** ppEnum)
        {
            return ((delegate* unmanaged<IBaseFilter*, IEnumPins**, int>)(lpVtbl[10]))((IBaseFilter*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindPin([NativeTypeName("LPCWSTR")] ushort* Id, IPin** ppPin)
        {
            return ((delegate* unmanaged<IBaseFilter*, ushort*, IPin**, int>)(lpVtbl[11]))((IBaseFilter*)Unsafe.AsPointer(ref this), Id, ppPin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryFilterInfo(FILTER_INFO* pInfo)
        {
            return ((delegate* unmanaged<IBaseFilter*, FILTER_INFO*, int>)(lpVtbl[12]))((IBaseFilter*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int JoinFilterGraph(IFilterGraph* pGraph, [NativeTypeName("LPCWSTR")] ushort* pName)
        {
            return ((delegate* unmanaged<IBaseFilter*, IFilterGraph*, ushort*, int>)(lpVtbl[13]))((IBaseFilter*)Unsafe.AsPointer(ref this), pGraph, pName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryVendorInfo([NativeTypeName("LPWSTR *")] ushort** pVendorInfo)
        {
            return ((delegate* unmanaged<IBaseFilter*, ushort**, int>)(lpVtbl[14]))((IBaseFilter*)Unsafe.AsPointer(ref this), pVendorInfo);
        }
    }
}
