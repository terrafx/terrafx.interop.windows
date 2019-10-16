// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD906C1-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1TessellationSink
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1TessellationSink* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1TessellationSink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1TessellationSink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _AddTriangles(ID2D1TessellationSink* pThis, [NativeTypeName("const D2D1_TRIANGLE *")] D2D1_TRIANGLE* triangles, [NativeTypeName("UINT32")] uint trianglesCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Close(ID2D1TessellationSink* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1TessellationSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1TessellationSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1TessellationSink*)Unsafe.AsPointer(ref this));
        }

        public void AddTriangles([NativeTypeName("const D2D1_TRIANGLE *")] D2D1_TRIANGLE* triangles, [NativeTypeName("UINT32")] uint trianglesCount)
        {
            Marshal.GetDelegateForFunctionPointer<_AddTriangles>(lpVtbl->AddTriangles)((ID2D1TessellationSink*)Unsafe.AsPointer(ref this), triangles, trianglesCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return Marshal.GetDelegateForFunctionPointer<_Close>(lpVtbl->Close)((ID2D1TessellationSink*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (const D2D1_TRIANGLE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AddTriangles;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Close;
        }
    }
}
