// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAv1ProfileIdsStatics.xml' path='doc/member[@name="IAv1ProfileIdsStatics"]/*' />
[Guid("9105812B-7C09-5882-88A4-678008A5174D")]
[NativeTypeName("struct IAv1ProfileIdsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAv1ProfileIdsStatics : IAv1ProfileIdsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAv1ProfileIdsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, uint>)(lpVtbl[1]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, uint>)(lpVtbl[2]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, HSTRING*, int>)(lpVtbl[4]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAv1ProfileIdsStatics.xml' path='doc/member[@name="IAv1ProfileIdsStatics.get_MainChromaSubsampling420BitDepth8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MainChromaSubsampling420BitDepth8([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, int*, int>)(lpVtbl[6]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAv1ProfileIdsStatics.xml' path='doc/member[@name="IAv1ProfileIdsStatics.get_MainChromaSubsampling420BitDepth10"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MainChromaSubsampling420BitDepth10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, int*, int>)(lpVtbl[7]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAv1ProfileIdsStatics.xml' path='doc/member[@name="IAv1ProfileIdsStatics.get_MainChromaSubsampling400BitDepth8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MainChromaSubsampling400BitDepth8([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, int*, int>)(lpVtbl[8]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAv1ProfileIdsStatics.xml' path='doc/member[@name="IAv1ProfileIdsStatics.get_MainChromaSubsampling400BitDepth10"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MainChromaSubsampling400BitDepth10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, int*, int>)(lpVtbl[9]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAv1ProfileIdsStatics.xml' path='doc/member[@name="IAv1ProfileIdsStatics.get_HighChromaSubsampling444BitDepth8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_HighChromaSubsampling444BitDepth8([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, int*, int>)(lpVtbl[10]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAv1ProfileIdsStatics.xml' path='doc/member[@name="IAv1ProfileIdsStatics.get_HighChromaSubsampling444BitDepth10"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_HighChromaSubsampling444BitDepth10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, int*, int>)(lpVtbl[11]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAv1ProfileIdsStatics.xml' path='doc/member[@name="IAv1ProfileIdsStatics.get_ProfessionalChromaSubsampling420BitDepth12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ProfessionalChromaSubsampling420BitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, int*, int>)(lpVtbl[12]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAv1ProfileIdsStatics.xml' path='doc/member[@name="IAv1ProfileIdsStatics.get_ProfessionalChromaSubsampling400BitDepth12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ProfessionalChromaSubsampling400BitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, int*, int>)(lpVtbl[13]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAv1ProfileIdsStatics.xml' path='doc/member[@name="IAv1ProfileIdsStatics.get_ProfessionalChromaSubsampling444BitDepth12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ProfessionalChromaSubsampling444BitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, int*, int>)(lpVtbl[14]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAv1ProfileIdsStatics.xml' path='doc/member[@name="IAv1ProfileIdsStatics.get_ProfessionalChromaSubsampling422BitDepth8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ProfessionalChromaSubsampling422BitDepth8([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, int*, int>)(lpVtbl[15]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAv1ProfileIdsStatics.xml' path='doc/member[@name="IAv1ProfileIdsStatics.get_ProfessionalChromaSubsampling422BitDepth10"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ProfessionalChromaSubsampling422BitDepth10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, int*, int>)(lpVtbl[16]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAv1ProfileIdsStatics.xml' path='doc/member[@name="IAv1ProfileIdsStatics.get_ProfessionalChromaSubsampling422BitDepth12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ProfessionalChromaSubsampling422BitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAv1ProfileIdsStatics*, int*, int>)(lpVtbl[17]))((IAv1ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MainChromaSubsampling420BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_MainChromaSubsampling420BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_MainChromaSubsampling400BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(9)]
        HRESULT get_MainChromaSubsampling400BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(10)]
        HRESULT get_HighChromaSubsampling444BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(11)]
        HRESULT get_HighChromaSubsampling444BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(12)]
        HRESULT get_ProfessionalChromaSubsampling420BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT get_ProfessionalChromaSubsampling400BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(14)]
        HRESULT get_ProfessionalChromaSubsampling444BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(15)]
        HRESULT get_ProfessionalChromaSubsampling422BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(16)]
        HRESULT get_ProfessionalChromaSubsampling422BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(17)]
        HRESULT get_ProfessionalChromaSubsampling422BitDepth12([NativeTypeName("INT32 *")] int* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainChromaSubsampling420BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainChromaSubsampling420BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainChromaSubsampling400BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainChromaSubsampling400BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_HighChromaSubsampling444BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_HighChromaSubsampling444BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ProfessionalChromaSubsampling420BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ProfessionalChromaSubsampling400BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ProfessionalChromaSubsampling444BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ProfessionalChromaSubsampling422BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ProfessionalChromaSubsampling422BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ProfessionalChromaSubsampling422BitDepth12;
    }
}
