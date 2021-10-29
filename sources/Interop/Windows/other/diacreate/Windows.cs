// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from diacreate.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("msdia140", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int NoRegCoCreate([NativeTypeName("const wchar_t *")] ushort* dllName, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("msdia140", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int NoOleCoCreate([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    }
}
