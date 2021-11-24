// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.0")]
public enum PrintDocumentPackageCompletion
{
    PrintDocumentPackageCompletion_InProgress = 0,
    PrintDocumentPackageCompletion_Completed = (PrintDocumentPackageCompletion_InProgress + 1),
    PrintDocumentPackageCompletion_Canceled = (PrintDocumentPackageCompletion_Completed + 1),
    PrintDocumentPackageCompletion_Failed = (PrintDocumentPackageCompletion_Canceled + 1),
}
