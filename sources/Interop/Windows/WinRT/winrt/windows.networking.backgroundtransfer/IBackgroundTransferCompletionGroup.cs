// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTransferCompletionGroup.xml' path='doc/member[@name="IBackgroundTransferCompletionGroup"]/*' />
[Guid("2D930225-986B-574D-7950-0ADD47F5D706")]
[NativeTypeName("struct IBackgroundTransferCompletionGroup : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTransferCompletionGroup : IBackgroundTransferCompletionGroup.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBackgroundTransferCompletionGroup);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroup*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTransferCompletionGroup*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroup*, uint>)(lpVtbl[1]))((IBackgroundTransferCompletionGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroup*, uint>)(lpVtbl[2]))((IBackgroundTransferCompletionGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroup*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTransferCompletionGroup*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroup*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTransferCompletionGroup*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroup*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTransferCompletionGroup*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTransferCompletionGroup.xml' path='doc/member[@name="IBackgroundTransferCompletionGroup.get_Trigger"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Trigger([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **")] IBackgroundTrigger** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroup*, IBackgroundTrigger**, int>)(lpVtbl[6]))((IBackgroundTransferCompletionGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferCompletionGroup.xml' path='doc/member[@name="IBackgroundTransferCompletionGroup.get_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroup*, byte*, int>)(lpVtbl[7]))((IBackgroundTransferCompletionGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferCompletionGroup.xml' path='doc/member[@name="IBackgroundTransferCompletionGroup.Enable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Enable()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroup*, int>)(lpVtbl[8]))((IBackgroundTransferCompletionGroup*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Trigger([NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **")] IBackgroundTrigger** value);

        [VtblIndex(7)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT Enable();
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBackgroundTrigger**, int> get_Trigger;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Enable;
    }
}
