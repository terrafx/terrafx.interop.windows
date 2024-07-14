// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaProtectionManager.xml' path='doc/member[@name="IMediaProtectionManager"]/*' />
[Guid("45694947-C741-434B-A79E-474C12D93D2F")]
[NativeTypeName("struct IMediaProtectionManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaProtectionManager : IMediaProtectionManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaProtectionManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaProtectionManager*, Guid*, void**, int>)(lpVtbl[0]))((IMediaProtectionManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaProtectionManager*, uint>)(lpVtbl[1]))((IMediaProtectionManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaProtectionManager*, uint>)(lpVtbl[2]))((IMediaProtectionManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaProtectionManager*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaProtectionManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaProtectionManager*, HSTRING*, int>)(lpVtbl[4]))((IMediaProtectionManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaProtectionManager*, TrustLevel*, int>)(lpVtbl[5]))((IMediaProtectionManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaProtectionManager.xml' path='doc/member[@name="IMediaProtectionManager.add_ServiceRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ServiceRequested([NativeTypeName("ABI::Windows::Media::Protection::IServiceRequestedEventHandler *")] IServiceRequestedEventHandler* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaProtectionManager*, IServiceRequestedEventHandler*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaProtectionManager*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaProtectionManager.xml' path='doc/member[@name="IMediaProtectionManager.remove_ServiceRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ServiceRequested(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaProtectionManager*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaProtectionManager*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaProtectionManager.xml' path='doc/member[@name="IMediaProtectionManager.add_RebootNeeded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_RebootNeeded([NativeTypeName("ABI::Windows::Media::Protection::IRebootNeededEventHandler *")] IRebootNeededEventHandler* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaProtectionManager*, IRebootNeededEventHandler*, EventRegistrationToken*, int>)(lpVtbl[8]))((IMediaProtectionManager*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaProtectionManager.xml' path='doc/member[@name="IMediaProtectionManager.remove_RebootNeeded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_RebootNeeded(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaProtectionManager*, EventRegistrationToken, int>)(lpVtbl[9]))((IMediaProtectionManager*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaProtectionManager.xml' path='doc/member[@name="IMediaProtectionManager.add_ComponentLoadFailed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ComponentLoadFailed([NativeTypeName("ABI::Windows::Media::Protection::IComponentLoadFailedEventHandler *")] IComponentLoadFailedEventHandler* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaProtectionManager*, IComponentLoadFailedEventHandler*, EventRegistrationToken*, int>)(lpVtbl[10]))((IMediaProtectionManager*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaProtectionManager.xml' path='doc/member[@name="IMediaProtectionManager.remove_ComponentLoadFailed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ComponentLoadFailed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaProtectionManager*, EventRegistrationToken, int>)(lpVtbl[11]))((IMediaProtectionManager*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaProtectionManager.xml' path='doc/member[@name="IMediaProtectionManager.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaProtectionManager*, IPropertySet**, int>)(lpVtbl[12]))((IMediaProtectionManager*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ServiceRequested([NativeTypeName("ABI::Windows::Media::Protection::IServiceRequestedEventHandler *")] IServiceRequestedEventHandler* handler, EventRegistrationToken* cookie);

        [VtblIndex(7)]
        HRESULT remove_ServiceRequested(EventRegistrationToken cookie);

        [VtblIndex(8)]
        HRESULT add_RebootNeeded([NativeTypeName("ABI::Windows::Media::Protection::IRebootNeededEventHandler *")] IRebootNeededEventHandler* handler, EventRegistrationToken* cookie);

        [VtblIndex(9)]
        HRESULT remove_RebootNeeded(EventRegistrationToken cookie);

        [VtblIndex(10)]
        HRESULT add_ComponentLoadFailed([NativeTypeName("ABI::Windows::Media::Protection::IComponentLoadFailedEventHandler *")] IComponentLoadFailedEventHandler* handler, EventRegistrationToken* cookie);

        [VtblIndex(11)]
        HRESULT remove_ComponentLoadFailed(EventRegistrationToken cookie);

        [VtblIndex(12)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::IServiceRequestedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IServiceRequestedEventHandler*, EventRegistrationToken*, int> add_ServiceRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ServiceRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::IRebootNeededEventHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRebootNeededEventHandler*, EventRegistrationToken*, int> add_RebootNeeded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RebootNeeded;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::IComponentLoadFailedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IComponentLoadFailedEventHandler*, EventRegistrationToken*, int> add_ComponentLoadFailed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ComponentLoadFailed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet**, int> get_Properties;
    }
}
