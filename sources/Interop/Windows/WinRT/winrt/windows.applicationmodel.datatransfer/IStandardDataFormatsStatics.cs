// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStandardDataFormatsStatics.xml' path='doc/member[@name="IStandardDataFormatsStatics"]/*' />
[Guid("7ED681A1-A880-40C9-B4ED-0BEE1E15F549")]
[NativeTypeName("struct IStandardDataFormatsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStandardDataFormatsStatics : IStandardDataFormatsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStandardDataFormatsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardDataFormatsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IStandardDataFormatsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardDataFormatsStatics*, uint>)(lpVtbl[1]))((IStandardDataFormatsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardDataFormatsStatics*, uint>)(lpVtbl[2]))((IStandardDataFormatsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardDataFormatsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IStandardDataFormatsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardDataFormatsStatics*, HSTRING*, int>)(lpVtbl[4]))((IStandardDataFormatsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardDataFormatsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IStandardDataFormatsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStandardDataFormatsStatics.xml' path='doc/member[@name="IStandardDataFormatsStatics.get_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardDataFormatsStatics*, HSTRING*, int>)(lpVtbl[6]))((IStandardDataFormatsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardDataFormatsStatics.xml' path='doc/member[@name="IStandardDataFormatsStatics.get_Uri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Uri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD). Instead, use WebLink or ApplicationLink.")]
    public HRESULT get_Uri(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardDataFormatsStatics*, HSTRING*, int>)(lpVtbl[7]))((IStandardDataFormatsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardDataFormatsStatics.xml' path='doc/member[@name="IStandardDataFormatsStatics.get_Html"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Html(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardDataFormatsStatics*, HSTRING*, int>)(lpVtbl[8]))((IStandardDataFormatsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardDataFormatsStatics.xml' path='doc/member[@name="IStandardDataFormatsStatics.get_Rtf"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Rtf(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardDataFormatsStatics*, HSTRING*, int>)(lpVtbl[9]))((IStandardDataFormatsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardDataFormatsStatics.xml' path='doc/member[@name="IStandardDataFormatsStatics.get_Bitmap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Bitmap(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardDataFormatsStatics*, HSTRING*, int>)(lpVtbl[10]))((IStandardDataFormatsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardDataFormatsStatics.xml' path='doc/member[@name="IStandardDataFormatsStatics.get_StorageItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_StorageItems(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardDataFormatsStatics*, HSTRING*, int>)(lpVtbl[11]))((IStandardDataFormatsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Text(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete("Uri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD). Instead, use WebLink or ApplicationLink.")]
        HRESULT get_Uri(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Html(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Rtf(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Bitmap(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_StorageItems(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Text;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("Uri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD). Instead, use WebLink or ApplicationLink.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Uri;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Html;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Rtf;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Bitmap;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_StorageItems;
    }
}
