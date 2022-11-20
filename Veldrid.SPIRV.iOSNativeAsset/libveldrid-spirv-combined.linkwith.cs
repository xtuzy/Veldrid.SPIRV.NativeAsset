using System;
using ObjCRuntime;

[assembly: LinkWith("libveldrid-spirv-combined.a", LinkTarget.Arm64, SmartLink = true, ForceLoad = true)]
