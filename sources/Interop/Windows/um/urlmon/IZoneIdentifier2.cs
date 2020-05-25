// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EB5E760C-09EF-45C0-B510-70830CE31E6A")]
    public unsafe partial struct IZoneIdentifier2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IZoneIdentifier2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IZoneIdentifier2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IZoneIdentifier2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetId(IZoneIdentifier2* pThis, [NativeTypeName("DWORD *")] uint* pdwZone);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetId(IZoneIdentifier2* pThis, [NativeTypeName("DWORD")] uint dwZone);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Remove(IZoneIdentifier2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLastWriterPackageFamilyName(IZoneIdentifier2* pThis, [NativeTypeName("LPWSTR *")] ushort** packageFamilyName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetLastWriterPackageFamilyName(IZoneIdentifier2* pThis, [NativeTypeName("LPCWSTR")] ushort* packageFamilyName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveLastWriterPackageFamilyName(IZoneIdentifier2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAppZoneId(IZoneIdentifier2* pThis, [NativeTypeName("DWORD *")] uint* zone);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetAppZoneId(IZoneIdentifier2* pThis, [NativeTypeName("DWORD")] uint zone);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveAppZoneId(IZoneIdentifier2* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IZoneIdentifier2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetId>(lpVtbl->GetId)((IZoneIdentifier2*)Unsafe.AsPointer(ref this), pdwZone);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("DWORD")] uint dwZone)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetId>(lpVtbl->SetId)((IZoneIdentifier2*)Unsafe.AsPointer(ref this), dwZone);
        }

        [return: NativeTypeName("HRESULT")]
        public int Remove()
        {
            return Marshal.GetDelegateForFunctionPointer<_Remove>(lpVtbl->Remove)((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastWriterPackageFamilyName([NativeTypeName("LPWSTR *")] ushort** packageFamilyName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetLastWriterPackageFamilyName>(lpVtbl->GetLastWriterPackageFamilyName)((IZoneIdentifier2*)Unsafe.AsPointer(ref this), packageFamilyName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLastWriterPackageFamilyName([NativeTypeName("LPCWSTR")] ushort* packageFamilyName)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetLastWriterPackageFamilyName>(lpVtbl->SetLastWriterPackageFamilyName)((IZoneIdentifier2*)Unsafe.AsPointer(ref this), packageFamilyName);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveLastWriterPackageFamilyName()
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveLastWriterPackageFamilyName>(lpVtbl->RemoveLastWriterPackageFamilyName)((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAppZoneId([NativeTypeName("DWORD *")] uint* zone)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAppZoneId>(lpVtbl->GetAppZoneId)((IZoneIdentifier2*)Unsafe.AsPointer(ref this), zone);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAppZoneId([NativeTypeName("DWORD")] uint zone)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetAppZoneId>(lpVtbl->SetAppZoneId)((IZoneIdentifier2*)Unsafe.AsPointer(ref this), zone);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAppZoneId()
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveAppZoneId>(lpVtbl->RemoveAppZoneId)((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetId;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr SetId;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Remove;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public IntPtr GetLastWriterPackageFamilyName;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr SetLastWriterPackageFamilyName;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr RemoveLastWriterPackageFamilyName;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetAppZoneId;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr SetAppZoneId;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr RemoveAppZoneId;
        }
    }
}
