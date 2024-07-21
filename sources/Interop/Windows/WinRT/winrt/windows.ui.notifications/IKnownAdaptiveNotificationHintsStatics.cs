// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKnownAdaptiveNotificationHintsStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationHintsStatics"]/*' />
[Guid("06206598-D496-497D-8692-4F7D7C2770DF")]
[NativeTypeName("struct IKnownAdaptiveNotificationHintsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKnownAdaptiveNotificationHintsStatics : IKnownAdaptiveNotificationHintsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKnownAdaptiveNotificationHintsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationHintsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKnownAdaptiveNotificationHintsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationHintsStatics*, uint>)(lpVtbl[1]))((IKnownAdaptiveNotificationHintsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationHintsStatics*, uint>)(lpVtbl[2]))((IKnownAdaptiveNotificationHintsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationHintsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownAdaptiveNotificationHintsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationHintsStatics*, HSTRING*, int>)(lpVtbl[4]))((IKnownAdaptiveNotificationHintsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationHintsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKnownAdaptiveNotificationHintsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKnownAdaptiveNotificationHintsStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationHintsStatics.get_Style"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Style(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationHintsStatics*, HSTRING*, int>)(lpVtbl[6]))((IKnownAdaptiveNotificationHintsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationHintsStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationHintsStatics.get_Wrap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Wrap(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationHintsStatics*, HSTRING*, int>)(lpVtbl[7]))((IKnownAdaptiveNotificationHintsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationHintsStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationHintsStatics.get_MaxLines"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxLines(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationHintsStatics*, HSTRING*, int>)(lpVtbl[8]))((IKnownAdaptiveNotificationHintsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationHintsStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationHintsStatics.get_MinLines"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MinLines(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationHintsStatics*, HSTRING*, int>)(lpVtbl[9]))((IKnownAdaptiveNotificationHintsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationHintsStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationHintsStatics.get_TextStacking"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_TextStacking(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationHintsStatics*, HSTRING*, int>)(lpVtbl[10]))((IKnownAdaptiveNotificationHintsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationHintsStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationHintsStatics.get_Align"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Align(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationHintsStatics*, HSTRING*, int>)(lpVtbl[11]))((IKnownAdaptiveNotificationHintsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Style(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Wrap(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_MaxLines(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_MinLines(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_TextStacking(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Align(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Style;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Wrap;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MaxLines;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MinLines;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TextStacking;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Align;
    }
}
