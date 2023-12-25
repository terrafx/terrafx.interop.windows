// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionObjectStatics.xml' path='doc/member[@name="ICompositionObjectStatics"]/*' />
[Guid("C1ED052F-1BA2-44BA-A904-6A882A0A5ADB")]
[NativeTypeName("struct ICompositionObjectStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionObjectStatics : ICompositionObjectStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionObjectStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObjectStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionObjectStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObjectStatics*, uint>)(lpVtbl[1]))((ICompositionObjectStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObjectStatics*, uint>)(lpVtbl[2]))((ICompositionObjectStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObjectStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionObjectStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObjectStatics*, HSTRING*, int>)(lpVtbl[4]))((ICompositionObjectStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObjectStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionObjectStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionObjectStatics.xml' path='doc/member[@name="ICompositionObjectStatics.StartAnimationWithIAnimationObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StartAnimationWithIAnimationObject([NativeTypeName("ABI::Windows::UI::Composition::IAnimationObject *")] IAnimationObject* target, HSTRING propertyName, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimation *")] ICompositionAnimation* animation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObjectStatics*, IAnimationObject*, HSTRING, ICompositionAnimation*, int>)(lpVtbl[6]))((ICompositionObjectStatics*)Unsafe.AsPointer(ref this), target, propertyName, animation);
    }

    /// <include file='ICompositionObjectStatics.xml' path='doc/member[@name="ICompositionObjectStatics.StartAnimationGroupWithIAnimationObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT StartAnimationGroupWithIAnimationObject([NativeTypeName("ABI::Windows::UI::Composition::IAnimationObject *")] IAnimationObject* target, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationBase *")] ICompositionAnimationBase* animation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObjectStatics*, IAnimationObject*, ICompositionAnimationBase*, int>)(lpVtbl[7]))((ICompositionObjectStatics*)Unsafe.AsPointer(ref this), target, animation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT StartAnimationWithIAnimationObject([NativeTypeName("ABI::Windows::UI::Composition::IAnimationObject *")] IAnimationObject* target, HSTRING propertyName, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimation *")] ICompositionAnimation* animation);

        [VtblIndex(7)]
        HRESULT StartAnimationGroupWithIAnimationObject([NativeTypeName("ABI::Windows::UI::Composition::IAnimationObject *")] IAnimationObject* target, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationBase *")] ICompositionAnimationBase* animation);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IAnimationObject *, HSTRING, ABI::Windows::UI::Composition::ICompositionAnimation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAnimationObject*, HSTRING, ICompositionAnimation*, int> StartAnimationWithIAnimationObject;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IAnimationObject *, ABI::Windows::UI::Composition::ICompositionAnimationBase *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAnimationObject*, ICompositionAnimationBase*, int> StartAnimationGroupWithIAnimationObject;
    }
}
