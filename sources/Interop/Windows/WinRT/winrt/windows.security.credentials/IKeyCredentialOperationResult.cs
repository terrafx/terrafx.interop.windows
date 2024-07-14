// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyCredentialOperationResult.xml' path='doc/member[@name="IKeyCredentialOperationResult"]/*' />
[Guid("F53786C1-5261-4CDD-976D-CC909AC71620")]
[NativeTypeName("struct IKeyCredentialOperationResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyCredentialOperationResult : IKeyCredentialOperationResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKeyCredentialOperationResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialOperationResult*, Guid*, void**, int>)(lpVtbl[0]))((IKeyCredentialOperationResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialOperationResult*, uint>)(lpVtbl[1]))((IKeyCredentialOperationResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialOperationResult*, uint>)(lpVtbl[2]))((IKeyCredentialOperationResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialOperationResult*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyCredentialOperationResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialOperationResult*, HSTRING*, int>)(lpVtbl[4]))((IKeyCredentialOperationResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialOperationResult*, TrustLevel*, int>)(lpVtbl[5]))((IKeyCredentialOperationResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyCredentialOperationResult.xml' path='doc/member[@name="IKeyCredentialOperationResult.get_Result"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Result([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialOperationResult*, IBuffer**, int>)(lpVtbl[6]))((IKeyCredentialOperationResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyCredentialOperationResult.xml' path='doc/member[@name="IKeyCredentialOperationResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Security::Credentials::KeyCredentialStatus *")] KeyCredentialStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialOperationResult*, KeyCredentialStatus*, int>)(lpVtbl[7]))((IKeyCredentialOperationResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Result([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(7)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Security::Credentials::KeyCredentialStatus *")] KeyCredentialStatus* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_Result;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::KeyCredentialStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, KeyCredentialStatus*, int> get_Status;
    }
}
