// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreInputViewOcclusion.xml' path='doc/member[@name="ICoreInputViewOcclusion"]/*' />
[Guid("CC36CE06-3865-4177-B5F5-8B65E0B9CE84")]
[NativeTypeName("struct ICoreInputViewOcclusion : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreInputViewOcclusion : ICoreInputViewOcclusion.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreInputViewOcclusion));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusion*, Guid*, void**, int>)(lpVtbl[0]))((ICoreInputViewOcclusion*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusion*, uint>)(lpVtbl[1]))((ICoreInputViewOcclusion*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusion*, uint>)(lpVtbl[2]))((ICoreInputViewOcclusion*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusion*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreInputViewOcclusion*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusion*, HSTRING*, int>)(lpVtbl[4]))((ICoreInputViewOcclusion*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusion*, TrustLevel*, int>)(lpVtbl[5]))((ICoreInputViewOcclusion*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreInputViewOcclusion.xml' path='doc/member[@name="ICoreInputViewOcclusion.get_OccludingRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OccludingRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusion*, Rect*, int>)(lpVtbl[6]))((ICoreInputViewOcclusion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreInputViewOcclusion.xml' path='doc/member[@name="ICoreInputViewOcclusion.get_OcclusionKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_OcclusionKind([NativeTypeName("ABI::Windows::UI::ViewManagement::Core::CoreInputViewOcclusionKind *")] CoreInputViewOcclusionKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusion*, CoreInputViewOcclusionKind*, int>)(lpVtbl[7]))((ICoreInputViewOcclusion*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OccludingRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(7)]
        HRESULT get_OcclusionKind([NativeTypeName("ABI::Windows::UI::ViewManagement::Core::CoreInputViewOcclusionKind *")] CoreInputViewOcclusionKind* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_OccludingRect;

        [NativeTypeName("HRESULT (ABI::Windows::UI::ViewManagement::Core::CoreInputViewOcclusionKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreInputViewOcclusionKind*, int> get_OcclusionKind;
    }
}
