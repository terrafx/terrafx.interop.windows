// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE")]
    [NativeTypeName("struct IShellItem : IUnknown")]
    public unsafe partial struct IShellItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellItem*, Guid*, void**, int>)(lpVtbl[0]))((IShellItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellItem*, uint>)(lpVtbl[1]))((IShellItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellItem*, uint>)(lpVtbl[2]))((IShellItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BindToHandler(IBindCtx* pbc, [NativeTypeName("const GUID &")] Guid* bhid, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellItem*, IBindCtx*, Guid*, Guid*, void**, int>)(lpVtbl[3]))((IShellItem*)Unsafe.AsPointer(ref this), pbc, bhid, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IShellItem*, IShellItem**, int>)(lpVtbl[4]))((IShellItem*)Unsafe.AsPointer(ref this), ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName(SIGDN sigdnName, [NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged<IShellItem*, SIGDN, ushort**, int>)(lpVtbl[5]))((IShellItem*)Unsafe.AsPointer(ref this), sigdnName, ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributes([NativeTypeName("SFGAOF")] uint sfgaoMask, [NativeTypeName("SFGAOF *")] uint* psfgaoAttribs)
        {
            return ((delegate* unmanaged<IShellItem*, uint, uint*, int>)(lpVtbl[6]))((IShellItem*)Unsafe.AsPointer(ref this), sfgaoMask, psfgaoAttribs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Compare(IShellItem* psi, [NativeTypeName("SICHINTF")] uint hint, int* piOrder)
        {
            return ((delegate* unmanaged<IShellItem*, IShellItem*, uint, int*, int>)(lpVtbl[7]))((IShellItem*)Unsafe.AsPointer(ref this), psi, hint, piOrder);
        }
    }
}
