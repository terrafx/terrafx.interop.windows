// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStreamSocketListener3.xml' path='doc/member[@name="IStreamSocketListener3"]/*' />
[Guid("4798201C-BDF8-4919-8542-28D450E74507")]
[NativeTypeName("struct IStreamSocketListener3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSocketListener3 : IStreamSocketListener3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamSocketListener3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener3*, Guid*, void**, int>)(lpVtbl[0]))((IStreamSocketListener3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener3*, uint>)(lpVtbl[1]))((IStreamSocketListener3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener3*, uint>)(lpVtbl[2]))((IStreamSocketListener3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener3*, uint*, Guid**, int>)(lpVtbl[3]))((IStreamSocketListener3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener3*, HSTRING*, int>)(lpVtbl[4]))((IStreamSocketListener3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener3*, TrustLevel*, int>)(lpVtbl[5]))((IStreamSocketListener3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStreamSocketListener3.xml' path='doc/member[@name="IStreamSocketListener3.CancelIOAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CancelIOAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener3*, IAsyncAction**, int>)(lpVtbl[6]))((IStreamSocketListener3*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IStreamSocketListener3.xml' path='doc/member[@name="IStreamSocketListener3.EnableTransferOwnership"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnableTransferOwnership(Guid taskId)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener3*, Guid, int>)(lpVtbl[7]))((IStreamSocketListener3*)Unsafe.AsPointer(ref this), taskId);
    }

    /// <include file='IStreamSocketListener3.xml' path='doc/member[@name="IStreamSocketListener3.EnableTransferOwnershipWithConnectedStandbyAction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnableTransferOwnershipWithConnectedStandbyAction(Guid taskId, [NativeTypeName("ABI::Windows::Networking::Sockets::SocketActivityConnectedStandbyAction")] SocketActivityConnectedStandbyAction connectedStandbyAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener3*, Guid, SocketActivityConnectedStandbyAction, int>)(lpVtbl[8]))((IStreamSocketListener3*)Unsafe.AsPointer(ref this), taskId, connectedStandbyAction);
    }

    /// <include file='IStreamSocketListener3.xml' path='doc/member[@name="IStreamSocketListener3.TransferOwnership"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TransferOwnership(HSTRING socketId)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener3*, HSTRING, int>)(lpVtbl[9]))((IStreamSocketListener3*)Unsafe.AsPointer(ref this), socketId);
    }

    /// <include file='IStreamSocketListener3.xml' path='doc/member[@name="IStreamSocketListener3.TransferOwnershipWithContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TransferOwnershipWithContext(HSTRING socketId, [NativeTypeName("ABI::Windows::Networking::Sockets::ISocketActivityContext *")] ISocketActivityContext* data)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener3*, HSTRING, ISocketActivityContext*, int>)(lpVtbl[10]))((IStreamSocketListener3*)Unsafe.AsPointer(ref this), socketId, data);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CancelIOAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(7)]
        HRESULT EnableTransferOwnership(Guid taskId);

        [VtblIndex(8)]
        HRESULT EnableTransferOwnershipWithConnectedStandbyAction(Guid taskId, [NativeTypeName("ABI::Windows::Networking::Sockets::SocketActivityConnectedStandbyAction")] SocketActivityConnectedStandbyAction connectedStandbyAction);

        [VtblIndex(9)]
        HRESULT TransferOwnership(HSTRING socketId);

        [VtblIndex(10)]
        HRESULT TransferOwnershipWithContext(HSTRING socketId, [NativeTypeName("ABI::Windows::Networking::Sockets::ISocketActivityContext *")] ISocketActivityContext* data);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> CancelIOAsync;

        [NativeTypeName("HRESULT (GUID) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, int> EnableTransferOwnership;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Networking::Sockets::SocketActivityConnectedStandbyAction) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, SocketActivityConnectedStandbyAction, int> EnableTransferOwnershipWithConnectedStandbyAction;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> TransferOwnership;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Networking::Sockets::ISocketActivityContext *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ISocketActivityContext*, int> TransferOwnershipWithContext;
    }
}
