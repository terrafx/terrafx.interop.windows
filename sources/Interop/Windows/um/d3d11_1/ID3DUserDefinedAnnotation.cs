// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B2DAAD8B-03D4-4DBF-95EB-32AB4B63D0AB")]
    public unsafe partial struct ID3DUserDefinedAnnotation
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("INT")]
        public int BeginEvent([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return lpVtbl->BeginEvent((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("INT")]
        public int EndEvent()
        {
            return lpVtbl->EndEvent((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        public void SetMarker([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            lpVtbl->SetMarker((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("BOOL")]
        public int GetStatus()
        {
            return lpVtbl->GetStatus((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3DUserDefinedAnnotation*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3DUserDefinedAnnotation*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3DUserDefinedAnnotation*, uint> Release;

            [NativeTypeName("INT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ID3DUserDefinedAnnotation*, ushort*, int> BeginEvent;

            [NativeTypeName("INT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3DUserDefinedAnnotation*, int> EndEvent;

            [NativeTypeName("void (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ID3DUserDefinedAnnotation*, ushort*, void> SetMarker;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* stdcall<ID3DUserDefinedAnnotation*, int> GetStatus;
        }
    }
}
