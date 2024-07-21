// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContentIndexerStatics.xml' path='doc/member[@name="IContentIndexerStatics"]/*' />
[Guid("8C488375-B37E-4C60-9BA8-B760FDA3E59D")]
[NativeTypeName("struct IContentIndexerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContentIndexerStatics : IContentIndexerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContentIndexerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerStatics*, uint>)(lpVtbl[1]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerStatics*, uint>)(lpVtbl[2]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerStatics*, HSTRING*, int>)(lpVtbl[4]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContentIndexerStatics.xml' path='doc/member[@name="IContentIndexerStatics.GetIndexerWithName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetIndexerWithName(HSTRING indexName, [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexer **")] IContentIndexer** index)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerStatics*, HSTRING, IContentIndexer**, int>)(lpVtbl[6]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this), indexName, index);
    }

    /// <include file='IContentIndexerStatics.xml' path='doc/member[@name="IContentIndexerStatics.GetIndexer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetIndexer([NativeTypeName("ABI::Windows::Storage::Search::IContentIndexer **")] IContentIndexer** index)
    {
        return ((delegate* unmanaged[MemberFunction]<IContentIndexerStatics*, IContentIndexer**, int>)(lpVtbl[7]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this), index);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetIndexerWithName(HSTRING indexName, [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexer **")] IContentIndexer** index);

        [VtblIndex(7)]
        HRESULT GetIndexer([NativeTypeName("ABI::Windows::Storage::Search::IContentIndexer **")] IContentIndexer** index);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Search::IContentIndexer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IContentIndexer**, int> GetIndexerWithName;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Search::IContentIndexer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContentIndexer**, int> GetIndexer;
    }
}
