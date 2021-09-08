// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3AA7AF7E-9B36-420C-A8E3-F77D4674A488")]
    [NativeTypeName("struct IKnownFolder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IKnownFolder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IKnownFolder*, Guid*, void**, int>)(lpVtbl[0]))((IKnownFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKnownFolder*, uint>)(lpVtbl[1]))((IKnownFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKnownFolder*, uint>)(lpVtbl[2]))((IKnownFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("KNOWNFOLDERID *")] Guid* pkfid)
        {
            return ((delegate* unmanaged<IKnownFolder*, Guid*, int>)(lpVtbl[3]))((IKnownFolder*)Unsafe.AsPointer(ref this), pkfid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetCategory(KF_CATEGORY* pCategory)
        {
            return ((delegate* unmanaged<IKnownFolder*, KF_CATEGORY*, int>)(lpVtbl[4]))((IKnownFolder*)Unsafe.AsPointer(ref this), pCategory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetShellItem([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IKnownFolder*, uint, Guid*, void**, int>)(lpVtbl[5]))((IKnownFolder*)Unsafe.AsPointer(ref this), dwFlags, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR *")] ushort** ppszPath)
        {
            return ((delegate* unmanaged<IKnownFolder*, uint, ushort**, int>)(lpVtbl[6]))((IKnownFolder*)Unsafe.AsPointer(ref this), dwFlags, ppszPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetPath([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pszPath)
        {
            return ((delegate* unmanaged<IKnownFolder*, uint, ushort*, int>)(lpVtbl[7]))((IKnownFolder*)Unsafe.AsPointer(ref this), dwFlags, pszPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDList([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IKnownFolder*, uint, ITEMIDLIST**, int>)(lpVtbl[8]))((IKnownFolder*)Unsafe.AsPointer(ref this), dwFlags, ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetFolderType([NativeTypeName("FOLDERTYPEID *")] Guid* pftid)
        {
            return ((delegate* unmanaged<IKnownFolder*, Guid*, int>)(lpVtbl[9]))((IKnownFolder*)Unsafe.AsPointer(ref this), pftid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetRedirectionCapabilities([NativeTypeName("KF_REDIRECTION_CAPABILITIES *")] uint* pCapabilities)
        {
            return ((delegate* unmanaged<IKnownFolder*, uint*, int>)(lpVtbl[10]))((IKnownFolder*)Unsafe.AsPointer(ref this), pCapabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetFolderDefinition(KNOWNFOLDER_DEFINITION* pKFD)
        {
            return ((delegate* unmanaged<IKnownFolder*, KNOWNFOLDER_DEFINITION*, int>)(lpVtbl[11]))((IKnownFolder*)Unsafe.AsPointer(ref this), pKFD);
        }
    }
}
