// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxBundleFactory3.xml' path='doc/member[@name="IAppxBundleFactory3"]/*' />
[Guid("D11EA6B6-3909-4376-B7C4-10D50F5CF3AE")]
[NativeTypeName("struct IAppxBundleFactory3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxBundleFactory3 : IAppxBundleFactory3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppxBundleFactory3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBundleFactory3*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleFactory3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBundleFactory3*, uint>)(lpVtbl[1]))((IAppxBundleFactory3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBundleFactory3*, uint>)(lpVtbl[2]))((IAppxBundleFactory3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBundleFactory3.xml' path='doc/member[@name="IAppxBundleFactory3.CreateBundleReaderFromSourceUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateBundleReaderFromSourceUri([NativeTypeName("LPCWSTR")] char* uri, [NativeTypeName("LPCWSTR")] char* expectedDigest, IAppxBundleReader** bundleReader)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxBundleFactory3*, char*, char*, IAppxBundleReader**, int>)(lpVtbl[3]))((IAppxBundleFactory3*)Unsafe.AsPointer(ref this), uri, expectedDigest, bundleReader);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateBundleReaderFromSourceUri([NativeTypeName("LPCWSTR")] char* uri, [NativeTypeName("LPCWSTR")] char* expectedDigest, IAppxBundleReader** bundleReader);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IAppxBundleReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IAppxBundleReader**, int> CreateBundleReaderFromSourceUri;
    }
}
