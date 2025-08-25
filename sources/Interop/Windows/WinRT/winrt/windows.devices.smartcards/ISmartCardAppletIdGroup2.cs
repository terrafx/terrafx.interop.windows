// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardAppletIdGroup2.xml' path='doc/member[@name="ISmartCardAppletIdGroup2"]/*' />
[Guid("6B0EF9DC-9956-4A62-8D4E-D37A68EBC3A6")]
[NativeTypeName("struct ISmartCardAppletIdGroup2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardAppletIdGroup2 : ISmartCardAppletIdGroup2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmartCardAppletIdGroup2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup2*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardAppletIdGroup2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup2*, uint>)(lpVtbl[1]))((ISmartCardAppletIdGroup2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup2*, uint>)(lpVtbl[2]))((ISmartCardAppletIdGroup2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup2*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardAppletIdGroup2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup2*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardAppletIdGroup2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup2*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardAppletIdGroup2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardAppletIdGroup2.xml' path='doc/member[@name="ISmartCardAppletIdGroup2.get_Logo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Logo([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup2*, IRandomAccessStreamReference**, int>)(lpVtbl[6]))((ISmartCardAppletIdGroup2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroup2.xml' path='doc/member[@name="ISmartCardAppletIdGroup2.put_Logo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Logo([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup2*, IRandomAccessStreamReference*, int>)(lpVtbl[7]))((ISmartCardAppletIdGroup2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroup2.xml' path='doc/member[@name="ISmartCardAppletIdGroup2.get_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Description(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup2*, HSTRING*, int>)(lpVtbl[8]))((ISmartCardAppletIdGroup2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroup2.xml' path='doc/member[@name="ISmartCardAppletIdGroup2.put_Description"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Description(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup2*, HSTRING, int>)(lpVtbl[9]))((ISmartCardAppletIdGroup2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroup2.xml' path='doc/member[@name="ISmartCardAppletIdGroup2.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup2*, IPropertySet**, int>)(lpVtbl[10]))((ISmartCardAppletIdGroup2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroup2.xml' path='doc/member[@name="ISmartCardAppletIdGroup2.get_SecureUserAuthenticationRequired"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SecureUserAuthenticationRequired([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup2*, byte*, int>)(lpVtbl[11]))((ISmartCardAppletIdGroup2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroup2.xml' path='doc/member[@name="ISmartCardAppletIdGroup2.put_SecureUserAuthenticationRequired"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_SecureUserAuthenticationRequired([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup2*, byte, int>)(lpVtbl[12]))((ISmartCardAppletIdGroup2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Logo([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(7)]
        HRESULT put_Logo([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(8)]
        HRESULT get_Description(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Description(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value);

        [VtblIndex(11)]
        HRESULT get_SecureUserAuthenticationRequired([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_SecureUserAuthenticationRequired([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_Logo;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_Logo;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Description;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Description;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet**, int> get_Properties;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SecureUserAuthenticationRequired;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_SecureUserAuthenticationRequired;
    }
}
