// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F25362EA-2C0E-447F-81E2-755914CDC0C3")]
    [NativeTypeName("struct IMFRelativePanelReport : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFRelativePanelReport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFRelativePanelReport*, Guid*, void**, int>)(lpVtbl[0]))((IMFRelativePanelReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFRelativePanelReport*, uint>)(lpVtbl[1]))((IMFRelativePanelReport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFRelativePanelReport*, uint>)(lpVtbl[2]))((IMFRelativePanelReport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetRelativePanel([NativeTypeName("ULONG *")] uint* panel)
        {
            return ((delegate* unmanaged<IMFRelativePanelReport*, uint*, int>)(lpVtbl[3]))((IMFRelativePanelReport*)Unsafe.AsPointer(ref this), panel);
        }
    }
}
