// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILocalContentSuggestionSettings.xml' path='doc/member[@name="ILocalContentSuggestionSettings"]/*' />
[Guid("EEAEB062-743D-456E-84A3-23F06F2D15D7")]
[NativeTypeName("struct ILocalContentSuggestionSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILocalContentSuggestionSettings : ILocalContentSuggestionSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ILocalContentSuggestionSettings);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILocalContentSuggestionSettings*, Guid*, void**, int>)(lpVtbl[0]))((ILocalContentSuggestionSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILocalContentSuggestionSettings*, uint>)(lpVtbl[1]))((ILocalContentSuggestionSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILocalContentSuggestionSettings*, uint>)(lpVtbl[2]))((ILocalContentSuggestionSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILocalContentSuggestionSettings*, uint*, Guid**, int>)(lpVtbl[3]))((ILocalContentSuggestionSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILocalContentSuggestionSettings*, HSTRING*, int>)(lpVtbl[4]))((ILocalContentSuggestionSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILocalContentSuggestionSettings*, TrustLevel*, int>)(lpVtbl[5]))((ILocalContentSuggestionSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILocalContentSuggestionSettings.xml' path='doc/member[@name="ILocalContentSuggestionSettings.put_Enabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Enabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILocalContentSuggestionSettings*, byte, int>)(lpVtbl[6]))((ILocalContentSuggestionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILocalContentSuggestionSettings.xml' path='doc/member[@name="ILocalContentSuggestionSettings.get_Enabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Enabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILocalContentSuggestionSettings*, byte*, int>)(lpVtbl[7]))((ILocalContentSuggestionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILocalContentSuggestionSettings.xml' path='doc/member[@name="ILocalContentSuggestionSettings.get_Locations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Locations([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStorageFolder_t **")] IVector<Pointer<IStorageFolder>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILocalContentSuggestionSettings*, IVector<Pointer<IStorageFolder>>**, int>)(lpVtbl[8]))((ILocalContentSuggestionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILocalContentSuggestionSettings.xml' path='doc/member[@name="ILocalContentSuggestionSettings.put_AqsFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AqsFilter(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILocalContentSuggestionSettings*, HSTRING, int>)(lpVtbl[9]))((ILocalContentSuggestionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILocalContentSuggestionSettings.xml' path='doc/member[@name="ILocalContentSuggestionSettings.get_AqsFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AqsFilter(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILocalContentSuggestionSettings*, HSTRING*, int>)(lpVtbl[10]))((ILocalContentSuggestionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILocalContentSuggestionSettings.xml' path='doc/member[@name="ILocalContentSuggestionSettings.get_PropertiesToMatch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PropertiesToMatch([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILocalContentSuggestionSettings*, IVector<HSTRING>**, int>)(lpVtbl[11]))((ILocalContentSuggestionSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Enabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT get_Enabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_Locations([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStorageFolder_t **")] IVector<Pointer<IStorageFolder>>** value);

        [VtblIndex(9)]
        HRESULT put_AqsFilter(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_AqsFilter(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_PropertiesToMatch([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_Enabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Enabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IStorageFolder>>**, int> get_Locations;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_AqsFilter;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AqsFilter;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_PropertiesToMatch;
    }
}
