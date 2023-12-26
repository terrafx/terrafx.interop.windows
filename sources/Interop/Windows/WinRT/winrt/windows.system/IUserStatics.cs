// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserStatics.xml' path='doc/member[@name="IUserStatics"]/*' />
[Guid("155EB23B-242A-45E0-A2E9-3171FC6A7FDD")]
[NativeTypeName("struct IUserStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserStatics : IUserStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserStatics*, Guid*, void**, int>)(lpVtbl[0]))((IUserStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserStatics*, uint>)(lpVtbl[1]))((IUserStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserStatics*, uint>)(lpVtbl[2]))((IUserStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IUserStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserStatics*, HSTRING*, int>)(lpVtbl[4]))((IUserStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserStatics*, TrustLevel*, int>)(lpVtbl[5]))((IUserStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserStatics.xml' path='doc/member[@name="IUserStatics.CreateWatcher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWatcher([NativeTypeName("ABI::Windows::System::IUserWatcher **")] IUserWatcher** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserStatics*, IUserWatcher**, int>)(lpVtbl[6]))((IUserStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IUserStatics.xml' path='doc/member[@name="IUserStatics.FindAllAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindAllAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSystem__CUser_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserStatics*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IUserStatics*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IUserStatics.xml' path='doc/member[@name="IUserStatics.FindAllAsyncByType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("FindAllAsyncByType is deprecated and might not function consistently on all platforms. Instead, use FindAllAsync or GetDefault.")]
    public HRESULT FindAllAsyncByType([NativeTypeName("ABI::Windows::System::UserType")] UserType type, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSystem__CUser_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserStatics*, UserType, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IUserStatics*)Unsafe.AsPointer(ref this), type, operation);
    }

    /// <include file='IUserStatics.xml' path='doc/member[@name="IUserStatics.FindAllAsyncByTypeAndStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("FindAllAsyncByTypeAndStatus is deprecated and might not function consistently on all platforms. Instead, use FindAllAsync or GetDefault.")]
    public HRESULT FindAllAsyncByTypeAndStatus([NativeTypeName("ABI::Windows::System::UserType")] UserType type, [NativeTypeName("ABI::Windows::System::UserAuthenticationStatus")] UserAuthenticationStatus status, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSystem__CUser_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserStatics*, UserType, UserAuthenticationStatus, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IUserStatics*)Unsafe.AsPointer(ref this), type, status, operation);
    }

    /// <include file='IUserStatics.xml' path='doc/member[@name="IUserStatics.GetFromId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFromId(HSTRING nonRoamableId, [NativeTypeName("ABI::Windows::System::IUser **")] IUser** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserStatics*, HSTRING, IUser**, int>)(lpVtbl[10]))((IUserStatics*)Unsafe.AsPointer(ref this), nonRoamableId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWatcher([NativeTypeName("ABI::Windows::System::IUserWatcher **")] IUserWatcher** result);

        [VtblIndex(7)]
        HRESULT FindAllAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSystem__CUser_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(8)]
        [Obsolete("FindAllAsyncByType is deprecated and might not function consistently on all platforms. Instead, use FindAllAsync or GetDefault.")]
        HRESULT FindAllAsyncByType([NativeTypeName("ABI::Windows::System::UserType")] UserType type, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSystem__CUser_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(9)]
        [Obsolete("FindAllAsyncByTypeAndStatus is deprecated and might not function consistently on all platforms. Instead, use FindAllAsync or GetDefault.")]
        HRESULT FindAllAsyncByTypeAndStatus([NativeTypeName("ABI::Windows::System::UserType")] UserType type, [NativeTypeName("ABI::Windows::System::UserAuthenticationStatus")] UserAuthenticationStatus status, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSystem__CUser_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(10)]
        HRESULT GetFromId(HSTRING nonRoamableId, [NativeTypeName("ABI::Windows::System::IUser **")] IUser** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IUserWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserWatcher**, int> CreateWatcher;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSystem__CUser_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> FindAllAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::UserType, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSystem__CUser_t **) __attribute__((stdcall))")]
        [Obsolete("FindAllAsyncByType is deprecated and might not function consistently on all platforms. Instead, use FindAllAsync or GetDefault.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserType, IAsyncOperation<IntPtr>**, int> FindAllAsyncByType;

        [NativeTypeName("HRESULT (ABI::Windows::System::UserType, ABI::Windows::System::UserAuthenticationStatus, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSystem__CUser_t **) __attribute__((stdcall))")]
        [Obsolete("FindAllAsyncByTypeAndStatus is deprecated and might not function consistently on all platforms. Instead, use FindAllAsync or GetDefault.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserType, UserAuthenticationStatus, IAsyncOperation<IntPtr>**, int> FindAllAsyncByTypeAndStatus;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IUser**, int> GetFromId;
    }
}
