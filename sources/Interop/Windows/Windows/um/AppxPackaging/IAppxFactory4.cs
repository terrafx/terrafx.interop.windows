// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxFactory4.xml' path='doc/member[@name="IAppxFactory4"]/*' />
[Guid("92E50000-6934-4C8D-B472-229D431DADDF")]
[NativeTypeName("struct IAppxFactory4 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxFactory4 : IAppxFactory4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppxFactory4);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFactory4*, Guid*, void**, int>)(lpVtbl[0]))((IAppxFactory4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFactory4*, uint>)(lpVtbl[1]))((IAppxFactory4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFactory4*, uint>)(lpVtbl[2]))((IAppxFactory4*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxFactory4.xml' path='doc/member[@name="IAppxFactory4.CreatePackageReaderFromSourceUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreatePackageReaderFromSourceUri([NativeTypeName("LPCWSTR")] char* uri, [NativeTypeName("LPCWSTR")] char* expectedDigest, IAppxPackageReader** packageReader)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxFactory4*, char*, char*, IAppxPackageReader**, int>)(lpVtbl[3]))((IAppxFactory4*)Unsafe.AsPointer(ref this), uri, expectedDigest, packageReader);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreatePackageReaderFromSourceUri([NativeTypeName("LPCWSTR")] char* uri, [NativeTypeName("LPCWSTR")] char* expectedDigest, IAppxPackageReader** packageReader);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IAppxPackageReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IAppxPackageReader**, int> CreatePackageReaderFromSourceUri;
    }
}
