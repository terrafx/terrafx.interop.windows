// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGameBarServicesManager.xml' path='doc/member[@name="IGameBarServicesManager"]/*' />
[Guid("3A4B9CFA-7F8B-4C60-9DBB-0BCD262DFFC6")]
[NativeTypeName("struct IGameBarServicesManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGameBarServicesManager : IGameBarServicesManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGameBarServicesManager);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesManager*, Guid*, void**, int>)(lpVtbl[0]))((IGameBarServicesManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesManager*, uint>)(lpVtbl[1]))((IGameBarServicesManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesManager*, uint>)(lpVtbl[2]))((IGameBarServicesManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesManager*, uint*, Guid**, int>)(lpVtbl[3]))((IGameBarServicesManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesManager*, HSTRING*, int>)(lpVtbl[4]))((IGameBarServicesManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesManager*, TrustLevel*, int>)(lpVtbl[5]))((IGameBarServicesManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGameBarServicesManager.xml' path='doc/member[@name="IGameBarServicesManager.add_GameBarServicesCreated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_GameBarServicesCreated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CGameBarServicesManager_Windows__CMedia__CCapture__CGameBarServicesManagerGameBarServicesCreatedEventArgs_t *")] ITypedEventHandler<Pointer<IGameBarServicesManager>, Pointer<IGameBarServicesManagerGameBarServicesCreatedEventArgs>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesManager*, ITypedEventHandler<Pointer<IGameBarServicesManager>, Pointer<IGameBarServicesManagerGameBarServicesCreatedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IGameBarServicesManager*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IGameBarServicesManager.xml' path='doc/member[@name="IGameBarServicesManager.remove_GameBarServicesCreated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_GameBarServicesCreated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGameBarServicesManager*, EventRegistrationToken, int>)(lpVtbl[7]))((IGameBarServicesManager*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_GameBarServicesCreated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CGameBarServicesManager_Windows__CMedia__CCapture__CGameBarServicesManagerGameBarServicesCreatedEventArgs_t *")] ITypedEventHandler<Pointer<IGameBarServicesManager>, Pointer<IGameBarServicesManagerGameBarServicesCreatedEventArgs>>* value, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_GameBarServicesCreated(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CGameBarServicesManager_Windows__CMedia__CCapture__CGameBarServicesManagerGameBarServicesCreatedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGameBarServicesManager>, Pointer<IGameBarServicesManagerGameBarServicesCreatedEventArgs>>*, EventRegistrationToken*, int> add_GameBarServicesCreated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_GameBarServicesCreated;
    }
}
