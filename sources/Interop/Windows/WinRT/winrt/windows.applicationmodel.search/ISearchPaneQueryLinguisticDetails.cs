// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISearchPaneQueryLinguisticDetails.xml' path='doc/member[@name="ISearchPaneQueryLinguisticDetails"]/*' />
[Guid("82FB460E-0940-4B6D-B8D0-642B30989E15")]
[NativeTypeName("struct ISearchPaneQueryLinguisticDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISearchPaneQueryLinguisticDetails : ISearchPaneQueryLinguisticDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchPaneQueryLinguisticDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQueryLinguisticDetails*, Guid*, void**, int>)(lpVtbl[0]))((ISearchPaneQueryLinguisticDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQueryLinguisticDetails*, uint>)(lpVtbl[1]))((ISearchPaneQueryLinguisticDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQueryLinguisticDetails*, uint>)(lpVtbl[2]))((ISearchPaneQueryLinguisticDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQueryLinguisticDetails*, uint*, Guid**, int>)(lpVtbl[3]))((ISearchPaneQueryLinguisticDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQueryLinguisticDetails*, HSTRING*, int>)(lpVtbl[4]))((ISearchPaneQueryLinguisticDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQueryLinguisticDetails*, TrustLevel*, int>)(lpVtbl[5]))((ISearchPaneQueryLinguisticDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISearchPaneQueryLinguisticDetails.xml' path='doc/member[@name="ISearchPaneQueryLinguisticDetails.get_QueryTextAlternatives"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_QueryTextAlternatives([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQueryLinguisticDetails*, IVectorView<HSTRING>**, int>)(lpVtbl[6]))((ISearchPaneQueryLinguisticDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPaneQueryLinguisticDetails.xml' path='doc/member[@name="ISearchPaneQueryLinguisticDetails.get_QueryTextCompositionStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_QueryTextCompositionStart([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQueryLinguisticDetails*, uint*, int>)(lpVtbl[7]))((ISearchPaneQueryLinguisticDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPaneQueryLinguisticDetails.xml' path='doc/member[@name="ISearchPaneQueryLinguisticDetails.get_QueryTextCompositionLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_QueryTextCompositionLength([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQueryLinguisticDetails*, uint*, int>)(lpVtbl[8]))((ISearchPaneQueryLinguisticDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_QueryTextAlternatives([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);

        [VtblIndex(7)]
        HRESULT get_QueryTextCompositionStart([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_QueryTextCompositionLength([NativeTypeName("UINT32 *")] uint* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_QueryTextAlternatives;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_QueryTextCompositionStart;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_QueryTextCompositionLength;
    }
}
