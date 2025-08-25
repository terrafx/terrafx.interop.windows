// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAdviseSinkEx.xml' path='doc/member[@name="IAdviseSinkEx"]/*' />
[Guid("3AF24290-0C96-11CE-A0CF-00AA00600AB8")]
[NativeTypeName("struct IAdviseSinkEx : IAdviseSink")]
[NativeInheritance("IAdviseSink")]
public unsafe partial struct IAdviseSinkEx : IAdviseSinkEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAdviseSinkEx);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdviseSinkEx*, Guid*, void**, int>)(lpVtbl[0]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdviseSinkEx*, uint>)(lpVtbl[1]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdviseSinkEx*, uint>)(lpVtbl[2]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IAdviseSink.OnDataChange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void OnDataChange(FORMATETC* pFormatetc, STGMEDIUM* pStgmed)
    {
        ((delegate* unmanaged[MemberFunction]<IAdviseSinkEx*, FORMATETC*, STGMEDIUM*, void>)(lpVtbl[3]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
    }

    /// <inheritdoc cref="IAdviseSink.OnViewChange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
    {
        ((delegate* unmanaged[MemberFunction]<IAdviseSinkEx*, uint, int, void>)(lpVtbl[4]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), dwAspect, lindex);
    }

    /// <inheritdoc cref="IAdviseSink.OnRename" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void OnRename(IMoniker* pmk)
    {
        ((delegate* unmanaged[MemberFunction]<IAdviseSinkEx*, IMoniker*, void>)(lpVtbl[5]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), pmk);
    }

    /// <inheritdoc cref="IAdviseSink.OnSave" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void OnSave()
    {
        ((delegate* unmanaged[MemberFunction]<IAdviseSinkEx*, void>)(lpVtbl[6]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IAdviseSink.OnClose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void OnClose()
    {
        ((delegate* unmanaged[MemberFunction]<IAdviseSinkEx*, void>)(lpVtbl[7]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAdviseSinkEx.xml' path='doc/member[@name="IAdviseSinkEx.OnViewStatusChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void OnViewStatusChange([NativeTypeName("DWORD")] uint dwViewStatus)
    {
        ((delegate* unmanaged[MemberFunction]<IAdviseSinkEx*, uint, void>)(lpVtbl[8]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), dwViewStatus);
    }

    public interface Interface : IAdviseSink.Interface
    {
        [VtblIndex(8)]
        void OnViewStatusChange([NativeTypeName("DWORD")] uint dwViewStatus);
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

        [NativeTypeName("void (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FORMATETC*, STGMEDIUM*, void> OnDataChange;

        [NativeTypeName("void (DWORD, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int, void> OnViewChange;

        [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMoniker*, void> OnRename;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> OnSave;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> OnClose;

        [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void> OnViewStatusChange;
    }
}
