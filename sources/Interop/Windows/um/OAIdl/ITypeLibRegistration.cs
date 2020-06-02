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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ITypeLibRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ITypeLibRegistration*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ITypeLibRegistration*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGuid([NativeTypeName("GUID *")] Guid* pGuid)
        {
            return lpVtbl->GetGuid((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pGuid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("BSTR *")] ushort** pVersion)
        {
            return lpVtbl->GetVersion((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pVersion);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLcid([NativeTypeName("LCID *")] uint* pLcid)
        {
            return lpVtbl->GetLcid((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pLcid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWin32Path([NativeTypeName("BSTR *")] ushort** pWin32Path)
        {
            return lpVtbl->GetWin32Path((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pWin32Path);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWin64Path([NativeTypeName("BSTR *")] ushort** pWin64Path)
        {
            return lpVtbl->GetWin64Path((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pWin64Path);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pDisplayName)
        {
            return lpVtbl->GetDisplayName((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pDisplayName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFlags([NativeTypeName("DWORD *")] uint* pFlags)
        {
            return lpVtbl->GetFlags((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHelpDir([NativeTypeName("BSTR *")] ushort** pHelpDir)
        {
            return lpVtbl->GetHelpDir((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pHelpDir);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLibRegistration*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLibRegistration*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLibRegistration*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLibRegistration*, Guid*, int> GetGuid;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLibRegistration*, ushort**, int> GetVersion;

            [NativeTypeName("HRESULT (LCID *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLibRegistration*, uint*, int> GetLcid;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLibRegistration*, ushort**, int> GetWin32Path;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLibRegistration*, ushort**, int> GetWin64Path;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLibRegistration*, ushort**, int> GetDisplayName;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLibRegistration*, uint*, int> GetFlags;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLibRegistration*, ushort**, int> GetHelpDir;
        }
    }
}
