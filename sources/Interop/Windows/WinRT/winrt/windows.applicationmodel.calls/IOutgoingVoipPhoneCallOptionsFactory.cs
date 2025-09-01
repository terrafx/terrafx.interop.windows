// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IOutgoingVoipPhoneCallOptionsFactory.xml' path='doc/member[@name="IOutgoingVoipPhoneCallOptionsFactory"]/*' />
[Guid("2EA2C6F4-0B7A-5789-9D33-FE3271FDEFA8")]
[NativeTypeName("struct IOutgoingVoipPhoneCallOptionsFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IOutgoingVoipPhoneCallOptionsFactory : IOutgoingVoipPhoneCallOptionsFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IOutgoingVoipPhoneCallOptionsFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptionsFactory*, Guid*, void**, int>)(lpVtbl[0]))((IOutgoingVoipPhoneCallOptionsFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptionsFactory*, uint>)(lpVtbl[1]))((IOutgoingVoipPhoneCallOptionsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptionsFactory*, uint>)(lpVtbl[2]))((IOutgoingVoipPhoneCallOptionsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptionsFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IOutgoingVoipPhoneCallOptionsFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptionsFactory*, HSTRING*, int>)(lpVtbl[4]))((IOutgoingVoipPhoneCallOptionsFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptionsFactory*, TrustLevel*, int>)(lpVtbl[5]))((IOutgoingVoipPhoneCallOptionsFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IOutgoingVoipPhoneCallOptionsFactory.xml' path='doc/member[@name="IOutgoingVoipPhoneCallOptionsFactory.CreateInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateInstance([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* associatedDeviceIds, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IOutgoingVoipPhoneCallOptions **")] IOutgoingVoipPhoneCallOptions** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptionsFactory*, IIterable<HSTRING>*, IOutgoingVoipPhoneCallOptions**, int>)(lpVtbl[6]))((IOutgoingVoipPhoneCallOptionsFactory*)Unsafe.AsPointer(ref this), associatedDeviceIds, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateInstance([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* associatedDeviceIds, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IOutgoingVoipPhoneCallOptions **")] IOutgoingVoipPhoneCallOptions** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::ApplicationModel::Calls::IOutgoingVoipPhoneCallOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IOutgoingVoipPhoneCallOptions**, int> CreateInstance;
    }
}
