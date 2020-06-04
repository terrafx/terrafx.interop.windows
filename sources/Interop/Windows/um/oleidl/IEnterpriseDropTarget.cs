// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("390E3878-FD55-4E18-819D-4682081C0CFD")]
    public unsafe partial struct IEnterpriseDropTarget
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IEnterpriseDropTarget*, Guid*, void**, int>)(lpVtbl[0]))((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IEnterpriseDropTarget*, uint>)(lpVtbl[1]))((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IEnterpriseDropTarget*, uint>)(lpVtbl[2]))((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDropSourceEnterpriseId([NativeTypeName("LPCWSTR")] ushort* identity)
        {
            return ((delegate* stdcall<IEnterpriseDropTarget*, ushort*, int>)(lpVtbl[3]))((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this), identity);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEvaluatingEdpPolicy([NativeTypeName("BOOL *")] int* value)
        {
            return ((delegate* stdcall<IEnterpriseDropTarget*, int*, int>)(lpVtbl[4]))((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this), value);
        }
    }
}
