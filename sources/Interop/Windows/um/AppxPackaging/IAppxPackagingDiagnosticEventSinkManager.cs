// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("369648FA-A7EB-4909-A15D-6954A078F18A")]
    [NativeTypeName("struct IAppxPackagingDiagnosticEventSinkManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxPackagingDiagnosticEventSinkManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager*, Guid*, void**, int>)(lpVtbl[0]))((IAppxPackagingDiagnosticEventSinkManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager*, uint>)(lpVtbl[1]))((IAppxPackagingDiagnosticEventSinkManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager*, uint>)(lpVtbl[2]))((IAppxPackagingDiagnosticEventSinkManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetSinkForProcess(IAppxPackagingDiagnosticEventSink* sink)
        {
            return ((delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager*, IAppxPackagingDiagnosticEventSink*, int>)(lpVtbl[3]))((IAppxPackagingDiagnosticEventSinkManager*)Unsafe.AsPointer(ref this), sink);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager*, uint> Release;

            [NativeTypeName("HRESULT (IAppxPackagingDiagnosticEventSink *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxPackagingDiagnosticEventSinkManager*, IAppxPackagingDiagnosticEventSink*, int> SetSinkForProcess;
        }
    }
}
