// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUICommandFactory.xml' path='doc/member[@name="IUICommandFactory"]/*' />
[Guid("A21A8189-26B0-4676-AE94-54041BC125E8")]
[NativeTypeName("struct IUICommandFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUICommandFactory : IUICommandFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUICommandFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommandFactory*, Guid*, void**, int>)(lpVtbl[0]))((IUICommandFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommandFactory*, uint>)(lpVtbl[1]))((IUICommandFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommandFactory*, uint>)(lpVtbl[2]))((IUICommandFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommandFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IUICommandFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommandFactory*, HSTRING*, int>)(lpVtbl[4]))((IUICommandFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommandFactory*, TrustLevel*, int>)(lpVtbl[5]))((IUICommandFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUICommandFactory.xml' path='doc/member[@name="IUICommandFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(HSTRING label, [NativeTypeName("ABI::Windows::UI::Popups::IUICommand **")] IUICommand** instance)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommandFactory*, HSTRING, IUICommand**, int>)(lpVtbl[6]))((IUICommandFactory*)Unsafe.AsPointer(ref this), label, instance);
    }

    /// <include file='IUICommandFactory.xml' path='doc/member[@name="IUICommandFactory.CreateWithHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithHandler(HSTRING label, [NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* action, [NativeTypeName("ABI::Windows::UI::Popups::IUICommand **")] IUICommand** instance)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommandFactory*, HSTRING, IUICommandInvokedHandler*, IUICommand**, int>)(lpVtbl[7]))((IUICommandFactory*)Unsafe.AsPointer(ref this), label, action, instance);
    }

    /// <include file='IUICommandFactory.xml' path='doc/member[@name="IUICommandFactory.CreateWithHandlerAndId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWithHandlerAndId(HSTRING label, [NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* action, IInspectable* commandId, [NativeTypeName("ABI::Windows::UI::Popups::IUICommand **")] IUICommand** instance)
    {
        return ((delegate* unmanaged[MemberFunction]<IUICommandFactory*, HSTRING, IUICommandInvokedHandler*, IInspectable*, IUICommand**, int>)(lpVtbl[8]))((IUICommandFactory*)Unsafe.AsPointer(ref this), label, action, commandId, instance);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(HSTRING label, [NativeTypeName("ABI::Windows::UI::Popups::IUICommand **")] IUICommand** instance);

        [VtblIndex(7)]
        HRESULT CreateWithHandler(HSTRING label, [NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* action, [NativeTypeName("ABI::Windows::UI::Popups::IUICommand **")] IUICommand** instance);

        [VtblIndex(8)]
        HRESULT CreateWithHandlerAndId(HSTRING label, [NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* action, IInspectable* commandId, [NativeTypeName("ABI::Windows::UI::Popups::IUICommand **")] IUICommand** instance);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Popups::IUICommand **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IUICommand**, int> Create;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Popups::IUICommandInvokedHandler *, ABI::Windows::UI::Popups::IUICommand **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IUICommandInvokedHandler*, IUICommand**, int> CreateWithHandler;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Popups::IUICommandInvokedHandler *, IInspectable *, ABI::Windows::UI::Popups::IUICommand **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IUICommandInvokedHandler*, IInspectable*, IUICommand**, int> CreateWithHandlerAndId;
    }
}
