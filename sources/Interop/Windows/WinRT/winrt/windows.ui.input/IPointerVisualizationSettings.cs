// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPointerVisualizationSettings.xml' path='doc/member[@name="IPointerVisualizationSettings"]/*' />
[Guid("4D1E6461-84F7-499D-BD91-2A36E2B7AAA2")]
[NativeTypeName("struct IPointerVisualizationSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPointerVisualizationSettings : IPointerVisualizationSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPointerVisualizationSettings);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerVisualizationSettings*, Guid*, void**, int>)(lpVtbl[0]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerVisualizationSettings*, uint>)(lpVtbl[1]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerVisualizationSettings*, uint>)(lpVtbl[2]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerVisualizationSettings*, uint*, Guid**, int>)(lpVtbl[3]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerVisualizationSettings*, HSTRING*, int>)(lpVtbl[4]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerVisualizationSettings*, TrustLevel*, int>)(lpVtbl[5]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPointerVisualizationSettings.xml' path='doc/member[@name="IPointerVisualizationSettings.put_IsContactFeedbackEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_IsContactFeedbackEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerVisualizationSettings*, byte, int>)(lpVtbl[6]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerVisualizationSettings.xml' path='doc/member[@name="IPointerVisualizationSettings.get_IsContactFeedbackEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsContactFeedbackEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerVisualizationSettings*, byte*, int>)(lpVtbl[7]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerVisualizationSettings.xml' path='doc/member[@name="IPointerVisualizationSettings.put_IsBarrelButtonFeedbackEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_IsBarrelButtonFeedbackEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerVisualizationSettings*, byte, int>)(lpVtbl[8]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerVisualizationSettings.xml' path='doc/member[@name="IPointerVisualizationSettings.get_IsBarrelButtonFeedbackEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsBarrelButtonFeedbackEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerVisualizationSettings*, byte*, int>)(lpVtbl[9]))((IPointerVisualizationSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_IsContactFeedbackEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT get_IsContactFeedbackEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_IsBarrelButtonFeedbackEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT get_IsBarrelButtonFeedbackEnabled([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsContactFeedbackEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsContactFeedbackEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsBarrelButtonFeedbackEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsBarrelButtonFeedbackEnabled;
    }
}
