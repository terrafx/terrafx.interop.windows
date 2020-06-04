// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("76A3E735-02DF-4A12-98EB-043AD3600AF3")]
    public unsafe partial struct ITypeLibRegistration
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ITypeLibRegistration*, Guid*, void**, int>)(lpVtbl[0]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ITypeLibRegistration*, uint>)(lpVtbl[1]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ITypeLibRegistration*, uint>)(lpVtbl[2]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGuid([NativeTypeName("GUID *")] Guid* pGuid)
        {
            return ((delegate* stdcall<ITypeLibRegistration*, Guid*, int>)(lpVtbl[3]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pGuid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("BSTR *")] ushort** pVersion)
        {
            return ((delegate* stdcall<ITypeLibRegistration*, ushort**, int>)(lpVtbl[4]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pVersion);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLcid([NativeTypeName("LCID *")] uint* pLcid)
        {
            return ((delegate* stdcall<ITypeLibRegistration*, uint*, int>)(lpVtbl[5]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pLcid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWin32Path([NativeTypeName("BSTR *")] ushort** pWin32Path)
        {
            return ((delegate* stdcall<ITypeLibRegistration*, ushort**, int>)(lpVtbl[6]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pWin32Path);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWin64Path([NativeTypeName("BSTR *")] ushort** pWin64Path)
        {
            return ((delegate* stdcall<ITypeLibRegistration*, ushort**, int>)(lpVtbl[7]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pWin64Path);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pDisplayName)
        {
            return ((delegate* stdcall<ITypeLibRegistration*, ushort**, int>)(lpVtbl[8]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pDisplayName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFlags([NativeTypeName("DWORD *")] uint* pFlags)
        {
            return ((delegate* stdcall<ITypeLibRegistration*, uint*, int>)(lpVtbl[9]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHelpDir([NativeTypeName("BSTR *")] ushort** pHelpDir)
        {
            return ((delegate* stdcall<ITypeLibRegistration*, ushort**, int>)(lpVtbl[10]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pHelpDir);
        }
    }
}
