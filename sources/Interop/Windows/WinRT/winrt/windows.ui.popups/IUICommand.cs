// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUICommand.xml' path='doc/member[@name="IUICommand"]/*' />
[Guid("4FF93A75-4145-47FF-AC7F-DFF1C1FA5B0F")]
[NativeTypeName("struct IUICommand : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUICommand : IUICommand.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUICommand));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommand*, Guid*, void**, int>)(lpVtbl[0]))((IUICommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommand*, uint>)(lpVtbl[1]))((IUICommand*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommand*, uint>)(lpVtbl[2]))((IUICommand*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommand*, uint*, Guid**, int>)(lpVtbl[3]))((IUICommand*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommand*, HSTRING*, int>)(lpVtbl[4]))((IUICommand*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommand*, TrustLevel*, int>)(lpVtbl[5]))((IUICommand*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUICommand.xml' path='doc/member[@name="IUICommand.get_Label"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Label(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommand*, HSTRING*, int>)(lpVtbl[6]))((IUICommand*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUICommand.xml' path='doc/member[@name="IUICommand.put_Label"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Label(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommand*, HSTRING, int>)(lpVtbl[7]))((IUICommand*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUICommand.xml' path='doc/member[@name="IUICommand.get_Invoked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Invoked([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler **")] IUICommandInvokedHandler** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommand*, IUICommandInvokedHandler**, int>)(lpVtbl[8]))((IUICommand*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUICommand.xml' path='doc/member[@name="IUICommand.put_Invoked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Invoked([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommand*, IUICommandInvokedHandler*, int>)(lpVtbl[9]))((IUICommand*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUICommand.xml' path='doc/member[@name="IUICommand.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Id(IInspectable** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommand*, IInspectable**, int>)(lpVtbl[10]))((IUICommand*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUICommand.xml' path='doc/member[@name="IUICommand.put_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Id(IInspectable* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommand*, IInspectable*, int>)(lpVtbl[11]))((IUICommand*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Label(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Label(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Invoked([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler **")] IUICommandInvokedHandler** value);

        [VtblIndex(9)]
        HRESULT put_Invoked([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* value);

        [VtblIndex(10)]
        HRESULT get_Id(IInspectable** value);

        [VtblIndex(11)]
        HRESULT put_Id(IInspectable* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Label;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Label;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Popups::IUICommandInvokedHandler **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUICommandInvokedHandler**, int> get_Invoked;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Popups::IUICommandInvokedHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUICommandInvokedHandler*, int> put_Invoked;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> get_Id;

        [NativeTypeName("HRESULT (IInspectable *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, int> put_Id;
    }
}
