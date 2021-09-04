// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B722BCC7-4E68-101B-A2BC-00AA00404770")]
    [NativeTypeName("struct IOleDocumentSite : IUnknown")]
    public unsafe partial struct IOleDocumentSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleDocumentSite*, Guid*, void**, int>)(lpVtbl[0]))((IOleDocumentSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleDocumentSite*, uint>)(lpVtbl[1]))((IOleDocumentSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleDocumentSite*, uint>)(lpVtbl[2]))((IOleDocumentSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateMe(IOleDocumentView* pViewToActivate)
        {
            return ((delegate* unmanaged<IOleDocumentSite*, IOleDocumentView*, int>)(lpVtbl[3]))((IOleDocumentSite*)Unsafe.AsPointer(ref this), pViewToActivate);
        }
    }
}
