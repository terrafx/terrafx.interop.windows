// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICharacterReceivedEventArgs.xml' path='doc/member[@name="ICharacterReceivedEventArgs"]/*' />
[Guid("C584659F-99B2-4BCC-BD33-04E63F42902E")]
[NativeTypeName("struct ICharacterReceivedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICharacterReceivedEventArgs : ICharacterReceivedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICharacterReceivedEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICharacterReceivedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICharacterReceivedEventArgs*, uint>)(lpVtbl[1]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICharacterReceivedEventArgs*, uint>)(lpVtbl[2]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICharacterReceivedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICharacterReceivedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICharacterReceivedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICharacterReceivedEventArgs.xml' path='doc/member[@name="ICharacterReceivedEventArgs.get_KeyCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_KeyCode([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICharacterReceivedEventArgs*, uint*, int>)(lpVtbl[6]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICharacterReceivedEventArgs.xml' path='doc/member[@name="ICharacterReceivedEventArgs.get_KeyStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_KeyStatus([NativeTypeName("ABI::Windows::UI::Core::CorePhysicalKeyStatus *")] CorePhysicalKeyStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICharacterReceivedEventArgs*, CorePhysicalKeyStatus*, int>)(lpVtbl[7]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_KeyCode([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_KeyStatus([NativeTypeName("ABI::Windows::UI::Core::CorePhysicalKeyStatus *")] CorePhysicalKeyStatus* value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_KeyCode;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CorePhysicalKeyStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CorePhysicalKeyStatus*, int> get_KeyStatus;
    }
}
