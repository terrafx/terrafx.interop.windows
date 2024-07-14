// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderQuotaUI.xml' path='doc/member[@name="IStorageProviderQuotaUI"]/*' />
[Guid("BA6295C3-312E-544F-9FD5-1F81B21F3649")]
[NativeTypeName("struct IStorageProviderQuotaUI : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderQuotaUI : IStorageProviderQuotaUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderQuotaUI));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQuotaUI*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderQuotaUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQuotaUI*, uint>)(lpVtbl[1]))((IStorageProviderQuotaUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQuotaUI*, uint>)(lpVtbl[2]))((IStorageProviderQuotaUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQuotaUI*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderQuotaUI*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQuotaUI*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderQuotaUI*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQuotaUI*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderQuotaUI*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderQuotaUI.xml' path='doc/member[@name="IStorageProviderQuotaUI.get_QuotaTotalInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_QuotaTotalInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQuotaUI*, ulong*, int>)(lpVtbl[6]))((IStorageProviderQuotaUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQuotaUI.xml' path='doc/member[@name="IStorageProviderQuotaUI.put_QuotaTotalInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_QuotaTotalInBytes([NativeTypeName("UINT64")] ulong value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQuotaUI*, ulong, int>)(lpVtbl[7]))((IStorageProviderQuotaUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQuotaUI.xml' path='doc/member[@name="IStorageProviderQuotaUI.get_QuotaUsedInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_QuotaUsedInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQuotaUI*, ulong*, int>)(lpVtbl[8]))((IStorageProviderQuotaUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQuotaUI.xml' path='doc/member[@name="IStorageProviderQuotaUI.put_QuotaUsedInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_QuotaUsedInBytes([NativeTypeName("UINT64")] ulong value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQuotaUI*, ulong, int>)(lpVtbl[9]))((IStorageProviderQuotaUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQuotaUI.xml' path='doc/member[@name="IStorageProviderQuotaUI.get_QuotaUsedLabel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_QuotaUsedLabel(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQuotaUI*, HSTRING*, int>)(lpVtbl[10]))((IStorageProviderQuotaUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQuotaUI.xml' path='doc/member[@name="IStorageProviderQuotaUI.put_QuotaUsedLabel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_QuotaUsedLabel(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQuotaUI*, HSTRING, int>)(lpVtbl[11]))((IStorageProviderQuotaUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQuotaUI.xml' path='doc/member[@name="IStorageProviderQuotaUI.get_QuotaUsedColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_QuotaUsedColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQuotaUI*, IReference<Color>**, int>)(lpVtbl[12]))((IStorageProviderQuotaUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageProviderQuotaUI.xml' path='doc/member[@name="IStorageProviderQuotaUI.put_QuotaUsedColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_QuotaUsedColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderQuotaUI*, IReference<Color>*, int>)(lpVtbl[13]))((IStorageProviderQuotaUI*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_QuotaTotalInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT put_QuotaTotalInBytes([NativeTypeName("UINT64")] ulong value);

        [VtblIndex(8)]
        HRESULT get_QuotaUsedInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(9)]
        HRESULT put_QuotaUsedInBytes([NativeTypeName("UINT64")] ulong value);

        [VtblIndex(10)]
        HRESULT get_QuotaUsedLabel(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_QuotaUsedLabel(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_QuotaUsedColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(13)]
        HRESULT put_QuotaUsedColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_QuotaTotalInBytes;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, int> put_QuotaTotalInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_QuotaUsedInBytes;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, int> put_QuotaUsedInBytes;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_QuotaUsedLabel;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_QuotaUsedLabel;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_QuotaUsedColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_QuotaUsedColor;
    }
}
