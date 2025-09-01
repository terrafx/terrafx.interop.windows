// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMessageWebSocket3.xml' path='doc/member[@name="IMessageWebSocket3"]/*' />
[Guid("59D9DEFB-71AF-4349-8487-911FCF681597")]
[NativeTypeName("struct IMessageWebSocket3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMessageWebSocket3 : IMessageWebSocket3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMessageWebSocket3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket3*, Guid*, void**, int>)(lpVtbl[0]))((IMessageWebSocket3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket3*, uint>)(lpVtbl[1]))((IMessageWebSocket3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket3*, uint>)(lpVtbl[2]))((IMessageWebSocket3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket3*, uint*, Guid**, int>)(lpVtbl[3]))((IMessageWebSocket3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket3*, HSTRING*, int>)(lpVtbl[4]))((IMessageWebSocket3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket3*, TrustLevel*, int>)(lpVtbl[5]))((IMessageWebSocket3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMessageWebSocket3.xml' path='doc/member[@name="IMessageWebSocket3.SendNonfinalFrameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SendNonfinalFrameAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT32_UINT32_t **")] IAsyncOperationWithProgress<uint, uint>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket3*, IBuffer*, IAsyncOperationWithProgress<uint, uint>**, int>)(lpVtbl[6]))((IMessageWebSocket3*)Unsafe.AsPointer(ref this), data, operation);
    }

    /// <include file='IMessageWebSocket3.xml' path='doc/member[@name="IMessageWebSocket3.SendFinalFrameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SendFinalFrameAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT32_UINT32_t **")] IAsyncOperationWithProgress<uint, uint>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket3*, IBuffer*, IAsyncOperationWithProgress<uint, uint>**, int>)(lpVtbl[7]))((IMessageWebSocket3*)Unsafe.AsPointer(ref this), data, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SendNonfinalFrameAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT32_UINT32_t **")] IAsyncOperationWithProgress<uint, uint>** operation);

        [VtblIndex(7)]
        HRESULT SendFinalFrameAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT32_UINT32_t **")] IAsyncOperationWithProgress<uint, uint>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT32_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IAsyncOperationWithProgress<uint, uint>**, int> SendNonfinalFrameAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT32_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IAsyncOperationWithProgress<uint, uint>**, int> SendFinalFrameAsync;
    }
}
