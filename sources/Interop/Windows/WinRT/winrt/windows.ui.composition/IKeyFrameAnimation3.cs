// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyFrameAnimation3.xml' path='doc/member[@name="IKeyFrameAnimation3"]/*' />
[Guid("845BF0B4-D8DE-462F-8753-C80D43C6FF5A")]
[NativeTypeName("struct IKeyFrameAnimation3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyFrameAnimation3 : IKeyFrameAnimation3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKeyFrameAnimation3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyFrameAnimation3*, Guid*, void**, int>)(lpVtbl[0]))((IKeyFrameAnimation3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyFrameAnimation3*, uint>)(lpVtbl[1]))((IKeyFrameAnimation3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyFrameAnimation3*, uint>)(lpVtbl[2]))((IKeyFrameAnimation3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyFrameAnimation3*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyFrameAnimation3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyFrameAnimation3*, HSTRING*, int>)(lpVtbl[4]))((IKeyFrameAnimation3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyFrameAnimation3*, TrustLevel*, int>)(lpVtbl[5]))((IKeyFrameAnimation3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyFrameAnimation3.xml' path='doc/member[@name="IKeyFrameAnimation3.get_DelayBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DelayBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationDelayBehavior *")] AnimationDelayBehavior* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyFrameAnimation3*, AnimationDelayBehavior*, int>)(lpVtbl[6]))((IKeyFrameAnimation3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyFrameAnimation3.xml' path='doc/member[@name="IKeyFrameAnimation3.put_DelayBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DelayBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationDelayBehavior")] AnimationDelayBehavior value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyFrameAnimation3*, AnimationDelayBehavior, int>)(lpVtbl[7]))((IKeyFrameAnimation3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DelayBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationDelayBehavior *")] AnimationDelayBehavior* value);

        [VtblIndex(7)]
        HRESULT put_DelayBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationDelayBehavior")] AnimationDelayBehavior value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::AnimationDelayBehavior *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AnimationDelayBehavior*, int> get_DelayBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::AnimationDelayBehavior) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AnimationDelayBehavior, int> put_DelayBehavior;
    }
}
