// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreFrameworkInputViewAnimationStartingEventArgs.xml' path='doc/member[@name="ICoreFrameworkInputViewAnimationStartingEventArgs"]/*' />
[Guid("C0EC901C-BBA4-501B-AE8B-65C9E756A719")]
[NativeTypeName("struct ICoreFrameworkInputViewAnimationStartingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreFrameworkInputViewAnimationStartingEventArgs : ICoreFrameworkInputViewAnimationStartingEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreFrameworkInputViewAnimationStartingEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewAnimationStartingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ICoreFrameworkInputViewAnimationStartingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewAnimationStartingEventArgs*, uint>)(lpVtbl[1]))((ICoreFrameworkInputViewAnimationStartingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewAnimationStartingEventArgs*, uint>)(lpVtbl[2]))((ICoreFrameworkInputViewAnimationStartingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewAnimationStartingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreFrameworkInputViewAnimationStartingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewAnimationStartingEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ICoreFrameworkInputViewAnimationStartingEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewAnimationStartingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ICoreFrameworkInputViewAnimationStartingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreFrameworkInputViewAnimationStartingEventArgs.xml' path='doc/member[@name="ICoreFrameworkInputViewAnimationStartingEventArgs.get_Occlusions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Occlusions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CViewManagement__CCore__CCoreInputViewOcclusion_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewAnimationStartingEventArgs*, IVectorView<IntPtr>**, int>)(lpVtbl[6]))((ICoreFrameworkInputViewAnimationStartingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreFrameworkInputViewAnimationStartingEventArgs.xml' path='doc/member[@name="ICoreFrameworkInputViewAnimationStartingEventArgs.get_FrameworkAnimationRecommended"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_FrameworkAnimationRecommended([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewAnimationStartingEventArgs*, byte*, int>)(lpVtbl[7]))((ICoreFrameworkInputViewAnimationStartingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreFrameworkInputViewAnimationStartingEventArgs.xml' path='doc/member[@name="ICoreFrameworkInputViewAnimationStartingEventArgs.get_AnimationDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AnimationDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreFrameworkInputViewAnimationStartingEventArgs*, TimeSpan*, int>)(lpVtbl[8]))((ICoreFrameworkInputViewAnimationStartingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Occlusions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CViewManagement__CCore__CCoreInputViewOcclusion_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(7)]
        HRESULT get_FrameworkAnimationRecommended([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_AnimationDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CViewManagement__CCore__CCoreInputViewOcclusion_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_Occlusions;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_FrameworkAnimationRecommended;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_AnimationDuration;
    }
}
