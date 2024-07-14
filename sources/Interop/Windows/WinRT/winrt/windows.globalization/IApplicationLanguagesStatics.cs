// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IApplicationLanguagesStatics.xml' path='doc/member[@name="IApplicationLanguagesStatics"]/*' />
[Guid("75B40847-0A4C-4A92-9565-FD63C95F7AED")]
[NativeTypeName("struct IApplicationLanguagesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationLanguagesStatics : IApplicationLanguagesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationLanguagesStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationLanguagesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationLanguagesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationLanguagesStatics*, uint>)(lpVtbl[1]))((IApplicationLanguagesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationLanguagesStatics*, uint>)(lpVtbl[2]))((IApplicationLanguagesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationLanguagesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IApplicationLanguagesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationLanguagesStatics*, HSTRING*, int>)(lpVtbl[4]))((IApplicationLanguagesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationLanguagesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IApplicationLanguagesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IApplicationLanguagesStatics.xml' path='doc/member[@name="IApplicationLanguagesStatics.get_PrimaryLanguageOverride"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PrimaryLanguageOverride(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationLanguagesStatics*, HSTRING*, int>)(lpVtbl[6]))((IApplicationLanguagesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationLanguagesStatics.xml' path='doc/member[@name="IApplicationLanguagesStatics.put_PrimaryLanguageOverride"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_PrimaryLanguageOverride(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationLanguagesStatics*, HSTRING, int>)(lpVtbl[7]))((IApplicationLanguagesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationLanguagesStatics.xml' path='doc/member[@name="IApplicationLanguagesStatics.get_Languages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Languages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationLanguagesStatics*, IVectorView<HSTRING>**, int>)(lpVtbl[8]))((IApplicationLanguagesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationLanguagesStatics.xml' path='doc/member[@name="IApplicationLanguagesStatics.get_ManifestLanguages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ManifestLanguages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationLanguagesStatics*, IVectorView<HSTRING>**, int>)(lpVtbl[9]))((IApplicationLanguagesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PrimaryLanguageOverride(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_PrimaryLanguageOverride(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Languages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);

        [VtblIndex(9)]
        HRESULT get_ManifestLanguages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PrimaryLanguageOverride;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_PrimaryLanguageOverride;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_Languages;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_ManifestLanguages;
    }
}
