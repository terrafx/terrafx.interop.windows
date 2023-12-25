// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimeZoneSettingsStatics.xml' path='doc/member[@name="ITimeZoneSettingsStatics"]/*' />
[Guid("9B3B2BEA-A101-41AE-9FBD-028728BAB73D")]
[NativeTypeName("struct ITimeZoneSettingsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimeZoneSettingsStatics : ITimeZoneSettingsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimeZoneSettingsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneSettingsStatics*, Guid*, void**, int>)(lpVtbl[0]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneSettingsStatics*, uint>)(lpVtbl[1]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneSettingsStatics*, uint>)(lpVtbl[2]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneSettingsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneSettingsStatics*, HSTRING*, int>)(lpVtbl[4]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneSettingsStatics*, TrustLevel*, int>)(lpVtbl[5]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimeZoneSettingsStatics.xml' path='doc/member[@name="ITimeZoneSettingsStatics.get_CurrentTimeZoneDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CurrentTimeZoneDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneSettingsStatics*, HSTRING*, int>)(lpVtbl[6]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimeZoneSettingsStatics.xml' path='doc/member[@name="ITimeZoneSettingsStatics.get_SupportedTimeZoneDisplayNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedTimeZoneDisplayNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneSettingsStatics*, IVectorView<HSTRING>**, int>)(lpVtbl[7]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimeZoneSettingsStatics.xml' path='doc/member[@name="ITimeZoneSettingsStatics.get_CanChangeTimeZone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CanChangeTimeZone([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneSettingsStatics*, byte*, int>)(lpVtbl[8]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimeZoneSettingsStatics.xml' path='doc/member[@name="ITimeZoneSettingsStatics.ChangeTimeZoneByDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ChangeTimeZoneByDisplayName(HSTRING timeZoneDisplayName)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneSettingsStatics*, HSTRING, int>)(lpVtbl[9]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), timeZoneDisplayName);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CurrentTimeZoneDisplayName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_SupportedTimeZoneDisplayNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);

        [VtblIndex(8)]
        HRESULT get_CanChangeTimeZone([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT ChangeTimeZoneByDisplayName(HSTRING timeZoneDisplayName);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CurrentTimeZoneDisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_SupportedTimeZoneDisplayNames;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanChangeTimeZone;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> ChangeTimeZoneByDisplayName;
    }
}
