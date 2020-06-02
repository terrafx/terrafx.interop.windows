// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA9DBF1A-C88E-4486-854A-98AA0138F30C")]
    public unsafe partial struct IDXGIDisplayControl
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXGIDisplayControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsStereoEnabled()
        {
            return lpVtbl->IsStereoEnabled((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
        }

        public void SetStereoEnabled([NativeTypeName("BOOL")] int enabled)
        {
            lpVtbl->SetStereoEnabled((IDXGIDisplayControl*)Unsafe.AsPointer(ref this), enabled);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDisplayControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDisplayControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDisplayControl*, uint> Release;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDisplayControl*, int> IsStereoEnabled;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDisplayControl*, int, void> SetStereoEnabled;
        }
    }
}
