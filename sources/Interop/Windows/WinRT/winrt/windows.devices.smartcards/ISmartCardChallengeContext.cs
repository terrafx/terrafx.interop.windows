// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardChallengeContext.xml' path='doc/member[@name="ISmartCardChallengeContext"]/*' />
[Guid("192A5319-C9C4-4947-81CC-44794A61EF91")]
[NativeTypeName("struct ISmartCardChallengeContext : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardChallengeContext : ISmartCardChallengeContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmartCardChallengeContext);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardChallengeContext*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardChallengeContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardChallengeContext*, uint>)(lpVtbl[1]))((ISmartCardChallengeContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardChallengeContext*, uint>)(lpVtbl[2]))((ISmartCardChallengeContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardChallengeContext*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardChallengeContext*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardChallengeContext*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardChallengeContext*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardChallengeContext*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardChallengeContext*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardChallengeContext.xml' path='doc/member[@name="ISmartCardChallengeContext.get_Challenge"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Challenge([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardChallengeContext*, IBuffer**, int>)(lpVtbl[6]))((ISmartCardChallengeContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardChallengeContext.xml' path='doc/member[@name="ISmartCardChallengeContext.VerifyResponseAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT VerifyResponseAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* response, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardChallengeContext*, IBuffer*, IAsyncOperation<bool>**, int>)(lpVtbl[7]))((ISmartCardChallengeContext*)Unsafe.AsPointer(ref this), response, result);
    }

    /// <include file='ISmartCardChallengeContext.xml' path='doc/member[@name="ISmartCardChallengeContext.ProvisionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ProvisionAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* response, [NativeTypeName("boolean")] byte formatCard, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardChallengeContext*, IBuffer*, byte, IAsyncAction**, int>)(lpVtbl[8]))((ISmartCardChallengeContext*)Unsafe.AsPointer(ref this), response, formatCard, result);
    }

    /// <include file='ISmartCardChallengeContext.xml' path='doc/member[@name="ISmartCardChallengeContext.ProvisionAsyncWithNewCardId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ProvisionAsyncWithNewCardId([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* response, [NativeTypeName("boolean")] byte formatCard, Guid newCardId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardChallengeContext*, IBuffer*, byte, Guid, IAsyncAction**, int>)(lpVtbl[9]))((ISmartCardChallengeContext*)Unsafe.AsPointer(ref this), response, formatCard, newCardId, result);
    }

    /// <include file='ISmartCardChallengeContext.xml' path='doc/member[@name="ISmartCardChallengeContext.ChangeAdministrativeKeyAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ChangeAdministrativeKeyAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* response, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* newAdministrativeKey, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardChallengeContext*, IBuffer*, IBuffer*, IAsyncAction**, int>)(lpVtbl[10]))((ISmartCardChallengeContext*)Unsafe.AsPointer(ref this), response, newAdministrativeKey, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Challenge([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(7)]
        HRESULT VerifyResponseAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* response, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(8)]
        HRESULT ProvisionAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* response, [NativeTypeName("boolean")] byte formatCard, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(9)]
        HRESULT ProvisionAsyncWithNewCardId([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* response, [NativeTypeName("boolean")] byte formatCard, Guid newCardId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(10)]
        HRESULT ChangeAdministrativeKeyAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* response, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* newAdministrativeKey, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_Challenge;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IAsyncOperation<bool>**, int> VerifyResponseAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, boolean, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, byte, IAsyncAction**, int> ProvisionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, boolean, GUID, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, byte, Guid, IAsyncAction**, int> ProvisionAsyncWithNewCardId;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IBuffer*, IAsyncAction**, int> ChangeAdministrativeKeyAsync;
    }
}
