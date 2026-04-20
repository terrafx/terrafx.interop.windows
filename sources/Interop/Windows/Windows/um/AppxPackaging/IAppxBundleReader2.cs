// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxBundleReader2.xml' path='doc/member[@name="IAppxBundleReader2"]/*' />
[Guid("98262195-D63A-4C10-B4CF-DD72E061BA87")]
[NativeTypeName("struct IAppxBundleReader2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxBundleReader2 : IAppxBundleReader2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppxBundleReader2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBundleReader2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleReader2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBundleReader2*, uint>)(lpVtbl[1]))((IAppxBundleReader2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBundleReader2*, uint>)(lpVtbl[2]))((IAppxBundleReader2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBundleReader2.xml' path='doc/member[@name="IAppxBundleReader2.GetPayloadPackageReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPayloadPackageReader([NativeTypeName("LPCWSTR")] char* fileName, IAppxPackageReader** payloadPackageReader)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBundleReader2*, char*, IAppxPackageReader**, int>)(lpVtbl[3]))((IAppxBundleReader2*)Unsafe.AsPointer(ref this), fileName, payloadPackageReader);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPayloadPackageReader([NativeTypeName("LPCWSTR")] char* fileName, IAppxPackageReader** payloadPackageReader);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR, IAppxPackageReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IAppxPackageReader**, int> GetPayloadPackageReader;
    }
}
