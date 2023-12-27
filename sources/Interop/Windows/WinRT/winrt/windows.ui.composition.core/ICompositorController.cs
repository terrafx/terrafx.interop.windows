// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositorController.xml' path='doc/member[@name="ICompositorController"]/*' />
[Guid("2D75F35A-70A7-4395-BA2D-CEF0B18399F9")]
[NativeTypeName("struct ICompositorController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositorController : ICompositorController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositorController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorController*, Guid*, void**, int>)(lpVtbl[0]))((ICompositorController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorController*, uint>)(lpVtbl[1]))((ICompositorController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorController*, uint>)(lpVtbl[2]))((ICompositorController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorController*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositorController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorController*, HSTRING*, int>)(lpVtbl[4]))((ICompositorController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorController*, TrustLevel*, int>)(lpVtbl[5]))((ICompositorController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositorController.xml' path='doc/member[@name="ICompositorController.get_Compositor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Compositor([NativeTypeName("ABI::Windows::UI::Composition::ICompositor **")] ICompositor** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorController*, ICompositor**, int>)(lpVtbl[6]))((ICompositorController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositorController.xml' path='doc/member[@name="ICompositorController.Commit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorController*, int>)(lpVtbl[7]))((ICompositorController*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICompositorController.xml' path='doc/member[@name="ICompositorController.EnsurePreviousCommitCompletedAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnsurePreviousCommitCompletedAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorController*, IAsyncAction**, int>)(lpVtbl[8]))((ICompositorController*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='ICompositorController.xml' path='doc/member[@name="ICompositorController.add_CommitNeeded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_CommitNeeded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CComposition__CCore__CCompositorController_IInspectable_t *")] ITypedEventHandler<Pointer<ICompositorController>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorController*, ITypedEventHandler<Pointer<ICompositorController>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ICompositorController*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICompositorController.xml' path='doc/member[@name="ICompositorController.remove_CommitNeeded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_CommitNeeded(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorController*, EventRegistrationToken, int>)(lpVtbl[10]))((ICompositorController*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Compositor([NativeTypeName("ABI::Windows::UI::Composition::ICompositor **")] ICompositor** value);

        [VtblIndex(7)]
        HRESULT Commit();

        [VtblIndex(8)]
        HRESULT EnsurePreviousCommitCompletedAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(9)]
        HRESULT add_CommitNeeded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CComposition__CCore__CCompositorController_IInspectable_t *")] ITypedEventHandler<Pointer<ICompositorController>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_CommitNeeded(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor**, int> get_Compositor;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Commit;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> EnsurePreviousCommitCompletedAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CComposition__CCore__CCompositorController_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICompositorController>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_CommitNeeded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CommitNeeded;
    }
}
