// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyCredentialWithWindow.xml' path='doc/member[@name="IKeyCredentialWithWindow"]/*' />
[Guid("050DEB3B-B19C-4635-9DF6-5650D66C62B1")]
[NativeTypeName("struct IKeyCredentialWithWindow : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyCredentialWithWindow : IKeyCredentialWithWindow.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKeyCredentialWithWindow);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialWithWindow*, Guid*, void**, int>)(lpVtbl[0]))((IKeyCredentialWithWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialWithWindow*, uint>)(lpVtbl[1]))((IKeyCredentialWithWindow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialWithWindow*, uint>)(lpVtbl[2]))((IKeyCredentialWithWindow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialWithWindow*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyCredentialWithWindow*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialWithWindow*, HSTRING*, int>)(lpVtbl[4]))((IKeyCredentialWithWindow*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialWithWindow*, TrustLevel*, int>)(lpVtbl[5]))((IKeyCredentialWithWindow*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyCredentialWithWindow.xml' path='doc/member[@name="IKeyCredentialWithWindow.RequestSignForWindowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestSignForWindowAsync([NativeTypeName("ABI::Windows::UI::WindowId")] WindowId window, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialOperationResult_t **")] IAsyncOperation<Pointer<IKeyCredentialOperationResult>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialWithWindow*, WindowId, IBuffer*, IAsyncOperation<Pointer<IKeyCredentialOperationResult>>**, int>)(lpVtbl[6]))((IKeyCredentialWithWindow*)Unsafe.AsPointer(ref this), window, data, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestSignForWindowAsync([NativeTypeName("ABI::Windows::UI::WindowId")] WindowId window, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialOperationResult_t **")] IAsyncOperation<Pointer<IKeyCredentialOperationResult>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::WindowId, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialOperationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WindowId, IBuffer*, IAsyncOperation<Pointer<IKeyCredentialOperationResult>>**, int> RequestSignForWindowAsync;
    }
}
