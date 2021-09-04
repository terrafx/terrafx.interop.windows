// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9C7-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IHlinkBrowseContext : IUnknown")]
    public unsafe partial struct IHlinkBrowseContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, Guid*, void**, int>)(lpVtbl[0]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, uint>)(lpVtbl[1]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, uint>)(lpVtbl[2]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Register([NativeTypeName("DWORD")] uint reserved, IUnknown* piunk, IMoniker* pimk, [NativeTypeName("DWORD *")] uint* pdwRegister)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, uint, IUnknown*, IMoniker*, uint*, int>)(lpVtbl[3]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), reserved, piunk, pimk, pdwRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetObjectW(IMoniker* pimk, [NativeTypeName("BOOL")] int fBindIfRootRegistered, IUnknown** ppiunk)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, IMoniker*, int, IUnknown**, int>)(lpVtbl[4]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), pimk, fBindIfRootRegistered, ppiunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Revoke([NativeTypeName("DWORD")] uint dwRegister)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, uint, int>)(lpVtbl[5]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), dwRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBrowseWindowInfo(HLBWINFO* phlbwi)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, HLBWINFO*, int>)(lpVtbl[6]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), phlbwi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBrowseWindowInfo(HLBWINFO* phlbwi)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, HLBWINFO*, int>)(lpVtbl[7]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), phlbwi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInitialHlink(IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, IMoniker*, ushort*, ushort*, int>)(lpVtbl[8]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), pimkTarget, pwzLocation, pwzFriendlyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnNavigateHlink([NativeTypeName("DWORD")] uint grfHLNF, IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName, [NativeTypeName("ULONG *")] uint* puHLID)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, uint, IMoniker*, ushort*, ushort*, uint*, int>)(lpVtbl[9]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), grfHLNF, pimkTarget, pwzLocation, pwzFriendlyName, puHLID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateHlink([NativeTypeName("ULONG")] uint uHLID, IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, uint, IMoniker*, ushort*, ushort*, int>)(lpVtbl[10]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), uHLID, pimkTarget, pwzLocation, pwzFriendlyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumNavigationStack([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint grfHLFNAMEF, IEnumHLITEM** ppienumhlitem)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, uint, uint, IEnumHLITEM**, int>)(lpVtbl[11]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), dwReserved, grfHLFNAMEF, ppienumhlitem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryHlink([NativeTypeName("DWORD")] uint grfHLQF, [NativeTypeName("ULONG")] uint uHLID)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, uint, uint, int>)(lpVtbl[12]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), grfHLQF, uHLID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHlink([NativeTypeName("ULONG")] uint uHLID, IHlink** ppihl)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, uint, IHlink**, int>)(lpVtbl[13]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), uHLID, ppihl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentHlink([NativeTypeName("ULONG")] uint uHLID)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, uint, int>)(lpVtbl[14]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), uHLID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppiunkObj)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, IUnknown*, Guid*, IUnknown**, int>)(lpVtbl[15]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), piunkOuter, riid, ppiunkObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("DWORD")] uint reserved)
        {
            return ((delegate* unmanaged<IHlinkBrowseContext*, uint, int>)(lpVtbl[16]))((IHlinkBrowseContext*)Unsafe.AsPointer(ref this), reserved);
        }
    }
}
