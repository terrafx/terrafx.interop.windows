// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("241C033E-E659-43DA-AA4D-4086DBC4758D")]
[NativeTypeName("struct ITravelLogClient : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITravelLogClient : ITravelLogClient.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITravelLogClient*, Guid*, void**, int>)(lpVtbl[0]))((ITravelLogClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITravelLogClient*, uint>)(lpVtbl[1]))((ITravelLogClient*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITravelLogClient*, uint>)(lpVtbl[2]))((ITravelLogClient*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FindWindowByIndex([NativeTypeName("DWORD")] uint dwID, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<ITravelLogClient*, uint, IUnknown**, int>)(lpVtbl[3]))((ITravelLogClient*)Unsafe.AsPointer(ref this), dwID, ppunk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetWindowData(IStream* pStream, [NativeTypeName("LPWINDOWDATA")] WINDOWDATA* pWinData)
    {
        return ((delegate* unmanaged<ITravelLogClient*, IStream*, WINDOWDATA*, int>)(lpVtbl[4]))((ITravelLogClient*)Unsafe.AsPointer(ref this), pStream, pWinData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LoadHistoryPosition([NativeTypeName("LPWSTR")] ushort* pszUrlLocation, [NativeTypeName("DWORD")] uint dwPosition)
    {
        return ((delegate* unmanaged<ITravelLogClient*, ushort*, uint, int>)(lpVtbl[5]))((ITravelLogClient*)Unsafe.AsPointer(ref this), pszUrlLocation, dwPosition);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FindWindowByIndex([NativeTypeName("DWORD")] uint dwID, IUnknown** ppunk);

        [VtblIndex(4)]
        HRESULT GetWindowData(IStream* pStream, [NativeTypeName("LPWINDOWDATA")] WINDOWDATA* pWinData);

        [VtblIndex(5)]
        HRESULT LoadHistoryPosition([NativeTypeName("LPWSTR")] ushort* pszUrlLocation, [NativeTypeName("DWORD")] uint dwPosition);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (DWORD, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown**, int> FindWindowByIndex;

        [NativeTypeName("HRESULT (IStream *, LPWINDOWDATA) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, WINDOWDATA*, int> GetWindowData;

        [NativeTypeName("HRESULT (LPWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> LoadHistoryPosition;
    }
}
