// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppInfoStatics.xml' path='doc/member[@name="IAppInfoStatics"]/*' />
[Guid("CF1F782A-E48B-4F0C-9B0B-79C3F8957DD7")]
[NativeTypeName("struct IAppInfoStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppInfoStatics : IAppInfoStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppInfoStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInfoStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAppInfoStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInfoStatics*, uint>)(lpVtbl[1]))((IAppInfoStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInfoStatics*, uint>)(lpVtbl[2]))((IAppInfoStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInfoStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAppInfoStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInfoStatics*, HSTRING*, int>)(lpVtbl[4]))((IAppInfoStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInfoStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAppInfoStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppInfoStatics.xml' path='doc/member[@name="IAppInfoStatics.get_Current"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Current([NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IAppInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInfoStatics*, IAppInfo**, int>)(lpVtbl[6]))((IAppInfoStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppInfoStatics.xml' path='doc/member[@name="IAppInfoStatics.GetFromAppUserModelId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFromAppUserModelId(HSTRING appUserModelId, [NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IAppInfo** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInfoStatics*, HSTRING, IAppInfo**, int>)(lpVtbl[7]))((IAppInfoStatics*)Unsafe.AsPointer(ref this), appUserModelId, result);
    }

    /// <include file='IAppInfoStatics.xml' path='doc/member[@name="IAppInfoStatics.GetFromAppUserModelIdForUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFromAppUserModelIdForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING appUserModelId, [NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IAppInfo** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppInfoStatics*, IUser*, HSTRING, IAppInfo**, int>)(lpVtbl[8]))((IAppInfoStatics*)Unsafe.AsPointer(ref this), user, appUserModelId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Current([NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IAppInfo** value);

        [VtblIndex(7)]
        HRESULT GetFromAppUserModelId(HSTRING appUserModelId, [NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IAppInfo** result);

        [VtblIndex(8)]
        HRESULT GetFromAppUserModelIdForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING appUserModelId, [NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IAppInfo** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::IAppInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppInfo**, int> get_Current;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::IAppInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAppInfo**, int> GetFromAppUserModelId;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::ApplicationModel::IAppInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, IAppInfo**, int> GetFromAppUserModelIdForUser;
    }
}
