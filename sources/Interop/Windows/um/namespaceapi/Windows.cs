// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/namespaceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreatePrivateNamespaceW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpPrivateNamespaceAttributes, [NativeTypeName("LPVOID")] void* lpBoundaryDescriptor, [NativeTypeName("LPCWSTR")] ushort* lpAliasPrefix);

        [DllImport("Kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenPrivateNamespaceW([NativeTypeName("LPVOID")] void* lpBoundaryDescriptor, [NativeTypeName("LPCWSTR")] ushort* lpAliasPrefix);

        [DllImport("Kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte ClosePrivateNamespace([NativeTypeName("HANDLE")] IntPtr Handle, [NativeTypeName("ULONG")] uint Flags);

        [DllImport("Kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateBoundaryDescriptorW([NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("ULONG")] uint Flags);

        [DllImport("Kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddSIDToBoundaryDescriptor([NativeTypeName("HANDLE *")] IntPtr* BoundaryDescriptor, [NativeTypeName("PSID")] void* RequiredSid);

        [DllImport("Kernel32", ExactSpelling = true)]
        public static extern void DeleteBoundaryDescriptor([NativeTypeName("HANDLE")] IntPtr BoundaryDescriptor);

        [NativeTypeName("#define PRIVATE_NAMESPACE_FLAG_DESTROY 0x00000001")]
        public const int PRIVATE_NAMESPACE_FLAG_DESTROY = 0x00000001;
    }
}
