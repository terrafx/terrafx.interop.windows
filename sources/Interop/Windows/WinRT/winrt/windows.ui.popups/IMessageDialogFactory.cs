// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMessageDialogFactory.xml' path='doc/member[@name="IMessageDialogFactory"]/*' />
[Guid("2D161777-A66F-4EA5-BB87-793FFA4941F2")]
[NativeTypeName("struct IMessageDialogFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMessageDialogFactory : IMessageDialogFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMessageDialogFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialogFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialogFactory*, uint>)(lpVtbl[1]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialogFactory*, uint>)(lpVtbl[2]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialogFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialogFactory*, HSTRING*, int>)(lpVtbl[4]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialogFactory*, TrustLevel*, int>)(lpVtbl[5]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMessageDialogFactory.xml' path='doc/member[@name="IMessageDialogFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(HSTRING content, [NativeTypeName("ABI::Windows::UI::Popups::IMessageDialog **")] IMessageDialog** messageDialog)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialogFactory*, HSTRING, IMessageDialog**, int>)(lpVtbl[6]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this), content, messageDialog);
    }

    /// <include file='IMessageDialogFactory.xml' path='doc/member[@name="IMessageDialogFactory.CreateWithTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithTitle(HSTRING content, HSTRING title, [NativeTypeName("ABI::Windows::UI::Popups::IMessageDialog **")] IMessageDialog** messageDialog)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageDialogFactory*, HSTRING, HSTRING, IMessageDialog**, int>)(lpVtbl[7]))((IMessageDialogFactory*)Unsafe.AsPointer(ref this), content, title, messageDialog);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(HSTRING content, [NativeTypeName("ABI::Windows::UI::Popups::IMessageDialog **")] IMessageDialog** messageDialog);

        [VtblIndex(7)]
        HRESULT CreateWithTitle(HSTRING content, HSTRING title, [NativeTypeName("ABI::Windows::UI::Popups::IMessageDialog **")] IMessageDialog** messageDialog);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Popups::IMessageDialog **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IMessageDialog**, int> Create;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::UI::Popups::IMessageDialog **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IMessageDialog**, int> CreateWithTitle;
    }
}
