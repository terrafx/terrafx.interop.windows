// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailIrmInfoFactory.xml' path='doc/member[@name="IEmailIrmInfoFactory"]/*' />
[Guid("314BB18C-E3E6-4D7B-BE8D-91A96311B01B")]
[NativeTypeName("struct IEmailIrmInfoFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailIrmInfoFactory : IEmailIrmInfoFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailIrmInfoFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfoFactory*, Guid*, void**, int>)(lpVtbl[0]))((IEmailIrmInfoFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfoFactory*, uint>)(lpVtbl[1]))((IEmailIrmInfoFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfoFactory*, uint>)(lpVtbl[2]))((IEmailIrmInfoFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfoFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailIrmInfoFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfoFactory*, HSTRING*, int>)(lpVtbl[4]))((IEmailIrmInfoFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfoFactory*, TrustLevel*, int>)(lpVtbl[5]))((IEmailIrmInfoFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailIrmInfoFactory.xml' path='doc/member[@name="IEmailIrmInfoFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime expiration, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailIrmTemplate *")] IEmailIrmTemplate* irmTemplate, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailIrmInfo **")] IEmailIrmInfo** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfoFactory*, WinRTDateTime, IEmailIrmTemplate*, IEmailIrmInfo**, int>)(lpVtbl[6]))((IEmailIrmInfoFactory*)Unsafe.AsPointer(ref this), expiration, irmTemplate, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime expiration, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailIrmTemplate *")] IEmailIrmTemplate* irmTemplate, [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailIrmInfo **")] IEmailIrmInfo** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::ApplicationModel::Email::IEmailIrmTemplate *, ABI::Windows::ApplicationModel::Email::IEmailIrmInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, IEmailIrmTemplate*, IEmailIrmInfo**, int> Create;
    }
}
