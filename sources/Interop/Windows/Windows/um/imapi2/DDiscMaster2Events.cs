// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("27354131-7F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct DDiscMaster2Events : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct DDiscMaster2Events : DDiscMaster2Events.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<DDiscMaster2Events*, Guid*, void**, int>)(lpVtbl[0]))((DDiscMaster2Events*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<DDiscMaster2Events*, uint>)(lpVtbl[1]))((DDiscMaster2Events*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<DDiscMaster2Events*, uint>)(lpVtbl[2]))((DDiscMaster2Events*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<DDiscMaster2Events*, uint*, int>)(lpVtbl[3]))((DDiscMaster2Events*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<DDiscMaster2Events*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((DDiscMaster2Events*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<DDiscMaster2Events*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((DDiscMaster2Events*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<DDiscMaster2Events*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((DDiscMaster2Events*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT NotifyDeviceAdded(IDispatch* @object, [NativeTypeName("BSTR")] ushort* uniqueId)
    {
        return ((delegate* unmanaged<DDiscMaster2Events*, IDispatch*, ushort*, int>)(lpVtbl[7]))((DDiscMaster2Events*)Unsafe.AsPointer(ref this), @object, uniqueId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT NotifyDeviceRemoved(IDispatch* @object, [NativeTypeName("BSTR")] ushort* uniqueId)
    {
        return ((delegate* unmanaged<DDiscMaster2Events*, IDispatch*, ushort*, int>)(lpVtbl[8]))((DDiscMaster2Events*)Unsafe.AsPointer(ref this), @object, uniqueId);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT NotifyDeviceAdded(IDispatch* @object, [NativeTypeName("BSTR")] ushort* uniqueId);

        [VtblIndex(8)]
        HRESULT NotifyDeviceRemoved(IDispatch* @object, [NativeTypeName("BSTR")] ushort* uniqueId);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (IDispatch *, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, ushort*, int> NotifyDeviceAdded;

        [NativeTypeName("HRESULT (IDispatch *, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, ushort*, int> NotifyDeviceRemoved;
    }
}
