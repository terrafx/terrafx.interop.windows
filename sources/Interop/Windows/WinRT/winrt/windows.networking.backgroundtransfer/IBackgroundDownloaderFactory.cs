// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundDownloaderFactory.xml' path='doc/member[@name="IBackgroundDownloaderFactory"]/*' />
[Guid("26836C24-D89E-46F4-A29A-4F4D4F144155")]
[NativeTypeName("struct IBackgroundDownloaderFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundDownloaderFactory : IBackgroundDownloaderFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBackgroundDownloaderFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderFactory*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundDownloaderFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderFactory*, uint>)(lpVtbl[1]))((IBackgroundDownloaderFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderFactory*, uint>)(lpVtbl[2]))((IBackgroundDownloaderFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundDownloaderFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderFactory*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundDownloaderFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderFactory*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundDownloaderFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundDownloaderFactory.xml' path='doc/member[@name="IBackgroundDownloaderFactory.CreateWithCompletionGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithCompletionGroup([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferCompletionGroup *")] IBackgroundTransferCompletionGroup* completionGroup, [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundDownloader **")] IBackgroundDownloader** backgroundDownloader)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloaderFactory*, IBackgroundTransferCompletionGroup*, IBackgroundDownloader**, int>)(lpVtbl[6]))((IBackgroundDownloaderFactory*)Unsafe.AsPointer(ref this), completionGroup, backgroundDownloader);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithCompletionGroup([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferCompletionGroup *")] IBackgroundTransferCompletionGroup* completionGroup, [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundDownloader **")] IBackgroundDownloader** backgroundDownloader);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferCompletionGroup *, ABI::Windows::Networking::BackgroundTransfer::IBackgroundDownloader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTransferCompletionGroup*, IBackgroundDownloader**, int> CreateWithCompletionGroup;
    }
}
