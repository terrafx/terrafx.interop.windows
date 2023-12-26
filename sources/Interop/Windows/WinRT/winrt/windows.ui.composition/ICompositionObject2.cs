// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionObject2.xml' path='doc/member[@name="ICompositionObject2"]/*' />
[Guid("EF874EA1-5CFF-4B68-9E30-A1519D08BA03")]
[NativeTypeName("struct ICompositionObject2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionObject2 : ICompositionObject2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionObject2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject2*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionObject2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject2*, uint>)(lpVtbl[1]))((ICompositionObject2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject2*, uint>)(lpVtbl[2]))((ICompositionObject2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject2*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionObject2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject2*, HSTRING*, int>)(lpVtbl[4]))((ICompositionObject2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject2*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionObject2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionObject2.xml' path='doc/member[@name="ICompositionObject2.get_Comment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Comment(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject2*, HSTRING*, int>)(lpVtbl[6]))((ICompositionObject2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionObject2.xml' path='doc/member[@name="ICompositionObject2.put_Comment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Comment(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject2*, HSTRING, int>)(lpVtbl[7]))((ICompositionObject2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionObject2.xml' path='doc/member[@name="ICompositionObject2.get_ImplicitAnimations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ImplicitAnimations([NativeTypeName("ABI::Windows::UI::Composition::IImplicitAnimationCollection **")] IImplicitAnimationCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject2*, IImplicitAnimationCollection**, int>)(lpVtbl[8]))((ICompositionObject2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionObject2.xml' path='doc/member[@name="ICompositionObject2.put_ImplicitAnimations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ImplicitAnimations([NativeTypeName("ABI::Windows::UI::Composition::IImplicitAnimationCollection *")] IImplicitAnimationCollection* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject2*, IImplicitAnimationCollection*, int>)(lpVtbl[9]))((ICompositionObject2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionObject2.xml' path='doc/member[@name="ICompositionObject2.StartAnimationGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StartAnimationGroup([NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationBase *")] ICompositionAnimationBase* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject2*, ICompositionAnimationBase*, int>)(lpVtbl[10]))((ICompositionObject2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionObject2.xml' path='doc/member[@name="ICompositionObject2.StopAnimationGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT StopAnimationGroup([NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationBase *")] ICompositionAnimationBase* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject2*, ICompositionAnimationBase*, int>)(lpVtbl[11]))((ICompositionObject2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Comment(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Comment(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_ImplicitAnimations([NativeTypeName("ABI::Windows::UI::Composition::IImplicitAnimationCollection **")] IImplicitAnimationCollection** value);

        [VtblIndex(9)]
        HRESULT put_ImplicitAnimations([NativeTypeName("ABI::Windows::UI::Composition::IImplicitAnimationCollection *")] IImplicitAnimationCollection* value);

        [VtblIndex(10)]
        HRESULT StartAnimationGroup([NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationBase *")] ICompositionAnimationBase* value);

        [VtblIndex(11)]
        HRESULT StopAnimationGroup([NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationBase *")] ICompositionAnimationBase* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Comment;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Comment;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IImplicitAnimationCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IImplicitAnimationCollection**, int> get_ImplicitAnimations;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IImplicitAnimationCollection *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IImplicitAnimationCollection*, int> put_ImplicitAnimations;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionAnimationBase *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionAnimationBase*, int> StartAnimationGroup;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionAnimationBase *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionAnimationBase*, int> StopAnimationGroup;
    }
}
