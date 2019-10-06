// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Populates an ID2D1Mesh object with triangles.</summary>
    [Guid("2CD906C1-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1TessellationSink
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1TessellationSink* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1TessellationSink* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1TessellationSink* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _AddTriangles(ID2D1TessellationSink* This, [NativeTypeName("D2D1_TRIANGLE[]")] D2D1_TRIANGLE* triangles, [NativeTypeName("UINT32")] uint trianglesCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Close(ID2D1TessellationSink* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1TessellationSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1TessellationSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1TessellationSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void AddTriangles([NativeTypeName("D2D1_TRIANGLE[]")] D2D1_TRIANGLE* triangles, [NativeTypeName("UINT32")] uint trianglesCount)
        {
            fixed (ID2D1TessellationSink* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_AddTriangles>(lpVtbl->AddTriangles)(This, triangles, trianglesCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            fixed (ID2D1TessellationSink* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Close>(lpVtbl->Close)(This);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr AddTriangles;

            public IntPtr Close;
        }
    }
}
