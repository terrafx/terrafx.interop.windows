// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("30510792-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLMSMediaElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLMSMediaElement : IHTMLMSMediaElement.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLMSMediaElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLMSMediaElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLMSMediaElement*, uint>)(lpVtbl[1]))((IHTMLMSMediaElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLMSMediaElement*, uint>)(lpVtbl[2]))((IHTMLMSMediaElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLMSMediaElement*, uint*, int>)(lpVtbl[3]))((IHTMLMSMediaElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLMSMediaElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLMSMediaElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLMSMediaElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLMSMediaElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLMSMediaElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLMSMediaElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_msPlayToDisabled([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLMSMediaElement*, short, int>)(lpVtbl[7]))((IHTMLMSMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_msPlayToDisabled([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMSMediaElement*, short*, int>)(lpVtbl[8]))((IHTMLMSMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_msPlayToPrimary([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLMSMediaElement*, short, int>)(lpVtbl[9]))((IHTMLMSMediaElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_msPlayToPrimary([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMSMediaElement*, short*, int>)(lpVtbl[10]))((IHTMLMSMediaElement*)Unsafe.AsPointer(ref this), p);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT put_msPlayToDisabled([NativeTypeName("VARIANT_BOOL")] short v);

            [VtblIndex(8)]
            HRESULT get_msPlayToDisabled([NativeTypeName("VARIANT_BOOL *")] short* p);

            [VtblIndex(9)]
            HRESULT put_msPlayToPrimary([NativeTypeName("VARIANT_BOOL")] short v);

            [VtblIndex(10)]
            HRESULT get_msPlayToPrimary([NativeTypeName("VARIANT_BOOL *")] short* p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLMSMediaElement*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLMSMediaElement*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLMSMediaElement*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLMSMediaElement*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLMSMediaElement*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLMSMediaElement*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLMSMediaElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLMSMediaElement*, short, int> put_msPlayToDisabled;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLMSMediaElement*, short*, int> get_msPlayToDisabled;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLMSMediaElement*, short, int> put_msPlayToPrimary;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLMSMediaElement*, short*, int> get_msPlayToPrimary;
        }
    }
}
