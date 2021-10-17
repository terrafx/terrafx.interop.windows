// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0751C551-7568-41C9-8E5B-E22E38919236")]
    [NativeTypeName("struct INewWDEvents : IWebWizardHost")]
    [NativeInheritance("IWebWizardHost")]
    public unsafe partial struct INewWDEvents
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INewWDEvents*, Guid*, void**, int>)(lpVtbl[0]))((INewWDEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INewWDEvents*, uint>)(lpVtbl[1]))((INewWDEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INewWDEvents*, uint>)(lpVtbl[2]))((INewWDEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<INewWDEvents*, uint*, int>)(lpVtbl[3]))((INewWDEvents*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<INewWDEvents*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((INewWDEvents*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<INewWDEvents*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((INewWDEvents*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<INewWDEvents*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((INewWDEvents*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int FinalBack()
        {
            return ((delegate* unmanaged<INewWDEvents*, int>)(lpVtbl[7]))((INewWDEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int FinalNext()
        {
            return ((delegate* unmanaged<INewWDEvents*, int>)(lpVtbl[8]))((INewWDEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Cancel()
        {
            return ((delegate* unmanaged<INewWDEvents*, int>)(lpVtbl[9]))((INewWDEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int put_Caption([NativeTypeName("BSTR")] ushort* bstrCaption)
        {
            return ((delegate* unmanaged<INewWDEvents*, ushort*, int>)(lpVtbl[10]))((INewWDEvents*)Unsafe.AsPointer(ref this), bstrCaption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_Caption([NativeTypeName("BSTR *")] ushort** pbstrCaption)
        {
            return ((delegate* unmanaged<INewWDEvents*, ushort**, int>)(lpVtbl[11]))((INewWDEvents*)Unsafe.AsPointer(ref this), pbstrCaption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int put_Property([NativeTypeName("BSTR")] ushort* bstrPropertyName, VARIANT* pvProperty)
        {
            return ((delegate* unmanaged<INewWDEvents*, ushort*, VARIANT*, int>)(lpVtbl[12]))((INewWDEvents*)Unsafe.AsPointer(ref this), bstrPropertyName, pvProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_Property([NativeTypeName("BSTR")] ushort* bstrPropertyName, VARIANT* pvProperty)
        {
            return ((delegate* unmanaged<INewWDEvents*, ushort*, VARIANT*, int>)(lpVtbl[13]))((INewWDEvents*)Unsafe.AsPointer(ref this), bstrPropertyName, pvProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetWizardButtons([NativeTypeName("VARIANT_BOOL")] short vfEnableBack, [NativeTypeName("VARIANT_BOOL")] short vfEnableNext, [NativeTypeName("VARIANT_BOOL")] short vfLastPage)
        {
            return ((delegate* unmanaged<INewWDEvents*, short, short, short, int>)(lpVtbl[14]))((INewWDEvents*)Unsafe.AsPointer(ref this), vfEnableBack, vfEnableNext, vfLastPage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int SetHeaderText([NativeTypeName("BSTR")] ushort* bstrHeaderTitle, [NativeTypeName("BSTR")] ushort* bstrHeaderSubtitle)
        {
            return ((delegate* unmanaged<INewWDEvents*, ushort*, ushort*, int>)(lpVtbl[15]))((INewWDEvents*)Unsafe.AsPointer(ref this), bstrHeaderTitle, bstrHeaderSubtitle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int PassportAuthenticate([NativeTypeName("BSTR")] ushort* bstrSignInUrl, [NativeTypeName("VARIANT_BOOL *")] short* pvfAuthenitcated)
        {
            return ((delegate* unmanaged<INewWDEvents*, ushort*, short*, int>)(lpVtbl[16]))((INewWDEvents*)Unsafe.AsPointer(ref this), bstrSignInUrl, pvfAuthenitcated);
        }
    }
}
