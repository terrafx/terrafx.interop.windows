// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaDataCallback.xml' path='doc/member[@name="IWiaDataCallback"]/*' />
[Guid("A558A866-A5B0-11D2-A08F-00C04F72DC3C")]
[NativeTypeName("struct IWiaDataCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaDataCallback : IWiaDataCallback.Interface, INativeGuid
{
    /// <include file='IWiaDataCallback.xml' path='doc/member[@name="IWiaDataCallback.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaDataCallback);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDataCallback*, Guid*, void**, int>)(lpVtbl[0]))((IWiaDataCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDataCallback*, uint>)(lpVtbl[1]))((IWiaDataCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDataCallback*, uint>)(lpVtbl[2]))((IWiaDataCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaDataCallback.xml' path='doc/member[@name="IWiaDataCallback.BandedDataCallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BandedDataCallback([NativeTypeName("LONG")] int lMessage, [NativeTypeName("LONG")] int lStatus, [NativeTypeName("LONG")] int lPercentComplete, [NativeTypeName("LONG")] int lOffset, [NativeTypeName("LONG")] int lLength, [NativeTypeName("LONG")] int lReserved, [NativeTypeName("LONG")] int lResLength, byte* pbBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDataCallback*, int, int, int, int, int, int, int, byte*, int>)(lpVtbl[3]))((IWiaDataCallback*)Unsafe.AsPointer(ref this), lMessage, lStatus, lPercentComplete, lOffset, lLength, lReserved, lResLength, pbBuffer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BandedDataCallback([NativeTypeName("LONG")] int lMessage, [NativeTypeName("LONG")] int lStatus, [NativeTypeName("LONG")] int lPercentComplete, [NativeTypeName("LONG")] int lOffset, [NativeTypeName("LONG")] int lLength, [NativeTypeName("LONG")] int lReserved, [NativeTypeName("LONG")] int lResLength, byte* pbBuffer);
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

        [NativeTypeName("HRESULT (LONG, LONG, LONG, LONG, LONG, LONG, LONG, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, int, int, int, int, int, byte*, int> BandedDataCallback;
    }
}
