// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics"]/*' />
[Guid("202192D7-8996-45AA-8BA1-D461D72C2A1B")]
[NativeTypeName("struct IKnownAdaptiveNotificationTextStylesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKnownAdaptiveNotificationTextStylesStatics : IKnownAdaptiveNotificationTextStylesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKnownAdaptiveNotificationTextStylesStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, uint>)(lpVtbl[1]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, uint>)(lpVtbl[2]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[4]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_Caption"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Caption(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[6]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_Body"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Body(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[7]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_Base"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Base(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[8]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_Subtitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Subtitle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[9]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[10]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_Subheader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Subheader(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[11]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_Header"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Header(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[12]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_TitleNumeral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_TitleNumeral(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[13]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_SubheaderNumeral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SubheaderNumeral(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[14]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_HeaderNumeral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_HeaderNumeral(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[15]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_CaptionSubtle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_CaptionSubtle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[16]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_BodySubtle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_BodySubtle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[17]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_BaseSubtle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_BaseSubtle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[18]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_SubtitleSubtle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_SubtitleSubtle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[19]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_TitleSubtle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_TitleSubtle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[20]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_SubheaderSubtle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_SubheaderSubtle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[21]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_SubheaderNumeralSubtle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_SubheaderNumeralSubtle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[22]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_HeaderSubtle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_HeaderSubtle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[23]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownAdaptiveNotificationTextStylesStatics.xml' path='doc/member[@name="IKnownAdaptiveNotificationTextStylesStatics.get_HeaderNumeralSubtle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_HeaderNumeralSubtle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownAdaptiveNotificationTextStylesStatics*, HSTRING*, int>)(lpVtbl[24]))((IKnownAdaptiveNotificationTextStylesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Caption(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Body(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Base(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Subtitle(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Subheader(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Header(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_TitleNumeral(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_SubheaderNumeral(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_HeaderNumeral(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_CaptionSubtle(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_BodySubtle(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_BaseSubtle(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_SubtitleSubtle(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_TitleSubtle(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_SubheaderSubtle(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_SubheaderNumeralSubtle(HSTRING* value);

        [VtblIndex(23)]
        HRESULT get_HeaderSubtle(HSTRING* value);

        [VtblIndex(24)]
        HRESULT get_HeaderNumeralSubtle(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Caption;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Body;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Base;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Subtitle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Subheader;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Header;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TitleNumeral;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SubheaderNumeral;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HeaderNumeral;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CaptionSubtle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BodySubtle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_BaseSubtle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SubtitleSubtle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TitleSubtle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SubheaderSubtle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SubheaderNumeralSubtle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HeaderSubtle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HeaderNumeralSubtle;
    }
}
