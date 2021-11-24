// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[Guid("ED90C8AD-5C34-4D05-A1EC-0E8A9B3AD7AF")]
[NativeTypeName("struct IPrintDocumentPackageStatusEvent : IDispatch")]
[NativeInheritance("IDispatch")]
[SupportedOSPlatform("windows8.0")]
public unsafe partial struct IPrintDocumentPackageStatusEvent : IPrintDocumentPackageStatusEvent.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrintDocumentPackageStatusEvent*, Guid*, void**, int>)(lpVtbl[0]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintDocumentPackageStatusEvent*, uint>)(lpVtbl[1]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintDocumentPackageStatusEvent*, uint>)(lpVtbl[2]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IPrintDocumentPackageStatusEvent*, uint*, int>)(lpVtbl[3]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IPrintDocumentPackageStatusEvent*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IPrintDocumentPackageStatusEvent*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT PackageStatusUpdated(PrintDocumentPackageStatus* packageStatus)
    {
        return ((delegate* unmanaged<IPrintDocumentPackageStatusEvent*, PrintDocumentPackageStatus*, int>)(lpVtbl[7]))((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), packageStatus);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT PackageStatusUpdated(PrintDocumentPackageStatus* packageStatus);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintDocumentPackageStatusEvent*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintDocumentPackageStatusEvent*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintDocumentPackageStatusEvent*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintDocumentPackageStatusEvent*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintDocumentPackageStatusEvent*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintDocumentPackageStatusEvent*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (PrintDocumentPackageStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintDocumentPackageStatusEvent*, PrintDocumentPackageStatus*, int> PackageStatusUpdated;
    }
}
