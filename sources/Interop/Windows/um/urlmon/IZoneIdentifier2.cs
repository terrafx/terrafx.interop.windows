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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IZoneIdentifier2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return lpVtbl->GetId((IZoneIdentifier2*)Unsafe.AsPointer(ref this), pdwZone);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("DWORD")] uint dwZone)
        {
            return lpVtbl->SetId((IZoneIdentifier2*)Unsafe.AsPointer(ref this), dwZone);
        }

        [return: NativeTypeName("HRESULT")]
        public int Remove()
        {
            return lpVtbl->Remove((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastWriterPackageFamilyName([NativeTypeName("LPWSTR *")] ushort** packageFamilyName)
        {
            return lpVtbl->GetLastWriterPackageFamilyName((IZoneIdentifier2*)Unsafe.AsPointer(ref this), packageFamilyName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLastWriterPackageFamilyName([NativeTypeName("LPCWSTR")] ushort* packageFamilyName)
        {
            return lpVtbl->SetLastWriterPackageFamilyName((IZoneIdentifier2*)Unsafe.AsPointer(ref this), packageFamilyName);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveLastWriterPackageFamilyName()
        {
            return lpVtbl->RemoveLastWriterPackageFamilyName((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAppZoneId([NativeTypeName("DWORD *")] uint* zone)
        {
            return lpVtbl->GetAppZoneId((IZoneIdentifier2*)Unsafe.AsPointer(ref this), zone);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAppZoneId([NativeTypeName("DWORD")] uint zone)
        {
            return lpVtbl->SetAppZoneId((IZoneIdentifier2*)Unsafe.AsPointer(ref this), zone);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAppZoneId()
        {
            return lpVtbl->RemoveAppZoneId((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IZoneIdentifier2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IZoneIdentifier2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IZoneIdentifier2*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IZoneIdentifier2*, uint*, int> GetId;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IZoneIdentifier2*, uint, int> SetId;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IZoneIdentifier2*, int> Remove;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IZoneIdentifier2*, ushort**, int> GetLastWriterPackageFamilyName;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IZoneIdentifier2*, ushort*, int> SetLastWriterPackageFamilyName;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IZoneIdentifier2*, int> RemoveLastWriterPackageFamilyName;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IZoneIdentifier2*, uint*, int> GetAppZoneId;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IZoneIdentifier2*, uint, int> SetAppZoneId;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IZoneIdentifier2*, int> RemoveAppZoneId;
        }
    }
}
