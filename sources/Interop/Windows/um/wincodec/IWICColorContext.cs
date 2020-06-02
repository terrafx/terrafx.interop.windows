// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3C613A02-34B2-44EA-9A7C-45AEA9C6FD6D")]
    public unsafe partial struct IWICColorContext
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICColorContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICColorContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICColorContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename)
        {
            return lpVtbl->InitializeFromFilename((IWICColorContext*)Unsafe.AsPointer(ref this), wzFilename);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromMemory([NativeTypeName("const BYTE *")] byte* pbBuffer, [NativeTypeName("UINT")] uint cbBufferSize)
        {
            return lpVtbl->InitializeFromMemory((IWICColorContext*)Unsafe.AsPointer(ref this), pbBuffer, cbBufferSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromExifColorSpace([NativeTypeName("UINT")] uint value)
        {
            return lpVtbl->InitializeFromExifColorSpace((IWICColorContext*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("WICColorContextType *")] WICColorContextType* pType)
        {
            return lpVtbl->GetType((IWICColorContext*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProfileBytes([NativeTypeName("UINT")] uint cbBuffer, [NativeTypeName("BYTE *")] byte* pbBuffer, [NativeTypeName("UINT *")] uint* pcbActual)
        {
            return lpVtbl->GetProfileBytes((IWICColorContext*)Unsafe.AsPointer(ref this), cbBuffer, pbBuffer, pcbActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExifColorSpace([NativeTypeName("UINT *")] uint* pValue)
        {
            return lpVtbl->GetExifColorSpace((IWICColorContext*)Unsafe.AsPointer(ref this), pValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICColorContext*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICColorContext*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICColorContext*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IWICColorContext*, ushort*, int> InitializeFromFilename;

            [NativeTypeName("HRESULT (const BYTE *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IWICColorContext*, byte*, uint, int> InitializeFromMemory;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IWICColorContext*, uint, int> InitializeFromExifColorSpace;

            [NativeTypeName("HRESULT (WICColorContextType *) __attribute__((stdcall))")]
            public new delegate* stdcall<IWICColorContext*, WICColorContextType*, int> GetType;

            [NativeTypeName("HRESULT (UINT, BYTE *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICColorContext*, uint, byte*, uint*, int> GetProfileBytes;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICColorContext*, uint*, int> GetExifColorSpace;
        }
    }
}
