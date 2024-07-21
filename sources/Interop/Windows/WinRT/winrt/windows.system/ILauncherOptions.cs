// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILauncherOptions.xml' path='doc/member[@name="ILauncherOptions"]/*' />
[Guid("BAFA21D8-B071-4CD8-853E-341203E557D3")]
[NativeTypeName("struct ILauncherOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILauncherOptions : ILauncherOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILauncherOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, uint>)(lpVtbl[1]))((ILauncherOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, uint>)(lpVtbl[2]))((ILauncherOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, HSTRING*, int>)(lpVtbl[4]))((ILauncherOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILauncherOptions.xml' path='doc/member[@name="ILauncherOptions.get_TreatAsUntrusted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TreatAsUntrusted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, byte*, int>)(lpVtbl[6]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions.xml' path='doc/member[@name="ILauncherOptions.put_TreatAsUntrusted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_TreatAsUntrusted([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, byte, int>)(lpVtbl[7]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions.xml' path='doc/member[@name="ILauncherOptions.get_DisplayApplicationPicker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisplayApplicationPicker([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, byte*, int>)(lpVtbl[8]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions.xml' path='doc/member[@name="ILauncherOptions.put_DisplayApplicationPicker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DisplayApplicationPicker([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, byte, int>)(lpVtbl[9]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions.xml' path='doc/member[@name="ILauncherOptions.get_UI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UI([NativeTypeName("ABI::Windows::System::ILauncherUIOptions **")] ILauncherUIOptions** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, ILauncherUIOptions**, int>)(lpVtbl[10]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions.xml' path='doc/member[@name="ILauncherOptions.get_PreferredApplicationPackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PreferredApplicationPackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, HSTRING*, int>)(lpVtbl[11]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions.xml' path='doc/member[@name="ILauncherOptions.put_PreferredApplicationPackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_PreferredApplicationPackageFamilyName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, HSTRING, int>)(lpVtbl[12]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions.xml' path='doc/member[@name="ILauncherOptions.get_PreferredApplicationDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PreferredApplicationDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, HSTRING*, int>)(lpVtbl[13]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions.xml' path='doc/member[@name="ILauncherOptions.put_PreferredApplicationDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_PreferredApplicationDisplayName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, HSTRING, int>)(lpVtbl[14]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions.xml' path='doc/member[@name="ILauncherOptions.get_FallbackUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_FallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, IUriRuntimeClass**, int>)(lpVtbl[15]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions.xml' path='doc/member[@name="ILauncherOptions.put_FallbackUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_FallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, IUriRuntimeClass*, int>)(lpVtbl[16]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions.xml' path='doc/member[@name="ILauncherOptions.get_ContentType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ContentType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, HSTRING*, int>)(lpVtbl[17]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILauncherOptions.xml' path='doc/member[@name="ILauncherOptions.put_ContentType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_ContentType(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILauncherOptions*, HSTRING, int>)(lpVtbl[18]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TreatAsUntrusted([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_TreatAsUntrusted([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_DisplayApplicationPicker([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_DisplayApplicationPicker([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_UI([NativeTypeName("ABI::Windows::System::ILauncherUIOptions **")] ILauncherUIOptions** value);

        [VtblIndex(11)]
        HRESULT get_PreferredApplicationPackageFamilyName(HSTRING* value);

        [VtblIndex(12)]
        HRESULT put_PreferredApplicationPackageFamilyName(HSTRING value);

        [VtblIndex(13)]
        HRESULT get_PreferredApplicationDisplayName(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_PreferredApplicationDisplayName(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_FallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(16)]
        HRESULT put_FallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);

        [VtblIndex(17)]
        HRESULT get_ContentType(HSTRING* value);

        [VtblIndex(18)]
        HRESULT put_ContentType(HSTRING value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_TreatAsUntrusted;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_TreatAsUntrusted;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DisplayApplicationPicker;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_DisplayApplicationPicker;

        [NativeTypeName("HRESULT (ABI::Windows::System::ILauncherUIOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILauncherUIOptions**, int> get_UI;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PreferredApplicationPackageFamilyName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_PreferredApplicationPackageFamilyName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PreferredApplicationDisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_PreferredApplicationDisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_FallbackUri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_FallbackUri;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContentType;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContentType;
    }
}
