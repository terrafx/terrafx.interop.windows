// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='INaturalMotionAnimation.xml' path='doc/member[@name="INaturalMotionAnimation"]/*' />
[Guid("438DE12D-769B-4821-A949-284A6547E873")]
[NativeTypeName("struct INaturalMotionAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INaturalMotionAnimation : INaturalMotionAnimation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_INaturalMotionAnimation);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<INaturalMotionAnimation*, Guid*, void**, int>)(lpVtbl[0]))((INaturalMotionAnimation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<INaturalMotionAnimation*, uint>)(lpVtbl[1]))((INaturalMotionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<INaturalMotionAnimation*, uint>)(lpVtbl[2]))((INaturalMotionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<INaturalMotionAnimation*, uint*, Guid**, int>)(lpVtbl[3]))((INaturalMotionAnimation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<INaturalMotionAnimation*, HSTRING*, int>)(lpVtbl[4]))((INaturalMotionAnimation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<INaturalMotionAnimation*, TrustLevel*, int>)(lpVtbl[5]))((INaturalMotionAnimation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='INaturalMotionAnimation.xml' path='doc/member[@name="INaturalMotionAnimation.get_DelayBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DelayBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationDelayBehavior *")] AnimationDelayBehavior* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INaturalMotionAnimation*, AnimationDelayBehavior*, int>)(lpVtbl[6]))((INaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INaturalMotionAnimation.xml' path='doc/member[@name="INaturalMotionAnimation.put_DelayBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DelayBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationDelayBehavior")] AnimationDelayBehavior value)
    {
        return ((delegate* unmanaged[MemberFunction]<INaturalMotionAnimation*, AnimationDelayBehavior, int>)(lpVtbl[7]))((INaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INaturalMotionAnimation.xml' path='doc/member[@name="INaturalMotionAnimation.get_DelayTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DelayTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INaturalMotionAnimation*, TimeSpan*, int>)(lpVtbl[8]))((INaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INaturalMotionAnimation.xml' path='doc/member[@name="INaturalMotionAnimation.put_DelayTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DelayTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<INaturalMotionAnimation*, TimeSpan, int>)(lpVtbl[9]))((INaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INaturalMotionAnimation.xml' path='doc/member[@name="INaturalMotionAnimation.get_StopBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_StopBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationStopBehavior *")] AnimationStopBehavior* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INaturalMotionAnimation*, AnimationStopBehavior*, int>)(lpVtbl[10]))((INaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INaturalMotionAnimation.xml' path='doc/member[@name="INaturalMotionAnimation.put_StopBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_StopBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationStopBehavior")] AnimationStopBehavior value)
    {
        return ((delegate* unmanaged[MemberFunction]<INaturalMotionAnimation*, AnimationStopBehavior, int>)(lpVtbl[11]))((INaturalMotionAnimation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DelayBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationDelayBehavior *")] AnimationDelayBehavior* value);

        [VtblIndex(7)]
        HRESULT put_DelayBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationDelayBehavior")] AnimationDelayBehavior value);

        [VtblIndex(8)]
        HRESULT get_DelayTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        HRESULT put_DelayTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(10)]
        HRESULT get_StopBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationStopBehavior *")] AnimationStopBehavior* value);

        [VtblIndex(11)]
        HRESULT put_StopBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationStopBehavior")] AnimationStopBehavior value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_DelayTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_DelayTime;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::AnimationStopBehavior *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AnimationStopBehavior*, int> get_StopBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::AnimationStopBehavior) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AnimationStopBehavior, int> put_StopBehavior;
    }
}
