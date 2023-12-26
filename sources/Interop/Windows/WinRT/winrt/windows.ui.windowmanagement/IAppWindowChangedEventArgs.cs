// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppWindowChangedEventArgs.xml' path='doc/member[@name="IAppWindowChangedEventArgs"]/*' />
[Guid("1DE1F3BE-A655-55AD-B2B6-EB240F880356")]
[NativeTypeName("struct IAppWindowChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppWindowChangedEventArgs : IAppWindowChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppWindowChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAppWindowChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowChangedEventArgs*, uint>)(lpVtbl[1]))((IAppWindowChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowChangedEventArgs*, uint>)(lpVtbl[2]))((IAppWindowChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAppWindowChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IAppWindowChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAppWindowChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppWindowChangedEventArgs.xml' path='doc/member[@name="IAppWindowChangedEventArgs.get_DidAvailableWindowPresentationsChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DidAvailableWindowPresentationsChange([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowChangedEventArgs*, byte*, int>)(lpVtbl[6]))((IAppWindowChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowChangedEventArgs.xml' path='doc/member[@name="IAppWindowChangedEventArgs.get_DidDisplayRegionsChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DidDisplayRegionsChange([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowChangedEventArgs*, byte*, int>)(lpVtbl[7]))((IAppWindowChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowChangedEventArgs.xml' path='doc/member[@name="IAppWindowChangedEventArgs.get_DidFrameChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DidFrameChange([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowChangedEventArgs*, byte*, int>)(lpVtbl[8]))((IAppWindowChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowChangedEventArgs.xml' path='doc/member[@name="IAppWindowChangedEventArgs.get_DidSizeChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DidSizeChange([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowChangedEventArgs*, byte*, int>)(lpVtbl[9]))((IAppWindowChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowChangedEventArgs.xml' path='doc/member[@name="IAppWindowChangedEventArgs.get_DidTitleBarChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DidTitleBarChange([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowChangedEventArgs*, byte*, int>)(lpVtbl[10]))((IAppWindowChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowChangedEventArgs.xml' path='doc/member[@name="IAppWindowChangedEventArgs.get_DidVisibilityChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DidVisibilityChange([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowChangedEventArgs*, byte*, int>)(lpVtbl[11]))((IAppWindowChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowChangedEventArgs.xml' path='doc/member[@name="IAppWindowChangedEventArgs.get_DidWindowingEnvironmentChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DidWindowingEnvironmentChange([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowChangedEventArgs*, byte*, int>)(lpVtbl[12]))((IAppWindowChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowChangedEventArgs.xml' path='doc/member[@name="IAppWindowChangedEventArgs.get_DidWindowPresentationChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_DidWindowPresentationChange([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowChangedEventArgs*, byte*, int>)(lpVtbl[13]))((IAppWindowChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DidAvailableWindowPresentationsChange([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_DidDisplayRegionsChange([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_DidFrameChange([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_DidSizeChange([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_DidTitleBarChange([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_DidVisibilityChange([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT get_DidWindowingEnvironmentChange([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT get_DidWindowPresentationChange([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DidAvailableWindowPresentationsChange;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DidDisplayRegionsChange;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DidFrameChange;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DidSizeChange;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DidTitleBarChange;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DidVisibilityChange;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DidWindowingEnvironmentChange;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DidWindowPresentationChange;
    }
}
