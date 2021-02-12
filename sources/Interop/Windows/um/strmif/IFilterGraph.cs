// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A8689F-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IFilterGraph : IUnknown")]
    public unsafe partial struct IFilterGraph
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IFilterGraph*, Guid*, void**, int>)(lpVtbl[0]))((IFilterGraph*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFilterGraph*, uint>)(lpVtbl[1]))((IFilterGraph*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFilterGraph*, uint>)(lpVtbl[2]))((IFilterGraph*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddFilter([NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter, [NativeTypeName("LPCWSTR")] ushort* pName)
        {
            return ((delegate* unmanaged<IFilterGraph*, IBaseFilter*, ushort*, int>)(lpVtbl[3]))((IFilterGraph*)Unsafe.AsPointer(ref this), pFilter, pName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveFilter([NativeTypeName("IBaseFilter *")] IBaseFilter* pFilter)
        {
            return ((delegate* unmanaged<IFilterGraph*, IBaseFilter*, int>)(lpVtbl[4]))((IFilterGraph*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumFilters([NativeTypeName("IEnumFilters **")] IEnumFilters** ppEnum)
        {
            return ((delegate* unmanaged<IFilterGraph*, IEnumFilters**, int>)(lpVtbl[5]))((IFilterGraph*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindFilterByName([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("IBaseFilter **")] IBaseFilter** ppFilter)
        {
            return ((delegate* unmanaged<IFilterGraph*, ushort*, IBaseFilter**, int>)(lpVtbl[6]))((IFilterGraph*)Unsafe.AsPointer(ref this), pName, ppFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConnectDirect([NativeTypeName("IPin *")] IPin* ppinOut, [NativeTypeName("IPin *")] IPin* ppinIn, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* unmanaged<IFilterGraph*, IPin*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[7]))((IFilterGraph*)Unsafe.AsPointer(ref this), ppinOut, ppinIn, pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reconnect([NativeTypeName("IPin *")] IPin* ppin)
        {
            return ((delegate* unmanaged<IFilterGraph*, IPin*, int>)(lpVtbl[8]))((IFilterGraph*)Unsafe.AsPointer(ref this), ppin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Disconnect([NativeTypeName("IPin *")] IPin* ppin)
        {
            return ((delegate* unmanaged<IFilterGraph*, IPin*, int>)(lpVtbl[9]))((IFilterGraph*)Unsafe.AsPointer(ref this), ppin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultSyncSource()
        {
            return ((delegate* unmanaged<IFilterGraph*, int>)(lpVtbl[10]))((IFilterGraph*)Unsafe.AsPointer(ref this));
        }
    }
}
