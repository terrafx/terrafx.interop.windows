// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("969DC708-5C76-11D1-8D86-0000F804B057")]
    public unsafe partial struct IThumbnailExtractor
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IThumbnailExtractor* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IThumbnailExtractor* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IThumbnailExtractor* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ExtractThumbnail(IThumbnailExtractor* pThis, [NativeTypeName("IStorage *")] IStorage* pStg, [NativeTypeName("ULONG")] uint ulLength, [NativeTypeName("ULONG")] uint ulHeight, [NativeTypeName("ULONG *")] uint* pulOutputLength, [NativeTypeName("ULONG *")] uint* pulOutputHeight, [NativeTypeName("HBITMAP *")] IntPtr* phOutputBitmap);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnFileUpdated(IThumbnailExtractor* pThis, [NativeTypeName("IStorage *")] IStorage* pStg);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IThumbnailExtractor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IThumbnailExtractor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IThumbnailExtractor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ExtractThumbnail([NativeTypeName("IStorage *")] IStorage* pStg, [NativeTypeName("ULONG")] uint ulLength, [NativeTypeName("ULONG")] uint ulHeight, [NativeTypeName("ULONG *")] uint* pulOutputLength, [NativeTypeName("ULONG *")] uint* pulOutputHeight, [NativeTypeName("HBITMAP *")] IntPtr* phOutputBitmap)
        {
            return Marshal.GetDelegateForFunctionPointer<_ExtractThumbnail>(lpVtbl->ExtractThumbnail)((IThumbnailExtractor*)Unsafe.AsPointer(ref this), pStg, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnFileUpdated([NativeTypeName("IStorage *")] IStorage* pStg)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnFileUpdated>(lpVtbl->OnFileUpdated)((IThumbnailExtractor*)Unsafe.AsPointer(ref this), pStg);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IStorage *, ULONG, ULONG, ULONG *, ULONG *, HBITMAP *) __attribute__((stdcall))")]
            public IntPtr ExtractThumbnail;

            [NativeTypeName("HRESULT (IStorage *) __attribute__((stdcall))")]
            public IntPtr OnFileUpdated;
        }
    }
}
