// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardAppletIdGroupRegistration2.xml' path='doc/member[@name="ISmartCardAppletIdGroupRegistration2"]/*' />
[Guid("5F5508D8-98A7-4F2E-91D9-6CFCCEDA407F")]
[NativeTypeName("struct ISmartCardAppletIdGroupRegistration2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardAppletIdGroupRegistration2 : ISmartCardAppletIdGroupRegistration2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardAppletIdGroupRegistration2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration2*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardAppletIdGroupRegistration2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration2*, uint>)(lpVtbl[1]))((ISmartCardAppletIdGroupRegistration2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration2*, uint>)(lpVtbl[2]))((ISmartCardAppletIdGroupRegistration2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration2*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardAppletIdGroupRegistration2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration2*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardAppletIdGroupRegistration2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration2*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardAppletIdGroupRegistration2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardAppletIdGroupRegistration2.xml' path='doc/member[@name="ISmartCardAppletIdGroupRegistration2.get_SmartCardReaderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SmartCardReaderId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration2*, HSTRING*, int>)(lpVtbl[6]))((ISmartCardAppletIdGroupRegistration2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroupRegistration2.xml' path='doc/member[@name="ISmartCardAppletIdGroupRegistration2.SetPropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* props, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration2*, IPropertySet*, IAsyncAction**, int>)(lpVtbl[7]))((ISmartCardAppletIdGroupRegistration2*)Unsafe.AsPointer(ref this), props, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SmartCardReaderId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT SetPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* props, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SmartCardReaderId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet*, IAsyncAction**, int> SetPropertiesAsync;
    }
}
