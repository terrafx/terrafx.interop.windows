// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305107C5-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IWebGeolocation : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IWebGeolocation : IWebGeolocation.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWebGeolocation*, Guid*, void**, int>)(lpVtbl[0]))((IWebGeolocation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWebGeolocation*, uint>)(lpVtbl[1]))((IWebGeolocation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWebGeolocation*, uint>)(lpVtbl[2]))((IWebGeolocation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IWebGeolocation*, uint*, int>)(lpVtbl[3]))((IWebGeolocation*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IWebGeolocation*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IWebGeolocation*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IWebGeolocation*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IWebGeolocation*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IWebGeolocation*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IWebGeolocation*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT getCurrentPosition(IDispatch* successCallback, IDispatch* errorCallback = null, IDispatch* options = null)
        {
            return ((delegate* unmanaged<IWebGeolocation*, IDispatch*, IDispatch*, IDispatch*, int>)(lpVtbl[7]))((IWebGeolocation*)Unsafe.AsPointer(ref this), successCallback, errorCallback, options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT watchPosition(IDispatch* successCallback, IDispatch* errorCallback, IDispatch* options, [NativeTypeName("long *")] int* watchId)
        {
            return ((delegate* unmanaged<IWebGeolocation*, IDispatch*, IDispatch*, IDispatch*, int*, int>)(lpVtbl[8]))((IWebGeolocation*)Unsafe.AsPointer(ref this), successCallback, errorCallback, options, watchId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT clearWatch([NativeTypeName("long")] int watchId)
        {
            return ((delegate* unmanaged<IWebGeolocation*, int, int>)(lpVtbl[9]))((IWebGeolocation*)Unsafe.AsPointer(ref this), watchId);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT getCurrentPosition(IDispatch* successCallback, IDispatch* errorCallback = null, IDispatch* options = null);

            [VtblIndex(8)]
            HRESULT watchPosition(IDispatch* successCallback, IDispatch* errorCallback, IDispatch* options, [NativeTypeName("long *")] int* watchId);

            [VtblIndex(9)]
            HRESULT clearWatch([NativeTypeName("long")] int watchId);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebGeolocation*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWebGeolocation*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWebGeolocation*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebGeolocation*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebGeolocation*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebGeolocation*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebGeolocation*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (IDispatch *, IDispatch *, IDispatch *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebGeolocation*, IDispatch*, IDispatch*, IDispatch*, int> getCurrentPosition;

            [NativeTypeName("HRESULT (IDispatch *, IDispatch *, IDispatch *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebGeolocation*, IDispatch*, IDispatch*, IDispatch*, int*, int> watchPosition;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebGeolocation*, int, int> clearWatch;
        }
    }
}
