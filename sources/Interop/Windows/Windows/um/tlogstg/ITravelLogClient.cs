// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ITravelLogClient.xml' path='doc/member[@name="ITravelLogClient"]/*' />
[Guid("241C033E-E659-43DA-AA4D-4086DBC4758D")]
[NativeTypeName("struct ITravelLogClient : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITravelLogClient : ITravelLogClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITravelLogClient);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITravelLogClient*, Guid*, void**, int>)(lpVtbl[0]))((ITravelLogClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITravelLogClient*, uint>)(lpVtbl[1]))((ITravelLogClient*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITravelLogClient*, uint>)(lpVtbl[2]))((ITravelLogClient*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITravelLogClient.xml' path='doc/member[@name="ITravelLogClient.FindWindowByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FindWindowByIndex([NativeTypeName("DWORD")] uint dwID, IUnknown** ppunk)
    {
        return ((delegate* unmanaged[MemberFunction]<ITravelLogClient*, uint, IUnknown**, int>)(lpVtbl[3]))((ITravelLogClient*)Unsafe.AsPointer(ref this), dwID, ppunk);
    }

    /// <include file='ITravelLogClient.xml' path='doc/member[@name="ITravelLogClient.GetWindowData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetWindowData(IStream* pStream, [NativeTypeName("LPWINDOWDATA")] WINDOWDATA* pWinData)
    {
        return ((delegate* unmanaged[MemberFunction]<ITravelLogClient*, IStream*, WINDOWDATA*, int>)(lpVtbl[4]))((ITravelLogClient*)Unsafe.AsPointer(ref this), pStream, pWinData);
    }

    /// <include file='ITravelLogClient.xml' path='doc/member[@name="ITravelLogClient.LoadHistoryPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LoadHistoryPosition([NativeTypeName("LPWSTR")] char* pszUrlLocation, [NativeTypeName("DWORD")] uint dwPosition)
    {
        return ((delegate* unmanaged[MemberFunction]<ITravelLogClient*, char*, uint, int>)(lpVtbl[5]))((ITravelLogClient*)Unsafe.AsPointer(ref this), pszUrlLocation, dwPosition);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FindWindowByIndex([NativeTypeName("DWORD")] uint dwID, IUnknown** ppunk);

        [VtblIndex(4)]
        HRESULT GetWindowData(IStream* pStream, [NativeTypeName("LPWINDOWDATA")] WINDOWDATA* pWinData);

        [VtblIndex(5)]
        HRESULT LoadHistoryPosition([NativeTypeName("LPWSTR")] char* pszUrlLocation, [NativeTypeName("DWORD")] uint dwPosition);
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

        [NativeTypeName("HRESULT (DWORD, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IUnknown**, int> FindWindowByIndex;

        [NativeTypeName("HRESULT (IStream *, LPWINDOWDATA) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, WINDOWDATA*, int> GetWindowData;

        [NativeTypeName("HRESULT (LPWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> LoadHistoryPosition;
    }
}
