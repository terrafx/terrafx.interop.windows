// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVp9ProfileIdsStatics.xml' path='doc/member[@name="IVp9ProfileIdsStatics"]/*' />
[Guid("20311A55-FE06-5883-92D9-6080C97743E5")]
[NativeTypeName("struct IVp9ProfileIdsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVp9ProfileIdsStatics : IVp9ProfileIdsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVp9ProfileIdsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVp9ProfileIdsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IVp9ProfileIdsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVp9ProfileIdsStatics*, uint>)(lpVtbl[1]))((IVp9ProfileIdsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVp9ProfileIdsStatics*, uint>)(lpVtbl[2]))((IVp9ProfileIdsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVp9ProfileIdsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IVp9ProfileIdsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVp9ProfileIdsStatics*, HSTRING*, int>)(lpVtbl[4]))((IVp9ProfileIdsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVp9ProfileIdsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IVp9ProfileIdsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVp9ProfileIdsStatics.xml' path='doc/member[@name="IVp9ProfileIdsStatics.get_Profile0ChromaSubsampling420BitDepth8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Profile0ChromaSubsampling420BitDepth8([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVp9ProfileIdsStatics*, int*, int>)(lpVtbl[6]))((IVp9ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVp9ProfileIdsStatics.xml' path='doc/member[@name="IVp9ProfileIdsStatics.get_Profile2ChromaSubsampling420BitDepth10"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Profile2ChromaSubsampling420BitDepth10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVp9ProfileIdsStatics*, int*, int>)(lpVtbl[7]))((IVp9ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVp9ProfileIdsStatics.xml' path='doc/member[@name="IVp9ProfileIdsStatics.get_Profile2ChromaSubsampling420BitDepth12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Profile2ChromaSubsampling420BitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVp9ProfileIdsStatics*, int*, int>)(lpVtbl[8]))((IVp9ProfileIdsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Profile0ChromaSubsampling420BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_Profile2ChromaSubsampling420BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_Profile2ChromaSubsampling420BitDepth12([NativeTypeName("INT32 *")] int* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Profile0ChromaSubsampling420BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Profile2ChromaSubsampling420BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Profile2ChromaSubsampling420BitDepth12;
    }
}
