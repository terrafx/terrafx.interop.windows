// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F9C013DC-3C23-4041-8E39-CFB402F7EA59")]
    [NativeTypeName("struct IWebWizardHost2 : IWebWizardHost")]
    [NativeInheritance("IWebWizardHost")]
    public unsafe partial struct IWebWizardHost2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWebWizardHost2*, Guid*, void**, int>)(lpVtbl[0]))((IWebWizardHost2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWebWizardHost2*, uint>)(lpVtbl[1]))((IWebWizardHost2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWebWizardHost2*, uint>)(lpVtbl[2]))((IWebWizardHost2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IWebWizardHost2*, uint*, int>)(lpVtbl[3]))((IWebWizardHost2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IWebWizardHost2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IWebWizardHost2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IWebWizardHost2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IWebWizardHost2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IWebWizardHost2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IWebWizardHost2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT FinalBack()
        {
            return ((delegate* unmanaged<IWebWizardHost2*, int>)(lpVtbl[7]))((IWebWizardHost2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT FinalNext()
        {
            return ((delegate* unmanaged<IWebWizardHost2*, int>)(lpVtbl[8]))((IWebWizardHost2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Cancel()
        {
            return ((delegate* unmanaged<IWebWizardHost2*, int>)(lpVtbl[9]))((IWebWizardHost2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT put_Caption([NativeTypeName("BSTR")] ushort* bstrCaption)
        {
            return ((delegate* unmanaged<IWebWizardHost2*, ushort*, int>)(lpVtbl[10]))((IWebWizardHost2*)Unsafe.AsPointer(ref this), bstrCaption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_Caption([NativeTypeName("BSTR *")] ushort** pbstrCaption)
        {
            return ((delegate* unmanaged<IWebWizardHost2*, ushort**, int>)(lpVtbl[11]))((IWebWizardHost2*)Unsafe.AsPointer(ref this), pbstrCaption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT put_Property([NativeTypeName("BSTR")] ushort* bstrPropertyName, VARIANT* pvProperty)
        {
            return ((delegate* unmanaged<IWebWizardHost2*, ushort*, VARIANT*, int>)(lpVtbl[12]))((IWebWizardHost2*)Unsafe.AsPointer(ref this), bstrPropertyName, pvProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_Property([NativeTypeName("BSTR")] ushort* bstrPropertyName, VARIANT* pvProperty)
        {
            return ((delegate* unmanaged<IWebWizardHost2*, ushort*, VARIANT*, int>)(lpVtbl[13]))((IWebWizardHost2*)Unsafe.AsPointer(ref this), bstrPropertyName, pvProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetWizardButtons([NativeTypeName("VARIANT_BOOL")] short vfEnableBack, [NativeTypeName("VARIANT_BOOL")] short vfEnableNext, [NativeTypeName("VARIANT_BOOL")] short vfLastPage)
        {
            return ((delegate* unmanaged<IWebWizardHost2*, short, short, short, int>)(lpVtbl[14]))((IWebWizardHost2*)Unsafe.AsPointer(ref this), vfEnableBack, vfEnableNext, vfLastPage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetHeaderText([NativeTypeName("BSTR")] ushort* bstrHeaderTitle, [NativeTypeName("BSTR")] ushort* bstrHeaderSubtitle)
        {
            return ((delegate* unmanaged<IWebWizardHost2*, ushort*, ushort*, int>)(lpVtbl[15]))((IWebWizardHost2*)Unsafe.AsPointer(ref this), bstrHeaderTitle, bstrHeaderSubtitle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SignString([NativeTypeName("BSTR")] ushort* value, [NativeTypeName("BSTR *")] ushort** signedValue)
        {
            return ((delegate* unmanaged<IWebWizardHost2*, ushort*, ushort**, int>)(lpVtbl[16]))((IWebWizardHost2*)Unsafe.AsPointer(ref this), value, signedValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, int> FinalBack;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, int> FinalNext;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, int> Cancel;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, ushort*, int> put_Caption;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, ushort**, int> get_Caption;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, ushort*, VARIANT*, int> put_Property;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, ushort*, VARIANT*, int> get_Property;

            [NativeTypeName("HRESULT (VARIANT_BOOL, VARIANT_BOOL, VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, short, short, short, int> SetWizardButtons;

            [NativeTypeName("HRESULT (BSTR, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, ushort*, ushort*, int> SetHeaderText;

            [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebWizardHost2*, ushort*, ushort**, int> SignString;
        }
    }
}
