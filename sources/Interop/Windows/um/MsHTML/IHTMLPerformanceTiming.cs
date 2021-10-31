// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510752-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLPerformanceTiming : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLPerformanceTiming
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, uint>)(lpVtbl[1]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, uint>)(lpVtbl[2]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, uint*, int>)(lpVtbl[3]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_navigationStart([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[7]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_unloadEventStart([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[8]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_unloadEventEnd([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[9]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_redirectStart([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[10]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_redirectEnd([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[11]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_fetchStart([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[12]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_domainLookupStart([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[13]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_domainLookupEnd([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[14]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_connectStart([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[15]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_connectEnd([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[16]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_requestStart([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[17]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_responseStart([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[18]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_responseEnd([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[19]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_domLoading([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[20]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_domInteractive([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[21]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_domContentLoadedEventStart([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[22]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_domContentLoadedEventEnd([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[23]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_domComplete([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[24]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_loadEventStart([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[25]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_loadEventEnd([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[26]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_msFirstPaint([NativeTypeName("ULONGLONG *")] ulong* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ulong*, int>)(lpVtbl[27]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT toString([NativeTypeName("BSTR *")] ushort** @string)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, ushort**, int>)(lpVtbl[28]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), @string);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT toJSON(VARIANT* pVar)
        {
            return ((delegate* unmanaged<IHTMLPerformanceTiming*, VARIANT*, int>)(lpVtbl[29]))((IHTMLPerformanceTiming*)Unsafe.AsPointer(ref this), pVar);
        }
    }
}
