// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9C4-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IHlinkTarget : IUnknown")]
    public unsafe partial struct IHlinkTarget
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHlinkTarget*, Guid*, void**, int>)(lpVtbl[0]))((IHlinkTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHlinkTarget*, uint>)(lpVtbl[1]))((IHlinkTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHlinkTarget*, uint>)(lpVtbl[2]))((IHlinkTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBrowseContext(IHlinkBrowseContext* pihlbc)
        {
            return ((delegate* unmanaged<IHlinkTarget*, IHlinkBrowseContext*, int>)(lpVtbl[3]))((IHlinkTarget*)Unsafe.AsPointer(ref this), pihlbc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBrowseContext(IHlinkBrowseContext** ppihlbc)
        {
            return ((delegate* unmanaged<IHlinkTarget*, IHlinkBrowseContext**, int>)(lpVtbl[4]))((IHlinkTarget*)Unsafe.AsPointer(ref this), ppihlbc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Navigate([NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("LPCWSTR")] ushort* pwzJumpLocation)
        {
            return ((delegate* unmanaged<IHlinkTarget*, uint, ushort*, int>)(lpVtbl[5]))((IHlinkTarget*)Unsafe.AsPointer(ref this), grfHLNF, pwzJumpLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMoniker([NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("DWORD")] uint dwAssign, IMoniker** ppimkLocation)
        {
            return ((delegate* unmanaged<IHlinkTarget*, ushort*, uint, IMoniker**, int>)(lpVtbl[6]))((IHlinkTarget*)Unsafe.AsPointer(ref this), pwzLocation, dwAssign, ppimkLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPWSTR *")] ushort** ppwzFriendlyName)
        {
            return ((delegate* unmanaged<IHlinkTarget*, ushort*, ushort**, int>)(lpVtbl[7]))((IHlinkTarget*)Unsafe.AsPointer(ref this), pwzLocation, ppwzFriendlyName);
        }
    }
}
