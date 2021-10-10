// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("11A66EFA-382E-451A-9234-1E0E12EF3085")]
    [NativeTypeName("struct IShellLibrary : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellLibrary
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellLibrary*, Guid*, void**, int>)(lpVtbl[0]))((IShellLibrary*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellLibrary*, uint>)(lpVtbl[1]))((IShellLibrary*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellLibrary*, uint>)(lpVtbl[2]))((IShellLibrary*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int LoadLibraryFromItem(IShellItem* psiLibrary, [NativeTypeName("DWORD")] uint grfMode)
        {
            return ((delegate* unmanaged<IShellLibrary*, IShellItem*, uint, int>)(lpVtbl[3]))((IShellLibrary*)Unsafe.AsPointer(ref this), psiLibrary, grfMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int LoadLibraryFromKnownFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* kfidLibrary, [NativeTypeName("DWORD")] uint grfMode)
        {
            return ((delegate* unmanaged<IShellLibrary*, Guid*, uint, int>)(lpVtbl[4]))((IShellLibrary*)Unsafe.AsPointer(ref this), kfidLibrary, grfMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int AddFolder(IShellItem* psiLocation)
        {
            return ((delegate* unmanaged<IShellLibrary*, IShellItem*, int>)(lpVtbl[5]))((IShellLibrary*)Unsafe.AsPointer(ref this), psiLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveFolder(IShellItem* psiLocation)
        {
            return ((delegate* unmanaged<IShellLibrary*, IShellItem*, int>)(lpVtbl[6]))((IShellLibrary*)Unsafe.AsPointer(ref this), psiLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetFolders(LIBRARYFOLDERFILTER lff, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellLibrary*, LIBRARYFOLDERFILTER, Guid*, void**, int>)(lpVtbl[7]))((IShellLibrary*)Unsafe.AsPointer(ref this), lff, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int ResolveFolder(IShellItem* psiFolderToResolve, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellLibrary*, IShellItem*, uint, Guid*, void**, int>)(lpVtbl[8]))((IShellLibrary*)Unsafe.AsPointer(ref this), psiFolderToResolve, dwTimeout, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultSaveFolder(DEFAULTSAVEFOLDERTYPE dsft, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellLibrary*, DEFAULTSAVEFOLDERTYPE, Guid*, void**, int>)(lpVtbl[9]))((IShellLibrary*)Unsafe.AsPointer(ref this), dsft, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultSaveFolder(DEFAULTSAVEFOLDERTYPE dsft, IShellItem* psi)
        {
            return ((delegate* unmanaged<IShellLibrary*, DEFAULTSAVEFOLDERTYPE, IShellItem*, int>)(lpVtbl[10]))((IShellLibrary*)Unsafe.AsPointer(ref this), dsft, psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetOptions(LIBRARYOPTIONFLAGS* plofOptions)
        {
            return ((delegate* unmanaged<IShellLibrary*, LIBRARYOPTIONFLAGS*, int>)(lpVtbl[11]))((IShellLibrary*)Unsafe.AsPointer(ref this), plofOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int SetOptions(LIBRARYOPTIONFLAGS lofMask, LIBRARYOPTIONFLAGS lofOptions)
        {
            return ((delegate* unmanaged<IShellLibrary*, LIBRARYOPTIONFLAGS, LIBRARYOPTIONFLAGS, int>)(lpVtbl[12]))((IShellLibrary*)Unsafe.AsPointer(ref this), lofMask, lofOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetFolderType([NativeTypeName("FOLDERTYPEID *")] Guid* pftid)
        {
            return ((delegate* unmanaged<IShellLibrary*, Guid*, int>)(lpVtbl[13]))((IShellLibrary*)Unsafe.AsPointer(ref this), pftid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetFolderType([NativeTypeName("const FOLDERTYPEID &")] Guid* ftid)
        {
            return ((delegate* unmanaged<IShellLibrary*, Guid*, int>)(lpVtbl[14]))((IShellLibrary*)Unsafe.AsPointer(ref this), ftid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetIcon([NativeTypeName("LPWSTR *")] ushort** ppszIcon)
        {
            return ((delegate* unmanaged<IShellLibrary*, ushort**, int>)(lpVtbl[15]))((IShellLibrary*)Unsafe.AsPointer(ref this), ppszIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int SetIcon([NativeTypeName("LPCWSTR")] ushort* pszIcon)
        {
            return ((delegate* unmanaged<IShellLibrary*, ushort*, int>)(lpVtbl[16]))((IShellLibrary*)Unsafe.AsPointer(ref this), pszIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* unmanaged<IShellLibrary*, int>)(lpVtbl[17]))((IShellLibrary*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int Save(IShellItem* psiFolderToSaveIn, [NativeTypeName("LPCWSTR")] ushort* pszLibraryName, LIBRARYSAVEFLAGS lsf, IShellItem** ppsiSavedTo)
        {
            return ((delegate* unmanaged<IShellLibrary*, IShellItem*, ushort*, LIBRARYSAVEFLAGS, IShellItem**, int>)(lpVtbl[18]))((IShellLibrary*)Unsafe.AsPointer(ref this), psiFolderToSaveIn, pszLibraryName, lsf, ppsiSavedTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int SaveInKnownFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* kfidToSaveIn, [NativeTypeName("LPCWSTR")] ushort* pszLibraryName, LIBRARYSAVEFLAGS lsf, IShellItem** ppsiSavedTo)
        {
            return ((delegate* unmanaged<IShellLibrary*, Guid*, ushort*, LIBRARYSAVEFLAGS, IShellItem**, int>)(lpVtbl[19]))((IShellLibrary*)Unsafe.AsPointer(ref this), kfidToSaveIn, pszLibraryName, lsf, ppsiSavedTo);
        }
    }
}
