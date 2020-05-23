// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("711C7600-6B48-11D1-B403-00AA00B92AF1")]
    public unsafe partial struct ICatalogFileInfo
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ICatalogFileInfo* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ICatalogFileInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ICatalogFileInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCatalogFile(ICatalogFileInfo* pThis, [NativeTypeName("LPSTR *")] sbyte** ppszCatalogFile);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetJavaTrust(ICatalogFileInfo* pThis, [NativeTypeName("void **")] void** ppJavaTrust);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ICatalogFileInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ICatalogFileInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ICatalogFileInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCatalogFile([NativeTypeName("LPSTR *")] sbyte** ppszCatalogFile)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCatalogFile>(lpVtbl->GetCatalogFile)((ICatalogFileInfo*)Unsafe.AsPointer(ref this), ppszCatalogFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetJavaTrust([NativeTypeName("void **")] void** ppJavaTrust)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetJavaTrust>(lpVtbl->GetJavaTrust)((ICatalogFileInfo*)Unsafe.AsPointer(ref this), ppJavaTrust);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPSTR *) __attribute__((stdcall))")]
            public IntPtr GetCatalogFile;

            [NativeTypeName("HRESULT (void **) __attribute__((stdcall))")]
            public IntPtr GetJavaTrust;
        }
    }
}
