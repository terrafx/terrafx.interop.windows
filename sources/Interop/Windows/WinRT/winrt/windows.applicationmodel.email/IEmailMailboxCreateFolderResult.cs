// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailboxCreateFolderResult.xml' path='doc/member[@name="IEmailMailboxCreateFolderResult"]/*' />
[Guid("B228557F-2885-4998-B595-8A2D374CE950")]
[NativeTypeName("struct IEmailMailboxCreateFolderResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxCreateFolderResult : IEmailMailboxCreateFolderResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMailboxCreateFolderResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCreateFolderResult*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMailboxCreateFolderResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCreateFolderResult*, uint>)(lpVtbl[1]))((IEmailMailboxCreateFolderResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCreateFolderResult*, uint>)(lpVtbl[2]))((IEmailMailboxCreateFolderResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCreateFolderResult*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMailboxCreateFolderResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCreateFolderResult*, HSTRING*, int>)(lpVtbl[4]))((IEmailMailboxCreateFolderResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCreateFolderResult*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMailboxCreateFolderResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMailboxCreateFolderResult.xml' path='doc/member[@name="IEmailMailboxCreateFolderResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxCreateFolderStatus *")] EmailMailboxCreateFolderStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCreateFolderResult*, EmailMailboxCreateFolderStatus*, int>)(lpVtbl[6]))((IEmailMailboxCreateFolderResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCreateFolderResult.xml' path='doc/member[@name="IEmailMailboxCreateFolderResult.get_Folder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Folder([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailFolder **")] IEmailFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCreateFolderResult*, IEmailFolder**, int>)(lpVtbl[7]))((IEmailMailboxCreateFolderResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxCreateFolderStatus *")] EmailMailboxCreateFolderStatus* value);

        [VtblIndex(7)]
        HRESULT get_Folder([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailFolder **")] IEmailFolder** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxCreateFolderStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMailboxCreateFolderStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailFolder**, int> get_Folder;
    }
}
