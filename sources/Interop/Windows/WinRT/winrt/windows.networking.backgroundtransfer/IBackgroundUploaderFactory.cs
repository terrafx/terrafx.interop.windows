// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundUploaderFactory.xml' path='doc/member[@name="IBackgroundUploaderFactory"]/*' />
[Guid("736203C7-10E7-48A0-AC3C-1AC71095EC57")]
[NativeTypeName("struct IBackgroundUploaderFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundUploaderFactory : IBackgroundUploaderFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundUploaderFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploaderFactory*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundUploaderFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploaderFactory*, uint>)(lpVtbl[1]))((IBackgroundUploaderFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploaderFactory*, uint>)(lpVtbl[2]))((IBackgroundUploaderFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploaderFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundUploaderFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploaderFactory*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundUploaderFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploaderFactory*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundUploaderFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundUploaderFactory.xml' path='doc/member[@name="IBackgroundUploaderFactory.CreateWithCompletionGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithCompletionGroup([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferCompletionGroup *")] IBackgroundTransferCompletionGroup* completionGroup, [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundUploader **")] IBackgroundUploader** backgroundUploader)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploaderFactory*, IBackgroundTransferCompletionGroup*, IBackgroundUploader**, int>)(lpVtbl[6]))((IBackgroundUploaderFactory*)Unsafe.AsPointer(ref this), completionGroup, backgroundUploader);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithCompletionGroup([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferCompletionGroup *")] IBackgroundTransferCompletionGroup* completionGroup, [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IBackgroundUploader **")] IBackgroundUploader** backgroundUploader);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::IBackgroundTransferCompletionGroup *, ABI::Windows::Networking::BackgroundTransfer::IBackgroundUploader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTransferCompletionGroup*, IBackgroundUploader**, int> CreateWithCompletionGroup;
    }
}
