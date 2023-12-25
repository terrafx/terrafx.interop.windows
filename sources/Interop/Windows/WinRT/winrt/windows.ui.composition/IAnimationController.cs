// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAnimationController.xml' path='doc/member[@name="IAnimationController"]/*' />
[Guid("C934EFD2-0722-4F5F-A4E2-9510F3D43BF7")]
[NativeTypeName("struct IAnimationController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAnimationController : IAnimationController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAnimationController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationController*, Guid*, void**, int>)(lpVtbl[0]))((IAnimationController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationController*, uint>)(lpVtbl[1]))((IAnimationController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationController*, uint>)(lpVtbl[2]))((IAnimationController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationController*, uint*, Guid**, int>)(lpVtbl[3]))((IAnimationController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationController*, HSTRING*, int>)(lpVtbl[4]))((IAnimationController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationController*, TrustLevel*, int>)(lpVtbl[5]))((IAnimationController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAnimationController.xml' path='doc/member[@name="IAnimationController.get_PlaybackRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PlaybackRate(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationController*, float*, int>)(lpVtbl[6]))((IAnimationController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAnimationController.xml' path='doc/member[@name="IAnimationController.put_PlaybackRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_PlaybackRate(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationController*, float, int>)(lpVtbl[7]))((IAnimationController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAnimationController.xml' path='doc/member[@name="IAnimationController.get_Progress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Progress(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationController*, float*, int>)(lpVtbl[8]))((IAnimationController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAnimationController.xml' path='doc/member[@name="IAnimationController.put_Progress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Progress(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationController*, float, int>)(lpVtbl[9]))((IAnimationController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAnimationController.xml' path='doc/member[@name="IAnimationController.get_ProgressBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ProgressBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationControllerProgressBehavior *")] AnimationControllerProgressBehavior* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationController*, AnimationControllerProgressBehavior*, int>)(lpVtbl[10]))((IAnimationController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAnimationController.xml' path='doc/member[@name="IAnimationController.put_ProgressBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ProgressBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationControllerProgressBehavior")] AnimationControllerProgressBehavior value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationController*, AnimationControllerProgressBehavior, int>)(lpVtbl[11]))((IAnimationController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAnimationController.xml' path='doc/member[@name="IAnimationController.Pause"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationController*, int>)(lpVtbl[12]))((IAnimationController*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAnimationController.xml' path='doc/member[@name="IAnimationController.Resume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged[MemberFunction]<IAnimationController*, int>)(lpVtbl[13]))((IAnimationController*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PlaybackRate(float* value);

        [VtblIndex(7)]
        HRESULT put_PlaybackRate(float value);

        [VtblIndex(8)]
        HRESULT get_Progress(float* value);

        [VtblIndex(9)]
        HRESULT put_Progress(float value);

        [VtblIndex(10)]
        HRESULT get_ProgressBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationControllerProgressBehavior *")] AnimationControllerProgressBehavior* value);

        [VtblIndex(11)]
        HRESULT put_ProgressBehavior([NativeTypeName("ABI::Windows::UI::Composition::AnimationControllerProgressBehavior")] AnimationControllerProgressBehavior value);

        [VtblIndex(12)]
        HRESULT Pause();

        [VtblIndex(13)]
        HRESULT Resume();
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_PlaybackRate;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_PlaybackRate;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Progress;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Progress;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::AnimationControllerProgressBehavior *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AnimationControllerProgressBehavior*, int> get_ProgressBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::AnimationControllerProgressBehavior) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AnimationControllerProgressBehavior, int> put_ProgressBehavior;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Pause;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Resume;
    }
}
