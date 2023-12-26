// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IH264ProfileIdsStatics.xml' path='doc/member[@name="IH264ProfileIdsStatics"]/*' />
[Guid("38654CA7-846A-4F97-A2E5-C3A15BBF70FD")]
[NativeTypeName("struct IH264ProfileIdsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IH264ProfileIdsStatics : IH264ProfileIdsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IH264ProfileIdsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, uint>)(lpVtbl[1]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, uint>)(lpVtbl[2]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, HSTRING*, int>)(lpVtbl[4]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IH264ProfileIdsStatics.xml' path='doc/member[@name="IH264ProfileIdsStatics.get_ConstrainedBaseline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ConstrainedBaseline([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, int*, int>)(lpVtbl[6]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IH264ProfileIdsStatics.xml' path='doc/member[@name="IH264ProfileIdsStatics.get_Baseline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Baseline([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, int*, int>)(lpVtbl[7]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IH264ProfileIdsStatics.xml' path='doc/member[@name="IH264ProfileIdsStatics.get_Extended"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Extended([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, int*, int>)(lpVtbl[8]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IH264ProfileIdsStatics.xml' path='doc/member[@name="IH264ProfileIdsStatics.get_Main"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Main([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, int*, int>)(lpVtbl[9]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IH264ProfileIdsStatics.xml' path='doc/member[@name="IH264ProfileIdsStatics.get_High"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_High([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, int*, int>)(lpVtbl[10]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IH264ProfileIdsStatics.xml' path='doc/member[@name="IH264ProfileIdsStatics.get_High10"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_High10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, int*, int>)(lpVtbl[11]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IH264ProfileIdsStatics.xml' path='doc/member[@name="IH264ProfileIdsStatics.get_High422"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_High422([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, int*, int>)(lpVtbl[12]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IH264ProfileIdsStatics.xml' path='doc/member[@name="IH264ProfileIdsStatics.get_High444"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_High444([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, int*, int>)(lpVtbl[13]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IH264ProfileIdsStatics.xml' path='doc/member[@name="IH264ProfileIdsStatics.get_StereoHigh"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_StereoHigh([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, int*, int>)(lpVtbl[14]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IH264ProfileIdsStatics.xml' path='doc/member[@name="IH264ProfileIdsStatics.get_MultiviewHigh"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_MultiviewHigh([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IH264ProfileIdsStatics*, int*, int>)(lpVtbl[15]))((IH264ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ConstrainedBaseline([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_Baseline([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_Extended([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(9)]
        HRESULT get_Main([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(10)]
        HRESULT get_High([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(11)]
        HRESULT get_High10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(12)]
        HRESULT get_High422([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT get_High444([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(14)]
        HRESULT get_StereoHigh([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(15)]
        HRESULT get_MultiviewHigh([NativeTypeName("INT32 *")] int* value);
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ConstrainedBaseline;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Baseline;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Extended;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Main;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_High;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_High10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_High422;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_High444;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_StereoHigh;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MultiviewHigh;
    }
}
