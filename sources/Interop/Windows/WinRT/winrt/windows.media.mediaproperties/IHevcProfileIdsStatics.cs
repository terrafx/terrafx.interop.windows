// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics"]/*' />
[Guid("1E50D280-2AA7-53C1-973F-2189FA656F53")]
[NativeTypeName("struct IHevcProfileIdsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHevcProfileIdsStatics : IHevcProfileIdsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHevcProfileIdsStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, uint>)(lpVtbl[1]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, uint>)(lpVtbl[2]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, HSTRING*, int>)(lpVtbl[4]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainChromaSubsampling420BitDepth8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MainChromaSubsampling420BitDepth8([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[6]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainChromaSubsampling420BitDepth10"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MainChromaSubsampling420BitDepth10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[7]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainChromaSubsampling420BitDepth12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MainChromaSubsampling420BitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[8]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainChromaSubsampling422BitDepth10"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MainChromaSubsampling422BitDepth10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[9]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainChromaSubsampling422BitDepth12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MainChromaSubsampling422BitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[10]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainChromaSubsampling444BitDepth8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MainChromaSubsampling444BitDepth8([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[11]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainChromaSubsampling444BitDepth10"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MainChromaSubsampling444BitDepth10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[12]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainChromaSubsampling444BitDepth12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MainChromaSubsampling444BitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[13]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MonochromeBitDepth12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_MonochromeBitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[14]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MonochromeBitDepth16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_MonochromeBitDepth16([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[15]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainIntraChromaSubsampling420BitDepth8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_MainIntraChromaSubsampling420BitDepth8([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[16]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainIntraChromaSubsampling420BitDepth10"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_MainIntraChromaSubsampling420BitDepth10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[17]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainIntraChromaSubsampling420BitDepth12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_MainIntraChromaSubsampling420BitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[18]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainIntraChromaSubsampling422BitDepth10"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_MainIntraChromaSubsampling422BitDepth10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[19]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainIntraChromaSubsampling422BitDepth12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_MainIntraChromaSubsampling422BitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[20]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainIntraChromaSubsampling444BitDepth8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_MainIntraChromaSubsampling444BitDepth8([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[21]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainIntraChromaSubsampling444BitDepth10"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_MainIntraChromaSubsampling444BitDepth10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[22]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainIntraChromaSubsampling444BitDepth12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_MainIntraChromaSubsampling444BitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[23]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainIntraChromaSubsampling444BitDepth16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_MainIntraChromaSubsampling444BitDepth16([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[24]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainStillChromaSubsampling420BitDepth8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_MainStillChromaSubsampling420BitDepth8([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[25]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainStillChromaSubsampling444BitDepth8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_MainStillChromaSubsampling444BitDepth8([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[26]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHevcProfileIdsStatics.xml' path='doc/member[@name="IHevcProfileIdsStatics.get_MainStillChromaSubsampling444BitDepth16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_MainStillChromaSubsampling444BitDepth16([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHevcProfileIdsStatics*, int*, int>)(lpVtbl[27]))((IHevcProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MainChromaSubsampling420BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_MainChromaSubsampling420BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_MainChromaSubsampling420BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(9)]
        HRESULT get_MainChromaSubsampling422BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(10)]
        HRESULT get_MainChromaSubsampling422BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(11)]
        HRESULT get_MainChromaSubsampling444BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(12)]
        HRESULT get_MainChromaSubsampling444BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT get_MainChromaSubsampling444BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(14)]
        HRESULT get_MonochromeBitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(15)]
        HRESULT get_MonochromeBitDepth16([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(16)]
        HRESULT get_MainIntraChromaSubsampling420BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(17)]
        HRESULT get_MainIntraChromaSubsampling420BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(18)]
        HRESULT get_MainIntraChromaSubsampling420BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(19)]
        HRESULT get_MainIntraChromaSubsampling422BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(20)]
        HRESULT get_MainIntraChromaSubsampling422BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(21)]
        HRESULT get_MainIntraChromaSubsampling444BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(22)]
        HRESULT get_MainIntraChromaSubsampling444BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(23)]
        HRESULT get_MainIntraChromaSubsampling444BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(24)]
        HRESULT get_MainIntraChromaSubsampling444BitDepth16([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(25)]
        HRESULT get_MainStillChromaSubsampling420BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(26)]
        HRESULT get_MainStillChromaSubsampling444BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(27)]
        HRESULT get_MainStillChromaSubsampling444BitDepth16([NativeTypeName("INT32 *")] int* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainChromaSubsampling420BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainChromaSubsampling422BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainChromaSubsampling422BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainChromaSubsampling444BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainChromaSubsampling444BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainChromaSubsampling444BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MonochromeBitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MonochromeBitDepth16;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainIntraChromaSubsampling420BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainIntraChromaSubsampling420BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainIntraChromaSubsampling420BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainIntraChromaSubsampling422BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainIntraChromaSubsampling422BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainIntraChromaSubsampling444BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainIntraChromaSubsampling444BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainIntraChromaSubsampling444BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainIntraChromaSubsampling444BitDepth16;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainStillChromaSubsampling420BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainStillChromaSubsampling444BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MainStillChromaSubsampling444BitDepth16;
    }
}
