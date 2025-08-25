// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxManifestQualifiedResource.xml' path='doc/member[@name="IAppxManifestQualifiedResource"]/*' />
[Guid("3B53A497-3C5C-48D1-9EA3-BB7EAC8CD7D4")]
[NativeTypeName("struct IAppxManifestQualifiedResource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestQualifiedResource : IAppxManifestQualifiedResource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppxManifestQualifiedResource);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestQualifiedResource*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestQualifiedResource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestQualifiedResource*, uint>)(lpVtbl[1]))((IAppxManifestQualifiedResource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestQualifiedResource*, uint>)(lpVtbl[2]))((IAppxManifestQualifiedResource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestQualifiedResource.xml' path='doc/member[@name="IAppxManifestQualifiedResource.GetLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetLanguage([NativeTypeName("LPWSTR *")] char** language)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestQualifiedResource*, char**, int>)(lpVtbl[3]))((IAppxManifestQualifiedResource*)Unsafe.AsPointer(ref this), language);
    }

    /// <include file='IAppxManifestQualifiedResource.xml' path='doc/member[@name="IAppxManifestQualifiedResource.GetScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetScale([NativeTypeName("UINT32 *")] uint* scale)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestQualifiedResource*, uint*, int>)(lpVtbl[4]))((IAppxManifestQualifiedResource*)Unsafe.AsPointer(ref this), scale);
    }

    /// <include file='IAppxManifestQualifiedResource.xml' path='doc/member[@name="IAppxManifestQualifiedResource.GetDXFeatureLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDXFeatureLevel(DX_FEATURE_LEVEL* dxFeatureLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestQualifiedResource*, DX_FEATURE_LEVEL*, int>)(lpVtbl[5]))((IAppxManifestQualifiedResource*)Unsafe.AsPointer(ref this), dxFeatureLevel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetLanguage([NativeTypeName("LPWSTR *")] char** language);

        [VtblIndex(4)]
        HRESULT GetScale([NativeTypeName("UINT32 *")] uint* scale);

        [VtblIndex(5)]
        HRESULT GetDXFeatureLevel(DX_FEATURE_LEVEL* dxFeatureLevel);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetLanguage;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetScale;

        [NativeTypeName("HRESULT (DX_FEATURE_LEVEL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DX_FEATURE_LEVEL*, int> GetDXFeatureLevel;
    }
}
