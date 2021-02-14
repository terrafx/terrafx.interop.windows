// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/DocumentSource.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0B31CC62-D7EC-4747-9D6E-F2537D870F2B")]
    [NativeTypeName("struct IPrintPreviewPageCollection : IUnknown")]
    public unsafe partial struct IPrintPreviewPageCollection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPrintPreviewPageCollection*, Guid*, void**, int>)(lpVtbl[0]))((IPrintPreviewPageCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPrintPreviewPageCollection*, uint>)(lpVtbl[1]))((IPrintPreviewPageCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPrintPreviewPageCollection*, uint>)(lpVtbl[2]))((IPrintPreviewPageCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Paginate([NativeTypeName("UINT32")] uint currentJobPage, [NativeTypeName("IInspectable *")] IInspectable* printTaskOptions)
        {
            return ((delegate* unmanaged<IPrintPreviewPageCollection*, uint, IInspectable*, int>)(lpVtbl[3]))((IPrintPreviewPageCollection*)Unsafe.AsPointer(ref this), currentJobPage, printTaskOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MakePage([NativeTypeName("UINT32")] uint desiredJobPage, [NativeTypeName("FLOAT")] float width, [NativeTypeName("FLOAT")] float height)
        {
            return ((delegate* unmanaged<IPrintPreviewPageCollection*, uint, float, float, int>)(lpVtbl[4]))((IPrintPreviewPageCollection*)Unsafe.AsPointer(ref this), desiredJobPage, width, height);
        }
    }
}
