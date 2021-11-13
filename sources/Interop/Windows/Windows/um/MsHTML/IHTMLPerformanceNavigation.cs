// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("30510750-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLPerformanceNavigation : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLPerformanceNavigation : IHTMLPerformanceNavigation.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLPerformanceNavigation*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLPerformanceNavigation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLPerformanceNavigation*, uint>)(lpVtbl[1]))((IHTMLPerformanceNavigation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLPerformanceNavigation*, uint>)(lpVtbl[2]))((IHTMLPerformanceNavigation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLPerformanceNavigation*, uint*, int>)(lpVtbl[3]))((IHTMLPerformanceNavigation*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLPerformanceNavigation*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLPerformanceNavigation*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLPerformanceNavigation*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLPerformanceNavigation*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLPerformanceNavigation*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLPerformanceNavigation*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_type([NativeTypeName("ULONG *")] uint* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceNavigation*, uint*, int>)(lpVtbl[7]))((IHTMLPerformanceNavigation*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_redirectCount([NativeTypeName("ULONG *")] uint* p)
        {
            return ((delegate* unmanaged<IHTMLPerformanceNavigation*, uint*, int>)(lpVtbl[8]))((IHTMLPerformanceNavigation*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT toString([NativeTypeName("BSTR *")] ushort** @string)
        {
            return ((delegate* unmanaged<IHTMLPerformanceNavigation*, ushort**, int>)(lpVtbl[9]))((IHTMLPerformanceNavigation*)Unsafe.AsPointer(ref this), @string);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT toJSON(VARIANT* pVar)
        {
            return ((delegate* unmanaged<IHTMLPerformanceNavigation*, VARIANT*, int>)(lpVtbl[10]))((IHTMLPerformanceNavigation*)Unsafe.AsPointer(ref this), pVar);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT get_type([NativeTypeName("ULONG *")] uint* p);

            [VtblIndex(8)]
            HRESULT get_redirectCount([NativeTypeName("ULONG *")] uint* p);

            [VtblIndex(9)]
            HRESULT toString([NativeTypeName("BSTR *")] ushort** @string);

            [VtblIndex(10)]
            HRESULT toJSON(VARIANT* pVar);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPerformanceNavigation*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPerformanceNavigation*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPerformanceNavigation*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPerformanceNavigation*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPerformanceNavigation*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPerformanceNavigation*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPerformanceNavigation*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPerformanceNavigation*, uint*, int> get_type;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPerformanceNavigation*, uint*, int> get_redirectCount;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPerformanceNavigation*, ushort**, int> toString;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLPerformanceNavigation*, VARIANT*, int> toJSON;
        }
    }
}
