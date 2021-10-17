// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7E8BC44D-AEFF-11D1-89C2-00C04FB6BFC4")]
    [NativeTypeName("struct IClientCaps : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IClientCaps
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IClientCaps*, Guid*, void**, int>)(lpVtbl[0]))((IClientCaps*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IClientCaps*, uint>)(lpVtbl[1]))((IClientCaps*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IClientCaps*, uint>)(lpVtbl[2]))((IClientCaps*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IClientCaps*, uint*, int>)(lpVtbl[3]))((IClientCaps*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IClientCaps*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IClientCaps*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IClientCaps*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IClientCaps*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IClientCaps*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IClientCaps*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_javaEnabled([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IClientCaps*, short*, int>)(lpVtbl[7]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_cookieEnabled([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IClientCaps*, short*, int>)(lpVtbl[8]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_cpuClass([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IClientCaps*, ushort**, int>)(lpVtbl[9]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_systemLanguage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IClientCaps*, ushort**, int>)(lpVtbl[10]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_userLanguage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IClientCaps*, ushort**, int>)(lpVtbl[11]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_platform([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IClientCaps*, ushort**, int>)(lpVtbl[12]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_connectionSpeed([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IClientCaps*, int*, int>)(lpVtbl[13]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_onLine([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IClientCaps*, short*, int>)(lpVtbl[14]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_colorDepth([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IClientCaps*, int*, int>)(lpVtbl[15]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_bufferDepth([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IClientCaps*, int*, int>)(lpVtbl[16]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_width([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IClientCaps*, int*, int>)(lpVtbl[17]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_height([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IClientCaps*, int*, int>)(lpVtbl[18]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_availHeight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IClientCaps*, int*, int>)(lpVtbl[19]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_availWidth([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IClientCaps*, int*, int>)(lpVtbl[20]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_connectionType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IClientCaps*, ushort**, int>)(lpVtbl[21]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int isComponentInstalled([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("BSTR")] ushort* bStrVer, [NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IClientCaps*, ushort*, ushort*, ushort*, short*, int>)(lpVtbl[22]))((IClientCaps*)Unsafe.AsPointer(ref this), bstrName, bstrUrl, bStrVer, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int getComponentVersion([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("BSTR *")] ushort** pbstrVer)
        {
            return ((delegate* unmanaged<IClientCaps*, ushort*, ushort*, ushort**, int>)(lpVtbl[23]))((IClientCaps*)Unsafe.AsPointer(ref this), bstrName, bstrUrl, pbstrVer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int compareVersions([NativeTypeName("BSTR")] ushort* bstrVer1, [NativeTypeName("BSTR")] ushort* bstrVer2, [NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IClientCaps*, ushort*, ushort*, int*, int>)(lpVtbl[24]))((IClientCaps*)Unsafe.AsPointer(ref this), bstrVer1, bstrVer2, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int addComponentRequest([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("BSTR")] ushort* bStrVer = null)
        {
            return ((delegate* unmanaged<IClientCaps*, ushort*, ushort*, ushort*, int>)(lpVtbl[25]))((IClientCaps*)Unsafe.AsPointer(ref this), bstrName, bstrUrl, bStrVer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int doComponentRequest([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IClientCaps*, short*, int>)(lpVtbl[26]))((IClientCaps*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int clearComponentRequest()
        {
            return ((delegate* unmanaged<IClientCaps*, int>)(lpVtbl[27]))((IClientCaps*)Unsafe.AsPointer(ref this));
        }
    }
}
