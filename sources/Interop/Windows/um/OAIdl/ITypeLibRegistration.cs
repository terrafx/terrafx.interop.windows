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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ITypeLibRegistration* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ITypeLibRegistration* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ITypeLibRegistration* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGuid(ITypeLibRegistration* pThis, [NativeTypeName("GUID *")] Guid* pGuid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVersion(ITypeLibRegistration* pThis, [NativeTypeName("BSTR *")] ushort** pVersion);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLcid(ITypeLibRegistration* pThis, [NativeTypeName("LCID *")] uint* pLcid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWin32Path(ITypeLibRegistration* pThis, [NativeTypeName("BSTR *")] ushort** pWin32Path);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWin64Path(ITypeLibRegistration* pThis, [NativeTypeName("BSTR *")] ushort** pWin64Path);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplayName(ITypeLibRegistration* pThis, [NativeTypeName("BSTR *")] ushort** pDisplayName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFlags(ITypeLibRegistration* pThis, [NativeTypeName("DWORD *")] uint* pFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetHelpDir(ITypeLibRegistration* pThis, [NativeTypeName("BSTR *")] ushort** pHelpDir);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ITypeLibRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ITypeLibRegistration*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ITypeLibRegistration*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGuid([NativeTypeName("GUID *")] Guid* pGuid)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGuid>(lpVtbl->GetGuid)((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pGuid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("BSTR *")] ushort** pVersion)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVersion>(lpVtbl->GetVersion)((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pVersion);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLcid([NativeTypeName("LCID *")] uint* pLcid)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLcid>(lpVtbl->GetLcid)((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pLcid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWin32Path([NativeTypeName("BSTR *")] ushort** pWin32Path)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWin32Path>(lpVtbl->GetWin32Path)((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pWin32Path);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWin64Path([NativeTypeName("BSTR *")] ushort** pWin64Path)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWin64Path>(lpVtbl->GetWin64Path)((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pWin64Path);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pDisplayName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDisplayName>(lpVtbl->GetDisplayName)((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pDisplayName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFlags([NativeTypeName("DWORD *")] uint* pFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFlags>(lpVtbl->GetFlags)((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHelpDir([NativeTypeName("BSTR *")] ushort** pHelpDir)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetHelpDir>(lpVtbl->GetHelpDir)((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pHelpDir);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public IntPtr GetGuid;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetVersion;

            [NativeTypeName("HRESULT (LCID *) __attribute__((stdcall))")]
            public IntPtr GetLcid;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetWin32Path;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetWin64Path;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetDisplayName;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetFlags;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetHelpDir;
        }
    }
}
