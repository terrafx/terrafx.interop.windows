// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3ACF075F-71DB-4AFA-81F0-3FC4FDF2A5B8")]
    [NativeTypeName("struct IFileSystemBindData2 : IFileSystemBindData")]
    [NativeInheritance("IFileSystemBindData")]
    public unsafe partial struct IFileSystemBindData2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileSystemBindData2*, Guid*, void**, int>)(lpVtbl[0]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileSystemBindData2*, uint>)(lpVtbl[1]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileSystemBindData2*, uint>)(lpVtbl[2]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetFindData([NativeTypeName("const WIN32_FIND_DATAW *")] WIN32_FIND_DATAW* pfd)
        {
            return ((delegate* unmanaged<IFileSystemBindData2*, WIN32_FIND_DATAW*, int>)(lpVtbl[3]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this), pfd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetFindData(WIN32_FIND_DATAW* pfd)
        {
            return ((delegate* unmanaged<IFileSystemBindData2*, WIN32_FIND_DATAW*, int>)(lpVtbl[4]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this), pfd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetFileID(LARGE_INTEGER liFileID)
        {
            return ((delegate* unmanaged<IFileSystemBindData2*, LARGE_INTEGER, int>)(lpVtbl[5]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this), liFileID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileID(LARGE_INTEGER* pliFileID)
        {
            return ((delegate* unmanaged<IFileSystemBindData2*, LARGE_INTEGER*, int>)(lpVtbl[6]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this), pliFileID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetJunctionCLSID([NativeTypeName("const IID &")] Guid* clsid)
        {
            return ((delegate* unmanaged<IFileSystemBindData2*, Guid*, int>)(lpVtbl[7]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this), clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetJunctionCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* unmanaged<IFileSystemBindData2*, Guid*, int>)(lpVtbl[8]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this), pclsid);
        }
    }
}
