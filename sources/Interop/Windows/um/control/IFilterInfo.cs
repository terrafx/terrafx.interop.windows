// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868BA-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IFilterInfo : IDispatch")]
    public unsafe partial struct IFilterInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFilterInfo*, Guid*, void**, int>)(lpVtbl[0]))((IFilterInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFilterInfo*, uint>)(lpVtbl[1]))((IFilterInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFilterInfo*, uint>)(lpVtbl[2]))((IFilterInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IFilterInfo*, uint*, int>)(lpVtbl[3]))((IFilterInfo*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IFilterInfo*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IFilterInfo*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IFilterInfo*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IFilterInfo*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IFilterInfo*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IFilterInfo*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindPin([NativeTypeName("BSTR")] ushort* strPinID, IDispatch** ppUnk)
        {
            return ((delegate* unmanaged<IFilterInfo*, ushort*, IDispatch**, int>)(lpVtbl[7]))((IFilterInfo*)Unsafe.AsPointer(ref this), strPinID, ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("BSTR *")] ushort** strName)
        {
            return ((delegate* unmanaged<IFilterInfo*, ushort**, int>)(lpVtbl[8]))((IFilterInfo*)Unsafe.AsPointer(ref this), strName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VendorInfo([NativeTypeName("BSTR *")] ushort** strVendorInfo)
        {
            return ((delegate* unmanaged<IFilterInfo*, ushort**, int>)(lpVtbl[9]))((IFilterInfo*)Unsafe.AsPointer(ref this), strVendorInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Filter(IUnknown** ppUnk)
        {
            return ((delegate* unmanaged<IFilterInfo*, IUnknown**, int>)(lpVtbl[10]))((IFilterInfo*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Pins(IDispatch** ppUnk)
        {
            return ((delegate* unmanaged<IFilterInfo*, IDispatch**, int>)(lpVtbl[11]))((IFilterInfo*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsFileSource([NativeTypeName("LONG *")] int* pbIsSource)
        {
            return ((delegate* unmanaged<IFilterInfo*, int*, int>)(lpVtbl[12]))((IFilterInfo*)Unsafe.AsPointer(ref this), pbIsSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Filename([NativeTypeName("BSTR *")] ushort** pstrFilename)
        {
            return ((delegate* unmanaged<IFilterInfo*, ushort**, int>)(lpVtbl[13]))((IFilterInfo*)Unsafe.AsPointer(ref this), pstrFilename);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Filename([NativeTypeName("BSTR")] ushort* strFilename)
        {
            return ((delegate* unmanaged<IFilterInfo*, ushort*, int>)(lpVtbl[14]))((IFilterInfo*)Unsafe.AsPointer(ref this), strFilename);
        }
    }
}
