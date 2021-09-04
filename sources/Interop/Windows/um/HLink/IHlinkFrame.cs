// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9C5-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IHlinkFrame : IUnknown")]
    public unsafe partial struct IHlinkFrame
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHlinkFrame*, Guid*, void**, int>)(lpVtbl[0]))((IHlinkFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHlinkFrame*, uint>)(lpVtbl[1]))((IHlinkFrame*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHlinkFrame*, uint>)(lpVtbl[2]))((IHlinkFrame*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBrowseContext(IHlinkBrowseContext* pihlbc)
        {
            return ((delegate* unmanaged<IHlinkFrame*, IHlinkBrowseContext*, int>)(lpVtbl[3]))((IHlinkFrame*)Unsafe.AsPointer(ref this), pihlbc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBrowseContext(IHlinkBrowseContext** ppihlbc)
        {
            return ((delegate* unmanaged<IHlinkFrame*, IHlinkBrowseContext**, int>)(lpVtbl[4]))((IHlinkFrame*)Unsafe.AsPointer(ref this), ppihlbc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Navigate([NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("LPBC")] IBindCtx* pbc, IBindStatusCallback* pibsc, IHlink* pihlNavigate)
        {
            return ((delegate* unmanaged<IHlinkFrame*, uint, IBindCtx*, IBindStatusCallback*, IHlink*, int>)(lpVtbl[5]))((IHlinkFrame*)Unsafe.AsPointer(ref this), grfHLNF, pbc, pibsc, pihlNavigate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnNavigate([NativeTypeName("DWORD")] uint grfHLNF, IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName, [NativeTypeName("DWORD")] uint dwreserved)
        {
            return ((delegate* unmanaged<IHlinkFrame*, uint, IMoniker*, ushort*, ushort*, uint, int>)(lpVtbl[6]))((IHlinkFrame*)Unsafe.AsPointer(ref this), grfHLNF, pimkTarget, pwzLocation, pwzFriendlyName, dwreserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateHlink([NativeTypeName("ULONG")] uint uHLID, IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName)
        {
            return ((delegate* unmanaged<IHlinkFrame*, uint, IMoniker*, ushort*, ushort*, int>)(lpVtbl[7]))((IHlinkFrame*)Unsafe.AsPointer(ref this), uHLID, pimkTarget, pwzLocation, pwzFriendlyName);
        }
    }
}
