// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("45E2B4AE-B1C3-11D0-B92F-00A0C90312E1")]
    [NativeTypeName("struct IShellLinkDataList : IUnknown")]
    public unsafe partial struct IShellLinkDataList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellLinkDataList*, Guid*, void**, int>)(lpVtbl[0]))((IShellLinkDataList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellLinkDataList*, uint>)(lpVtbl[1]))((IShellLinkDataList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellLinkDataList*, uint>)(lpVtbl[2]))((IShellLinkDataList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddDataBlock(void* pDataBlock)
        {
            return ((delegate* unmanaged<IShellLinkDataList*, void*, int>)(lpVtbl[3]))((IShellLinkDataList*)Unsafe.AsPointer(ref this), pDataBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyDataBlock([NativeTypeName("DWORD")] uint dwSig, void** ppDataBlock)
        {
            return ((delegate* unmanaged<IShellLinkDataList*, uint, void**, int>)(lpVtbl[4]))((IShellLinkDataList*)Unsafe.AsPointer(ref this), dwSig, ppDataBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveDataBlock([NativeTypeName("DWORD")] uint dwSig)
        {
            return ((delegate* unmanaged<IShellLinkDataList*, uint, int>)(lpVtbl[5]))((IShellLinkDataList*)Unsafe.AsPointer(ref this), dwSig);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IShellLinkDataList*, uint*, int>)(lpVtbl[6]))((IShellLinkDataList*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFlags([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IShellLinkDataList*, uint, int>)(lpVtbl[7]))((IShellLinkDataList*)Unsafe.AsPointer(ref this), dwFlags);
        }
    }
}
